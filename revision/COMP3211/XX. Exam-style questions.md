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

#### Exam
1. What is the purpose of a message queue in a distributed system?
- To store messages temporarily
- To ensure messages are delivered in order

2. What does an endpoint represent in a Service-Oriented Architecture(SOA)?
- A network-accessible address where a service can be invoked
- In SOA, an endpoint is the specific location(often a URL) where a service is made available to consumers. It defines how and where the service can be accessed.
3. Consider a nested transaction that has started several subtransactions in parallel. One of these commits and makes its results visible to the parent transaction. After further computation, the parent aborts. What happens next?

- The parent restores the entire system to the state it had before the top-level transaction started

- The results of the subtransaction that committed are undone

- As demonstrated by the ACID properties

4. In addition to computers, which of the following resources can be shared on a Grid?

- storage

- application software

- specialised equipment such as sensors

- databases

- By definition, anything can be shared on the Grid

5. Consider a social-media application in which clients connect to an online service to exchange information. Which statement(s) is /are true?

- The connection between a specific client and the service is tight

- The coupling between clients is loose

- The client first interacts with a centralised server, so the connection between a client and the service is tight. The coupling between clients is loose when they interact with each other(no dependency).

6. Essentially everyone, when they first build a distributed application, makes eight assumptions as discussed in the lecture. All prove to be false in the long run and cause big trouble and painful learning experiences. There is argument for a 9th fallacy. Which one is it?

- All clocks are synchronised

7. What is a Virtual organisation?

- a group of people geographically distributed that come together from different organisations to work on a Grid project

8. Caching is a special form of replication, but caching and replication lead to consistency problems

T

F

False

9. A client binds to a distributed object. The proxy (the object’s interface implementation) is loaded into the client address’ space and an object’s method is invoked. The client realises that the result returned by the object is different from the one returned the day before. Is this possible?

- Yes. Although the interface did not change, the implementation of the object's method may have. This is hidden from the end-user.

10. An ad hoc network is created between a group of friends playing a multiplayer game over wireless links on a collection of mobile devices including smartphones and tablets. Identify the classes of heterogeneity that may occur in this scenario. - performance, platform and operating system

- Three aspects of heterogeneity: performance, platform and operating system

11. You are initiating an MPI program with the command "mpirun -np 4 ./myprog". What does the call to MPI_Init do?

- Enable the 4 independent programs subsequently to communicate with each other

- Enable the 4 independent programs subsequently to communicate with each other

12. Consider a ubiquitous computing whose primary feature is to take into account the context in which interactions take place. Context aware applications are built with the consideration of shared data spaces. Which statement is true?

- processes are decoupled in time and space

- The aspect of shard data spaces is attractive as it combines flexibility and distribution. Processes are decoupled in time and space

13. The DNS name space is organised

- hierarchically into a tree of domains , which are divided into non-overlapping zones

- DNS is organised hierarchically into a tree of domains , which are divided into non-overlapping zones

14. In a structured peer-to-peer system where data items are stored, the system is seen to implement

- a distributed hash table, as explained in the lecture (see slide)

15. In the statement "Standard interfaces and protocols ensure that the _?_ of messages and the _?_ of communication are preserved when a message is passed between two dissimilar computer systems", what are the two missing words?

- content / semantics: content of message and semantic of communication. Think protocols

16. In the context of RPC, stubs make the remote procedure call appear as a local call to the client, hiding the complexities of network communication. - This is true, see the definition of a stub.

17. The intra-Lilliputian quarrel was over

- the practice of breaking eggs, smaller vs larger end (little vs big endian)

18. Suppose you organise a sensor network as a distributed database. You decide that sensors do not cooperate but simply send their data to a centralised database located at the operator's site. This approach will

- waste network resources

- waste energy

- Constantly sending data to a centralised database will lead to a waste of network resources (e.g. bandwidth) and energy (due to resource consumption)

19. In a resource-based architecture, resources are addressed by

- URIs, e.g. in the context of REST

20. You are accessing from a computer in Bragg 2.05 Lab a remote database located on Microsoft Azure cloud (using JDBC). The MySQL server resides on a host called mariadb.azure.com, which stores additional data on a server called storage.azure.com. Which client/server architecture model is this?

- 3-Tier

21. In the context of RPC, which of these statements is true:

- Serialisation is part of marshalling

-The client-side stub is responsible for taking the parameters provided by the client, marshalling them into a format suitable for network transmission, and sending the request to the server. Serialisation is part of marshalling and consists of the conversion of the message into a linear sequence of bytes or characters that can be shared or stored.

22. Consider a distributed system supported by message queues. A process needs to install a callback function, which is automatically invoked whenever a message is put into a specified queue. Such notification can be implemented by

- a handler

- To notify the process, a handler is to be called when a message is put into the specified queue

23. What is the missing word? In a client/server architecture, a client with most resources installed locally rather than distributed over the network is known as a ??? client

- Fat client as it does more than it should

24. You are designing a ubiquitous computing system for a car where the settings of the driver’s seat, steering wheel, and mirrors are fully personalised. If Bob takes a seat, the system will recognise that it is dealing with Bob and subsequently makes the appropriate adjustments. The same happens when Alice uses the car. Which core requirement does this satisfy?

- Interaction

- In ubiquitous computing systems design, when it comes to interaction with end users, special attention needs to be paid to how the interaction between users and core system takes place.

25. In an edge-server system, servers can be used to

- optimise content distribution

- optimise application distribution

- optimise network traffic

- support Quality of Service

26. In a distributed system, how long does it take to send a file from a sender host A to a receiver host B considering the following assumptions: the file size is 256 MegaBytes, the communication link is 5.12 GigaBytes/second, and the propagation delay is 30 milli-seconds. Note: 1 Giga = 1,000 Mega

- 0.08 seconds

- Time = size/bandwidth + latency which is 128/5120 + 0.030 = 0.055 seconds = 55 milli-seconds