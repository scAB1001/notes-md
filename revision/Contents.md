### **1. Introduction to Distributed Systems**
*   **Definition of a Distributed System (DS)**
    *   **Distributed versus Decentralised Systems**
        *   **(EXAMPLE 1) Blockchain (Decentralised System)**
        *   **(EXAMPLE 2) Geographically Dispersed Monitoring (Decentralised System)**
        *   **(EXAMPLE 3) Content Delivery Network (CDN) (Distributed System)**
        *   **(EXAMPLE 4) Network-Attached Storage (NAS) (Distributed System)**
*   **Goals and challenges & Sharing of resources**
*   **Transparency**
    *   **(TYPES OF TRANSPARENCY)**
*   **Openness**
*   **Scalability Issues**
    *   **(SCALING SIZE)**
    *   **(SCALING GEOGRAPHICALLY - THE LATENCY & BANDWIDTH PROBLEM)**
    *   **(SCALING ADMINISTRATIVELY - THE TRUST & POLICY PROBLEM)**
*   **Scaling Techniques**
    *   **(SOLUTION 1) Hiding Communication Latencies**
    *   **(SOLUTION 2) Partitioning and Distribution**
        *   **(EXAMPLE - DOMAIN NAME SYSTEM (DNS))**
    *   **(SOLUTION 3) Replication**
*   **Pitfalls (9)**
### **2. Types of Distributed Systems**
*   **1. High performance distributed computing systems (HPDCS)**
    *   **Distributed Shared Memory systems**
    *   **Cluster Computing**
    *   **Grid Computing**
    *   **Cloud Computing**
        *   **(THE FOUR LAYERS OF A CLOUD)**
        *   **(OBSTACLES)**
*   **2. Distributed information systems**
    *   **Transactions**
        *   **(CONTEXT)**
        *   **(SUB-TRANSACTIONS & NESTING)**
        *   **(TRANSACTION PROCESSING (TP) MONITORS)**
        *   **(MIDDLEWARE FOR EAI)**
    *   **Coupling in Distributed Systems: Space vXs. Time**
        *   **(INTERSECTION)**
        *   **(TRADE-OFFS)**
*   **3. Distributed Systems for Pervasive computing (DPS)**
    *   **Ubiquitous Computing Systems (UCS)**
    *   **Mobile computing systems**
        *   **(ROUTING STRATEGIES)**
    *   **Sensor (and actuator) networks**
        *   **(DATABASE VIEW & DATA ACCESS)**
        *   **(DATA PROCESSING ARCHITECTURES)**
        *   **(GOOGLE SPANNER - A CASE STUDY IN GLOBAL CONSISTENCY)**
### **3. Architectures**
*   **Understand the different ways on how to view the org of a DS**
*   **Architectural styles**
    *   **Layered**
        *   **(LAYERED COMMUNICATION PROTOCOL)**
        *   **(APPLICATION LAYERING: THE PAD MODEL)**
    *   **Object-based**
    *   **Resource-centred**
    *   **Event-based (Publish-Subscribe)**
*   **System architecture**
    *   **Centralised**
    *   **Decentralised (Peer-to-Peer - P2P)**
    *   **Hybrid**
### **4. Communication**
*   **Latency and Bandwidth**
    *   **(LATENCY)**
    *   **(BANDWIDTH)**
*   **Layered Protocols**
    *   **(MIDDLEWARE PROTOCOLS)**
*   **Types of Communication**
    *   **(SYNCHRONOUS vs. ASYNCHRONOUS)**
    *   **(TRANSIENT vs. PERSISTENT)**
*   **Remote Procedure Call (RPC)**
    *   **(BASIC OPERATION)**
    *   **(PARAMETER PASSING & MARSHALLING)**
    *   **(ASYMPTOTOIC RPC)**
    *   **(REMOTE METHOD INVOCATION - RMI)**
*   **Message Oriented Middleware**
    *   **(MESSAGE-QUEUING MODEL)**
    *   **(THE MESSAGE-PASSING INTERFACE - MPI)**
    *   **(ADVANCED MESSAGE QUEUING PROTOCOL - AMQP)**
### **5. Service Oriented Architectures**
*   **Conceptual Design of Software systems**
*   **Architectures**
    *   **N-Tier**
        *   **(1-Tier)**
        *   **(2-Tier)**
        *   **(3-Tier)**
*   **Emergence of SOAs**
*   **Vision**
    *   **What is a ‘Service’?**
    *   **Architecture Model**
    *   **Service Provision and Consumption**
    *   **Differences between SOAs and traditional n-tier architectures**
### **6. Web Services and REST**
*   **Why do we need Web services?**
*   **What are web services?**
    *   **(SOA ROLES & EXAMPLE)**
    *   **(KEY FEATURES)**
*   **What is REST?**
*   **What does it consist of?**
    *   **(RESOURCE-BASED ARCHITECTURE)**
    *   **(REPRESENTATIONAL STATE TRANSFER)**
    *   **(PRACTICAL EXAMPLE)**
*   **Claimed benefits**
*   **HTTP**
    *   **(ANATOMY OF HTTP REQUEST)**
    *   **(ANATOMY OF HTTP RESPONSE)**
    *   **(HTTP STATUS CODES)**
    *   **(ADDITIONAL HTTP VERBS)**
### **7. Programming RESTful Web Services**
*   **Reference implementations:**
    *   **Python (Flask Restful)**
        *   **(BASIC EXAMPLE)**
        *   **(CRUD RESOURCE EXAMPLE)**
    *   **Java (Jersey)**
        *   **(JAX-RS ANNOTATIONS)**
        *   **(EXAMPLE: SIMPLE CALCULATOR)**
        *   **(OTHER FRAMEWORKS)**
*   **Data encoding and RPC**
### **8. Microservices, Nanoservices and Serverless**
*   **Recap: SOAs**
*   **Microservices**
    *   **(KEY FEATURES)**
    *   **(ARCHITECTURAL SHIFT)**
    *   **(CONTAINERS & MICROSERVICES)**
*   **Nanoservices**
*   **Serverless Computing**
*   **Function as a Service (FaaS)**
    *   **(EXECUTION MODEL)**
*   **Architectural Support**
    *   **(KEY METRICS & CHALLENGES)**
    *   **(EVOLUTION OF GRANULARITY)**
*   **Solutions**
    *   **(COMMERCIAL & OPEN SOURCE FaaS PLATFORMS)**
    *   **(BENEFITS)**
### **9. Naming Pt.1**
*   **Fundamental concepts**
    *   **(DEFINITIONS)**
    *   **(ACCESS POINTS AND ADDRESSES)**
    *   **(FUNCTION OF A NAMING System)**
*   **Namespaces**
    *   **(BROADCASTING)**
    *   **(FORWARDING POINTERS)**
    *   **(HOME-BASED APPROACH)**
*   **Naming graphs**
    *   **(DISTRIBUTED HASH TABLES - DHTs)**
    *   **(HIERARCHICAL APPROACHES)**
        *   **(LOOKUP OPERATION)**
        *   **(INSERT OPERATION)**
### **10. Naming Pt.2**
*   **Structured naming**
    *   **Namespaces**
    *   **Name resolution**
        *   **(CLOSURE MECHANISM)**
        *   **(PATH NAME RESOLUTION)**
        *   **(LINKING)**
        *   **(MOUNTING)**
    *   **Implementation of a namespace**
        *   **(DOMAIN NAME System - DNS)**
*   **Attribute-based naming**
    *   **(LDAP - LIGHTWEIGHT DIRECTORY ACCESS PROTOCOL)**
    *   **(JAVA NAMING AND DIRECTORY INTERFACE - JNDI)**
### **11. Timing and Synchronisation**
*   **Synchronisation in a DS**
*   **Internal and external physical clocks**
    *   **(INTERNAL CLOCKS)**
    *   **(EXTERNAL STANDARDS & UTC)**
    *   **(TIME REPRESENTATION)**
*   **Clock synchronisation algorithms**
    *   **(CRISTIAN'S ALGORITHM)**
    *   **(BERKELEY ALGORITHM)**
*   **Drift as a Function of UTC**
*   **Election Algorithm**
    *   **(BULLY ALGORITHM)**
    *   **(RING ALGORITHM)**
*   **Network time protocol (NTP)**
    *   **(STRUCTURE)**
    *   **(CLOCK CORRECTION)**
### **12. Consistency and Replication Pt.1**
*   **Introduction to the problem**
    *   **(REASONS FOR REPLICATION)**
    *   **(THE CONSISTENCY PROBLEM)**
    *   **(THE PERFORMANCE-SCALE DILEMMA)**
*   **Data-centric consistency models**
    *   **Continuous Consistency**
        *   **(CONSISTENCY UNIT - CONIT)**
        *   **(CONIT EXAMPLE)**
    *   **Sequential Consistency**
        *   **(THE ROLE OF TIME)**
        *   **(EXAMPLE WITH PROGRAMS)**
        *   **(THE HAPPENS-BEFORE RELATION)**
    *   **Causal Consistency**
        *   **(VIOLATION EXAMPLE)**
### **13. Consistency and Replication Pt.2**
*   **Client-centric consistency models**
    *   **(BASIC ARCHITECTURE)**
    *   **Monotonic Reads (MRs)**
    *   **Monotonic Writes (MWs)**
    *   **Read Your Writes (RYWs)**
*   **Replica management**
    *   **Content Replication**
    *   **Server-Initiated Replica Example**
        *   **(ALGORITHM)**
    *   **Consistency Protocols: Primary-backup Protocol with Remote Writes**
        *   **(MECHANISM - BLOCKING)**
        *   **(CHARACTERISTICS & PERFORMANCE)**
    *   **Consistency Protocols: Primary-backup Protocol with Local Writes**
        *   **(MECHANISM)**
        *   **(USE CASES & TRADE-OFFS)**
### **14. Fault Tolerance**
*   **Dependability, reliability and availability in a DS**
    *   **(Availability)**
    *   **(Reliability)**
    *   **(Safety)**
    *   **(Maintainability)**
    *   **(QUANTIFYING AVAILABILITY & RELIABILITY)**
    *   **(NOTE)**
*   **Terminology**
*   **Failure models**
    *   **Dependability vs Security (Omission versus Commission)**
    *   **Failure Masking by Redundancy**
*   **Process resilience by Groups**
    *   **Groups org**
        *   **(FLAT GROUP)**
        *   **(HIERARCHICAL GROUP)**
    *   **Groups and Failure Masking**
*   **Consensus with crash failures**
    *   **Crash Failures: Flooding-based Consensus**
    *   **Raft Consensus Algorithm**
    *   **The Two Generals Problem**
*   **The Byzantine Generals Problem**
*   **Consensus with arbitrary failures**
    *   **Byzantine Agreement: Requirements**
    *   **Why having 3k processes is not enough**
    *   **System Models**
### **15. Cloud Computing**
*   **Technology Landscape**
    *   **(EVOLUTION OF DISTRIBUTED COMPUTING)**
*   **Towards a Definition of Cloud Computing**
    *   **(CLOUD DATA CENTERS)**
*   **Virtualised infrastructures**
    *   **(BENEFITS)**
*   **Conceptual Cloud Architecture**
*   **Taxonomy of cloud Models**
    *   **Infrastructure as a Service (IaaS)**
    *   **Platform as a Service (PaaS)**
    *   **Software as a Service (SaaS)**
*   **Virtual Infrastructure Managers (VIMs)**
    *   **(ROLE OF A VIM)**
    *   **(OPENSTACK EXAMPLE)**
*   **Cloud services**
    *   **(VIRTUAL MACHINES VS. CONTAINERS)**
    *   **(THE CASE OF CONTAINERS & MICROSERVICES)**
*   **Private, Public, and Hybrid Clouds**
### **16. Distributed Systems Topics and Trends Pt.1**
*   **IoT: the Internet of Things**
    *   **(INTEGRATING A DEVICE INTO IoT - THE FRIDGE EXAMPLE)**
    *   **(EXAMPLE ARCHITECTURE)**
*   **Edge Computing**
    *   **(THE CLOUD TO EDGE SHIFT)**
    *   **(EXAMPLE - DRIVERLESS CARS)**
*   **Revisiting the Cloud Computing Stack**
*   **Vision for a (near) future**
    *   **(EDGE-DRIVEN EXASCALE)**
    *   **(INTELLIGENT DISTRIBUTED SYSTEMS)**
### **17. Distributed Systems Topics and Trends Pt.2**
*   **Module themes**
*   **Evolution of distributed computing**
    *   **(SCALABILITY IN COMPUTE - EXASCALE)**
    *   **(SCALABILITY IN USERS & DATA - INTERNET SCALE)**
*   **Most Active Topics in Distributed Systems**
    *   **(1-Edge-Cloud Continuum)**
    *   **(2-Intelligent Distributed Systems)**
    *   **(3-Serverless and Event-Driven Architectures)**
    *   **(4-Reliability, Consistency, and Correctness at Scale)**
    *   **(5-Secure Large Scale Distributed Systems)**
    *   **(6-Think Sustainability?)**