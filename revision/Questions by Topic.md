### **1. Introduction to Distributed Systems**
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
**010. What is the definition of a centralised system?**
- A **centralised system** is one where all major processing, data storage, and control functions are performed by a **single, central computer or server**. Users interact with this central point.
**011. Why might we use a centralised system? Give an example scenario.**
- We use it for **simplicity, control, and security**. Example: A small company's **payroll system** running on a single, secured server where all data and logic are centrally managed and audited.
**012. What is the definition of a decentralised system?**
- A **decentralised** system is a networked computer system in which processes and resources are **necessarily** spread across multiple computers.
- The distribution is **fundamental** to its operation, often due to organisational, trust, or physical constraints.
**013. Why might we use a decentralised system? Give an example scenario.**
- We use it when **inherent distribution, lack of central trust, or administrative boundaries** exist. Example: A **blockchain** (e.g., Bitcoin), where no single entity is trusted, so transaction validation is **necessarily distributed** across a peer-to-peer network.
**014. What’s the difference between a distributed and decentralised system?**
- A **distributed** system is spread *sufficiently* for practical gains. A **decentralised** system is spread *necessarily* due to its core design principles (e.g., trust, geography). All decentralised systems are distributed, but not all distributed systems are fully decentralised.
**015. Explain what is meant by the term 'distribution transparency' and provide examples.**
- **Distribution transparency** is the design goal of **hiding from users and applications** the fact that processes and resources are physically distributed across a network.
- Examples: A user accessing a file via a **network path** (e.g., `\\server\share\file`) without knowing its physical disk location, or a website visitor not knowing which of hundreds of **CDN servers** is delivering the content.
**016. Define the architecture of a DS.**
- The **architecture** of a DS defines its logical organisation: the **components** (clients, servers, peers), their **functions**, the **interaction patterns** between them (e.g., client-server, peer-to-peer), and how they are physically mapped onto machines.
**017. What is the definition of distribution transparency?**
- **Distribution transparency** is the phenomenon by which a DS attempts to **hide the fact** that its processes and resources are physically distributed across multiple computers, possibly separated by large distances.
**018. How does a DS achieve distribution transparency?**
- A DS achieves distribution transparency primarily through **middleware**. The middleware presents a **uniform interface** to applications, while internally handling all the complexities of distribution, such as location, migration, and failure.
**019. Describe some common challenges of a DS.**
- Common challenges include designing the **architecture** and **communication** facilities, enabling **coordination** and **naming**, managing **consistency and replication**, providing **fault tolerance**, and ensuring **security**.
**020. Define access transparency of a DS. Provide an example.**
- **Access transparency** hides differences in **data representation and how an object is accessed**. Example: A Windows client using the same file open call (`fopen`) to read a file from a Linux server, unaware of different underlying file systems.
**021. Define location transparency of a DS. Provide an example.**
- **Location transparency** hides **where an object is physically located**. Example: A **URL** like `https://example.com/data` gives no clue about the geographic location or specific server hosting the data.
**022. Define migration transparency of a DS. Provide an example.**
- **Migration transparency** hides that an **object may move to another location**. Example: A **mobile user's cellular connection** being seamlessly handed off between towers without dropping the call.
**023. Define relocation transparency of a DS. Provide an example.**
- **Relocation transparency** hides that an **object may be moved while in use**. Example: **Live migration of a virtual machine** between physical servers in a data centre without disconnecting the users or applications running on it.
**024. Define replication transparency of a DS. Provide an example.**
- **Replication transparency** hides that **multiple copies (replicas) of an object exist**. Example: Reading a popular webpage; the user doesn't know which of many globally distributed **CDN edge servers** is actually serving the content.
**025. Define concurrency transparency of a DS. Provide an example.**
- **Concurrency transparency** hides that an **object may be shared by several independent users**. Example: Multiple users **collaboratively editing a shared online document**; the system manages merges and locks without users explicitly coordinating.
**026. Define failure transparency of a DS. Provide an example.**
- **Failure transparency** hides the **failure and recovery of an object**. Example: If a database replica fails, the system **automatically redirects queries** to a working replica without the application throwing an error to the user.
**027. What is meant by the terms 'resource sharing'? Give an example.**
- **Resource sharing** means that **hardware, software, and data** can be accessed and used by multiple users or applications in the DS. Example: **Cloud storage** (like Dropbox), where a single storage infrastructure is shared by millions of users to store and synchronise files.
**028. What is meant by 'openness' in a DS? Give an example.**
- **Openness** means a DS is built from **components with well-defined, standardised interfaces**, allowing them to be easily replaced, extended, or to interoperate with components from other systems.
- Example: **Web services** using **HTTP** and **RESTful APIs**; any client that understands these standards can interact with the service, regardless of its implementation language or platform.
**029. Explain what the terms 'Interoperability, composability, and extensibility' refer to in an open DS.**
- In an open DS:
    - **Interoperability**: The ability for **components from different vendors/systems to work together** using common standards.
    - **Composability**: The ability to **easily assemble (compose) systems from smaller, reusable service components**.
    - **Extensibility**: The ease with which a system can be **modified or have new functionality added** without major restructuring, often by adding new components that adhere to the published interfaces.
**030. Which of the following is a key characteristic of DS?**
- **Scalability**.
- The ability to effectively handle increases in **users, data volume, and geographical span** is a fundamental goal and differentiating characteristic of distributed systems.
**031. Essentially everyone, when they first build a distributed application, makes eight assumptions as discussed in the lecture. All prove to be false in the long run and cause big trouble and painful learning experiences. There is argument for a 9th fallacy. Which one is it?**
- All clocks are synchronised.
- The original "**8 Fallacies of Distributed Computing**" by Peter Deutsch are well-known pitfalls. The commonly cited 9th fallacy, "**All clocks are synchronised**," highlights the mistaken assumption of a single, global time source, which ignores clock drift and the fundamental challenge of time synchronisation in distributed systems.
**032. An ad hoc network is created between a group of friends playing a multiplayer game over wireless links on a collection of mobile devices including smartphones and tablets. Identify the classes of heterogeneity that may occur in this scenario.**
- Performance, platform and operating system.
- The three main aspects of heterogeneity are:
    1.  **Performance:** Devices have different CPU power, memory, and battery life.
    2.  **Platform:** Different hardware architectures (e.g., ARM vs. x86).
    3.  **Operating System:** Different OSs and versions (e.g., iOS, Android, various versions).
**033. Both Alice and her husband Bob make use of the family car, which is considered as a ubiquitous computing system. The settings of the car’s passenger’s seat and mirrors is fully personalised, and subsequently the car makes the appropriate adjustments. What ubiquitous computing system requirement does such pervasiveness support? Simply provide its name.**
- **Interaction.**
- This scenario satisfies the **Interaction** requirement of ubiquitous computing. The system interacts in a highly **unobtrusive** and **implicit** manner, reacting to the user's presence automatically without requiring an explicit command.
**034. Consider a system that supports a client server business application. A powerful computer running the Linux operating system is used to host the server process. Users access the service through low-cost desktop computers running the Windows operating system. Identify the classes of heterogeneity that may occur in this scenario.**
- **Hardware** (powerful vs. low-cost computers), **Operating System** (Linux vs. Windows), and **Network** (potentially different network stacks, firewalls). **Performance** heterogeneity is also implied by the hardware difference.
- *Explanation:* Heterogeneity refers to differences across the system's components. Here, key differences exist in the **hardware platform**, the **OS platform**, and likely the local network environments.
**035. The Internet, the World Wide Web and a cellular phone mobile network are examples of distributed systems. Which one is truly transparent and why?**
- **The World Wide Web.**
- The Web provides a high degree of **distribution transparency**. Users access resources via **URLs** without any knowledge of the physical server location, the OS it runs on, or the replication behind a **CDN**. The Internet (the TCP/IP infrastructure) and cellular networks expose more of their distributed nature (e.g., IP addresses, signal strength, handovers) to the user/application.
**036. Discuss briefly the implications of these properties on the engineering of large-scale, widely distributed systems: Concurrent execution of components, Independent failure modes, Communication delay, No global time.**
- **Concurrent execution:** Requires **synchronisation mechanisms** (e.g., locks, transactions) to avoid race conditions and ensure consistency.
- **Independent failure modes (Partial Failure):** Systems must be designed for **fault tolerance**; failures must be detected, masked, or recovered from without total collapse.
- **Communication delay:** Introduces **latency**, making synchronous operations inefficient. Engineers must use **asynchronous communication** and design for eventual consistency.
- **No global time:** Makes ordering events hard. Requires **logical clocks** (Lamport/Vector) for causal ordering and protocols like **NTP** for approximate physical clock synchronisation.
- *Combined,* these properties make guaranteeing **strong consistency**, **precise coordination**, and **simple programming models** extremely challenging at large scale.
**037. According to the definitions provided, which of the following is a *decentralised* system and why?**
    A. A corporate email system hosted on a cluster of servers in a single data centre.
    B. A federated machine learning system where hospitals train a model on local patient data without sharing the data itself.
    C. A video streaming service that uses edge servers to cache popular content closer to users.
- **B. A federated machine learning system...**
- *Explanation:* This is **decentralised** because the distribution is *necessary* due to **organisational and privacy constraints** (data cannot leave the hospital). The training is fundamentally distributed across administrative domains. **A** is a *distributed* system for performance/reliability (sufficiently spread). **C** is a *distributed* system for performance (sufficiently spread via replication).
**038. What is the primary role of middleware in achieving distribution transparency?**
- Middleware acts as a **software layer** that provides a **uniform programming model** to applications, **masking the heterogeneity** of underlying hardware, networks, and operating systems, and **hiding the distribution** of components.
- *Explanation:* As shown in the architecture diagram, middleware sits between the OS and applications. It provides common services (e.g., communication, naming) so that applications don't have to deal directly with the complexities of distribution, thereby enabling transparency.
**039. When scaling a system geographically, why does techniques like broadcasting for service discovery, which works in a LAN, fail in a WAN?**
- **Broadcasting** in a WAN is **inefficient and often impossible** because it generates excessive, wasteful network traffic across expensive, limited-bandwidth links. Furthermore, routers are typically configured to **block broadcast packets** from propagating between different network segments to prevent flooding.
- *Explanation:* This is a key **scalability issue**. WANs require scalable alternatives like **hierarchical** or **decentralised directory services** (e.g., DNS) for discovery.
**040. The "8 Fallacies of Distributed Computing" highlight incorrect assumptions. Explain how the fallacy **"Latency is zero"** impacts the design of a distributed application, and name one **scaling technique** used to mitigate this.**
- **Impact:** Assuming zero latency leads to designs using excessive **synchronous, blocking calls** over the network. This causes poor performance and unresponsive applications, as processes spend most of their time waiting for network replies.
- **Mitigating Technique:** **Hiding Communication Latencies**. This is done by using **asynchronous communication** (e.g., callbacks, promises) or by **moving computation to the client** (e.g., sending JavaScript code to a browser) to avoid blocking.
- *Explanation:* This directly links a core pitfall to a specific scaling solution from the notes.
**041. Describe the **integrative view** and the **expansive view** of distributed systems. Provide a real-world example that illustrates each view.**
- **Integrative View:** Connects **existing, autonomous systems** into a larger, unified system. *Example:* The **Internet** itself, which integrates countless independent networks (ISPs, corporate nets) using standard protocols (TCP/IP).
- **Expansive View:** **Extends a single system** by adding more computers to increase its capacity or reach. *Example:* **Scaling a web application** by adding more servers behind a load balancer to handle more users.
- *Explanation:* This tests understanding of the two philosophical perspectives on distribution, which underpin the distributed vs. decentralised distinction.
**042. A key challenge of **replication** as a scaling technique is maintaining consistency. Why does strict consistency (where all replicas are instantly identical) conflict with the goals of scalability and performance?**
- Maintaining strict consistency requires **global synchronisation** on every update. This means every write operation must block until all replicas are updated, which **increases latency** significantly due to network delays. This coordination overhead also consumes bandwidth and processing power, creating a **bottleneck** that prevents the system from scaling to a large number of replicas or geographic spread.
- *Explanation:* This gets to the heart of the scalability trade-off: you often must relax consistency (e.g., to eventual consistency) to achieve performance and scale.
**043. Explain, using the DNS as an example, how **partitioning** (distribution) and **replication** work together to create a scalable system.**
- **Partitioning in DNS:** The namespace is **hierarchically partitioned** into zones (e.g., `.com`, `ac.uk`). Authority for each zone is **delegated** to different name servers. This distributes the management and query load.
- **Replication in DNS:** Each zone is typically served by **multiple replica name servers**. This provides **fault tolerance** (if one fails) and **improves performance/load balancing**.
- **Together:** Partitioning prevents any single point of control or failure for the entire system. Replication within each partition ensures the availability and performance of that partition. Client caching of responses adds another layer of effective replication.
- *Explanation:* This question synthesises two core scaling techniques using the prime example from the notes.
**044. What does **federated learning** exemplify about the reasons for building a decentralised system?**
- It exemplifies that distribution can be **necessary due to external constraints**, not just desirable for performance. In federated learning, the data (e.g., patient records) **cannot be centralised** due to **privacy regulations, legal boundaries, or organizational policy**. Therefore, the computation (model training) is **necessarily brought to the data** across multiple locations.
- *Explanation:* This tests understanding of the "necessarily spread" criterion for decentralised systems, using a modern, relevant example from the notes.
**045. The diagram of centralised, decentralised, and distributed systems shows a spectrum. Positioning a system on this spectrum involves a trade-off. What is typically traded off when moving from a centralised design toward a distributed/decentralised one?**
- The trade-off is between **control, simplicity, and strong consistency** (advantages of centralisation) versus **scalability, fault tolerance, and autonomy** (advantages of distribution).
- *Explanation:* Centralised systems are simpler to design, manage, and keep consistent. Distributed systems give these up to achieve growth, reliability, and to meet physical or trust-based constraints.
**046. Which of the following is NOT a goal of a distributed system, but rather a *technique* or *property* used to achieve its goals?**
    A. Transparency
    B. Scalability
    C. Replication
    D. Openness
- **C. Replication**
- *Explanation:* **Replication** is a *scaling technique* used to achieve the goals of **performance, reliability, and availability**. **Transparency**, **Scalability**, and **Openness** are primary goals/design objectives of a DS itself.
### **2. Types of Distributed Systems**
**001. What is High Performance Computing (HPC)?**
- Use of (super)computers and parallel processing techniques.
- HPC focuses on executing complex computations at extremely high speeds by aggregating the power of many processors, often in clusters or supercomputers, to solve problems that are too large or time-consuming for a standard computer.
**002. Which of the following is a popular HPC architecture?**
- Cluster computing.
- Cluster computing, which links numerous standard, commodity computers via a high-speed network, is a dominant and cost-effective HPC architecture for achieving supercomputing-level performance.
**003. Which programming model is commonly used in HPC for parallel computing?**
- Message Passing Interface (MPI).
- MPI is the de facto standard API for programming parallel applications in HPC environments, especially on clusters. It provides a rich set of routines for point-to-point and collective communication between processes.
**004. What is Pervasive Computing?**
- Computing integrated into everyday objects and activities.
- Pervasive (or ubiquitous) computing describes the trend of embedding computational capability into everyday objects and environments so that it blends seamlessly into the background of human activity.
**005. Which technology is often associated with pervasive computing?**
- Internet of Things.
- The Internet of Things (IoT) is a primary manifestation of pervasive computing, involving a vast network of physical devices (sensors, appliances, wearables) embedded with electronics and network connectivity.
**006. What is a Virtual organisation?**
- A group of people geographically distributed that come together from different organisations to work on a Grid project.
- A **Virtual Organization (VO)** is a key concept in grid computing. It's a dynamic, policy-driven collection of individuals and/or institutions from different administrative domains who pool their resources (compute, data, equipment) to collaborate on a common goal, facilitated by grid middleware.
**007. In addition to computers, which of the following resources can be shared on a Grid?**
- Storage, application software, specialised equipment such as sensors, databases.
- Grid computing is defined by federating heterogeneous resources from different administrative domains into a Virtual Organization (VO). This includes not just raw compute power but any resource that can be accessed as a service: **storage** systems, licensed **software**, scientific **databases**, and unique **equipment** like telescopes or particle accelerators.
**008. In the context of ACID properties, what is a ‘transaction’?**
- A sequence of operations performed as a single logical unit of work.
- A transaction bundles multiple read/write operations into one logical unit that must satisfy the ACID properties (Atomicity, Consistency, Isolation, Durability) to ensure reliable processing.
**009. Consider a nested transaction that has started several subtransactions in parallel. One of these commits and makes its results visible to the parent transaction. After further computation, the parent aborts. What happens next?**
    1.  The parent restores the entire system to the state it had before the top-level transaction started.
    2.  The results of the subtransaction that committed are undone.
- This illustrates the **ACID properties**, specifically **Atomicity** ("all or nothing"). A nested transaction is considered part of its parent. If the top-level (root) transaction aborts, the entire operation is rolled back, including the effects of any committed subtransactions. Permanence is only guaranteed at the top level.
**010. Consider a social-media application in which clients connect to an online service to exchange information. Which statement(s) is/are true?**
    1.  The connection between a specific client and the service is tight.
    2.  The coupling between clients is loose.
- The client-server connection is **tightly coupled** in space and time: the client must know the server's exact endpoint (IP/URL) and both must be active for synchronous request/reply. However, **clients are loosely coupled** with each other; they have no direct knowledge of or dependency on other clients. They interact indirectly via the central service.
**011. Consider a ubiquitous computing system whose primary feature is to take into account the context in which interactions take place. Context aware applications are built with the consideration of shared data spaces. Which statement is true?**
- Processes are decoupled in time and space.
- A **shared data space** (like a tuple space or blackboard model) is a coordination paradigm where processes communicate by reading/writing data to a common, persistent store. This provides **full decoupling**: producers and consumers don't need to know each other (space) and don't need to be active simultaneously (time).
**012. Suppose you organise a sensor network as a distributed database. You decide that sensors do not cooperate but simply send their data to a centralised database located at the operator's site. This approach will...**
- Waste network resources and waste energy.
- A purely centralised approach is highly inefficient for sensor networks. Transmitting **all raw sensor data** over the (often wireless) network **consumes significant bandwidth (wasting network resources)** and drains the **battery-powered sensors' energy**. The standard solution is **in-network processing** to aggregate/filter data locally before transmission.
**013. You are designing a ubiquitous computing system for a car where the settings of the driver’s seat, steering wheel, and mirrors are fully personalised. If Bob takes a seat, the system will recognise that it is dealing with Bob and subsequently makes the appropriate adjustments. The same happens when Alice uses the car. Which core requirement does this satisfy?**
- Interaction.
- This scenario satisfies the **Interaction** requirement of ubiquitous computing. The system interacts in a highly **unobtrusive** and **implicit** manner. The user's simple act of sitting down is interpreted as an input, and the system reacts automatically without the user having to issue an explicit command.
**014. Consider distributed transaction processing. Explain through an example the ”all-or-nothing” characteristic property.**
- The "all-or-nothing" property is **Atomicity** from ACID.
- *Example:* A bank transfer transaction involves two operations: 1) Debit £100 from Account A. 2) Credit £100 to Account B.
- **All:** If both operations succeed, the transaction **commits**, and both updates become permanent.
- **Nothing:** If the debit succeeds but the credit fails (e.g., network error), the transaction **aborts**. The system must **roll back** the debit, restoring Account A to its original balance. The system state is as if the transaction never started.
**015. Customers interact with a transaction processing system over a Web interface but confirmation are also sent by email, such as "Please collect from your local branch". Should the email message be generated before, during, or after the process of committing the order transaction? What are the advantages and disadvantages of such an approach? Justify your design decision in terms of system complexity and durability over a system crash.**
- The email should be generated **after** the transaction successfully commits.
- **Reasoning (Durability & Complexity):**
    - **After Commit:** Ensures the email is only sent for **durable, confirmed orders**. If a crash occurs after commit but before email sending, a recovery process can re-send the email. This is **safer** and simpler to reason about.
    - **Before/During Commit:** Risks sending an email for an order that later fails to commit (violating atomicity) or is rolled back. This leads to incorrect user communication and greater **system complexity** to handle retractions or compensate.
- **Justification:** Post-commit generation cleanly separates the **durable business transaction** from the **notification side-effect**, simplifying failure recovery and ensuring data consistency.
**016. What was the fundamental flaw in the **Distributed Shared Memory (DSM)** approach that led to its decline as a mainstream HPDCS model?**
- It tried to mimic the **shared memory programming model** of a multiprocessor across a network, but the **performance penalty** of page faults over the network was too high. The **latency** of fetching remote memory pages via the network was orders of magnitude worse than local RAM access, making it unable to compete with true **shared-memory multiprocessors** on performance.
- *Explanation:* This tests understanding of why a specific architectural style failed, highlighting the critical impact of **network latency**.
**017. In a typical **cluster computing** setup, what are the distinct roles of the **master node** and the **compute nodes**?**
- **Master Node:** Acts as the **job scheduler and resource manager**. It receives user jobs, manages a **batch queue**, allocates tasks to compute nodes, monitors their health, and provides the user interface/access point to the cluster. It runs the cluster **middleware**.
- **Compute Nodes:** Are **worker machines** that execute the actual computational tasks assigned by the master. They are typically **homogeneous, commodity machines** interconnected by a high-speed network.
- *Explanation:* This drills down into the specific architecture of clusters, a foundational HPDCS type.
**018. The evolution from Cluster -> Grid -> Cloud computing represents a shift in key characteristics. Match the characteristic on the left with the system type on the right that best exemplifies it.**
    1. Single administrative domain, homogeneous hardware.
    2. Federation of heterogeneous resources across multiple organisations.
    3. Resources provided as an on-demand, pay-per-use utility.
    A. Cloud Computing
    B. Grid Computing
    C. Cluster Computing
- **1 -> C (Cluster Computing)**
- **2 -> B (Grid Computing)**
- **3 -> A (Cloud Computing)**
- *Explanation:* This is a concise way to test the defining traits of each HPDCS type from the comparison table/notes.
**019. Which of the following is a defining characteristic of **Cloud Computing** that distinguishes it from Grid Computing?**
    A. It uses virtualised resources.
    B. It spans multiple administrative domains.
    C. It operates on a pay-per-use economic model.
    D. It provides high-performance computing.
- **C. It operates on a pay-per-use economic model.**
- *Explanation:* **A** is true but also applies to modern grids. **B** is a defining characteristic of *Grid* computing. **D** is a goal of HPDCS in general. The **utility/economic model** is a core differentiator for cloud.
**020. In the cloud computing stack (Hardware, Infrastructure, Platform, Application), what is the key responsibility of the **Platform** layer, and what service model does it provide?**
- The **Platform** layer provides a higher-level **runtime environment, development tools, databases, and APIs** that allow developers to build, deploy, and manage applications without worrying about the underlying infrastructure (OS, servers, storage). This is delivered as **Platform-as-a-Service (PaaS)**.
- *Example:* Google App Engine, Microsoft Azure App Service.
- *Explanation:* Tests understanding of the specific layers of the cloud stack and their corresponding service models (IaaS, PaaS, SaaS).
**021. In the context of **Enterprise Application Integration (EAI)**, what is the primary function of a **Transaction Processing (TP) Monitor**?**
- The TP Monitor acts as **middleware** that **coordinates** the execution of a transaction that spans multiple, potentially distributed, servers. It ensures the **ACID properties** (especially Atomicity and Isolation) are maintained across all participants, typically using protocols like **two-phase commit**.
- *Explanation:* This defines a key component of distributed information systems, linking transactions to middleware.
**022. Using the **coupling dimensions** (Space and Time), classify the following communication paradigms: (i) Synchronous Remote Procedure Call (RPC), (ii) Persistent Message Queuing, (iii) Publish-Subscribe with immediate delivery.**
- **(i) Synchronous RPC:** **Spatially Tight** (client must know server's endpoint) and **Temporally Tight** (both must be active, caller blocks).
- **(ii) Persistent Message Queuing:** **Spatially Tight** (producer knows the specific queue) and **Temporally Loose** (messages are stored; consumer can process later).
- **(iii) Pub/Sub with immediate delivery:** **Spatially Loose** (communicate via topics) and **Temporally Tight** (subscriber must be running to receive the immediate broadcast).
- *Explanation:* Applies the core coupling framework from the notes to concrete examples.
**023. What is the key advantage of moving from a **tightly-coupled** system design (e.g., direct RPC) to a **loosely-coupled** one (e.g., message queues)?**
- The key advantage is **improved scalability and fault tolerance**. Loosely-coupled systems allow components to be **added, removed, or fail independently** without cascading failures. They also enable **asynchronous processing**, which helps absorb load spikes and hides latency.
- *Explanation:* Tests the understanding of the trade-off and the rationale behind the architectural shift towards loose coupling.
**024. A **Disruption-Tolerant Network (DTN)** is designed for environments with no continuous connectivity. Describe its core routing strategy and provide a real-world example of its use.**
- **Core Strategy:** **Store-Carry-Forward.** A node receives a message, stores it locally, physically **carries** it (by moving), and **forwards** it to another node when a communication opportunity arises. This repeats until the message reaches its destination.
- **Example:** **Wildlife tracking networks.** A sensor on an animal collects data. When the animal comes near a stationary gateway node (e.g., at a watering hole), the sensor forwards its stored data. The gateway later relays it via a satellite link.
- *Explanation:* Tests a key concept from mobile/pervasive computing with a practical scenario.
**025. What is the primary reason **in-network processing** is essential in wireless sensor networks, as opposed to sending all raw data to a central server?**
- To **conserve the limited energy** of battery-powered sensor nodes. Transmitting raw data over a wireless radio is a **major power drain**. By processing and **aggregating data locally** (e.g., computing an average, detecting an event), sensors can drastically reduce the volume of data that needs to be transmitted, thereby **extending network lifetime**.
- *Explanation:* This gets to the heart of the design constraint for sensor networks and justifies their unique architecture.
**026. Google Spanner achieves global **external consistency**. What technological innovation enables this, and how does it differ from traditional logical clocks?**
- The innovation is **TrueTime**. It is a **globally synchronized physical clock API** that exposes **bounded clock uncertainty**. Unlike **logical clocks** (e.g., Lamport timestamps) that only track causal *order*, TrueTime provides **tightly synchronized absolute time** using a combination of **GPS receivers and atomic clocks** in Google's data centers. This allows Spanner to assign globally meaningful commit timestamps.
- *Explanation:* Tests understanding of a cutting-edge case study that combines time synchronization with database consistency.
**027. A research consortium spanning three universities wants to run a climate simulation that requires more compute power than any single member has. They agree to share their existing clusters. This is best described as an example of:**
    A. Cluster Computing
    B. Grid Computing
    C. Cloud Computing
    D. Utility Computing
- **B. Grid Computing**
- *Explanation:* The scenario involves **federating resources from multiple independent administrative domains** (the universities) into a **Virtual Organization (VO)** for a common goal. This is the essence of Grid computing. It is not a single managed cluster (A), a paid utility service (C/D), though cloud could also be used, the described *sharing* model is classic Grid.
**028. Which of the following is a **core requirement of Ubiquitous Computing Systems (UCS)**, as distinct from just being "distributed"?**
    A. Use of middleware.
    B. Context awareness.
    C. Transactional support.
    D. Replication for fault tolerance.
- **B. Context awareness.**
- *Explanation:* While A, C, and D are common in many distributed systems, **context awareness** (the system's ability to understand and react to the user's situation) is a defining requirement for systems that are "pervasive" and "unobtrusive."
### **3. Architectures**
**001. What is the process perspective?**
- The **process perspective** examines a DS in terms of the **types of processes** (e.g., clients, servers, peers) that execute, their **roles, lifecycles, and relationships** (e.g., how they are created, communicate, and synchronise).
**002. What is the communication perspective?**
- The **communication perspective** examines the **facilities and paradigms** for data exchange between processes (e.g., **RPC, message passing, pub/sub**), focusing on protocols, reliability, and the **abstraction** provided to programmers.
**003. Describe the integrative view of a DS.**
- The **integrative view** sees a DS as **connecting existing networked computer systems into a larger, unified system**. It focuses on federation and interoperability of pre-existing autonomous systems.
**004. Describe the expansive view of a DS.**
- The **expansive view** sees a DS as an **existing networked computer system that is extended with additional computers**. It focuses on scaling out a single system's capacity and reach.
**005. Which of the following is an example of a distributed system?**
- A client-server architecture.
- The client-server model is the foundational architectural style for most distributed systems. It explicitly separates the user interface/client from the data processing/server, which are typically located on different networked machines, fulfilling the definition of a distributed system.
**006. Consider an online gaming application A that makes use of a library LOS to interface to an operating system. At the same time, the application uses a specialised rendering library LRend that has been implemented by also making use of LOS. What kind of architectural style is this? Simply provide its name.**
- **Layered architecture.**
- The system is structured into **hierarchical layers**. The application (A) is the top layer, which uses services from LRend (middle layer), which in turn uses services from LOS (lower layer). LOS provides foundational OS services to both upper layers.
**007. In the **layered architectural style**, what is the typical direction of calls between components, and what is a classic real-world example of this style?**
- Calls typically flow as **downcalls** from a higher layer to a lower layer. The lower layer provides a service to the layer above it via a defined interface.
- **Classic Example:** A **communication protocol stack**, such as the **TCP/IP model**. Each layer (e.g., Application, Transport, Network, Link) offers a specific service to the layer above and uses the services of the layer below.
- *Explanation:* Tests the fundamental rule and a key application of the layered style.
**008. In the context of the **PAD model** for application layering, what are the three logical tiers and their primary responsibilities?**
1.  **Presentation Tier:** Handles the **user interface** (UI). Its responsibility is to display information and capture user input.
2.  **Application (or Logic) Tier:** Contains the **core business logic and processing rules**. It processes requests, makes decisions, and performs calculations.
3.  **Data Tier:** Manages **persistent data storage and retrieval**. Its responsibility is to provide reliable access to data, typically via a database.
- *Explanation:* This is a fundamental model for structuring applications, especially in client-server systems.
**009. In a **distributed object architecture**, what is the role of the **proxy** (or client stub)?**
- The **proxy** is a local representative (stub) of the remote object that resides on the client's machine. It **marshals** method arguments into a network message, sends the request to the server where the real object resides, **unmarshals** the reply, and returns it to the client application. This makes the remote method call appear **local** to the client programmer.
- *Explanation:* Tests understanding of a key mechanism that enables the object-based style.
**010. Which architectural style is characterised by modelling a system as a collection of uniquely named **resources** that are manipulated through a **uniform, stateless interface**? Provide the name of this style and a common set of operations it uses.**
- **Resource-centred architecture** (exemplified by **REST**).
- The common uniform interface operations are **CRUD**: Create (**POST**/PUT), Retrieve (**GET**), Update (**PUT**/PATCH), Delete (**DELETE**).
- *Explanation:* Directly tests the definition and key principle of the resource-centred/REST style.
**011. How does an **event-based (publish-subscribe) architecture** achieve **loose coupling** between components?**
- It achieves loose coupling primarily through **referential decoupling**. Publishers and subscribers do **not need to know each other's identities or locations**. They communicate indirectly via an **event bus** or **broker**, using logical **topics** or **content filters**. A publisher emits an event to a topic, and the broker delivers it to all subscribers interested in that topic.
- *Explanation:* Highlights the core benefit and mechanism of the pub/sub style.
**012. What is the key difference between **event-based coordination** and **shared data space** coordination in terms of temporal coupling?**
- In **event-based coordination**, processes are often **temporally coupled**; the subscriber must be active and listening at the moment the event is published to receive it immediately (unless persistent queues are used).
- In a **shared data space**, processes are **temporally decoupled**; a process can write a tuple (data item) into the shared space and terminate. Another process can read that tuple at a much later time.
- *Explanation:* Tests the nuanced difference between two related but distinct styles within the event-driven paradigm.
**013. In a **centralised system architecture**, what are the defining roles in the **client-server model**?**
- **Server:** A **provider of a service**. It is a passive entity that waits for requests, processes them, and sends back replies. It manages resources (data, compute).
- **Client:** A **consumer of a service**. It is an active entity that initiates communication by sending a request to a server and then waits for a reply.
- *Explanation:* Tests the foundational roles of the most common system architecture.
**014. Compare the **2-tier** and **3-tier** client-server architectures. What is the primary advantage of moving to a 3-tier design?**
- **2-Tier:** The client communicates directly with the server. The client often contains both **presentation logic and application logic** (fat client), while the server handles the data.
- **3-Tier:** Introduces a separate **application server tier** between the client (presentation) and the database server (data). The application server contains the core business logic.
- **Primary Advantage:** **Improved scalability, maintainability, and security.** The middle tier can pool database connections, implement complex transaction logic, and serve many thin clients. It also allows the presentation and data tiers to evolve independently.
- *Explanation:* Tests a key evolutionary step in centralised architectures.
**015. In a **decentralised Peer-to-Peer (P2P) system**, all nodes are **servants**. What does this term mean?**
- A **servant** is a peer that acts as both a **client** (by making requests to other peers) and a **server** (by receiving and responding to requests from other peers). There is no permanent distinction between clients and servers.
- *Explanation:* Tests the key egalitarian concept of P2P systems.
**016. What is the fundamental difference between an **unstructured** and a **structured** P2P overlay network?**
- **Unstructured P2P:** The network is formed **ad-hoc**; connections between peers are arbitrary. There is **no deterministic relationship** between a data item's identifier and its location. Searching requires **flooding** or **random walks**.
- **Structured P2P:** Peers organise themselves into a **specific, deterministic topology** (e.g., a ring, a hypercube). Data items are assigned to specific peers based on a consistent hash of their key, creating a **Distributed Hash Table (DHT)**. This allows for **efficient, predictable routing** to locate data.
- *Explanation:* Tests a critical classification within P2P architectures.
**017. The **edge-server system** is an example of a **hybrid architecture**. Explain how it combines elements of centralised and decentralised designs.**
- It combines **centralised management** (the origin server in a core data centre controls and distributes content) with **decentralised deployment** (multiple, geographically dispersed edge servers cache and serve that content to end-users). The system appears decentralised to users (they connect to a local edge), but is logically centralised in its control and data origin.
- *Explanation:* Tests understanding of hybrid models, a key modern architecture for scalability.
**018. Match the architectural style on the left with its most accurate description on the right.**
    1. Layered
    2. Object-based
    3. Resource-centred
    4. Event-based (Publish-Subscribe)
    A. System composed of encapsulated components communicating via method invocations.
    B. System structured as hierarchical levels, where each layer provides a service to the one above.
    C. System modelled as named resources manipulated through a uniform interface.
    D. System where components interact by generating and reacting to notifications.
- **1 -> B**
- **2 -> A**
- **3 -> C**
- **4 -> D**
- *Explanation:* A quick classification test for all four core architectural styles.
**019. In the diagram of a 4D hypercube used for a structured P2P network, if node `0110` wants to find data with key `1101`, what is a key property of the routing process?**
- The routing process is **deterministic and efficient**. The request will be forwarded through connected neighbours in the hypercube, with each hop **"correcting"** one bit of the address to move closer to the destination node responsible for key `1101`. The maximum number of hops is the number of dimensions (4 in this case).
- *Explanation:* Applies the concept of structured P2P routing to a specific example from the notes.
**020. Why is the **proxy** essential in a distributed object architecture? What problem does it solve?**
- It solves the problem of **location transparency** and **programming complexity**. It **hides** all the network communication details (marshalling, sending, receiving, unmarshalling) from the application programmer. The programmer simply calls a method on a local object (the proxy), making distributed programming similar to local programming.
- *Explanation:* Goes deeper into the *purpose* of a key component in the object-based style.
### **4. Communication**
**001. Which protocol is commonly used for reliable communication in distributed systems?**
- TCP.
- The Transmission Control Protocol (TCP) provides a reliable, ordered, and error-checked delivery stream between applications running on hosts. This reliability is crucial for many distributed system communications.
**002. In a distributed system, what does RPC stand for?**
- Remote Procedure Call.
- RPC is a key communication paradigm that allows a program to execute a procedure (a subroutine) on another machine as if it were a local call, abstracting the complexities of network communication.
**003. What does the term endianness refer to in distributed systems?**
- The order of bytes in a word.
- Endianness defines the sequential order in which bytes of a multi-byte data word (like an integer) are stored in memory or transmitted over a network. It is a critical consideration for data marshalling.
**004. What is the main difference between little-endian and big-endian formats?**
- Big-endian stores the most significant byte first while little-endian stores the least significant byte first.
- In **big-endian**, the most significant byte (the "big end") is stored at the lowest memory address. In **little-endian**, the least significant byte is stored first. Systems must agree on a format for correct data interpretation.
**005. The intra-Lilliputian quarrel was over...**
- the practice of breaking eggs, smaller vs larger end (little vs big endian).
- This is a reference to *Gulliver's Travels*, used as an analogy for the **endianness** debate in computing. The Lilliputians fought a war over whether to break a boiled egg from the "little end" or the "big end," paralleling the disagreement over byte order (big-endian vs. little-endian) in data representation, a key issue in data marshalling for RPC.
**006. In the context of RPC, stubs make the remote procedure call appear as a local call to the client, hiding the complexities of network communication.**
- True.
- This statement is **true**. The **client-side stub** (or proxy) is responsible for **marshalling** parameters, sending the request over the network, and **unmarshalling** the reply. To the client application, calling the stub looks exactly like calling a local function, which is the key abstraction of RPC.
**007. In the context of RPC, which of these statements is true:**
- Serialisation is part of marshalling.
- **Marshalling** is the complete process of preparing a procedure call for network transmission. This includes gathering parameters, converting them to a network-standard format (handling endianness, data types), and writing them into a message buffer. **Serialisation** is a key sub-task of marshalling: transforming complex data structures (objects) into a linear sequence of bytes.
**008. What is the main advantage of using a publish-subscribe model in distributed systems?**
- Scalability and decoupling of components.
- The publish-subscribe model decouples message producers (publishers) from consumers (subscribers) in time and space. Publishers and subscribers don't need to know each other, leading to highly scalable and flexible architectures.
**009. What is the purpose of a message queue in a distributed system?**
- To store messages temporarily.
- The core function of a message queue in Message-Oriented Middleware (MOM) is **persistent asynchronous communication**. It acts as an intermediate buffer that stores messages, decoupling the sender (producer) and receiver (consumer) in time. This ensures messages are not lost if the receiver is temporarily unavailable. While some advanced queues can offer ordering guarantees (e.g., FIFO within a partition), "ensuring messages are delivered in order" is a specific feature, not the universal primary purpose of all message queues.
**010. Consider a distributed system supported by message queues. A process needs to install a callback function, which is automatically invoked whenever a message is put into a specified queue. Such notification can be implemented by...**
- a handler.
- This is typically implemented via an **event handler** or **callback handler**. The process registers a function with the messaging middleware. When a new message arrives in the specified queue, the middleware's event system **triggers** or **calls** the registered handler function, passing the message as an argument.
**011. In a distributed system, how long does it take to send a file from a sender host A to a receiver host B considering the following assumptions: the file size is 256 MegaBytes, the communication link is 5.12 GigaBytes/second, and the propagation delay is 30 milli-seconds. Note: 1 Giga = 1,000 Mega**
- 0.08 seconds (80 milliseconds).
- **Explanation & Working:**
    1.  **Convert units for consistency:** Bandwidth is `5.12 GB/s = 5120 MB/s`.
    2.  **Calculate transmission time:** `Time_tx = Size / Bandwidth = 256 MB / 5120 MB/s = 0.05 s`.
    3.  **Add propagation delay:** `Time_prop = 0.030 s`.
    4.  **Total Time (for a single packet/message model):** `Total = Time_tx + Time_prop = 0.05s + 0.03s = 0.08 s` or **80 ms**.
    *Note: This uses the simple formula: `Total Time = (Message Size / Bandwidth) + Propagation Delay`.*
**012. You are initiating an MPI program with the command `mpirun -np 4 ./myprog`. What does the call to `MPI_Init` do?**
- Enable the 4 independent programs subsequently to communicate with each other.
- `MPI_Init` initialises the MPI execution environment. For the command `mpirun -np 4`, it sets up the necessary data structures and communication channels so that the**04 separate processes** (instances of `./myprog`) can identify each other and exchange messages using MPI primitives like `MPI_Send` and `MPI_Recv`.
**013. When implementing a distributed system design, determine which transport layer protocol is most appropriate for the following applications:**
**(i) Real-time streaming**
- **UDP.** Low overhead and no retransmission delays are critical for timeliness; packet loss is preferable to late data.
**(ii) File transfer that is used across the Internet**
- **TCP.** Reliability and in-order delivery are essential for file integrity.
**(iii) A clock synchronising service for all computers in a local network**
- **UDP.** Used by protocols like **NTP**. It's lightweight, and timestamps in packets account for delay; occasional loss is acceptable.
**(iv) A local file sharing application in which clients need to automatically locate the server and cannot rely on the name service to be present.**
- **UDP.** Used for **broadcast** or **multicast** discovery protocols (e.g., SMB browsing). TCP requires a known endpoint to connect to.
**014. You are required to develop a cloud application that uses publish-subscribe to communicate between entities developed in different languages. Producers should be written in C++ and consumers should be in Java. Distributed components communicate with one another using AMQP. Explain how to develop such application.**
1.  **Choose an AMQP Broker:** Deploy a message broker like **RabbitMQ** or **Apache ActiveMQ**.
2.  **Define the Exchange & Topics:** On the broker, configure a **topic exchange**. Define a logical topic naming structure (e.g., `sensor.temperature.floor1`).
3.  **Develop C++ Producers:** Use a **C++ AMQP client library** (e.g., rabbitmq-c). Write code to connect to the broker, declare the exchange, and **publish** messages to specific topics. Data should be serialized into a broker-agnostic format (e.g., **JSON**, **Protocol Buffers**).
4.  **Develop Java Consumers:** Use a **Java AMQP client library** (e.g., amqp-client). Write code to connect to the broker, declare a temporary queue, **bind** that queue to the exchange with a topic pattern, and **subscribe** to start consuming messages. Deserialize the messages from the wire format.
5.  **Key:** The **AMQP protocol** and the **broker** provide the interoperability layer. The common wire format ensures language-agnostic data exchange, achieving **loose coupling**.
**015. Consider a message queue system. In order to automatically start a process to fetch messages from an input queue, a daemon is often used that monitors the input queue. Propose a simple, alternative implementation that does not make use of a daemon.**
- Use a **callback** or **event-driven** mechanism integrated with the message broker.
- **Implementation:** The consumer process registers itself with the broker (e.g., using AMQP's `basic.consume`). Instead of polling, the consumer provides a **callback function**. When a message arrives in the queue, the broker **actively pushes** the message to the consumer and invokes the callback. The consumer process is always running but blocks idly until the broker delivers a message.
**016. In 221 B.C., Emperor Qin unified several formerly warring states... How does this statement relate to SOAs and Web Services?**
- It is an analogy for the **standardisation** required in **SOAs** and **Web Services**.
- **Standard "cart wheel" distance (wheel gauge):** Analogous to **standard communication protocols** (HTTP, SOAP, AMQP) that ensure components can "travel" on the same network.
- **Common written language:** Analogous to **standard data formats** (XML with WSDL/XML Schema for SOAP, JSON for REST) that allow components to understand each other's messages regardless of implementation.
- **Strong defenses (Great Wall):** Analogous to **standard security protocols** (HTTPS, WS-Security, OAuth) that protect the system.
- **Result:** Just as standards unified China, **technical standards** enable **interoperability**, **composability**, and **scalability** in SOA by allowing diverse services to work together seamlessly.
**017. What are the two fundamental performance metrics for a communication channel? Define each one.**
- **Latency:** The **delay** or time it takes for a single message (or the first bit of data) to travel from the source to the destination. It is limited by physical laws (speed of light) and processing delays.
- **Bandwidth:** The **capacity** or maximum data transfer rate of the channel, measured in bits/bytes per second. It defines the volume of data that can be pushed through the pipe.
- *Explanation:* Tests the definitions of the two core concepts that govern all communication performance.
**018. The total time \( T \) to transfer a message of size \( S \) over a link with latency \( L \) and bandwidth \( B \) is given by the formula: \( T = L + S/B \). For a 1 MB file sent over a link with 50 ms latency and 100 Mbps bandwidth, which term dominates the total time? Show your working.**
- **Calculation:**
    - \( S = 1 \text{ MB} = 8 \text{ Mbits} \)
    - \( B = 100 \text{ Mbps} \)
    - \( S/B = 8 / 100 = 0.08 \text{ seconds} = 80 \text{ ms} \)
    - \( T = 50 \text{ ms} + 80 \text{ ms} = 130 \text{ ms} \)
- **Dominant Term:** The **bandwidth term (\( S/B = 80 ms \))** is larger than the latency term (50 ms), so it dominates. For smaller messages or higher bandwidth, latency would dominate.
- *Explanation:* Applies the core formula and tests understanding of when each metric is the limiting factor.
**019. In the layered protocol model, what is the purpose of the **Middleware** layer that sits above the transport layer (e.g., TCP)?**
- The **Middleware** layer provides **common, high-level services** to distributed applications, such as **secure communication (RPC, RMI), naming, resource location, and data marshalling**. It abstracts away the heterogeneity of underlying operating systems, networks, and hardware, allowing application developers to focus on business logic rather than low-level communication details.
- *Explanation:* Defines the role of middleware in the communication stack, a key concept from the adapted layering scheme.
**020. Classify the following communication scenarios as either **Synchronous** or **Asynchronous**, and **Transient** or **Persistent**.**
    a) A client sends an HTTP request to a web server and blocks waiting for the HTML response.
    b) A sensor sends a temperature reading to a message queue. A separate analytics service retrieves and processes it an hour later.
    c) An MPI program uses `MPI_Send` to pass data to another process in a tightly-coupled cluster.
- **a) Synchronous & Transient.** The client blocks (synchronous), and the HTTP request is not typically stored if the server is down (transient).
- **b) Asynchronous & Persistent.** The sensor doesn't wait for processing (asynchronous). The message is stored in the queue until the analytics service is ready (persistent).
- **c) Synchronous & Transient.** `MPI_Send` typically blocks until the receiver is ready (synchronous). MPI messages are not stored if the target process isn't listening (transient).
- *Explanation:* A direct application of the two key dimensions for classifying communication types.
**021. What is a major disadvantage of using **transient communication** (as opposed to persistent) in a distributed system?**
- **Lack of reliability in the face of failures.** If the receiver process or machine is not running at the exact moment the sender transmits, the message is **lost forever**. This makes it unsuitable for scenarios requiring guaranteed delivery, such as financial transactions or job submissions in unreliable environments.
- *Explanation:* Tests the implication and trade-off of choosing transient messaging.
**022. In the RPC abstraction, what specific tasks are performed by the **client-side stub**? (List at least three).**
1.  **Marshalling/Serialisation:** Converts the procedure parameters from the client's local memory representation into a standard network format (handling endianness, data types).
2.  **Communication:** Sends the marshalled request message over the network to the server.
3.  **Synchronisation:** Blocks the client process (in synchronous RPC) while waiting for the server's reply.
4.  **Unmarshalling/Deserialisation:** Converts the reply message from the network format back into the client's local memory representation.
5.  **Returning the result:** Presents the unmarshalled result to the client application as the return value of the local call.
- *Explanation:* Details the responsibilities that enable the RPC transparency illusion.
**023. What is the key conceptual difference between **RPC (Remote Procedure Call)** and **RMI (Remote Method Invocation)**?**
- **RPC** is centred on calling **remote procedures or functions**. It is a procedural programming abstraction.
- **RMI** is the **object-oriented extension** of RPC. It is centred on invoking **methods on remote objects**. This involves not just calling a function, but also dealing with object references, state, and potentially polymorphism/inheritance.
- *Explanation:* Tests the evolution from a procedural to an object-oriented communication paradigm.
**024. The **Message-Passing Interface (MPI)** is designed for a specific environment. What is that environment, and what does this imply about the **transient vs. persistent** nature of its communication?**
- MPI is designed for **High-Performance Computing (HPC) environments**, specifically for **tightly-coupled parallel programs** running on clusters or supercomputers.
- This implies its communication is **transient**. It assumes all processes are started together (`mpirun`), are all running for the duration of the job, and have high-speed, reliable interconnects. There is no need for persistent message storage because the system is controlled and failures often mean the entire job is restarted.
- *Explanation:* Links the design of a specific technology (MPI) to the communication classification and its target use case.
**025. What is the primary role of the **AMQP broker** (e.g., RabbitMQ) in a message-oriented middleware system?**
- The **AMQP broker** is the central message routing and intermediation engine. Its primary roles are to:
    1.  **Accept messages** from publishers/producers.
    2.  **Route and deliver** those messages to the correct queues based on defined rules (exchanges and bindings).
    3.  **Store messages persistently** in queues until consumers are ready.
    4.  **Deliver messages** to consumers, potentially acknowledging successful processing.
- It enables the **decoupling** of producers and consumers.
- *Explanation:* Defines the core component of an AMQP-based MOM system.
**026. Asynchronous RPC (aRPC) is used to avoid client blocking. Describe two common implementation patterns for handling the server's reply in an aRPC system.**
1.  **Callback:** The client provides a **callback function** (or handler) when it makes the aRPC call. When the server's reply arrives, the RPC runtime automatically invokes this callback with the result.
2.  **Future/Promise:** The aRPC call immediately returns a **future** (or promise) object to the client. This object is a placeholder for the eventual result. The client can later **poll** this future or **block on it** to retrieve the actual result once it is available.
- *Explanation:* Tests knowledge of the mechanisms that make RPC asynchronous, a key variant mentioned in the notes.
**027. In the context of data marshalling, why is agreeing on a **common data representation** (like XDR or Protocol Buffers) more robust than simply converting between different machine-specific formats (e.g., big-endian to little-endian)?**
- A **common data representation** defines a single, canonical format for all data on the wire. Every sender converts *to* this format, and every receiver converts *from* it. This is an **N-to-1-to-N** conversion problem, which is simpler and less error-prone. The alternative (direct conversion between every pair of formats) is an **N-to-N** problem, requiring a conversion routine for every possible pair of heterogeneous systems, which is complex and unscalable.
- *Explanation:* Tests a deeper architectural reason behind the use of intermediate wire formats.
### **5. Service Oriented Architectures**
**001. In the evolution from 1-Tier to N-Tier architectures, what is the key purpose of introducing a dedicated **middle tier** (Application/Logic Tier) in a 3-tier system?**
- The key purpose is **separation of concerns** to improve **scalability, security, and maintainability**. The middle tier encapsulates the **core business logic**, shielding the database (Data Tier) from direct client connections and allowing multiple, varied client interfaces (Presentation Tier) to reuse the same logic.
- *Explanation:* Tests the fundamental rationale for moving beyond 2-tier client-server models.
**002. An N-tier architecture often emerges from integrating multiple legacy systems. What is the primary challenge this introduces, and what architectural style emerged to address it?**
- The primary challenge is **integration complexity** due to a lack of universal standards between disparate systems, requiring extensive custom middleware.
- The architectural style that emerged to address this is the **Service-Oriented Architecture (SOA)**, which treats application functionality as reusable, loosely-coupled services with standardised interfaces.
- *Explanation:* Links the problem (N-tier complexity) to the solution (SOA).
**003. According to the SOA model, what are the three core **roles** and the three core **operations**?**
- **Roles:**
    1.  **Service Provider:** The entity that hosts and implements the service.
    2.  **Service Registry (or Broker):** A directory where services are published and can be discovered.
    3.  **Service Consumer:** The entity that finds and uses the service.
- **Operations:**
    1.  **Publish:** The provider makes a service description available in the registry.
    2.  **Find:** The consumer searches the registry for a service meeting certain criteria.
    3.  **Bind:** The consumer connects to the provider using the service description and invokes the service.
- *Explanation:* Tests the fundamental conceptual model of SOA.
**004. What distinguishes a **service** in SOA from a simple **function** or **object method** in a traditional application?**
- A service in SOA is:
    1.  **Reusable:** Designed to be invoked in multiple contexts by different consumers.
    2.  **Self-contained:** It encapsulates a discrete business function with minimal dependencies.
    3.  **Accessed via a message-based interface:** Communication is through explicit, often standardised, messages rather than direct procedure calls or method invocations.
    4.  **Platform and language independent:** Its interface is defined in a neutral way to promote interoperability.
- *Explanation:* Tests the specific definition and characteristics of a "service" in the SOA context.
**005. How does SOA differ from a traditional N-tier architecture in its approach to **middleware** and **coupling**?**
- **Middleware:** In traditional N-tier, middleware (e.g., a TP monitor, app server) is often a **centralised component** managing communication between tiers. In SOA, the communication logic is **decentralised** and embedded within the service's runtime environment.
- **Coupling:** SOA emphasises **loose coupling** through standardised, message-based interfaces. Services are independent and hide their implementation. N-tier architectures, while layered, can have **tighter coupling** between tiers, especially if they share proprietary data formats or APIs.
- *Explanation:* Highlights two of the key architectural differences listed in the notes.
**006. In the SOA "vision" diagram integrating Resources, Communities, and Technologies, what is the role of standardised **Services** and **Connectivity**?**
- **Services** act as the standardised, reusable abstractions that expose functionality from **Resources** (data, compute) and **Communities** (procedures, people).
- **Connectivity** (based on standard protocols) provides the technological glue that allows these services to be discovered, bound to, and interoperate across different systems and organisational boundaries.
- Together, they enable the integration of diverse elements into a coherent, flexible distributed system.
- *Explanation:* Tests the high-level conceptual vision of SOA as an integrating force.
**007. Which of the following scenarios is the **LEAST** suitable for an SOA approach, and why?**
    A) Exposing a "currency conversion" function for use by multiple internal departments and external partners.
    B) Building a real-time, latency-critical video game engine where components need ultra-fast, direct communication.
    C) Integrating a new customer relationship management (CRM) system with an existing legacy billing system.
- **B) Building a real-time, latency-critical video game engine.**
- **Why:** SOA is optimised for **loose coupling, interoperability, and reuse** across organisational boundaries, which often comes with overhead from message-based communication, serialisation, and network hops. A game engine requires **tightly-coupled, high-performance, low-latency** communication between components, making a more integrated, monolithic, or specialised distributed architecture (like using direct sockets or a shared memory segment) more appropriate.
- *Explanation:* Applies the SOA principles to judge fitness for purpose, highlighting its trade-offs.
**008. Describe the sequence of steps in the SOA "Service Provision and Consumption" cycle, starting from a provider implementing a service.**
1.  **Implement:** The Service Provider develops and hosts the service.
2.  **Publish:** The provider registers a description of the service (e.g., in WSDL) with a Service Registry.
3.  **Find:** A Service Consumer queries the registry to locate a service that meets its needs.
4.  **Bind:** The consumer retrieves the service description from the registry and uses it to construct a request message and bind to the provider's endpoint.
5.  **Execute/Consume:** The consumer invokes the service by sending a request message; the provider executes the service and returns a response message.
- *Explanation:* Tests the dynamic workflow of service interaction in SOA.
**009. What is a key **business driver**, rather than just a technical one, for adopting an SOA?**
- **Business Agility.** SOA allows an organisation to **rapidly compose new business processes or applications** by recombining existing services ("service composition"). This enables quicker response to market changes, new partnership opportunities, or internal process improvements without rebuilding systems from scratch.
- *Explanation:* Connects the technical architecture to a core business benefit.
**010. In a 3-tier web application, the Presentation, Application, and Data tiers are typically deployed and scaled as a single logical unit or with close coordination. How does SOA change this deployment and scaling model?**
- In SOA, each **service** (which encapsulates a business function) can be **independently deployed, scaled, and updated**. The "Check Inventory" service can run on different servers, use different technologies, and be scaled up based on its own load, independently of the "Process Payment" service. This enables **fine-grained scalability and resilience**.
- *Explanation:* Contrasts the deployment granularity of SOA with that of a monolithic 3-tier app.
### **6. Web Services and REST**
**001. In a resource-based architecture, resources are addressed by...**
- URIs.
- Resource-based architectures, most notably **REST**, use **Uniform Resource Identifiers (URIs)** (or URLs) as the global, unique identifier for every resource (e.g., `https://api.example.com/users/123`). All operations are performed on these URIs using a uniform interface (HTTP methods).
**002. A large infrastructure as a service provider wants to allow users to provision new server capacity from a variety of different interface technologies. Which Web technology should the service provider use to build an interface that users can leverage? Simply choose the letter(s) corresponding to the correct answer(s).**
- **A. The company should provide an HTTP REST API.**
- *Explanation:* A **REST API** is the standard for cloud provider interfaces (e.g., AWS, Azure, OpenStack). It uses **HTTP**, a universal protocol, allowing access from any language/tool (CLI, SDKs, UI). **B (XML RPC)** is outdated. **C (CLI)** and **D (Proprietary API)** are specific implementations that would typically be built *on top of* the core REST API, not the primary interface.
**003. Consider Amazon Simple Storage Service (S3). A resource is identified by `http://BucketName.s3.amazonaws.com/ObjectName`. Fill in the gaps:**
- Amazon S3 supports only 2 resources: **Bucket** and **Object**.
- An object is placed into a **Bucket**.
- An ObjectName is referred to by means of a **Key**.
- To create an object, an application would send a **PUT** request with the **value/data** of the object.
- A **PUT** request modifies a resource by transferring a new state. *(Note: POST is for uploads, but PUT can create/replace)*.
- In principle, the protocol that is used with the service is **HTTP**.
**004. What is the core problem that **Web Services** were designed to solve in the evolution of the Internet?**
- To enable **programmatic, reliable interaction between applications** over networks, moving beyond the "linking of documents" (the Web) to the "linking of applications." They provide a standardised way for disparate systems to exchange data and invoke functionality, overcoming the unreliability of techniques like screen scraping.
- *Explanation:* Tests the historical context and fundamental *why* behind Web Services.
**005. In the context of a Service-Oriented Architecture (SOA), what are the three core roles played by entities interacting with a **Web Service**?**
1.  **Service Provider (or Publisher):** The entity that implements and hosts the web service.
2.  **Service Registry (or Broker):** A searchable directory (like UDDI) where service descriptions are published and discovered.
3.  **Service Consumer (or Requestor):** The client application that finds and invokes the web service.
- *Explanation:* Tests the SOA model as applied specifically to Web Services.
**006. Which of the following is **NOT** a key characteristic of a Web Service?**
    A) It uses standard protocols like HTTP and data formats like XML/JSON.
    B) It is tightly coupled to a specific programming language like Java.
    C) It provides a coarse-grained interface to business logic.
    D) It promotes interoperability between heterogeneous systems.
- **B) It is tightly coupled to a specific programming language like Java.**
- *Explanation:* **Interoperability and platform/language independence** are defining goals of Web Services. They are designed to be **loosely coupled** from implementation details.
**007. REST is described as an **architectural style**, not a protocol. What does this mean?**
- It means REST is a **set of constraints and design principles** (like client-server, statelessness, uniform interface) that guide how a system should be built. It is not a formal standard with a rigid specification, but rather a conceptual framework that can be implemented using existing standards like **HTTP, URI, and HTML/XML/JSON**.
- *Explanation:* Tests the important distinction between a *style* and a *standard*.
**008. What are the four fundamental principles of the REST architectural style? (Name and briefly describe each).**
1.  **Resource Identification:** Every piece of data or service is modelled as a **resource**, uniquely identified by a **URI**.
2.  **Uniform Interface:** All resources are manipulated using a constrained set of **HTTP verbs** (GET, POST, PUT, DELETE) with well-defined semantics.
3.  **Self-Descriptive Messages:** Each message contains all the information (headers, media types) necessary for its processing.
4.  **Stateless Interactions:** The server does not store any client context between requests. Each request from a client must contain all the information needed to understand and process it.
- *Explanation:* Tests the core "REST triangle" principles from the notes.
**009. Explain the meaning of **"Representational State Transfer"** (the acronym REST) in terms of client-server interaction.**
- A client retrieves a **representation** (e.g., a JSON document) of a resource, which places the client in an **application state**. That representation contains **hyperlinks** (URIs) to other related resources. By choosing to follow one of these links, the client **initiates a new request**, which **transfers** it to a new application state. The transfer of state happens via the exchange of resource representations.
- *Explanation:* Tests the conceptual model behind the name REST.
**010. What is a key **claimed benefit** of RESTful web services over other RPC-style web services (e.g., SOAP) regarding network performance and scalability?**
- **Native support for HTTP caching.** Because REST uses standard HTTP GET for retrieval, responses can be cached by clients, proxies, and CDNs. This significantly **improves performance, reduces server load, and enhances scalability** for read-heavy operations. The stateless nature of REST also simplifies horizontal scaling of servers.
- *Explanation:* Tests one of the primary advantages listed in the notes.
**011. In an HTTP request, what three main parts constitute the **Request Line**?**
- `<HTTP Method> <Request-URI> <HTTP Version>`
- *Example:* `GET /api/users/123 HTTP/1.1`
- *Explanation:* Tests the basic syntax of an HTTP request.
**012. Match the following HTTP status code categories with their meaning:**
    1. 2xx
    2. 3xx
    3. 4xx
    4. 5xx
    A) Client Error
    B) Redirection
    C) Success
    D) Server Error
- **1 -> C (Success)**
- **2 -> B (Redirection)**
- **3 -> A (Client Error)**
- **4 -> D (Server Error)**
- *Explanation:* Tests familiarity with the major HTTP status code classes.
**013. For each of the following operations on a RESTful API for a library system, specify the appropriate **HTTP method** and a sample **URI structure**.**
    a) Retrieve details of a specific book with ID `456`.
    b) Add a new book to the library catalog.
    c) Update the publisher information for book `456`.
    d) Remove book `789` from the catalog.
- **a) Retrieve book:** `GET /books/456`
- **b) Add new book:** `POST /books` (with book details in the request body)
- **c) Update book:** `PUT /books/456` (with full updated book details) or `PATCH /books/456` (with partial update)
- **d) Remove book:** `DELETE /books/789`
- *Explanation:* A practical application of REST design using HTTP verbs.
**014. What is the purpose of the `Content-Type` header in an HTTP request or response in the context of a REST API?**
- The `Content-Type` header specifies the **media type (MIME type)** of the **body** of the request or response (e.g., `application/json`, `application/xml`). This tells the recipient how to **parse and interpret** the data in the body. It is crucial for **self-descriptive messages** in REST.
- *Explanation:* Tests understanding of a key HTTP header for data interchange.
**015. How does the **statelessness** constraint of REST simplify the design and scaling of a server?**
- Because the server does not retain client session state between requests, **any server can handle any request** from a client. This eliminates the need for **session affinity (sticky sessions)** and complex state synchronization between servers. It allows requests to be trivially load-balanced across a pool of identical servers, making horizontal scaling straightforward.
- *Explanation:* Tests the implication of a core REST constraint on system architecture.
**016. The REST principle of **"Hypermedia as the Engine of Application State (HATEOAS)"** suggests that a client should need no prior knowledge of an API beyond an initial URI. How is this achieved?**
- It is achieved by **embedding hyperlinks within the resource representations** returned by the server. The client discovers available actions and navigates the API by following these links, much like a human browses the web. The server guides the client's state transitions by providing the relevant URIs in each response.
- *Explanation:* Tests the advanced concept of HATEOAS, which is part of the REST hypermedia constraint.
**017. In the provided "Boeing" REST example diagram, what does the sequence of `GET` requests and the returned XML documents illustrate?**
- It illustrates the **"Representational State Transfer"** concept. The client starts with a known URI, performs a `GET`, and receives an XML representation (e.g., a parts list). That representation contains **hyperlinks** to other resources (e.g., specific parts). The client follows one of those links with another `GET` to retrieve a new representation (part details), thereby transferring its application state.
- *Explanation:* Tests interpretation of a key diagram from the notes.
### **7. Programming RESTful Web Services**
**001. Using a programming language of your choice (Java, C++, Python), create a data packet format to hold the following object data... Provide an illustration of the serialised form of your data packet and state any assumptions that you make.**
- *Assumption:* Using **JSON** for language-agnostic, human-readable serialisation over HTTP.
- *Python Example (using `json` module):*
    ```python
    import json
    data = {
        "customer_name": "Jeff Lebowski",
        "customer_age": 42,
        "address": "71 Mulholland Drive, Fargo, Old County, UK"
    }
    serialized_packet = json.dumps(data)
    ```
- **Illustration of Serialised Form (the actual string):**
    ```
    {"customer_name": "Jeff Lebowski", "customer_age": 42, "address": "71 Mulholland Drive, Fargo, Old County, UK"}
    ```
- *Key Points:* The packet is a string. JSON handles basic data types (string, number). For complex systems, **Protocol Buffers** or **Avro** might be used for efficiency.
**002. You are designing a RESTful API for a library system. Write a **Flask-RESTful** class definition for a `BookResource` that supports the following operations:**
    - `GET /books/<id>`: Retrieve a single book by its ID (return JSON).
    - `PUT /books/<id>`: Update a book's details using JSON data from the request.
    - `DELETE /books/<id>`: Remove a book from the catalog.
*Assume an in-memory dictionary `books = {}` maps IDs to book objects. Provide the Python code for the class.*
```python
from flask_restful import Resource, reqparse
books = {}  # In-memory storage: {id: {'title':..., 'author':...}}
parser = reqparse.RequestParser()
parser.add_argument('title', type=str, required=True)
parser.add_argument('author', type=str, required=True)

class BookResource(Resource):
    def get(self, book_id):
        """GET to retrieve a book by ID."""
        book = books.get(book_id)
        if book is None:
            return {'message': 'Book not found'}, 404
        return book, 200  # Returns JSON automatically

    def put(self, book_id):
        """PUT to update a book."""
        args = parser.parse_args()  # Validates request data
        books[book_id] = {'title': args['title'], 'author': args['author']}
        return books[book_id], 200  # Return updated book

    def delete(self, book_id):
        """DELETE to remove a book."""
        if book_id not in books:
            return {'message': 'Book not found'}, 404
        del books[book_id]
        return '', 204  # No content on successful deletion
```
*Explanation:* Tests practical implementation of CRUD endpoints using Flask-RESTful, including HTTP status codes.
**003. In JAX-RS (Java), what is the purpose of the `@Produces` and `@Consumes` annotations? Provide an example of their use in a method signature.**
- **`@Produces`** declares the **Media Type (MIME type)** that a resource method can **send back** to the client (e.g., `application/json`). It's used in the response.
- **`@Consumes`** declares the **Media Type** that a resource method can **accept** from the client in the request body (e.g., `application/json`). It's used for the request.
- **Example:**
    ```java
    @PUT
    @Path("/users/{id}")
    @Consumes(MediaType.APPLICATION_JSON)
    @Produces(MediaType.APPLICATION_JSON)
    public User updateUser(@PathParam("id") String id, User userData) {
        // Accepts JSON in the request body, returns JSON in the response.
    }
    ```
- *Explanation:* Tests understanding of key JAX-RS annotations for content negotiation.
**004. The JAX-RS `@Path` annotation can be used at both the class and method level. Describe how they combine to form the full URI path for an endpoint, using the provided Calculator example.**
- The **class-level `@Path`** defines the **base path** for all methods in the resource class.
- The **method-level `@Path`** defines a relative path that is **appended to the class-level path**.
- **Example from notes:** `@Path("/calc")` on the `CalcREST` class + `@Path("/add/{a}/{b}")` on the `addPlainText` method creates the full endpoint: **`/calc/add/{a}/{b}`**.
- *Explanation:* Tests the compositional nature of URI mapping in JAX-RS.
**005. What is **content negotiation** in the context of REST, and how is it demonstrated in the provided Java Calculator example?**
- **Content negotiation** is the mechanism by which the client and server agree on the **representation format** (e.g., JSON, XML, plain text) of a resource. The client indicates its preferences using the HTTP `Accept` header.
- **Demonstration in Calculator:** The `CalcREST` class has **two methods** for the same URI path (`/calc/add/{a}/{b}`). One is annotated with `@Produces(MediaType.TEXT_PLAIN)`, the other with `@Produces(MediaType.TEXT_XML)`. The JAX-RS runtime selects the appropriate method based on the client's `Accept` header (`text/plain` vs. `text/xml`).
- *Explanation:* Tests a core REST feature and its implementation in JAX-RS.
**006. Compare and contrast the primary use cases for **REST/JSON APIs** (built with Flask or Jersey) versus **gRPC with Protocol Buffers**. List two scenarios where each would be the preferred choice.**
- **REST/JSON is preferred for:**
    1.  **Public, web-facing APIs** where broad interoperability, human-readable messages, and leveraging HTTP semantics (caching, verbs) are important.
    2.  **Systems integrating with web browsers or third-party clients** where the ubiquity of HTTP/JSON is a requirement.
- **gRPC/Protobuf is preferred for:**
    1.  **High-performance internal microservices** where low latency, high throughput, and efficient binary serialisation are critical (e.g., financial trading, real-time analytics).
    2.  **Polyglot systems requiring strict interface contracts** and bi-directional streaming (e.g., IoT data ingestion, internal service mesh communication).
- *Explanation:* Tests the decision-making criteria for choosing a communication technology, as highlighted in the "Check of Understanding".
**007. What is a key advantage of using **Protocol Buffers (protobuf)** over JSON for data serialisation in an RPC context?**
- **Significantly smaller payload size and faster serialisation/deserialisation.** Protobuf uses a **binary format** and a pre-compiled schema (`.proto` file), which eliminates the need for field names in the transmitted data and allows for very efficient encoding. This reduces network bandwidth and CPU usage, which is crucial for high-performance RPC.
- *Explanation:* Tests understanding of the performance benefits of a modern serialization format.
**008. In the context of building a REST client for the Java Calculator service, what is the purpose of the `.accept(MediaType.TEXT_PLAIN)` call in the Jersey client code?**
- It sets the **HTTP `Accept` header** on the outgoing request. This tells the server which **representation format** the client prefers for the response. In this case, it instructs the server to return the result as plain text, triggering the JAX-RS runtime to invoke the method annotated with `@Produces(MediaType.TEXT_PLAIN)`.
- *Explanation:* Tests the client-side mechanism for content negotiation.
**009. When deploying a JAX-RS application (like the Calculator), what is the role of the class containing the `main` method that calls `HttpServerFactory.create(BASE_URI)`?**
- It acts as an **embedded application server** launcher. It creates and starts a lightweight HTTP server (like Grizzly) at the specified base URI, deploying the JAX-RS application. This is a simple way to run the service during development or testing without needing a full Java EE application server like Tomcat or WildFly.
- *Explanation:* Tests understanding of the deployment model shown in the example.
**010. The Flask-RESTful `TodoSimple` example uses `request.form['data']` to access data from a `PUT` request. In a modern REST API expecting JSON, how should the code be modified to properly parse a JSON request body?**
- Use Flask's `request.get_json()` method (or `reqparse` with `location='json'`). The `request.form` is for HTML form data.
- **Modified code:**
    ```python
    from flask import request
    # ... inside the put method ...
    data = request.get_json()  # Parses JSON body into a dict
    if not data or 'data' not in data:
        return {'error': 'Missing "data" field'}, 400
    todos[todo_id] = data['data']
    ```
- *Explanation:* Tests practical knowledge of handling JSON payloads in a REST framework.
**011. What is the primary role of a `.proto` file in the gRPC/Protocol Buffers ecosystem?**
- It is an **interface definition language (IDL) file**. It defines the **message structures** (data contracts) and **service interfaces** (RPC methods) in a language-neutral way. This file is then compiled by the `protoc` compiler to generate **type-safe client and server code** in various programming languages (Java, Python, Go, etc.).
- *Explanation:* Tests the foundational concept of contract-first development in gRPC.
**012. A service needs to send a high-volume stream of sensor readings from an edge device to a cloud processor. Which combination of technology from this chapter would be most suitable, and why?**
- **gRPC with Protocol Buffers.**
- **Why:** gRPC's **first-class support for bidirectional streaming** over HTTP/2 is ideal for continuous data flow. **Protocol Buffers** provide the **efficient binary serialisation** needed to minimise bandwidth usage from the edge device, which may have limited connectivity. The strict `.proto` contract also ensures data consistency.
- *Explanation:* Applies the knowledge of modern RPC technologies to a streaming IoT scenario.
### **8. Microservices, Nanoservices and Serverless**
**001. Which of the following best describes serverless computing?**
- A cloud computing model supporting function as a service where the provider dynamically manages the allocation of machine resources.
- Serverless computing is defined by the cloud provider automatically provisioning, scaling, and managing the server infrastructure required to run code, which is typically packaged as individual, event-triggered functions (FaaS).
**002. What is a key benefit of serverless computing for application development?**
- Automatic scaling based on demand.
- The cloud provider handles all scaling logic, seamlessly adjusting compute capacity in real-time to match the rate of incoming events or requests, with zero effort required from the developer.
**003. What is a “cold start” in serverless computing?**
- A performance issue when a function is invoked for the first time or after being idle.
- A "cold start" is the latency incurred when a serverless platform must provision a new execution environment (e.g., container) for a function, including loading the runtime and code. Subsequent "warm" invocations on the same environment are faster.
**004. Which of the following strategies helps reduce cold start latency in serverless applications?**
- Keeping functions warm with scheduled invocations.
- A common workaround is to use a scheduled trigger (like a cron job) to periodically invoke the function, preventing its execution environment from being deallocated by the provider and thus keeping it in a "warm" state.
**005. Which of the following is a valid trigger type for Azure Functions?**
- Azure Functions can be triggered by various sources, including HTTP requests, Azure Blob Storage, queues, and timers.
- Azure Functions, as a serverless FaaS platform, supports numerous triggers: **HTTP** (for web APIs), **Blob Storage** (file uploads), **Queues** (messages), **Timers** (scheduled jobs), and events from many other Azure services.
**006. What is a key characteristic of a microservices architecture?**
- Independent deployment of services.
- Microservices are small, autonomous services that can be developed, deployed, scaled, and updated independently of one another. This independence is a core characteristic that enables agility and continuous delivery.
**007. Which of the following is a common benefit of using microservices?**
- Easier scaling of individual components.
- Because services are independent, you can scale only the specific components that are under heavy load, rather than scaling the entire monolithic application. This leads to more efficient resource utilization.
**008. In a microservices architecture, what is the role of an API Gateway?**
- Provides a single entry point for all client requests.
- An API Gateway is a reverse proxy that sits in front of the microservices. It handles request routing, composition, protocol translation, and cross-cutting concerns like authentication and rate limiting, simplifying the client interface.
**009. What is a primary advantage of serverless architectures?**
- Reduced operational costs.
- Serverless follows a pay-per-execution model with no charge for idle resources. It eliminates the operational overhead of server provisioning, patching, and capacity planning, leading to significant cost reduction for variable workloads.
**010. Which of the following best describes a serverless function?**
- A function that is triggered by events and runs in stateless compute containers.
- A serverless function is a single-purpose, event-driven unit of code. It is executed in ephemeral, stateless containers managed entirely by the cloud platform, which are instantiated in response to triggering events.
**011. In serverless architectures, what is the role of a service like AWS Lambda?**
- To automatically manage the infrastructure required to run code.
- AWS Lambda is the execution environment. Its primary role is to abstract away all server management: it automatically runs your code on a highly available, scalable compute infrastructure in response to events.
**012. Flixnet... requires re-engineering their core application... Which solution should Flixnet adopt, serverless computing or containers? Consider: scalability, cost, maintenance, time of deployment.**
- **Containers** (e.g., Docker/Kubernetes) are the better choice.
- **Reasoning:**
    - **Scalability:** Both scale well, but containers offer more **predictable, fine-grained control** over scaling stateful, long-running processes (like video transcoding).
    - **Cost:** For a **constant, high-volume** workload, containers on reserved VMs are more **cost-effective** than the per-invocation model of serverless.
    - **Maintenance:** Containers require more ops overhead (orchestration, patching). However, for a core application with thousands of changing files, the **operational control** and ability to define the exact environment is crucial.
    - **Deployment Time:** Containers have a longer startup than a warm function but are more suitable for **stateful, complex applications** with many dependencies. Serverless suits event-driven, stateless glue code.
- **Conclusion:** The need for **control over the environment, stateful processing, and predictable performance/cost** points to containers.
**013. How does serverless computing fit into the distributed Web paradigm? Explain.**
- Serverless (specifically **FaaS**) represents the **extreme of distribution and decomposition**.
- It fits by:
    1.  **Decomposing Monoliths:** A web app backend is broken into **distributed functions**, each handling a specific API endpoint or event.
    2.  **Event-Driven Communication:** Functions are triggered by **HTTP events** (API Gateway), **queue messages**, or **database events**, forming a **loosely-coupled**, reactive distributed system.
    3.  **Managed Distribution:** The cloud provider handles the ultimate distribution concerns: **placement, scaling, and fault-tolerance** of the function execution environments across its data centres, making distribution **completely transparent** to the developer.
**014. A company has decided to leverage the web conferencing services provided by a cloud provider and to pay for those services as they are used. The cloud provider manages the infrastructure and any application upgrades. What type of cloud delivery model is this an example of?**
- **Software as a Service (SaaS).**
- The user is consuming a **complete application** (web conferencing) over the internet. The provider manages **everything** (infrastructure, platform, software). The pay-as-you-go model is typical of SaaS.
**015. Which statement best describes the relationship between application, server, and client in a multi-tenancy cloud environment?**
- **(ii) Single instance of software running on a server and serving multiple clients.**
- **Multi-tenancy** is a core SaaS characteristic where a **single, shared instance** of the application (and its underlying resources) serves **multiple client organisations** ("tenants"), with mechanisms to keep their data and configuration isolated.
**016. Microservices are often described as a specific implementation of the **SOA** pattern. How do microservices differ from a traditional, broader SOA? (Name two key differences).**
1.  **Granularity:** Microservices are **fine-grained**, with each service focused on a single, small business capability. Traditional SOA services can be **coarse-grained**, encompassing larger business functions or entire applications.
2.  **Technology & Standards:** Microservices favour **lightweight protocols** (HTTP/REST, gRPC, simple messaging) and are less prescriptive about global standards. Traditional SOA often emphasises **heavy, formal standards** like WS-* (SOAP, WSDL, UDDI) and Enterprise Service Buses (ESBs).
- *Explanation:* Tests the evolution from SOA to microservices, a key conceptual link.
**017. Why are **containers** (like Docker) considered the ideal deployment vehicle for microservices?**
- Containers provide **lightweight, isolated, and consistent runtime environments**. They package a microservice with all its dependencies, ensuring it runs the same way in development, testing, and production. This isolation allows multiple microservices to run on the same host without conflict, and their lightweight nature enables rapid startup and efficient resource utilisation, which aligns with the microservices goal of independent deployment and scaling.
- *Explanation:* Tests the synergy between container technology and the microservices architectural style.
**018. What is the primary architectural characteristic that distinguishes a **nanoservice** from a microservice, and why is this often considered an anti-pattern?**
- **Extreme Functional Granularity.** A nanoservice performs a **single, trivial function** (often just a few lines of code), whereas a microservice handles a complete business capability.
- **Anti-pattern Reason:** This leads to **excessive operational complexity** (managing, deploying, monitoring, and securing thousands of tiny services), overwhelming communication overhead (network latency between services dominates), and makes system-wide reasoning and debugging extremely difficult, often negating any theoretical benefits.
- *Explanation:* Defines nanoservices and highlights their practical drawback.
**019. In a serverless **Function-as-a-Service (FaaS)** model, the provider manages scaling. How does this scaling typically work in response to a sudden burst of events (e.g., 1000 simultaneous uploads triggering a function)?**
- The FaaS platform **automatically provisions multiple concurrent execution environments (containers)**. It will launch new instances of the function in parallel to handle the influx. Each event is routed to an available instance. The scaling is **instantaneous and transparent** to the developer, who does not need to configure auto-scaling rules or manage server clusters.
- *Explanation:* Tests the dynamic, elastic scaling promise of serverless.
**020. The **statelessness** of serverless functions is a core constraint. If a function needs to maintain user session data across multiple invocations, what is the standard architectural approach?**
- Store the state in an **external, managed persistence service** such as a **database** (e.g., DynamoDB, Cosmos DB), a **cache** (e.g., Redis), or **object storage** (e.g., S3). The function retrieves the state at the start of execution and persists any changes at the end. The function instance itself holds no persistent state.
- *Explanation:* Tests a critical design implication and solution for serverless applications.
**021. What is **function composition** in serverless architectures, and what are two common patterns for achieving it?**
- **Function composition** is the coordination of multiple serverless functions to implement a complex business workflow or application logic.
- **Common Patterns:**
    1.  **Event-Driven Chaining:** The output of one function triggers the next function via an event (e.g., a message on a queue, a database update). This creates a **loosely-coupled pipeline**.
    2.  **Orchestration:** A dedicated **orchestrator function** or service (e.g., AWS Step Functions, Azure Durable Functions) explicitly coordinates the execution sequence of multiple worker functions, managing state, retries, and error handling.
- *Explanation:* Tests how to build complex applications from simple functions.
**022. The diagram showing the evolution from Monolith -> Microservices -> Nanoservices illustrates a trend in granularity. What is the corresponding trend in **operational responsibility and complexity** for the development team?**
- As granularity increases, **operational responsibility shifts left** (towards the developer/team). In a monolith, ops might be handled by a separate team. With microservices, teams own the full lifecycle of their services ("you build it, you run it"). With nanoservices, this operational burden becomes **exponentially more complex** due to the sheer number of deployable units, requiring sophisticated automation and observability.
- *Explanation:* Tests the organisational and operational implications of architectural granularity.
**023. AWS Lambda functions can be triggered by an **API Gateway**. What key benefit does this provide for building web APIs?**
- It allows serverless functions to act as the backend for **RESTful or HTTP APIs**. The API Gateway handles HTTP protocol details (routing, request/response transformation, authentication, rate limiting), allowing the Lambda function to focus purely on business logic. It also provides a **unified, managed entry point** that can route to multiple functions.
- *Explanation:* Tests a common serverless integration pattern for web applications.
**024. In the "Check of Understanding" scenario (photo-sharing app thumbnail generation), why would implementing the feature as a **standalone microservice in a container** be *less* optimal than a serverless function?**
- A containerised microservice would require **managing a continuously running (or scaled) service** for a sporadic, event-driven task. This leads to **resource inefficiency** (paying for idle compute) and **operational overhead** (patching, monitoring the service). The serverless function, by contrast, **scales to zero** when not in use (cost-effective) and eliminates all infrastructure management.
- *Explanation:* Applies the cost and operational model trade-off to a specific scenario.
**025. What is the relationship between **microservices** and **serverless functions**? Can they be used together?**
- They are **complementary concepts**. A microservice is an **architectural style** (a small, independent service). A serverless function is an **execution model** (event-triggered, managed compute). **Yes, they can be used together.** A microservice can be **implemented as a serverless function** (if it's short-lived and event-driven), or a serverless function can act as a **glue component** in a larger microservices ecosystem (e.g., processing events from a message queue that connects microservices).
- *Explanation:* Clarifies the conceptual relationship and compatibility between the two key topics of this section.
**026. The **cold start** latency in serverless is a function of several factors. Which of the following would likely **increase** cold start time? (Select all that apply).**
    A) Using a runtime with a slow initialization time (e.g., Java JVM vs. Python interpreter).
    B) Having a large deployment package (e.g., many library dependencies).
    C) The function being invoked frequently (e.g., 100 requests per second).
    D) The function code being very simple (e.g., 10 lines).
- **A) Using a runtime with a slow initialization time.**
- **B) Having a large deployment package.**
- *Explanation:* **A** and **B** directly increase the time to provision and load the execution environment. **C** would likely lead to warm instances, reducing cold starts. **D** would decrease cold start time.
**027. The "No Servers to Manage" benefit of serverless computing is primarily about shifting responsibility. What specific **operational tasks** does the cloud provider take over from the developer?**
- The provider manages:
    1.  **Server provisioning and maintenance** (hardware, hypervisors).
    2.  **Operating system patching and security updates.**
    3.  **Capacity planning and auto-scaling.**
    4.  **Load balancing and high-availability deployment.**
    5.  **Runtime environment management** (e.g., maintaining language runtimes).
- *Explanation:* Details the concrete meaning of the "no ops" promise.
### **9. Naming Pt.1**
**001. What is the primary purpose of a naming service in a distributed system?**
- To resolve names to addresses.
- A naming service provides a mapping from human-friendly, location-independent names (like `www.example.com`) to low-level, machine-specific network addresses (like `192.0.2.1:80`), which are needed for communication.
**002. Which of the following is a characteristic of a distributed naming service?**
- Scalability.
- A naming service for a distributed system must itself be distributed and scalable to handle the vast number of names and high query rates generated by a large-scale system, without becoming a bottleneck.
**003. In a distributed system, what is a name space?**
- A set of names and their corresponding addresses.
- A namespace is the structured collection of all valid names recognized by a naming system and the bindings that associate those names with the entities (and their attributes/addresses) they represent.
**004. What is the main advantage of using hierarchical naming in distributed systems?**
- Simplifies name resolution.
- A hierarchical namespace (like DNS) allows for decentralized administration and efficient, scalable resolution. Responsibility can be delegated (e.g., `example.com` is managed independently), and lookups can be performed by walking the hierarchy.
**005. In a structured peer-to-peer system where data items are stored, the system is seen to implement...**
- a distributed hash table.
- Structured P2P systems (like Chord, Pastry) organise nodes in a deterministic overlay network (e.g., a ring) and use a **consistent hashing** function to assign keys to nodes. This creates a **Distributed Hash Table (DHT)** abstraction, providing a lookup service: `get(key)` returns the data or location of the node responsible for that key.
**006. From a local machine mycomputer.myuni.uk, you would like to access the URL `www.universityofleeds.vevox.com/discussion.html`... Draw a diagram showing the recursive name resolution process...**
*(Answer describes the process; a diagram would show hierarchical steps).*
1.  **Client -> Local DNS:** Query: "`www.universityofleeds.vevox.com`?"
2.  **Local DNS -> Root (R):** Query (if not cached).
3.  **Root -> Local DNS:** Referral to **`.com`** TLD servers.
4.  **Local DNS -> .com TLD:** Query.
5.  **.com TLD -> Local DNS:** Referral to **`vevox.com`** authoritative servers.
6.  **Local DNS -> vevox.com NS:** Query.
7.  **vevox.com NS -> Local DNS:** Referral to **`universityofleeds.vevox.com`** authoritative servers (or directly returns the A record if it's authoritative for the subdomain).
8.  **Local DNS -> universityofleeds.vevox.com NS:** Query for `www`.
9.  **universityofleeds.vevox.com NS -> Local DNS:** Returns the **A record** (IP address).
10. **Local DNS -> Client:** Returns the IP address.
- *Note:* This is **recursive resolution** from the client's perspective; the local DNS performs **iterative queries** on the client's behalf.
**007. Illustrate the use of the flat naming home-based approach in the context of this mobile phone scenario.**
1.  **Home Location (UK):** Your mobile phone is **registered with a home location register (HLR)** in the UK. The HLR stores your **permanent "home" address** (your UK phone number and home network info).
2.  **Movement to Spain:** When you enter Spain, your phone connects to a local network (Visitor Location Register - VLR). The VLR in Spain **contacts your HLR in the UK** to authenticate you and get your profile. The HLR updates its record to point to the VLR in Spain.
3.  **Call from France:** When your friend in France calls your UK number, their network queries the **international routing system**. This system ultimately contacts your **HLR in the UK**. The HLR, which has the **forwarding pointer** to the VLR in Spain, provides the current location. The call is then routed to Spain.
**008. In the context of naming, what is the difference between a **location-independent name** and an **address**?**
- A **location-independent name** is a **stable identifier** for an entity that does not change when the entity's physical location or access method changes (e.g., a user ID, a file name).
- An **address** is the **name of an access point** for an entity; it is **location-dependent** and changes if the entity moves (e.g., an IP address and port number, a MAC address).
- *Explanation:* Tests the fundamental distinction from the definitions, crucial for understanding why naming services are needed.
**009. What is the core challenge addressed by **flat naming systems**?**
- Given a simple, unstructured, unique identifier (a **flat ID**) for an entity, how can a client **locate the current access point (address)** of that entity in a large, distributed system?
- *Explanation:* States the central problem of this section.
**010. The **broadcasting** approach to flat name resolution (e.g., ARP) works well in a Local Area Network (LAN). Why does it fail to scale to a Wide Area Network (WAN) or the Internet?**
- Broadcasting generates a message that is **flooded to every node** in the network. In a WAN/Internet, this would create **prohibitive, wasteful traffic**, consuming massive bandwidth. Furthermore, routers are typically configured to **block broadcast packets** from propagating between network segments to prevent such floods.
- *Explanation:* Tests the scalability limitation of the simplest resolution method.
**011. Describe how **forwarding pointers** are used to locate a mobile entity. What is a major drawback of long chains of pointers?**
- When an entity moves from location A to B, it leaves a **pointer at A pointing to B**. A client looking for the entity starts at a known initial location and **follows the chain of pointers** until it reaches the current location.
- **Major Drawback:** Long chains are **not fault-tolerant**. If any node along the chain fails or the pointer is lost, the resolution **breaks completely**, making the entity unreachable.
- *Explanation:* Tests the mechanism and a key weakness of the forwarding pointer approach.
**012. In the **home-based approach** (e.g., Mobile IP), what are the roles of the **home agent** and the **care-of address**?**
- **Home Agent:** A designated, fixed entity on the entity's **home network** that maintains the **current location** (care-of address) of the mobile entity.
- **Care-of Address:** A **temporary address** assigned to the mobile entity when it is visiting a foreign network. It represents the entity's current point of attachment.
- The home agent **intercepts** messages sent to the entity's permanent home address and **tunnels** them to the care-of address.
- *Explanation:* Tests the key components of the home-based method.
**013. What is the primary **geographical scalability** problem with the home-based approach when a mobile entity is far from its home network?**
- Communication becomes **inefficient (triangle routing)**. A client located near the mobile entity must send messages to the distant **home agent**, which then forwards them back to the entity's current location. This long detour increases **latency** and wastes network resources, especially if the client and entity are in the same remote region.
- *Explanation:* Tests a critical performance drawback of the home-based method.
**014. A **Distributed Hash Table (DHT)** provides a `get(key)` operation. In the context of flat naming, what does the `key` typically represent, and what is the `value` returned?**
- The **key** is the **flat identifier (ID)** of the entity (e.g., a hash of a file's content).
- The **value** returned is the **network address (access point)** of the node currently responsible for or storing that entity.
- *Explanation:* Links the DHT abstraction directly to the flat naming problem.
**015. In a **hierarchical tree** approach for flat name resolution (not to be confused with DNS), describe the two-phase process of a **lookup** operation.**
1.  **Upward Search:** The request starts at the local leaf directory and moves **up the tree** (towards the root) until it finds a directory that has a record for the entity's ID.
2.  **Downward Follow:** From that directory, the request follows **forwarding pointers down the tree** (towards the leaves) until it reaches the leaf directory that holds the current address of the entity.
- *Explanation:* Tests the specific algorithm for the hierarchical approach to flat naming.
**016. Compare the **forwarding pointers** and **hierarchical tree** approaches for flat naming. Which one is more structured and potentially more scalable for a wide-area system?**
- The **hierarchical tree** approach is **more structured and scalable** for a wide-area system.
- **Forwarding pointers** create ad-hoc chains that are unpredictable and fragile.
- The **hierarchical tree** imposes a logical structure on the resolution infrastructure (mirroring network topology), making operations more predictable and efficient. Lookups involve a bounded number of hops (height of the tree), and the structure can be managed and optimized.
- *Explanation:* Tests the comparative analysis of two flat naming solutions.
**017. In the "Check of Understanding" scenario (P2P file-sharing), the answer recommends a DHT. What property of the DHT makes it resilient to the **frequent joining and leaving of nodes (churn)**?**
- DHTs are designed with **redundancy** (replicating `(key, value)` pairs on multiple successor nodes) and **self-healing routing tables**. When a node leaves, the DHT protocol automatically updates pointers (e.g., successor lists in Chord) and redistributes responsibility for keys, ensuring the `get(key)` operation can still succeed after a short stabilization period.
- *Explanation:* Tests understanding of how DHTs handle dynamism, a key requirement in P2P.
**018. Which flat naming resolution method is exemplified by the **Address Resolution Protocol (ARP)**?**
- **Broadcasting.**
- ARP resolves an IP address (a network-layer identifier) to a MAC address (a link-layer address) by **broadcasting** a query packet to all hosts on the local physical network.
- *Explanation:* A direct application question linking a core networking protocol to a naming concept.
### **10. Naming Pt.2**
**001. The DNS name space is organised...**
- hierarchically into a tree of domains, which are divided into non-overlapping zones.
- DNS uses a **hierarchical, tree-structured namespace** (e.g., `.` -> `.com` -> `example.com` -> `www.example.com`). For administrative and performance reasons, this tree is partitioned into **non-overlapping zones** (e.g., the `example.com` zone), each managed by an authoritative name server.
**002. The type of DNS record that is used to map a domain name to an IPv4 address is the MX record, True or False?**
- False. It is the A record.
- An **A (Address) record** maps a domain name to an IPv4 address. An **MX (Mail Exchange) record** specifies the mail servers responsible for receiving email for a domain.
**003. What is the primary purpose of LDAP?**
- To access and maintain distributed directory information services.
- The Lightweight Directory Access Protocol (LDAP) is an open, vendor-neutral protocol for accessing and managing hierarchical directory information, which is optimized for read-heavy operations like authentication and lookup.
**004. Which of the following is a common use case for LDAP?**
- User authentication and authorization.
- LDAP is extensively used as a central repository for user credentials and attributes (like groups and roles), enabling single sign-on (SSO) and centralized access control across many applications.
**005. In the graph representation of a structured namespace, what are the two types of nodes, and what does each store?**
1.  **Leaf Node:** Represents a **named entity** (e.g., a file, host, service). It stores the **entity's state or attributes** (e.g., file contents, IP address).
2.  **Directory Node:** Acts as a **catalog**. It stores a **directory table** of (`edge-label`, `node-identifier`) pairs, which map outgoing labels to child nodes (which can be other directories or leaves).
- *Explanation:* Tests the fundamental data model for structured namespaces.
**006. What is a **closure mechanism** in the context of name resolution? Provide an example from a filesystem and one from the Internet.**
- A **closure mechanism** is the rule or context that determines the **starting point (initial node or index node)** for resolving a structured name.
- **Filesystem Example:** In Unix, to resolve `/home/steen/mbox`, the closure mechanism provides access to the **inode of the root directory** (found via the disk's superblock).
- **Internet Example:** To resolve `www.distributed-systems.net`, the closure mechanism is the **IP address of a configured DNS resolver** (or root hints) that provides the starting point for the DNS hierarchy.
- *Explanation:* Tests a critical but often implicit concept that makes resolution possible.
**007. Describe the step-by-step process of **path name resolution** for the Unix file path `/home/steen/mbox`, starting from the root inode.**
1.  Start at the root directory's inode.
2.  Read the root directory's data blocks, which contain a table mapping names to inode numbers.
3.  Look up the name `"home"` in this table to get the inode number of the `/home` directory.
4.  Access that inode, read its data blocks, and look up `"steen"` to get the inode number of `/home/steen`.
5.  Access that inode, read its data blocks, and look up `"mbox"` to get the inode number of the target file.
6.  Access that final inode to read the file's attributes and data.
- *Explanation:* Tests the concrete algorithm for walking a hierarchical namespace.
**008. What is the key difference between a **hard link** and a **symbolic (soft) link** in a filesystem?**
- A **hard link** is a **direct directory entry** that points to the same underlying inode (data structure) as the original file. It creates another absolute path to the same node.
- A **symbolic (soft) link** is a **special type of leaf node** whose *data* is a **path name** (a string) of the target file. It is an indirect reference; if the target file is deleted, the symbolic link becomes a **dangling reference**.
- *Explanation:* Tests a core concept for creating aliases in a namespace.
**009. What is the purpose of **mounting** in the context of distributed namespaces? Provide a brief example.**
- **Mounting** transparently **integrates a foreign namespace** (e.g., a remote filesystem) into the local namespace at a specified directory (the **mount point**).
- **Example:** Mounting the Network File System (NFS) export `/remote/vu` from server `fs.vu.nl` to the local directory `/home/steen/remote`. After mounting, accessing the local path `/home/steen/remote/mbox` actually accesses the file `/remote/vu/mbox` on the remote server, without the user needing to know the remote path.
- *Explanation:* Tests the mechanism for building unified namespaces from disparate parts.
**010. The DNS namespace is partitioned into three logical layers for implementation. What are these layers, and what is the primary characteristic of each?**
1.  **Global Layer:** Consists of the **root and top-level domains** (e.g., `.com`, `.uk`). **Highly stable**, changes infrequently, managed by large organisations.
2.  **Administrational Layer:** Consists of **zones managed by large organisations** (e.g., `example.com`, `ac.uk`). Managed independently, changes moderately.
3.  **Managerial Layer:** Consists of **individual hosts and services** within an organisation (e.g., `www.example.com`). **Highly dynamic**, frequently updated, and often replicated for performance and availability.
- *Explanation:* Tests the architectural design of DNS for scalability and manageability.
**011. Compare **iterative** and **recursive** DNS resolution. What is the key trade-off between them?**
- **Iterative Resolution:** The contacted server returns the **best answer it has** (often a referral to another server). The **client is responsible** for querying the next server.
- **Recursive Resolution:** The contacted server **takes on the responsibility** of finding the full answer. It queries other servers on the client's behalf and returns the final result.
- **Trade-off:** Recursive resolution places a **higher processing and state burden on the name server** but allows for **effective caching of results** at intermediate resolvers, benefiting future clients. Iterative resolution is **less demanding on individual servers**.
- *Explanation:* Tests the two fundamental resolution strategies and their impact on performance and load.
**012. In LDAP, data is organised in a **Directory Information Tree (DIT)**. What is an **entry** in this tree, and how is it uniquely identified?**
- An **entry** is a collection of **attribute-value pairs** that describes an object (e.g., a person, a printer, a group).
- It is uniquely identified by its **Distinguished Name (DN)**, which is a sequence of **Relative Distinguished Names (RDNs)** read from the entry up to the root of the DIT. An RDN is a single attribute-value pair that uniquely identifies the entry among its siblings.
- *Explanation:* Tests the core data model of LDAP.
**013. What problem does the **Java Naming and Directory Interface (JNDI)** solve for Java application developers?**
- JNDI provides a **uniform, standard Java API** for accessing **different, heterogeneous naming and directory services** (like LDAP, DNS, RMI registry, CORBA Naming Service). It solves the problem of **vendor lock-in** and **implementation complexity** by allowing developers to write code against a single interface while using pluggable **service providers** for the underlying service.
- *Explanation:* Tests the purpose and benefit of the JNDI abstraction layer.
**014. In the "Check of Understanding" scenario (finding a colour A3 printer on the same floor), why is an **attribute-based naming** service like LDAP necessary, rather than a structured naming service like DNS?**
- Structured naming services like DNS are designed for **lookup by precise, hierarchical name** (e.g., `printer5.floor3.example.com`). They cannot efficiently answer **queries based on multiple, arbitrary attributes** (colour-capable, A3, floor location).
- Attribute-based naming services are built precisely for this: they allow **search queries** over a set of descriptive attributes (e.g., `(&(type=printer)(capabilities=colour)(capabilities=A3)(locationFloor=5))`), returning all matching entries regardless of their exact name.
- *Explanation:* Applies the core distinction between the two naming paradigms to a practical scenario.
**015. When a DNS server returns a **CNAME record** during resolution, what does this indicate, and how does the resolver proceed?**
- A **CNAME (Canonical Name) record** indicates that the queried name is an **alias** for another domain name (the canonical name).
- The resolver must **suspend its current resolution** and **restart the resolution process** for the canonical name provided in the CNAME record. Once the canonical name is resolved to an IP address, that address is returned for the original alias query.
- *Explanation:* Tests understanding of a specific DNS record type and its impact on the resolution algorithm.
**016. What is the purpose of the **Time-To-Live (TTL)** value associated with DNS resource records?**
- The **TTL** specifies how **long (in seconds) a DNS record can be cached** by resolvers and clients before it must be considered stale and re-fetched from an authoritative server. It is a critical mechanism for **balancing consistency and performance**: a low TTL allows quick propagation of changes, while a high TTL reduces load on authoritative servers and speeds up lookups via caching.
- *Explanation:* Tests the role of caching and its management in DNS.
**017. In a Unix filesystem, after creating a hard link `link.txt` to an existing file `original.txt`, what happens if you delete `original.txt`? Can you still access the file's content via `link.txt`? Why?**
- **Yes, you can still access the file's content via `link.txt`.**
- **Why:** A hard link is a direct reference to the underlying **inode** (the data structure containing the file's metadata and pointers to data blocks). Deleting `original.txt` only removes **one directory entry** pointing to that inode. As long as at least one hard link (directory entry) to the inode exists—in this case, `link.txt`—the inode and its data are not freed. The file continues to exist.
- *Explanation:* A practical test of hard link semantics.
### **11. Timing and Synchronisation**
**001. What is the primary purpose of synchronization in distributed systems?**
- To coordinate actions and events across different nodes.
- Synchronization mechanisms ensure that processes in a distributed system cooperate correctly, for example, to maintain data consistency, execute in a specific order, or agree on a shared state.
**002. Which of the following is a common method for achieving synchronization in distributed systems?**
- A logical clock.
- Since a perfectly synchronized global physical clock is impossible, distributed systems often use logical clocks (like Lamport timestamps or vector clocks) to define a causal order of events without relying on absolute time.
**003. In the context of distributed systems, what does the term "clock skew" refer to?**
- The difference in time between two clocks.
- Clock skew is the instantaneous difference in time readings between any two clocks in the system. It arises because every physical clock drifts at a slightly different rate.
**004. What is the primary purpose of Cristian's algorithm in distributed systems?**
- To synchronize a client's clock with a server's clock.
- Cristian's algorithm is a simple time-synchronization protocol where a client obtains the current time from a trusted time server and adjusts its local clock, accounting for the estimated network message delay.
**005. The Berkeley algorithm requires one of the nodes in the distributed system to be a UTC server, True or False?**
- False.
- The Berkeley algorithm is an internal synchronization algorithm. It does not require an external UTC source. Instead, a coordinator node polls others, computes an average time, and instructs all nodes how to adjust their clocks relative to each other.
**006. Which of the following steps is NOT part of Cristian's algorithm?**
- The client and server exchange multiple messages to average the time.
- Cristian's algorithm involves a single request-reply exchange between client and server. It does not use multiple rounds or averaging between peers; that is characteristic of algorithms like NTP or Berkeley.
**007. What is the primary function of the Network Time Protocol (NTP) in distributed systems?**
- To synchronize the clocks of computers over a network.
- NTP is the standard internet protocol used to synchronize system clocks across packet-switched, variable-latency data networks with a high degree of accuracy and reliability.
**008. Which of the following is a key feature of NTP?**
- It uses a hierarchical system of time sources.
- NTP uses a hierarchical, stratified architecture. Stratum 1 servers are connected to atomic clocks, Stratum 2 servers sync with Stratum 1, and so on. This design provides scalability, redundancy, and distributes the load.
**009. Consider a network consisting of 5 computers, A (coordinator), B, C, D, and E. At 12:09 the coordinator decides to synchronise the clock of all computers... Apply the Berkeley clock synchronisation algorithm...**
- **Stages:**
    1.  **Coordinator (A, 12:09) polls others:** Requests time from B, C, D, E.
    2.  **Times received:** B(11:59), C(12:13), D(12:00), E(12:09). Coordinator's own time is 12:09.
    3.  **Compute average:** Convert to minutes past a reference (e.g., 00:00).
        - A: 12:09 = 729 min
        - B: 11:59 = 719 min
        - C: 12:13 = 733 min
        - D: 12:00 = 720 min
        - E: 12:09 = 729 min
        - **Average** = (729+719+733+720+729)/5 = 3630/5 = **726 minutes** (12:06).
    4.  **Compute offsets:** Offset for each = Average - Local Time.
        - A: 726 - 729 = **-3 min** (must slow down by 3 min)
        - B: 726 - 719 = **+7 min**
        - C: 726 - 733 = **-7 min**
        - D: 726 - 720 = **+6 min**
        - E: 726 - 729 = **-3 min**
    5.  **Coordinator sends adjustments:** Sends each node the amount to adjust (the offset).
- **Outcome:** All nodes adjust their clocks to converge towards the computed average of **12:06**. No node is set to an absolute UTC time; they are synchronised **relative to each other**.
**010. A client attempts to synchronise with a time server using Cristian’s algorithm... (i) Which time should it use? (ii) To what time should it set it? (iii) Can ±10 ms be met?**
- **(i) Which time?** Use the measurement with the **shortest round-trip time (RTT)**, as it has the least uncertainty. **110 ms**.
- **(ii) Calculate:** `Adjusted Time = Server Timestamp + (RTT/2)`.
    - Server time: 09:35:12.371
    - RTT/2 = 110ms / 2 = **55ms**.
    - **Adjusted Time = 09:35:12.371 + 55ms = 09:35:12.426**.
- **(iii) Can requirement be met?** **Possibly, but not guaranteed.** Cristian's algorithm assumes the delay is symmetric. Asymmetry in network travel times can introduce error greater than ±10 ms. For such a tight bound, a more sophisticated protocol like **NTP** with multiple samples and statistical filtering is needed.
**011. The clock on the car needs to constantly synchronise with a UTC server using Cristian’s algorithm. Suppose the clock on the car reads 13:48:56. The server’s clock reads 13:49:02 when they synchronise. Assume the Round Trip Time (RTT) is 2 seconds. What is the time at the client after synchronization?**
- **Calculation:**
    - Server Timestamp (`T_server`) = 13:49:02.
    - Estimated One-Way Delay = RTT/2 = 2s / 2 = **1 second**.
    - **Adjusted Client Time = T_server + Delay**
    - = 13:49:02 + 1 second = **13:49:03**.
- *Note:* The client's original time (13:48:56) is irrelevant for the calculation; it's used to compute the offset to apply.
**012. Why is it impossible to have a perfectly accurate global clock in a distributed system?**
- Due to **clock drift** and **network latency**. Each computer's internal clock (based on a quartz crystal) drifts at a unique, non-zero rate (**parts per million, ppm**). Additionally, even if clocks were perfect, synchronising them requires message exchange, and the **variable, unpredictable propagation delays** in a network make it impossible to determine the exact instant a message was sent or received at a remote machine.
- *Explanation:* Tests the fundamental physical and network limitations that make time synchronization a problem.
**013. What is the **maximum drift rate (ρ)** of a physical clock, and what does it imply about the guaranteed accuracy of the clock over a time interval `t`?**
- The **maximum drift rate (ρ)** is a constant (e.g., 10^-6 or 1 ppm) that bounds the rate at which a computer's clock can deviate from real (UTC) time: $1 - \rho ≤ dC/dt ≤ 1 + \rho$.
- Over a time interval `t` without synchronization, the clock can be off by at most $± \rho t$. For example, with $\rho = 1 \text{ ppm} = 10^{-6}$, after 24 hours (86,400 seconds), the maximum error is $10^{-6} * 86400 \text{ s} ≈ 0.0864 \text{ s}$, or about **86 milliseconds**.
- *Explanation:* Tests the mathematical model for clock drift and its practical implications.
**014. The 1991 **Patriot Missile failure** is cited as an example of a catastrophic timing error. What was the root cause in terms of clock synchronisation?**
- A **software truncation error** in converting system time (in tenths of a second) led to an **accumulated clock drift** of approximately 0.34 seconds over 100 hours of continuous operation. This caused the missile's tracking system to miscalculate the target's position, leading to a failed interception.
- *Explanation:* Tests a famous real-world case study of the consequences of poor timekeeping.
**015. In the **Bully Election Algorithm**, what does a process do when it receives an **ELECTION** message from a process with a **lower ID**?**
- It sends back an **OK** message to acknowledge the election, and then **immediately starts its own election** by sending ELECTION messages to processes with IDs higher than its own. This ensures that the process with the **highest ID among the active processes** eventually wins.
- *Explanation:* Tests a key step in the bully algorithm's logic to ensure the highest-ID candidate emerges.
**016. Describe the message flow in the **Ring Election Algorithm** when a single process `P2` detects the coordinator's failure and initiates an election in a ring of 5 processes (P1-P5).**
1.  `P2` creates an **ELECTION** message containing its own ID (`[2]`) and sends it to its successor in the ring (e.g., `P3`).
2.  `P3` receives it, appends its own ID (`[2,3]`), and forwards it to `P4`.
3.  `P4` appends its ID (`[2,3,4]`) and forwards to `P5`.
4.  `P5` appends its ID (`[2,3,4,5]`) and forwards to `P1`.
5.  `P1` appends its ID (`[2,3,4,5,1]`) and forwards back to the initiator `P2`.
6.  `P2` receives its own message, sees the list `[2,3,4,5,1]`, identifies the highest ID (`5`).
7.  `P2` (or `P5` directly) sends a **COORDINATOR** message around the ring announcing `P5` as the new leader.
- *Explanation:* Tests the step-by-step mechanics of the ring algorithm.
**017. In **NTP's hierarchical structure**, what is a **Stratum 1** server, and why is the stratum number important?**
- A **Stratum 1** server is a **primary time server** that is directly synchronized to an authoritative external time source, such as an atomic clock, a GPS receiver, or a radio clock. It has minimal delay to the source.
- The **stratum number** indicates the **distance (in network hops) from an authoritative UTC source**. Lower stratum numbers imply **higher accuracy and reliability**. A Stratum 2 server syncs with Stratum 1, Stratum 3 with Stratum 2, and so on. Accuracy generally decreases as stratum increases.
- *Explanation:* Tests the core hierarchical design of NTP.
**018. NTP uses different **clock correction mechanisms** based on the calculated offset (θ). What action does NTP take for an offset of **200 ms**?**
- For an offset where **125 ms ≤ |θ| < 1000 ms**, NTP will perform a **step** correction. This means it will **jump** (set) the local clock to the corrected time immediately, rather than trying to adjust its speed gradually.
- *Explanation:* Tests the specific operational rules of NTP for handling different magnitudes of error.
**019. In the "Check of Understanding" scenario about sensor timestamps, the first potential cause is **asymmetric network delay**. Why does this break the assumption of Cristian's algorithm and affect NTP accuracy?**
- Both Cristian's algorithm and NTP's basic offset calculation assume that the **network delay is symmetric**—the time for a message to travel from client to server is roughly equal to the time from server to client ($T_{go} ≈ T_{return}$). If this assumption is false (asymmetric routes or congestion), the calculated one-way delay (RTT/2) is incorrect, leading to a **systematic error** in the synchronized time. A consistent 50ms offset suggests a fixed asymmetry.
- *Explanation:* Tests understanding of a fundamental limitation in time sync protocols.
**020. What is the primary **disadvantage** of the Berkeley Algorithm compared to synchronizing each machine directly with an external UTC source?**
- The Berkeley Algorithm synchronizes clocks **only relative to each other**, not to **absolute UTC time**. The computed "average" time may drift away from real-world time if the coordinator or the group of machines has a systematic drift. It provides **internal consistency** but not **external accuracy**.
- *Explanation:* Highlights the key trade-off of internal vs. external synchronization.
**021. After a successful election using the Bully Algorithm, the new coordinator (e.g., process with ID 6) sends a **COORDINATOR** message. To which processes should this message be sent?**
- The new coordinator should send the COORDINATOR message to **all processes with lower IDs** than itself. It may also broadcast it to all processes in the system to ensure everyone is aware of the new leadership.
- *Explanation:* Tests a final step in the bully algorithm's protocol.
**022. What is a **logical clock** (as mentioned in Q002), and how does its purpose differ from the **physical clock synchronization** methods (Cristian's, Berkeley, NTP) discussed in this chapter?**
- A **logical clock** is a mechanism (e.g., Lamport timestamps, vector clocks) that **orders events causally** without measuring real time. It tracks **happens-before** relationships.
- **Difference:** Physical clock synchronisation aims to make local clocks **read approximately the same absolute (UTC) time**. Logical clocks abandon the goal of measuring real time entirely, focusing only on **maintaining a consistent causal order** of events, which is sufficient for many distributed algorithms (e.g., consistency protocols).
- *Explanation:* Clarifies the distinction between two major approaches to "time" in distributed systems, linking back to a previous question.
### **12. Consistency and Replication Pt.1**
**001. Which of the following is a common challenge in maintaining consistency in distributed systems?**
- Network latency.
- The finite and variable speed of network communication makes it impossible to instantly update all replicas of data. This delay creates windows of inconsistency, making it a fundamental challenge.
**002. What is the primary goal of replication in distributed systems?**
- To improve availability and fault tolerance.
- Replication creates redundant copies of data or services. If one replica fails, the system can continue operating using another, thereby increasing overall system availability and resilience to failures.
**003. Which of the following is an advantage of client-initiated replication?**
- Clients can control the timing and frequency of updates.
- In client-initiated replication (caching), the client decides when to fetch or refresh data from the source. This allows clients to optimize for their own performance and usage patterns, potentially reducing perceived latency.
**004. Caching is a special form of replication, but caching and replication lead to consistency problems. True or false?**
- True.
- This statement is **true**. Both caching (temporary local copy) and replication (persistent multiple copies) are techniques for duplicating data. The fundamental problem with any duplication is **maintaining consistency**: ensuring that an update to one copy is propagated to all others. If not managed carefully, this leads to clients reading stale data.
**005. Consider a simple interaction... using a causal consistency model... What would R(x)? return to process P3? What would R(y)? return to process P4? Explain.**
- *(Without the specific figure, the general principle is tested.)*
- **For Causal Consistency:** A read must return a value that reflects all **causally related writes** that happened before it. A write is causally related if it was done by the same process earlier, or if the process read a value that included the effect of that write.
- **Answering for P3:** R(x)? must return a value that is **at least as recent as the latest write to x that P3 is causally aware of** (e.g., through its own previous writes or reads).
- **Answering for P4:** Similarly, R(y)? must respect causal order. If P4 performed a write to y after reading from another process, it must see its own write.
- *Key:* Trace the **happens-before** relationships in the diagram to determine the permissible values.
**006. Think about a simple interaction of the car by means of a data store consistency model... "a write operation by a process on a data item x following a previous read operation on x by the same process is guaranteed to take place on the same or a more recent value of x that was read." Does the data store consistency hold in such case?**
- The described model is **Read-Your-Writes (RYW)** consistency, a **client-centric** model.
- **To evaluate:** Check the sequence for a specific process (e.g., L1 or L2). For every `W(x)` operation, look at the most recent `R(x)` by the *same* process before it. The value written must be based on the value read or a newer one. If the figure shows a process writing a value *older* than what it last read (which shouldn't happen in a correct program), the model would be violated. The answer depends on the provided figure.
**007. What is the fundamental **trade-off** between achieving strong consistency (like sequential consistency) and achieving scalability in a replicated system?**
- Achieving strong consistency requires **global synchronisation** to agree on the order of conflicting operations across all replicas. This synchronisation involves **communication delays and coordination overhead**, which **increases latency** and **limits throughput**, directly hindering the system's ability to scale in size and geography.
- *Explanation:* Tests the core "performance-scale dilemma" introduced at the start of the chapter.
**008. The **Continuous Consistency** model allows an application to specify tolerance for inconsistency along three dimensions. Name these three dimensions.**
1.  **Numerical Deviation:** The maximum absolute difference in value between replicas.
2.  **Staleness Deviation:** The maximum time a replica's value is older than another's.
3.  **Ordering Deviation:** The maximum number of unpropagated (pending) write operations.
- *Explanation:* Tests the key innovation of the continuous consistency model.
**009. In the Continuous Consistency example for a fleet manager, what is the role of a **Conit**?**
- A **Conit** is the **consistency unit**—a specific set of related data items (e.g., gallons tanked, price paid, distance driven) over which the numerical, staleness, and ordering deviations are measured and bounded. The application defines the Conit, and the system ensures the replicas of that Conit stay within the specified deviation bounds.
- *Explanation:* Tests the central data structure of the continuous model.
**010. What is the key guarantee provided by the **Sequential Consistency** model?**
- The result of any execution is equivalent to some **sequential execution** of all operations, where the operations **of each individual process** appear in this sequence in the **order specified by its program** (program order). All processes agree on this single global interleaving.
- *Explanation:* Tests the formal definition of sequential consistency.
**011. Using the **happens-before relation**, explain why the execution in Diagram (b) of the sequential consistency notes (where P3 and P4 see different interleavings of writes) is **not** sequentially consistent.**
- For sequential consistency to hold, **all processes must agree on a single global order** of all operations. In Diagram (b), P3 sees the order `W2(x)b` -> `W1(x)a`, while P4 sees the order `W1(x)a` -> `W2(x)b`. These are **contradictory observations**. There is no single sequential order that can satisfy both P3's and P4's view of the write order, thus violating the model.
- *Explanation:* Applies the happens-before/logical ordering concept to diagnose a consistency violation.
**012. The provided print program example (with processes P1, P2, P3) demonstrates that sequential consistency does **not** guarantee all prints will be `(1,1,1)`. Why is the output `(1,0,0)` a valid outcome under sequential consistency?**
- Sequential consistency only requires that the execution be equivalent to *some* sequential interleaving of the statements that respects each process's **program order**. One such valid interleaving is:
    1.  P1: `x = 1; print(y, z)` -> prints `(0,0)` because P2 and P3 haven't run yet.
    2.  P2: `y = 1; print(x, z)` -> prints `(1,0)`.
    3.  P3: `z = 1; print(x, y)` -> prints `(1,1)`.
- In this interleaving, P1 prints before P2 and P3 set `y` and `z`, leading to the output `(1,0,0)` for P1. This is permissible.
- *Explanation:* Tests understanding that sequential consistency is about order, not about real-time simultaneity.
**013. How does **Causal Consistency** relax the requirements of Sequential Consistency?**
- Causal Consistency **only requires that causally related writes be seen by all processes in the same order**. **Concurrent writes** (writes that are not causally related) can be seen in **different orders** by different processes. Sequential Consistency requires a *total* order of *all* writes, regardless of causality.
- *Explanation:* Tests the core distinction between these two strict models.
**014. Define the **happens-before relation (→)**. Provide a small example diagram with two processes and one message, labelling the relation between events.**
- **Definition:** Event `a` happens-before event `b` (`a → b`) if:
    1.  `a` and `b` are events in the same process and `a` occurs before `b`.
    2.  `a` is the sending of a message and `b` is the receipt of that *same* message.
    3.  It is transitive: if `a → c` and `c → b`, then `a → b`.
- **Example Diagram:**
    ```
    Process P1: a (send msg m) ---> b (local event)
                     |
                     v (message m)
    Process P2: c (receive msg m) ---> d (local event)
    ```
    Relations: `a → b` (same process), `a → c` (message send/receive), `c → d` (same process). By transitivity, `a → d`.
- *Explanation:* Tests the formal definition and ability to apply it to a simple scenario.
**015. In the "Check of Understanding" social media scenario, why does the Asian user's read of the post establish a causal link between Write A (post) and Write B (comment)?**
- Because the Asian user **performed a read operation (`R_A`)** that returned the value written by Write A, and then **performed Write B** based on that information. This sequence creates a **happens-before chain**: `Write A → R_A → Write B`. Therefore, `Write A` is a **cause** of `Write B`; Write B could not have occurred without the knowledge gained from reading Write A.
- *Explanation:* Tests the application of causality to a real-world example.
**016. Diagram (a) in the causal consistency notes shows a violation. Which specific read operation creates the causal link that is subsequently violated?**
- The read operation `R2(x)a` performed by Process P2. This read observes the value `'a'` written by `W1(x)a`. Because P2 later performs `W2(x)b`, a causal link `W1(x)a → W2(x)b` is established. The violation occurs because Process P3 sees `W2(x)b` (via `R3(x)b`) **before** it sees `W1(x)a`, thereby inverting the order of causally related writes.
- *Explanation:* Tests the ability to pinpoint the source of causality in a violation diagram.
**017. If two write operations, `W1` and `W2`, are **concurrent** (`W1 || W2`), what does this imply about the **happens-before** relation between them, and what freedom does this give under Causal Consistency?**
- If they are concurrent (`W1 || W2`), it means **neither `W1 → W2` nor `W2 → W1`**. There is no causal relationship between them.
- Under **Causal Consistency**, this gives processes the freedom to see these two writes in **any order**. Process P may see `W1` then `W2`, while process Q may see `W2` then `W1`. Both are valid.
- *Explanation:* Tests the implication of concurrency within the causal consistency model.
**018. What is the primary purpose of defining a **consistency model**?**
- It defines a **formal contract** or set of guarantees between the distributed data store (the system) and the client processes (the application) about the possible results of **read** and **write** operations when executed concurrently. It tells the programmer what values a read operation is allowed to return, enabling them to reason about their program's behaviour.
- *Explanation:* Tests the fundamental reason for having these models.
### **13. Consistency and Replication Pt.2**
***001. What is the key difference between **data-centric** and **client-centric** consistency models?**
- **Data-centric models** (like Sequential, Causal) define **global guarantees** about the order of operations visible to *all processes* in the system.
- **Client-centric models** (like Monotonic Reads, Read Your Writes) define guarantees only for the **sequence of operations performed by a *single client***, ensuring a self-consistent view for that client as it moves or interacts with different replicas. They make no guarantees about consistency between operations of *different* clients.
- *Explanation:* Tests the fundamental distinction that introduces client-centric models.
**002. Describe the guarantee provided by the **Monotonic Reads (MR)** client-centric consistency model. Provide a real-world example of its violation.**
- **Guarantee:** If a process reads a particular version of a data item, any **future read** by that same process must return that same version or a **more recent (never older) version**.
- **Violation Example:** A user checks their email inbox on their office computer and sees 5 unread emails. They then open the email app on their phone and it shows only 3 unread emails. The phone's view has "gone back in time," violating Monotonic Reads.
- *Explanation:* Tests the definition and provides a concrete scenario.
**003. The **Monotonic Writes (MW)** model is crucial for operations that have dependencies. Explain its guarantee and why it is necessary for a software installation process.**
- **Guarantee:** All write operations performed by a single process are **propagated to all replicas in the same order** they were issued by that process.
- **Necessity for Software Installation:** Installing software often requires steps in a specific order (e.g., install framework A **then** install application B that depends on A). If a package manager's writes were propagated out of order to different mirrors, a user might fetch and attempt to install application B *before* framework A is available on their local mirror, causing the installation to fail.
- *Explanation:* Tests the model's definition and a practical use case highlighting its importance.
**004. What does **Read Your Writes (RYW)** consistency guarantee for a mobile user? How does the diagram (b) in the notes show a violation of this?**
- **Guarantee:** After a process performs a write, any **subsequent read** by the same process will always reflect that write (or a later one). The user always sees their own updates.
- **Violation in Diagram (b):** Process P1 writes value `x1` at local store L1. Later, when P1 reads from a different store L2, it gets value `x2`, which is a version created *without* incorporating its own write `x1`. P1 does **not** see its own write, violating RYW.
- *Explanation:* Tests the definition and the ability to interpret a violation from the provided diagrams.
**005. In the context of **replica management**, what is the difference between a **permanent replica**, a **server-initiated replica**, and a **client-initiated replica (cache)**?**
- **Permanent Replica:** Part of the **initial, fixed set** of replicas that form the core of the distributed data store (e.g., the origin servers for a website).
- **Server-Initiated Replica:** Created **dynamically by the system** (the data owner) to improve performance, typically placed near clusters of demanding clients (e.g., a CDN edge server copying a popular video).
- **Client-Initiated Replica (Cache):** Created at the **request of a client** to store data locally for fast, repeated access (e.g., a web browser cache, or a mobile app's local database).
- *Explanation:* Tests the classification of replicas based on who creates them and why.
**006. Describe the simple algorithm used for **server-initiated replication**. What are the roles of the **Replication Threshold (R)** and **Deletion Threshold (D)**?**
- **Algorithm:** Servers monitor access counts for files. When the access count for a file `F` from a specific region (aggregated via a nearby server) exceeds the **Replication Threshold (R)**, a new replica of `F` is created in that region.
- **Replication Threshold (R):** The access count level that triggers the **creation** of a new replica.
- **Deletion Threshold (D):** A lower access count level. If accesses for a replicated file fall below **D**, the replica is **removed** to free up resources.
- *Explanation:* Tests the dynamic, access-driven logic behind server-initiated replication.
**007. In the **primary-backup protocol with remote writes**, why does the client experience high write latency? Describe the blocking steps that cause this.**
- The client must wait for **multiple network round-trips** to complete:
    1.  Client sends write request to the **primary** server.
    2.  Primary performs the write locally.
    3.  Primary forwards the update to all **backup** servers.
    4.  Primary **blocks, waiting for acknowledgements** from all backups.
    5.  Only after all backups acknowledge, the primary sends an acknowledgement back to the client, which can then continue.
- This sequential, blocking nature causes high latency.
- *Explanation:* Tests the understanding of the protocol's mechanics and its performance implication.
**008. What is the key advantage of the **primary-backup protocol with local writes** over the remote-write variant? What typical use case does it enable?**
- **Key Advantage:** **Very low write latency** for the client holding the primary, because writes are performed **locally** without waiting for network communication.
- **Typical Use Case:** **Mobile disconnected operation**. A user can "check out" a file (become its primary), work on it offline (performing many local writes), and later propagate the changes back to the backup servers when reconnected.
- *Explanation:* Tests the benefit and a primary application of the local-write variant.
**009. Under the local-write primary-backup protocol, what consistency issue can arise for other clients trying to read the data item while the primary is held by a mobile user?**
- Other clients may read from **stale backup replicas** that have not yet received the updates from the mobile primary. They will **not see the latest writes** performed by the mobile user until those writes are asynchronously propagated back. This can violate client-centric models like **Monotonic Reads** for those other clients if they had previously seen a more recent version.
- *Explanation:* Tests the trade-off of the local-write approach: performance for the primary holder vs. consistency for others.
**010. A system uses server-initiated replication for a popular news article. The Replication Threshold R is 1000 requests/hour from a region, and the Deletion Threshold D is 200 requests/hour. A server in Europe has been serving 1500 requests/hour for the article from Asian users. What action should the system take, and why?**
- The system should **create a server-initiated replica of the article on a server in Asia**.
- **Why:** The access count (1500 requests/hour) from the Asian region **exceeds the Replication Threshold R (1000)**. This indicates high demand from that geographic area, justifying the creation of a local replica to reduce latency for Asian users and offload traffic from the European server.
- *Explanation:* Applies the server-initiated replication algorithm to a scenario.
**011. For a distributed document editing application, which **client-centric consistency model** is most critical to prevent a user from seeing their own changes "disappear" when they switch devices? Justify your answer.**
- **Read Your Writes (RYW)** consistency is most critical.
- **Justification:** When a user edits a document on their laptop (a write) and then opens it on their phone (a read), RYW guarantees the phone will show the changes made on the laptop. Without RYW, the phone might display a stale, cached version, making it appear as if the user's own changes have disappeared.
- *Explanation:* Tests the application of a client-centric model to a specific user experience problem.
**012. In the "Check of Understanding" scenario comparing remote-write and local-write protocols, the answer mentions a violation of "Monotonic Reads for the Berlin user." Explain how this violation could occur.**
- The Berlin user might have previously read a moderately recent version of the document from a server in Paris (let's call it version `v5`). Later, while the Tokyo user is the primary and making edits (creating versions `v6`, `v7`, etc.), the Berlin user refreshes. If his request is routed to a backup server that is *still on version `v4`* (because Tokyo's updates haven't propagated yet), he would see version `v4`. This is **older than the version `v5` he previously saw**, violating the **Monotonic Reads** guarantee that his view of the data should never go backwards in time.
- *Explanation:* Tests deeper analysis of the consistency trade-off in the provided scenario.*
### **14. Fault Tolerance**
**001. In the context of distributed systems, the Atomicity property of ACID ensures that:**
- Either all operations of a transaction are completed successfully or none are applied.
- Atomicity is the "all-or-nothing" guarantee. A transaction is an indivisible unit; if any part fails, the entire transaction is rolled back, leaving the system state unchanged.
**002. What is fault tolerance in distributed systems?**
- The ability to continue operating properly in the event of the failure of some of its components.
- Fault tolerance is the property that enables a system to deliver its specified service even when one or more of its internal hardware or software components have failed.
**003. In a distributed system, what is the purpose of redundancy?**
- To ensure that there are backup components available in case of failure.
- Redundancy is the core technique for achieving fault tolerance. By having extra components (information, time, or physical), the system can mask or recover from the failure of individual parts.
**004. What is the role of a consensus algorithm in fault-tolerant distributed systems?**
- To ensure all nodes agree on a single data value.
- In a replicated system, a consensus algorithm (like Paxos or Raft) is the mechanism by which non-faulty nodes reach a common agreement on a value (e.g., the next state or transaction order) despite the potential failure of some nodes.
**005. What is the Byzantine Generals Problem in distributed systems?**
- A problem of achieving consensus in the presence of faulty or malicious components.
- It's a theoretical framework that describes the difficulty of getting distributed components to agree on a coordinated plan of action when some components may fail in arbitrary, even malicious, ways (Byzantine failures).
**006. Which of the following is a key challenge addressed by the Byzantine Generals Problem?**
- Ensuring all non-faulty nodes agree on the same value despite the presence of faulty nodes.
- The core challenge is maintaining system correctness and consistency when participants cannot be fully trusted, requiring protocols that can tolerate a certain number of arbitrarily failing components.
**007. Consider a Byzantine fault tolerance system... (i) What are the two possible problems? (ii) Show that n ≥ 3f + 1 must hold...**
- **(i) Two problems from Byzantine failure:**
    1.  **A faulty server may send *different, incorrect* values to different clients/replicas.**
    2.  **A faulty server may send *no* value (act as a crash failure).**
- **(ii) Proof sketch for n ≥ 3f + 1:**
    - Assume `n` total servers, `f` of which are faulty (malicious).
    - After receiving replies, the client sees `n-f` responses from non-faulty servers. The faulty servers could have sent arbitrary values.
    - To decide the correct value, the client must see a **majority** of *identical* values among the `n-f` good replies.
    - However, the faulty servers can **all lie consistently** to try to form a false majority. The worst case is when the `f` faulty replies are identical, and they try to outvote the `n-f` good replies.
    - To ensure a correct majority exists: `(n - f) > f`. This simplifies to `n > 2f`.
    - But we also need to tolerate `f` crash failures *on top of* the Byzantine case? The tighter bound considers that the `f` faulty nodes can also *omit* replies. The client only sees `n-f` replies, and all `f` faulty nodes could be silent. The remaining `n-2f` must outnumber the `f` that could lie within the received set. The classic result is `n > 3f` or `n ≥ 3f + 1`.
**008. Many distributed algorithms require one process to act as coordinator... Consider a group of 8 nodes labelled 0..7... Initially node 7 is the coordinator and node 4 is the first to notice it crashed.**
**(i) What happens if node 7 has actually not crashed?**
- In the **bully algorithm**, node 4 sends **ELECTION** messages to all nodes with higher IDs (5,6,7).
- Node 7, being alive, will respond with an **OK** message to node 4.
- Upon receiving an **OK** from a higher-ID node, node 4 **stops its election attempt**. Node 7 remains coordinator. The false assumption causes a brief flurry of messages but no change in leadership.
**(ii) Is the bully algorithm adequate for a dynamic P2P system?**
- **No.** The bully algorithm assumes a **static, known group** of processes. In a dynamic P2P system where nodes regularly join/leave (churn):
    - The assumption of known, ordered IDs is hard to maintain.
    - Frequent elections would be triggered by normal departures, causing excessive overhead.
    - The algorithm doesn't handle new nodes joining the election process cleanly.
- **P2P systems** typically use **leader election** based on **Distributed Hash Table (DHT)** rings (e.g., in Raft/Paxos variants) or are designed to be **leaderless**.
**009. Consider a group of 6 nodes labelled 0..5. Initially node 5 is the coordinator but it crashes. Node 2 is the first node to notice... Describe the election using: (i) the bully algorithm; (ii) the ring algorithm.**
- **(i) Bully Algorithm:**
    1.  Node 2 sends **ELECTION** messages to nodes with higher IDs: 3, 4, 5.
    2.  Nodes 3 and 4 are alive. They respond with **OK** to node 2 and each starts its own election.
        - Node 3 sends ELECTION to 4,5. Node 4 responds OK, Node 5 is dead.
        - Node 4 sends ELECTION to 5. No response (Node 5 dead).
    3.  Node 4, receiving no OK from anyone higher, declares itself coordinator. It sends **COORDINATOR** message to all lower nodes (0,1,2,3).
- **(ii) Ring Algorithm:**
    - *Assumption:* Logical ring order is 0->1->2->3->4->5->0.
    1.  Node 2 creates an **ELECTION** message `[2]` and sends it to its neighbour (3).
    2.  Node 3 forwards it, appending its ID: `[2,3]` -> Node 4.
    3.  Node 4 forwards: `[2,3,4]` -> Node 5 (dead). Node 4 times out and skips 5, sends to Node 0: `[2,3,4]`.
    4.  Node 0 forwards: `[2,3,4,0]` -> Node 1.
    5.  Node 1 forwards: `[2,3,4,0,1]` -> Node 2.
    6.  Node 2 receives its own message. It sees the list `[2,3,4,0,1]`. The highest ID is **4**.
    7.  Node 2 sends a **COORDINATOR(4)** message around the ring to inform everyone that node 4 is the new coordinator.
**010. Consider the Byzantine Generals Problem. Two generals... How can they devise a scheme...?**
- This is the **Two Generals' Problem**, which is **provably unsolvable** in a deterministic way over an unreliable network.
- A **probabilistic scheme** can be used:
    1.  General A sends a message "Attack at dawn" to General B.
    2.  General B, upon receiving it, sends an **acknowledgment** "Ack, Attack at dawn" back.
    3.  General A, upon receiving the ack, sends an **ack-for-the-ack** "Ack2".
    4.  This continues for a predetermined number of rounds `k`.
- With each round, the probability that *both* know the other knows the plan increases, but it never reaches 100%. They must decide to attack if they have completed `k` rounds, accepting a small probability of miscoordination. This illustrates the fundamental difficulty of achieving **perfect consensus** over an unreliable link.
**011. Distinguish between the terms **Fault**, **Error**, and **Failure** in the context of fault tolerance. Provide a simple example.**
- **Fault:** The **cause** of an error (e.g., a programming mistake by a developer, a hardware flaw).
- **Error:** A **deviation from the correct system state** caused by a fault (e.g., an incorrect variable value in memory due to the bug).
- **Failure:** The **observable event** where the system **does not meet its specification** (e.g., the program crashes or returns a wrong result to the user).
- **Example:** A developer (fault) writes a bug that divides by zero under a certain condition (error). When a user triggers that condition, the application crashes (failure).
- *Explanation:* Tests the precise, layered terminology that is crucial for discussing FT.
**012. What is the difference between **Availability** and **Reliability**? Provide an example of a system that is highly available but not highly reliable.**
- **Availability:** The **probability the system is operational at a given instant in time**. Focuses on **minimising downtime**.
- **Reliability:** The **probability the system operates continuously without failure over a specified time interval**. Focuses on **maximising time between failures**.
- **Example:** A web service that automatically restarts in 1ms after crashing every hour. It has 99.9999% availability (downtime is tiny) but is **unreliable** because it fails frequently (every hour).
- *Explanation:* Tests a key distinction, with the classic example from the notes.
**013. A system has a Mean Time To Failure (MTTF) of 500 hours and a Mean Time To Repair (MTTR) of 5 hours. Calculate its **Mean Time Between Failures (MTBF)** and its **Availability (A)**.**
- **MTBF = MTTF + MTTR = 500 + 5 = 505 hours.**
- **Availability A = MTTF / MTBF = 500 / 505 ≈ 0.9901, or 99.01%.**
- *Explanation:* Tests the application of the fundamental quantitative metrics.
**014. Classify the following as an **Omission Failure** or a **Commission (Byzantine) Failure**:**
    a) A server crashes and stops responding to requests.
    b) A malicious server receives a request for a user's balance and returns an incorrect, fabricated amount.
    c) A router drops a packet due to congestion.
    d) A faulty sensor sends a plausible but incorrect temperature reading.
- **a) Omission Failure** (Fail-stop crash).
- **b) Commission (Byzantine) Failure** (Sends arbitrary, incorrect data).
- **c) Omission Failure** (Fails to deliver a message).
- **d) Commission (Byzantine) Failure** (Sends incorrect but plausible data – a lie).
- *Explanation:* Tests the classification of failures, a core part of the failure model.
**015. What are the three main types of **redundancy** used to mask faults? Provide a brief example of each in a distributed system context.**
1.  **Information Redundancy:** Adding extra bits for error detection/correction. *Example:* Using a **checksum or CRC** on network packets to detect corruption.
2.  **Time Redundancy:** Performing an action again. *Example:* **TCP retransmission** of a lost packet.
3.  **Physical Redundancy:** Adding extra hardware or software components. *Example:* Running **multiple replica servers**; if one fails, another takes over.
- *Explanation:* Tests the core techniques for achieving fault tolerance.
**016. In the context of **process groups** for fault tolerance, what does it mean for a system to be **k-fault tolerant**? How does the required group size differ for **crash failures** versus **Byzantine failures**?**
- **k-fault tolerant:** The system can survive **k component failures** and still meet its specification.
- **Group Size:**
    - For **Crash (Fail-stop) Failures:** Need **k + 1** processes. With `k` failures, at least 1 correct process remains.
    - For **Byzantine (Arbitrary) Failures:** Need at least **2k + 1** processes. This ensures that among the non-faulty processes (`k+1`), they have a majority and can out-vote any consistent lie from the `k` faulty processes.
- *Explanation:* Tests the fundamental sizing rules derived from the Byzantine Generals problem.
**017. Describe the key idea behind the **flooding-based consensus** algorithm for crash failures. What extra mechanism is needed when a process crashes during a round?**
- **Key Idea:** Processes exchange lists of proposed commands in rounds. Each process merges received lists and uses a **deterministic function** (same for all) to select the next command. This ensures all non-faulty processes execute the same sequence.
- **Mechanism for Mid-Round Crash:** Processes must **wait an extra round** if they detect a crash. This ensures all surviving processes have received the same set of proposals from the crashed process (or know it sent none) before making a decision, maintaining consistency.
- *Explanation:* Tests understanding of a basic consensus algorithm and its handling of partial failures.
**018. In the **Raft consensus algorithm**, what is the role of the **leader**, and how does it ensure that all servers maintain the same log of committed operations?**
- **Leader Role:** The leader is the **only server that accepts client commands** and is responsible for **replicating them** to follower servers.
- **Ensuring Consistency:** The leader appends the command to its log, sends it to all followers, and waits for **acknowledgements from a majority**. Once a majority acknowledges, the leader **commits** the entry (applies it to its state machine) and notifies followers to do the same. This **majority agreement** guarantees that all servers will eventually have the same sequence of committed entries, even if a leader fails.
- *Explanation:* Tests the core operation of the widely-used Raft algorithm.
**019. The **Two Generals Problem** demonstrates a fundamental impossibility. What is that impossibility, and what is its practical implication for designing reliable distributed systems?**
- **Impossibility:** It is **impossible to achieve perfect, deterministic reliability** over an **unreliable communication channel** where messages can be lost. There will always be residual uncertainty about whether the last critical message (or acknowledgement) was received.
- **Practical Implication:** System designers must use **timeouts, retransmissions, and probabilistic guarantees** (e.g., TCP) rather than seeking absolute certainty. They accept a small, non-zero probability of failure or inconsistency.
- *Explanation:* Tests the profound lesson of this classic thought experiment.
**020. Using the example from the notes, explain why a system of **3 processes cannot tolerate 1 Byzantine failure**, but a system of **4 processes can**.**
- **With 3 processes (1 faulty):** The faulty process (`P_f`) can send value `A` to `P1` and value `B` to `P2`. The two loyal processes (`P1` and `P2`) now have conflicting views (`A` and `B`). They cannot determine who is lying, as there is no majority (2 out of 3) for a single value. Consensus fails.
- **With 4 processes (1 faulty):** The loyal processes (`P1`, `P2`, `P3`) can all exchange messages. Even if `P_f` tells different lies, the three loyal processes can compare notes. Since there are **3 loyal processes**, they will agree on the **majority value** among themselves (at least 2 out of 3 will have the same value from `P_f` or will agree on a default). This allows them to reach consensus.
- *Explanation:* Tests the intuitive understanding behind the `3f+1` bound with a concrete scenario.
**021. What is the purpose of defining a **system model** (assumptions about network, node, and timing behaviour) when discussing fault tolerance and consensus?**
- The system model **defines the boundaries of what is possible**. It makes explicit the assumptions under which an algorithm is designed to work (e.g., "synchronous network with bounded delay," "nodes only crash"). **Impossibility results** (like the Two Generals Problem) and **solvability conditions** (like `3f+1` for Byzantine consensus) are only valid within a specific model. Changing the model (e.g., from synchronous to asynchronous) can make a previously solvable problem unsolvable.
- *Explanation:* Tests the importance of the underlying assumptions in distributed algorithms.
**022. In the "Check of Understanding" blockchain scenario, the answer states honest validators need >2/3 of the stake. Link this directly to the **Byzantine Generals `3f+1` bound**.**
- The `3f+1` bound states that to tolerate `f` Byzantine failures, you need **`3f + 1` total participants**.
- Honest participants are the **non-faulty** ones. Their number is `(3f + 1) - f = 2f + 1`.
- Therefore, the **fraction** of honest participants is `(2f + 1) / (3f + 1)`. For any `f > 0`, this fraction is **greater than 2/3** (e.g., for `f=1`, it's 3/4; as `f→∞`, it approaches 2/3 from above). Thus, the honest majority must always control **> 2/3** of the total weight (stake).
- *Explanation:* Provides the mathematical derivation linking the abstract bound to the concrete blockchain requirement.
### **15. Cloud Computing**
**001. What is the definition of federated learning?**
- **Federated learning** is a machine learning technique where a **predictive model is trained across multiple decentralised edge devices or servers** holding local data samples, without exchanging the data itself.
- The training is **brought to the data** (at the edge) to preserve privacy and comply with data governance, instead of centralising all data for HPC training.
**002. Propose a cloud computing-based solution for monitoring critical processes in a factory (LPS)...**
- **Solution:** A **hybrid cloud-edge IoT platform**.
- **Deployment:**
    1.  **Sensors & Edge:** Deploy **IoT sensors** (temperature, gas, humidity) on the factory floor. Use **edge gateways** (e.g., Raspberry Pi with Azure IoT Edge/AWS Greengrass) to pre-process data (filter, aggregate) and run real-time anomaly detection.
    2.  **Cloud Platform:** Use a public cloud (e.g., AWS, Azure, GCP).
        - **IaaS/PaaS:** Use VMs or Kubernetes (**IaaS/PaaS**) to host the core application platform.
        - **Data Pipeline:** Use cloud **message queues** (e.g., AWS Kinesis/Azure Event Hubs) to ingest data from edge.
        - **Storage & Processing:** Store time-series data in a cloud **database** (e.g., TimescaleDB on cloud VMs, or AWS Timestream). Use **serverless functions** (FaaS) for event-driven alerts (e.g., SMS/email on threshold breach).
        - **Analytics & Dashboards:** Use cloud analytics services (e.g., AWS QuickSight) for dashboards showing real-time and historical trends.
    3.  **Justification:** The **edge** handles low-latency, real-time safety checks. The **cloud** provides scalable storage, complex analytics, historical compliance reporting, and global management. **Hybrid model** ensures resilience even if cloud connectivity is lost.
**003. What are the main characteristics of a distributed file system in a large-scale cloud system? Illustrate using GFS or HDFS.**
- **Key Characteristics:**
    1.  **Designed for Commodity Hardware:** Assumes and tolerates frequent component failures.
    2.  **Optimized for Large Files:** Manages multi-GB files efficiently, not many small files.
    3.  **Write-Once, Read-Many (WORM) Access Model:** Simplifies coherency; appends are primary.
    4.  **Centralized Master/Slave Architecture:** A single **master (NameNode in HDFS)** manages metadata (filenames, block locations). Many **chunk servers (DataNodes)** store actual data blocks.
    5.  **Data Replication:** Files are split into large blocks (e.g., 64-128MB) and each block is **replicated** (default 3x) across different racks/nodes for **fault tolerance**.
    6.  **Streaming Data Access:** High throughput is prioritized over low latency.
- **HDFS Example:** A client writes a file. The **NameNode** allocates blocks. The client writes data directly to a pipeline of **DataNodes**, which replicate each block. The NameNode updates the metadata. Reads are directed by the NameNode to the nearest DataNode holding the block.
**004. Cloud computing is often described as the fourth phase in the evolution of distributed computing. What are the four phases, and what is the key characteristic of the cloud phase?**
1.  **Linking Machines:** The Internet (TCP/IP).
2.  **Linking Documents:** The World Wide Web (HTTP, HTML).
3.  **Linking Applications:** Web Services & SOA (REST, SOAP).
4.  **Linking Everything as a Utility:** **Cloud Computing**. The key characteristic is delivering computing resources (processing, storage, networking) as an **on-demand, elastic, pay-per-use utility**, similar to electricity.
- *Explanation:* Tests the historical context and defining utility model of cloud computing.
**005. What is the core technological enabler that makes the **elasticity** and **multi-tenancy** of cloud computing feasible?**
- **Virtualisation.** It abstracts physical hardware to create multiple, isolated virtual machines (VMs) or containers. This allows a single physical server to run many tenants' workloads securely (multi-tenancy) and enables resources to be provisioned, migrated, and scaled dynamically (elasticity) with minimal overhead.
- *Explanation:* Tests the understanding of the fundamental technology underpinning cloud.
**006. Match the cloud service model on the left with the correct description of the consumer's responsibility on the right.**
    1. Infrastructure as a Service (IaaS)
    2. Platform as a Service (PaaS)
    3. Software as a Service (SaaS)
    A. Manages applications and data only.
    B. Manages applications, data, runtime, middleware, and OS.
    C. Manages applications, data, runtime, middleware, OS, and virtualised network/storage.
- **1 -> C** (IaaS: Consumer manages everything from the OS up).
- **2 -> B** (PaaS: Consumer manages application and data; provider manages runtime, OS, etc.).
- **3 -> A** (SaaS: Consumer only manages their own data and configuration).
- *Explanation:* Tests the core responsibility split in the cloud service stack.
**007. A company wants to migrate its existing, complex Java application which has specific library dependencies and requires a customised middleware configuration to the cloud. Which cloud service model—**IaaS** or **PaaS**—would be most appropriate, and why?**
- **IaaS (Infrastructure as a Service)** would be most appropriate.
- **Why:** The application has **specific, complex dependencies and custom middleware**. PaaS environments are often opinionated, offering a fixed set of runtimes and middleware. IaaS provides raw virtual machines, giving the company full control to install its specific Java version, libraries, and middleware, replicating its on-premises environment without modification.
- *Explanation:* Applies the service model decision to a scenario involving legacy/complex apps.
**008. What is the primary function of a **Virtual Infrastructure Manager (VIM)** like OpenStack in a cloud data centre?**
- To provide **orchestration and lifecycle management** for the pool of virtualised resources (compute, storage, network). It automates tasks like scheduling VMs onto physical hosts, provisioning from templates, managing virtual networks, monitoring health, and handling recovery from failures, presenting a unified API/dashboard to administrators and users.
- *Explanation:* Tests the role of the management layer in a cloud stack.
**009. Compare **Virtual Machines (VMs)** and **Containers** in terms of their architectural layer and typical use case in cloud-native development.**
- **Architectural Layer:** A **VM** virtualises the **entire hardware stack**, requiring a full guest Operating System. A **Container** virtualises at the **Operating System level**, sharing the host OS kernel and running isolated user-space instances.
- **Use Case:** **VMs** are used for running full, isolated legacy systems or mixed-OS workloads. **Containers** are the standard for **cloud-native, microservices-based applications** due to their lightweight nature, fast startup, and efficiency, often orchestrated by platforms like Kubernetes.
- *Explanation:* Tests the key distinction between the two virtualisation technologies central to modern clouds.
**010. What is **Kubernetes**, and what problem does it solve in a container-based cloud environment?**
- **Kubernetes** is a **container orchestration platform**.
- **Problem it Solves:** When deploying a microservices application composed of hundreds of containers, manually managing their placement, scaling, networking, and recovery is impossible. Kubernetes **automates** these operations: it schedules containers onto nodes, scales them based on load, manages service discovery, load balancing, and automatically restarts failed containers.
- *Explanation:* Tests the understanding of the need for and role of container orchestration.
**011. A financial services company wants to move its customer-facing web application to the cloud but must keep sensitive customer transaction data in its own data centre for regulatory reasons. Which cloud deployment model should it use, and what is a key technology that enables this model?**
- It should use a **Hybrid Cloud** deployment model.
- **Key Enabling Technology:** **Secure, high-bandwidth network connectivity** (like a dedicated leased line or VPN) between the company's private data centre (holding the sensitive data) and the public cloud provider (running the web front-end). This allows the application logic to run in the scalable public cloud while securely accessing the private data.
- *Explanation:* Tests the application of deployment models to a compliance and architecture scenario.
**012. In the "Check of Understanding" startup scenario, using a **PaaS** for backend logic and **SaaS** for the database and ML API is recommended. What is the primary **business benefit** of this approach for a startup?**
- **Dramatically reduced operational overhead and faster time-to-market.** The startup's small team can focus entirely on developing their unique application logic (PaaS) and integrating pre-built services (SaaS), without needing expertise in or spending time on infrastructure provisioning, database administration, or machine learning model training and hosting. This allows them to innovate and scale quickly with minimal initial investment.
- *Explanation:* Tests the business rationale behind choosing higher-level cloud service models.
**013. What is **cloud bursting**, and under which cloud deployment model is it typically implemented?**
- **Cloud bursting** is an application deployment model where an application runs in a **private cloud** or data centre but **"bursts"** into a **public cloud** when the demand for computing capacity spikes (e.g., during a sale or event).
- **Deployment Model:** This is a key use case of the **Hybrid Cloud** model, which combines private and public cloud resources.
- *Explanation:* Tests a specific dynamic scaling pattern enabled by hybrid cloud.
**014. The conceptual cloud architecture diagram shows a stack from Hardware to Applications. What is the role of the **Virtualisation & Management** layer in this stack?**
- It sits above the **Hardware** layer and is responsible for **abstracting the physical resources** (CPU, memory, storage, network) into flexible, shareable pools. The **Management** component (the VIM) then provides the APIs and automation to provision, monitor, and manage these virtualised resources, enabling the **Infrastructure as a Service** model.
- *Explanation:* Tests understanding of the layered architectural diagram from the notes.
**015. Why are modern cloud data centres built using massive numbers of **commodity (off-the-shelf) servers** rather than a smaller number of high-end, specialised servers?**
- For reasons of **cost, scalability, and fault tolerance**.
    - **Cost:** Commodity servers are much cheaper per unit of compute.
    - **Scalability:** It's easier and more flexible to scale out by adding more standard units.
    - **Fault Tolerance:** The software is designed to expect hardware failures. Losing a single cheap server among thousands has minimal impact, and its workload can be automatically migrated to others. This is more cost-effective than building ultra-reliable single servers.
- *Explanation:* Tests the economic and architectural principles behind warehouse-scale computing.
### **16. Distributed Systems Topics and Trends Pt.1**
**001. In an edge-server system, servers can be used to...**
- Optimise content distribution, optimise application distribution, optimise network traffic, support Quality of Service.
- Edge servers, placed at the boundary between core networks and access networks, serve several key purposes: **caching content** closer to users (optimising distribution), hosting parts of applications (optimising app distribution), reducing load on core network links (optimising traffic), and enabling low-latency services (supporting QoS).
**002. What are the two fundamental capabilities required to transform a traditional physical appliance (like a fridge) into an **Internet of Things (IoT)** device?**
1.  **Computational Intelligence:** The ability to **process sensor data locally** to interpret the environment and make basic decisions (e.g., recognising food items, tracking inventory).
2.  **Network Connectivity:** The ability to **send and receive data over a network** (e.g., Wi-Fi, cellular) to enable remote monitoring, control, and interaction with cloud services (e.g., sending alerts, placing orders).
- *Explanation:* Tests the core dual-component definition of an IoT device from the "fridge example."
**003. The classic "cloud-only" model faces three major challenges when applied to large-scale IoT deployments. Name these three challenges.**
1.  **Latency:** The round-trip delay to a distant cloud data centre is too high for applications requiring **real-time or near-real-time responses** (e.g., autonomous vehicles, industrial control).
2.  **Bandwidth/Congestion:** Transmitting **vast volumes of raw sensor data** from billions of devices to the cloud would **overwhelm network links**, causing congestion and high costs.
3.  **Data Volume:** Storing and processing all raw IoT data centrally in the cloud is **inefficient and expensive**; much of the data may be irrelevant noise.
- *Explanation:* Tests the fundamental problems that motivate the shift to edge computing.
**004. What is **Edge Computing**, and what primary problem does it address in the context of IoT?**
- **Edge Computing** is a distributed computing paradigm that moves **data processing, storage, and applications closer to the source of the data** (the IoT devices) – to the "edge" of the network, rather than in a centralised cloud data centre.
- **Primary Problem Addressed:** It solves the **latency** problem by enabling real-time processing and decision-making locally. It also alleviates **bandwidth congestion** by processing data locally and sending only valuable summaries or alerts to the cloud.
- *Explanation:* Tests the definition and primary purpose of edge computing.
**005. In the autonomous vehicle example, why is a **hybrid edge-cloud architecture** necessary? Specify one task best performed at the edge and one best performed in the cloud.**
- A hybrid architecture is necessary because the vehicle requires both **ultra-low latency responses** and **massive compute/storage resources** that no single layer can provide alone.
- **Task at the Edge:** **Real-time sensor fusion and obstacle avoidance.** Processing camera and LiDAR data *immediately* to avoid a collision cannot wait for a cloud round-trip.
- **Task in the Cloud:** **Training and updating the vehicle's deep learning models.** This requires massive datasets and computational power that is available in cloud data centres, and is not time-critical.
- *Explanation:* Tests the application of the edge-cloud continuum to a canonical use case.
**006. The "revisited cloud computing stack" diagram adds new layers below IaaS. What is the role of the **Edge Computing Layer** in this extended stack?**
- The Edge Computing Layer provides **localised compute, storage, and networking resources** close to IoT devices. Its role is to perform **initial data processing**: monitoring, analysis, filtering/reduction, and caching. It acts as a buffer and pre-processor, transforming high-volume, raw sensor data into manageable, valuable information before sending it upstream to the cloud for deeper analysis.
- *Explanation:* Tests understanding of the edge's position and function in the modern computing hierarchy.
**007. The vision for **edge-driven exascale computing** suggests a change in data flow. Instead of sending all raw data to the supercomputer, what does the edge do, and why is this more efficient?**
- The edge acts as an **intelligent filter and pre-processor**. It analyses the raw data locally and transmits only **critical information, anomalies, or highly refined data summaries** to the exascale supercomputer.
- **Efficiency:** This transforms what would be an **I/O-bound problem** (limited by the bandwidth of sending all data) into a **compute-bound problem** for the supercomputer. It maximises the utilisation of the supercomputer's immense processing power on meaningful computations rather than wasting its time and network resources on sifting through noise.
- *Explanation:* Tests the forward-looking concept of symbiotic edge and high-performance computing.
**008. The progression from Disruptive Applications -> Supporting Infrastructure -> Intelligent Distributed Systems describes an evolution. What is the ultimate goal of an **Intelligent Distributed System**?**
- The ultimate goal is to create a **seamless, adaptive, and efficient computing fabric** that intelligently distributes workloads across the entire cloud-edge continuum. The system itself manages resources, data flow, and processing locations autonomously to meet application demands for low latency, high bandwidth, and massive scale, appearing as a single, coherent intelligent entity.
- *Explanation:* Tests the high-level vision that concludes the section.
**009. In the "Check of Understanding" smart traffic management scenario, the edge server's task includes **filtering/aggregating data**. Give a concrete example of what this means and why it's critical.**
- **Concrete Example:** Instead of sending 24/7 high-definition video from every camera to the cloud, the edge server runs computer vision algorithms to extract **semantic information**: e.g., it outputs a simple data stream like `{intersection_id: 5, timestamp: ..., vehicle_count: 42, avg_speed: 30mph, incident_detected: false}`.
- **Why Critical:** This reduces the **data volume** sent to the cloud by **orders of magnitude**, saving bandwidth costs and cloud storage. It allows the cloud to focus on city-wide analytics using lightweight summary data, rather than being overwhelmed by petabytes of raw video.
- *Explanation:* Tests the ability to detail a key edge computing function within a scenario.
**010. Which of the following is a characteristic of the **IoT layer** in the revisited cloud stack, as opposed to the Edge layer?**
    A) It performs data aggregation and filtering.
    B) It consists of physical sensors and actuators with minimal local processing.
    C) It hosts long-term data storage and complex machine learning model training.
    D) It manages virtualised resource pools.
- **B) It consists of physical sensors and actuators with minimal local processing.**
- *Explanation:* **A** and **D** are functions of the Edge and IaaS layers respectively. **C** is a cloud function. **B** correctly identifies the IoT layer as the "things" themselves.
### **17. Distributed Systems Topics and Trends Pt.2**
**001. Edge computing is a distributed, open IT architecture that features decentralised processing power. Illustrate through an example how edge computing enables mobile computing and Internet of Things (IoT) technologies.**
- **Example: Smart City Traffic Management.**
    1.  **IoT Sensors:** Cameras and induction loops at intersections generate vast video and vehicle count data.
    2.  **Edge Computing:** An **edge server** at each intersection runs **computer vision algorithms** in real-time to detect traffic congestion, accidents, or count vehicles.
    3.  **Enabled Benefits:**
        - **Low Latency:** Traffic light control algorithms can react **immediately** to local conditions (e.g., extend green light for an ambulance detected), impossible if sending raw video to a distant cloud.
        - **Bandwidth Reduction:** Only **processed metadata** (e.g., "congestion level: high") is sent to the central cloud, not terabytes of raw video.
        - **Reliability:** The intersection operates autonomously even if cloud connection is lost.
    4.  **Cloud Role:** The central cloud aggregates metadata from all intersections for city-wide traffic flow optimization and long-term analytics.
**002. You have been asked to work on a project called Orientation and Mobility... Discuss how to deploy such solution...**
- **Deployment Strategy:** A **Mobile Edge Computing (MEC)** or **Device-Edge-Cloud** solution.
- **Architecture:**
    1.  **Device (Headset):** Runs lightweight **object detection model** (highly optimized, e.g., TensorFlow Lite). Performs **initial, low-latency detection**. Streams processed data (bounding box labels, confidence scores) and optionally compressed video to...
    2.  **Edge Device (Smartphone/Wearable Hub):** The user's smartphone acts as a personal edge. It runs a more sophisticated **scene understanding model**, fuses data from other sensors (GPS, IMU), and generates the specific, contextual voice message ("Obstacle: postbox, 2m ahead").
    3.  **Cloud:** Used for **model training/updates**, storing user travel patterns for route optimization, and aggregating anonymous data to improve city accessibility maps.
- **Justification:** Processing on the headset alone is limited. Offloading to the **personal smartphone edge** provides more compute without the latency of the cloud, ensuring **real-time, safe navigation**. The cloud handles non-real-time heavy lifting.
**003. Consider a distributed system in a smart factory with mobile robots supported by Edge Computing. (i) Explain briefly how Edge Computing can support this. (ii) Discuss the implications of the concurrent execution of components property.**
- **(i) Edge Computing Support:** An **edge server** in the factory acts as a local coordination hub. It runs the **fleet management software**, calculates optimal paths in real-time, processes data from on-robot sensors (LIDAR, cameras) for collision avoidance, and provides a local database of the factory floor plan. This ensures **ultra-low latency** for coordination and avoids reliance on a potentially slow or unreliable cloud connection.
- **(ii) Implications of Concurrency:** Multiple robots (components) execute **concurrently**. This leads to:
    - **Race Conditions:** Two robots might try to claim the same path segment.
    - **Need for Coordination:** Requires **distributed locking** or **transactional protocols** for shared resources (charging stations, inventory bins).
    - **Consistency Challenges:** Each robot's local map view must be kept **consistent** with the global edge server view and other robots' perceptions.
    - **Deadlock Potential:** Improper coordination can lead to deadlock (e.g., two robots waiting for each other to move).
- **Engineering Solution:** Use a **centralized coordinator on the edge server** for path planning (simplifies concurrency) while allowing robots distributed, reactive obstacle avoidance.
**004. Consider the issue of scalability in distributed systems... (i) What is the level of interaction complexity? (ii) Formula? (iii) How many interactions for 20 components?**
- **(i) Level of interaction complexity:** **Quadratic (O(n²))** in the number of components.
- **(ii) Formula:** If each of `N` components interacts with `k` others, the total number of *directed* interactions is up to `N * k`. If `k = N-1` (all-to-all), it's `N(N-1)`. If each interacts with *approximately half*, `k ≈ N/2`, so interactions ≈ `N * (N/2) = N²/2`.
- **(iii) Calculation for N=20, k≈10:** Interactions ≈ `20 * 10 = 200`. This illustrates the **scalability problem**: communication overhead grows rapidly with system size.
**005. Describe how you would solve the average house value per postcode problem using MapReduce.**
- **Map Stage (Processes each housing record):**
    - **Input:** (line_of_text).
    - **Map Function:** Parse the record to extract `postcode` and `value`.
    - **Emit:** `(postcode, value)`.
- **Shuffle/Sort Stage:** The MapReduce framework **groups all values** by the same `postcode` key.
- **Reduce Stage (Processes each postcode group):**
    - **Input:** `(postcode, [value1, value2, ...])` – a list of all house values for that postcode.
    - **Reduce Function:** Calculate `sum = sum([value1, value2, ...])`, `count = length of list`. Emit `(postcode, sum/count)`.
- **Output:** A list of `(postcode, average_value)` pairs.
**006. Comment on the student's statements about MapReduce.**
(i) "Each mapper must generate the same number of key/value pairs as its input had."
    - **False.** A mapper can emit **zero, one, or many** key/value pairs for a single input record (e.g., splitting text into words).
(ii) "The number of output jobs you get at the end of the job is m."
    - **False/Unclear.** The final output is determined by the number of **reducer tasks (`r`)**, not mappers (`m`). There are `r` output files (from the reducers).
(iii) "There will be m × r distinct copy operations in the sort/shuffle phase."
    - **False.** In the shuffle, each mapper sends *each* of its output key/value pairs to *the specific reducer* responsible for that key's partition. It's not a full `m x r` mesh.
(iv) "The earliest point at which the reduce method... can be called is as soon as a mapper has emitted at least one record."
    - **False.** The **reduce phase** typically starts only after **all mappers have finished** (unless speculative execution or optimizations like *slow-start reducers* are used, but it's not "as soon as").
(v) "A reducer is applied to all values associated with the same key."
    - **True.** This is the core guarantee: all values for a given key are sent to the same reducer.
**007. The **Edge-Cloud Continuum** is a key trend. What does this concept mean, and what new challenge does it introduce for system architects?**
- **Concept:** It means the rigid boundary between centralized "cloud" and dispersed "edge" is blurring into a **spectrum or continuum of compute resources**, from massive data centers to regional hubs to on-device processing (e.g., sensors, phones).
- **New Challenge:** **Distributed orchestration.** System architects must design platforms that can seamlessly **deploy, manage, and migrate** application components across this highly heterogeneous landscape, deciding dynamically where to place workloads to optimize for latency, bandwidth, cost, and energy.
- *Explanation:* Tests the definition and the primary technical implication of this trend.
**008. The relationship between **Artificial Intelligence (AI)** and Distributed Systems is described as two-way. Explain the two directions: "AI for Systems" and "Systems for AI".**
- **AI for Systems:** Using AI techniques (like **Large Language Models - LLMs** or **agentic AI**) to **automate and optimize the distributed system itself**. Examples include AI-driven resource scheduling, anomaly detection, automatic scaling policies, and self-healing fault recovery.
- **Systems for AI:** Designing new **distributed system architectures** specifically to support the massive computational and data demands of **training and running large AI models**. This includes specialized hardware (TPUs), high-bandwidth interconnects, and frameworks for distributed training (e.g., TensorFlow Distributed).
- *Explanation:* Tests understanding of the symbiotic relationship defining future intelligent systems.
**009. **WebAssembly (WASM)** is highlighted as an emerging solution for serverless and edge computing. What two key properties of WASM make it particularly suitable for the edge-cloud continuum?**
1.  **Fast Startup / Low Latency:** WASM binaries have a very **short cold-start time** compared to traditional containerized runtimes, which is critical for event-driven functions and responsive edge services.
2.  **Portability and Lightweight Footprint:** WASM provides a **secure, standardized binary format** that runs consistently across different hardware and OS platforms. Its modules are typically **small**, making them efficient to distribute and deploy across the continuum from cloud to constrained edge devices.
- *Explanation:* Tests the specific technical advantages of WASM in the context of modern trends.
**010. **Conflict-free Replicated Data Types (CRDTs)** are mentioned as an advancement beyond traditional consensus for ensuring consistency. What is the key guarantee provided by CRDTs, and what type of application are they ideal for?**
- **Key Guarantee:** CRDTs guarantee **eventual consistency** *without* requiring **coordination or consensus** during updates. Operations can be applied to any replica concurrently and independently; the data structure's mathematical properties ensure all replicas will **automatically converge to the same state**.
- **Ideal Application:** **Real-time collaborative applications** (like Google Docs, Figma) and **mobile apps with offline operation**, where low latency, high availability, and tolerance to network partitions are more important than strong, immediate consistency.
- *Explanation:* Tests the core innovation and application domain of CRDTs.
**011. What is a **Trusted Execution Environment (TEE)**, and how does it address security challenges in large-scale, multi-tenant cloud systems?**
- A **TEE** is a secure area of a main processor that guarantees **confidentiality and integrity** for code and data loaded inside it, even from the privileged OS or hypervisor.
- **Addressing Cloud Security:** It enables **Confidential Computing**. Sensitive workloads (e.g., processing financial or medical data) can run in a TEE on a shared cloud server. The data remains encrypted in memory and is only decrypted within the TEE, protecting it from other tenants, the cloud provider, and even insiders with physical access.
- *Explanation:* Tests a key security technology for modern distributed systems.
**012. The sustainability trend highlights the massive energy footprint of distributed computing. Beyond hardware efficiency, name **two software or protocol-level strategies** mentioned for improving energy efficiency in distributed systems.**
1.  **Energy-aware network protocols** that optimize data transmission to reduce power consumption.
2.  **Energy-conscious application design**, where software is written to minimize computational waste and leverage low-power states when possible.
- *Additionally:* **Virtualisation techniques** like VM consolidation to turn off idle servers.
- *Explanation:* Tests awareness of solutions beyond just buying better hardware.
**013. In the "Check of Understanding" collaborative editor scenario, the answer recommends CRDTs. What is the primary **trade-off** made when choosing CRDTs over a traditional primary-backup with remote writes protocol?**
- The trade-off is **consistency model vs. performance/availability**. CRDTs sacrifice **strong consistency** (immediate, global agreement on order) for **high availability and low latency**. They provide eventual consistency. The traditional primary-backup protocol provides strong consistency (sequential) but introduces higher write latency (waiting for replication) and becomes unavailable during network partitions or primary failure.
- *Explanation:* Tests the understanding of the CAP theorem trade-off inherent in choosing CRDTs.
**014. The module summary organizes Distributed Systems into four parts. According to this structure, under which part would you classify the study of **Byzantine Fault Tolerance** and the **Raft consensus algorithm**? Justify your choice.**
- **Part 3 – Distributed Systems Support (Coordination & Resilience).**
- **Justification:** Byzantine Fault Tolerance and Raft are fundamentally concerned with **enabling coordination** (agreeing on a single value/order) and **providing resilience** (tolerating process failures) in a distributed system. They are core support mechanisms that higher-level applications (in Part 4 - Use Cases) rely upon.
- *Explanation:* Tests the ability to categorize core concepts within the module's conceptual framework.
**015. The trend towards **Intelligent Distributed Systems** suggests using AI for system management. Describe one concrete example of how **agentic AI** could be used to improve fault tolerance in a cloud data centre.**
- **Example: Autonomous Failure Diagnosis and Recovery.** An **agentic AI system** could continuously monitor thousands of servers and microservices. Upon detecting an anomaly (e.g., a database node slowing down), it could autonomously:
    1.  **Diagnose** the root cause by analyzing logs and metrics (e.g., identify a failing disk).
    2.  **Take Action** by provisioning a new instance from a template, migrating data, and updating the load balancer—all without human intervention.
    3.  **Learn** from the event to improve future detection and response.
- This moves fault tolerance from manual, reactive ops to automated, proactive resilience.
- *Explanation:* Applies the "AI for Systems" concept to a specific FT scenario.
**016. The evolution of distributed computing is scaling in two dimensions: **compute power (exascale)** and **user/data scale (internet scale)**. How do the primary technical challenges differ between building a system for these two different scales?**
- **Exascale (Compute):** Challenges are **tight coupling and coordination**. The focus is on **low-latency, high-bandwidth interconnects** (e.g., InfiniBand) and sophisticated **parallel programming models** (MPI) to keep millions of cores working efficiently on a single, massive problem (like a climate simulation).
- **Internet Scale (Users/Data):** Challenges are **loose coupling and fault tolerance**. The focus is on **stateless designs, eventual consistency, replication, and geo-distribution** to handle billions of independent requests, tolerate constant partial failures, and serve users globally with low latency.
- *Explanation:* Tests the understanding that scale in different dimensions requires different architectural priorities.
### **Miscellaneous / Core Concepts**
**001. Provide an example of when a DS would be placed in a system.**
- A DS would be placed in a system when **scalability or reliability** becomes a critical need. Example: Placing a **load balancer** and a **cluster of web servers** in front of a single database to handle high traffic for an e-commerce website.
**002. What is the role of middleware in a DS? Give an example.**
- The role of middleware is to **enable communication and coordination** between different components. **Middleware acts as the glue**.
- Example: An **RPC framework** (like gRPC) that allows a client written in Java to seamlessly call a function on a server written in Python, handling all network communication and data marshalling.
**003. Define middleware.**
- **Middleware** is a software layer that sits **between the operating system and applications**. It provides common services (communication, naming, security) to allow diverse and distributed components to interoperate, hiding the underlying heterogeneity.
**004. What is a distributed system?**
- A network of independent computers that appear to the users as a single coherent system.
- A distributed system is a collection of autonomous nodes that communicate via message passing. The key is that these nodes collaborate to present themselves as a unified whole to the end user, hiding the underlying complexity of distribution.
**005. Which of the following is a key characteristic of distributed systems?**
- Scalability.
- Scalability—the ability to effectively handle growth in the number of users, data volume, or geographic spread—is a fundamental goal and defining challenge of distributed systems. Centralized systems are inherently limited in this regard.
**006. In a distributed system, what is the role of middleware?**
- To enable communication and coordination between different components. Middleware acts a glue.
- Middleware is the software layer that sits between the operating system and applications, providing common services such as communication, naming, and security. It abstracts the heterogeneity of the underlying infrastructure, acting as the "glue" that allows diverse components to work together seamlessly.
**007. What is the primary advantage of using a distributed system?**
- Improved performance and reliability.
- By distributing computation and storage across multiple machines, a system can process tasks in parallel (improving performance) and continue operating if some components fail (improving reliability).
**008. A client binds to a distributed object. The proxy (the object’s interface implementation) is loaded into the client address’ space and an object’s method is invoked. The client realises that the result returned by the object is different from the one returned the day before. Is this possible?**
- Yes.
- **Yes, this is possible.** The principle of **encapsulation** in distributed objects means the client only depends on the **public interface**. The server-side **implementation** of the method can be changed, upgraded, or even switched to a different algorithm without altering the interface. The client's proxy remains the same, but the underlying logic producing the result can differ.
**009. In the statement "Standard interfaces and protocols ensure that the *?* of messages and the *?* of communication are preserved when a message is passed between two dissimilar computer systems", what are the two missing words?**
- Content / semantics.
- The correct pair is **content** and **semantics**. Standardised **protocols** (rules for exchange) and **interfaces** (how to call) ensure the raw **content** of the message is not corrupted during transfer and, crucially, that its meaning (**semantics**) is correctly interpreted by the receiver, despite differences in underlying hardware or software.
**010. What is the missing word? In a client/server architecture, a client with most resources installed locally rather than distributed over the network is known as a ??? client**
- Fat client.
- A **fat client** (or thick client) is one that implements the majority of the application's business logic and functionality locally. It relies less on the server, which may act primarily as a data backend. This contrasts with a **thin client**, which does minimal processing and relies heavily on the server.
**011. You are accessing from a computer in Bragg 2.05 Lab a remote database located on Microsoft Azure cloud (using JDBC). The MySQL server resides on a host called mariadb.azure.com, which stores additional data on a server called storage.azure.com. Which client/server architecture model is this?**
- 3-Tier.
- This is a classic **3-tier architecture**:
    1.  **Presentation Tier:** The client application/Java program in the lab.
    2.  **Application/Logic Tier:** The `mariadb.azure.com` MySQL server (processing queries).
    3.  **Data Tier:** The `storage.azure.com` server (persistent storage). The logic tier (server) acts as a client to the data tier.
# s
Next. Content:

Questions:
