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
24. 
25. Describe some common challenges of a DS.
	Architecture: common organisations, common styles
	Process: what kind of processes, and their relationships
	Communication: facilities for exchanging data
	Coordination: application-independent algorithms
	Naming: how do you identify resources?
	Consistency and replication: performance requires of data, which need to be the same
	Fault tolerance: keep running in the presence of partial failures
	Security: ensure authorised access to resources
26. What is the definition of distribution transparency?
	 The phenomenon by which a DS attempts to hide the distribution of its processes and resources are physically from it's end-users and applications. They are typically distributed across multiple computers, possibly separated by large distances. 
27. How does a DS achieve distribution transparency?
	Distribution transparency is realised through middleware.
	In essence, what applications get to see is the same interface everywhere, whereas behind that interface, where and how processes and resources are and how they are accessed is kept transparent.
28. What is the process perspective?
29.  What is the communication perspective?
30. Define access transparency of a DS. Provide an example.
31. Define location transparency of a DS. Provide an example.
	The Uniform Resource Locator (URL) for a website, gives no clue of the actual physical location of the web server, nor their previous whereabouts  where the data is/has been offered.
32. Define migration transparency of a DS. Provide an example.
33. Define relocation transparency of a DS. Provide an example.
34. Define replication transparency of a DS. Provide an example.
35. Define concurrency transparency of a DS. Provide an example.
36. Define failure transparency of a DS. Provide an example.
37. What is meant by the terms 'resource sharing'? Give an example.
38. What is meant by 'openness' in a DS? Give an example.
39. Explain what the terms 'Interoperability, composability, and extensibility' refer to in an open DS.

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
1. 