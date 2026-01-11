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

### **5. Service Oriented Architectures**
*(No specific questions from the provided list directly correspond to this topic header. Questions about "what is a service," architecture models, and differences are conceptual and covered indirectly in other sections like Web Services and Microservices).*
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


### **13. Consistency and Replication Pt.2**
*(All key questions for this topic are covered in Pt.1. The list does not contain specific questions on the sub-headings like Monotonic Reads or specific protocols).*
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


### **16. Distributed Systems Topics and Trends Pt.1**
**001. In an edge-server system, servers can be used to...**
- Optimise content distribution, optimise application distribution, optimise network traffic, support Quality of Service.
- Edge servers, placed at the boundary between core networks and access networks, serve several key purposes: **caching content** closer to users (optimising distribution), hosting parts of applications (optimising app distribution), reducing load on core network links (optimising traffic), and enabling low-latency services (supporting QoS).
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