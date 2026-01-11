#### Main
1. Before DS, what did we have?
2. What purpose do DS fulfil?
3. For what reasons are DS introduced?
4. What are the requirements of a DS?
5. What is the basic definition of a DS?
	A **distributed** system is a networked computer system in which processes and resources are **sufficiently** spread across multiple computers.
6.  What is the nodal definition of a DS?
	A collection of autonomous computing elements (nodes) that appears to its users as a single coherent system

	These nodes are both hardware devices and software processes (e.g. computer, car, robot). that collaborate to form the working system. They are autonomous nodes which have their own clock, ergo their own notion of time, in order to achieve synchronisation, as opposed to a global clock.
7. What is the network definition of a DS?
	A system in which components located at networked computers communicate and coordinate their actions only by passing messages.

	The collection of nodes as a whole operates the same –no matter where, when or how the interaction takes places between the user and that system.
	
	E.g. An end-user cannot tell where the computation is taking place
	Where data is stored exactly should be irrelevant to an application
	Whether or not data has been replicated is completely unknown/hidden. 
8. What is the definition of an autonomous node in a DS?
	An autonomous node in a DS, refers to the elements of a computer system, both hard ware devices and software process, that collaborate to form the working system. 
	
	They autonomous nodes have their own clock, ergo their own notion of time, in order to achieve synchronisation, as opposed to a global clock.
9. Explain why a node in a DS does not have a global clock?
10. Define the architecture of a DS.
11. Which of the following is a key characteristic of DS?
	Scalability.
12. What is the definition of a centralised system?
13. Why might we use a centralised system? Give an example scenario.
14. What is the definition of a decentralised system?
	A **decentralised** system is a networked computer system in which processes and resources are **necessarily** spread across multiple computers.
15. Why might we use a decentralised system? Give an example scenario.
	They come to being because we want to connect systems, yet may be hindered by administrative boundaries. For example, many applications in the artificial-intelligence domain require massive amounts of data for building reliable predictive models.
16. What’s the difference between a distributed and decentralised system?
17. What is the role of middleware in a DS? Give an example.
	To enable communication and coordination between different components. Middleware acts a glue..
18. Define middleware.
19. Provide an example of when a DS would be placed in a system.
20. Explain what is meant by the term 'distribution transparency' and provide examples.
21. Describe the integrative view of a DS.
	Connecting existing networked computer systems into a larger a system.
22. Describe the expansive view of a DS.
	An existing networked computer system is extended with additional computers.
23. What is the definition of federated learning?
	Federated learning describes the method of building reliable predictive AI models, typically in a decentralised system.
	Usually, HPC would be used to train these models but when data must remain within the organisation, the training is, instead, brought to the data.  
24. Describe some common challenges of a DS.
	Architecture: common organisations, common styles
	Process: what kind of processes, and their relationships
	Communication: facilities for exchanging data
	Coordination: application-independent algorithms
	Naming: how do you identify resources?
	Consistency and replication: performance requires of data, which need to be the same
	Fault tolerance: keep running in the presence of partial failures
	Security: ensure authorised access to resources
25. What is the definition of distribution transparency?
	 The phenomenon by which a DS attempts to hide the distribution of its processes and resources are physically from it's end-users and applications. They are typically distributed across multiple computers, possibly separated by large distances. 
26. How does a DS achieve distribution transparency?
	Distribution transparency is realised through middleware.
	In essence, what applications get to see is the same interface everywhere, whereas behind that interface, where and how processes and resources are and how they are accessed is kept transparent.
27. What is the process perspective?
28.  What is the communication perspective?
29. Define access transparency of a DS. Provide an example.
30. Define location transparency of a DS. Provide an example.
	The Uniform Resource Locator (URL) for a website, gives no clue of the actual physical location of the web server, nor their previous whereabouts  where the data is/has been offered.
31. Define migration transparency of a DS. Provide an example.
32. Define relocation transparency of a DS. Provide an example.
33. Define replication transparency of a DS. Provide an example.
34. Define concurrency transparency of a DS. Provide an example.
35. Define failure transparency of a DS. Provide an example.
36. What is meant by the terms 'resource sharing'? Give an example.
37. What is meant by 'openness' in a DS? Give an example.
38. Explain what the terms 'Interoperability, composability, and extensibility' refer to in an open DS.

#### Quiz QnA
##### Quiz 1
1. What is the primary advantage of using a distributed system?
	Improved performance and reliability
2. What is a distributed system?
	A network of independent computers that appear to the users as a single coherent system
3. Which of the following is a key characteristic of distributed systems?
	Scalability
4. In a distributed system, what is the role of middleware?
	To enable communication and coordination between different components. Middleware acts a glue
5. Which of the following is an example of a distributed system?
	A client-server architecture
##### Quiz 2
1. What is High Performance Computing (HPC)?
	Use of (super)computers and parallel processing techniques
2. Which of the following is a popular HPC architecture?
	Cluster computing
3. Which programming model is commonly used in HPC for parallel computing?
	Message Passing Interface (MPI)
4. What is Pervasive Computing?
	Computing integrated into everyday objects and activities
5. Which technology is often associated with pervasive computing?
	Internet of Things
6. In the context of distributed systems, the Atomicity property of ACID ensures that:
	Either all operations of a transaction are completed successfully or none are applied
7. In the context of ACID properties, what is a ‘transaction’?
	A sequence of operations performed as a single logical unit of work
##### Quiz 3
1. Which protocol is commonly used for reliable communication in distributed systems?
	TCP
2. In a distributed system, what does RPC stand for?
	Remote Procedure Call
3. What is the main advantage of using a publish-subscribe model in distributed systems?
	Scalability and decoupling of components
4. What does the term endianness refer to in distributed systems?
	The order of bytes in a word
5. What is the main difference between little-endian and big-endian formats?
	Big-endian stores the most significant byte first while little-endian stores the least significant byte first, while
##### Quiz 4
1. Which of the following best describes serverless computing?
	A cloud computing model supporting function as a service where the provider dynamically manages the allocation of machine resources
2. What is a key benefit of serverless computing for application development?
	Automatic scaling based on demand
3. What is a “cold start” in serverless computing?
    A performance issue when a function is invoked for the first time or after being idle
4. Which of the following strategies helps reduce cold start latency in serverless applications?
	Keeping functions warm with scheduled invocations
5. Which of the following is a valid trigger type for Azure Functions?
	Azure Functions can be triggered by various sources, including HTTP requests, Azure Blob Storage, queues, and timers. HTTP triggers are commonly used for building APIs and webhooks.
##### Quiz 5
1. What is a key characteristic of a microservices architecture?
	Independent deployment of services
2. Which of the following is a common benefit of using microservices?
	Easier scaling of individual components
3. In a microservices architecture, what is the role of an API Gateway?
	Provides a single entry point for all client requests
4. What is a primary advantage of serverless architectures?
	Reduced operational costs
5. Which of the following best describes a serverless function?
	A function that is triggered by events and runs in stateless compute containers
6. In serverless architectures, what is the role of a service like AWS Lambda?
	To automatically manage the infrastructure required to run code
##### Quiz 6
1. What is the primary purpose of a naming service in a distributed system?
	To resolve names to addresses
2. Which of the following is a characteristic of a distributed naming service?
	Scalability
3. In a distributed system, what is a name space?
	A set of names and their corresponding addresses
4. What is the main advantage of using hierarchical naming in distributed systems?
	Simplifies name resolution
5. The type of DNS record that is used to map a domain name to an IPv4 address is the MX record, True or False?
	False. It is the A record
6. What is the primary purpose of LDAP?
	To access and maintain distributed directory information services
7. Which of the following is a common use case for LDAP?
	User authentication and authorization
##### Quiz 7
1. What is the primary purpose of synchronization in distributed systems?
	To coordinate actions and events across different nodes
2. Which of the following is a common method for achieving synchronization in distributed systems?
	A logical clock
3. In the context of distributed systems, what does the term "clock skew" refer to?
	The difference in time between two clocks
4. What is the primary purpose of Cristian's algorithm in distributed systems?
	To synchronize a client's clock with a server's clock
5. The Berkeley algorithm requires one of the nodes in the distributed system to be a UTC server, True or False?
	False
6. Which of the following steps is NOT part of Cristian's algorithm?
	The client and server exchange multiple messages to average the time
7. What is the primary function of the Network Time Protocol (NTP) in distributed systems?
	To synchronize the clocks of computers over a network
8. Which of the following is a key feature of NTP?
	It uses a hierarchical system of time sources
##### Quiz 8
1. Which of the following is a common challenge in maintaining consistency in distributed systems?
	Network latency
2. What is the primary goal of replication in distributed systems?
	To improve availability and fault tolerance
3. Which of the following is an advantage of client-initiated replication?
	Clients can control the timing and frequency of updates
##### Quiz 9
1. What is fault tolerance in distributed systems?
	The ability to continue operating properly in the event of the failure of some of its components
2. In a distributed system, what is the purpose of redundancy?
	To ensure that there are backup components available in case of failure
3. What is the role of a consensus algorithm in fault-tolerant distributed systems?
	To ensure all nodes agree on a single data value
4. What is the Byzantine Generals Problem in distributed systems?
	A problem of achieving consensus in the presence of faulty or malicious components
5. Which of the following is a key challenge addressed by the Byzantine Generals Problem?
	Ensuring all non-faulty nodes agree on the same value despite the presence of faulty nodes

#### Exam
**1. What is the purpose of a message queue in a distributed system?**
- To store messages temporarily.
- The core function of a message queue in Message-Oriented Middleware (MOM) is **persistent asynchronous communication**. It acts as an intermediate buffer that stores messages, decoupling the sender (producer) and receiver (consumer) in time. This ensures messages are not lost if the receiver is temporarily unavailable. While some advanced queues can offer ordering guarantees (e.g., FIFO within a partition), "ensuring messages are delivered in order" is a specific feature, not the universal primary purpose of all message queues.**2. What does an endpoint represent in a Service-Oriented Architecture (SOA)?**
- A network-accessible address where a service can be invoked.
- In SOA, an **endpoint** is the specific, concrete location (typically a URI or URL) where a service's interface is exposed. It defines the protocol (e.g., HTTP), address, and often the specific port where a client can send requests to invoke the service's operations.
**3. Consider a nested transaction that has started several subtransactions in parallel. One of these commits and makes its results visible to the parent transaction. After further computation, the parent aborts. What happens next?**
    1.  The parent restores the entire system to the state it had before the top-level transaction started.
    2.  The results of the subtransaction that committed are undone.
- This illustrates the **ACID properties**, specifically **Atomicity** ("all or nothing"). A nested transaction is considered part of its parent. If the top-level (root) transaction aborts, the entire operation is rolled back, including the effects of any committed subtransactions. Permanence is only guaranteed at the top level.
**4. In addition to computers, which of the following resources can be shared on a Grid?**
- Storage, application software, specialised equipment such as sensors, databases.
- Grid computing is defined by federating heterogeneous resources from different administrative domains into a Virtual Organization (VO). This includes not just raw compute power but any resource that can be accessed as a service: **storage** systems, licensed **software**, scientific **databases**, and unique **equipment** like telescopes or particle accelerators.
**5. Consider a social-media application in which clients connect to an online service to exchange information. Which statement(s) is/are true?**
    1.  The connection between a specific client and the service is tight.
    2.  The coupling between clients is loose.
- The client-server connection is **tightly coupled** in space and time: the client must know the server's exact endpoint (IP/URL) and both must be active for synchronous request/reply. However, **clients are loosely coupled** with each other; they have no direct knowledge of or dependency on other clients. They interact indirectly via the central service.
**6. Essentially everyone, when they first build a distributed application, makes eight assumptions as discussed in the lecture. All prove to be false in the long run and cause big trouble and painful learning experiences. There is argument for a 9th fallacy. Which one is it?**
- All clocks are synchronised.
- The original "**8 Fallacies of Distributed Computing**" by Peter Deutsch are well-known pitfalls. The commonly cited 9th fallacy, "**All clocks are synchronised**," highlights the mistaken assumption of a single, global time source, which ignores clock drift and the fundamental challenge of time synchronisation in distributed systems.
**7. What is a Virtual organisation?**
- A group of people geographically distributed that come together from different organisations to work on a Grid project.
- A **Virtual Organization (VO)** is a key concept in grid computing. It's a dynamic, policy-driven collection of individuals and/or institutions from different administrative domains who pool their resources (compute, data, equipment) to collaborate on a common goal, facilitated by grid middleware.
**8. Caching is a special form of replication, but caching and replication lead to consistency problems. True or false?**
- True.
- This statement is **true**. Both caching (temporary local copy) and replication (persistent multiple copies) are techniques for duplicating data. The fundamental problem with any duplication is **maintaining consistency**: ensuring that an update to one copy is propagated to all others. If not managed carefully, this leads to clients reading stale data.
**9. A client binds to a distributed object. The proxy (the object’s interface implementation) is loaded into the client address’ space and an object’s method is invoked. The client realises that the result returned by the object is different from the one returned the day before. Is this possible?**
- Yes.
- **Yes, this is possible.** The principle of **encapsulation** in distributed objects means the client only depends on the **public interface**. The server-side **implementation** of the method can be changed, upgraded, or even switched to a different algorithm without altering the interface. The client's proxy remains the same, but the underlying logic producing the result can differ.
**10. An ad hoc network is created between a group of friends playing a multiplayer game over wireless links on a collection of mobile devices including smartphones and tablets. Identify the classes of heterogeneity that may occur in this scenario.**
- Performance, platform and operating system.
- The three main aspects of heterogeneity are:
    1.  **Performance:** Devices have different CPU power, memory, and battery life.
    2.  **Platform:** Different hardware architectures (e.g., ARM vs. x86).
    3.  **Operating System:** Different OSs and versions (e.g., iOS, Android, various versions).
**11. You are initiating an MPI program with the command `mpirun -np 4 ./myprog`. What does the call to `MPI_Init` do?**
- Enable the 4 independent programs subsequently to communicate with each other.
- `MPI_Init` initialises the MPI execution environment. For the command `mpirun -np 4`, it sets up the necessary data structures and communication channels so that the **4 separate processes** (instances of `./myprog`) can identify each other and exchange messages using MPI primitives like `MPI_Send` and `MPI_Recv`.
**12. Consider a ubiquitous computing system whose primary feature is to take into account the context in which interactions take place. Context aware applications are built with the consideration of shared data spaces. Which statement is true?**
- Processes are decoupled in time and space.
- A **shared data space** (like a tuple space or blackboard model) is a coordination paradigm where processes communicate by reading/writing data to a common, persistent store. This provides **full decoupling**: producers and consumers don't need to know each other (space) and don't need to be active simultaneously (time).
**13. The DNS name space is organised...**
- hierarchically into a tree of domains, which are divided into non-overlapping zones.
- DNS uses a **hierarchical, tree-structured namespace** (e.g., `.` -> `.com` -> `example.com` -> `www.example.com`). For administrative and performance reasons, this tree is partitioned into **non-overlapping zones** (e.g., the `example.com` zone), each managed by an authoritative name server.
**14. In a structured peer-to-peer system where data items are stored, the system is seen to implement...**
- a distributed hash table.
- Structured P2P systems (like Chord, Pastry) organise nodes in a deterministic overlay network (e.g., a ring) and use a **consistent hashing** function to assign keys to nodes. This creates a **Distributed Hash Table (DHT)** abstraction, providing a lookup service: `get(key)` returns the data or location of the node responsible for that key.
**15. In the statement "Standard interfaces and protocols ensure that the *?* of messages and the *?* of communication are preserved when a message is passed between two dissimilar computer systems", what are the two missing words?**
- Content / semantics.
- The correct pair is **content** and **semantics**. Standardised **protocols** (rules for exchange) and **interfaces** (how to call) ensure the raw **content** of the message is not corrupted during transfer and, crucially, that its meaning (**semantics**) is correctly interpreted by the receiver, despite differences in underlying hardware or software.
**16. In the context of RPC, stubs make the remote procedure call appear as a local call to the client, hiding the complexities of network communication.**
- True.
- This statement is **true**. The **client-side stub** (or proxy) is responsible for **marshalling** parameters, sending the request over the network, and **unmarshalling** the reply. To the client application, calling the stub looks exactly like calling a local function, which is the key abstraction of RPC.
**17. The intra-Lilliputian quarrel was over...**
- the practice of breaking eggs, smaller vs larger end (little vs big endian).
- This is a reference to *Gulliver's Travels*, used as an analogy for the **endianness** debate in computing. The Lilliputians fought a war over whether to break a boiled egg from the "little end" or the "big end," paralleling the disagreement over byte order (big-endian vs. little-endian) in data representation, a key issue in data marshalling for RPC.
**18. Suppose you organise a sensor network as a distributed database. You decide that sensors do not cooperate but simply send their data to a centralised database located at the operator's site. This approach will...**
- Waste network resources and waste energy.
- A purely centralised approach is highly inefficient for sensor networks. Transmitting **all raw sensor data** over the (often wireless) network **consumes significant bandwidth (wasting network resources)** and drains the **battery-powered sensors' energy**. The standard solution is **in-network processing** to aggregate/filter data locally before transmission.
**19. In a resource-based architecture, resources are addressed by...**
- URIs.
- Resource-based architectures, most notably **REST**, use **Uniform Resource Identifiers (URIs)** (or URLs) as the global, unique identifier for every resource (e.g., `https://api.example.com/users/123`). All operations are performed on these URIs using a uniform interface (HTTP methods).
**20. You are accessing from a computer in Bragg 2.05 Lab a remote database located on Microsoft Azure cloud (using JDBC). The MySQL server resides on a host called mariadb.azure.com, which stores additional data on a server called storage.azure.com. Which client/server architecture model is this?**
- 3-Tier.
- This is a classic **3-tier architecture**:
    1.  **Presentation Tier:** The client application/Java program in the lab.
    2.  **Application/Logic Tier:** The `mariadb.azure.com` MySQL server (processing queries).
    3.  **Data Tier:** The `storage.azure.com` server (persistent storage). The logic tier (server) acts as a client to the data tier.
**21. In the context of RPC, which of these statements is true:**
- Serialisation is part of marshalling.
- **Marshalling** is the complete process of preparing a procedure call for network transmission. This includes gathering parameters, converting them to a network-standard format (handling endianness, data types), and writing them into a message buffer. **Serialisation** is a key sub-task of marshalling: transforming complex data structures (objects) into a linear sequence of bytes.
**22. Consider a distributed system supported by message queues. A process needs to install a callback function, which is automatically invoked whenever a message is put into a specified queue. Such notification can be implemented by...**
- a handler.
- This is typically implemented via an **event handler** or **callback handler**. The process registers a function with the messaging middleware. When a new message arrives in the specified queue, the middleware's event system **triggers** or **calls** the registered handler function, passing the message as an argument.
**23. What is the missing word? In a client/server architecture, a client with most resources installed locally rather than distributed over the network is known as a ??? client**
- Fat client.
- A **fat client** (or thick client) is one that implements the majority of the application's business logic and functionality locally. It relies less on the server, which may act primarily as a data backend. This contrasts with a **thin client**, which does minimal processing and relies heavily on the server.
**24. You are designing a ubiquitous computing system for a car where the settings of the driver’s seat, steering wheel, and mirrors are fully personalised. If Bob takes a seat, the system will recognise that it is dealing with Bob and subsequently makes the appropriate adjustments. The same happens when Alice uses the car. Which core requirement does this satisfy?**
- Interaction.
- This scenario satisfies the **Interaction** requirement of ubiquitous computing. The system interacts in a highly **unobtrusive** and **implicit** manner. The user's simple act of sitting down is interpreted as an input, and the system reacts automatically without the user having to issue an explicit command.
**25. In an edge-server system, servers can be used to...**
- Optimise content distribution, optimise application distribution, optimise network traffic, support Quality of Service.
- Edge servers, placed at the boundary between core networks and access networks, serve several key purposes: **caching content** closer to users (optimising distribution), hosting parts of applications (optimising app distribution), reducing load on core network links (optimising traffic), and enabling low-latency services (supporting QoS).
**26. In a distributed system, how long does it take to send a file from a sender host A to a receiver host B considering the following assumptions: the file size is 256 MegaBytes, the communication link is 5.12 GigaBytes/second, and the propagation delay is 30 milli-seconds. Note: 1 Giga = 1,000 Mega**
- 0.08 seconds (80 milliseconds).
- **Explanation & Working:**
    1.  **Convert units for consistency:** Bandwidth is `5.12 GB/s = 5120 MB/s`.
    2.  **Calculate transmission time:** `Time_tx = Size / Bandwidth = 256 MB / 5120 MB/s = 0.05 s`.
    3.  **Add propagation delay:** `Time_prop = 0.030 s`.
    4.  **Total Time (for a single packet/message model):** `Total = Time_tx + Time_prop = 0.05s + 0.03s = 0.08 s` or **80 ms**.
    *Note: This uses the simple formula: `Total Time = (Message Size / Bandwidth) + Propagation Delay`.*