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
11. What is the definition of a centralised system?
12. Why might we use a centralised system? Give an example scenario.
13. What is the definition of a decentralised system?
	A **decentralised** system is a networked computer system in which processes and resources are **necessarily** spread across multiple computers.
14. Why might we use a decentralised system? Give an example scenario.
	They come to being because we want to connect systems, yet may be hindered by administrative boundaries. For example, many applications in the artificial-intelligence domain require massive amounts of data for building reliable predictive models.
15. What’s the difference between a distributed and decentralised system?
16. Provide an example of when a DS would be placed in a system.
17. Explain what is meant by the term 'distribution transparency' and provide examples.
18. Describe the integrative view of a DS.
	Connecting existing networked computer systems into a larger a system.
19. Describe the expansive view of a DS.
	An existing networked computer system is extended with additional computers.
20. What is the definition of federated learning?
	Federated learning describes the method of building reliable predictive AI models, typically in a decentralised system.
	Usually, HPC would be used to train these models but when data must remain within the organisation, the training is, instead, brought to the data.  
21. 
22. Describe some common challenges of a DS.
	Architecture: common organisations, common styles
	Process: what kind of processes, and their relationships
	Communication: facilities for exchanging data
	Coordination: application-independent algorithms
	Naming: how do you identify resources?
	Consistency and replication: performance requires of data, which need to be the same
	Fault tolerance: keep running in the presence of partial failures
	Security: ensure authorised access to resources
23. What is the definition of distribution transparency?
	 The phenomenon by which a DS attempts to hide the distribution of its processes and resources are physically from it's end-users and applications. They are typically distributed across multiple computers, possibly separated by large distances. 
24. How does a DS achieve distribution transparency?
	Distribution transparency is realised through middleware.
	In essence, what applications get to see is the same interface everywhere, whereas behind that interface, where and how processes and resources are and how they are accessed is kept transparent.
25. What is the process perspective?
26.  What is the communication perspective?
27. Define access transparency of a DS. Provide an example.

28. Define location transparency of a DS. Provide an example.
	The Uniform Resource Locator (URL) for a website, gives no clue of the actual physical location of the web server, nor their previous whereabouts  where the data is/has been offered.
29. Define migration transparency of a DS. Provide an example.
30. Define relocation transparency of a DS. Provide an example.
31. Define replication transparency of a DS. Provide an example.
32. Define concurrency transparency of a DS. Provide an example.
33. Define failure transparency of a DS. Provide an example.