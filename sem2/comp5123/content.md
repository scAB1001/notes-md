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

---

## Overview

### Technology landscape
> **Cloud computing** = on-demand delivery of **compute, storage, networking** over the internet with **pay-as-you-go pricing** and **no upfront capital expenditure**.

**Example**: Netflix runs on AWS – owns no data centres, scales to 282 million subscribers globally.

### Distributed computing evolution
> Evolution of distributed computing paradigms:

| Era | Paradigm | Key Technologies |
|-----|----------|------------------|
| First | Linked machines together | Internet, TCP/IP |
| Second | Linked documents together | WWW, HTTP, HTML, XML |
| Third | Linked applications together | Web services, SOAP, WSDL, REST |
| Now | Linking everything together | **Grid** (decentralised), **Cloud** (centralised) |

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
| Technology | Doubling Period | 1986 → 2000 → Today |
|------------|----------------|----------------------|
| Computer speed | 18 months | 64Kbs → 2.5Gbps → Terabits |
| Network speed | 9 months | 64Kbs → 2.5Gbps → 1 Petabit/s (CRS-X) |
| Storage density | 12 months | 0.5 PB (2000) → Exabytes → Zetta era (10²¹ bytes) |

**Current data scales (exam-relevant figures)**:
| Company | Data Scale |
|---------|------------|
| Facebook | 300 PB user data + 600 TB/day processing |
| Google | 8.5 billion searches/day, 15+ exabytes stored |
| YouTube | 1 billion hours videos watched/day |
| TikTok | 0.75 billion users in China |
| By 2025 | 400 exabytes data generated **per day** globally |

### Towards a definition of cloud computing
> **NIST Definition** (National Institute of Standards and Technology): *Cloud computing is a model for enabling **ubiquitous, convenient, on-demand network access** to a **shared pool of configurable computing resources** (networks, servers, storage, applications, services) that can be **rapidly provisioned and released** with **minimal management effort** or service provider interaction.*

**Five essential characteristics (memorise for exam)**:

| Characteristic | Description |
|----------------|-------------|
| **On-demand self-service** | Consumer provisions capabilities **automatically** without human interaction |
| **Broad network access** | Available over network via **standard mechanisms** (heterogeneous clients) |
| **Resource pooling** | Provider's resources **pooled** to serve multiple consumers; **location independence** |
| **Rapid elasticity** | Capabilities appear **unlimited**; can be appropriated in any quantity at any time |
| **Measured service** | Automatic **control and optimisation** via metering at appropriate abstraction level |

> **The Cloud Metaphor**: Application → Workstation/Mobile Access → The Cloud (Supercomputer, PC-Cluster, Data-storage, Sensors) → Internet/Networks

### Conceptual cloud architecture
**Layered architecture** (from bottom to top):
1. **Physical infrastructure** (servers, storage, network)
2. **Virtualisation layer** (hypervisors, VMs)
3. **Infrastructure as a Service (IaaS)** – compute, storage, networking
4. **Platform as a Service (PaaS)** – development frameworks, databases
5. **Software as a Service (SaaS)** – applications

**NIST Cloud Computing Reference Architecture actors**:

| Actor | Role |
|-------|------|
| **Cloud Consumer** | Uses services from Cloud Provider |
| **Cloud Provider** | Makes services available |
| **Cloud Auditor** | Independent assessment of security, performance, operations |
| **Cloud Broker** | Manages use, performance, delivery; negotiates between Provider and Consumer |
| **Cloud Carrier** | Provides connectivity and transport |

**What consumers want**: Meet **Quality of Service**, minimise expenses
**What providers want**: Attract customers, **maximise profit**

### Conclusion
- Clouds built on: **SOA**, **VMs**, **Web 2.0/3.0** technologies
- Many business and consumer applications enabled
- **Cloud is NOT a silver bullet** – some applications may not be suitable to run on cloud
- Enables **opex over capex** (operational expenditure vs capital expenditure)

---

## Quick Reference for This Lecture

| Concept | Key Point |
|---------|-----------|
| **NIST 5 characteristics** | On-demand, broad access, pooling, elasticity, measured service |
| **Moore's Law** | Transistors double every 2 years |
| **Law of Accelerating Returns** | Kurzweil – exponential progress feeds itself |
| **Cloud evolution** | Machines → Documents → Applications → Everything |
| **Utility computing vision** | Leonard Kleinrock (1969) – "computer utilities like electricity" |
| **El Capitan** | 1.742 exaflops/s (2024 fastest supercomputer) |

**Exam trap (2024 Q1a-e)**: Learn which NIST characteristic matches which description:
- "consumer can unilaterally provision... without human interaction" = **On-demand self-service**
- "capabilities appear unlimited... any quantity any time" = **Rapid elasticity**
- "automatic control and optimisation by metering" = **Measured service**
- "available over network via standard mechanisms" = **Broad network access**
- "location independence, multi-tenant" = **Resource pooling**

---

# Lecture 2: Introduction to Cloud Computing (Part 2)

## Goals

Understand concepts of Cloud Computing

---

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

| Layer | Responsible Party |
|-------|-------------------|
| Physical hardware, network, hypervisor | **Cloud Provider** |
| OS, middleware, runtime | **Consumer** (IaaS) / Provider (PaaS/SaaS) |
| Data, applications, access control | **Consumer** |

---

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

| Feature | Public | Private | Hybrid |
|---------|--------|---------|--------|
| **Ownership** | Cloud provider | Organisation | Both |
| **Control** | Limited | Full | Partial |
| **Cost** | Pay-as-you-go | Capital + operational | Mixed |
| **Scalability** | Infinite | Limited (own capacity) | Burst to public |
| **Security** | Provider-managed | Self-managed | Sensitive data on-prem |
| **Compliance** | Shared responsibility | Full control | Flexible |

### Other cloud types
- **Community cloud**: Shared by several organisations with common concerns (e.g., government agencies)
- **Multi-cloud**: Using multiple public cloud providers (avoids vendor lock-in)
- **Distributed cloud**: Public cloud services running at edge locations

---

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

---

## Virtualisation

> **Virtualisation** = emulating in software a specialised physical resource (machine, network function) into a host computer. Enables reproducing same capabilities/functionalities from client's perspective – **implemented in software**.

### Historical context
- Heated topic in **1970s** following IBM's introduction of **VMM (Virtual Machine Monitor)** in 1960s
- OS were sold bundled with hardware – to get new OS, had to buy new machine
- **Virtualisation made it possible to run new OS on older hardware** via VMs

### Virtualisation layer
> The **virtualisation layer** "hides" and "homogenises" hardware resources, allowing **one or more operating systems** to run simultaneously on same physical machine.

### Cyber/Virtual vs Physical Infrastructures

| Infrastructure | Description |
|----------------|-------------|
| **Physical Infrastructure** | Actual physical servers, racks, switches, cabling |
| **Virtualisation Layer** | Creates the cyberinfrastructure |
| **Cyber/Virtual Infrastructure** | VMs, virtual networks, load balancers, firewalls, managed services |

### Virtualised Infrastructure benefits
- **Consolidation** of server systems
- **Reduced costs**
- **Reduced complexity**
- **Simplified administration**
- **Pay-per-usage** model

---

## Conclusion

### Classical Computing vs Cloud Computing

| Aspect | Classical Computing | Cloud Computing |
|--------|---------------------|-----------------|
| **Model** | Buy & Own | **Subscribe & Use** |
| **Hardware** | Meet peak needs (over-provisioned) | Elastic – scale as needed |
| **Effort** | Install, configure, test, verify, evaluate, manage | Provider manages |
| **Time to use** | Months | Minutes |
| **Cost** | Capital expenditure ($$$) | Operational expenditure ($ – pay for what you use) |

> **Revolution in IT**: Shift from **capital expenditure (capex)** to **operational expenditure (opex)**.

---

## Quick Reference for This Lecture

| Concept | Key Point |
|---------|-----------|
| **IaaS** | Rent VMs, storage, networks – e.g., EC2 |
| **PaaS** | Deploy code, platform manages infrastructure – e.g., Heroku |
| **SaaS** | Use applications over internet – e.g., Gmail |
| **Public cloud** | Multi-tenant, internet-accessible |
| **Private cloud** | Single organisation, own datacenter |
| **Hybrid cloud** | Public + private |
| **Virtualisation** | Software emulation of hardware |
| **VMM/Hypervisor** | Manages VMs on physical host |
| **Cyberinfrastructure** | Virtualised resources (VMs, virtual networks) |

**Exam trap (2024 Q1)**: Know which scenario matches which cloud type:
- "Company's usage peaks in summer, exceeding internal capacity" → **Hybrid cloud** (combine local + cloud) – 2025 Q1a answer **D**
- "Organisation creates cloud in own datacenter, no external access" → **Private cloud**
- "Resources shared across multiple organisations, internet-accessible" → **Public cloud**

**Exam trap (2025 Q1)**: Paravirtualisation, hardware-assisted virtualisation questions refer to **virtualisation types** (covered in later lecture).
# Lecture 3: Cloud Platform Architecture over Virtualised Datacenters – Part I: Compute and Storage

## Plan of the Lecture

### Goals
Understand concepts of cloud platform architectures

### Overview
- Hardware in Cloud computing: Benefits
- Data centre design
- Warehouse scale computing
- Cloud Architecture: System Level
- Compute
- Storage
- Aspect of heterogeneity
- Conclusion

---

## Hardware in Cloud computing: Benefits

> **Three hardware benefits that enabled cloud computing**:

1. **Illusion of infinite resources** – on-demand availability eliminates need for users to plan far ahead for resource provisioning.
2. **Elimination of up-front commitment** – users can start small and increase hardware resources when needed.
3. **Pay-as-you-go** – costs on short-term basis (e.g., processors by the hour, storage by the day), rewarding resource conservation.

**Example**: A startup launches a web app with 1 server. When traffic spikes, they automatically scale to 100 servers for 2 hours, then back to 1. They pay only for the 2 hours of extra capacity.

---

## Data centre design

> **Cluster Computing** = many similar machines, closely interconnected, specialised hardware, owned and managed by a single organisation.

**Clouds built on massive datacenters**:
- Size ranges from **edge facilities** to **megascale** (100,000 – 1 million servers)
- Power consumption: one server may use up to **500W**; one rack (42 servers) = **21kW** (3× average UK household)

> **Centralisation** = consolidate different machines and software into one location.

**Economies of scale** (approximate cost savings comparing 1,000 servers vs 400,000 servers):

| Cost Component | Small Center (1K servers) | Large Center (400K servers) |
|----------------|---------------------------|-----------------------------|
| Power | ~$0.30 | ~$0.15 |
| Cooling | ~$0.30 | ~$0.10 |
| Network bandwidth | ~$0.20 | ~$0.05 |
| Administration | ~$0.30 | ~$0.03 |

> **This data center is 11.5 times the size of a football field** (exam memorable figure).

---

## Warehouse scale computing

> **Warehouse Scale Computing (WSC)** provides Internet services: search, social networking, online maps, video sharing, online shopping, email, cloud computing.

### WSC vs HPC Clusters – Key Differences

| Aspect | HPC Clusters | WSC |
|--------|--------------|-----|
| **Processors/Network** | Higher performance | Cost-effective |
| **Parallelism type** | Thread-level (split heavy task across nodes) | Request-level (handle many independent requests) |
| **Workload** | Batch (simulations, modelling) | Interactive (search, social media) + Batch |
| **Design priority** | Peak performance | Cost-performance + energy efficiency |

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

---

## Cloud Architecture: System Level

### Architecture of a Small Server Cluster (~1000 servers)
- Interconnected by Ethernet switch
- Housed in warehouse or container environment
- **Typical elements**: 1U servers, racks with Ethernet switches, cluster-level Ethernet switch/router

### Racking & Networking Hierarchy

| Level | Scale | Description |
|-------|-------|-------------|
| **System** | 1 server | Individual compute node |
| **Rack** | ~40 systems | Installed and networked together |
| **Container** | ~1,000 systems | No packaging to remove, no floor space, weatherproof, easy transport |
| **Datacenter** | 100K+ systems | Construction takes **24+ months**; requires regulatory approval |

---

## Compute

### Heterogeneity Aspects

> **Heterogeneity** is one of the most profound and challenging characteristics of parallel environments.

| Level | Description |
|-------|-------------|
| **Macro level** | Networks of distributed computers (clouds) with diverse node architectures (single/multi-core), interconnected with heterogeneous networks |
| **Micro level** | Deeper memory hierarchies (main, cache, disk, tertiary storage) + accelerator architectures (fixed, programmable: GPUs, reconfigurable: FPGAs) |
| **Software** | OS, middleware, tools – also heterogeneous |

### Processor Types

| Type | Description | Characteristics |
|------|-------------|-----------------|
| **General Purpose Microprocessor (GPP)** | PCs, workstations, laptops | Execute multiple applications/tasks; flexible, portable |
| **Microcontroller** | Embedded systems | On-chip CPU, fixed RAM/ROM/I/O; low cost, low power, small |
| **Digital Signal Processor (DSP)** | Real-time mathematical computations | Multiply-accumulate units; programmable |
| **ASIP** (Application Specific Instruction Set Processor) | Hardware + instruction set designed together for one application | Better performance, lower cost, lower power than GPP |
| **ASIC** (Application Specific Integrated Circuit) | Algorithm completely implemented in hardware | Market-specific; rigid, hard to build; e.g., Tesla D1 chip (362 TFLOPS) |

### Accelerators / Coprocessors

> **Accelerators** perform functions more efficiently than CPU – **faster** and/or **lower energy**.

#### GPU (Graphics Processing Unit)
- Choice for **HPC**, **Machine Learning**, **Deep Learning**, **AI**
- **SIMT** (Single Instruction Multiple Thread) model – CUDA/OpenCL programming
- Efficient for **data parallel applications** (thousands of ALUs)
- Architecture: multiple Processor Clusters → Streaming Multiprocessors → dedicated L1/L2 cache → global GDDR5/GDDR6 memory
- **GPU is throughput-optimised** (more cores, parallel processing)
- **CPU is latency-optimised** (significant cache memory)

| | CPU | GPU |
|--|-----|-----|
| **Goal** | Low latency | High throughput |
| **Cache** | Large L1-L3 caches | Smaller caches |
| **Cores** | Few (8-64), complex | Many (thousands), simpler |
| **Memory** | DDR4 | GDDR5/6 (faster) |

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

| Feature | CPU | GPU | FPGA | ASIC |
|---------|-----|-----|------|------|
| **Market** | General | General + HPC | Niche | Specific |
| **Programmability** | Easy (C, Python) | Moderate (CUDA) | Hard (VHDL/Verilog) | None (fixed) |
| **Flexibility** | High | Medium | Medium | Low (rigid) |
| **Power efficiency** | Low | Medium | High | Highest |
| **Development cost** | Low | Medium | High | Very high |
| **Best for** | Sequential, complex logic | Parallel, matrix ops | Custom pipelines | Mass production |

---

## Storage

### Storage Options in Datacenters

| Type | Description |
|------|-------------|
| **Storage Area Network (SAN)** | Local dedicated network using Fibre Channel to connect storage devices |
| **Network Attached Storage (NAS)** | Dedicated hardware device on LAN (Ethernet); operates on data files like shared folder |
| **Local disks** | WSCs generally rely on local disks in servers; Google File System (GFS) uses local disks with **at least 3 replicas** |

> **WSC storage approach**: Use **local disks** + **replication** (e.g., GFS maintains 3+ replicas) rather than centralised SAN/NAS.

---

## Aspect of heterogeneity

> Heterogeneity exists at **macro level** (networked computers with diverse architectures) and **micro level** (memory hierarchies, accelerators). It is a **profound challenge** for parallel environments but also enables **specialised acceleration**.

**Example**: A cloud workload may use:
- **CPU** for control logic and sequential tasks
- **GPU** for matrix multiplication (ML inference)
- **FPGA** for custom packet processing
- **TPU** for neural network training

---

## Conclusion

- Reviewed design issues for cloud datacenters at system level:
  - **Servers, racks, clusters**
  - **Storage** (local disks with replication vs SAN/NAS)
  - **Networks** (covered in Lecture 4)
- Heterogeneity and specialised hardware are becoming **increasingly important** (GPUs, TPUs, FPGAs, ASICs)

---

## Quick Reference for This Lecture

| Concept | Key Point |
|---------|-----------|
| **3 hardware benefits** | Infinite resources (illusion), no upfront commitment, pay-as-you-go |
| **WSC vs HPC** | Request-level vs thread-level parallelism |
| **Server utilisation** | Can be as low as 5–20% |
| **Datacenter construction** | 24+ months |
| **1 rack power** | 42 servers × 500W = 21kW (3× average UK house) |
| **GPU programming** | CUDA, OpenCL – SIMT model |
| **TPU** | Google custom ASIC for ML (100 petaflops) |
| **FPGA** | Hardware-programmable (VHDL/Verilog) |
| **GFS replication** | At least 3 replicas on local disks |

**Exam traps**:
- **2024 Q1f**: FPGA for custom data acquisition/pre-processing
- **2025 Q1e**: TPU advantage = designed for ML computations
- **WSC vs HPC**: Don't confuse thread-level (HPC) with request-level (WSC) parallelism

---

# Lecture 4: Cloud Platform Architecture over Virtualised Datacenters – Part II: Networking

## Plan of the Lecture

### Goals
Understand concepts of cloud networking architectures

### Overview
- Cloud Architecture: System Level
- Data Centre Networks
- Architecture
- Ethernet
- Infiniband
- Software Defined Networks (SDN)
- Conclusion

---

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

| Speed | Status |
|-------|--------|
| 1GbE, 10GbE, 25GbE, 40GbE | Common |
| 100GbE, 200GE, 400GE | Increasingly common |
| 800GE, 1.6Tb/sec | Emerging (DCI ecosystem) |

> **Trend**: Data center optics transitioning to **400GE rates**. Fiber optics dominates backbone, top-of-rack uplinks, inter-rack, and inter-datacenter traffic.

---

## InfiniBand

> **InfiniBand** is a high-performance, software-defined, hardware-accelerated network technology used in HPC and cloud datacenters.

### InfiniBand Speed Generations

| Generation | Speed | Year context |
|------------|-------|--------------|
| SDR | 8 Gbps | Single Data Rate |
| DDR | 16 Gbps | Double Data Rate |
| QDR | 32 Gbps | Quad Data Rate |
| FDR | 56 Gbps | Fourteen Data Rate |
| EDR | 100 Gbps | Enhanced Data Rate |
| HDR | 200 Gbps | High Dynamic Range |
| NDR | 400 Gbps | Next Data Rate |
| XDR | 800 Gbps | eXtreme Data Rate |

> **Projection**: 1.6 Tb/sec ports → 64 ports × 1.6 Tb/sec = **102.4 Tb/sec** switch throughput.

### In-Network Acceleration

> **Goal**: Shift computational tasks from CPUs/GPUs to network devices (switch ASIC, NIC, DPU) to improve efficiency and reduce latency.

| Technology | Description |
|------------|-------------|
| **PDA** (Programmable Datapath Accelerator) | Specialised hardware (usually in NIC) programmable to process/filter/route data before it reaches CPU |
| **RDMA** (Remote Direct Memory Access) | Transfer data directly between host memories **without involving CPU** |
| **BlueField DPU** (NVIDIA) | Offloads, accelerates, isolates datacenter infrastructure tasks from CPU; can virtualise networking and storage |
| **SHARP** (Scalable Hierarchical Aggregation Protocol) | In-network computing inside InfiniBand switches; offloads MPI collective operations to switches |
| **SHIELD** (Self-Healing Interconnect Enhancement) | Security feature of BlueField DPUs; improves fault recovery |

---

## Software Defined Networks (SDN)

> **SDN** = rethinking network architectures with **abstractions** – clear interfaces, **programmability**. Some functionality is **defined by software** (controlled by controlling software).

### Core Insight (Scott Shenker)
> Current networks are designed to **"master the complexity"** behind existing technologies, rather than **"extract simplicity"** from learned lessons. Abstractions play a big role in CS – shielding high-level software from low-level complexity.

### Separation of Planes

| Plane | Function | Location in SDN |
|-------|----------|-----------------|
| **Data plane** | Packet forwarding (logic/tables for how to handle packets) | Remains in device (switch) |
| **Control plane** | Decision making (algorithms that program the data plane) | Moved to **centralised controller** |

**Traditional networks**: Control and data planes are coupled (each switch makes its own decisions)

**SDN networks**: Centralised controller makes decisions; switches just forward packets

### SDN Components

| Component | Function |
|-----------|----------|
| **SDN switches** (e.g., Open vSwitch) | Forward packets based on flow tables |
| **Controller** (e.g., ONOS) | Implements control plane; presents abstraction of network to applications; maintains **global network view** |
| **SDN applications** | Built on controller; implement routing, access control, load balancing, etc. |
| **OpenFlow** | Network control protocol; enables controller to manage switches by separating control from data plane |

### Flow Tables

> **Flow tables** reside on network devices; contain **flow entries** with **match fields** and **actions**.

**Operation**:
1. Device matches incoming packet against flow table
2. If match found → take action (forward, drop, send to controller)
3. If no match → drop or pass to controller

**Forwarding Actions**:

| Action | Description |
|--------|-------------|
| **Physical Port** | Send out specific physical port |
| **CONTROLLER** | Send to controller |
| **ALL** | Send to all ports |
| **DROP** | Discard packet |
| **NORMAL** | Standard L2/L3 forwarding |
| **MODIFY FIELD** | Change header field (IP, MAC, VLAN) before forwarding |

---

## Conclusion

- **In-network computing and security** enable modern datacenters to handle complex requirements
- **Ethernet** is a trend in datacenters; **InfiniBand** offers software-defined, hardware-accelerated networking for HPC
- **SDN simplifies management** of complex datacenter networks
- SDN has **profound impact** on how communication networks are designed and implemented

---

## Comparison Table: Ethernet vs InfiniBand

| Feature | Ethernet | InfiniBand |
|---------|----------|------------|
| **Primary use** | General datacenters, LAN | HPC, supercomputers, AI clusters |
| **Speed (current)** | 1GbE – 400GE | HDR (200Gbps), NDR (400Gbps) |
| **Protocol** | TCP/IP, UDP | IB transport (RDMA native) |
| **CPU involvement** | High (TCP/IP stack) | Low (RDMA, hardware offload) |
| **Programmability** | SDN (OpenFlow) | SHARP, PDA, DPU |
| **Cost** | Lower | Higher |
| **Latency** | Higher | Very low |

---

## Quick Reference for This Lecture

| Concept | Key Point |
|---------|-----------|
| **Load balancer** | Application-layer routing; hides datacenter internals |
| **TOR switch** | Top of Rack – connects servers to network |
| **InfiniBand speeds** | SDR → DDR → QDR → FDR → EDR → HDR → NDR → XDR |
| **NDR** | 400 Gb/sec (NVIDIA Quantum2) |
| **XDR projection** | 800 Gb/sec; 1.6 Tb/sec possible |
| **RDMA** | Direct memory-to-memory transfer without CPU |
| **DPU** | Data Processing Unit (e.g., BlueField) – offloads infrastructure tasks |
| **SDN** | Separates control plane (centralised) from data plane (in switches) |
| **OpenFlow** | Protocol for controller to manage switches |
| **Flow table** | Match fields + actions on switch |

**Exam traps**:
- SDN = **control plane centralised**, data plane distributed
- OpenFlow = **protocol**, not the controller itself
- InfiniBand speeds: remember **HDR=200G, NDR=400G, XDR=800G**
- SHARP = in-switch collective operations; SHIELD = security/fault recovery

---

# Lecture 5: Virtualisation – Part I

## Plan of the Lecture

### Goals
Understand concepts of virtualisation

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

---

## Definitions

> **Virtual Machine (VM)** = a representation of a real machine using software that provides an operating environment which can run or host a **guest operating system**.

> **Guest Operating System** = an operating system running in a virtual machine environment that would otherwise run directly on a separate physical system.

> **Virtualization Layer** = middleware between underlying hardware and virtual machines.

### Virtual Machine Isolation and Encapsulation

| Benefit | Description |
|---------|-------------|
| **Secure multiplexing** | Run multiple VMs on single physical host |
| **Strong guarantees** | Processor hardware isolates VMs |
| **Performance isolation** | Partition system resources |
| **Snapshots and clones** | Capture VM state on the fly; restore to point-in-time |
| **Encapsulation** | VM can be saved as a file (image) containing OS, apps, data, memory, device state |

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

---

## Implementation Levels of Virtualisation

| Level | What is intercepted | Description |
|-------|---------------------|-------------|
| **Application virtualisation** | Application-OS interactions | App believes it runs alone or in different environment |
| **Library (user-level API) virtualisation** | API calls (system calls, libraries) | Redirects or modifies behaviour (hooks, wrappers) |
| **Operating System / Containers virtualisation** | OS kernel-resource interactions | Each container gets illusion of its own OS environment |
| **Hardware Abstraction Layer (HAL) / Hypervisors** | Hardware access (CPU, memory, I/O) | Presents virtual hardware to each VM |
| **Instruction Set Architecture (ISA) virtualisation (emulation)** | CPU instructions | Translates one instruction set to another |

---

## Machine Level Virtualisation

### Two Approaches

| Approach | Type | Description | Examples |
|----------|------|-------------|----------|
| **Hosted** | Type 2 | Runs over host OS; second layer over hardware | VMware Workstation, VirtualBox |
| **Bare metal** | Type 1 | Sits directly on hardware; first layer over hardware | VMware ESXi, Xen, KVM, Hyper-V |

**Exam tip**: Type 1 = **bare metal** (no host OS). Type 2 = **hosted** (has host OS).

---

## x86 Privileged Architecture (Before Virtualisation)

- x86 has **4 privilege levels**: **Ring 0, 1, 2, 3**
- Operating System needs **Ring 0** (most privileged) for direct hardware access
- User applications run in **Ring 3** (least privileged)
- Non-privileged instructions execute directly on CPU
- **System calls** request OS to perform privileged operations safely

**Problem for virtualisation**: Some instructions were **sensitive** (affect system state) but **not privileged** (could execute outside Ring 0 without trapping). Called **non-virtualisable instructions**.

---

## Hypervisor-based Virtualisation

> Hypervisor presents virtual operating platform to guest systems; monitors and manages execution.

### Three Categories

| Category | Guest OS Modification? | How it works | Performance | Examples |
|----------|------------------------|--------------|-------------|----------|
| **Full virtualisation** | **No** (unmodified OS) | Binary translation of critical instructions | Slower (emulation overhead) | VMware, Microsoft Virtual Server |
| **Para-virtualisation** | **Yes** (OS modified) | Guest uses **hypercalls** to VMM; no binary translation | Better than full | Xen, KVM, VMware ESX |
| **Hardware-assisted** | **No** (unmodified OS) | CPU provides VT-x/AMD-V; hardware handles privileged instructions | Best (near-native) | KVM, VMware on modern CPUs |

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

---

## Operating System Level Virtualisation (Containers)

> **OS-level virtualisation** = single OS kernel shared across multiple isolated user-space instances (containers). Each container gets illusion of its own OS environment.

**Examples**: Docker, LXC, OpenVZ

**Comparison (preview – detailed in later lecture)**:

| Feature | VMs (Type 1/2) | Containers |
|---------|----------------|------------|
| **Isolation** | Full OS-level | Process-level |
| **Guest OS** | Each VM has own | Shared host kernel |
| **Boot time** | Minutes | Milliseconds |
| **Size** | GBs | MBs |
| **Overhead** | Higher | Near-zero |

---

## Examples

| Hypervisor | Type | Virtualisation method |
|------------|------|----------------------|
| VMware Workstation | Type 2 | Full virtualisation |
| VirtualBox | Type 2 | Full virtualisation |
| VMware ESXi | Type 1 | Full + hardware-assisted |
| Xen | Type 1 | Para-virtualisation (or HVM with hardware assist) |
| KVM | Type 1 (Linux kernel module) | Hardware-assisted |
| Microsoft Hyper-V | Type 1 | Hardware-assisted |

---

## Conclusion

- Virtualisation enables **secure multiplexing**, **performance isolation**, **snapshots**, **encapsulation**
- Three hypervisor-based techniques: **full**, **para**, **hardware-assisted**
- Hardware-assisted (VT-x/AMD-V) offers **lowest overhead**
- Containers (OS-level) offer **lightweight alternative** (Lecture 6)
- VIM (OpenStack, OpenNebula) manages virtual resources at scale

---

## Comparison Table: Virtualisation Techniques

| Feature | Full | Para | Hardware-assisted |
|---------|------|------|-------------------|
| **Guest OS modification** | No | Yes | No |
| **Binary translation** | Yes | No | No |
| **Hypercalls** | No | Yes | No |
| **CPU support required** | No | No | Yes (VT-x/AMD-V) |
| **Performance** | Lowest | Medium | Highest |
| **Compatibility** | High | Low | High |

---

## Quick Reference for This Lecture

| Term | Definition |
|------|------------|
| **Hypervisor** | Software that manages VMs |
| **Type 1** | Bare-metal (runs directly on hardware) |
| **Type 2** | Hosted (runs on host OS) |
| **VIM** | Virtual Infrastructure Manager (OpenStack, OpenNebula) |
| **Full virtualisation** | Unmodified guest, binary translation |
| **Para-virtualisation** | Modified guest, hypercalls |
| **Hardware-assisted** | VT-x/AMD-V, near-native performance |
| **Ring 0** | Most privileged x86 level (OS) |
| **Ring 3** | Least privileged (user apps) |
| **Non-virtualisable instructions** | Sensitive but not privileged; require binary translation |

**Exam traps**:
- **2025 Q1b**: Paravirtualisation benefit = **improves performance by reducing overhead** (C)
- **2025 Q1c**: Hardware-assisted virtualisation = **CPU provides support** (B) + **hypervisor emulates hardware** (A) – select two
- **2025 Q1d**: VM communication = **private IP + virtual private bridge** (C)
# Lecture 6: Virtualisation Part II – Containers

## Plan of the Lecture

### Goals
Understand concepts of virtualisation

### Overview
- Virtual Machines: Recap
- Container technologies
- VMs vs Containers
- Example: Docker
- The case for Unikernels
- Conclusion

---

## Virtual Machines: Recap

> **Virtualisation** = a level of indirection between hardware and software. **Virtual Machine (VM) abstraction** runs all software written for physical machine.

**Challenge addressed**: Infrastructure heterogeneity, hidden complexity from apps, manage and coordinate micro-services reliably, scale and move services quickly without downtime.

**Analogy (cargo transport)** : Historically, cargo handling faced similar challenges – different container sizes, shapes, handling requirements. Solution = **intermodal shipping container** – standardised, stackable, transferable across ships, trains, trucks.

> **Containers are the "shipping containers" of software** – standardised units that package code + dependencies, run anywhere.

---

## Container Technologies

> **Container** virtualises the **OS rather than the hardware**. Uses a single kernel to run multiple isolated OS instances.

**Key characteristics**:
- Each instance runs in **completely isolated environment**
- Fewer components to patch, less attack surface at application level
- **However**: rely heavily on host kernel – kernel vulnerabilities are critical
- Offers **greater efficiency and performance** than conventional hypervisor

### Container History Timeline

| Year | Technology | Significance |
|------|------------|--------------|
| 1979 | **chroot** (Unix) | First isolation mechanism (change root directory) |
| 1998 | **FreeBSD jails** | First practical implementation |
| 2005 | Solaris Zones, OpenVZ | Resource control, stronger isolation |
| 2008 | **LXC** (Linux Containers) | First modern Linux container tech – combines cgroups + namespaces |
| 2013 | **Docker** | Made containers accessible ("what ChatGPT did for LLMs") |

### Containers vs Hypervisors

| | Type 1 Hypervisor | Type 2 Hypervisor | Containers |
|--|------------------|-------------------|------------|
| **Location of abstraction** | Below host OS | Within host OS | Above OS kernel |
| **What is abstracted** | Hardware | Hardware | OS kernel |
| **Isolation mechanism** | Hardware + VMM | Hardware + VMM + host OS | Kernel namespaces + cgroups |
| **Performance** | Good | Moderate | **Best** |

**Key insight**: chroot + Linux kernel features (cgroups for resource limits, namespaces for isolation) = container foundation.

---

## VMs vs Containers – Detailed Comparison

| Feature | Virtual Machines | Containers |
|---------|-----------------|------------|
| **Isolation level** | Full OS-level (strong) | Process-level (weaker) |
| **Guest OS** | Each VM has own full OS | Share host kernel |
| **Boot time** | Minutes | **Seconds or milliseconds** |
| **Size** | Gigabytes (full OS image) | **Megabytes** (app + dependencies) |
| **Portability** | Constrained to hypervisor, hardware-emulation | **Run anywhere** with compatible kernel |
| **Management cost** | High (each VM requires full OS management) | Low (single kernel to manage) |
| **Resource overhead** | High | **Near-zero** |
| **Use cases** | Legacy apps, multi-OS, strong isolation | DevOps, batch computing, **microservices** |

> **Clear advantage for containers in**: DevOps, batch computing, microservices.

---

## Microservices Architecture

> **Microservices** = architectural pattern where an application is decomposed into **small, autonomous services** that work together.

**Characteristics**:
- Unit of distribution = **single service granularity**
- **Loosely coupled** components
- **API-accessible** (via chosen protocol, e.g., HTTP)
- Each service developed and deployed **independently**

**Monolithic vs Microservices**:

| Aspect | Monolithic | Microservices |
|--------|------------|---------------|
| **Scaling** | Replicate entire monolith | Replicate only needed services |
| **Changes** | Change entire application | Change individual services |
| **Fault isolation** | Failure affects everything | Failure isolated to one service |
| **Development** | Large team, coordinated releases | Small teams, independent deployment |

> **Containers provide an excellent environment for running microservices** – each microservice runs in its own container, multiple copies for load balancing.

**Typical container contents**: single executable service (a microservice). Multiple containers for same microservice run same code, linked via message queuing or load balancing.

---

## Container Management Platforms

> **Container Management Platforms** (aka container orchestration engines, CaaS platforms) help enterprises address challenges of deploying containers. They let administrators **monitor, manage, secure, and scale containers** like existing servers/VMs.

**Examples**: Docker Swarm, Kubernetes, Amazon ECS, Azure Container Instances.

---

## Example: Docker

> **Docker** = open-source project for developing, packaging, distributing, and running applications inside software containers. Provides additional abstraction and automation of OS-level virtualisation on Linux.

**Analogy**: "docker" (person employed in port to load/unload ships) → uniform wrapper around software package: **"Build, Ship and Run Any App, Anywhere"**

### Docker Core Definitions

| Term | Definition |
|------|------------|
| **Image** | Read-only template (binary artifact) that defines how to create a container |
| **Container** | Instantiation of an image; a **running instance** |
| **Runtime** | Tool or service to execute and manage containers |
| **Registry** | Service to store and distribute images (e.g., **Docker Hub**) |

### Docker Engine Components

| Component | Function |
|-----------|----------|
| **Docker Daemon (dockerd)** | Runs on host machine; long-running background service; manages images, containers, networks, volumes; provides Docker API |
| **Docker Client** | User interface; communicates with Docker Daemon to execute commands |
| **REST API** | For interacting with Docker Daemon remotely |

### Dockerfile and Images

> **Dockerfile** = end-user writes instructions to build a Docker image. Images are **read-only templates** (saved on disk) built from Dockerfile instructions. Define both the packaged application and its dependencies, plus processes to run on launch.

### Docker Analogy

| Docker Concept | Analogy |
|----------------|---------|
| Docker Client | Waiter (takes order) |
| Docker Daemon | Manager (coordinates kitchen) |
| Docker Image | Recipe (instructions) |
| Runtime | Chef (executes recipe) |
| Container | Dish Served (final product) |

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

---

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

---

## Conclusion

- **Containers** = alternative to Virtual Machines
- Comprise just the **application + its dependencies**
- Run as **isolated process in user space** on host OS, sharing kernel with other containers
- Enjoys resource isolation and allocation benefits of VMs but is **much more portable and efficient**

**Note**: Singularity (http://singularity.lbl.gov/) is an alternative to Docker, designed for scientific/HPC environments.

---

## Comparison Table: Deployment Options

| Feature | Dedicated HW | Virtual Machine | Container | Unikernel |
|---------|--------------|----------------|-----------|-----------|
| **Isolation** | Full (physical) | Full (hardware) | Process-level | Process-level |
| **Guest OS** | Native OS | Full OS per VM | Shared kernel | Minimal kernel |
| **Boot time** | Minutes | Minutes | Seconds/milliseconds | Milliseconds |
| **Size** | Full OS | GBs | MBs | KBs-MBs |
| **Overhead** | None | High | Low | Very low |
| **Use case** | Performance-critical | Legacy, multi-OS | Microservices, DevOps | IoT, edge, specialized |

---

## Quick Reference for This Lecture

| Term | Definition |
|------|------------|
| **Container** | Isolated user-space instance sharing host kernel |
| **chroot** | 1979 Unix isolation (change root directory) |
| **LXC** | 2008 – first modern Linux container tech (cgroups + namespaces) |
| **Docker** | 2013 – made containers accessible |
| **Image** | Read-only template for containers |
| **Container** (Docker) | Running instance of an image |
| **Docker Daemon** | Background service managing containers |
| **Docker Hub** | Public registry for Docker images |
| **Docker Compose** | Multi-container YAML orchestration |
| **Microservices** | Small, autonomous, loosely coupled services |
| **Unikernel** | App + minimal OS components, no general-purpose OS |

**Exam traps**:
- **2025 Q1c (implied)** : Container vs VM performance – containers boot **seconds** vs VMs **minutes**
- **Migration**: containers are portable but share kernel; VMs have stronger isolation
- **Unikernels** = even lighter than containers, but less mature
- **Docker Compose** = multi-container orchestration (simpler than Kubernetes)

---

# Lecture 7: Cloud Virtual Infrastructure Management

## Plan of the Lecture

### Goals
Understand Virtual Infrastructure Manager (VIM) features

### Overview
- Introduction
- Virtual Infrastructure Managers
- Architectural view
- Examples: OpenNebula and OpenStack
- Considerations: Compute, Storage, Network
- Programming – APIs
- Conclusion

---

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

---

## Virtual Infrastructure Managers – Architectural View

### OpenNebula (https://opennebula.io/)

**Additional interaction methods**: CLIs and APIs.

| Feature | Function |
|---------|----------|
| **Internal Interface** | Unix-like CLI for VM life-cycle + physical boxes; XML-RPC API and libvirt virtualization API |
| **Scheduler** | Requirement/rank matchmaker for workload and resource-aware allocation policies |
| **Virtualization Management** | Xen, KVM, VirtualBox, VMware; Generic libvirt connector |
| **Image Management** | Transfer and clone VM images |
| **Network Management** | Define isolated virtual networks to interconnect VMs |
| **Service Management** | Support for multi-tier services with auto-configuration at boot |
| **Security** | User management by infrastructure administrator |
| **Fault Tolerance** | Persistent database backend for host and VM info |
| **Scalability** | Tested with hundreds of servers and VMs |
| **Installation** | On UNIX cluster front-end without new services |
| **Flexibility** | Open, extensible architecture for integration with any product/tool |

### OpenNebula Architecture – Storage Considerations

| Approach | Description |
|----------|-------------|
| **NAS** (Network Attached Storage) | VMs and images represented as **files** |
| **SAN** (Storage Area Network) | VMs and images represented as **block devices** (like a disk) |

### OpenNebula – Networking Demands

| Traffic Type | Description |
|--------------|-------------|
| **Management operations** | Use ssh connections |
| **Image traffic** | May require moving heavy files (VM images, checkpoints) |
| **VM demands** | Typical requirements of thousands of VMs |
| **NICs for VM traffic** | Configuration of MAC and IP addresses |
| **Bridge networking (Layer 2)** | VIM creates bridges for VMs; Linux bridge acts as virtual Ethernet switch connecting vNICs and physical NICs |

### OpenNebula – VM Description

| Option | Description |
|--------|-------------|
| **NAME** | VM name for description purposes |
| **CPU** | Percentage of CPU ÷ 100 required for the VM |
| **OS (KERNEL, INITRD)** | Path of kernel and initrd files to boot from |
| **DISK (SOURCE, TARGET, CLONE, TYPE)** | Disk image to attach to VM |
| **NIC (NETWORK)** | Virtual network the VM will be attached to |

> **Principle**: Install once, deploy many – prepare master images.

### OpenNebula – Interaction Methods

| Method | Description |
|--------|-------------|
| **Sunstone GUI** | Web interface for admins and users |
| **CLI** (Command Line Interface) | Tools like `onevm`, `onevnet`, etc. |
| **OpenNebula Cloud API (OCA) Libraries** | Ruby, Java, Python for automation |
| **XML-RPC API** | Simple, fast, any language; for advanced integrations |

---

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

| Project | Function | Component Name |
|---------|----------|----------------|
| **Compute** | Provision and manage virtual resources | **Nova** |
| **Storage (Block)** | Persistent block storage | **Cinder** |
| **Network** | Software-defined networking | **Neutron** |
| **Dashboard** | Self-service portal | **Horizon** |
| **Image** | Catalog and manage server images | **Glance** |
| **Identity** | Unified authentication, RBAC | **Keystone** |
| **Object Storage** | Petabytes of secure, reliable object storage | **Swift** |

### OpenStack Compute (Nova) – Key Capabilities

| Capability | Description |
|------------|-------------|
| **Manage virtualised server resources** | CPU, memory, disk, network interfaces |
| **API with authentication** | Programmatic access |
| **Distributed and asynchronous architecture** | Scalable |
| **Massively scalable, highly available** | Production-grade |
| **Live guest migration** | Move running VMs between physical hosts |
| **Live VM management** | Run, reboot, suspend, resize, terminate |
| **Security Groups** | Firewall rules |
| **Role-Based Access Control (RBAC)** | Security by user, role, project |
| **Projects & Quotas** | Resource limits per project |

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

| Project | Function |
|---------|----------|
| **Heat** | Orchestration of multiple composite cloud applications |
| **Mistral** | Workflow management |
| **Zun** | Launch and manage containers (instead of VMs) |
| **Ceilometer** | Billing systems (resource consumption) |
| **Trove** | Database as a Service |
| **Sahara** | Rapidly provision Hadoop clusters |

---

## Programming – APIs

**Interaction with OpenStack**:
1. OpenStack portal (Horizon – web GUI)
2. Python SDK for OpenStack APIs

**For OpenNebula**:
- XML-RPC API
- OCA libraries (Ruby, Java, Python)
- CLI tools

---

## Conclusion

- Presented Virtual Infrastructure Management features
- Two examples: **OpenNebula** (simpler, lightweight) vs **OpenStack** (complex, full-featured)
- Both provide setting up **private and hybrid clouds**
- OpenStack modular architecture with **7 core projects**
- Additional projects (Heat, Zun, Ceilometer, Sahara, etc.) extend functionality

---

## Comparison Table: OpenNebula vs OpenStack

| Feature | OpenNebula | OpenStack |
|---------|------------|-----------|
| **Complexity** | Simple, lightweight | Complex, full-featured |
| **Target scale** | Medium (hundreds of servers) | Large (thousands+ servers) |
| **Architecture** | Monolithic | Modular (many projects) |
| **Scheduler** | Rank scheduling | Multiple schedulers (Nova filters) |
| **Networking** | Basic bridge networking | Neutron (SDN, advanced) |
| **Storage** | NAS or SAN | Cinder (block) + Swift (object) |
| **Dashboard** | Sunstone | Horizon |
| **API** | XML-RPC, OCA | REST (OpenStack APIs) |
| **Use case** | Simple private clouds | Large-scale, carrier-grade, hybrid |

---

## Quick Reference for This Lecture

| Term | Definition |
|------|------------|
| **VIM** | Virtual Infrastructure Manager |
| **Server consolidation** | Reducing physical servers by running multiple VMs on fewer hosts |
| **OpenNebula** | Lightweight VIM for medium-scale private clouds |
| **OpenStack** | Full-featured VIM for large-scale, carrier-grade clouds |
| **Nova** | OpenStack Compute service |
| **Neutron** | OpenStack Networking service |
| **Cinder** | OpenStack Block Storage |
| **Glance** | OpenStack Image service |
| **Keystone** | OpenStack Identity service |
| **Horizon** | OpenStack dashboard |
| **Swift** | OpenStack Object Storage |
| **RabbitMQ** | Default message queue for OpenStack |

**Exam traps**:
- **VIM is NOT the hypervisor** – it manages hypervisors (scheduling, images, networking)
- **OpenStack vs OpenNebula** – know which is suitable for which scale
- **Server consolidation** = energy efficiency (fewer physical servers running)
- **Live migration** requires shared storage (SAN/NAS) for disk state

---

# Lecture 8: Cloud Resource Management and Scheduling

## Plan of the Lecture

### Goals
Understand concepts of resource management and scheduling in clouds

### Overview
- Introduction
- Cloud Resource Management
- Scheduling Approaches
- Live Migration Issues
- Scaling Up/Out
- Conclusion

---

## Introduction

### Resource Management and Scheduling

> **Scheduling** = deciding how to allocate resources (hosts, CPU cycles, memory, storage space, I/O, network bandwidth) between users and tasks.

**Affects three basic criteria for system evaluation**: performance, cost, energy.

**Policies vs Mechanisms**:
- **Policy**: principles guiding decisions (e.g., maximise resource utilisation, maximise profit)
- **Mechanisms**: means to implement policies (e.g., scheduling algorithms)

---

## Cloud Resource Management

### What is Required?

> **SLA (Service Level Agreement)** = contract between provider and consumer specifying QoS guarantees (uptime, performance, response time).

**Cloud resource management**:
- Requires **complex policies and decision making** – a **multi-objective optimisation problem**
- Is challenging – accurate global state information difficult
- Affected by unpredictable interactions (failures, attacks)
- Highly variable workloads test cloud elasticity

### Cloud Resource Management Policies

| Policy | Description |
|--------|-------------|
| **Admission control** | Prevent system from accepting workload that would violate policies or exceed resources |
| **Capacity allocation** | Allocate resources for individual service activations |
| **Load balancing** | Distribute workload evenly among servers |
| **Energy optimisation** | Minimise energy consumption |
| **QoS guarantees** | Satisfy timing/conditions specified by SLA |

### Cloud Scheduling: Nested Resource Levels

> Scheduling responsible for resource sharing at **multiple levels**:
> 1. Physical host shared among several VMs
> 2. A VM supports several applications
> 3. An application may consist of multiple threads

**Cloud Computing Scheduling = Resource Sharing Hierarchy**

### Scheduler Objectives by Workload Type

| Workload Type | Objective |
|---------------|-----------|
| **Batch system** | Maximise throughput, minimise turnaround time |
| **Real-time system** | Meet deadlines, be predictable (very difficult) |
| **Best effort** | Fair resource sharing |

**Best effort scheduling algorithms**: Round-Robin (RR), First-Come-First-Served (FCFS), Shortest-Job-First (SJF), Priority Algorithms. Fairness indexes can be calculated.

---

## Scheduling Approaches

### VM Scheduling in OpenNebula

> Scheduler **matches waiting VMs with available hosts**. **Match making** = takes VM's requirements and matches with physical host that can support them.

**Rank Scheduling Policy**: prioritises resources more suitable for the VM.

### VM Scheduling Approaches – Examples

| Approach | Focus |
|----------|-------|
| **Power-aware** | Minimise power consumed by physical hosts to maximise revenues |
| **Performance-aware** | Maintain service levels while improving resource utilisation via dynamic placement |
| **Network-aware** | Minimise effect of data transfer time between VM instances and data storage |
| **Heuristics** | Service disciplines like FCFS, RR |

### VM Scheduling Example: First Fit

> Place each VM on the **first physical host** that has sufficient resources (CPU, memory, etc.). Simple but may lead to fragmentation.

### Power-aware Example

> Which configuration is better? **485 Watts vs 552 Watts** – lower power consumption is better for energy optimisation.

---

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

| Method | Description | Pros | Cons |
|--------|-------------|------|------|
| **Precopy** | First copies memory state through repetitive process, then transfers processor state | Higher reliability | May repeatedly copy inconsistent "dirty pages" |
| **Postcopy** | Transfers processor state first; memory pages fetched on-demand | Avoids repeated dirty page copying | Performance degradation from page faults, network delays; less stable |

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

---

## Scaling Up/Out

| Strategy | Description | Analogy |
|----------|-------------|---------|
| **Scaling Out** (Horizontal) | Getting additional VM(s) to spread application processing load | Add more servers |
| **Scaling Up** (Vertical) | Upgrading current hardware components within VM, or replacing VM with better performance version | Make existing server bigger |

> **Cloud elasticity**: scale out for increased load, scale in when load decreases.

---

## Conclusion

- Reviewed important aspects of cloud resource management and scheduling
- Many VM scheduling approaches exist in literature – **still an important research problem**
- Issues with VM migration (memory, network, storage) remain challenging

---

## Quick Reference for This Lecture

| Term | Definition |
|------|------------|
| **SLA** | Service Level Agreement – QoS guarantees |
| **Admission control** | Reject workload that would violate policies |
| **Load balancing** | Distribute workload evenly |
| **Server consolidation** | Reduce physical servers, run multiple VMs |
| **Precopy migration** | Copy memory first, then CPU state (reliable) |
| **Postcopy migration** | Copy CPU first, fetch memory on-demand (faster but less stable) |
| **Unsolicited ARP reply** | Announces new MAC for same IP after LAN migration |
| **Scaling out** | Add more VMs (horizontal) |
| **Scaling up** | Make VM bigger (vertical) |
| **Hotspot** | Excessive overloading of CPU/memory/network/storage |

**Exam traps**:
- **Precopy = reliable** (preferred); **Postcopy = faster but less stable**
- **LAN migration** = same private IP, unsolicited ARP
- **WAN migration** = new public/private IPs, use DNS names
- **Scaling out** = more VMs; **Scaling up** = bigger VM
- **Server consolidation** reduces physical servers → saves energy
