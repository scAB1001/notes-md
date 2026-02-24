## 🚀 Part 1: Core Java (The Engine)
### Memory & Performance
- **Stack vs. Heap:** * **Stack:** Stores method calls and local variables. Fast and memory-managed automatically.
- **Heap:** Where all Objects live. Managed by the **Garbage Collector (GC)**.
- **GC Strategy:** For a betting app, mention **G1GC** or **ZGC**. These are designed for low-latency. You want to avoid "Stop-the-World" pauses where the app freezes to clean memory.
- **Strings:** Always use `StringBuilder` for modifications. `String` is immutable; `s1 + s2` creates a third object, wasting heap space.
### Collections & Concurrency
- **HashMap:** Average $O(1)$ for get/put. Uses `hashCode()` to find a bucket and `equals()` to find the exact object.
- **ConcurrentHashMap:** Essential for Fanatics. It uses **striping/bucket-level locking**. 10 threads can update 10 different users simultaneously without blocking each other.
- **Volatile:** Guarantees **visibility** (threads see the latest value) but NOT **atomicity** (it doesn't stop two threads from updating at once).

---
## 🍃 Part 2: Spring Boot (The Framework)
### Dependency Injection (DI) & Beans
- **What is a Bean?** A Java object managed by the Spring **IoC Container**.
- **IoC (Inversion of Control):** The framework handles the object lifecycle. You don't use `new`; you ask Spring for the dependency.
- **Constructor Injection:** The gold standard.
```java
// Do this (Safe, testable, final fields)
public MyService(MyRepository repo) { this.repo = repo; }
```
### Annotations Cheat Sheet
- `@RestController`: Combines `@Controller` and `@ResponseBody`. Returns JSON by default.
- `@Service` / `@Repository`: Semantic labels for beans. `@Repository` adds DB exception translation.
- `@Transactional`: (The "Money" Annotation). If an error occurs inside the method, all database changes are **rolled back**.
- `@PathVariable` vs `@RequestParam`:
- `/bet/{id}` $\rightarrow$ `PathVariable`
- `/bet?status=WON` $\rightarrow$ `RequestParam`

---
## 🏗️ Part 3: Architecture & Distributed Systems
### The "Betting Stack"
- **Kafka:** Decouples services. If the "Bonus Service" is slow, it doesn't crash the "Place Bet" service. The message just sits in a Kafka topic until processed.
- **Redis:** In-memory caching. Essential for **Live Odds**. You can't hit a SQL database 1,000 times a second for the same Man Utd vs Liverpool price.
- **Microservices:** Fanatics uses these to scale independently. The "Login Service" can have 2 instances while the "Betting Service" has 50 during the Super Bowl.

---
## 🎤 Part 4: The "Model Answer" Bank
### Q1: How do you handle a "Double Spend" (Race Condition)?
> **Model Answer:** "I avoid global synchronization because it kills performance. Instead, I use **Atomic Operations** in Java (like `AtomicLong`) or, more commonly, **Optimistic Locking** in the database using a `@Version` column. This ensures that if the data changed between the time I read it and the time I write it, the transaction fails and retries."
### Q2: Why use Microservices for a Sportsbook?
> **Model Answer:** "Scalability and Fault Tolerance. During a major event, the traffic spike is localized to the Betting and Wallet services. We can scale those specifically without wasting resources on the 'Account Settings' service. Also, if the 'Email Notification' service fails, users can still place bets."
### Q3: What is the N+1 problem in JPA?
> **Model Answer:** "It happens when you fetch a list of entities and then JPA fires an individual query for every child relationship. For example, fetching 100 bets and firing 100 queries to get the User for each. I fix this using `JOIN FETCH` in JPQL or an `EntityGraph`."

---
## 📝 Final Interview Strategy: "The Walkthrough"
When asked to code or explain a system, follow the **"RED"** rule:
1. **R**eliability: "How do I ensure this doesn't lose data?" (Transactions, Kafka).
2. **E**fficiency: "How do I ensure this is fast?" (HashMap, Caching, GC Tuning).
3. **D**ebuggability: "How do I know what happened when it breaks?" (Logging, Records for Audit).

## MCQ & Coding Patterns
**MCQ Focus:** DBMS, Time Complexity, and OS.
- **Time Complexity:** Be ready to calculate the complexity of recursive functions.
- _Tip:_ If a function splits the input in half (like Merge Sort), it’s usually $O(n \log n)$. If it’s a tree traversal visiting every node, it’s $O(n)$.
- **DBMS:** Expect questions on **Normalization** (1NF, 2NF, 3NF) and **Indexing**.
- _Fanatics Context:_ Why use an index on a `user_id` in a `bets` table? To reduce search time from $O(n)$ to $O(\log n)$ using B-Trees.

---
## 🧠 Round 2: Technical Interview Walkthroughs
### 1. Implement a Queue using Stacks
**The Question:** How do you mimic FIFO (First In, First Out) using LIFO (Last In, First Out) structures?
**The "Thinking Out Loud" Answer:** > "To implement a Queue with two stacks, I use one stack for **enqueuing** (pushing) and another for **dequeuing** (popping). When I need to dequeue, if my second stack is empty, I pop everything from the first stack and push it into the second. This reverses the order, effectively turning LIFO into FIFO."
- **Complexity:** $O(1)$ amortized for both operations.
### 2. Undo/Redo Operations
**The Question:** Which data structure is best?
**The Answer:** > "I would use **two Stacks**. The first stack stores the user's actions. When 'Undo' is pressed, we pop from the first stack and push onto the 'Redo' stack. This allows us to move back and forth through the history state efficiently."
### 3. Middle of a Linked List (The Slow-Fast Pointer)
**The Question:** Find the middle in one pass.
**The "Thinking Out Loud" Answer:**
> "I’ll use the **Tortoise and Hare** approach. I’ll have two pointers, `slow` and `fast`, both starting at the head. `slow` moves one step while `fast` moves two. By the time `fast` reaches the end of the list, `slow` will be exactly at the middle. This is $O(n)$ time and $O(1)$ space."
### 4. Next Greater Element (NGE)
**The Question:** Given an array, find the first element to the right that is greater.
**The Optimization (Stack Approach):**
> "The brute force is $O(n^2)$. To optimize to $O(n)$, I use a **Monotonic Stack**. I traverse the array from right to left. I pop elements from the stack that are smaller than the current element (because they can't be the 'next greater' for anything to the left). The top of the stack is then my NGE, and then I push the current element onto the stack."
---
## 🛠️ High-Value Coding Challenges (Likely for Fanatics)
Based on the "Trees" and "Linked List" focus you mentioned, prepare these two specific logic problems:
### A. Add 1 to a Linked List Number
**The Trick:** The "Carry" logic.
1. **Reverse** the list (e.g., $1 \rightarrow 2 \rightarrow 9$ becomes $9 \rightarrow 2 \rightarrow 1$).
2. Add 1 to the head. If it becomes 10, set it to 0 and carry 1 to the next node.
3. **Reverse** it back.
- _Why this matters:_ It tests your ability to handle **edge cases** (like $999 \rightarrow 1000$ where you need to add a new node).
### B. Tree Traversal (Level Order / Spiral)
**The Fanatics Context:** Trees are often used to represent betting market hierarchies (Sport $\rightarrow$ League $\rightarrow$ Match $\rightarrow$ Market).
- **Question:** "How would you print all betting markets for a match level by level?"
- **Answer:** "I would use **Breadth-First Search (BFS)** using a **Queue**. I push the root, then while the queue isn't empty, I pop a node, process it, and push its children."

---
## 📝 Final Interview Checklist for the Day
- **Self-Introduction:** Even if they don't ask, have a 30-second "pitch" ready that mentions your passion for high-scale Java systems.
- **Complexity:** Never give an answer without stating the **Time** and **Space** complexity ($O(n)$, $O(1)$, etc.).
- **The "Hint" Response:** If they give you a hint (like the 4th panelist did), acknowledge it: _"That's a great point, using a stack would allow us to keep track of elements we haven't found a 'greater' match for yet..."_ This shows coachability.
