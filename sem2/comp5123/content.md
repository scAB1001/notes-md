# Prompt
You are an expert in the UK UG BSc, MSc Computer Science, Cloud Computing Systems field. I am currently taking this module and need assistance writing my lecture revision notes for my exam. Ensure keywords, terminology, language and concepts are always clear and bold. There should be brief, concise examples and explanations for every important concept --- multiple if complex. I want no unnecessary spacing and I want clear headers that fit with the module outline.
I will provide you with exam papers, content and exam structure.
### Prerequisites
- The stated prerequisite for this module requires students
	- To have some background in distributed systems and networking
	- To be able to write code independently
- This module does not teach
	- the concepts of programming
	- the skills to program in a programming language
	- OS (Linux) skills
- General distributed systems concepts, e.g.
	- Terminology
	- Middleware
	- Service Oriented Architectures
	- Web services
	- Networking aspects
### Programming, Technologies, Tools
- Programming languages (Python, Java …)
- OS (Linux)
- Software installation
- Source code editor, e.g. VS Code
- Simulation software
- Mininet
- Prometheus
- Grafana
- Virtualisation
- Docker
- Kubernetes, Minikube, Kubectl
- Knative
- Hadoop, Spark
- Other
### Course Outline - Themes
1. Distributed system models and enabling technologies
2. Cloud computing - architectures, services, models, use cases
3. Public and private clouds
4. Virtualization of clusters/data centres, containers and unikernels
5. Virtual Infrastructure Management, Disaggregated computing
6. Resource management and Kubernetes
7. Software-defined networking and Network Functions Virtualization
8. Cloud programming and software environments
9. Serverless architectures
10. Cloud middleware and configuration management
11. Big data. MapReduce and Hadoop
12. Energy Efficiency
13. Ubiquitous clouds, Internet of things, Edge Computing, Edge Intelligence
14. A Glimpse on 6G mobile networks softwarization
15. Clouds in the Exascale
#### Text books (Content used for this module)
- Cloud Computing for Science and Engineering. I. Foster and D.B. Gannon. MIT Press, 2017
- Cloud computing. S. Bhowmik, Cambridge University Press, 2017
- Distributed Systems - Principles and Paradigms. Tanenbaum A.S. and van Steen M., Prentice Hall, 3rd Edition, 2017
- Computer Networking: A Top-Down Approach. J. Kurose and K. Ross, 8th Edition, Pearson, 2021
### Exam details
- Open book - bring any notes*
## Example of previous exam notes written for another module
```markdown
# Lecture 1: Introduction to Data Science
## 1. Core Definition & Scope > **Data Science** is a multidisciplinary field using principles, algorithms, and processes to extract **nonobvious and useful patterns** from **large data sets**. It encompasses the full **data lifecycle**: capture, cleaning, analysis, modelling, and presentation. * **Machine Learning (ML)** is a subset focused on algorithmic pattern extraction. * **Data Mining** typically analyses structured data for discovery. * **Data Science** includes **unstructured data** (e.g., social media), **big-data technologies**, and **data ethics**. ## 2. Datafication > **Datafication** is the process of taking all aspects of life and turning them into **quantifiable data**. Once datafied, information can be repurposed into new forms of value. **Example**: A **fitness tracker** datafies sleep, movement, and heart rate. The resulting data allows a user to derive **actionable insights**, such as linking poor sleep quality to late-night screen time, which would be difficult to notice otherwise. ## 3. Key Skills of a Data Scientist * **Technical**: Computer Science, Mathematics, Statistics, Machine Learning. * **Domain Expertise**: Understanding the specific field (e.g., healthcare, film). * **Soft Skills**: Communication, Presentation, **Data Visualisation**. ## 4. Core Process & Workflow 1. **Data Collection & Preparation**: **Collecting, Curating, Cleaning**. The most time-consuming phase. 2. **Analysis & Modelling**: **Visualize, Analyze, Model (Machine Learning)**. 3. **Critical Questions Before Modelling**: * Does the **past represent the future**? (Assumption for predictive models). * What is the **goal** of the model? * How will it be **used**? * What data is **needed** vs. **available**?
## 5. Example Applications * **IMDb**: Structured, crowdsourced data enabling questions on actor careers, film success factors (**correlation** between budget/ratings), and societal trends (e.g., age disparity between actors/actresses). * **Gapminder**: Uses **GDP per capita** (a **metric** for national wealth) to analyse relationships with health outcomes like life expectancy, demonstrating **exploratory data analysis**.
## 6. Historical Context & Greater Data Science (GDS) * **50-Year Foundation**: Roots in statistics (Tukey, Cleveland) advocating for a broader **data analysis** science beyond theory. * **Lesser Data Science (LDS)**: Current, narrow commercial focus on **big-data** tools and scalability. * **Greater Data Science (GDS)**: Donoho's proposed rigorous framework with six divisions: 1. Data Exploration & Preparation. 2. Data Representation & Transformation. 3. Computing with Data. 4. Data Modelling (includes both **statistical inference** and **predictive modelling**). 5. Data Visualisation & Presentation. 6. **Science about Data Science**: Empirical study of data analysis methods themselves. * **Common Task Framework (CTF)**: Key driver of ML progress; uses public **benchmarks**, shared data, and objective scoring to compare algorithms.
## 7. Core Objectives & Values * **Primary Goal**: Derive **actionable insights**, not just numbers. Requires asking the **right questions**. * **Statistical Reasoning Values**: Understanding the **application domain**, appreciating the **small** (details matter), quest for **significance**, hunger for **exploration**. * **Future Direction**: Evolution towards **evidence-based methodology** via **Science about Data Science**, using meta-analysis of computational research to improve methods.
# Lecture 2: Data Understanding & Profiling
## 2.1 What is Data? > A **datum** is a single measurement of something on a scale understandable to both recorder and reader. **Example**: Using the **Titanic dataset** (891 rows, 12 columns) to predict passenger survival based on personal characteristics (age, ticket class, gender). This is a **classification** task.
```
# Lecture 1: Introduction to Cloud Computing (Part 1)
## Goals
Understand concepts of Cloud Computing
## Overview
### Technology landscape
> **Cloud computing** = on-demand delivery of **compute, storage, networking** over the internet with **pay-as-you-go pricing** and **no upfront capital expenditure**.

**Example**: Netflix runs on AWS – owns no data centres, scales to 282 million subscribers globally.
### Distributed computing evolution
> Evolution of distributed computing paradigms:

| Era    | Paradigm                     | Key Technologies                                  |
| ------ | ---------------------------- | ------------------------------------------------- |
| First  | Linked machines together     | Internet, TCP/IP                                  |
| Second | Linked documents together    | WWW, HTTP, HTML, XML                              |
| Third  | Linked applications together | Web services, SOAP, WSDL, REST                    |
| Now    | Linking everything together  | **Grid** (decentralised), **Cloud** (centralised) |

> **Cloud Computing** = "the next natural step in the evolution of on-demand information technology services" – requires a **paradigm shift** to enable on-demand services.
### The Law of Accelerating Returns
> **Ray Kurzweil's Law** (1999, *The Age of Spiritual Machines*): Evolutionary processes apply **positive feedback** – better methods from one stage enable the next stage. Result: **rate of progress increases exponentially over time**.

**Key principles**:
- Best of one generation used to create the next
- More important results achieved in **less time**
- Greater resources deployed as process becomes more effective
- **Second-level exponential growth** (rate of exponential growth itself grows exponentially)

**Example**: Moore's Law (transistors doubling every 2 years) → El Capitan supercomputer: **1.742 exaflops/s**, 11 million cores (2024).
### Examples of current scales
**Exponential growth trends**:

| Technology      | Doubling Period | 1986 → 2000 → Today                               |
| --------------- | --------------- | ------------------------------------------------- |
| Computer speed  | 18 months       | 64Kbs → 2.5Gbps → Terabits                        |
| Network speed   | 9 months        | 64Kbs → 2.5Gbps → 1 Petabit/s (CRS-X)             |
| Storage density | 12 months       | 0.5 PB (2000) → Exabytes → Zetta era (10²¹ bytes) |
**Current data scales (exam-relevant figures)**:

| Company  | Data Scale                                       |
| -------- | ------------------------------------------------ |
| Facebook | 300 PB user data + 600 TB/day processing         |
| Google   | 8.5 billion searches/day, 15+ exabytes stored    |
| YouTube  | 1 billion hours videos watched/day               |
| TikTok   | 0.75 billion users in China                      |
| By 2025  | 400 exabytes data generated **per day** globally |
### Towards a definition of cloud computing
> **NIST Definition** (National Institute of Standards and Technology): *Cloud computing is a model for enabling **ubiquitous, convenient, on-demand network access** to a **shared pool of configurable computing resources** (networks, servers, storage, applications, services) that can be **rapidly provisioned and released** with **minimal management effort** or service provider interaction.*

**Five essential characteristics (memorise for exam)**:

| Characteristic             | Description                                                                            |
| -------------------------- | -------------------------------------------------------------------------------------- |
| **On-demand self-service** | Consumer provisions capabilities **automatically** without human interaction           |
| **Broad network access**   | Available over network via **standard mechanisms** (heterogeneous clients)             |
| **Resource pooling**       | Provider's resources **pooled** to serve multiple consumers; **location independence** |
| **Rapid elasticity**       | Capabilities appear **unlimited**; can be appropriated in any quantity at any time     |
| **Measured service**       | Automatic **control and optimisation** via metering at appropriate abstraction level   |

> **The Cloud Metaphor**: Application → Workstation/Mobile Access → The Cloud (Supercomputer, PC-Cluster, Data-storage, Sensors) → Internet/Networks
### Conceptual cloud architecture
**Layered architecture** (from bottom to top):
1. **Physical infrastructure** (servers, storage, network)
2. **Virtualisation layer** (hypervisors, VMs)
3. **Infrastructure as a Service (IaaS)** – compute, storage, networking
4. **Platform as a Service (PaaS)** – development frameworks, databases
5. **Software as a Service (SaaS)** – applications

**NIST Cloud Computing Reference Architecture actors**:

| Actor              | Role                                                                         |
| ------------------ | ---------------------------------------------------------------------------- |
| **Cloud Consumer** | Uses services from Cloud Provider                                            |
| **Cloud Provider** | Makes services available                                                     |
| **Cloud Auditor**  | Independent assessment of security, performance, operations                  |
| **Cloud Broker**   | Manages use, performance, delivery; negotiates between Provider and Consumer |
| **Cloud Carrier**  | Provides connectivity and transport                                          |

**What consumers want**: Meet **Quality of Service**, minimise expenses
**What providers want**: Attract customers, **maximise profit**
### Conclusion
- Clouds built on: **SOA**, **VMs**, **Web 2.0/3.0** technologies
- Many business and consumer applications enabled
- **Cloud is NOT a silver bullet** – some applications may not be suitable to run on cloud
- Enables **opex over capex** (operational expenditure vs capital expenditure)
## Quick Reference for This Lecture

| Concept                         | Key Point                                                        |
| ------------------------------- | ---------------------------------------------------------------- |
| **NIST 5 characteristics**      | On-demand, broad access, pooling, elasticity, measured service   |
| **Moore's Law**                 | Transistors double every 2 years                                 |
| **Law of Accelerating Returns** | Kurzweil – exponential progress feeds itself                     |
| **Cloud evolution**             | Machines → Documents → Applications → Everything                 |
| **Utility computing vision**    | Leonard Kleinrock (1969) – "computer utilities like electricity" |
| **El Capitan**                  | 1.742 exaflops/s (2024 fastest supercomputer)                    |

**Exam trap (2024 Q1a-e)**: Learn which NIST characteristic matches which description:
- "consumer can unilaterally provision... without human interaction" = **On-demand self-service**
- "capabilities appear unlimited... any quantity any time" = **Rapid elasticity**
- "automatic control and optimisation by metering" = **Measured service**
- "available over network via standard mechanisms" = **Broad network access**
- "location independence, multi-tenant" = **Resource pooling**
# Lecture 2: Introduction to Cloud Computing (Part 2)
## Goals
Understand concepts of Cloud Computing
## Taxonomy of Cloud Services
> **Cloud Service Stack** comprises three layers; services can be exposed at any layer, with lower layers hidden from end user.
### Layer 1: Infrastructure as a Service (IaaS)
> **IaaS** = pay-as-you-go IT infrastructure by renting **servers, VMs, storage, networks, OS** from a cloud provider.

**Example**: Amazon EC2 – provision virtual machines with specified CPU, RAM, storage.
### Layer 2: Platform as a Service (PaaS)
> **PaaS** = environment for **building, testing, and deploying** software applications without managing underlying infrastructure.

**Example**: Heroku, Google App Engine – deploy code, platform handles scaling, OS updates, load balancing.
### Layer 3: Software as a Service (SaaS)
> **SaaS** = users connect to and use cloud-based apps over the internet; alternative to locally run applications.

**Example**: Google Apps, Microsoft Office 365, Gmail, calendars.
### Shared Responsibility Model
> Security and management responsibilities are **shared** between cloud provider and consumer. Provider responsible for **security OF the cloud** (physical hardware, hypervisor, network). Consumer responsible for **security IN the cloud** (data, OS, applications, access control).

| Layer                                  | Responsible Party                          |
| -------------------------------------- | ------------------------------------------ |
| Physical hardware, network, hypervisor | **Cloud Provider**                         |
| OS, middleware, runtime                | **Consumer** (IaaS) / Provider (PaaS/SaaS) |
| Data, applications, access control     | **Consumer**                               |
## Types of Clouds
### Public Cloud
> Owned by cloud services/hosting provider. Provides resources to **multiple organisations and users**. Accessed via secure network (typically internet).

**Examples**: AWS, Microsoft Azure, Google Cloud Platform.
### Private Cloud
> Organisation creates cloud environment in **own datacenter**. Responsible for operating services. **No access** to users outside organisation.

**Use cases**: Government, finance, healthcare (data sovereignty, compliance).
### Hybrid Cloud
> **Combines public and private clouds** to allow applications to run in most appropriate location.

**Example**: Sensitive data on private cloud, compute-intensive batch processing burst to public cloud.
### Cloud Model Comparison

| Feature         | Public                | Private                | Hybrid                 |
| --------------- | --------------------- | ---------------------- | ---------------------- |
| **Ownership**   | Cloud provider        | Organisation           | Both                   |
| **Control**     | Limited               | Full                   | Partial                |
| **Cost**        | Pay-as-you-go         | Capital + operational  | Mixed                  |
| **Scalability** | Infinite              | Limited (own capacity) | Burst to public        |
| **Security**    | Provider-managed      | Self-managed           | Sensitive data on-prem |
| **Compliance**  | Shared responsibility | Full control           | Flexible               |
### Other cloud types
- **Community cloud**: Shared by several organisations with common concerns (e.g., government agencies)
- **Multi-cloud**: Using multiple public cloud providers (avoids vendor lock-in)
- **Distributed cloud**: Public cloud services running at edge locations
## Cloud Use Cases
### End-user to cloud
> Applications running on cloud and accessed directly by end users.

**Examples**: Gmail, Netflix, Spotify, TikTok.
### Enterprise to cloud
> Enterprise using cloud for its **internal processes**.

**Example**: Company using Salesforce for CRM, Workday for HR.
### Enterprise to cloud to end-user
> Enterprise delivers data and services to end users via cloud.

**Examples**: Banking apps, airline booking systems.
### Enterprise to cloud to enterprise
> Two enterprises use same cloud; focus on **interoperability** between applications.

**Example**: Supply chain management – supplier and retailer share cloud-hosted inventory system.
### Hybrid cloud (federated/broker)
> Delivered by **federated cloud provider** combining its resources with other providers, or via a **broker**.

**Example**: Cloud broker provides unified interface to AWS, Azure, and GCP.
## Virtualisation
> **Virtualisation** = emulating in software a specialised physical resource (machine, network function) into a host computer. Enables reproducing same capabilities/functionalities from client's perspective – **implemented in software**.
### Historical context
- Heated topic in **1970s** following IBM's introduction of **VMM (Virtual Machine Monitor)** in 1960s
- OS were sold bundled with hardware – to get new OS, had to buy new machine
- **Virtualisation made it possible to run new OS on older hardware** via VMs
### Virtualisation layer
> The **virtualisation layer** "hides" and "homogenises" hardware resources, allowing **one or more operating systems** to run simultaneously on same physical machine.
### Cyber/Virtual vs Physical Infrastructures

| Infrastructure                   | Description                                                        |
| -------------------------------- | ------------------------------------------------------------------ |
| **Physical Infrastructure**      | Actual physical servers, racks, switches, cabling                  |
| **Virtualisation Layer**         | Creates the cyberinfrastructure                                    |
| **Cyber/Virtual Infrastructure** | VMs, virtual networks, load balancers, firewalls, managed services |
### Virtualised Infrastructure benefits
- **Consolidation** of server systems
- **Reduced costs**
- **Reduced complexity**
- **Simplified administration**
- **Pay-per-usage** model
## Conclusion
### Classical Computing vs Cloud Computing

| Aspect          | Classical Computing                                | Cloud Computing                                    |
| --------------- | -------------------------------------------------- | -------------------------------------------------- |
| **Model**       | Buy & Own                                          | **Subscribe & Use**                                |
| **Hardware**    | Meet peak needs (over-provisioned)                 | Elastic – scale as needed                          |
| **Effort**      | Install, configure, test, verify, evaluate, manage | Provider manages                                   |
| **Time to use** | Months                                             | Minutes                                            |
| **Cost**        | Capital expenditure ($$$)                          | Operational expenditure ($ – pay for what you use) |

> **Revolution in IT**: Shift from **capital expenditure (capex)** to **operational expenditure (opex)**.
## Quick Reference for This Lecture

| Concept                 | Key Point                                                   |
| ----------------------- | ----------------------------------------------------------- |
| **IaaS**                | Rent VMs, storage, networks – e.g., EC2                     |
| **PaaS**                | Deploy code, platform manages infrastructure – e.g., Heroku |
| **SaaS**                | Use applications over internet – e.g., Gmail                |
| **Public cloud**        | Multi-tenant, internet-accessible                           |
| **Private cloud**       | Single organisation, own datacenter                         |
| **Hybrid cloud**        | Public + private                                            |
| **Virtualisation**      | Software emulation of hardware                              |
| **VMM/Hypervisor**      | Manages VMs on physical host                                |
| **Cyberinfrastructure** | Virtualised resources (VMs, virtual networks)               |

**Exam trap (2024 Q1)**: Know which scenario matches which cloud type:
- "Company's usage peaks in summer, exceeding internal capacity" → **Hybrid cloud** (combine local + cloud) – 2025 Q1a answer **D**
- "Organisation creates cloud in own datacenter, no external access" → **Private cloud**
- "Resources shared across multiple organisations, internet-accessible" → **Public cloud**

**Exam trap (2025 Q1)**: Paravirtualisation, hardware-assisted virtualisation questions refer to **virtualisation types** (covered in later lecture).
# Lecture 3: Cloud Platform Architecture over Virtualised Datacenters – Part I: Compute and Storage
**Goals:** Understand concepts of cloud platform architectures
### Overview
- Hardware in Cloud computing: Benefits
- Data centre design
- Warehouse scale computing
- Cloud Architecture: System Level
- Compute
- Storage
- Aspect of heterogeneity
- Conclusion
## Hardware in Cloud computing: Benefits
> **Three hardware benefits that enabled cloud computing**:

1. **Illusion of infinite resources** – on-demand availability eliminates need for users to plan far ahead for resource provisioning.
2. **Elimination of up-front commitment** – users can start small and increase hardware resources when needed.
3. **Pay-as-you-go** – costs on short-term basis (e.g., processors by the hour, storage by the day), rewarding resource conservation.

**Example**: A startup launches a web app with 1 server. When traffic spikes, they automatically scale to 100 servers for 2 hours, then back to 1. They pay only for the 2 hours of extra capacity.
## Data centre design
> **Cluster Computing** = many similar machines, closely interconnected, specialised hardware, owned and managed by a single organisation.

**Clouds built on massive datacenters**:
- Size ranges from **edge facilities** to **megascale** (100,000 – 1 million servers)
- Power consumption: one server may use up to **500W**; one rack (42 servers) = **21kW** (3× average UK household)
> **Centralisation** = consolidate different machines and software into one location.

**Economies of scale** (approximate cost savings comparing 1,000 servers vs 400,000 servers):

| Cost Component    | Small Center (1K servers) | Large Center (400K servers) |
| ----------------- | ------------------------- | --------------------------- |
| Power             | ~$0.30                    | ~$0.15                      |
| Cooling           | ~$0.30                    | ~$0.10                      |
| Network bandwidth | ~$0.20                    | ~$0.05                      |
| Administration    | ~$0.30                    | ~$0.03                      |

> **This data center is 11.5 times the size of a football field** (exam memorable figure).
## Warehouse scale computing
> **Warehouse Scale Computing (WSC)** provides Internet services: search, social networking, online maps, video sharing, online shopping, email, cloud computing.
### WSC vs HPC Clusters – Key Differences

| Aspect                 | HPC Clusters                                 | WSC                                              |
| ---------------------- | -------------------------------------------- | ------------------------------------------------ |
| **Processors/Network** | Higher performance                           | Cost-effective                                   |
| **Parallelism type**   | Thread-level (split heavy task across nodes) | Request-level (handle many independent requests) |
| **Workload**           | Batch (simulations, modelling)               | Interactive (search, social media) + Batch       |
| **Design priority**    | Peak performance                             | Cost-performance + energy efficiency             |
### Design Considerations for WSC

1. **Cost-performance** – small savings add up at scale
2. **Energy efficiency** – affects power distribution and cooling
3. **Dependability via redundancy** – hardware fails; design for it
4. **Network I/O** – critical bottleneck
5. **Support for**:
   - **Interactive workloads** – real-time end-user applications
   - **Batch processing workloads** – large-scale background tasks
6. **Operational costs count** – power consumption is primary constraint
7. **Scale** – opportunities and problems
### Workload and System Utilisation
> **The dilemma**: A datacenter is always on, but not always in use. Peak load can exceed average load by **10×**. Provision for peak = wasted resources. Provision for less = poor service, lost users.

**Server utilisation can be as low as 5–20%** – significant waste, but necessary to handle spikes.
## Cloud Architecture: System Level
### Architecture of a Small Server Cluster (~1000 servers)
- Interconnected by Ethernet switch
- Housed in warehouse or container environment
- **Typical elements**: 1U servers, racks with Ethernet switches, cluster-level Ethernet switch/router
### Racking & Networking Hierarchy

| Level          | Scale          | Description                                                          |
| -------------- | -------------- | -------------------------------------------------------------------- |
| **System**     | 1 server       | Individual compute node                                              |
| **Rack**       | ~40 systems    | Installed and networked together                                     |
| **Container**  | ~1,000 systems | No packaging to remove, no floor space, weatherproof, easy transport |
| **Datacenter** | 100K+ systems  | Construction takes **24+ months**; requires regulatory approval      |
## Compute
### Heterogeneity Aspects
> **Heterogeneity** is one of the most profound and challenging characteristics of parallel environments.

| Level           | Description                                                                                                                                    |
| --------------- | ---------------------------------------------------------------------------------------------------------------------------------------------- |
| **Macro level** | Networks of distributed computers (clouds) with diverse node architectures (single/multi-core), interconnected with heterogeneous networks     |
| **Micro level** | Deeper memory hierarchies (main, cache, disk, tertiary storage) + accelerator architectures (fixed, programmable: GPUs, reconfigurable: FPGAs) |
| **Software**    | OS, middleware, tools – also heterogeneous                                                                                                     |
### Processor Types

| Type                                                      | Description                                                      | Characteristics                                                         |
| --------------------------------------------------------- | ---------------------------------------------------------------- | ----------------------------------------------------------------------- |
| **General Purpose Microprocessor (GPP)**                  | PCs, workstations, laptops                                       | Execute multiple applications/tasks; flexible, portable                 |
| **Microcontroller**                                       | Embedded systems                                                 | On-chip CPU, fixed RAM/ROM/I/O; low cost, low power, small              |
| **Digital Signal Processor (DSP)**                        | Real-time mathematical computations                              | Multiply-accumulate units; programmable                                 |
| **ASIP** (Application Specific Instruction Set Processor) | Hardware + instruction set designed together for one application | Better performance, lower cost, lower power than GPP                    |
| **ASIC** (Application Specific Integrated Circuit)        | Algorithm completely implemented in hardware                     | Market-specific; rigid, hard to build; e.g., Tesla D1 chip (362 TFLOPS) |
### Accelerators / Coprocessors
> **Accelerators** perform functions more efficiently than CPU – **faster** and/or **lower energy**.
#### GPU (Graphics Processing Unit)
- Choice for **HPC**, **Machine Learning**, **Deep Learning**, **AI**
- **SIMT** (Single Instruction Multiple Thread) model – CUDA/OpenCL programming
- Efficient for **data parallel applications** (thousands of ALUs)
- Architecture: multiple Processor Clusters → Streaming Multiprocessors → dedicated L1/L2 cache → global GDDR5/GDDR6 memory
- **GPU is throughput-optimised** (more cores, parallel processing)
- **CPU is latency-optimised** (significant cache memory)

|            | CPU                 | GPU                       |
| ---------- | ------------------- | ------------------------- |
| **Goal**   | Low latency         | High throughput           |
| **Cache**  | Large L1-L3 caches  | Smaller caches            |
| **Cores**  | Few (8-64), complex | Many (thousands), simpler |
| **Memory** | DDR4                | GDDR5/6 (faster)          |
#### FPGA (Field Programmable Gate Array)
- Array of logic gates that can be **hardware-programmed** (VHDL, Verilog)
- Part of application implemented entirely in hardware
- **Flexibility**: between GPP (fully flexible) and ASIC (fixed)
- **Performance/Efficiency**: better than GPP, worse than ASIC
- **Programming difficulty**: harder than GPP/GPU

**Exam question (2024 Q1f)**: *Application requiring data acquisition and pre-processing with freedom to describe underlying hardware* → **FPGA** is appropriate because you can implement custom filtering pipeline in hardware.
#### TPU (Tensor Processing Unit) – Google
- Custom ASIC for **machine learning** (TensorFlow, PyTorch)
- Up to **100 petaflops** performance
- Powers Google Translate, Photos, Search, Gmail
- Ideal for **matrix operations** (neural networks)
- **Exam trap (2025 Q1e)**: Key advantage = **specifically designed for high-performance machine learning computations**
### Comparison Table: CPU, GPU, FPGA, ASIC

| Feature              | CPU                       | GPU                  | FPGA                | ASIC            |
| -------------------- | ------------------------- | -------------------- | ------------------- | --------------- |
| **Market**           | General                   | General + HPC        | Niche               | Specific        |
| **Programmability**  | Easy (C, Python)          | Moderate (CUDA)      | Hard (VHDL/Verilog) | None (fixed)    |
| **Flexibility**      | High                      | Medium               | Medium              | Low (rigid)     |
| **Power efficiency** | Low                       | Medium               | High                | Highest         |
| **Development cost** | Low                       | Medium               | High                | Very high       |
| **Best for**         | Sequential, complex logic | Parallel, matrix ops | Custom pipelines    | Mass production |
## Storage
### Storage Options in Datacenters

| Type                               | Description                                                                                                           |
| ---------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| **Storage Area Network (SAN)**     | Local dedicated network using Fibre Channel to connect storage devices                                                |
| **Network Attached Storage (NAS)** | Dedicated hardware device on LAN (Ethernet); operates on data files like shared folder                                |
| **Local disks**                    | WSCs generally rely on local disks in servers; Google File System (GFS) uses local disks with **at least 3 replicas** |

> **WSC storage approach**: Use **local disks** + **replication** (e.g., GFS maintains 3+ replicas) rather than centralised SAN/NAS.
## Aspect of heterogeneity
>Heterogeneity exists at **macro level** (networked computers with diverse architectures) and **micro level** (memory hierarchies, accelerators). It is a **profound challenge** for parallel environments but also enables **specialised acceleration**.

**Example**: A cloud workload may use:
- **CPU** for control logic and sequential tasks
- **GPU** for matrix multiplication (ML inference)
- **FPGA** for custom packet processing
- **TPU** for neural network training
## Conclusion
- Reviewed design issues for cloud datacenters at system level:
  - **Servers, racks, clusters**
  - **Storage** (local disks with replication vs SAN/NAS)
  - **Networks** (covered in Lecture 4)
- Heterogeneity and specialised hardware are becoming **increasingly important** (GPUs, TPUs, FPGAs, ASICs)
## Quick Reference for This Lecture

| Concept                     | Key Point                                                           |
| --------------------------- | ------------------------------------------------------------------- |
| **3 hardware benefits**     | Infinite resources (illusion), no upfront commitment, pay-as-you-go |
| **WSC vs HPC**              | Request-level vs thread-level parallelism                           |
| **Server utilisation**      | Can be as low as 5–20%                                              |
| **Datacenter construction** | 24+ months                                                          |
| **1 rack power**            | 42 servers × 500W = 21kW (3× average UK house)                      |
| **GPU programming**         | CUDA, OpenCL – SIMT model                                           |
| **TPU**                     | Google custom ASIC for ML (100 petaflops)                           |
| **FPGA**                    | Hardware-programmable (VHDL/Verilog)                                |
| **GFS replication**         | At least 3 replicas on local disks                                  |
**Exam traps**:
- **2024 Q1f**: FPGA for custom data acquisition/pre-processing
- **2025 Q1e**: TPU advantage = designed for ML computations
- **WSC vs HPC**: Don't confuse thread-level (HPC) with request-level (WSC) parallelism
# Lecture 4: Cloud Platform Architecture over Virtualised Datacenters – Part II: Networking
**Goals:** Understand concepts of cloud networking architectures
### Overview
- Cloud Architecture: System Level
- Data Centre Networks
- Architecture
- Ethernet
- Infiniband
- Software Defined Networks (SDN)
- Conclusion
## Data Centre Networks
### Load Balancer
> **Load balancer** performs application-layer routing:
> - Receives external client requests (e.g., "Search for Glastonbury 2025")
> - Directs workload within datacenter
> - Returns results to external client, **hiding datacenter internals**
### Network Architecture (Tiered)
```
External Clients
       │
       ▼
  Tier-1 Switches (core)
       │
       ▼
  Tier-2 Switches (aggregation)
       │
       ▼
Top of Rack (TOR) Switches
       │
       ▼
   Server Racks
```
> **Rich interconnection** between switches and racks provides:
> - Increased throughput (multiple routing paths)
> - Increased reliability via redundancy
### Ethernet Standards in Datacenters

| Speed                     | Status                   |
| ------------------------- | ------------------------ |
| 1GbE, 10GbE, 25GbE, 40GbE | Common                   |
| 100GbE, 200GE, 400GE      | Increasingly common      |
| 800GE, 1.6Tb/sec          | Emerging (DCI ecosystem) |

> **Trend**: Data center optics transitioning to **400GE rates**. Fiber optics dominates backbone, top-of-rack uplinks, inter-rack, and inter-datacenter traffic.
## InfiniBand
> **InfiniBand** is a high-performance, software-defined, hardware-accelerated network technology used in HPC and cloud datacenters.
### InfiniBand Speed Generations

| Generation | Speed    | Year context       |
| ---------- | -------- | ------------------ |
| SDR        | 8 Gbps   | Single Data Rate   |
| DDR        | 16 Gbps  | Double Data Rate   |
| QDR        | 32 Gbps  | Quad Data Rate     |
| FDR        | 56 Gbps  | Fourteen Data Rate |
| EDR        | 100 Gbps | Enhanced Data Rate |
| HDR        | 200 Gbps | High Dynamic Range |
| NDR        | 400 Gbps | Next Data Rate     |
| XDR        | 800 Gbps | eXtreme Data Rate  |

> **Projection**: 1.6 Tb/sec ports → 64 ports × 1.6 Tb/sec = **102.4 Tb/sec** switch throughput.
### In-Network Acceleration
> **Goal**: Shift computational tasks from CPUs/GPUs to network devices (switch ASIC, NIC, DPU) to improve efficiency and reduce latency.

| Technology                                             | Description                                                                                                     |
| ------------------------------------------------------ | --------------------------------------------------------------------------------------------------------------- |
| **PDA** (Programmable Datapath Accelerator)            | Specialised hardware (usually in NIC) programmable to process/filter/route data before it reaches CPU           |
| **RDMA** (Remote Direct Memory Access)                 | Transfer data directly between host memories **without involving CPU**                                          |
| **BlueField DPU** (NVIDIA)                             | Offloads, accelerates, isolates datacenter infrastructure tasks from CPU; can virtualise networking and storage |
| **SHARP** (Scalable Hierarchical Aggregation Protocol) | In-network computing inside InfiniBand switches; offloads MPI collective operations to switches                 |
| **SHIELD** (Self-Healing Interconnect Enhancement)     | Security feature of BlueField DPUs; improves fault recovery                                                     |
## Software Defined Networks (SDN)
> **SDN** = rethinking network architectures with **abstractions** – clear interfaces, **programmability**. Some functionality is **defined by software** (controlled by controlling software).
### Core Insight (Scott Shenker)
> Current networks are designed to **"master the complexity"** behind existing technologies, rather than **"extract simplicity"** from learned lessons. Abstractions play a big role in CS – shielding high-level software from low-level complexity.
### Separation of Planes

| Plane             | Function                                                   | Location in SDN                     |
| ----------------- | ---------------------------------------------------------- | ----------------------------------- |
| **Data plane**    | Packet forwarding (logic/tables for how to handle packets) | Remains in device (switch)          |
| **Control plane** | Decision making (algorithms that program the data plane)   | Moved to **centralised controller** |
**Traditional networks**: Control and data planes are coupled (each switch makes its own decisions)
**SDN networks**: Centralised controller makes decisions; switches just forward packets
### SDN Components

| Component                             | Function                                                                                                     |
| ------------------------------------- | ------------------------------------------------------------------------------------------------------------ |
| **SDN switches** (e.g., Open vSwitch) | Forward packets based on flow tables                                                                         |
| **Controller** (e.g., ONOS)           | Implements control plane; presents abstraction of network to applications; maintains **global network view** |
| **SDN applications**                  | Built on controller; implement routing, access control, load balancing, etc.                                 |
| **OpenFlow**                          | Network control protocol; enables controller to manage switches by separating control from data plane        |
### Flow Tables
> **Flow tables** reside on network devices; contain **flow entries** with **match fields** and **actions**.

**Operation**:
1. Device matches incoming packet against flow table
2. If match found → take action (forward, drop, send to controller)
3. If no match → drop or pass to controller

**Forwarding Actions**:

| Action            | Description                                           |
| ----------------- | ----------------------------------------------------- |
| **Physical Port** | Send out specific physical port                       |
| **CONTROLLER**    | Send to controller                                    |
| **ALL**           | Send to all ports                                     |
| **DROP**          | Discard packet                                        |
| **NORMAL**        | Standard L2/L3 forwarding                             |
| **MODIFY FIELD**  | Change header field (IP, MAC, VLAN) before forwarding |
## Conclusion
- **In-network computing and security** enable modern datacenters to handle complex requirements
- **Ethernet** is a trend in datacenters; **InfiniBand** offers software-defined, hardware-accelerated networking for HPC
- **SDN simplifies management** of complex datacenter networks
- SDN has **profound impact** on how communication networks are designed and implemented
## Comparison Table: Ethernet vs InfiniBand

| Feature             | Ethernet                 | InfiniBand                       |
| ------------------- | ------------------------ | -------------------------------- |
| **Primary use**     | General datacenters, LAN | HPC, supercomputers, AI clusters |
| **Speed (current)** | 1GbE – 400GE             | HDR (200Gbps), NDR (400Gbps)     |
| **Protocol**        | TCP/IP, UDP              | IB transport (RDMA native)       |
| **CPU involvement** | High (TCP/IP stack)      | Low (RDMA, hardware offload)     |
| **Programmability** | SDN (OpenFlow)           | SHARP, PDA, DPU                  |
| **Cost**            | Lower                    | Higher                           |
| **Latency**         | Higher                   | Very low                         |
## Quick Reference for This Lecture

| Concept               | Key Point                                                              |
| --------------------- | ---------------------------------------------------------------------- |
| **Load balancer**     | Application-layer routing; hides datacenter internals                  |
| **TOR switch**        | Top of Rack – connects servers to network                              |
| **InfiniBand speeds** | SDR → DDR → QDR → FDR → EDR → HDR → NDR → XDR                          |
| **NDR**               | 400 Gb/sec (NVIDIA Quantum2)                                           |
| **XDR projection**    | 800 Gb/sec; 1.6 Tb/sec possible                                        |
| **RDMA**              | Direct memory-to-memory transfer without CPU                           |
| **DPU**               | Data Processing Unit (e.g., BlueField) – offloads infrastructure tasks |
| **SDN**               | Separates control plane (centralised) from data plane (in switches)    |
| **OpenFlow**          | Protocol for controller to manage switches                             |
| **Flow table**        | Match fields + actions on switch                                       |

**Exam traps**:
- SDN = **control plane centralised**, data plane distributed
- OpenFlow = **protocol**, not the controller itself
- InfiniBand speeds: remember **HDR=200G, NDR=400G, XDR=800G**
- SHARP = in-switch collective operations; SHIELD = security/fault recovery
# Lecture 5: Virtualisation – Part I
**Goals:** Understand concepts of virtualisation
### Overview
- Definitions
- Implementation levels of virtualisation
- Machine Level Virtualisation
- Hypervisor-based Virtualisation
  - Full virtualisation
  - Para-virtualisation
  - Hardware-assisted virtualisation
- Operating System Level Virtualisation
- Examples
- Conclusion
## Definitions
> **Virtual Machine (VM)** = a representation of a real machine using software that provides an operating environment which can run or host a **guest operating system**.
> **Guest Operating System** = an operating system running in a virtual machine environment that would otherwise run directly on a separate physical system.
> **Virtualization Layer** = middleware between underlying hardware and virtual machines.
### Virtual Machine Isolation and Encapsulation

| Benefit                   | Description                                                                       |
| ------------------------- | --------------------------------------------------------------------------------- |
| **Secure multiplexing**   | Run multiple VMs on single physical host                                          |
| **Strong guarantees**     | Processor hardware isolates VMs                                                   |
| **Performance isolation** | Partition system resources                                                        |
| **Snapshots and clones**  | Capture VM state on the fly; restore to point-in-time                             |
| **Encapsulation**         | VM can be saved as a file (image) containing OS, apps, data, memory, device state |
### Virtual Machine Monitor (Hypervisor)
**Type 1 (Bare-metal)** – runs directly on hardware:
- VMware ESXi, Xen, KVM, Microsoft Hyper-V

**Type 2 (Hosted)** – runs on top of host OS:
- VMware Workstation, VirtualBox, Microsoft Virtual PC
### Virtual Infrastructure Manager (VIM)
> **VIM** facilitates provisioning of virtual resources on behalf of end users.

**Main functions**:
- Virtual resource scheduling
- Image preparation, distribution, instantiation
- Migration, termination
- Virtual and physical resource monitoring
- User access control

**Examples**:
- **OpenStack** → Large pools, complex
- **OpenNebula** → Simple and lightweight
### Typical Cloud Architecture Flow
1. VIM provisions virtual resources through Hypervisor from physical resources
2. VIM makes resources available to Distributed Application
3. Distributed Application deployed into Virtual Machine Cluster
## Implementation Levels of Virtualisation

| Level                                                             | What is intercepted                 | Description                                            |
| ----------------------------------------------------------------- | ----------------------------------- | ------------------------------------------------------ |
| **Application virtualisation**                                    | Application-OS interactions         | App believes it runs alone or in different environment |
| **Library (user-level API) virtualisation**                       | API calls (system calls, libraries) | Redirects or modifies behaviour (hooks, wrappers)      |
| **Operating System / Containers virtualisation**                  | OS kernel-resource interactions     | Each container gets illusion of its own OS environment |
| **Hardware Abstraction Layer (HAL) / Hypervisors**                | Hardware access (CPU, memory, I/O)  | Presents virtual hardware to each VM                   |
| **Instruction Set Architecture (ISA) virtualisation (emulation)** | CPU instructions                    | Translates one instruction set to another              |
## Machine Level Virtualisation
### Two Approaches

| Approach       | Type   | Description                                          | Examples                       |
| -------------- | ------ | ---------------------------------------------------- | ------------------------------ |
| **Hosted**     | Type 2 | Runs over host OS; second layer over hardware        | VMware Workstation, VirtualBox |
| **Bare metal** | Type 1 | Sits directly on hardware; first layer over hardware | VMware ESXi, Xen, KVM, Hyper-V |

**Exam tip**: Type 1 = **bare metal** (no host OS). Type 2 = **hosted** (has host OS).
## x86 Privileged Architecture (Before Virtualisation)
- x86 has **4 privilege levels**: **Ring 0, 1, 2, 3**
- Operating System needs **Ring 0** (most privileged) for direct hardware access
- User applications run in **Ring 3** (least privileged)
- Non-privileged instructions execute directly on CPU
- **System calls** request OS to perform privileged operations safely

**Problem for virtualisation**: Some instructions were **sensitive** (affect system state) but **not privileged** (could execute outside Ring 0 without trapping). Called **non-virtualisable instructions**.
## Hypervisor-based Virtualisation
> Hypervisor presents virtual operating platform to guest systems; monitors and manages execution.
### Three Categories

| Category                | Guest OS Modification? | How it works                                                      | Performance                 | Examples                         |
| ----------------------- | ---------------------- | ----------------------------------------------------------------- | --------------------------- | -------------------------------- |
| **Full virtualisation** | **No** (unmodified OS) | Binary translation of critical instructions                       | Slower (emulation overhead) | VMware, Microsoft Virtual Server |
| **Para-virtualisation** | **Yes** (OS modified)  | Guest uses **hypercalls** to VMM; no binary translation           | Better than full            | Xen, KVM, VMware ESX             |
| **Hardware-assisted**   | **No** (unmodified OS) | CPU provides VT-x/AMD-V; hardware handles privileged instructions | Best (near-native)          | KVM, VMware on modern CPUs       |
### 1. Full Virtualisation
> Unmodified guest OS runs over hypervisor. Hypervisor **emulates underlying hardware**. Critical instructions emulated via **binary translation**.

**Process**:
1. VMM runs guest OS in less-privileged mode (Ring 1)
2. Guest executes privileged instruction → CPU traps
3. CPU transfers control to VMM
4. VMM emulates instruction, returns control

**The x86 problem (non-virtualisable instructions)**:
- Some sensitive instructions execute silently without trapping
- VMM cannot intercept them through normal hardware mechanisms
- **Solution**: Binary translation at runtime – rewrite instructions to reliably transfer control to VMM
### 2. Para-virtualisation
> Part of virtualisation work shifted from VMM to **guest OS**. Guest OS **cooperates** with VMM.

**Key characteristics**:
- Guest OS **must be modified** (ported/adapted)
- Sensitive/privileged instructions replaced with explicit **hypercalls** to VMM
- No runtime binary translation → **reduced overhead**
- VMM presents virtual interface that need not match underlying hardware

**Disadvantages**:
- Reduced compatibility and portability (modified OS)
- High maintenance cost (deep OS modifications)
### 3. Hardware-Assisted Virtualisation
> CPU vendors add dedicated virtualisation features (AMD-V, Intel VT-x).

**How it works**:
- New CPU execution mode (VMX non-root for guests, VMX root for hypervisor)
- Privileged/sensitive operations run natively in VMX non-root
- Others configured to trigger **VM-exit** (hardware trap) to hypervisor
- **No binary translation, no paravirtualisation**

**Overhead comparison (highest to lowest)**:
1. **Full virtualisation** – binary translation + emulation
2. **Para-virtualisation** – hypercalls, but still VMM overhead
3. **Hardware-assisted** – lowest overhead (near-native)
## Operating System Level Virtualisation (Containers)
> **OS-level virtualisation** = single OS kernel shared across multiple isolated user-space instances (containers). Each container gets illusion of its own OS environment.

**Examples**: Docker, LXC, OpenVZ

**Comparison (preview – detailed in later lecture)**:

| Feature       | VMs (Type 1/2)  | Containers         |
| ------------- | --------------- | ------------------ |
| **Isolation** | Full OS-level   | Process-level      |
| **Guest OS**  | Each VM has own | Shared host kernel |
| **Boot time** | Minutes         | Milliseconds       |
| **Size**      | GBs             | MBs                |
| **Overhead**  | Higher          | Near-zero          |
## Examples

| Hypervisor         | Type                         | Virtualisation method                             |
| ------------------ | ---------------------------- | ------------------------------------------------- |
| VMware Workstation | Type 2                       | Full virtualisation                               |
| VirtualBox         | Type 2                       | Full virtualisation                               |
| VMware ESXi        | Type 1                       | Full + hardware-assisted                          |
| Xen                | Type 1                       | Para-virtualisation (or HVM with hardware assist) |
| KVM                | Type 1 (Linux kernel module) | Hardware-assisted                                 |
| Microsoft Hyper-V  | Type 1                       | Hardware-assisted                                 |
## Conclusion
- Virtualisation enables **secure multiplexing**, **performance isolation**, **snapshots**, **encapsulation**
- Three hypervisor-based techniques: **full**, **para**, **hardware-assisted**
- Hardware-assisted (VT-x/AMD-V) offers **lowest overhead**
- Containers (OS-level) offer **lightweight alternative** (Lecture 6)
- VIM (OpenStack, OpenNebula) manages virtual resources at scale
## Comparison Table: Virtualisation Techniques

| Feature                   | Full   | Para   | Hardware-assisted |
| ------------------------- | ------ | ------ | ----------------- |
| **Guest OS modification** | No     | Yes    | No                |
| **Binary translation**    | Yes    | No     | No                |
| **Hypercalls**            | No     | Yes    | No                |
| **CPU support required**  | No     | No     | Yes (VT-x/AMD-V)  |
| **Performance**           | Lowest | Medium | Highest           |
| **Compatibility**         | High   | Low    | High              |
## Quick Reference for This Lecture

| Term                               | Definition                                               |
| ---------------------------------- | -------------------------------------------------------- |
| **Hypervisor**                     | Software that manages VMs                                |
| **Type 1**                         | Bare-metal (runs directly on hardware)                   |
| **Type 2**                         | Hosted (runs on host OS)                                 |
| **VIM**                            | Virtual Infrastructure Manager (OpenStack, OpenNebula)   |
| **Full virtualisation**            | Unmodified guest, binary translation                     |
| **Para-virtualisation**            | Modified guest, hypercalls                               |
| **Hardware-assisted**              | VT-x/AMD-V, near-native performance                      |
| **Ring 0**                         | Most privileged x86 level (OS)                           |
| **Ring 3**                         | Least privileged (user apps)                             |
| **Non-virtualisable instructions** | Sensitive but not privileged; require binary translation |

**Exam traps**:
- **2025 Q1b**: Paravirtualisation benefit = **improves performance by reducing overhead** (C)
- **2025 Q1c**: Hardware-assisted virtualisation = **CPU provides support** (B) + **hypervisor emulates hardware** (A) – select two
- **2025 Q1d**: VM communication = **private IP + virtual private bridge** (C)
# Lecture 6: Virtualisation Part II – Containers
**Goals:** Understand concepts of virtualisation
### Overview
- Virtual Machines: Recap
- Container technologies
- VMs vs Containers
- Example: Docker
- The case for Unikernels
- Conclusion
## Virtual Machines: Recap
> **Virtualisation** = a level of indirection between hardware and software. **Virtual Machine (VM) abstraction** runs all software written for physical machine.

**Challenge addressed**: Infrastructure heterogeneity, hidden complexity from apps, manage and coordinate micro-services reliably, scale and move services quickly without downtime.

**Analogy (cargo transport)** : Historically, cargo handling faced similar challenges – different container sizes, shapes, handling requirements. Solution = **intermodal shipping container** – standardised, stackable, transferable across ships, trains, trucks.
> **Containers are the "shipping containers" of software** – standardised units that package code + dependencies, run anywhere.
## Container Technologies
> **Container** virtualises the **OS rather than the hardware**. Uses a single kernel to run multiple isolated OS instances.

**Key characteristics**:
- Each instance runs in **completely isolated environment**
- Fewer components to patch, less attack surface at application level
- **However**: rely heavily on host kernel – kernel vulnerabilities are critical
- Offers **greater efficiency and performance** than conventional hypervisor
### Container History Timeline

| Year | Technology                 | Significance                                                      |
| ---- | -------------------------- | ----------------------------------------------------------------- |
| 1979 | **chroot** (Unix)          | First isolation mechanism (change root directory)                 |
| 1998 | **FreeBSD jails**          | First practical implementation                                    |
| 2005 | Solaris Zones, OpenVZ      | Resource control, stronger isolation                              |
| 2008 | **LXC** (Linux Containers) | First modern Linux container tech – combines cgroups + namespaces |
| 2013 | **Docker**                 | Made containers accessible ("what ChatGPT did for LLMs")          |
### Containers vs Hypervisors

|                             | Type 1 Hypervisor | Type 2 Hypervisor        | Containers                  |
| --------------------------- | ----------------- | ------------------------ | --------------------------- |
| **Location of abstraction** | Below host OS     | Within host OS           | Above OS kernel             |
| **What is abstracted**      | Hardware          | Hardware                 | OS kernel                   |
| **Isolation mechanism**     | Hardware + VMM    | Hardware + VMM + host OS | Kernel namespaces + cgroups |
| **Performance**             | Good              | Moderate                 | **Best**                    |
**Key insight**: chroot + Linux kernel features (cgroups for resource limits, namespaces for isolation) = container foundation.
## VMs vs Containers – Detailed Comparison

| Feature               | Virtual Machines                              | Containers                                 |
| --------------------- | --------------------------------------------- | ------------------------------------------ |
| **Isolation level**   | Full OS-level (strong)                        | Process-level (weaker)                     |
| **Guest OS**          | Each VM has own full OS                       | Share host kernel                          |
| **Boot time**         | Minutes                                       | **Seconds or milliseconds**                |
| **Size**              | Gigabytes (full OS image)                     | **Megabytes** (app + dependencies)         |
| **Portability**       | Constrained to hypervisor, hardware-emulation | **Run anywhere** with compatible kernel    |
| **Management cost**   | High (each VM requires full OS management)    | Low (single kernel to manage)              |
| **Resource overhead** | High                                          | **Near-zero**                              |
| **Use cases**         | Legacy apps, multi-OS, strong isolation       | DevOps, batch computing, **microservices** |
> **Clear advantage for containers in**: DevOps, batch computing, microservices.
## Microservices Architecture
> **Microservices** = architectural pattern where an application is decomposed into **small, autonomous services** that work together.

**Characteristics**:
- Unit of distribution = **single service granularity**
- **Loosely coupled** components
- **API-accessible** (via chosen protocol, e.g., HTTP)
- Each service developed and deployed **independently**

**Monolithic vs Microservices**:

| Aspect              | Monolithic                       | Microservices                       |
| ------------------- | -------------------------------- | ----------------------------------- |
| **Scaling**         | Replicate entire monolith        | Replicate only needed services      |
| **Changes**         | Change entire application        | Change individual services          |
| **Fault isolation** | Failure affects everything       | Failure isolated to one service     |
| **Development**     | Large team, coordinated releases | Small teams, independent deployment |
> **Containers provide an excellent environment for running microservices** – each microservice runs in its own container, multiple copies for load balancing.

**Typical container contents**: single executable service (a microservice). Multiple containers for same microservice run same code, linked via message queuing or load balancing.
## Container Management Platforms
> **Container Management Platforms** (aka container orchestration engines, CaaS platforms) help enterprises address challenges of deploying containers. They let administrators **monitor, manage, secure, and scale containers** like existing servers/VMs.

**Examples**: Docker Swarm, Kubernetes, Amazon ECS, Azure Container Instances.
## Example: Docker
> **Docker** = open-source project for developing, packaging, distributing, and running applications inside software containers. Provides additional abstraction and automation of OS-level virtualisation on Linux.

**Analogy**: "docker" (person employed in port to load/unload ships) → uniform wrapper around software package: **"Build, Ship and Run Any App, Anywhere"**
### Docker Core Definitions

| Term          | Definition                                                                  |
| ------------- | --------------------------------------------------------------------------- |
| **Image**     | Read-only template (binary artifact) that defines how to create a container |
| **Container** | Instantiation of an image; a **running instance**                           |
| **Runtime**   | Tool or service to execute and manage containers                            |
| **Registry**  | Service to store and distribute images (e.g., **Docker Hub**)               |
### Docker Engine Components

| Component                   | Function                                                                                                                  |
| --------------------------- | ------------------------------------------------------------------------------------------------------------------------- |
| **Docker Daemon (dockerd)** | Runs on host machine; long-running background service; manages images, containers, networks, volumes; provides Docker API |
| **Docker Client**           | User interface; communicates with Docker Daemon to execute commands                                                       |
| **REST API**                | For interacting with Docker Daemon remotely                                                                               |
### Dockerfile and Images
> **Dockerfile** = end-user writes instructions to build a Docker image. Images are **read-only templates** (saved on disk) built from Dockerfile instructions. Define both the packaged application and its dependencies, plus processes to run on launch.
### Docker Analogy

| Docker Concept | Analogy                       |
| -------------- | ----------------------------- |
| Docker Client  | Waiter (takes order)          |
| Docker Daemon  | Manager (coordinates kitchen) |
| Docker Image   | Recipe (instructions)         |
| Runtime        | Chef (executes recipe)        |
| Container      | Dish Served (final product)   |
### Docker Layered File System
> Images are **read-only**. Docker uses a **layered file system** – writable layer sits above image's read-only layers. When file modified, change written only to writable overlay.

**Docker also**:
- Creates network interface for container to talk to local host
- Attaches IP address to container
- Executes specified process when defining image
### Docker Compose
> **Docker Compose** = tool for designing and running **multi-container services**. Uses **YAML file** to specify containers and their options. More basic than Kubernetes.

**Example** (CodiMD markdown server requiring database):
```yaml
services:
  database:
    image: postgres:11.6-alpine
  codimd:
    image: hackmdio/hackmd:2.1.0-cjk
    depends_on:
      - database
volumes:
  database-data: {}
  upload-data: {}
```

**Analogy**: Docker Compose = **"Menu Planner"** – takes multiple recipes (images) and instructions (services, networks, volumes) into a full meal (multi-container application).
### Docker Hub
> **Docker Hub** = registry where Docker images are stored and shared. Like GitHub for Docker images. Owners commit and push images for others to use.
## The Case for Unikernels
> **Unikernel** = specialised, single-purpose machine image that includes:
> 1. The application
> 2. The **minimal OS components it needs**
>
> Runs directly on hypervisor or bare metal – **no general-purpose OS**.

**Benefits**:
- Extremely light, allowing high density on commodity hardware
- **Just-in-time computing service**
- Smaller attack surface (no unnecessary OS components)

**Deployment Options – Efficiency Spectrum**:

```
Least Efficient ─────────────────────────────────────────► Most Efficient

Dedicated HW → Virtual Machines → Containers → Unikernels

Services placed anywhere from dedicated hardware to just a software package.
```

**Container position**: Ideal for efficiency and management – most advantages of VMs, less overhead than VMs.

**Further improvement**: Unikernels (even lighter, but less mature).
## Conclusion

- **Containers** = alternative to Virtual Machines
- Comprise just the **application + its dependencies**
- Run as **isolated process in user space** on host OS, sharing kernel with other containers
- Enjoys resource isolation and allocation benefits of VMs but is **much more portable and efficient**

**Note**: Singularity (http://singularity.lbl.gov/) is an alternative to Docker, designed for scientific/HPC environments.
## Comparison Table: Deployment Options

| Feature       | Dedicated HW         | Virtual Machine  | Container             | Unikernel              |
| ------------- | -------------------- | ---------------- | --------------------- | ---------------------- |
| **Isolation** | Full (physical)      | Full (hardware)  | Process-level         | Process-level          |
| **Guest OS**  | Native OS            | Full OS per VM   | Shared kernel         | Minimal kernel         |
| **Boot time** | Minutes              | Minutes          | Seconds/milliseconds  | Milliseconds           |
| **Size**      | Full OS              | GBs              | MBs                   | KBs-MBs                |
| **Overhead**  | None                 | High             | Low                   | Very low               |
| **Use case**  | Performance-critical | Legacy, multi-OS | Microservices, DevOps | IoT, edge, specialized |
## Quick Reference for This Lecture

| Term                   | Definition                                                      |
| ---------------------- | --------------------------------------------------------------- |
| **Container**          | Isolated user-space instance sharing host kernel                |
| **chroot**             | 1979 Unix isolation (change root directory)                     |
| **LXC**                | 2008 – first modern Linux container tech (cgroups + namespaces) |
| **Docker**             | 2013 – made containers accessible                               |
| **Image**              | Read-only template for containers                               |
| **Container** (Docker) | Running instance of an image                                    |
| **Docker Daemon**      | Background service managing containers                          |
| **Docker Hub**         | Public registry for Docker images                               |
| **Docker Compose**     | Multi-container YAML orchestration                              |
| **Microservices**      | Small, autonomous, loosely coupled services                     |
| **Unikernel**          | App + minimal OS components, no general-purpose OS              |

**Exam traps**:
- **2025 Q1c (implied)** : Container vs VM performance – containers boot **seconds** vs VMs **minutes**
- **Migration**: containers are portable but share kernel; VMs have stronger isolation
- **Unikernels** = even lighter than containers, but less mature
- **Docker Compose** = multi-container orchestration (simpler than Kubernetes)
# Lecture 7: Cloud Virtual Infrastructure Management
**Goals:** Understand Virtual Infrastructure Manager (VIM) features
### Overview
- Introduction
- Virtual Infrastructure Managers
- Architectural view
- Examples: OpenNebula and OpenStack
- Considerations: Compute, Storage, Network
- Programming – APIs
- Conclusion
## Introduction
### Why a Virtual Infrastructure Manager (VIM)?

VMs are great... but something more is needed:
- Where do I put my VM? (**scheduling & monitoring**)
- How do I provision a new cluster node? (**clone & context**)
- What MAC addresses are available? (**networking**)
> **VIM provides**: uniform view of resource pool, life-cycle management and monitoring of VM, integration of Image, Network and Virtualisation.
### Virtual Machine Management Model

**Key principles**:
- VM Manager is **service agnostic** – doesn't matter if service is web server or database
- VMs encapsulate service components and act as endpoints for client interactions
- Single VM may serve multiple tiers (e.g., Web Server + Database)
- Centralises service logic within individual VMs

**Key responsibilities**:
- **Interconnection**: configure networking in many VMs
- **Placement**: physical server must support VM requirements (vCPUs, memory, etc.)
- **Image management**: creation, storage, distribution of VM images
- **Enables scalable, modular control** of VM infrastructure across multiple nodes
### Benefits of VIM

**For Infrastructure Manager**:
- Centralised management of VM workload and distributed infrastructures
- Support for VM placement policies (load balancing, server consolidation)
- Dynamic resizing of infrastructure
- Dynamic partition and isolation of clusters
- Dynamic scaling of private infrastructure to meet fluctuating demands
- Lower infrastructure expenses combining local and remote cloud resources
> **Server consolidation** = reducing number of physical servers by running multiple VMs on fewer physical hosts.
## Virtual Infrastructure Managers – Architectural View
### OpenNebula (https://opennebula.io/)

**Additional interaction methods**: CLIs and APIs.

| Feature                       | Function                                                                                     |
| ----------------------------- | -------------------------------------------------------------------------------------------- |
| **Internal Interface**        | Unix-like CLI for VM life-cycle + physical boxes; XML-RPC API and libvirt virtualization API |
| **Scheduler**                 | Requirement/rank matchmaker for workload and resource-aware allocation policies              |
| **Virtualization Management** | Xen, KVM, VirtualBox, VMware; Generic libvirt connector                                      |
| **Image Management**          | Transfer and clone VM images                                                                 |
| **Network Management**        | Define isolated virtual networks to interconnect VMs                                         |
| **Service Management**        | Support for multi-tier services with auto-configuration at boot                              |
| **Security**                  | User management by infrastructure administrator                                              |
| **Fault Tolerance**           | Persistent database backend for host and VM info                                             |
| **Scalability**               | Tested with hundreds of servers and VMs                                                      |
| **Installation**              | On UNIX cluster front-end without new services                                               |
| **Flexibility**               | Open, extensible architecture for integration with any product/tool                          |
### OpenNebula Architecture – Storage Considerations

| Approach                           | Description                                                   |
| ---------------------------------- | ------------------------------------------------------------- |
| **NAS** (Network Attached Storage) | VMs and images represented as **files**                       |
| **SAN** (Storage Area Network)     | VMs and images represented as **block devices** (like a disk) |
### OpenNebula – Networking Demands

| Traffic Type                    | Description                                                                                                  |
| ------------------------------- | ------------------------------------------------------------------------------------------------------------ |
| **Management operations**       | Use ssh connections                                                                                          |
| **Image traffic**               | May require moving heavy files (VM images, checkpoints)                                                      |
| **VM demands**                  | Typical requirements of thousands of VMs                                                                     |
| **NICs for VM traffic**         | Configuration of MAC and IP addresses                                                                        |
| **Bridge networking (Layer 2)** | VIM creates bridges for VMs; Linux bridge acts as virtual Ethernet switch connecting vNICs and physical NICs |
### OpenNebula – VM Description

| Option                                 | Description                                  |
| -------------------------------------- | -------------------------------------------- |
| **NAME**                               | VM name for description purposes             |
| **CPU**                                | Percentage of CPU ÷ 100 required for the VM  |
| **OS (KERNEL, INITRD)**                | Path of kernel and initrd files to boot from |
| **DISK (SOURCE, TARGET, CLONE, TYPE)** | Disk image to attach to VM                   |
| **NIC (NETWORK)**                      | Virtual network the VM will be attached to   |

> **Principle**: Install once, deploy many – prepare master images.
### OpenNebula – Interaction Methods

| Method                                   | Description                                           |
| ---------------------------------------- | ----------------------------------------------------- |
| **Sunstone GUI**                         | Web interface for admins and users                    |
| **CLI** (Command Line Interface)         | Tools like `onevm`, `onevnet`, etc.                   |
| **OpenNebula Cloud API (OCA) Libraries** | Ruby, Java, Python for automation                     |
| **XML-RPC API**                          | Simple, fast, any language; for advanced integrations |
### OpenStack (https://www.openstack.org/)
> Ubiquitous open-source cloud computing platform for public and private clouds. **Aim**: to be the "Linux" of cloud computing systems.

**Key characteristics**:
- Management layer adding automation and control
- Empower administrators via service portals
- Empower developers with cloud-aware APIs
- Commonly used in **large datacenters** with advanced requirements
- Enables **cloud federation**
- Used by hundreds of providers, telcos, thousands of enterprises
- **25+ million cores** running in production (OpenStack User Survey 2021)
### OpenStack Core Projects ("7 Core" for IaaS)

| Project             | Function                                     | Component Name |
| ------------------- | -------------------------------------------- | -------------- |
| **Compute**         | Provision and manage virtual resources       | **Nova**       |
| **Storage (Block)** | Persistent block storage                     | **Cinder**     |
| **Network**         | Software-defined networking                  | **Neutron**    |
| **Dashboard**       | Self-service portal                          | **Horizon**    |
| **Image**           | Catalog and manage server images             | **Glance**     |
| **Identity**        | Unified authentication, RBAC                 | **Keystone**   |
| **Object Storage**  | Petabytes of secure, reliable object storage | **Swift**      |
### OpenStack Compute (Nova) – Key Capabilities

| Capability                                    | Description                             |
| --------------------------------------------- | --------------------------------------- |
| **Manage virtualised server resources**       | CPU, memory, disk, network interfaces   |
| **API with authentication**                   | Programmatic access                     |
| **Distributed and asynchronous architecture** | Scalable                                |
| **Massively scalable, highly available**      | Production-grade                        |
| **Live guest migration**                      | Move running VMs between physical hosts |
| **Live VM management**                        | Run, reboot, suspend, resize, terminate |
| **Security Groups**                           | Firewall rules                          |
| **Role-Based Access Control (RBAC)**          | Security by user, role, project         |
| **Projects & Quotas**                         | Resource limits per project             |
### OpenStack Compute Management Stack
> Built on **queues** and **database**.

**Message Queues**:
- Responsible for inter-process communications hub and data persistence
- **AMQP-based** messaging (RabbitMQ default, also Qpid, ZeroMQ)
- Single "cell" (1 Queue, 1 Database) scales to **500–1000 physical machines**

**Flow**:
1. API requests validated and placed on queue
2. Workers listen to queues based on role
3. Responses dispatched back through queue
### Additional OpenStack Projects (exam awareness)

| Project        | Function                                               |
| -------------- | ------------------------------------------------------ |
| **Heat**       | Orchestration of multiple composite cloud applications |
| **Mistral**    | Workflow management                                    |
| **Zun**        | Launch and manage containers (instead of VMs)          |
| **Ceilometer** | Billing systems (resource consumption)                 |
| **Trove**      | Database as a Service                                  |
| **Sahara**     | Rapidly provision Hadoop clusters                      |
## Programming – APIs

**Interaction with OpenStack**:
1. OpenStack portal (Horizon – web GUI)
2. Python SDK for OpenStack APIs

**For OpenNebula**:
- XML-RPC API
- OCA libraries (Ruby, Java, Python)
- CLI tools
## Conclusion

- Presented Virtual Infrastructure Management features
- Two examples: **OpenNebula** (simpler, lightweight) vs **OpenStack** (complex, full-featured)
- Both provide setting up **private and hybrid clouds**
- OpenStack modular architecture with **7 core projects**
- Additional projects (Heat, Zun, Ceilometer, Sahara, etc.) extend functionality
## Comparison Table: OpenNebula vs OpenStack

| Feature          | OpenNebula                   | OpenStack                          |
| ---------------- | ---------------------------- | ---------------------------------- |
| **Complexity**   | Simple, lightweight          | Complex, full-featured             |
| **Target scale** | Medium (hundreds of servers) | Large (thousands+ servers)         |
| **Architecture** | Monolithic                   | Modular (many projects)            |
| **Scheduler**    | Rank scheduling              | Multiple schedulers (Nova filters) |
| **Networking**   | Basic bridge networking      | Neutron (SDN, advanced)            |
| **Storage**      | NAS or SAN                   | Cinder (block) + Swift (object)    |
| **Dashboard**    | Sunstone                     | Horizon                            |
| **API**          | XML-RPC, OCA                 | REST (OpenStack APIs)              |
| **Use case**     | Simple private clouds        | Large-scale, carrier-grade, hybrid |
## Quick Reference for This Lecture

| Term                     | Definition                                                       |
| ------------------------ | ---------------------------------------------------------------- |
| **VIM**                  | Virtual Infrastructure Manager                                   |
| **Server consolidation** | Reducing physical servers by running multiple VMs on fewer hosts |
| **OpenNebula**           | Lightweight VIM for medium-scale private clouds                  |
| **OpenStack**            | Full-featured VIM for large-scale, carrier-grade clouds          |
| **Nova**                 | OpenStack Compute service                                        |
| **Neutron**              | OpenStack Networking service                                     |
| **Cinder**               | OpenStack Block Storage                                          |
| **Glance**               | OpenStack Image service                                          |
| **Keystone**             | OpenStack Identity service                                       |
| **Horizon**              | OpenStack dashboard                                              |
| **Swift**                | OpenStack Object Storage                                         |
| **RabbitMQ**             | Default message queue for OpenStack                              |

**Exam traps**:
- **VIM is NOT the hypervisor** – it manages hypervisors (scheduling, images, networking)
- **OpenStack vs OpenNebula** – know which is suitable for which scale
- **Server consolidation** = energy efficiency (fewer physical servers running)
- **Live migration** requires shared storage (SAN/NAS) for disk state
# Lecture 8: Cloud Resource Management and Scheduling
**Goals:** Understand concepts of resource management and scheduling in clouds
### Overview
- Introduction
- Cloud Resource Management
- Scheduling Approaches
- Live Migration Issues
- Scaling Up/Out
- Conclusion
## Introduction
### Resource Management and Scheduling
> **Scheduling** = deciding how to allocate resources (hosts, CPU cycles, memory, storage space, I/O, network bandwidth) between users and tasks.

**Affects three basic criteria for system evaluation**: performance, cost, energy.

**Policies vs Mechanisms**:
- **Policy**: principles guiding decisions (e.g., maximise resource utilisation, maximise profit)
- **Mechanisms**: means to implement policies (e.g., scheduling algorithms)
## Cloud Resource Management
### What is Required?
> **SLA (Service Level Agreement)** = contract between provider and consumer specifying QoS guarantees (uptime, performance, response time).

**Cloud resource management**:
- Requires **complex policies and decision making** – a **multi-objective optimisation problem**
- Is challenging – accurate global state information difficult
- Affected by unpredictable interactions (failures, attacks)
- Highly variable workloads test cloud elasticity
### Cloud Resource Management Policies

| Policy                  | Description                                                                            |
| ----------------------- | -------------------------------------------------------------------------------------- |
| **Admission control**   | Prevent system from accepting workload that would violate policies or exceed resources |
| **Capacity allocation** | Allocate resources for individual service activations                                  |
| **Load balancing**      | Distribute workload evenly among servers                                               |
| **Energy optimisation** | Minimise energy consumption                                                            |
| **QoS guarantees**      | Satisfy timing/conditions specified by SLA                                             |
### Cloud Scheduling: Nested Resource Levels
> Scheduling responsible for resource sharing at **multiple levels**:
> 1. Physical host shared among several VMs
> 2. A VM supports several applications
> 3. An application may consist of multiple threads

**Cloud Computing Scheduling = Resource Sharing Hierarchy**
### Scheduler Objectives by Workload Type

| Workload Type        | Objective                                       |
| -------------------- | ----------------------------------------------- |
| **Batch system**     | Maximise throughput, minimise turnaround time   |
| **Real-time system** | Meet deadlines, be predictable (very difficult) |
| **Best effort**      | Fair resource sharing                           |

**Best effort scheduling algorithms**: Round-Robin (RR), First-Come-First-Served (FCFS), Shortest-Job-First (SJF), Priority Algorithms. Fairness indexes can be calculated.
## Scheduling Approaches
### VM Scheduling in OpenNebula
> Scheduler **matches waiting VMs with available hosts**. **Match making** = takes VM's requirements and matches with physical host that can support them.

**Rank Scheduling Policy**: prioritises resources more suitable for the VM.
### VM Scheduling Approaches – Examples

| Approach              | Focus                                                                              |
| --------------------- | ---------------------------------------------------------------------------------- |
| **Power-aware**       | Minimise power consumed by physical hosts to maximise revenues                     |
| **Performance-aware** | Maintain service levels while improving resource utilisation via dynamic placement |
| **Network-aware**     | Minimise effect of data transfer time between VM instances and data storage        |
| **Heuristics**        | Service disciplines like FCFS, RR                                                  |
### VM Scheduling Example: First Fit
> Place each VM on the **first physical host** that has sufficient resources (CPU, memory, etc.). Simple but may lead to fragmentation.
### Power-aware Example
> Which configuration is better? **485 Watts vs 552 Watts** – lower power consumption is better for energy optimisation.
## Live Migration Issues
### Scheduling and Migration
> **Migration** allows avoiding/minimising datacenter hotspots (excessive overloading). **However**: migration requires additional cost and energy (rescheduling).

**Hotspots** can occur in CPU, memory, network, and/or storage.
### VM Migration
> **VM Migration** = transferring executing VMs between physical hosts without disconnecting client or application. Memory, storage, and network connectivity transferred.

**Common use**: planned activities (e.g., physical machine maintenance).
### The Problem
> Copy of a VM requires transferring **complete state** from original VM to copy: processor state, memory, disk, network connections.
### Migration Methods – Memory

| Method       | Description                                                                          | Pros                               | Cons                                                                  |
| ------------ | ------------------------------------------------------------------------------------ | ---------------------------------- | --------------------------------------------------------------------- |
| **Precopy**  | First copies memory state through repetitive process, then transfers processor state | Higher reliability                 | May repeatedly copy inconsistent "dirty pages"                        |
| **Postcopy** | Transfers processor state first; memory pages fetched on-demand                      | Avoids repeated dirty page copying | Performance degradation from page faults, network delays; less stable |

> **Precopy generally preferred** because it ensures higher reliability.
### Migration Methods – Network
> To maintain network connectivity after migration, must preserve open connections. Clients should be attended with minimal disruption.

**Case 1: Migration within same LAN (Local Area Network)** :
- VM retains its original **private IP address**
- MAC address may be reassigned and re-advertised
- System sends **unsolicited ARP reply** to ensure recognition (private IP reachable via new MAC)

**Case 2: Migration over WAN (Wide Area Network)** :
- Virtual networks (VNet) cannot be moved between regions
- **Public IP not retained** – VM requires new public IP (IP resources region-specific)
- **Private IP usually changes** – VM gets new IP from new subnet
- **Best practice**: Use **DNS names** instead of hardcoded IPs
### Migration Methods – Storage

**Case 1: Migration within same LAN (easy)** :
- If SAN or NAS used locally, new VM accesses **same storage**
- Disk state migration **not required**

**Case 2: Migration over WAN (costly)** :
- Disk state must be recreated or replicated in target WAN
- Data transfer and potential downtime for consistency
- **Largest component** of overall migration time (tens/hundreds of GBs)
- Many strategies exist (e.g., Distributed Replicated Block storage)
## Scaling Up/Out

| Strategy                     | Description                                                                                      | Analogy                     |
| ---------------------------- | ------------------------------------------------------------------------------------------------ | --------------------------- |
| **Scaling Out** (Horizontal) | Getting additional VM(s) to spread application processing load                                   | Add more servers            |
| **Scaling Up** (Vertical)    | Upgrading current hardware components within VM, or replacing VM with better performance version | Make existing server bigger |

> **Cloud elasticity**: scale out for increased load, scale in when load decreases.
## Conclusion
- Reviewed important aspects of cloud resource management and scheduling
- Many VM scheduling approaches exist in literature – **still an important research problem**
- Issues with VM migration (memory, network, storage) remain challenging
## Quick Reference for This Lecture

| Term                      | Definition                                                      |
| ------------------------- | --------------------------------------------------------------- |
| **SLA**                   | Service Level Agreement – QoS guarantees                        |
| **Admission control**     | Reject workload that would violate policies                     |
| **Load balancing**        | Distribute workload evenly                                      |
| **Server consolidation**  | Reduce physical servers, run multiple VMs                       |
| **Precopy migration**     | Copy memory first, then CPU state (reliable)                    |
| **Postcopy migration**    | Copy CPU first, fetch memory on-demand (faster but less stable) |
| **Unsolicited ARP reply** | Announces new MAC for same IP after LAN migration               |
| **Scaling out**           | Add more VMs (horizontal)                                       |
| **Scaling up**            | Make VM bigger (vertical)                                       |
| **Hotspot**               | Excessive overloading of CPU/memory/network/storage             |

**Exam traps**:
- **Precopy = reliable** (preferred); **Postcopy = faster but less stable**
- **LAN migration** = same private IP, unsolicited ARP
- **WAN migration** = new public/private IPs, use DNS names
- **Scaling out** = more VMs; **Scaling up** = bigger VM
- **Server consolidation** reduces physical servers → saves energy
# Lecture 9: Container Management – Kubernetes
**Goals:** Understand the concepts of container orchestration
### Overview
- Kubernetes: what is it?
- Definitions
- Architecture
- Key concepts
- Pods and containers
- Auto-scaling
- Nephio
- References
## Kubernetes: What Is It?
> **Kubernetes** (Greek for "pilot" or "helmsman of a ship") = open source cluster manager from Google. **Pronunciation**: Koo-ber-NAY-teez.

**Alternative names**: **kube**, **k8s** ('k' + 8 letters + 's').
> **Kubernetes** = declarative language for launching containers + highly collaborative open-source project originally conceived by Google (10+ years experience with containerised apps). **De facto standard for container orchestration**.

**Key capabilities**:
- Start, stop, update, and manage a cluster of machines running containers in a consistent and maintainable fashion
- Provided as a service (Google Cloud, Rackspace, Azure, etc.)
### Kubernetes Role

| Function                             | Description                                                                             |
| ------------------------------------ | --------------------------------------------------------------------------------------- |
| **Coordinates deployments**          | Which containers? Where? How do different containers talk to each other?                |
| **Improves reliability**             | Continuously monitors and manages containers; scales application to handle load changes |
| **Manages infrastructure resources** | Reduces infrastructure requirements by scaling up/down gracefully                       |
## Definitions

| Term                 | Definition                                                                                        |
| -------------------- | ------------------------------------------------------------------------------------------------- |
| **Kubernetes (k8s)** | Open source container orchestration platform originally from Google                               |
| **Pod**              | Smallest deployable unit of compute; one or more containers sharing network namespace and storage |
| **Node**             | Worker machine (virtual or physical) where pods run                                               |
| **Cluster**          | Set of nodes managed by the control plane                                                         |
| **Control Plane**    | Kubernetes master components (API server, etcd, scheduler, controller manager)                    |
| **Deployment**       | Defines desired state for pods (template + replicas); manages rolling updates                     |
| **ReplicaSet**       | Ensures specified number of identical pods are always running                                     |
| **Service**          | Stable network endpoint (internal IP/DNS) for accessing pods; internal load balancer              |
| **Namespace**        | Logical isolation method; creates virtual environments inside same physical infrastructure        |
## Architecture
### High-Level Architecture
**Control Plane (Master)** components:
- **kube-api-server** – API that clients use to interact with control plane; handles authentication, authorisation, request validation, admission control
- **etcd** – Strong, consistent, highly available key-value store for persisting cluster state
- **kube-controller-manager** – Primary daemon managing all core component control loops
- **kube-scheduler** – Assigns pods to nodes; default scheduler uses **bin packing** (smallest number of nodes with enough capacity)

**Node-Level Abstractions**:

| Component                    | Function                                                                                                                                           |
| ---------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------- |
| **kubelet**                  | Node agent responsible for managing lifecycle of every pod on its host; ensures containers run as defined in PodSpec; reports status to API server |
| **Container Runtime Engine** | Actually runs and manages container lifecycle (start, stop, delete) – e.g., Docker, containerd                                                     |
| **kube-proxy**               | TCP/UDP forwarding; manages network rules on each node; manages iptables/IPVS rules to route traffic to correct pods                               |
| **System services**          | Essential OS-level services supporting control plane and nodes (networking, storage, process management)                                           |
## Key Concepts
### Pods
> **Pod** = atomic unit / smallest "unit of work" of Kubernetes. **One or more containers** that share volumes, a network namespace, and are part of a single context.

**What pods share**:
- **Storage volumes** – containers can read/write same files
- **Network namespace** – communicate over **localhost**; share same IP address and ports
### Nodes
> **Node** = worker machine (virtual or physical). Each Node managed by the **Master**. Node can have **multiple pods**. Master automatically schedules pods across cluster nodes considering available resources.
### Namespace
> **Namespace** = logical isolation method. Most resources are namespace-scoped (share same context). Creates **virtual environments** inside same physical infrastructure.

**Uses**:
- Group similar workloads logically
- Enforce policies (access controls, resource limits, network policies)
### Deployment
> **Deployment** defines:
> - **Pod template** (how each pod should be configured)
> - **Replicas field** (how many copies of the pod should run)

**Behaviour**:
- Kubernetes constantly monitors system to ensure running pods match Deployment definition
- If pod crashes → Kubernetes fixes automatically
- If Deployment changes (e.g., update container image) → **rolling update** gradually replaces old pods with new ones (avoids downtime)
### ReplicaSet
> **ReplicaSet** ensures specified number of identical pods are always running.

**Behaviour**:
- If pod crashes or deleted → ReplicaSet automatically creates new one to maintain desired count
- **Horizontal scaling** adjusts replica count dynamically (e.g., 3 → 6 pods) based on metrics (CPU usage)
- **Deployment manages ReplicaSets over time**
### Service
> **Service** provides stable way to talk to containerised application using internal IP or DNS name. **Internal load balancer** to pod(s).

**Key properties**:
- Even if pods created/destroyed, Service provides **consistent network endpoint**
- **Durable resource** – static cluster IP, static namespaced DNS name
- Clients always reach application regardless of pod changes
## Auto-Scaling
### Horizontal Pod Autoscaler (HPA)
> **HPA** = built-in feature; control loop that runs intermittently. **Automatically scales pods in/out** based on metrics (primarily CPU usage).

**Works on top of**:
- **ReplicaSets** – ensures given number of identical pods are up
- **Deployments** – manages replica set through time and versions

**Operation**:
- Makes threshold-based decisions automatically
- Scales pods up when load increases
- Scales pods down when load decreases

**Exam trap (2025 Q1f)**: HPA primary function = **B. Automatically adjust number of replicas in a workload based on observed resource utilisation** (not node scaling, not network traffic, not persistent storage).
### Cluster Autoscaler
> **Cluster Autoscaler** changes the number of cluster **nodes** (makes new nodes available). While HPA scales **pods**, Cluster Autoscaler scales **nodes**.

**Triggered when**:
- HPA requests more pods but cluster lacks available node resources to schedule them
- Cluster Autoscaler tries to consolidate pods deployed on few nodes

**Loops constantly through both tasks** (scaling in and out).
## Nephio: Cloud Native Network Automation
> **Nephio** = Kubernetes-based open-source framework for managing network functions and underlying infrastructure using cloud-native principles.

**Purpose**: Bridges gaps between traditional networking and modern cloud-native paradigms using **Kubernetes-driven intent-based automation** across cloud and edge environments. Aims for **carrier-grade automation** that is open, extensible, and standards-aligned (3GPP, O-RAN).

**Key features**:
- Uses Kubernetes **declarative automation** and **intent-driven models**
- Simplifies deployment and management of multi-vendor network functions across distributed cloud environments

**Abstraction levels**:

| Level                | Description                                                                                                           |
| -------------------- | --------------------------------------------------------------------------------------------------------------------- |
| **System Context**   | Shows what Nephio is and how it interacts with other systems (responsibilities, connections – not deployment details) |
| **System Landscape** | Explains that Nephio is made of several software systems working together; shows their relationships                  |
| **Component View**   | Breaks down main parts inside Nephio (core functions, vendor-specific controllers, package management tools)          |

**Component View details**:
- **Nephio Core** – heart of architecture; operators and functions handling fundamental aspects independent of vendor-specific implementations
- **Controllers for OAI (Open Air Interface) and Free5GC** – vendor extensions for open-source 5G implementations
- **Porch** – key component providing package orchestration and lifecycle management in Kubernetes-native way
## Comparison Table: HPA vs Cluster Autoscaler

| Feature          | Horizontal Pod Autoscaler (HPA)                 | Cluster Autoscaler                              |
| ---------------- | ----------------------------------------------- | ----------------------------------------------- |
| **Scales**       | **Pods** (number of replicas)                   | **Nodes** (cluster size)                        |
| **Trigger**      | CPU utilisation, custom metrics                 | Pods pending due to insufficient resources      |
| **Direction**    | Scales out (more pods) and in (fewer pods)      | Scales up (more nodes) and down (fewer nodes)   |
| **Works with**   | Deployments, ReplicaSets                        | Node pools, auto-scaling groups                 |
| **Relationship** | HPA can trigger CA when pods can't be scheduled | CA adds nodes to accommodate HPA-requested pods |
## Quick Reference for This Lecture

| Term                   | Definition                                                          |
| ---------------------- | ------------------------------------------------------------------- |
| **k8s**                | Kubernetes (k + 8 letters + s)                                      |
| **Pod**                | Smallest deployable unit; 1+ containers sharing network/storage     |
| **Node**               | Worker machine (VM or physical)                                     |
| **Control Plane**      | Master components (API server, etcd, scheduler, controller manager) |
| **kube-api-server**    | Entry point for all Kubernetes API calls                            |
| **etcd**               | Key-value store for cluster state                                   |
| **kube-scheduler**     | Assigns pods to nodes (bin packing)                                 |
| **kubelet**            | Node agent managing pods                                            |
| **kube-proxy**         | Network rules and routing                                           |
| **Deployment**         | Desired state for pods (template + replicas)                        |
| **ReplicaSet**         | Maintains pod count                                                 |
| **Service**            | Stable network endpoint for pods                                    |
| **Namespace**          | Logical isolation within cluster                                    |
| **HPA**                | Scales pods based on CPU/metrics                                    |
| **Cluster Autoscaler** | Scales nodes                                                        |
| **Rolling update**     | Gradual pod replacement (zero downtime)                             |
| **Nephio**             | K8s-based network function automation                               |

**Exam traps**:
- **2025 Q1f**: HPA = pod scaling (not node scaling)
- **Pod vs Container**: Pod can have multiple containers; smallest **Kubernetes** unit is Pod, not container
- **Deployment vs ReplicaSet**: Deployment manages ReplicaSets; ReplicaSet maintains pod count
- **Rolling update** = zero downtime; gradual replacement
- **etcd** stores cluster state (not application data)
# Lecture 10: Advanced SDN and NFV
**Goals:** Understand concepts of cloud networking architectures, including modern SDN and traditional NFV
### Overview
- SDN recap
- Slicing-as-a-service
- ONOS
- SD-RAN
- P4
- Stratum
- P4 + Stratum for security
- Intent-based networking
- Zero-touch provisioning
- YANG and NETCONF
- NFV and VNF: ETSI Architecture
- Conclusion
## SDN Recap
### SDN and the Cloud – Key Applications

| Application                              | Description                                                                               |
| ---------------------------------------- | ----------------------------------------------------------------------------------------- |
| **Centralised Network Management**       | SDN controllers manage policies, security, routing across multiple datacenters            |
| **Network Virtualisation**               | Create virtual networks dynamically provisioned and modified                              |
| **Traffic Engineering & Load Balancing** | Dynamically optimise traffic flow; intelligent load balancing across datacenter resources |
| **Automation & Orchestration**           | Automate network provisioning and configuration                                           |
| **Security & Access Control**            | Isolate workloads, define strict access policies                                          |
### Use Cases of SDN
> SDN modules triggered by events from **southbound API** (e.g., OpenFlow) or **northbound API** (security services, application orchestration).

**Characteristics**:
- Network services are **short-lived and event-driven** (transcoding, anomaly detection)
- Require **low start-up latencies**
- Virtualisation platform needs fast task scheduling
## Slicing-as-a-Service (SlaaS)
> **Slicing as a Service** = network service model allowing operators to create and deliver customised, **isolated network slices** on demand to different tenants or applications.

**Definition**:
- Each slice = virtualised end-to-end network segment with own resources, performance guarantees, and policies
- Runs over **shared physical infrastructure**

**SDN role**: Provides centralised programmability and real-time telemetry, enabling dynamic path selection, bandwidth allocation, and policy enforcement to meet SLA requirements automatically.
## ONOS (Open Network Operating System)
> **ONOS** = open-source SDN controller specifically designed for **Telecom Service Providers, carriers, and high-performance mission-critical networks**. Prioritises **scalability, high availability, and enhanced performance**.

**History**: Originally developed by Open Networking Foundation (ONF); now under Linux Foundation Networking (LFN).

**Key features**:
- Manages network resources (bandwidth, links, switches) to run network applications
- Creates **Global Network View** – logical map of entire network; applications interact with this map, not individual switches
### ONOS Architecture – Three Layers

| Layer                   | Function                                                                                                                                           |
| ----------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------- |
| **Northbound Core API** | Faces applications (traffic engineering); high-level abstractions – "Connect Host A to Host B" without knowing underlying hardware                 |
| **Distributed Core**    | Runs as cluster of multiple servers (failover); maintains network topology and state                                                               |
| **Southbound Core API** | Faces network devices; supports multiple protocols (OpenFlow, NETCONF, P4Runtime); uses "drivers" to translate generic commands to device-specific |
## SD-RAN (Software-Defined Radio Access Network)
> **SD-RAN** = cloud-native RAN platform consistent with **O-RAN (Open RAN)** architecture.

**Key component**: **μONOS-RIC** (micro version of ONOS RAN Intelligent Controller) – allows operators to install AI/ML applications (xApps) to control RAN in (near) real-time, optimising spectrum utilisation and network performance.
## P4 (Programming Protocol-independent Packet Processors)
> **P4** = domain-specific, open-source programming language for the network **data plane** (switches, routers, NICs, packet filters).

**Key characteristics**:
- **Protocol-independent** – developers specify packet parsing, header formats, tables, and actions
- Works with SDN control protocols (OpenFlow) but can interoperate with new control protocols
- **Separates** how packets are processed (P4 program) from which rules are applied (SDN controller)
- Makes **data plane fully programmable**
### P4 Architecture
> P4 enables switches to process packets using **programmable parser** and **multiple match-action stages** arranged in series, parallel, or both.

**Abstract model** works across various devices – from software switches to high-speed ASICs.

**bmv2** = behavioral model – tool for developing, testing, and debugging P4 data planes and control plane software.
## Stratum
> **Stratum** = open-source, silicon-independent switch operating system for SDN. **P4** = language describing what switch should do; **Stratum** = how that logic runs on actual hardware/software targets.

**Features**:
- Open, minimal production-ready distribution for **white box switches**
- Provides consistent interface for SDN controllers to manage P4-based pipelines across diverse platforms
- Controllers (ONOS, etc.) interact with P4-programmable switches via Stratum using **P4Runtime API**
- Supports Barefoot Tofino, Broadcom Tomahawk, and bmv2 software switch
### P4 + Stratum for Security

| Capability                     | Description                                                                 |
| ------------------------------ | --------------------------------------------------------------------------- |
| **Programmable Data Plane**    | Define custom packet parsing and filtering for emerging threats             |
| **Dynamic Policy Enforcement** | Real-time updates to match-action tables for intrusion detection/mitigation |
| **Protocol Independence**      | Inspect and secure non-standard or encrypted headers                        |
| **Target Independence**        | Apply security logic across ASICs, FPGAs, software switches                 |
| **SDN Controller Integration** | Centralised control for adaptive security via P4Runtime                     |
## Intent-Based Networking (IBN)
> **IBN** = modern network management approach where administrators define desired outcomes or **"intent"** (performance, security, connectivity) using high-level, often natural-language inputs.

**How it works**:
- System automatically translates intents into network configurations
- Continuously monitors network to ensure compliance
- Adjusts as needed

**Relationship to SDN**:
- **SDN** = how to configure and control network (APIs, controllers)
- **IBN** = what network should achieve (business intent)
- IBN uses SDN's capabilities to enforce policies automatically
- **LLMs** can provide natural language explainability
## Zero-Touch Provisioning (ZTP)
> **ZTP** handles bootstrap phase bringing new devices online with **minimal or no manual configuration**.

**IBN enhances ZTP**: When new device provisioned, automatically receives configurations aligned with declared intent – seamless, intent-driven onboarding.

**In practice**: ZTP automatically bootstraps new devices, installing Stratum, loading P4 pipelines, connecting node to controller. Switch fabric operates in closed loop, comparing telemetry with declared intent, adjusting policies or reprovisioning via ZTP to maintain compliance.
## YANG and NETCONF

| Term                                         | Definition                                                                                                       |
| -------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- |
| **YANG** (Yet Another Next Generation)       | Data modelling language defining structure/semantics of configuration and state data for network devices         |
| **NETCONF** (Network Configuration Protocol) | Network management protocol using XML over SSH to retrieve/modify configuration data, often based on YANG models |

> **YANG and NETCONF are complements to SDN, not competitors**. SDN defines **how** network is controlled; YANG/NETCONF define **how configurations and state are represented and applied**.
## NFV and VNF
### Definitions
> **NFV (Network Functions Virtualisation)** = architecture for virtualising network, storage, and computing resources, enabling creation of virtualised network functions as services.
> **VNF (Virtualised Network Function)** = one or more virtual machines that emulate in software the functionalities of network equipment. Run on standard servers – not specialised physical hardware.

**Examples of VNFs**: firewalls, network terminal equipment, gateways, network caches, virtual switches.
### ETSI Architecture (MANO)
> In 2012, **ETSI** began pre-standardisation studies for **MANO (Management and Orchestration)** of virtual network functions.

**Orchestration definition (3GPP TS 28.801)** : "The act of interpreting and translating a given service request into configurations of physical and/or virtualised resources."

**Orchestrator analogy**: The **conductor** of an orchestra – defines who does what and how; receives customer demands; coordinates resources to ensure everything works as intended.

**Orchestrator responsibilities**:
- Receives customer demands
- Coordinates integration of various VNFs
- Forwards configurations in physical networks via SDN controllers
- **Lifecycle management**: selects hardware → instantiates VMs/containers → initialises network functions → connects programs into **service chain** or **service graph**
## Comparison Table: P4 vs OpenFlow

| Feature             | OpenFlow                          | P4                                           |
| ------------------- | --------------------------------- | -------------------------------------------- |
| **Protocol**        | Fixed protocol (v1.0, v1.3, etc.) | Protocol-independent language                |
| **Data plane**      | Fixed set of match fields         | Fully programmable (custom parsers, headers) |
| **Programmability** | Limited to OpenFlow specification | Complete (define any packet format)          |
| **Targets**         | OpenFlow-enabled switches         | Switches, NICs, FPGAs, ASICs                 |
| **Controller API**  | OpenFlow protocol                 | P4Runtime                                    |
## Quick Reference for This Lecture

| Term        | Definition                                                              |
| ----------- | ----------------------------------------------------------------------- |
| **SlaaS**   | Slicing as a Service – isolated network slices on shared infrastructure |
| **ONOS**    | Open Network Operating System – carrier-grade SDN controller            |
| **SD-RAN**  | Software-Defined RAN – O-RAN with μONOS-RIC                             |
| **P4**      | Protocol-independent packet processing language (data plane)            |
| **Stratum** | Open source switch OS for white box switches                            |
| **bmv2**    | Behavioral model – P4 software switch for development                   |
| **IBN**     | Intent-Based Networking – high-level declarative network management     |
| **ZTP**     | Zero-Touch Provisioning – automatic device bootstrap                    |
| **YANG**    | Data modelling language for network configuration                       |
| **NETCONF** | Network configuration protocol (XML over SSH)                           |
| **NFV**     | Network Functions Virtualisation                                        |
| **VNF**     | Virtualised Network Function (e.g., virtual firewall)                   |
| **MANO**    | Management and Orchestration (ETSI NFV framework)                       |

**Exam traps**:
- **P4** = data plane programmability; **OpenFlow** = control protocol (not language)
- **Stratum** runs **on** switches; **ONOS** is **controller**
- **IBN** = what; **SDN** = how
- **NFV** virtualises network functions; **SDN** separates control/data planes
- **MANO** = ETSI orchestration framework; **VNFs** run on standard servers (not special hardware)
# Lecture 11: Cloud Configuration Management
**Goals:** Present the cloud configuration management landscape
### Overview
- Infrastructure as Code
- Solutions – Examples
- Terraform
- Architecture
- Conclusion
## Infrastructure as Code (IaC)
> **Infrastructure as Code (IaC)** = managing and provisioning cyberinfrastructure through **machine-readable definition files**, not manual configuration.

**Core Goal**: Treat infrastructure setup like application code – **versionable, testable, repeatable**.

**Key Benefit**: Eliminates **configuration drift**; ensures all environments (dev, test, prod) are identical.
### How IaC Works
> Tools use **declarative approach** (stating desired end-state) to call Cloud Provider APIs (AWS, Azure, GCP).

**IaC vs OpenStack**: IaC can deploy and manage resources within OpenStack cloud (the platform providing underlying virtual resources).

**IaC vs Kubernetes**:
- **IaC** provisions the environment (underlying VMs, virtual networks, or K8s cluster itself)
- **Kubernetes** orchestrates application containers **inside** that provisioned environment
### Top IaC Tools

| Tool                   | Type                     | Description                                                                        |
| ---------------------- | ------------------------ | ---------------------------------------------------------------------------------- |
| **Terraform**          | Provisioning             | Cloud-agnostic; provisions infrastructure across multiple providers                |
| **Ansible**            | Configuration management | SSH/WinRM agentless; server configuration; widely used for orchestration           |
| **AWS CloudFormation** | Provisioning             | AWS-native declarative service for modelling, provisioning, managing AWS resources |
| **Puppet**             | Configuration management | Model-driven approach; master-agent architecture; enforces desired state           |
| **Chef**               | Configuration management | "Recipes" and "cookbooks" (Ruby DSL) for infrastructure configuration              |
### IaC and DevOps
> IaC enables **DevOps collaboration**. Key DevOps practices:

| Practice                                | Description                                                                            |
| --------------------------------------- | -------------------------------------------------------------------------------------- |
| **Continuous Integration (CI)**         | Automatically build and test code changes                                              |
| **Continuous Deployment/Delivery (CD)** | Results of development loop continuously deployed and tested in production environment |
### Environment Variables in IaC

| Environment                    | Variables                                                     |
| ------------------------------ | ------------------------------------------------------------- |
| **Development**                | mock endpoints, test credentials, non-critical configurations |
| **System Integration Testing** | How different systems and components integrate                |
| **User Acceptance Testing**    | Business/end users validate solution meets requirements       |
| **Production**                 | Live configuration used by real users and workloads           |
### Benefits of IaC

- **Multi-cloud automation** across Azure, AWS, GCP
- **Faster, more efficient deployments** with fewer manual steps
- **Repeatable, consistent environments** built same every time
- **Source control and versioning** for collaboration and auditability
- **Easy scaling and standardisation** through policies and variable changes
- **Supports CI/CD** for automated build, test, deployment
- **Static security scanning** directly on infrastructure code
- **Reduced manual effort** and fewer opportunities for human error
## Example: Terraform
> **Terraform** = provisioning declarative tool based on IaC paradigm.

**Core principle**: Describe what infrastructure should look like – **not how to create it**. Terraform reads desired end state from `.tf` files and works out steps automatically.

**Syntax**: **HCL (Hashicorp Configuration Language)**. Written in Go (Golang – developed by Google).
### Terraform Key Concepts

| Concept                         | Description                                                                          |
| ------------------------------- | ------------------------------------------------------------------------------------ |
| **Resource provisioning**       | Using configuration code to create actual infrastructure (VMs, networks) in cloud(s) |
| **Planning updates**            | Determines what changes will be made to match updated code                           |
| **Source control**              | IaC managed with version control systems (Git)                                       |
| **Reusing templates (Modules)** | Modularity allows reusability and speedy deployment                                  |
### Terraform Multipurpose Composition
- Composes multiple tiers (**SaaS/PaaS/IaaS**) – all layers of system
- **Plugin-based architecture** using **providers** (plugins) to interact with different platforms
- Creates **resource graph** to understand dependencies and build systems safely (dependability)
### Terraform Architecture Components

| Component               | Description                                                                                      |
| ----------------------- | ------------------------------------------------------------------------------------------------ |
| **Core**                | Primary interface for Terraform users                                                            |
| **State file (JSON)**   | Stores current state, dependencies, and changes to be made                                       |
| **Variables (.tfvars)** | Manage variable assignments systematically                                                       |
| **Instances**           | Resources that can be created, updated, deleted (e.g., EC2 instance)                             |
| **Providers**           | Plugins interacting with services via external APIs; manage full lifecycle (CRUD)                |
| **Provisioners**        | Plugins executing scripts/commands on local/remote machine; handle post-deployment configuration |
### Terraform Workflow
1. **Write** configuration (.tf files describing desired state)
2. **Plan** (`terraform plan`) – previews changes
3. **Apply** (`terraform apply`) – creates/updates infrastructure
## Conclusion

- Reviewed cloud configuration management landscape
- IaC provisions, deploys, configures cloud infrastructure at **massive scale** (10,000+ machines)
- Presented **Terraform** as leading declarative provisioning tool
## Comparison Table: IaC vs Kubernetes

| Aspect               | IaC (e.g., Terraform)                             | Kubernetes                               |
| -------------------- | ------------------------------------------------- | ---------------------------------------- |
| **What it manages**  | Infrastructure (VMs, networks, storage, clusters) | Containers (pods, services, deployments) |
| **Scope**            | Provisioning cyberinfrastructure                  | Orchestrating application workloads      |
| **Declarative**      | Yes – desired state in .tf files                  | Yes – desired state in YAML              |
| **State management** | State file (JSON) tracks resources                | etcd stores cluster state                |
| **Example**          | Provision 10 VMs on AWS                           | Deploy 50 nginx pods across those VMs    |
## Quick Reference for This Lecture

| Term                    | Definition                                                           |
| ----------------------- | -------------------------------------------------------------------- |
| **IaC**                 | Infrastructure as Code – machine-readable infrastructure definitions |
| **Configuration drift** | Environments diverging from each other over time                     |
| **Declarative**         | Describe desired end-state, not steps to get there                   |
| **Terraform**           | Cloud-agnostic declarative provisioning tool                         |
| **HCL**                 | Hashicorp Configuration Language (Terraform syntax)                  |
| **State file**          | JSON file storing Terraform's view of infrastructure                 |
| **Provider**            | Terraform plugin for cloud/service API                               |
| **Provisioner**         | Terraform plugin for post-deployment scripts                         |
| **Module**              | Reusable Terraform component                                         |
| **Ansible**             | Agentless configuration management (SSH/WinRM)                       |
| **Puppet/Chef**         | Classic configuration management (master-agent)                      |
| **CloudFormation**      | AWS-native IaC                                                       |

**Exam traps**:
- **IaC ≠ Kubernetes** – IaC provisions the cluster; Kubernetes runs workloads **on** the cluster
- **Terraform** = declarative, cloud-agnostic; **CloudFormation** = AWS-specific
- **Ansible** = agentless (SSH); **Puppet/Chef** = master-agent architecture
- **State file** tracks what Terraform created – critical for updates/destruction
- **Configuration drift** eliminated by IaC (all environments identical)
# Lecture 12: Serverless Architectures
**Goals:** Understand the concept of serverless architectures
### Overview
- Introduction
- Definition
- Function as a Service
- Architectural Support
- Solutions – Commercial & Open Source
- Summary
## Introduction
> **Serverless computing** simply means that you, the developer, **do not have to deal with the server**.

**Core idea**: A serverless computing platform (like AWS Lambda) allows you to build your code and deploy it without ever needing to configure or manage underlying servers. **Your unit of deployment is your code** – not the container that hosts the code, or the server that runs the code, but simply the **code itself**.
## Definition
> **Serverless computing** = model where the existence of servers is **hidden from developers**.
> **FaaS (Function-as-a-Service)** = key mechanism by which a developer implements business logic in serverless architecture.

**What serverless provides**: simplicity, speed, and flexibility.
### IaaS, PaaS, SaaS, and FaaS – Where FaaS Fits

| Model    | What you manage                                                                | What provider manages                                                                 |
| -------- | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------- |
| **IaaS** | Apps, data, runtime, middleware, OS, virtualization, storage, network, servers | Physical hardware                                                                     |
| **PaaS** | Apps, data                                                                     | Runtime, middleware, OS, virtualization, storage, network, servers, physical hardware |
| **SaaS** | Just use the app                                                               | Everything else                                                                       |
| **FaaS** | Code (functions)                                                               | Everything else – including scaling, servers, runtime                                 |

> **You own and control the code you deploy!**
## Function as a Service (FaaS) – Core of Serverless Computing

**FaaS execution model**:

1. Developer writes a function (small piece of code)
2. Defines a trigger (HTTP request, queue message, database change, timer)
3. Platform handles everything else
> **When an event occurs**: Platform checks if function is already running (warm). If not (cold), platform loads function from data store, instantiates container, executes function, returns result.
### Cold Start vs Warm Start

|                     | Cold Start                          | Warm Start                                 |
| ------------------- | ----------------------------------- | ------------------------------------------ |
| **When**            | First run or after idle period      | Run again shortly after previous execution |
| **What happens**    | Platform must instantiate container | Reuses existing container                  |
| **Latency**         | **Extra latency penalty**           | Low latency                                |
| **User experience** | Delayed response                    | Fast response                              |

**Exam trap (2025 Q1h)**: Cold start overhead negatively impacts user experience – **True**.
## Serverless Applications

| Type                  | Examples                                            |
| --------------------- | --------------------------------------------------- |
| **Single-function**   | Amazon Alexa, image resizing                        |
| **Multiple-function** | IoT pipelines, image recognition, database analysis |
| **Emerging**          | Parallel processing, machine learning               |

**Function topologies**:
- **Linear topology** – functions call functions in sequence
- **Nested functions** – functions call other functions (composition)
### Serverless Functions vs Microservices

| Aspect          | Microservices                      | Serverless Functions                         |
| --------------- | ---------------------------------- | -------------------------------------------- |
| **Granularity** | Independent, long-running services | Single-purpose functions                     |
| **Lifetime**    | Long-running (always on)           | Short-lived, event-driven                    |
| **State**       | Can be stateful                    | **Stateless** (spins up only when triggered) |
| **Scaling**     | Manual or HPA-based                | **Instantaneously scalable**                 |
| **Pricing**     | Pay for running instances          | Pay per invocation/compute time              |

> Evolution: **Monoliths → Microservices → Functions (nanoservices)**
## Architectural Support – Serverless Execution Model

**Serverless computing platform responsibilities**:
1. Check if function is already running (warm)
2. If not running (cold): load function from data store, instantiate container
3. Execute function
4. Scale automatically based on event volume
5. Scale to **zero** when no events
## Solutions – Commercial and Open Source

| Type            | Examples                                                                                       |
| --------------- | ---------------------------------------------------------------------------------------------- |
| **Commercial**  | AWS Lambda, Google Cloud Functions, Microsoft Azure Functions, IBM Cloud Functions (OpenWhisk) |
| **Open Source** | Apache OpenWhisk, OpenFaaS, Knative, Iron.io, Fission                                          |
### AWS Lambda – In Practice
> **AWS Lambda** = Amazon's FaaS offering.

**Key characteristics**:
- When container created first time → **initialisation penalty (cold start)**
- After that → **quicker (warm start)**
- Triggers: API Gateway, S3, SQS, DynamoDB, CloudWatch events, etc.
- Supported languages: Node.js, Python, Java, Go, Ruby, C# (.NET)

**Exam trap (2025 Q1g)**: Lambda execution model = **invoked and executed only when an event occurs** (not continuously running).
### Microsoft Azure Functions

| Feature                       | Description                                                                                 |
| ----------------------------- | ------------------------------------------------------------------------------------------- |
| **Event-driven**              | Activated by triggers (HTTP, timers, queues, events)                                        |
| **Bindings**                  | Declarative integration with services (Cosmos DB, HTTP, Storage) – reduce repetitive coding |
| **Stateless execution**       | Each invocation independent; state externalised to storage                                  |
| **Consumption-based billing** | Pay for actual executions and compute time                                                  |
| **Hosting plans**             | Consumption, Premium, Dedicated                                                             |
| **Deployment**                | Code packages (.zip), containers, CI/CD pipelines                                           |
| **Languages**                 | C#, JavaScript/Node.js, Python, Java, PowerShell                                            |
| **Scaling**                   | Automatic horizontal scaling based on event volume                                          |
| **Ecosystem integration**     | Event Grid, Service Bus, Storage Queues, Logic Apps                                         |
| **Monitoring**                | Application Insights (logging, metrics, distributed tracing)                                |
| **Continuous deployment**     | GitHub, Bitbucket, Azure Repos                                                              |
| **Testing**                   | Manual trigger in Azure portal                                                              |
### OpenFaaS – Architecture
> **OpenFaaS** = open-source FaaS platform built on **Kubernetes**.

**Key characteristics**:
- Provides compute management and automatic scaling through PaaS/FaaS
- Each function or microservice = **immutable Docker container** managed by Kubernetes
- **NATS** = lightweight, high-performance messaging system for cloud-native systems (message durability, replay, at-least-once delivery)
### Knative – Architecture
> **Knative** = Kubernetes-based platform for serverless workloads. Two main pillars: **Knative Serving** (HTTP-triggered) and **Knative Eventing** (event-driven).
#### Knative Serving Components

| Component                 | Function                                                                                       |
| ------------------------- | ---------------------------------------------------------------------------------------------- |
| **Configuration**         | Desired state (container image, environment variables); updates create new Revision            |
| **Revision**              | Immutable snapshot of code and configuration; versioned unit                                   |
| **Route**                 | Traffic policy ("90% → Revision A, 10% → Revision B")                                          |
| **Service** (Knative)     | Logical config object combining Configuration and Route                                        |
| **Ingress** (Istio/other) | Handles network traffic, mTLS, routing rules, telemetry                                        |
| **Activator**             | Intercepts traffic for scaled-to-zero services; queues requests; tells Autoscaler to start Pod |
| **Autoscaler**            | Watches concurrency; adjusts Pod count (scales up/down, even to zero)                          |
| **Queue Proxy**           | Sidecar container in each Pod; gathers metrics; enforces concurrency limit                     |
#### Knative Autoscaling

| Autoscaler                          | Based on            | Supports scale-to-zero? |
| ----------------------------------- | ------------------- | ----------------------- |
| **HPA** (Horizontal Pod Autoscaler) | CPU/memory metrics  | **No**                  |
| **KPA** (Knative Pod Autoscaler)    | Request concurrency | **Yes**                 |

> **PodAutoscaler** defines policy; **Autoscaler** enforces using KPA or HPA.
#### Knative Eventing
> **Event-driven communication** flow: **Source → Broker → Trigger → Service**

**Note**: Route is used only in Knative Serving, not in Eventing.
## Summary / Conclusion

| Key Takeaway                 | Description                                                                    |
| ---------------------------- | ------------------------------------------------------------------------------ |
| **Serverless architectures** | Employ **nanoservices** (vs microservices) to increase scalability, lower cost |
| **FaaS**                     | Core mechanism – functions as deployment unit                                  |
| **Cold start**               | Key challenge (latency penalty for idle functions)                             |
| **Scale-to-zero**            | Unique serverless capability (no cost when idle)                               |
| **Commercial**               | AWS Lambda, Azure Functions, Google Cloud Functions                            |
| **Open source**              | Knative, OpenFaaS, OpenWhisk                                                   |
## Comparison Table: Serverless vs Containers vs VMs

| Aspect                   | Serverless (FaaS)             | Containers                     | Virtual Machines           |
| ------------------------ | ----------------------------- | ------------------------------ | -------------------------- |
| **Unit of deployment**   | Function (code)               | Container image                | VM image                   |
| **Server management**    | None (provider)               | Cluster management (K8s)       | Hypervisor + VIM           |
| **Scaling**              | Automatic, per invocation     | HPA (pods), Cluster Autoscaler | VIM scheduling             |
| **Scale-to-zero**        | **Yes**                       | No (min replicas usually 1)    | No                         |
| **Cold start**           | **Yes** – latency penalty     | No                             | No (but boot time minutes) |
| **State**                | Stateless (external storage)  | Stateful possible              | Stateful possible          |
| **Billing**              | Per invocation + compute time | Pay for running instances      | Pay for running VMs        |
| **Execution time limit** | Yes (e.g., 15 min Lambda)     | No                             | No                         |
## Quick Reference for This Lecture

| Term                | Definition                                                     |
| ------------------- | -------------------------------------------------------------- |
| **Serverless**      | Servers hidden from developer                                  |
| **FaaS**            | Function as a Service – core serverless mechanism              |
| **Cold start**      | First invocation latency (container instantiation)             |
| **Warm start**      | Subsequent invocation (reusing container)                      |
| **Nanoservices**    | Even finer granularity than microservices (functions)          |
| **AWS Lambda**      | Commercial FaaS from Amazon                                    |
| **Azure Functions** | Commercial FaaS from Microsoft                                 |
| **Knative**         | Kubernetes-native serverless platform (Serving + Eventing)     |
| **OpenFaaS**        | Open-source FaaS on Kubernetes                                 |
| **KPA**             | Knative Pod Autoscaler (concurrency-based, scale-to-zero)      |
| **HPA**             | Horizontal Pod Autoscaler (CPU/memory-based, no scale-to-zero) |
| **Activator**       | Knative component handling scale-to-zero traffic               |
| **Queue Proxy**     | Sidecar for concurrency limiting and metrics                   |

**Exam traps**:
- **2025 Q1g**: AWS Lambda = event-triggered execution (not continuous)
- **2025 Q1h**: Cold start negatively impacts user experience – **True**
- **Cold start vs warm start**: Know the difference (latency penalty for first invocation)
- **FaaS vs PaaS**: FaaS is even more abstracted – no runtime management at all
- **Knative KPA vs HPA**: KPA supports scale-to-zero (concurrency-based); HPA does not
# Lecture 13: Cloud Programming Landscape
**Goals:** Present the cloud programming landscape
### Overview
- Introduction
- Cloud Service Lifecycle
- Cloud Programming – Models
- MPI and OpenMP
- MapReduce and Hadoop
- TensorFlow
- Other frameworks
- Amazon Web Services
- Conclusion
## Introduction
### Cloud Applications – Three Categories

| Category                         | Examples                                       |
| -------------------------------- | ---------------------------------------------- |
| **Scientific/Tech Applications** | Simulations, data analysis, research computing |
| **Business Applications**        | CRM, ERP, supply chain, financial systems      |
| **Consumer/Social Applications** | Social media, gaming, streaming, e-commerce    |
## Cloud Service Lifecycle (Revisited)
> Cloud service development workflow:

1. **Develop the service logic** – Build applications that provide functionality to end-users. Use programming models that simplify distributed service creation (MapReduce, MPI).

2. **Prepare execution environments** – Create and configure VM images (or container images) to host the implemented service. Ensure environment includes all runtime libraries and dependencies.

3. **Define service requirements** – Specify functional and non-functional parameters:
   - Capacity (CPU, memory, storage, throughput)
   - Location or placement constraints
   - Energy-efficiency or sustainability constraints
## Cloud Programming – Models

Frameworks are empirically classified into categories:

1. **High Performance Computing**
   - **MPI** (Message Passing Interface)
   - **OpenMP** (Open Multi-Processing)

2. **Non-general purpose programming models**
   - **MapReduce** – big data
   - **TensorFlow** – library for Machine Learning
   - Platforms/frameworks for distributed cloud applications

3. **New APIs to develop applications**
   - Azure, Google App Engine, AWS
### The Case for Go (Golang)
> **Go** = programming language by Google. Language of choice for cloud projects like **Docker** and **Kubernetes**.

**Key features**: concurrent operations, exploits cloud provisioning models. Designed to improve upon C++.
## Example 1: High Performance Computing
### Historical Problem

- Most interconnection networks shipped with **proprietary communication libraries** (expensive, incompatible)
- Portability across architectures was difficult
- Need for **hardware-independent** solution
### MPI (Message Passing Interface)
> **MPI** = standard for parallel applications in high-performance and distributed computing.

| Characteristic          | Description                                                                                       |
| ----------------------- | ------------------------------------------------------------------------------------------------- |
| **Network usage**       | Direct use of underlying physical network; optimised for fast interconnects                       |
| **Communication scope** | Within known group of processes (communicator, e.g., `MPI_COMM_WORLD`)                            |
| **Communication model** | **Explicit message passing** (send/receive, collective calls: broadcast, scatter, gather, reduce) |
| **Memory model**        | **No shared memory** – each process has own memory space                                          |
| **Portability**         | **Portable programming standard** – vendors implement API for diverse hardware                    |
| **Scalability**         | Efficient from few processes to thousands of nodes                                                |

**Message-passing model**: Data transfer + synchronisation. Requires cooperation of sender and receiver.

**Primitives**: `MPI_send`, `MPI_recv`, `MPI_Bcast`, `MPI_Scatter`, `MPI_Gather`, `MPI_Reduce`
### OpenMP
> **OpenMP** = shared memory alternative to MPI. API for multi-threaded parallelisation.

**Components**: Source code directives, functions, environment variables.

**Memory model**: Process spawns additional threads within **same memory address space**.

|                   | MPI                                   | OpenMP                        |
| ----------------- | ------------------------------------- | ----------------------------- |
| **Memory**        | Distributed (each process own memory) | Shared (threads share memory) |
| **Communication** | Explicit message passing              | Implicit (shared variables)   |
| **Programming**   | Harder (coordination required)        | Easier (directives)           |
| **Scalability**   | Excellent (thousands of nodes)        | Limited to single node        |
## Example 2: MapReduce and Hadoop
### MapReduce
> **MapReduce** = programming model for fast processing of large datasets. Applied in Web-scale search and cloud computing.

**Users specify**:
- **Map function** – generates intermediate key/value pairs
- **Reduce function** – merges all intermediate values with the same key
### Hadoop
> **Hadoop** = open-source platform for large-scale distributed data processing. Created in Nutch project, expanded at Yahoo.

**Attractive features**:

| Feature        | Description                                                               |
| -------------- | ------------------------------------------------------------------------- |
| **Big data**   | Write and run applications over vast distributed data                     |
| **Scalable**   | Store and process petabytes of data                                       |
| **Economical** | Open-source MapReduce minimises overheads                                 |
| **Efficient**  | High-degree of parallelism across commodity nodes                         |
| **Reliable**   | Automatically maintains multiple data copies; redeploys tasks on failures |

*(More detail in Lectures 14-15 on Big Data)*
## Example 3: TensorFlow
> **TensorFlow** = programming model and execution framework for Machine Learning. Open-source numerical computation library developed by Google Brain Team.

**Core idea**: Computation as a **data-flow graph**.
- **Nodes** = operations (with zero or more inputs/outputs)
- **Edges** = **tensors** (multi-dimensional arrays) flowing between operations

**Enables**: parallelism, distribution, optimisation of computation.
### TensorFlow Graph Elements

| Element         | Description                                                                        |
| --------------- | ---------------------------------------------------------------------------------- |
| **Placeholder** | Node whose value is fed in at execution time (e.g., input X)                       |
| **Variable**    | Stateful node retaining value across multiple executions (e.g., weights W, bias b) |
| **Operation**   | Combines inputs and parameters (e.g., MatMul, Add, ReLU)                           |

**Example**: Neural network with one hidden layer – `h = ReLU(Wx + b)`
- `x` = Placeholder
- `W`, `b` = Variables
- `MatMul`, `Add`, `ReLU` = Operations
## Example 4: Amazon Web Services (AWS) – Cloud APIs
### AWS Cloud Control APIs
> Make it easy for developers to manage lifecycle of AWS and third-party services. Provide **five operations** for infrastructure: **Create, Read, Update, Delete, List (CRUDL)** .
### AWS Parallel Programming Offerings

| Service                         | Description                                                                                                          |
| ------------------------------- | -------------------------------------------------------------------------------------------------------------------- |
| **EC2** (Elastic Compute Cloud) | Resizable compute capacity; makes web-scale cloud computing easy                                                     |
| **S3** (Simple Storage Service) | Secure, durable, highly-scalable **object storage**; 1B – 5GB per object; 99.99% availability; geographic redundancy |
| **EBS** (Elastic Block Store)   | Persistent block-level storage volumes for EC2; automatically replicated                                             |
### Amazon Machine Images (AMI)
> **AMI** = blueprint (predefined template) for EC2 instances – defines OS, software, configuration.

| AMI Type    | Description                                                         |
| ----------- | ------------------------------------------------------------------- |
| **Private** | Created by you; private by default; can grant access to other users |
| **Public**  | Released to AWS community; anyone can launch instances              |
| **Paid**    | Commercial AMIs offered by third parties; pay per hour of usage     |

**When you launch an instance**: AWS clones the AMI, creating a fresh VM with same setup. Ensures consistency and scalability.
## Other Frameworks (Brief)

| Framework             | Purpose                                        |
| --------------------- | ---------------------------------------------- |
| **Azure SDK**         | Develop cloud applications for Microsoft Azure |
| **Google App Engine** | PaaS for building scalable web applications    |
| **OpenStack APIs**    | Programmatic access to OpenStack resources     |
## Conclusion

- Reviewed cloud programming landscape
- Classified frameworks for cloud application development:
  - **HPC**: MPI (distributed memory), OpenMP (shared memory)
  - **Big Data**: MapReduce/Hadoop
  - **ML/AI**: TensorFlow
  - **Cloud APIs**: AWS (EC2, S3, EBS, Cloud Control APIs)
## Comparison Table: MPI vs OpenMP vs MapReduce vs TensorFlow

| Aspect          | MPI                   | OpenMP                  | MapReduce                       | TensorFlow               |
| --------------- | --------------------- | ----------------------- | ------------------------------- | ------------------------ |
| **Paradigm**    | Message passing       | Shared memory           | Data-parallel                   | Data-flow graph          |
| **Memory**      | Distributed           | Shared                  | Distributed (HDFS)              | Distributed (optional)   |
| **Granularity** | Process               | Thread                  | Task (Map/Reduce)               | Operation                |
| **Best for**    | HPC simulations       | Single-node parallelism | Batch data processing           | Machine Learning         |
| **Cloud use**   | HPC on cloud clusters | Limited to single VM    | Big data analytics              | AI/ML training/inference |
| **Languages**   | C, Fortran, Python    | C, C++, Fortran         | Java, Python (Hadoop Streaming) | Python, C++              |
## Quick Reference for This Lecture

| Term                      | Definition                                                          |
| ------------------------- | ------------------------------------------------------------------- |
| **MPI**                   | Message Passing Interface – distributed memory parallel programming |
| **OpenMP**                | Open Multi-Processing – shared memory parallel programming          |
| **Communicator**          | MPI group of processes (e.g., `MPI_COMM_WORLD`)                     |
| **Collective operations** | Broadcast, scatter, gather, reduce                                  |
| **MapReduce**             | Map (key/value) + Reduce (aggregate) programming model              |
| **Hadoop**                | Open-source MapReduce platform                                      |
| **TensorFlow**            | ML data-flow graph framework (Google)                               |
| **Tensors**               | Multi-dimensional arrays flowing between operations                 |
| **Placeholder**           | Input node (value fed at execution)                                 |
| **Variable**              | Stateful node (weights/biases)                                      |
| **AMI**                   | Amazon Machine Image – EC2 blueprint                                |
| **EC2**                   | Elastic Compute Cloud (VMs)                                         |
| **S3**                    | Simple Storage Service (objects)                                    |
| **EBS**                   | Elastic Block Store (block storage)                                 |
| **CRUDL**                 | Create, Read, Update, Delete, List (Cloud Control APIs)             |

**Exam traps**:
- **MPI** = distributed memory (each process has own memory) → explicit message passing
- **OpenMP** = shared memory (threads share address space) → directives
- **MPI is portable standard** – not tied to specific vendor hardware
- **Go language**: used by Docker and Kubernetes (exam may ask which language cloud projects use)
- **AMI types**: Private (you), Public (community), Paid (commercial)
- **S3**: object storage (not block storage – that's EBS); 1B–5GB per object
# Lecture 14: Introduction to Big Data Systems
**Goals:**
- Appreciate the generation and use of big data through examples
- Understand the technology landscape
- Understand key concepts in a big-data architecture
- Introduction to MapReduce and Hadoop
### Overview
- Introduction
- Big data classification
- Technology landscape
- Layered Architecture Overview
- MapReduce
- Hadoop
- Conclusion
## Introduction
### Data Everywhere – Current Scales

| Company          | Data Scale                                |
| ---------------- | ----------------------------------------- |
| Google           | 15+ exabytes stored, processes 100 PB/day |
| Facebook         | 300 PB user data, processes 600 TB/day    |
| YouTube          | 90 PB stored, processes 100 PB/day        |
| Global (by 2025) | 400 exabytes generated **per day**        |

> **1 exabyte = 10¹⁸ bytes** (1,000 petabytes)
## Big Data Classification
### Data Types

| Type                | Description                                           | Examples                                   |
| ------------------- | ----------------------------------------------------- | ------------------------------------------ |
| **Structured**      | Fixed format (tables, columns, rows)                  | SQL databases, numbers, dates              |
| **Unstructured**    | No predefined organisation                            | Free text, images, videos, audio           |
| **Semi-structured** | Some organisation, not as rigid as tables             | JSON, XML, emails (header + body)          |
| **Relational**      | Typically structured                                  | Tables/transactions/legacy RDBMS           |
| **Text data**       | Often unstructured                                    | HTML pages, blogs, social posts, documents |
| **Graph data**      | Usually semi-structured (nodes/edges with properties) | Social network, Semantic Web               |
| **Streaming data**  | Can be any type; high-velocity event streams          | IoT sensor data, clickstreams              |

**Exam trap (2024 Q1i)**: "Which type of data falls under 'unstructured data'?" – **C. Emails, social media posts, and images** (not relational databases, spreadsheets, or sensor data – those are structured or semi-structured).
### What "Big Data" Means
> **Big Data** = extremely large collections of structured, semi-structured, and unstructured data that grow exponentially.

**Why traditional systems fall short**:
- Older database tools could not store or analyse such large and varied datasets
- Smartphones exceeded 300 million worldwide by 2010 → accelerated digital data generation

**Why it matters**: Big data technologies enable **scalable, timely processing, analysis, visualisation, and knowledge extraction**.
## The 5 Vs of Big Data (Exam-Ready)
> The **5 Vs** characterise big data challenges. **Exam may ask to apply these to a scenario** (e.g., 2025 Q2a – Netflix video streaming service).

| V            | Definition                                                          | Example (Netflix)                                                                                                                            |
| ------------ | ------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------- |
| **Volume**   | Enormous quantity of data generated                                 | Millions of users watching billions of hours; petabytes of video content                                                                     |
| **Velocity** | High speed of data generation and processing                        | Real-time viewing data, clickstreams, recommendations need near-instant processing                                                           |
| **Variety**  | Different types of data (structured, semi-structured, unstructured) | User profiles (structured), video metadata (semi-structured), viewing history (structured), reviews (unstructured text), thumbnails (images) |
| **Veracity** | Quality and accuracy of data                                        | Data quality issues – duplicate accounts, incorrect viewing metrics, bot traffic                                                             |
| **Value**    | Extracting meaningful insights for business benefit                 | Personalised recommendations, content investment decisions, churn prediction                                                                 |
### Big Data Use Cases

| Domain                    | Applications                                                                               |
| ------------------------- | ------------------------------------------------------------------------------------------ |
| **Business Intelligence** | Data-driven decision making, customer insights and personalisation, operational efficiency |
| **Environmental Impact**  | Climate modelling, smart cities, intelligent transport, datacenter energy/cooling          |
| **Knowledge Discovery**   | Machine learning/AI, scientific research, healthcare                                       |
| **Monetary Value**        | Financial trading, fraud detection, personalised offers                                    |
## Technology Landscape
### Desired Big Data System Properties

| Property                         | Description                         |
| -------------------------------- | ----------------------------------- |
| **Schema flexibility**           | Handle evolving data structures     |
| **Distributed processing**       | Scale across many machines          |
| **High throughput**              | Process large volumes quickly       |
| **Robustness & fault tolerance** | Survive failures without restarting |
| **Low-latency reads/updates**    | Respond quickly when needed         |
| **Scalability**                  | Grow with data volume               |
| **Generalisation**               | Handle many use cases               |
| **Extensibility**                | Add new functionality               |
| **Ad-hoc queries**               | Support unplanned queries           |
| **Minimal maintenance**          | Reduce operational burden           |
| **Debuggability**                | Troubleshoot when things fail       |
| **Security & access control**    | Protect data                        |
## Layered Architecture Overview
### Six Layers of Big Data Architecture

| Layer                              | Function                                                             |
| ---------------------------------- | -------------------------------------------------------------------- |
| **1. Data Collection & Ingestion** | IoT devices, sensors, mobile apps, logs; streaming or bulk ingestion |
| **2. Data Storage**                | Distributed, scalable storage for raw and processed data             |
| **3. Data Processing**             | Transformation & cleansing (batch processing, real-time processing)  |
| **4. Data Analysis**               | Data mining, machine learning, statistical models                    |
| **5. Visualisation & Insights**    | Dashboards, reports, KPIs, alerts, recommendations                   |
| **6. Orchestration & Governance**  | Pipelines, metadata, security, access control, compliance            |
### Logical Layers with Verticals

| Layer                        | Description                                                                                       |
| ---------------------------- | ------------------------------------------------------------------------------------------------- |
| **Big Data sources**         | All data available for analysis (format, velocity, volume, real-time vs batch, internal/external) |
| **Data messaging and store** | Acquires data from sources; sends to ingestion or storage; possibly converts format               |
| **Analysis layer**           | Produces desired analytics; derives insight; determines algorithms and tools                      |
| **Consumption layer**        | Consumes output (dashboards, apps, APIs)                                                          |
### Vertical Concerns (Cross-cutting)

| Concern                      | Description                                                                                              |
| ---------------------------- | -------------------------------------------------------------------------------------------------------- |
| **Information Integration**  | Connectors, adapters, communication protocols, APIs, web services                                        |
| **Big Data Governance**      | Legal concerns, data ownership, storage conditions, security, privacy, compliance, accountability (GDPR) |
| **Quality of Service (QoS)** | Service downtime, timeliness, availability, reliability                                                  |
| **Infrastructure**           | Cloud or any other infrastructure                                                                        |
## MapReduce
### The Problem MapReduce Solves
> **Problem**: Data kept growing beyond what a single machine could process quickly. One machine = limited CPU, memory, storage, I/O.

**Requirements**:
- Split job across many machines and still get one correct answer
- Survive machine failures without starting again
- Store data resiliently and access it quickly
### Core Ideas of MapReduce
> **MapReduce** = programming model with two small functions: **map** and **reduce**.

| Function           | Description                                                       |
| ------------------ | ----------------------------------------------------------------- |
| **Map**            | Process chunks of input independently; output **key-value pairs** |
| **Shuffle & Sort** | Group all values that share the same key (system handles)         |
| **Reduce**         | Combine values per key to produce results                         |
### MapReduce Dataflow

```
Input → Map → (key, value) pairs → Shuffle & Sort (by key) → Reduce → Output
```

**Analogy (kitchen)** :
- **Map** = Many cooks chop different piles of vegetables at the same time
- **Shuffle & Sort** = All chopped carrots end up in one bowl, onions in another
- **Reduce** = Chef counts amounts in each bowl for final dishes
### Key Characteristics

| Characteristic                  | Description                                                                     |
| ------------------------------- | ------------------------------------------------------------------------------- |
| **Abstraction**                 | Hides parallelisation, fault tolerance, data distribution, load balancing       |
| **Computation**                 | Done locally on distributed nodes (commodity hardware)                          |
| **Fault-tolerant**              | Data stored with multiple copies; another node can read same split if one fails |
| **Stateless, idempotent tasks** | Map and Reduce can be rerun elsewhere and produce same output                   |
| **History**                     | Originally developed by **Google**                                              |
| **Open-source**                 | **Hadoop** implementation                                                       |
## Hadoop
> **Hadoop** = open-source framework under Apache Software Foundation. First developed by **Yahoo!**

**Well-suited for**: VOLUME and VARIETY in big data.

**Use cases**: Retail & e-commerce, healthcare, finance, web search engines.

**Two main components**:
1. **Distributed Processing Framework** – MapReduce
2. **Distributed File System** – **HDFS** (Hadoop Distributed File System)
## Conclusion

- Introduced big-data systems and technology landscape
- Big data and cloud computing are complementary
- Architecture of big data systems (layered approach)
- MapReduce = programming model hiding distributed complexity
- Hadoop = open-source MapReduce + HDFS
## Quick Reference for This Lecture

| Term                     | Definition                                                  |
| ------------------------ | ----------------------------------------------------------- |
| **Big Data**             | Extremely large collections of data that grow exponentially |
| **5 Vs**                 | Volume, Velocity, Variety, Veracity, Value                  |
| **Structured data**      | Fixed format (tables, columns, rows)                        |
| **Unstructured data**    | No predefined organisation (text, images, video)            |
| **Semi-structured data** | Some organisation (JSON, XML, emails)                       |
| **Map**                  | Function processing input chunks into key-value pairs       |
| **Reduce**               | Function combining values by key                            |
| **Shuffle & Sort**       | System groups values by key, routes to same reducer         |
| **Hadoop**               | Open-source MapReduce + HDFS                                |
| **HDFS**                 | Hadoop Distributed File System                              |

**Exam traps**:
- **2024 Q1i**: Unstructured data = emails, social media posts, images (C)
- **2025 Q2a**: Apply 5 Vs to a scenario (e.g., Netflix)
- **MapReduce** = two functions (map, reduce); system handles shuffle/sort
- **Hadoop** = open-source MapReduce (originally Google, implemented by Yahoo!)
# Lecture 15: Evolution of Hadoop and Spark
**Goals:** Understand evolution of original Hadoop
### Plan
- Hadoop Architecture
- Limitations
- HDFS Federation
- YARN
- Spark
- Summary
## Hadoop Architecture (Hadoop 1.0)
### Two Main Components

| Component                                 | Function                 |
| ----------------------------------------- | ------------------------ |
| **HDFS** (Hadoop Distributed File System) | Storage layer            |
| **MapReduce**                             | Compute/processing layer |
### HDFS (Storage Layer)

**Characteristics**:
- Cluster of hundreds or thousands of commodity computers
- Average file size > 500MB; **block size = 128MB** (default)
- File replicas (x3) stored across nodes in different racks
- **Rack-awareness** to avoid data unavailability
- **"Write Once, Read Often"** model of data access
- Controller/Worker architecture (NameNode & DataNode)

| HDFS Component | Function                                                                                                                                         |
| -------------- | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| **NameNode**   | Keeps track of names and locations of all files and blocks (filesystem directory and index); manages system metadata; coordinates with DataNodes |
| **DataNode**   | Stores actual file blocks on disk; sends heartbeats and block reports to NameNode                                                                |
### MapReduce (Compute Layer)

| Component        | Function                                                                                                                                           |
| ---------------- | -------------------------------------------------------------------------------------------------------------------------------------------------- |
| **JobTracker**   | Accepts MapReduce jobs; coordinates with NameNode for input data splits; schedules tasks on TaskTrackers; tracks progress and failures             |
| **TaskTracker**  | Runs map and reduce tasks on DataNodes; sends heartbeats to JobTracker; **executes tasks on same node where block is stored** (high data locality) |
| **Map slots**    | Number of map tasks a TaskTracker can run in parallel                                                                                              |
| **Reduce slots** | Number of reduce tasks a TaskTracker can run in parallel                                                                                           |
### Hadoop 1.0 Definitions

| Term     | Definition                                                                        |
| -------- | --------------------------------------------------------------------------------- |
| **Job**  | Whole MapReduce computation (program + input dataset + configuration + all tasks) |
| **Task** | Single unit of work within a job (map task or reduce task)                        |
## Limitations of Hadoop 1.0

| Limitation                           | Description                                                                                                        |
| ------------------------------------ | ------------------------------------------------------------------------------------------------------------------ |
| **Single point of failure**          | JobTracker and NameNode were single points of failure                                                              |
| **Scalability issues**               | Scaled to ~5,000 nodes, ~40,000 concurrent tasks (JobTracker bottleneck); NameNode RAM limited total files/blocks  |
| **Inefficient resource utilisation** | Map slots could be "full" while reduce slots "empty" – slots dedicated to only one task type                       |
| **Rigid programming model**          | Poor fit for iterative (machine learning) and interactive processing; difficulty expressing complex data pipelines |
## Hadoop 2.0 Improvements
> Hadoop 2 moves from restricted batch-oriented model to **multi-purpose platform** (batch, interactive, online, streaming). 2× throughput with same hardware.

**Major changes**:
- HDFS High Availability
- HDFS Federation
- **YARN** (Yet Another Resource Negotiator)
- Container concept
- Highly available NameNode
### HDFS High Availability
> **Problem**: In Hadoop 1, single NameNode was single point of failure.

**Solution in Hadoop 2**: Run **two redundant NameNodes** in same cluster in **Active/Passive** configuration.
### HDFS Federation
> **Problem**: Even with HA, two NameNodes alone do not provide horizontal scalability.

**Solution**: **Federate multiple independent NameNodes**.

**Key points**:
- Federated NameNodes are **independent** – no coordination required
- DataNodes serve as **common storage** for all NameNodes
- Each DataNode registers with all NameNodes in cluster
- Each DataNode sends heartbeats, block reports, handles commands from all NameNodes
### YARN (Yet Another Resource Negotiator)
> **Fundamental idea**: **Decouple cluster resource management from data processing frameworks**.

**Key benefit**: Many different types of applications can be submitted to YARN (not just MapReduce). More jobs run in parallel; scalability dramatically increased.
#### YARN Components

| Component                                   | Function                                                                                                                                     |
| ------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------- |
| **ResourceManager (RM)**                    | Central authority; accepts application submissions; allocates cluster resources; schedules work across all nodes                             |
| **Scheduler** (within RM)                   | Allocates resources to running applications; does NOT monitor or restart them                                                                |
| **ApplicationsManager Service (AMService)** | Manages application submission; starts each ApplicationMaster; handles application lifecycle                                                 |
| **NodeManager (NM)**                        | Per-node daemon; monitors local resources; manages container lifecycle (start, stop, clean-up); sends heartbeats to RM                       |
| **ApplicationMaster (AM)**                  | Per-application coordinator; runs in container on NodeManager; negotiates resources with RM; coordinates tasks (does NOT execute job itself) |
| **Container**                               | Resource allocation (CPU, memory) on a NodeManager; where tasks actually run                                                                 |

**Example ApplicationMasters**:
- **MR AM** = ApplicationMaster for MapReduce (negotiates containers for mappers and reducers)
- **MPI AM** = ApplicationMaster for MPI applications on YARN
## Apache Spark
> **Apache Spark** = general-purpose data processing engine. Originated at UC Berkeley AMPLab (2009) to be **faster and more flexible than Hadoop MapReduce**.

**Key features**:
- Designed for: faster batch processing, interactive query processing, streaming data, iterative algorithms (machine learning)
- **In-memory computation engine**
- Almost **100× faster** than Hadoop MapReduce with in-memory computations
- Almost **10× faster** using disk I/O
### Spark Architecture – Three Layers

| Layer                         | Description                                                                             |
| ----------------------------- | --------------------------------------------------------------------------------------- |
| **Resource Management Layer** | Includes own lightweight cluster manager; can integrate with YARN, Mesos, or Kubernetes |
| **Ecosystems Layer**          | Libraries operating on Spark Core (SQL, MLlib, Streaming, GraphX)                       |
| **Core Layer**                | Generalised layer; defines basic functions; all other functionalities built on top      |
### Spark Core Concepts

| Concept                                 | Description                                                                                                       |
| --------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| **Driver**                              | User code running on driver (Scala, Python, Java, R); calls Spark APIs; produces DataFrame plans and RDD lineages |
| **RDD** (Resilient Distributed Dataset) | Immutable, fault-tolerant, distributed collections of data elements; can be operated on in parallel               |
| **DataFrame API**                       | Parses operations; builds/optimises logical plan; creates physical plan; passes to Spark Core                     |
| **Directed Acyclic Graph (DAG)**        | Graphs of stages and tasks with one-way dependencies; Spark Core turns plans into DAGs                            |
| **Executors**                           | Run tasks in parallel; keep data in memory (enables fast distributed processing); requested from Resource Manager |
### Spark Data Flow

```
Driver (user code) → DataFrame plans + RDD lineages → DataFrame API (logical plan → physical plan) → Spark Core (DAG of stages/tasks) → Executors (run tasks, keep data in memory)
```
## Comparison Table: Hadoop 1.0 vs Hadoop 2.0 (YARN) vs Spark

| Feature                  | Hadoop 1.0              | Hadoop 2.0 (YARN)                          | Spark                                    |
| ------------------------ | ----------------------- | ------------------------------------------ | ---------------------------------------- |
| **Resource management**  | JobTracker (monolithic) | ResourceManager + NodeManager              | Own manager or YARN/Mesos/K8s            |
| **Processing model**     | MapReduce only          | Multiple frameworks (MapReduce, MPI, etc.) | Batch, interactive, streaming, iterative |
| **Storage**              | HDFS (disk-based)       | HDFS (disk-based)                          | In-memory + disk                         |
| **Speed**                | Baseline                | ~2× throughput                             | 10–100× faster (in-memory)               |
| **Fault tolerance**      | Task re-execution       | Task re-execution                          | RDD lineage (recompute)                  |
| **Programming model**    | Rigid (map/reduce)      | Flexible                                   | Unified APIs (SQL, ML, streaming)        |
| **Iterative processing** | Poor (many disk writes) | Poor                                       | Excellent (in-memory caching)            |
## Quick Reference for This Lecture

| Term                  | Definition                                                                       |
| --------------------- | -------------------------------------------------------------------------------- |
| **HDFS**              | Hadoop Distributed File System (storage layer)                                   |
| **NameNode**          | HDFS master – manages metadata (single point of failure in 1.0)                  |
| **DataNode**          | HDFS worker – stores actual data blocks                                          |
| **JobTracker**        | Hadoop 1.0 master – schedules MapReduce jobs                                     |
| **TaskTracker**       | Hadoop 1.0 worker – runs map/reduce tasks                                        |
| **YARN**              | Yet Another Resource Negotiator – decouples resource management from processing  |
| **ResourceManager**   | YARN central authority                                                           |
| **NodeManager**       | YARN per-node daemon                                                             |
| **ApplicationMaster** | YARN per-application coordinator                                                 |
| **Container**         | YARN resource allocation (CPU, memory)                                           |
| **HDFS Federation**   | Multiple independent NameNodes sharing DataNodes                                 |
| **Spark**             | In-memory general-purpose data processing engine                                 |
| **RDD**               | Resilient Distributed Dataset – immutable, fault-tolerant distributed collection |
| **DAG**               | Directed Acyclic Graph – stages and tasks with one-way dependencies              |
| **Driver**            | Spark process running user code                                                  |
| **Executor**          | Spark worker process running tasks, caching data                                 |

**Exam traps**:
- **Hadoop 1.0** = JobTracker + TaskTracker; **Hadoop 2.0** = ResourceManager + NodeManager (YARN)
- **HDFS Federation** = multiple NameNodes (not just HA – that's Active/Passive)
- **YARN decouples** resource management from processing (can run non-MapReduce applications)
- **Spark** = in-memory (100× faster than Hadoop MapReduce) – **2025 Q1j**: key difference = **D. All of the above**
- **RDDs** are immutable, fault-tolerant, distributed – can be cached in memory
- **MapReduce output count (2025 Q1i)** : number of output files = **r** (reducers), not m or m×r
# Lecture 16: Energy Efficiency in Clouds – Part I
**Goals:** Understand concepts surrounding energy efficiency in clouds
### Overview
- Introduction
- Powering the Cloud Infrastructure: Energy Consumption, Costs, Implications
- Power-Aware Computing: Trends and Issues
- The role of hardware
- The role of software
- Towards energy efficient Clouds
- Review of energy efficiency metrics
- Conclusion
## Introduction
### Ordinary Things, Extraordinary Energy Cost
> Every internet activity (liking on Facebook, streaming movies, posting on Instagram) involves huge amounts of data processed/stored somewhere.

**Driverless cars** – example of "internet of everything" driving further data centre growth.
> The vast network of cloud data centres that have sprouted in the past decade will continue to spread.
## Powering the Cloud Infrastructure: Energy Consumption, Costs, Implications
### Cloud Data Centre Workloads

| Workload Type     | Examples                                                     |
| ----------------- | ------------------------------------------------------------ |
| **Short-running** | Serving web requests (e-commerce, social networks) – seconds |
| **Long-running**  | Simulations, large dataset processing – longer periods       |

> **Scale**: Total energy bill for data centres is over **$15 billion** (estimate).
### Environmental Impact – The Dark Side

| Statistic                      | Value                                                      |
| ------------------------------ | ---------------------------------------------------------- |
| Global electricity consumption | 3–4%                                                       |
| Global CO₂ emissions           | ~2% (estimated 14% by 2040)                                |
| Electricity in 2022            | 460 TWh (more than UK's ~320 TWh)                          |
| Projected 2026 consumption     | 1,000+ TWh                                                 |
| IT sector future               | Estimated to become world's most energy-consuming industry |

**Examples of large data centres**:
- Apple's "iDataCenter" (North Carolina) – estimated energy = 250,000 EU homes
- Facebook data centre (Lulea, Sweden – 70 miles from Arctic Circle) – 84 acres, tens of thousands of servers, 500 huge fans for cooling
- **Colossus 2** (AI datacentre) – peak draw ~1.2 GW (enough for 2+ million homes); 7 Titan-class gas turbines (~460 MW); 168 Tesla Megapacks for stability
### Data Centre Power Breakdown

| Component          | Percentage |
| ------------------ | ---------- |
| **Server/Storage** | 50%        |
| Computer Room AC   | 34%        |
| Conversion         | 7%         |
| Network            | 7%         |
| Lighting           | 2%         |

> **Key insight**: Compute resources (servers) are at the heart – but cooling (34%) is also massive.
### COVID-19 Impact
> Global internet traffic surged by almost **40%** between February and mid-April 2020 (video streaming, conferencing, gaming, social networking).
## Power-Aware Computing: Trends and Issues
### Energy and Power Definitions

| Term                       | Definition                                                                                                | Formula                                               |
| -------------------------- | --------------------------------------------------------------------------------------------------------- | ----------------------------------------------------- |
| **Energy**                 | Physical currency to accomplish a task. Units: **Joule (J)**, **Watt-hour (Wh)**, **Kilowatt-hour (kWh)** | Energy = AvgPower × Time                              |
| **Power**                  | Instantaneous rate of energy use. Units: **Watt (W)**                                                     | Power = Energy / Time                                 |
| **Energy Efficiency (EE)** | Ratio of work done per unit of energy consumed                                                            | EE = Work Done / (Power × Time) = Performance / Power |

> **Joule**: The work required to produce one Watt of power for one second.
### Power Measurement Tools

| Tool                                                   | Description                                      |
| ------------------------------------------------------ | ------------------------------------------------ |
| **IPMI** (Intelligent Platform Management Interface)   | Direct measurement via server-integrated sensors |
| **RAPL** (Running Average Power Limit)                 | Intel/AMD power capping interface                |
| **Powerstat**                                          | Linux tool for power measurement                 |
| **Powertop**                                           | Linux tool identifying power-hungry components   |
| **Kepler** (Kubernetes Efficient Power Level Exporter) | Container power metrics                          |
### Key Observations (40 Years of Microprocessor Trend Data)

- Historically: performance increased exponentially, power followed
- Recently: **energy-optimised programmable hardware is ultimately controlled by software**
- Hardware is optimised for power/performance/cost; software determines actual energy use
## The Role of Hardware
### Hardware Optimisation Approaches

| Approach                        | Description                                       | Trade-off                                                              |
| ------------------------------- | ------------------------------------------------- | ---------------------------------------------------------------------- |
| **Hardware specialisation**     | ASICs, FPGAs, accelerators                        | Less flexibility, better efficiency                                    |
| **Hardware optimisation**       | Instruction-level parallelism, hardware threading | Diminishing returns                                                    |
| **Hardware-software co-design** | Large one-off engineering cost                    | Expensive but optimal                                                  |
| **Software closer to hardware** | Fewer abstractions                                | Harder to program; tools are performance-oriented, not energy-oriented |
| **Optimal software operation**  | Off-line and on-line optimisation                 | Overhead may pay off                                                   |
### Data Movement Dominates Power
> **Key principle (exam-relevant)** :
> 1. **Data Movement Dominates Power** – moving data costs more than computing on it
> 2. **Optimise the Storage Hierarchy** – use caches, avoid disk when possible
> 3. **Tailor Memory to the Application** – match memory type to workload
## The Role of Software
### Who Is to Blame? Hardware or Software?
> Hardware is often extensively optimised. But **energy-optimised programmable hardware is ultimately controlled by software**.

**Levels of software optimisation**:
1. **Software design** – architectural choices, algorithms, data structures
2. **Software operation** – runtime configuration, frequency scaling, core allocation
### Software Operation Space

**Hardware resources to monitor**:
- Hard disk: bytes/sec, read bytes/sec
- CPU: percentage utilisation
- Memory: private bytes, working set
- Network: bytes total/sec, sent/sec, received/sec
- IO: bytes/sec, read/sec, write/sec

**Configuration parameters**:
- Number of cores/threads
- Frequency of cores
- Type of core (heterogeneous computing – big.LITTLE)
### Energy Formulation
> **Energy = Power / Performance** OR **Energy = Power × Time**

**Trade-offs**:

| Action                     | Effect on Performance | Effect on Power            | Effect on Energy       |
| -------------------------- | --------------------- | -------------------------- | ---------------------- |
| Increase frequency/voltage | Increases             | Increases more (quadratic) | Often increases        |
| Decrease frequency/voltage | Decreases             | Decreases more             | Often decreases        |
| Add more cores             | Increases             | Increases                  | Depends on parallelism |
## Towards Energy Efficient Clouds – Six Strategies
> **Six key strategies for energy efficiency**:

1. Data Centre Design Considerations
2. **Dynamic Voltage and Frequency Scaling (DVFS)**
3. **Server Consolidation**
4. Virtualisation and Scheduling
5. Data Analytics
6. Software Design

*(Detailed in Part II)*
## Review of Energy Efficiency Metrics
### PUE (Power Utilisation Effectiveness)
> **PUE** = Total facility power / IT equipment power

| PUE Value | Meaning                                           |
| --------- | ------------------------------------------------- |
| 1.0       | Ideal (all power to IT, none to cooling/lighting) |
| 1.1       | Excellent (target)                                |
| 1.55      | Median in 2022 study                              |
| >2.0      | Poor                                              |

**Limitations of PUE**:
- 100W of IT equipment might not all be **useful** work
- Techniques exist to **deflate** PUE (some companies reported 1.02)
- Doesn't measure **performance** or **useful work**
### Performance Metrics
> **Latency** is important because users see it. **SLOs/SLAs** (e.g., "99% of requests <100ms") must be met even while saving energy.
### Energy Efficiency Metrics Summary

| Metric Type            | Unit                  | Example            |
| ---------------------- | --------------------- | ------------------ |
| **Energy**             | J, W, A, kWh          | Total consumption  |
| **Performance**        | GFLOPS/kWh, %         | Work per energy    |
| **Throughput**         | Requests/sec per Watt | Service efficiency |
| **Utilisation**        | %, MHz, GB/s          | CPU usage          |
| **Economics**          | £, $                  | Lifecycle cost     |
| **Performance/Energy** | GFLOPS/Watt           | Power efficiency   |
| **Pollution**          | CO₂ units             | Carbon emissions   |
### Metrics by Context

| Context             | Example Metric                                            |
| ------------------- | --------------------------------------------------------- |
| **Application**     | Computational energy cost (CPU, memory, I/O)              |
| **Architecture**    | Distributed system energy consumption (sum of components) |
| **Service**         | Execution plan energy efficiency                          |
| **Virtual Machine** | Disk energy model over time                               |
| **Data Centre**     | Data centre energy productivity (bytes per kWh)           |
| **Server**          | Server power utilisation vs CPU utilisation               |
| **DBMS**            | Power-aware query plan cost                               |
## Conclusion (Part I)

- Data centres consume massive energy (3–4% global electricity) with significant CO₂ impact
- **Jevons paradox**: efficiency results in increased use (demand trumps savings)
- Hardware provides the knobs; software must turn them
- **PUE** measures facility efficiency but not useful work
- **Energy = Power × Time** – trade-offs between performance and power
## Quick Reference for This Lecture

| Term               | Definition                                                  |
| ------------------ | ----------------------------------------------------------- |
| **Energy**         | Power × Time (Joules, Wh, kWh)                              |
| **Power**          | Instantaneous rate (Watts)                                  |
| **EE**             | Work Done / Energy = Performance / Power                    |
| **PUE**            | Total facility power / IT equipment power (lower is better) |
| **Jevons paradox** | Efficiency leads to increased consumption                   |
| **IPMI**           | Intelligent Platform Management Interface                   |
| **RAPL**           | Running Average Power Limit                                 |
| **Data movement**  | Dominates power (more than computation)                     |
| **Colossus 2**     | AI datacentre – 1.2 GW peak, 7 gas turbines, 168 Megapacks  |

**Exam traps**:
- **PUE = 1.0** is ideal (all power to IT); median ~1.55; target ~1.1
- **PUE doesn't measure useful work** – IT equipment may be idle
- **Jevons paradox** = efficiency → more use → total energy may not decrease
- **Energy = Power × Time** (not Power/Time)
- **Data movement** dominates power – optimise storage hierarchy
# Lecture 17: Energy Efficiency in Clouds – Part II
**Goals:** Understand concepts surrounding energy efficiency in clouds
### Overview
- Introduction
- Powering the Cloud Infrastructure: Energy Consumption, Costs, Implications
- Power-Aware Computing: Trends and Issues
- The role of hardware
- The role of software
- Towards energy efficient Clouds
- Review of energy efficiency metrics
- Conclusion
## Towards Energy Efficient Clouds – Eight Strategies (Detailed)
### 1. Data Centre Design Considerations

| Consideration                | Description                                |
| ---------------------------- | ------------------------------------------ |
| Cost-performance             | Balance capital and operational costs      |
| Datacenter layout            | Hot/cold aisle containment                 |
| Cooling system               | Efficient cooling (air, liquid, immersion) |
| Server architecture          | Energy-optimised components                |
| Dependability via redundancy | Trade-off between reliability and energy   |
| Network I/O                  | Energy-efficient switching                 |
| Workload types               | Interactive vs batch processing            |
| Server lifecycle             | ~18 months refresh cycle                   |
### 2. Dynamic Voltage and Frequency Scaling (DVFS)
> **DVFS** = power-management technique where clock frequency is decreased to allow corresponding reduction in supply voltage.

**Dynamic energy consumption formula**:
```
Dynamic Energy = α × Vdd² × Ncycle
```
- **Vdd** = supply voltage
- **Ncycle** = number of clock cycles

**Key relationships**:
- Voltage drop → slower transistors → frequency drop
- Reducing voltage has **quadratic** effect on dynamic energy

**Example** (exam-relevant calculation):
- Reduce voltage and frequency by 10%
- Program slows by ~8%
- **Dynamic power reduces by 27%** (quadratic effect)
- **Total power reduces by ~23%**
- **Total energy reduces by ~17%**
> **Motivation for DVFS scheduling algorithms**: minimise energy consumption while meeting job deadlines.

**Exam trap (2024 Q1g, 2025 Q1l)** : Server at Vmax finishes in T/2 seconds. Voltage for T seconds? **Vmax / 2**.
### 3. Server Consolidation
> **Problem**: Most servers utilisation is less than **5%**. Idle servers can consume up to **70% of maximum energy output**.

| Issue                  | Description                            |
| ---------------------- | -------------------------------------- |
| Low utilisation        | 5% typical – massive waste             |
| Idle power             | Up to 70% of peak                      |
| Can't turn servers off | Breaks hot/cold aisle; may not restart |
| Admin uncertainty      | Unsure how to use effectively          |

> **Server consolidation** = reducing number of physical servers by running multiple VMs on fewer hosts.
### 4. Virtualisation and Scheduling
> **Virtualisation** allows many applications on a single server → smarter resource allocation.

**Energy-aware scheduling decisions**:

| Decision Point            | Question                                                                                      |
| ------------------------- | --------------------------------------------------------------------------------------------- |
| **When to migrate?**      | Host overload/underload detection algorithms                                                  |
| **Which VMs to migrate?** | VM selection algorithms (e.g., Minimum Migration Time – MMT)                                  |
| **Where to migrate?**     | Heuristics for bin-packing (Power-Aware Best Fit, Genetic Algorithms, reinforcement learning) |

**Migration trade-off**: Migration requires additional cost and energy but can reduce hotspots.
### 5. Energy-Aware Load Balancing
> **Traditional load balancing** spreads load evenly. **Energy-aware balancing** does the **opposite**.

**Strategy**:
- Concentrate workloads on a **subset of servers**
- Keep the rest in **sleep or low-power mode**
- Reduces number of **partially utilised machines** (least energy-efficient)

**Benefit**: Partially utilised servers are the **least energy-efficient** (idle power high, useful work low).
### 6. Containerisation and Lightweight Virtualisation
> **Containers** reduce overhead compared to full VMs. **Unikernels** implement bare minimum OS functions.

| Technology             | Characteristics                                         | Energy benefit                                     |
| ---------------------- | ------------------------------------------------------- | -------------------------------------------------- |
| **Containers**         | Share host kernel; MBs vs GBs                           | Lower overhead, faster scaling                     |
| **Unikernels**         | App + minimal OS components; run directly on hypervisor | Extremely light; born/die in fractions of a second |
| **WebAssembly (Wasm)** | Binary instruction format for stack-based VM            | Emerging lightweight alternative                   |
### 7. Data Analytics
> Use **Big Data techniques** to identify points of inefficiency.

**Key findings**:
- Server architecture types exhibit different resource inefficiencies
- **CPU waste**: 4.33–14.22%
- **Memory waste**: 1.29–7.61%

**User Resource Estimation Problem**:
- Users always **overestimate** what they need (just in case, naive)
- Results in large amounts of idle resources
- Can use **over-provisioning** (similar to overbooking flight seats)
### VM Power Modelling
> Estimate energy consumption when direct measurement unavailable.

**Simple CPU utilisation model**:
```
VM_Px = Host_P × (VM_Utilx / ΣVM_Util)
```

| Variable | Meaning                                   |
| -------- | ----------------------------------------- |
| VM_Px    | VM's power consumption                    |
| Host_P   | Measured host power                       |
| VM_Utilx | VM's CPU utilisation                      |
| ΣVM_Util | Sum of CPU utilisation of all VMs on host |
### Physical Machine Power Modelling

**Linear Model**:
```
PMx_predPwr = α × PMx_predUtil + β
```

**Polynomial Model** (more accurate for real CPUs):
```
PMx_predPwr = α(PMx_predUtil)³ - γ(PMx_predUtil)² + δ(PMx_predUtil) + β
```

Where α, γ, δ are slopes, β is intercept.
> Polynomial model better captures non-linear relationship between CPU utilisation and power.
### 8. Energy Efficiency and Software Design
> Can service applications be built with energy awareness at **requirements/design stage**?

**Key principle**: Shared software components are used and reused many times → imperative they are as energy-efficient as possible.

**Programming Model with Energy Optimisation**:
1. Developer constructs application using Programming Model
2. Uses Plug-in to analyse code
3. Identifies **patterns** and **potential energy hotspots**
4. Adaptive methodology: **Monitor → Analyse → Plan → Execute**

**Adaptation decisions** (5W1H for energy adaptation):

| Question   | Considerations                         |
| ---------- | -------------------------------------- |
| **When?**  | Time: reactive, proactive              |
| **Why?**   | Reason: context, resources             |
| **Where?** | Level: application, software, resource |
| **What?**  | Technique: parameter, structure        |
| **How?**   | Control: approach, decision criteria   |
## Energy Awareness Across Cloud Layers
> Energy efficiency must be addressed at **every layer** of the cloud stack:

| Layer                      | Energy Considerations                                           |
| -------------------------- | --------------------------------------------------------------- |
| **User level**             | Applications (enterprise, scientific, social)                   |
| **User-level middleware**  | Cloud programming environments, workflows, libraries            |
| **Apps hosting platforms** | QoS negotiation, admission control, pricing, SLA management     |
| **Core middleware**        | Monitoring, execution management, metering, accounting, billing |
| **Virtualisation**         | VM management and deployment                                    |
| **System level**           | Hardware, hypervisors                                           |
## A Final Note on Policy
### Societal Enforcement and Policies

- Many companies want to be seen as "green"
- Increased pressure for enforcement to restrict datacentre energy costs
### Jevons Paradox (Exam-Relevant)
> **Jevons paradox** = efficiency results in **increased use** (not decreased).

**Implication**: The easier/cheaper you make it to consume a product, the **greater the consumption** will be. Energy efficiency gains in data centres may lead to **more data centre use**, not less total energy.

**Example**: More energy-efficient servers → lower cost per computation → more computations performed → total energy may increase.
## Summary

| Key Point       | Summary                                                                                                       |
| --------------- | ------------------------------------------------------------------------------------------------------------- |
| **Problem**     | Data centres consume high energy → high operational cost + environmental impact                               |
| **Solutions**   | DVFS, server consolidation, energy-aware scheduling, lightweight virtualisation                               |
| **Open issues** | Energy-efficient algorithms, software design, resource management for varied workloads, understanding metrics |
| **Paradox**     | Jevons paradox – efficiency may increase total consumption                                                    |
## Metrics for Measuring Energy Consumption (Reference Tables)
### By Metric Type

| Metrics Type       | Units                 | Example               |
| ------------------ | --------------------- | --------------------- |
| Energy             | J, W, A, kWh          | Total consumption     |
| Performance        | GFLOPS/kWh, %, s      | Work per energy       |
| Throughput         | Requests/sec per Watt | Service efficiency    |
| Utilisation        | %, MB, MHz, GB/s      | CPU/memory/disk usage |
| Economics          | £, $                  | Lifecycle cost        |
| Performance/Energy | GFLOPS/Watt           | Power efficiency      |
| Pollution          | CO₂ units             | Carbon emissions      |
### By Context

| Context           | Example Metric                               |
| ----------------- | -------------------------------------------- |
| Application       | Computational energy cost (CPU, memory, I/O) |
| Architecture      | Distributed system energy consumption        |
| Service           | Execution plan energy efficiency             |
| Virtual Machine   | Disk energy model over time                  |
| Data Centre       | Data centre energy productivity (bytes/kWh)  |
| Embedded Software | Executed instructions count                  |
| Server            | Server power utilisation vs CPU utilisation  |
| DBMS              | Power-aware query plan cost                  |
## Quick Reference for This Lecture

| Term                       | Definition                                                       |
| -------------------------- | ---------------------------------------------------------------- |
| **DVFS**                   | Dynamic Voltage and Frequency Scaling                            |
| **DFS**                    | Dynamic Frequency Scaling (only frequency, not voltage)          |
| **Dynamic Energy**         | α × Vdd² × Ncycle (quadratic with voltage)                       |
| **Server consolidation**   | Reducing physical servers by running multiple VMs on fewer hosts |
| **Idle server power**      | Up to 70% of max energy                                          |
| **MMT**                    | Minimum Migration Time (VM selection policy)                     |
| **Jevons paradox**         | Efficiency → increased consumption                               |
| **PUE**                    | Power Utilisation Effectiveness (facility metric)                |
| **Linear power model**     | PMx_predPwr = α × util + β                                       |
| **Polynomial power model** | Cubic regression (more accurate)                                 |

**Exam traps**:
- **DVFS reduces voltage** → quadratic energy reduction (not linear)
- **Voltage down → frequency down** (cannot lower voltage without lowering frequency on most systems)
- **Server consolidation** – turning servers off breaks hot/cold aisle; may not restart
- **Energy-aware load balancing** = concentrate load (opposite of traditional)
- **Jevons paradox** = efficiency → more use (not less energy)
- **VM power modelling** uses CPU utilisation proportion – simple but imperfect
- **Idle servers consume up to 70% of max power** (can't just turn off)
# Lecture 18: The Internet of Things and Ubiquitous Clouds
**Goals:** Understand concepts surrounding ubiquitous clouds and the Internet of Things (IoT)
### Overview
- Technology abundance
- Ubiquitous computing
- Smart environments
- IoT: architecture, scope, building blocks
- RFID, NFC, Devices
- The Challenges
- IoT data flow to the cloud
- Programmability of things
- Wireless networks IoT (LoRa, 5G for IoT, 5G slicing)
- Conclusion
## Technology Abundance
> **The Big Switch in early 21st century** was enabled by:
- More powerful computers
- Almost infinite cheap storage
- High bandwidth network and pervasive connectivity (6G, petabit networking in sight)
- Industries racing to build massive datacenters
- Virtualisation realising economies of scale
> **Emerging idea**: Technological abundance (Peter Diamandis) – technology is becoming so cheap and plentiful that scarcity is no longer the limiting factor.
## Ubiquitous Computing
> **Ubiquitous Computing** = inexpensive computing leading to **smart environments** or **ambient intelligence** – computing integrated seamlessly into everyday objects and environments.
> Ubiquitous computing leads to **ubiquitous connectivity** – connectivity anywhere, anytime, anyplace, to anyone.

**Result**: Emergence of the **Internet of Things (IoT)** concept.
### Smart Environments and Cloud Computing
> Clouds will be the base to provide future Internet services. Future Internet covers not only people and machines but also **any objects or things**.

**Examples of things**: household appliances, security equipment, sensors and actuators, bottles of wine, surveillance equipment, goods in a supermarket.
> **Key insight**: Interesting IoT applications **must leverage clouds** for processing and storage of massive amounts of data, dynamically.
## Internet of Things (IoT) – Definition
> **Kevin Ashton** coined "Internet of Things" phrase to describe a system where the Internet is connected to the physical world via ubiquitous sensors.
> **"Things"** = any physical object with a device that has its own IP address and can connect & send/receive data via a network.
## Architecture of the Internet of Things

**Core enabling technology**: **RFID** (Radio Frequency Identification Technology) – allows things to be identified and tracked wirelessly.
## Scope of the Internet of Things

IoT spans multiple domains:
- **Smart Homes** – connected appliances, security, lighting, HVAC
- **Smart Cities** – traffic management, waste management, smart lighting, parking
- **Wearables** – fitness trackers, smartwatches, medical monitors
- **Industrial IoT (IIoT)** – predictive maintenance, asset tracking, process automation
- **Healthcare** – remote patient monitoring, smart implants
- **Agriculture** – soil monitoring, precision irrigation, livestock tracking
- **Transportation** – connected vehicles, fleet management, autonomous driving
## Building Blocks of the Internet of Things

| Category           | Elements           | Examples                                                                                                                     |
| ------------------ | ------------------ | ---------------------------------------------------------------------------------------------------------------------------- |
| **Identification** | Naming, Addressing | EPC (Electronic Product Code), uCode, IPv4, IPv6                                                                             |
| **Sensing**        | Sensors, Actuators | Smart sensors, wearable sensing, embedded sensors, RFID tags                                                                 |
| **Communication**  | Protocols          | RFID, NFC, UWB, Bluetooth, BLE, IEEE 802.15.4, Z-Wave, WiFi, WiFi Direct, LTE-A                                              |
| **Computation**    | Hardware, Software | Arduino, Raspberry Pi, BeagleBone, smartphones; Contiki, TinyOS, LiteOS, RIOT OS, Android                                    |
| **Services**       | Types              | Identity-related (shipping), Information Aggregation (smart grid), Collaborative-Aware (smart home), Ubiquitous (smart city) |
| **Semantic**       | Data models        | RDF, OWL, EXI (Efficient XML Interchange)                                                                                    |
## RFID – Radio Frequency Identification
> **RFID** = wireless technology that uses radio waves to identify and track objects, animals, or people automatically.
### Components

| Component   | Function                                                                                                           |
| ----------- | ------------------------------------------------------------------------------------------------------------------ |
| **Tag**     | Contains microchip and antenna; can be **passive** (no battery), **active** (battery-powered), or **semi-passive** |
| **Reader**  | Sends and receives signals to/from the tag                                                                         |
| **Antenna** | Facilitates communication between tag and reader                                                                   |

**How it works**:
1. Reader emits radio waves
2. Tag responds with stored data (e.g., ID number)
3. Reader processes data and sends to backend system
## NFC – Near Field Communication
> **NFC** = short-range wireless communication technology enabling data exchange between devices within **~4 cm**.
### Modes of Operation

| Mode               | Description                       | Example                                       |
| ------------------ | --------------------------------- | --------------------------------------------- |
| **Peer-to-peer**   | Two devices exchange data         | Sharing contact info, photos                  |
| **Reader/Writer**  | Device reads data from NFC tags   | Reading product information from smart poster |
| **Card emulation** | Device acts like contactless card | Mobile payments (Apple Pay, Google Pay)       |

**How it works**:
- Requires two NFC-enabled devices: **initiator** (generates RF field) and **target**
- Communication automatic when devices brought close together
## Other IoT Devices

| Device Type   | Examples                                        | Characteristics                                                              |
| ------------- | ----------------------------------------------- | ---------------------------------------------------------------------------- |
| **Beacons**   | Bluetooth Low Energy (BLE) beacons              | Broadcast signals for proximity detection; used in retail, museums, airports |
| **Dongles**   | USB IoT adapters                                | Add connectivity to existing devices; plug-and-play                          |
| **Wearables** | Smartwatches, fitness trackers, medical patches | Body-worn; often have limited battery and compute                            |
## The Challenges of IoT

| Challenge                    | Description                                                   |
| ---------------------------- | ------------------------------------------------------------- |
| **Massive scale**            | Billions of devices to manage                                 |
| **Heterogeneity**            | Different protocols, data formats, hardware capabilities      |
| **Security**                 | Constrained devices difficult to secure; large attack surface |
| **RF interference**          | Wireless spectrum congestion                                  |
| **Control traffic**          | Large volume of signalling and coordination messages          |
| **Low latency requirements** | Some applications require near-real-time response             |
| **Power constraints**        | Many devices battery-powered; must operate for years          |
| **Reliability**              | Network or device failures must be handled gracefully         |

> **Control traffic and security mechanisms must be lightweight and optimised to minimise power consumption without compromising performance or trust.**
## IoT Data Flow to the Cloud
### Forward Flow (Sensor Data Path)

| Layer                       | Function                                                                                                               |
| --------------------------- | ---------------------------------------------------------------------------------------------------------------------- |
| **1. Sensing Layer**        | Physical sensors collect raw data (temperature, motion, humidity, etc.)                                                |
| **2. Edge Layer**           | Data pre-processed (filtering, aggregation, compression); may trigger local actions                                    |
| **3. Network Layer**        | Data transmitted via protocols (MQTT, CoAP, LoRa, IEEE 802.15.4, Zigbee, Sigfox) to edge servers/gateways and to cloud |
| **4. Cloud/Platform Layer** | Data stored (big data), analysed, visualised; AI/ML models extract insights or detect anomalies                        |
| **5. Application Layer**    | Information visualisation; insights used for decision-making, automation, or user interaction                          |
## Programmability of Things
### Reverse Path (Control Flow)
> **Programmability of the physical** = ability to send control commands from cloud/edge back to actuators.

| Step                    | Description                                                                    |
| ----------------------- | ------------------------------------------------------------------------------ |
| **1. Control Commands** | Decisions or models generate actuation commands                                |
| **2. Edge Execution**   | Commands sent to actuators via edge gateways                                   |
| **3. Actuation Layer**  | Physical devices (motors, valves, lights, alarms) controlled in near real-time |
| **4. Feedback Loop**    | Sensor data confirms execution and updates system state; new decisions made    |

> **Cloud → Edge → Actuators** path enables closed-loop control of physical systems.
## Cloud, Fog, and Edge Computing – The Continuum

| Layer               | Location                          | Characteristics                                            |
| ------------------- | --------------------------------- | ---------------------------------------------------------- |
| **Cloud Computing** | Centralised datacenters           | Massive storage, powerful analytics, high latency          |
| **Fog Computing**   | Intermediate layer (network edge) | Local aggregation, filtering, some processing              |
| **Edge Computing**  | Device/thing level                | Fastest response, local decision-making, minimal bandwidth |

> **Cloud provides elastic storage, analytics, and centralised management. Edge processes data closer to devices to reduce latency, bandwidth use, and energy consumption.**
## Wireless Networks for Supporting Ubiquitous Computing

| Feature                 | LoRaWAN                       | NB-IoT                               | Wi-Fi 6 (802.11ax)          | BLE                            | Zigbee                          |
| ----------------------- | ----------------------------- | ------------------------------------ | --------------------------- | ------------------------------ | ------------------------------- |
| **Application Focus**   | Long-range, low-power sensors | Cellular IoT for massive deployments | High-speed IoT, smart homes | Short-range, low-power devices | Home automation, industrial IoT |
| **System Resources**    | 32–256 KB                     | 256 KB+                              | 1 MB+                       | 32–256 KB                      | 4–256 KB                        |
| **Battery Life (days)** | 1,000+                        | 1,000+                               | 100–1,000+                  | 100–1,000+                     | 100–1,000+                      |
| **Network Size**        | Unlimited (star)              | Unlimited (cellular)                 | Thousands (multi-AP)        | 32,767 (mesh)                  | Unlimited (mesh)                |
| **Bandwidth (Kbps)**    | 0.3–50                        | 20–250                               | 600,000+                    | 125–2,000                      | 20–250                          |
| **Range (meters)**      | 2,000–10,000                  | 1,000–10,000                         | 1–100                       | 1–100                          | 1–100                           |
| **Success Metrics**     | Coverage, power efficiency    | Coverage, reliability                | Speed, flexibility          | Cost, convenience              | Reliability, cost               |
## LoRa – Long Range Communication
> **LoRa (Long Range)** = low-power, long-range wireless communication protocol designed for IoT applications.
### Key Characteristics

| Aspect                | Specification                                                                  |
| --------------------- | ------------------------------------------------------------------------------ |
| **Frequency bands**   | Unlicensed ISM bands (e.g., 868 MHz in Europe, 915 MHz in US, 433 MHz in Asia) |
| **Range**             | Up to 10 km in rural areas; 2–5 km in urban settings                           |
| **Data rate**         | Low (ideal for small, infrequent data packets)                                 |
| **Power consumption** | Very low (battery life: years)                                                 |
| **Topology**          | Star-of-stars (devices → gateways → network server)                            |

**Example**: ESP32 LoRa – popular development board combining LoRa with Wi-Fi/Bluetooth.
## 5G Support for IoT
> Networks can now be customised through **network slicing** – multiple logical "slices" (virtual networks) of functionality optimised for specific use cases, all operating on a single physical core within the 5G network infrastructure.
### 5G Slicing – Virtualised Isolated Networks
> **Network slicing** creates end-to-end virtual networks with dedicated resources (compute, storage, networking) tailored to specific service requirements.

**Exam relevance (2024 Q1e)**: "What concept does 5G use to support network function virtualisation?" – **D. slice**.
### Example Slices for IoT

| Slice Type                             | Characteristics                                | Use Cases                                               |
| -------------------------------------- | ---------------------------------------------- | ------------------------------------------------------- |
| **Massive IoT (mMTC)**                 | Many devices, low bandwidth, long battery life | Sensors, smart meters, asset tracking                   |
| **Ultra-Reliable Low Latency (URLLC)** | Very low latency, high reliability             | Autonomous vehicles, remote surgery, industrial control |
| **Enhanced Mobile Broadband (eMBB)**   | High bandwidth, moderate latency               | Video streaming, VR/AR, fixed wireless                  |
## Conclusion

| Key Point                          | Summary                                                                                                                       |
| ---------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- |
| **Cloud + Edge essential for IoT** | Balance scalability with real-time performance                                                                                |
| **Cloud provides**                 | Elastic storage, analytics, centralised management for massive IoT data volumes                                               |
| **Edge computing provides**        | Low latency, reduced bandwidth use, lower energy consumption, faster decision-making                                          |
| **Together they enable**           | Faster decision-making, resilient operation, secure data handling for time-critical and resource-constrained IoT applications |
## Quick Reference for This Lecture

| Term                         | Definition                                                                    |
| ---------------------------- | ----------------------------------------------------------------------------- |
| **Ubiquitous computing**     | Computing integrated seamlessly into everyday objects/environments            |
| **IoT**                      | Internet of Things – physical objects with IP addresses connecting to network |
| **RFID**                     | Radio Frequency Identification – wireless identification/tracking             |
| **NFC**                      | Near Field Communication – short-range (~4cm) wireless data exchange          |
| **LoRa**                     | Long Range – low-power, long-range IoT wireless protocol                      |
| **Network slicing**          | Virtualised isolated networks on shared 5G infrastructure                     |
| **Edge computing**           | Data processing near devices (low latency)                                    |
| **Fog computing**            | Intermediate layer between edge and cloud                                     |
| **EPC**                      | Electronic Product Code (RFID identification)                                 |
| **MQTT, CoAP**               | IoT communication protocols                                                   |
| **Contiki, TinyOS, RIOT OS** | IoT operating systems                                                         |
| **mMTC**                     | Massive Machine Type Communication (5G slice)                                 |
| **URLLC**                    | Ultra-Reliable Low Latency Communication (5G slice)                           |
| **eMBB**                     | Enhanced Mobile Broadband (5G slice)                                          |

**Exam traps**:
- **2024 Q1e**: 5G supports NFV through **network slicing** (D – slice)
- **Cloud vs Edge**: Cloud = centralised, high latency, massive storage; Edge = distributed, low latency, local processing
- **RFID vs NFC**: RFID longer range (metres), NFC very short range (~4cm)
- **LoRa** = unlicensed spectrum, long range, low bandwidth, very low power
- **5G slicing** creates virtual networks – each slice can have different QoS characteristics
- **Kevin Ashton** coined "Internet of Things" (exam may ask who coined the term)
# Lecture 19: Edge Computing and Intelligence
## Justifications for Edge Computing
> The traditional **data warehouse model** (centralised cloud processing) is insufficient for modern **IoT-driven applications** because it cannot handle the **data volume** and **velocity** produced by IoT devices, nor meet the **low latency response times** users demand.

Sending all data to the cloud creates three problems: **security concerns** (sensitive data traversing the network), **data congestion** (bandwidth bottleneck), and **control overhead** (difficulty coordinating massive distributed data flows).

**Example**: A **driverless car** generates ~**4 TB of data per day** from LiDAR, cameras, radar, and ultrasonic sensors. Sending this to the cloud for processing would introduce unacceptable latency for real-time braking decisions. Instead, **local edge processing** handles immediate safety decisions while the cloud handles **advanced analytics** (route optimisation, fleet learning).

**Key takeaway**: New business models demand **faster data analytics** closer to the data source — this is the fundamental motivation for edge computing.
## From Cloud to Edge
> Edge devices are used to **pre-process**, **pre-fetch**, and **filter** unnecessary data from streams before forwarding to mobile devices or the cloud. The goal is that devices receive **only the data they need, when they need it**.

This achieves three benefits: **reduced bandwidth** (less raw data sent over the network), **reduced latency** (responses generated locally), and **reduced load** (cloud servers handle less work).

**Architecture flow**: Raw data → **Edge Device** (pre-processes, aggregates, filters) → sends **summaries, alerts, aggregations** to mobile devices/cloud.

**Example**: In a smart factory, hundreds of temperature sensors stream data every second. An **edge gateway** filters out normal readings and only forwards **anomaly alerts** to the cloud dashboard, cutting network traffic by over 90%.
## Definition of Edge Computing
> **Edge Computing** is a **distributed computing paradigm** that moves **data processing and storage closer to the source** where data is generated (**IoT devices, sensors, machines**), instead of relying exclusively on the cloud. The goal is to **reduce latency**, **save bandwidth**, and **improve privacy**.
### Fog Computing vs Edge Computing

Both push **intelligence and processing** closer to where data originates. The key difference is **where** the processing happens:

| Feature                 | **Edge Computing**                                  | **Fog Computing**                                                            |
| ----------------------- | --------------------------------------------------- | ---------------------------------------------------------------------------- |
| **Processing location** | Directly on **end-devices** where data is generated | **Intermediate layer** between edge and cloud (LAN nodes)                    |
| **Infrastructure**      | Sensors, cameras, IoT devices themselves            | **Routers, switches, dedicated servers** within the LAN                      |
| **Function**            | Lowest possible latency, on-device decisions        | **Aggregate, filter, process** data from multiple endpoints before the cloud |
| **Scale**               | Billions of edge devices                            | Millions of fog nodes                                                        |
| **Latency**             | Lowest                                              | Low (but higher than pure edge)                                              |

**Example**: A **smart camera** running object detection on-device = **edge computing**. A **local gateway** collecting data from 50 cameras, aggregating results, then sending summaries to the cloud = **fog computing**.
### Edge/Fog/Cloud Continuum

The three tiers work together as a **continuum**: **Edge** (immediate local processing) → **Fog** (intermediate aggregation and richer processing) → **Cloud** (heavy computation, long-term storage, global analytics). An **e-Health smart city** example uses wearable sensors (edge) sending vital signs to edge controllers, which compress and encrypt data for fog nodes, which handle serverless processing and container elasticity, with the cloud providing dashboards and high-level notifications to authorities.
## EC: Representative Hardware

| Hardware                                                              | Description                                                          | Use Case                                                    |
| --------------------------------------------------------------------- | -------------------------------------------------------------------- | ----------------------------------------------------------- |
| **Raspberry Pi**                                                      | Cheap, versatile, **4 cores (ARM Cortex)**, 2–8 GiB RAM              | Prototyping, light home servers                             |
| **NVIDIA Jetson**                                                     | Integrated **GPU (CUDA architecture)** for heavy parallel processing | **Computer vision**, deep neural networks in near real-time |
| **Intel NUC**                                                         | **Mini PCs** with desktop-class processors                           | Edge servers needing more compute than a Pi                 |
| **IoT boards (ESP32, Arduino)**                                       | **Ultra-low power** microcontrollers, months on a single battery     | Specific sensor tasks, simple data collection               |
| **Industrial gateways** (Siemens SIMATIC IoT2050, Advantech ECU-1051) | Hardened for **harsh environments**, protocol translation            | Factory floors, local analytics in industrial settings      |
| **Smartphones/mobile devices**                                        | **Opportunistic edge nodes** running lightweight AI/ML workloads     | On-device inference, personal AI tasks                      |
## Definition of Edge Intelligence
> **Edge Intelligence (EI)** combines **Edge Computing** and **Artificial Intelligence (AI)**. It runs **ML models on or near edge devices** to enable **intelligent decision-making** locally. The aims are: **reduced latency**, **lower communication overhead**, **enhanced privacy**, and **context awareness**.
### Centralised Intelligence vs Edge Intelligence

|                   | **Centralised Intelligence**                         | **Edge Intelligence**                                                  |
| ----------------- | ---------------------------------------------------- | ---------------------------------------------------------------------- |
| **Where AI runs** | Cloud data centre                                    | Edge nodes/devices                                                     |
| **Data flow**     | Raw data sent **up** to cloud; results sent **down** | Data processed **locally**; only summaries/model updates sent to cloud |
| **Latency**       | High (network round-trip)                            | Low (local inference)                                                  |
| **Privacy**       | Data leaves the device                               | Data **stays on-device**                                               |
| **Scalability**   | Limited by cloud bandwidth                           | Scales with number of edge devices                                     |
## EI: Software Building Blocks
### Optimized AI Models
**Compact architectures** designed for resource-constrained devices: **TinyML** (ML on microcontrollers), **MobileNet** (lightweight CNNs), **distilled transformers**. **Compression techniques** include **pruning** (removing unneeded weights), **quantization** (reducing precision, e.g. 32-bit → 8-bit via **Google TurboQuant**), and **knowledge distillation** (training a small "student" model to mimic a large "teacher" model).
### Edge AI Frameworks
Software that enables running inference on edge hardware: **TensorFlow Lite** (Google, Android/IoT), **PyTorch Mobile** (Meta), **OpenVINO** (Intel), **ONNX Runtime Mobile**, **Qualcomm AI Stack**, **Core ML** (Apple).
### Federated Learning
> **Federated Learning** is a **collaborative training** approach where multiple devices train a shared model **without centralising data**. Each device trains on its **local data**, then sends only **model updates** (gradients) to a central server for aggregation.

This preserves **privacy** (raw data never leaves the device) while still benefiting from **collective learning**. Tools: **FedAvg** (algorithm), **Flower**, **TensorFlow Federated**, **OpenFL**.

**Example**: Smartphones improve a keyboard prediction model by learning from each user's typing locally, then sharing only the model weight updates — never the actual messages typed.
### Edge Pipeline
The typical processing flow on edge: **Pod instantiation** → **Data ingestion** (via **MQTT/Kafka**) → **Pre-processing** (Apache Edgent, NumPy) → **Local inference** (TinyML) → **Feedback loops**. Orchestrated by **lightweight Kubernetes** (**K3s/MicroK8s**) with **Grafana** for observability.
## EI: Hardware

| Hardware                                | Type                                                                  | Use Cases                                              |
| --------------------------------------- | --------------------------------------------------------------------- | ------------------------------------------------------ |
| **NVIDIA Jetson Nano/TX2/Xavier**       | Embedded **GPU** (CUDA), scalable from entry-level to heavy inference | Autonomous robotics, drones, real-time video analytics |
| **Google Coral TPU**                    | **ASIC** optimised for **TensorFlow Lite** at ultra-low power         | Industrial IoT sensors, local anomaly detection        |
| **Intel Movidius Neural Compute Stick** | **USB VPU accelerator**, plug-and-play                                | Rapid prototyping, upgrading legacy hardware with AI   |
| **Smartphones with Neural Engines**     | Dedicated **NPU** silicon for on-device execution                     | Computational photography, AR, real-time translation   |
## AI & EI
### Kubernetes-Connected Cloud-Edge Architecture
The **Kubernetes control plane** (API Server, Scheduler, Controller Manager, **etcd**) runs in the **cloud**. **Worker nodes** at the **edge** run **Kubelet** (manages pod lifecycle) and **Docker** (container runtime). **Kube-Proxy** manages network rules and distributes incoming requests across pods per worker node. **IoT devices** access application services hosted as **pods on edge nodes**.

Key points: Edge node resources are **heterogeneous and limited**. **Lightweight K8s distributions** dominate edge environments: **K3s**, **MicroK8s**, **k0s**. Cloud nodes provide **large computing and memory capacity** for heavier tasks.
### LLM-Based Edge Intelligence
Deploying **Large Language Models** at the edge brings **context understanding** to edge devices, increases device **autonomy** for low-latency decisions, and provides **context-awareness** for near real-time management of **6G edge devices**. Privacy is enhanced via **local processing** or **randomization** of sensitive data.
### LLM Deployment Strategies

| Strategy                    | Description                                                | Trade-off                                                          |
| --------------------------- | ---------------------------------------------------------- | ------------------------------------------------------------------ |
| **Cloud Deployment**        | LLMs hosted centrally (e.g. GPT-4, 1.7T params)            | Abundant resources but **high latency, high bandwidth cost**       |
| **Network Edge Deployment** | LLMs at network edge (e.g. Llama2 13B, PaLM2 16B)          | **Lower latency** but constrained resources require optimisation   |
| **On-Device Deployment**    | LLMs on user devices (e.g. Mistral 7B, Gemini Nano 1.8B)   | **Fastest response**, personalisation, but **limited by hardware** |
| **Cache-Based Deployment**  | Model split/cached across cloud, edge, devices             | **Flexible** but complex synchronisation                           |
| **Cooperative Deployment**  | Cloud trains large models; edge runs small tailored models | Best of both but requires **coordination**                         |
### Wasm & Trusted Execution Environments (TEEs)
**WebAssembly (Wasm)**: A **portable, lightweight, safe** execution format providing **software-level sandboxing**. **Intel SGX (Software Guard Extensions)**: Provides **hardware-isolated enclaves** that protect code/data from the host OS. The **TWINE Runtime** combines both: executes Wasm inside SGX creating a **two-way sandbox** (Wasm sandbox nested in TEE hardware sandbox). Uses **WASI** for controlled OS access and **attestation** to verify runtime and app integrity.
### Serverless + Edge for AI/ML Training
Running **serverless functions** on edge devices for ML training requires **lightweight Kubernetes** (K3s, MicroK8s, k0s), **lightweight OS images** (Python debian slim), and benchmarking tools like **Benchfaster** for evaluating serverless function performance at the edge.
## Model Answer Block

**Q: Propose a cloud/edge computing-based solution for a real-world IoT monitoring scenario (e.g., greenhouse monitoring, blind navigation headset). Discuss deployment. (6–7 marks)**

**Answer structure** (adapt the specific scenario):

**1. Edge Layer (Sensors + Local Processing)**: Deploy **IoT sensors** (e.g., temperature, humidity, camera) connected to an **edge device** (e.g., **Raspberry Pi** or **NVIDIA Jetson** for vision tasks). The edge device runs **local pre-processing** and **event filtering** — e.g., only flagging readings outside thresholds, or running a **lightweight ML model** (TinyML/MobileNet via TensorFlow Lite) for real-time object detection. This ensures **low-latency responses** for time-critical alerts (e.g., obstacle detection, temperature spike).

**2. Fog/Gateway Layer**: An **edge gateway** (e.g., industrial gateway) aggregates data from multiple sensor nodes, performs **data compression** and **encryption**, and forwards summaries/alerts to the cloud. Uses **MQTT** or **Kafka** for data ingestion. Orchestrated using **lightweight Kubernetes (K3s)** for container management.

**3. Cloud Layer**: A **cloud platform** provides **long-term storage**, **advanced analytics** (historical trend analysis, model retraining), **dashboards** (Grafana), and **notification services** (SMS/email alerts to stakeholders). Handles tasks that don't require real-time response.

**4. Networking**: Use **5G/6G connectivity** for reliable low-latency communication between edge and cloud. **Network slicing** can allocate a dedicated slice for the IoT application ensuring **QoS guarantees**.

**5. Justification**: Processing at the edge reduces **latency** (critical for real-time decisions), **bandwidth** (only summaries sent to cloud), and improves **privacy** (sensitive data stays local). The cloud provides **scalability** and **heavy computation** for non-time-critical tasks. This **edge/fog/cloud continuum** architecture is the standard pattern for IoT applications.
# Lecture 20: A Glimpse in Monetized 6G — From 5G to 6G
## Some Background in Fundamental Concepts
### Multi-access Edge Computing (MEC)
> **MEC** is an **ETSI-standardised** architecture that moves cloud-computing capabilities to the **network edge** (e.g., at or near **base stations**). It provides an **edge computing platform** consisting of infrastructure + **APIs for Mobile Edge services**.

Typical MEC services: **Radio Network Information Service**, **Location Service**, **Bandwidth Management**, **Traffic Steering**. MEC services require **dependency-aware multiple service placement** and are **not** 3GPP 5G Virtual Network Functions (**VNFs**).

**Example**: A mobile AR game uses MEC to offload rendering to a nearby edge server at the base station, achieving <10ms latency instead of ~100ms to a distant cloud.
### Open Radio Access Network (O-RAN)
> **O-RAN** promotes **vendor interoperability** by defining **open interfaces** for radio access network components. It **disaggregates** the traditional base station (**gNB**) into separate components.

The functional split: **Central Unit (CU)** — split into **CU-CP** (Control Plane: RRC, PDCP) and **CU-UP** (User Plane: SDAP, PDCP). **Distributed Unit (DU)** — handles RLC, MAC, PHY-high layers, runs at the edge. **Radio Unit (RU)** — handles PHY-low and RF at the **cell site**. The CU and DU run in the **O-Cloud (Edge Cloud)**, enabling **virtualised, software-defined** radio infrastructure.
### Immutability and Smart Contracts

**Immutability**: The ability to **persistently store data** and/or **run programs** in a way that they **cannot be changed once registered** (e.g., blockchain).

**Smart Contract**: A **self-executing digital agreement** with terms directly written into **code**. It executes automatically when predefined conditions are met, without needing a trusted intermediary.

**Example**: A smart contract on a blockchain automatically pays an infrastructure provider when sensor data confirms an SLA has been met — no manual invoicing needed.
### Service Delivery Models (SDMs)
> **SDMs** define how **mobile network services** are structured and provided to end users and third-party operators.

| Model                                                  | Description                                                                               |
| ------------------------------------------------------ | ----------------------------------------------------------------------------------------- |
| **MNO (Mobile Network Operator)**                      | Traditional operator that **owns its own** network infrastructure                         |
| **MVNO (Virtual Mobile Network Operator)**             | Operator that **leases network** from an MNO, does not own physical infrastructure        |
| **DeWi (Decentralised Wireless)**                      | Emerging model using **decentralised infrastructure** — community-owned wireless networks |
| **DePIN (Decentralised Physical Infrastructure Nets)** | Blockchain-incentivised **decentralised physical infrastructure** sharing                 |
### Digital Twin (DT)
> A **Digital Twin** is a **near-real-time virtual representation** of a **physical asset**, enabling **indirect observability** and **programmability** through **service-level APIs**. It can run as a **smart contract**.

The DT receives **data** from the physical asset (sensor readings, state updates) and sends **control** commands back. Services interact with the DT via an **agreement** (API/smart contract), not directly with the physical asset.

**Example**: A **digital twin of a 6G base station** mirrors its real-time state (load, power consumption, antenna config). Network operators interact with the twin to adjust parameters; changes propagate to the physical device automatically.
## 6G Starting Points
### 5G Network Slicing (Recap for Context)
> **Network Slicing** uses **NFV** and **SDN** to create multiple **virtual networks (slices)** on a single physical infrastructure. Each slice is customised for a specific use case with its own **QoS guarantees**.

5G uses the concept of a **slice** to support NFV. This was a key exam topic: "What concept does 5G use to support network function virtualisation?" → **D. Slice**.
### From 5G to 6G — Key Differences

| Aspect             | **5G**                              | **6G**                                                             |
| ------------------ | ----------------------------------- | ------------------------------------------------------------------ |
| **Peak data rate** | ~20 Gbps                            | ~1 Tbps                                                            |
| **Latency**        | ~1 ms                               | ~0.1 ms (sub-millisecond)                                          |
| **Intelligence**   | Some AI-assisted network management | **Native AI/ML** embedded throughout                               |
| **Architecture**   | Centralised core + edge add-ons     | **Cloud/Fog/Edge continuum** as default                            |
| **Trust model**    | Centralised operators               | **Decentralised** via DLT/blockchain                               |
| **New enablers**   | NFV, SDN, MEC                       | THz communications, digital twins, quantum, neuromorphic computing |
## Case Study: Disruptive 6G (D6G) Architecture
### D6G Enabler Families (8 Building Blocks)

| Family                     | What It Covers                                                                                                                     |
| -------------------------- | ---------------------------------------------------------------------------------------------------------------------------------- |
| **1. Energy**              | Energy harvesting, green technology                                                                                                |
| **2. Sensing & Actuating** | Ubiquitous sensing, IoT sensing, programmability of things                                                                         |
| **3. Communication**       | THz communications, Ultra MIMO, IRS/RIS, VLC, OWC, D2D, UAVs, cell-free nets, 3D nets, DTN                                         |
| **4. Softwarization**      | Functional fragmentation, programmability (cloud/edge), virtualisation, servitisation, digital twins, slicing, augmented realities |
| **5. Immutability**        | Immutable registers, tokenization, smart contracts, decentralised deterministic computing                                          |
| **6. Intelligence**        | AI, ML, SON (Self-Organising Networks), neuromorphic computing, decision support systems                                           |
| **7. Security**            | Identity/traceability, secrecy/integrity/authentication, authorisation/trust/transparency                                          |
| **8. Quantum**             | Quantum computing, quantum communications, quantum security, quantum ML                                                            |
### D6G Vision — Core Pillars

**Native Cloud/Edge Intelligence**: Cloud and edge collaborate with embedded **AI/ML** as a first-class component of the network, not an add-on.

**Smart Contracts**: Automate **agreements**, **resource allocation**, and **digital monetisation** — e.g., automatically paying for network slice usage via blockchain.

**Decentralized AI**: Distributing intelligence across the network for **autonomy** and **optimised local decision-making**, rather than centralising all AI in the cloud.

**Digital Twins**: Virtual representations of all physical network assets enabling **mirrored reality** — operators manage twins, changes propagate to physical infrastructure.

**Focus areas**: Flexibility, **open digital markets**, automated resource sharing, enhanced security/trust via **Distributed Ledger Technology (DLT)**, fostering new economies.
### D6G Architecture — Three Strata

| Stratum                                 | Role                                                                                            | Components                                                                          |
| --------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| **1. Service Stratum**                  | Hosts **on-chain and off-chain services**; producers/consumers interact via **digital markets** | Smart contracts, decentralised service store, Chainlink oracles, off-chain services |
| **2. Abstraction & Middleware Stratum** | **Virtualises** physical resources, manages security, enables **programmability**               | Software platform, virtualiser (VMs/containers)                                     |
| **3. Physical Stratum**                 | The underlying **hardware infrastructure**                                                      | SDRs, antennas, switches, RIS/IRS, UAVs, satellites, sensors, quantum hardware      |
### On-Chain/Off-Chain Interoperability

**Oracles** (e.g., **Chainlink**) act as **bridges** between the **blockchain (on-chain)** smart contracts and **external data sources (off-chain)**. In D6G, an operator expresses **intents** on-chain, an oracle translates these into **slicing parameters** via an **intent decoder (SLOrion)**, which configures **Network Slice as a Service (NSaaS)** across RAN, Transport, and Core. Services self-verify against the on-chain contract.
## Some Aspects of 6G Deployment
### Industry 5.0 Integration Challenges
Key challenges of integrating **6G with edge computing** in the context of **Industry 5.0** (exam topic from 2025 paper):

| Challenge                          | Explanation                                                                                                                           |
| ---------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------- |
| **Ultra-low latency requirements** | Manufacturing processes need **sub-millisecond** responses for real-time control and safety                                           |
| **Heterogeneous infrastructure**   | Mixing legacy factory equipment with new 6G-enabled devices creates **interoperability** issues                                       |
| **Energy efficiency**              | Dense 6G deployments (THz, massive MIMO) consume significant power; factories need **green computing** strategies                     |
| **Security & privacy**             | Industrial data is highly sensitive; requires **TEEs**, **encryption**, and **secure edge processing**                                |
| **Scalability**                    | Thousands of IoT sensors per factory floor; managing at scale with **lightweight orchestration** (K3s)                                |
| **Human-centric design**           | Industry 5.0 emphasises **human-machine collaboration**; 6G must support **digital twins** and **AR/VR** for worker augmentation      |
| **Reliability**                    | Mission-critical industrial processes cannot tolerate network failures; **redundancy** and **DTN (Delay-Tolerant Networking)** needed |
## Model Answer Block

**Q: Highlight the challenges of integrating 6G with edge computing in the context of Industry 5.0. (4 marks)**

6G integration with edge computing for Industry 5.0 faces several challenges. First, **ultra-low latency** requirements for real-time industrial control (e.g., robotic assembly) demand **sub-millisecond** responses, requiring compute placement very close to actuators via **MEC** and edge nodes. Second, **heterogeneous infrastructure** creates interoperability issues — factories combine legacy OT (operational technology) equipment with new 6G-enabled IoT sensors and edge devices, requiring **O-RAN**-style open interfaces and **middleware abstraction layers**. Third, **energy efficiency** is critical since dense 6G deployments (THz frequencies, massive MIMO antennas) significantly increase power consumption, conflicting with Industry 5.0's sustainability goals — this requires **DVFS**, **energy harvesting**, and workload-aware scheduling. Fourth, **security and privacy** of industrial data is paramount; sensitive manufacturing data processed at the edge requires **Trusted Execution Environments (TEEs)** like Intel SGX and **federated learning** to keep data local. Finally, **human-centric design** — Industry 5.0 emphasises human-machine collaboration, meaning 6G must reliably support **digital twins** and **AR/VR** for worker augmentation, which demands high bandwidth and consistent QoS via **network slicing**.

**Q: Discuss how to deploy an IoT solution for a person who is blind using a headset with limited compute (2025 exam Q3d, 6 marks)**

**Edge layer**: The **headset** is the primary edge device, equipped with a **camera** and a **lightweight ML model** (e.g., **MobileNet** or **YOLO-Tiny** via **TensorFlow Lite**) for real-time **object detection**. Since compute and storage on the headset are limited, the model must be **optimised** via **quantization** and **pruning** to run inference within strict latency and power constraints. Detected obstacles trigger **voice alerts** via text-to-speech directly on the device — this must work with **zero cloud dependency** for safety-critical, real-time responses.

**Fog/edge server layer**: A **smartphone** (connected via Bluetooth/Wi-Fi) or nearby **MEC server** (via **5G/6G**) acts as a more powerful edge node. More complex tasks — such as **scene understanding**, **navigation routing**, or running a larger ML model — can be offloaded here. **Network slicing** ensures a dedicated low-latency slice for this safety-critical application.

**Cloud layer**: The cloud handles **model retraining** using aggregated anonymised data (via **federated learning** to preserve privacy), **long-term route mapping**, and **software updates** pushed to the headset. A **digital twin** of the user's environment could be maintained in the cloud for enhanced navigation planning.

**Justification**: This **edge/fog/cloud continuum** approach ensures the most **time-critical function** (obstacle detection → voice alert) runs **locally on the headset** with minimal latency. Heavier processing is offloaded when connectivity allows. **Federated learning** improves the model over time without compromising user privacy. **Lightweight Kubernetes (K3s)** could orchestrate containerised services on the edge/fog layer.

| Comparison: Edge vs Cloud for This Scenario |                                                                                         |
| ------------------------------------------- | --------------------------------------------------------------------------------------- |
| **Edge (headset)**                          | Real-time object detection, voice alerts, always available even offline                 |
| **Cloud**                                   | Model retraining, route planning, software updates, analytics                           |
| **Why not cloud-only?**                     | Latency too high for real-time obstacle avoidance; connectivity not guaranteed outdoors |
| **Why not edge-only?**                      | Headset too limited for complex scene understanding and model training                  |