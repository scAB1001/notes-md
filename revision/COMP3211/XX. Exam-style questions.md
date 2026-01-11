#### Practice 1
**001. Before DS, what did we have?**
- Before distributed systems, we had **centralised systems** (e.g., mainframes) and simple **networked computers** that operated largely in isolation.
**002. What purpose do DS fulfil?**
- They fulfil the purpose of making multiple, networked computers work together as a **single, coherent system** to solve problems that a single machine cannot, primarily for **performance, reliability, and resource sharing**.
**003. For what reasons are DS introduced?**
- They are introduced for **performance** (parallel processing), **reliability** (fault tolerance through replication), **resource sharing** (data, hardware, software), and inherent **geographical distribution** of applications or organisations.
**004. What are the requirements of a DS?**
- Key requirements include **distribution transparency**, **openness**, **scalability**, **reliability**, **security**, and efficient **communication** and **coordination** between components.
**005. What is the basic definition of a DS?**
- A **distributed** system is a networked computer system in which processes and resources are **sufficiently** spread across multiple computers.
- The spread is **"sufficient"** for practical benefits like performance or availability, but the system could theoretically be centralised.
**006. What is the nodal definition of a DS?**
- A collection of **autonomous computing elements (nodes)** that appears to its users as a **single coherent system**.
- **Nodes** (hardware/software) collaborate. Their **autonomy** means each has its own clock, making **synchronisation a challenge** in the absence of a global clock.
**007. What is the network definition of a DS?**
- A system in which components located at **networked computers** communicate and coordinate their actions only by **passing messages**.
- The system operates uniformly regardless of *where, when, or how* the user interacts with it, hiding distribution details (**transparency**).
**008. What is the definition of an autonomous node in a DS?**
- An **autonomous node** is an independent hardware device or software process that collaborates within the system. Its key autonomy is having **its own local clock**, leading to the need for clock synchronisation protocols, as there is no perfect **global clock**.
**009. Explain why a node in a DS does not have a global clock?**
- A node does not have a **global clock** because **perfect physical clock synchronisation across a network is impossible** due to **clock drift** and **message propagation delays**. Each node maintains its own time source.
**010. Define the architecture of a DS.**
- The **architecture** of a DS defines its logical organisation: the **components** (clients, servers, peers), their **functions**, the **interaction patterns** between them (e.g., client-server, peer-to-peer), and how they are physically mapped onto machines.
**011. Which of the following is a key characteristic of DS?**
- **Scalability**.
- The ability to effectively handle increases in **users, data volume, and geographical span** is a fundamental goal and differentiating characteristic of distributed systems.
**012. What is the definition of a centralised system?**
- A **centralised system** is one where all major processing, data storage, and control functions are performed by a **single, central computer or server**. Users interact with this central point.
**013. Why might we use a centralised system? Give an example scenario.**
- We use it for **simplicity, control, and security**. Example: A small company's **payroll system** running on a single, secured server where all data and logic are centrally managed and audited.
**014. What is the definition of a decentralised system?**
- A **decentralised** system is a networked computer system in which processes and resources are **necessarily** spread across multiple computers.
- The distribution is **fundamental** to its operation, often due to organisational, trust, or physical constraints.
**015. Why might we use a decentralised system? Give an example scenario.**
- We use it when **inherent distribution, lack of central trust, or administrative boundaries** exist. Example: A **blockchain** (e.g., Bitcoin), where no single entity is trusted, so transaction validation is **necessarily distributed** across a peer-to-peer network.
**016. What’s the difference between a distributed and decentralised system?**
- A **distributed** system is spread *sufficiently* for practical gains. A **decentralised** system is spread *necessarily* due to its core design principles (e.g., trust, geography). All decentralised systems are distributed, but not all distributed systems are fully decentralised.
**017. What is the role of middleware in a DS? Give an example.**
- The role of middleware is to **enable communication and coordination** between different components. **Middleware acts as the glue**.
- Example: An **RPC framework** (like gRPC) that allows a client written in Java to seamlessly call a function on a server written in Python, handling all network communication and data marshalling.
**018. Define middleware.**
- **Middleware** is a software layer that sits **between the operating system and applications**. It provides common services (communication, naming, security) to allow diverse and distributed components to interoperate, hiding the underlying heterogeneity.
**019. Provide an example of when a DS would be placed in a system.**
- A DS would be placed in a system when **scalability or reliability** becomes a critical need. Example: Placing a **load balancer** and a **cluster of web servers** in front of a single database to handle high traffic for an e-commerce website.
**020. Explain what is meant by the term 'distribution transparency' and provide examples.**
- **Distribution transparency** is the design goal of **hiding from users and applications** the fact that processes and resources are physically distributed across a network.
- Examples: A user accessing a file via a **network path** (e.g., `\\server\share\file`) without knowing its physical disk location, or a website visitor not knowing which of hundreds of **CDN servers** is delivering the content.
**021. Describe the integrative view of a DS.**
- The **integrative view** sees a DS as **connecting existing networked computer systems into a larger, unified system**. It focuses on federation and interoperability of pre-existing autonomous systems.
**022. Describe the expansive view of a DS.**
- The **expansive view** sees a DS as an **existing networked computer system that is extended with additional computers**. It focuses on scaling out a single system's capacity and reach.
**023. What is the definition of federated learning?**
- **Federated learning** is a machine learning technique where a **predictive model is trained across multiple decentralised edge devices or servers** holding local data samples, without exchanging the data itself.
- The training is **brought to the data** (at the edge) to preserve privacy and comply with data governance, instead of centralising all data for HPC training.
**024. Describe some common challenges of a DS.**
- Common challenges include designing the **architecture** and **communication** facilities, enabling **coordination** and **naming**, managing **consistency and replication**, providing **fault tolerance**, and ensuring **security**.
**025. What is the definition of distribution transparency?**
- **Distribution transparency** is the phenomenon by which a DS attempts to **hide the fact** that its processes and resources are physically distributed across multiple computers, possibly separated by large distances.
**026. How does a DS achieve distribution transparency?**
- A DS achieves distribution transparency primarily through **middleware**. The middleware presents a **uniform interface** to applications, while internally handling all the complexities of distribution, such as location, migration, and failure.
**027. What is the process perspective?**
- The **process perspective** examines a DS in terms of the **types of processes** (e.g., clients, servers, peers) that execute, their **roles, lifecycles, and relationships** (e.g., how they are created, communicate, and synchronise).
**028. What is the communication perspective?**
- The **communication perspective** examines the **facilities and paradigms** for data exchange between processes (e.g., **RPC, message passing, pub/sub**), focusing on protocols, reliability, and the **abstraction** provided to programmers.
**029. Define access transparency of a DS. Provide an example.**
- **Access transparency** hides differences in **data representation and how an object is accessed**. Example: A Windows client using the same file open call (`fopen`) to read a file from a Linux server, unaware of different underlying file systems.
**030. Define location transparency of a DS. Provide an example.**
- **Location transparency** hides **where an object is physically located**. Example: A **URL** like `https://example.com/data` gives no clue about the geographic location or specific server hosting the data.
**031. Define migration transparency of a DS. Provide an example.**
- **Migration transparency** hides that an **object may move to another location**. Example: A **mobile user's cellular connection** being seamlessly handed off between towers without dropping the call.
**032. Define relocation transparency of a DS. Provide an example.**
- **Relocation transparency** hides that an **object may be moved while in use**. Example: **Live migration of a virtual machine** between physical servers in a data centre without disconnecting the users or applications running on it.
**033. Define replication transparency of a DS. Provide an example.**
- **Replication transparency** hides that **multiple copies (replicas) of an object exist**. Example: Reading a popular webpage; the user doesn't know which of many globally distributed **CDN edge servers** is actually serving the content.
**034. Define concurrency transparency of a DS. Provide an example.**
- **Concurrency transparency** hides that an **object may be shared by several independent users**. Example: Multiple users **collaboratively editing a shared online document**; the system manages merges and locks without users explicitly coordinating.
**035. Define failure transparency of a DS. Provide an example.**
- **Failure transparency** hides the **failure and recovery of an object**. Example: If a database replica fails, the system **automatically redirects queries** to a working replica without the application throwing an error to the user.
**036. What is meant by the terms 'resource sharing'? Give an example.**
- **Resource sharing** means that **hardware, software, and data** can be accessed and used by multiple users or applications in the DS. Example: **Cloud storage** (like Dropbox), where a single storage infrastructure is shared by millions of users to store and synchronise files.
**037. What is meant by 'openness' in a DS? Give an example.**
- **Openness** means a DS is built from **components with well-defined, standardised interfaces**, allowing them to be easily replaced, extended, or to interoperate with components from other systems.
- Example: **Web services** using **HTTP** and **RESTful APIs**; any client that understands these standards can interact with the service, regardless of its implementation language or platform.
**038. Explain what the terms 'Interoperability, composability, and extensibility' refer to in an open DS.**
- In an open DS:
    - **Interoperability**: The ability for **components from different vendors/systems to work together** using common standards.
    - **Composability**: The ability to **easily assemble (compose) systems from smaller, reusable service components**.
    - **Extensibility**: The ease with which a system can be **modified or have new functionality added** without major restructuring, often by adding new components that adhere to the published interfaces.
#### Quiz QnA
**1. What is the primary advantage of using a distributed system?**
- Improved performance and reliability.
- By distributing computation and storage across multiple machines, a system can process tasks in parallel (improving performance) and continue operating if some components fail (improving reliability).
**2. What is a distributed system?**
- A network of independent computers that appear to the users as a single coherent system.
- A distributed system is a collection of autonomous nodes that communicate via message passing. The key is that these nodes collaborate to present themselves as a unified whole to the end user, hiding the underlying complexity of distribution.
**3. Which of the following is a key characteristic of distributed systems?**
- Scalability.
- Scalability—the ability to effectively handle growth in the number of users, data volume, or geographic spread—is a fundamental goal and defining challenge of distributed systems. Centralized systems are inherently limited in this regard.
**4. In a distributed system, what is the role of middleware?**
- To enable communication and coordination between different components. Middleware acts a glue.
- Middleware is the software layer that sits between the operating system and applications, providing common services such as communication, naming, and security. It abstracts the heterogeneity of the underlying infrastructure, acting as the "glue" that allows diverse components to work together seamlessly.
**5. Which of the following is an example of a distributed system?**
- A client-server architecture.
- The client-server model is the foundational architectural style for most distributed systems. It explicitly separates the user interface/client from the data processing/server, which are typically located on different networked machines, fulfilling the definition of a distributed system.
**6. What is High Performance Computing (HPC)?**
- Use of (super)computers and parallel processing techniques.
- HPC focuses on executing complex computations at extremely high speeds by aggregating the power of many processors, often in clusters or supercomputers, to solve problems that are too large or time-consuming for a standard computer.
**7. Which of the following is a popular HPC architecture?**
- Cluster computing.
- Cluster computing, which links numerous standard, commodity computers via a high-speed network, is a dominant and cost-effective HPC architecture for achieving supercomputing-level performance.
**8. Which programming model is commonly used in HPC for parallel computing?**
- Message Passing Interface (MPI).
- MPI is the de facto standard API for programming parallel applications in HPC environments, especially on clusters. It provides a rich set of routines for point-to-point and collective communication between processes.
**9. What is Pervasive Computing?**
- Computing integrated into everyday objects and activities.
- Pervasive (or ubiquitous) computing describes the trend of embedding computational capability into everyday objects and environments so that it blends seamlessly into the background of human activity.
**10. Which technology is often associated with pervasive computing?**
- Internet of Things.
- The Internet of Things (IoT) is a primary manifestation of pervasive computing, involving a vast network of physical devices (sensors, appliances, wearables) embedded with electronics and network connectivity.
**11. In the context of distributed systems, the Atomicity property of ACID ensures that:**
- Either all operations of a transaction are completed successfully or none are applied.
- Atomicity is the "all-or-nothing" guarantee. A transaction is an indivisible unit; if any part fails, the entire transaction is rolled back, leaving the system state unchanged.
**12. In the context of ACID properties, what is a ‘transaction’?**
- A sequence of operations performed as a single logical unit of work.
- A transaction bundles multiple read/write operations into one logical unit that must satisfy the ACID properties (Atomicity, Consistency, Isolation, Durability) to ensure reliable processing.
**13. Which protocol is commonly used for reliable communication in distributed systems?**
- TCP.
- The Transmission Control Protocol (TCP) provides a reliable, ordered, and error-checked delivery stream between applications running on hosts. This reliability is crucial for many distributed system communications.
**14. In a distributed system, what does RPC stand for?**
- Remote Procedure Call.
- RPC is a key communication paradigm that allows a program to execute a procedure (a subroutine) on another machine as if it were a local call, abstracting the complexities of network communication.
**15. What is the main advantage of using a publish-subscribe model in distributed systems?**
- Scalability and decoupling of components.
- The publish-subscribe model decouples message producers (publishers) from consumers (subscribers) in time and space. Publishers and subscribers don't need to know each other, leading to highly scalable and flexible architectures.
**16. What does the term endianness refer to in distributed systems?**
- The order of bytes in a word.
- Endianness defines the sequential order in which bytes of a multi-byte data word (like an integer) are stored in memory or transmitted over a network. It is a critical consideration for data marshalling.
**17. What is the main difference between little-endian and big-endian formats?**
- Big-endian stores the most significant byte first while little-endian stores the least significant byte first.
- In **big-endian**, the most significant byte (the "big end") is stored at the lowest memory address. In **little-endian**, the least significant byte is stored first. Systems must agree on a format for correct data interpretation.
**18. Which of the following best describes serverless computing?**
- A cloud computing model supporting function as a service where the provider dynamically manages the allocation of machine resources.
- Serverless computing is defined by the cloud provider automatically provisioning, scaling, and managing the server infrastructure required to run code, which is typically packaged as individual, event-triggered functions (FaaS).
**19. What is a key benefit of serverless computing for application development?**
- Automatic scaling based on demand.
- The cloud provider handles all scaling logic, seamlessly adjusting compute capacity in real-time to match the rate of incoming events or requests, with zero effort required from the developer.
**20. What is a “cold start” in serverless computing?**
- A performance issue when a function is invoked for the first time or after being idle.
- A "cold start" is the latency incurred when a serverless platform must provision a new execution environment (e.g., container) for a function, including loading the runtime and code. Subsequent "warm" invocations on the same environment are faster.
**21. Which of the following strategies helps reduce cold start latency in serverless applications?**
- Keeping functions warm with scheduled invocations.
- A common workaround is to use a scheduled trigger (like a cron job) to periodically invoke the function, preventing its execution environment from being deallocated by the provider and thus keeping it in a "warm" state.
**22. Which of the following is a valid trigger type for Azure Functions?**
- Azure Functions can be triggered by various sources, including HTTP requests, Azure Blob Storage, queues, and timers.
- Azure Functions, as a serverless FaaS platform, supports numerous triggers: **HTTP** (for web APIs), **Blob Storage** (file uploads), **Queues** (messages), **Timers** (scheduled jobs), and events from many other Azure services.
**23. What is a key characteristic of a microservices architecture?**
- Independent deployment of services.
- Microservices are small, autonomous services that can be developed, deployed, scaled, and updated independently of one another. This independence is a core characteristic that enables agility and continuous delivery.
**24. Which of the following is a common benefit of using microservices?**
- Easier scaling of individual components.
- Because services are independent, you can scale only the specific components that are under heavy load, rather than scaling the entire monolithic application. This leads to more efficient resource utilization.
**25. In a microservices architecture, what is the role of an API Gateway?**
- Provides a single entry point for all client requests.
- An API Gateway is a reverse proxy that sits in front of the microservices. It handles request routing, composition, protocol translation, and cross-cutting concerns like authentication and rate limiting, simplifying the client interface.
**26. What is a primary advantage of serverless architectures?**
- Reduced operational costs.
- Serverless follows a pay-per-execution model with no charge for idle resources. It eliminates the operational overhead of server provisioning, patching, and capacity planning, leading to significant cost reduction for variable workloads.
**27. Which of the following best describes a serverless function?**
- A function that is triggered by events and runs in stateless compute containers.
- A serverless function is a single-purpose, event-driven unit of code. It is executed in ephemeral, stateless containers managed entirely by the cloud platform, which are instantiated in response to triggering events.
**28. In serverless architectures, what is the role of a service like AWS Lambda?**
- To automatically manage the infrastructure required to run code.
- AWS Lambda is the execution environment. Its primary role is to abstract away all server management: it automatically runs your code on a highly available, scalable compute infrastructure in response to events.
**29. What is the primary purpose of a naming service in a distributed system?**
- To resolve names to addresses.
- A naming service provides a mapping from human-friendly, location-independent names (like `www.example.com`) to low-level, machine-specific network addresses (like `192.0.2.1:80`), which are needed for communication.
**30. Which of the following is a characteristic of a distributed naming service?**
- Scalability.
- A naming service for a distributed system must itself be distributed and scalable to handle the vast number of names and high query rates generated by a large-scale system, without becoming a bottleneck.
**31. In a distributed system, what is a name space?**
- A set of names and their corresponding addresses.
- A namespace is the structured collection of all valid names recognized by a naming system and the bindings that associate those names with the entities (and their attributes/addresses) they represent.
**32. What is the main advantage of using hierarchical naming in distributed systems?**
- Simplifies name resolution.
- A hierarchical namespace (like DNS) allows for decentralized administration and efficient, scalable resolution. Responsibility can be delegated (e.g., `example.com` is managed independently), and lookups can be performed by walking the hierarchy.
**33. The type of DNS record that is used to map a domain name to an IPv4 address is the MX record, True or False?**
- False. It is the A record.
- An **A (Address) record** maps a domain name to an IPv4 address. An **MX (Mail Exchange) record** specifies the mail servers responsible for receiving email for a domain.
**34. What is the primary purpose of LDAP?**
- To access and maintain distributed directory information services.
- The Lightweight Directory Access Protocol (LDAP) is an open, vendor-neutral protocol for accessing and managing hierarchical directory information, which is optimized for read-heavy operations like authentication and lookup.
**35. Which of the following is a common use case for LDAP?**
- User authentication and authorization.
- LDAP is extensively used as a central repository for user credentials and attributes (like groups and roles), enabling single sign-on (SSO) and centralized access control across many applications.
**36. What is the primary purpose of synchronization in distributed systems?**
- To coordinate actions and events across different nodes.
- Synchronization mechanisms ensure that processes in a distributed system cooperate correctly, for example, to maintain data consistency, execute in a specific order, or agree on a shared state.
**37. Which of the following is a common method for achieving synchronization in distributed systems?**
- A logical clock.
- Since a perfectly synchronized global physical clock is impossible, distributed systems often use logical clocks (like Lamport timestamps or vector clocks) to define a causal order of events without relying on absolute time.
**38. In the context of distributed systems, what does the term "clock skew" refer to?**
- The difference in time between two clocks.
- Clock skew is the instantaneous difference in time readings between any two clocks in the system. It arises because every physical clock drifts at a slightly different rate.
**39. What is the primary purpose of Cristian's algorithm in distributed systems?**
- To synchronize a client's clock with a server's clock.
- Cristian's algorithm is a simple time-synchronization protocol where a client obtains the current time from a trusted time server and adjusts its local clock, accounting for the estimated network message delay.
**40. The Berkeley algorithm requires one of the nodes in the distributed system to be a UTC server, True or False?**
- False.
- The Berkeley algorithm is an internal synchronization algorithm. It does not require an external UTC source. Instead, a coordinator node polls others, computes an average time, and instructs all nodes how to adjust their clocks relative to each other.
**41. Which of the following steps is NOT part of Cristian's algorithm?**
- The client and server exchange multiple messages to average the time.
- Cristian's algorithm involves a single request-reply exchange between client and server. It does not use multiple rounds or averaging between peers; that is characteristic of algorithms like NTP or Berkeley.
**42. What is the primary function of the Network Time Protocol (NTP) in distributed systems?**
- To synchronize the clocks of computers over a network.
- NTP is the standard internet protocol used to synchronize system clocks across packet-switched, variable-latency data networks with a high degree of accuracy and reliability.
**43. Which of the following is a key feature of NTP?**
- It uses a hierarchical system of time sources.
- NTP uses a hierarchical, stratified architecture. Stratum 1 servers are connected to atomic clocks, Stratum 2 servers sync with Stratum 1, and so on. This design provides scalability, redundancy, and distributes the load.
**44. Which of the following is a common challenge in maintaining consistency in distributed systems?**
- Network latency.
- The finite and variable speed of network communication makes it impossible to instantly update all replicas of data. This delay creates windows of inconsistency, making it a fundamental challenge.
**45. What is the primary goal of replication in distributed systems?**
- To improve availability and fault tolerance.
- Replication creates redundant copies of data or services. If one replica fails, the system can continue operating using another, thereby increasing overall system availability and resilience to failures.
**46. Which of the following is an advantage of client-initiated replication?**
- Clients can control the timing and frequency of updates.
- In client-initiated replication (caching), the client decides when to fetch or refresh data from the source. This allows clients to optimize for their own performance and usage patterns, potentially reducing perceived latency.
**47. What is fault tolerance in distributed systems?**
- The ability to continue operating properly in the event of the failure of some of its components.
- Fault tolerance is the property that enables a system to deliver its specified service even when one or more of its internal hardware or software components have failed.
**48. In a distributed system, what is the purpose of redundancy?**
- To ensure that there are backup components available in case of failure.
- Redundancy is the core technique for achieving fault tolerance. By having extra components (information, time, or physical), the system can mask or recover from the failure of individual parts.
**49. What is the role of a consensus algorithm in fault-tolerant distributed systems?**
- To ensure all nodes agree on a single data value.
- In a replicated system, a consensus algorithm (like Paxos or Raft) is the mechanism by which non-faulty nodes reach a common agreement on a value (e.g., the next state or transaction order) despite the potential failure of some nodes.
**50. What is the Byzantine Generals Problem in distributed systems?**
- A problem of achieving consensus in the presence of faulty or malicious components.
- It's a theoretical framework that describes the difficulty of getting distributed components to agree on a coordinated plan of action when some components may fail in arbitrary, even malicious, ways (Byzantine failures).
**51. Which of the following is a key challenge addressed by the Byzantine Generals Problem?**
- Ensuring all non-faulty nodes agree on the same value despite the presence of faulty nodes.
- The core challenge is maintaining system correctness and consistency when participants cannot be fully trusted, requiring protocols that can tolerate a certain number of arbitrarily failing components.
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