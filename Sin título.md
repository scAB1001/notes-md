# Cloud Computing Systems – Exam Revision Master Document

## Comparison Tables

### MPI vs OpenMP vs MapReduce vs TensorFlow [!P]

| Aspect | MPI | OpenMP | MapReduce | TensorFlow |
|--------|-----|--------|-----------|------------|
| **Paradigm** | Message passing | Shared memory | Data-parallel | Data-flow graph |
| **Memory** | Distributed | Shared | Distributed (HDFS) | Distributed (optional) |
| **Granularity** | Process | Thread | Task (Map/Reduce) | Operation |
| **Best for** | HPC simulations | Single-node parallelism | Batch data processing | Machine Learning |
| **Cloud use** | HPC on cloud clusters | Limited to single VM | Big data analytics | AI/ML training/inference |
| **Languages** | C, Fortran, Python | C, C++, Fortran | Java, Python (Hadoop Streaming) | Python, C++ |

### Hadoop 1.0 vs Hadoop 2.0 (YARN) vs Spark [!P]

| Feature | Hadoop 1.0 | Hadoop 2.0 (YARN) | Spark |
|---------|------------|-------------------|-------|
| **Resource management** | JobTracker (monolithic) | ResourceManager + NodeManager | Own manager or YARN/Mesos/K8s |
| **Processing model** | MapReduce only | Multiple frameworks | Batch, interactive, streaming, iterative |
| **Storage** | HDFS (disk-based) | HDFS (disk-based) | In-memory + disk |
| **Speed** | Baseline | ~2× throughput | 10–100× faster (in-memory) |
| **Fault tolerance** | Task re-execution | Task re-execution | RDD lineage (recompute) |
| **Programming model** | Rigid (map/reduce) | Flexible | Unified APIs (SQL, ML, streaming) |
| **Iterative processing** | Poor (many disk writes) | Poor | Excellent (in-memory caching) |

### HPA vs Cluster Autoscaler [!P]

| Feature | HPA | Cluster Autoscaler |
|---------|-----|-------------------|
| **Scales** | Pods (replicas) | Nodes (cluster size) |
| **Trigger** | CPU utilisation, custom metrics | Pods pending due to insufficient resources |
| **Scale-to-zero** | No (min replicas >0) | Yes (idle nodes removed) |

### Serverless vs Containers vs VMs [!P]

| Aspect | Serverless | Containers | VMs |
|--------|------------|------------|-----|
| **Unit of deployment** | Function (code) | Container image | VM image |
| **Scale-to-zero** | **Yes** | No (min replicas usually 1) | No |
| **Cold start** | **Yes** – latency penalty | No | No (but boot time minutes) |
| **Billing** | Per invocation + compute time | Pay for running instances | Pay for running VMs |
| **State** | Stateless | Stateful possible | Stateful possible |

### Virtualisation Techniques [!P]

| Feature | Full | Para | Hardware-assisted |
|---------|------|------|-------------------|
| Guest OS modification | No | Yes | No |
| Binary translation | Yes | No | No |
| Hypercalls | No | Yes | No |
| CPU support required | No | No | Yes (VT-x/AMD-V) |
| Performance | Lowest | Medium | Highest |
| Compatibility | High | Low | High |

### VMs vs Containers [!P]

| Feature | Virtual Machines | Containers |
|---------|-----------------|------------|
| Isolation | Full OS-level | Process-level |
| Guest OS | Each VM has own | Shared host kernel |
| Boot time | Minutes | Seconds/milliseconds |
| Size | GBs | MBs |
| Overhead | High | Near-zero |
| Use cases | Legacy, multi-OS | Microservices, DevOps |

### Deployment Options (Dedicated HW → VM → Container → Unikernel) [!P]

| Feature | Dedicated HW | VM | Container | Unikernel |
|---------|--------------|-----|-----------|-----------|
| Isolation | Full (physical) | Full (hardware) | Process-level | Process-level |
| Boot time | Minutes | Minutes | Milliseconds | Milliseconds |
| Size | Full OS | GBs | MBs | KBs-MBs |
| Overhead | None | High | Low | Very low |

### Edge vs Fog vs Cloud

| | Edge | Fog | Cloud |
|---|------|-----|-------|
| Location | End-devices | Intermediate LAN nodes | Centralised datacenters |
| Latency | Lowest | Low | High |
| Function | On-device decisions | Aggregation, filtering | Heavy analytics, storage |

### Wireless IoT Protocols Comparison [!P]

| Feature | LoRaWAN | NB-IoT | Wi-Fi 6 | BLE | Zigbee |
|---------|---------|--------|---------|-----|--------|
| Range | 2–10 km | 1–10 km | 1–100 m | 1–100 m | 1–100 m |
| Battery life | 1000+ days | 1000+ days | 100–1000 days | 100–1000 days | 100–1000 days |
| Bandwidth | 0.3–50 Kbps | 20–250 Kbps | 600+ Mbps | 125–2000 Kbps | 20–250 Kbps |

### Hardware Accelerators Comparison [!P]

| Feature | CPU | GPU | FPGA | ASIC | TPU |
|---------|-----|-----|------|------|-----|
| Programmability | Easy | Moderate | Hard | None (fixed) | Via frameworks |
| Flexibility | High | Medium | Medium | Low (rigid) | Low (ML-specific) |
| Power efficiency | Low | Medium | High | Highest | Very high |
| Best for | Sequential logic | Parallel, matrix ops | Custom pipelines | Mass production | ML inference/training |

### OpenStack vs OpenNebula [!P]

| Feature | OpenNebula | OpenStack |
|---------|------------|-----------|
| Complexity | Simple, lightweight | Complex, full-featured |
| Target scale | Medium (hundreds) | Large (thousands+) |
| Architecture | Monolithic | Modular (many projects) |
| Networking | Basic bridge | Neutron (SDN) |
| Use case | Simple private clouds | Large-scale, carrier-grade |

---

## Hadoop 2.0 Improvements [!P]

> Hadoop 2 moves from restricted batch-oriented model to **multi-purpose platform** (batch, interactive, online, streaming). 2× throughput with same hardware.

**Major changes**: HDFS High Availability, HDFS Federation, **YARN**, Container concept, highly available NameNode.

### HDFS High Availability
> **Problem**: Single NameNode was single point of failure. **Solution**: Run **two redundant NameNodes** in **Active/Passive** configuration.

### HDFS Federation
> **Problem**: Two NameNodes don't provide horizontal scalability. **Solution**: **Federate multiple independent NameNodes** – no coordination required. DataNodes serve as common storage for all NameNodes; each DataNode registers with all NameNodes.

### YARN (Yet Another Resource Negotiator)
> **Fundamental idea**: **Decouple cluster resource management from data processing frameworks**. Many application types (not just MapReduce) can run on YARN.

#### YARN Components [!P]

| Component | Function |
|-----------|----------|
| **ResourceManager (RM)** | Central authority; accepts submissions; allocates resources; schedules work |
| **Scheduler** (within RM) | Allocates resources to running applications; does NOT monitor or restart them |
| **ApplicationsManager Service (AMService)** | Manages submissions; starts ApplicationMasters; handles lifecycle |
| **NodeManager (NM)** | Per-node daemon; monitors local resources; manages container lifecycle; sends heartbeats to RM |
| **ApplicationMaster (AM)** | Per-application coordinator; runs in container; negotiates resources; coordinates tasks (does NOT execute) |
| **Container** | Resource allocation (CPU, memory) on a NodeManager; where tasks run |

**Example ApplicationMasters**: **MR AM** (MapReduce), **MPI AM** (MPI applications on YARN).

---

## Apache Spark

> **Apache Spark** = general-purpose data processing engine. Originated at UC Berkeley AMPLab (2009) to be **faster and more flexible than Hadoop MapReduce**.

**Key features**: Designed for faster batch processing, interactive query processing, streaming data, iterative algorithms (machine learning). **In-memory computation engine**. Almost **100× faster** than Hadoop MapReduce with in-memory computations; almost **10× faster** using disk I/O.

### Spark Core Concepts [!P]

| Concept | Description |
|---------|-------------|
| **Driver** | User code (Scala, Python, Java, R); calls Spark APIs; produces DataFrame plans and RDD lineages |
| **RDD** (Resilient Distributed Dataset) | Immutable, fault-tolerant, distributed collections; can be operated on in parallel; fault tolerance via lineage (recomputation) |
| **DataFrame API** | Parses operations; builds/optimises logical plan; creates physical plan; passes to Spark Core |
| **DAG** (Directed Acyclic Graph) | Graphs of stages and tasks with one-way dependencies; Spark Core turns plans into DAGs |
| **Executors** | Run tasks in parallel; keep data in memory (enables fast distributed processing); requested from Resource Manager |

### Spark Data Flow
```
Driver → DataFrame plans + RDD lineages → DataFrame API (logical plan → physical plan) → Spark Core (DAG) → Executors (run tasks, cache data)
```

---

## Power-Aware Computing

### Energy and Power Definitions [!P]

| Term | Definition | Formula |
|------|------------|---------|
| **Energy** | Physical currency to accomplish task. Units: Joule (J), Watt-hour (Wh), Kilowatt-hour (kWh) | Energy = AvgPower × Time |
| **Power** | Instantaneous rate of energy use. Units: Watt (W) | Power = Energy / Time |
| **Energy Efficiency (EE)** | Ratio of work done per unit of energy consumed | EE = Work Done / (Power × Time) = Performance / Power |

> **Joule**: Work required to produce one Watt of power for one second.

### Power Measurement Tools [!P]

| Tool | Description |
|------|-------------|
| **IPMI** (Intelligent Platform Management Interface) | Direct measurement via server-integrated sensors |
| **RAPL** (Running Average Power Limit) | Intel/AMD power capping interface |
| **Powerstat** | Linux tool for power measurement |
| **Powertop** | Linux tool identifying power-hungry components |
| **Kepler** (Kubernetes Efficient Power Level Exporter) | Container power metrics |

### Key Observations (40 Years of Microprocessor Trend Data)
- Historically: performance increased exponentially, power followed.
- Recently: **energy-optimised programmable hardware is ultimately controlled by software**.
- Hardware optimised for power/performance/cost; software determines actual energy use.

### Hardware Optimisation Approaches [!P]

| Approach | Description | Trade-off |
|----------|-------------|-----------|
| **Hardware specialisation** | ASICs, FPGAs, accelerators | Less flexibility, better efficiency |
| **Hardware optimisation** | Instruction-level parallelism, hardware threading | Diminishing returns |
| **Hardware-software co-design** | Large one-off engineering cost | Expensive but optimal |
| **Software closer to hardware** | Fewer abstractions | Harder to program; tools are performance-oriented |
| **Optimal software operation** | Off-line and on-line optimisation | Overhead may pay off |

### Energy Formulation [!P]
> **Energy = Power / Performance** OR **Energy = Power × Time**

**Trade-offs**:

| Action | Effect on Performance | Effect on Power | Effect on Energy |
|--------|----------------------|-----------------|------------------|
| Increase frequency/voltage | Increases | Increases more (quadratic) | Often increases |
| Decrease frequency/voltage | Decreases | Decreases more | Often decreases |
| Add more cores | Increases | Increases | Depends on parallelism |

### DVFS (Dynamic Voltage and Frequency Scaling) [!P]

> **Formula**: Dynamic Energy = α × Vdd² × Ncycle (quadratic with voltage)

**Exam calculation (2024 Q1g, 2025 Q1l)**: Server at Vmax finishes task in T/2 seconds. Voltage to finish in T seconds? **Answer: Vmax / 2** (time inversely proportional to voltage).

**Example effect**: Reduce voltage and frequency by 10% → program slows ~8% → dynamic power reduces ~27% (quadratic), total energy reduces ~17%.

**Exam trap**: Voltage drop → frequency must drop (cannot lower voltage alone on most processors).

### Server Consolidation [!P]

> **Problem**: Most servers utilisation <5%. Idle servers can consume up to **70% of maximum energy output**.

| Issue | Description |
|-------|-------------|
| Low utilisation | 5% typical – massive waste |
| Idle power | Up to 70% of peak |
| Can't turn servers off | Breaks hot/cold aisle; may not restart |
| Admin uncertainty | Unsure how to use effectively |

> **Server consolidation** = reducing number of physical servers by running multiple VMs on fewer hosts → saves energy.

### Energy-aware load balancing
> **Concentrate** workloads on subset of servers, keep rest in low-power mode (opposite of traditional balancing).

### Jevons Paradox (Exam-Ready)
> Efficiency → **increased** consumption (not decreased). More efficient servers → lower cost per computation → more computations performed → total energy may increase.

### PUE (Power Utilisation Effectiveness) [!P]

> **PUE** = Total facility power / IT equipment power. Ideal = 1.0, median ~1.55, target ~1.1.

**Limitations**: PUE does not measure useful work; can be deflated.

### Power Models
- **Linear**: PMx_predPwr = α × util + β
- **Polynomial (more accurate)** : cubic regression

### Metrics for Measuring Energy Consumption [!P]

#### By Metric Type

| Metrics Type | Units | Example |
|--------------|-------|---------|
| Energy | J, W, A, kWh | Total consumption |
| Performance | GFLOPS/kWh, %, s | Work per energy |
| Throughput | Requests/sec per Watt | Service efficiency |
| Utilisation | %, MB, MHz, GB/s | CPU/memory/disk usage |
| Economics | £, $ | Lifecycle cost |
| Performance/Energy | GFLOPS/Watt | Power efficiency |
| Pollution | CO₂ units | Carbon emissions |

#### By Context

| Context | Example Metric |
|---------|----------------|
| Application | Computational energy cost (CPU, memory, I/O) |
| Architecture | Distributed system energy consumption |
| Service | Execution plan energy efficiency |
| Virtual Machine | Disk energy model over time |
| Data Centre | Data centre energy productivity (bytes/kWh) |
| Embedded Software | Executed instructions count |
| Server | Server power utilisation vs CPU utilisation |
| DBMS | Power-aware query plan cost |

---

## IoT, Edge Computing, and 6G

### Building Blocks of the Internet of Things [!P]

| Category | Elements | Examples |
|----------|----------|----------|
| **Identification** | Naming, Addressing | EPC, uCode, IPv4, IPv6 |
| **Sensing** | Sensors, Actuators | Smart sensors, wearable sensing, RFID tags |
| **Communication** | Protocols | RFID, NFC, BLE, IEEE 802.15.4, Z-Wave, WiFi, LTE-A |
| **Computation** | Hardware, Software | Arduino, Raspberry Pi, Contiki, TinyOS, LiteOS, RIOT OS, Android |
| **Services** | Types | Identity-related, Information Aggregation, Collaborative-Aware, Ubiquitous |
| **Semantic** | Data models | RDF, OWL, EXI |

### The Challenges of IoT [!P]

| Challenge | Description |
|-----------|-------------|
| **Massive scale** | Billions of devices to manage |
| **Heterogeneity** | Different protocols, data formats, hardware capabilities |
| **Security** | Constrained devices difficult to secure; large attack surface |
| **RF interference** | Wireless spectrum congestion |
| **Control traffic** | Large volume of signalling and coordination messages |
| **Low latency requirements** | Some applications need near-real-time response |
| **Power constraints** | Many devices battery-powered; must operate for years |
| **Reliability** | Network or device failures must be handled gracefully |

> Control traffic and security mechanisms must be **lightweight** and optimised to minimise power consumption.

### Example Slices for IoT [!P]

| Slice Type | Characteristics | Use Cases |
|------------|----------------|-----------|
| **Massive IoT (mMTC)** | Many devices, low bandwidth, long battery life | Sensors, smart meters, asset tracking |
| **Ultra-Reliable Low Latency (URLLC)** | Very low latency, high reliability | Autonomous vehicles, remote surgery, industrial control |
| **Enhanced Mobile Broadband (eMBB)** | High bandwidth, moderate latency | Video streaming, VR/AR, fixed wireless |

### Edge Pipeline [!P]

Typical processing flow on edge: **Pod instantiation** → **Data ingestion** (MQTT/Kafka) → **Pre-processing** (Apache Edgent, NumPy) → **Local inference** (TinyML) → **Feedback loops**. Orchestrated by **lightweight Kubernetes** (**K3s/MicroK8s**) with **Grafana** for observability.

### Edge Intelligence (EI) Hardware [!P]

| Hardware | Type | Use Cases |
|----------|------|-----------|
| **NVIDIA Jetson** | Embedded GPU (CUDA) | Autonomous robotics, real-time video analytics |
| **Google Coral TPU** | ASIC for TensorFlow Lite | Industrial IoT sensors, local anomaly detection |
| **Intel Movidius NCS** | USB VPU accelerator | Rapid prototyping, upgrading legacy hardware |
| **Smartphones with Neural Engines** | Dedicated NPU | Computational photography, AR, real-time translation |

### LLM Deployment Strategies [!P]

| Strategy | Description | Trade-off |
|----------|-------------|-----------|
| **Cloud Deployment** | LLMs hosted centrally (e.g., GPT-4) | Abundant resources but high latency, high bandwidth cost |
| **Network Edge Deployment** | LLMs at network edge (e.g., Llama2 13B) | Lower latency but constrained resources |
| **On-Device Deployment** | LLMs on user devices (e.g., Mistral 7B) | Fastest response, personalisation, limited by hardware |
| **Cache-Based Deployment** | Model split/cached across cloud, edge, devices | Flexible but complex synchronisation |
| **Cooperative Deployment** | Cloud trains large models; edge runs small tailored models | Best of both but requires coordination |

### Wasm & Trusted Execution Environments (TEEs) [!P]

**WebAssembly (Wasm)**: Portable, lightweight, safe execution format providing **software-level sandboxing**. **Intel SGX**: Provides **hardware-isolated enclaves** protecting code/data from host OS. **TWINE Runtime** combines both: executes Wasm inside SGX creating a **two-way sandbox**. Uses **WASI** for controlled OS access and **attestation** to verify integrity.

### Service Delivery Models (SDMs) [!P]

| Model | Description |
|-------|-------------|
| **MNO** (Mobile Network Operator) | Owns its network infrastructure |
| **MVNO** (Virtual Mobile Network Operator) | Leases network from MNO |
| **DeWi** (Decentralised Wireless) | Community-owned wireless networks |
| **DePIN** (Decentralised Physical Infrastructure Nets) | Blockchain-incentivised decentralised infrastructure sharing |

### Digital Twin (DT) [!P]

> **Digital Twin** = near-real-time virtual representation of a physical asset, enabling indirect observability and programmability via service-level APIs. Can run as a smart contract. Receives data from physical asset, sends control commands back.

---

## 6G Starting Points

### 5G Network Slicing (Recap) [!P]

> **Network Slicing** uses NFV and SDN to create multiple virtual networks (slices) on a single physical infrastructure, each customised for a specific use case with its own QoS guarantees.

**Exam trap (2024 Q1e)** : 5G uses **slice** to support NFV (D).

### From 5G to 6G — Key Differences [!P]

| Aspect | 5G | 6G |
|--------|----|----|
| **Peak data rate** | ~20 Gbps | ~1 Tbps |
| **Latency** | ~1 ms | ~0.1 ms (sub-millisecond) |
| **Intelligence** | Some AI-assisted | **Native AI/ML** embedded throughout |
| **Architecture** | Centralised core + edge add-ons | **Cloud/Fog/Edge continuum** as default |
| **Trust model** | Centralised operators | **Decentralised** via DLT/blockchain |
| **New enablers** | NFV, SDN, MEC | THz comms, digital twins, quantum, neuromorphic computing |

### Disruptive 6G (D6G) Enabler Families (8 Building Blocks) [!P]

| Family | What It Covers |
|--------|----------------|
| **1. Energy** | Energy harvesting, green technology |
| **2. Sensing & Actuating** | Ubiquitous sensing, programmability of things |
| **3. Communication** | THz, Ultra MIMO, IRS/RIS, VLC, D2D, UAVs, cell-free nets, DTN |
| **4. Softwarization** | Functional fragmentation, programmability, virtualisation, digital twins, slicing |
| **5. Immutability** | Immutable registers, tokenization, smart contracts, decentralised deterministic computing |
| **6. Intelligence** | AI, ML, SON, neuromorphic computing, decision support |
| **7. Security** | Identity, secrecy, authentication, authorisation, trust |
| **8. Quantum** | Quantum computing, quantum communications, quantum security, quantum ML |

### D6G Vision — Core Pillars [!P]

- **Native Cloud/Edge Intelligence**: AI/ML as first-class component.
- **Smart Contracts**: Automate agreements, resource allocation, digital monetisation (e.g., paying for network slice usage via blockchain).
- **Decentralized AI**: Distributing intelligence across the network for autonomy.
- **Digital Twins**: Virtual representations enabling mirrored reality.
- **Focus areas**: Flexibility, open digital markets, automated resource sharing, enhanced security/trust via Distributed Ledger Technology (DLT).

### On-Chain/Off-Chain Interoperability [!P]

**Oracles** (e.g., **Chainlink**) act as bridges between blockchain (on-chain) smart contracts and external data sources (off-chain). In D6G, operator expresses **intents** on-chain; oracle translates into **slicing parameters** via intent decoder (SLOrion), configuring **Network Slice as a Service (NSaaS)**.

---

## Industry 5.0 Integration Challenges [!P]

Key challenges of integrating **6G with edge computing** in Industry 5.0 (exam topic from 2025 paper):

| Challenge | Explanation |
|-----------|-------------|
| **Ultra-low latency requirements** | Manufacturing needs sub-millisecond responses for real-time control |
| **Heterogeneous infrastructure** | Mixing legacy equipment with new 6G devices creates interoperability issues |
| **Energy efficiency** | Dense 6G deployments consume significant power; need green computing |
| **Security & privacy** | Industrial data requires TEEs, encryption, secure edge processing |
| **Scalability** | Thousands of IoT sensors per factory floor; manage with lightweight orchestration (K3s) |
| **Human-centric design** | Industry 5.0 emphasises human-machine collaboration; need digital twins and AR/VR |
| **Reliability** | Mission-critical processes cannot tolerate failures; need redundancy and DTN |

---

## Exam Essential Extracts (Quick Reference)

### NIST Cloud Characteristics (Exam Trap Classic)

| Characteristic | Exam Keyword |
|----------------|--------------|
| **On-demand self-service** | “unilaterally provision… without human interaction” |
| **Broad network access** | “heterogeneous thin/thick clients” |
| **Resource pooling** | “location independence, pooled resources” |
| **Rapid elasticity** | “unlimited… any quantity at any time” |
| **Measured service** | “automatic control and optimisation by metering” |

### Cloud Service Models

| Model | What you manage | Example |
|-------|----------------|---------|
| **IaaS** | Apps, data, runtime, middleware, OS, virtualization, storage, network, servers | EC2 |
| **PaaS** | Apps, data | Heroku |
| **SaaS** | Just use the app | Gmail |
| **FaaS** | Code (functions) | AWS Lambda |

**Exam trap**: FaaS is **not** PaaS – FaaS abstracts the runtime entirely.

### Cloud Types

| Type | Key characteristic | Exam scenario |
|------|--------------------|---------------|
| **Public** | Multi-tenant, internet-accessible | “Resources shared across multiple organisations” |
| **Private** | Single organisation, own datacenter | “Government, finance, data sovereignty” |
| **Hybrid** | Public + private | “Peak usage exceeds internal capacity” → combine local + cloud (2025 Q1a answer D) |

### Virtualisation Exam Traps

- **2025 Q1b**: Paravirtualisation benefit = **improves performance by reducing overhead** (C).
- **2025 Q1c**: Hardware-assisted virtualisation = **CPU provides support** (B) + **hypervisor emulates hardware** (A) – select two.
- **2025 Q1d**: VM communication = **private IP + virtual private bridge** (C).

### MapReduce Exam Traps

- **Output files = r** (reducers), not m (2025 Q1i).
- **Shuffle copy operations = m × r**.
- **Reducer cannot start until all mappers complete** (2024 Q1j(ii) false).

### Serverless Exam Traps

- **2025 Q1g**: AWS Lambda = **invoked only when an event occurs** (not continuous running).
- **2025 Q1h**: Cold start overhead negatively impacts user experience – **True**.

### SDN/NFV Exam Traps

- **SDN** = control plane centralised, data plane distributed.
- **OpenFlow** = protocol, not the controller.
- **5G uses slice** to support NFV (2024 Q1e answer D).
- **InfiniBand speeds**: SDR→DDR→QDR→FDR→EDR→HDR (200G)→NDR (400G)→XDR (800G).

### Energy Efficiency Exam Traps

- **PUE ideal = 1.0** (all power to IT); median ~1.55; target ~1.1.
- **PUE doesn't measure useful work**.
- **Energy = Power × Time** (not Power/Time).
- **Idle servers consume up to 70% of max energy**.
- **Server utilisation typical: 5–20%**.
- **DVFS voltage for double time = Vmax/2**.

### Big Data Exam Traps

- **2024 Q1i**: Unstructured data = **emails, social media posts, images** (C).
- **2025 Q1j**: Hadoop vs Spark key difference = **All of the above** (D).
- **HDFS block size = 128 MB**, replication factor = 3.
- **NameNode** = single point of failure in Hadoop 1; fixed in Hadoop 2 with HA + Federation.

### Edge & IoT Exam Traps

- **LoRa**: unlicensed ISM bands, long range (2–10 km), low bandwidth, very low power.
- **RFID vs NFC**: RFID longer range (metres); NFC very short range (~4 cm).
- **Kevin Ashton** coined “Internet of Things”.
- **Edge vs Fog**: Edge = on-device; Fog = intermediate LAN layer.

### Hardware Accelerators Exam Traps

- **2024 Q1f**: FPGA for custom data acquisition/pre-processing.
- **2025 Q1e**: TPU advantage = **specifically designed for high-performance ML computations**.

### Programming Models Exam Traps

- **MPI** = distributed memory (each process own memory) → explicit message passing.
- **OpenMP** = shared memory (threads) → directives.
- **Go** language used by Docker and Kubernetes.

### IaC (Terraform) Exam Traps

- **IaC provisions infrastructure** (VMs, clusters); **Kubernetes orchestrates containers** inside that infrastructure.
- **Terraform** = declarative, cloud-agnostic; **CloudFormation** = AWS-specific.
- **Ansible** = agentless (SSH); **Puppet/Chef** = master-agent.

### Kubernetes Exam Traps

- **2025 Q1f**: HPA = pod scaling (not node scaling).
- **Pod** = smallest Kubernetes unit (one or more containers).
- **etcd** stores cluster state (not application data).
- **Rolling update** = zero downtime; gradual replacement.

### Live Migration Exam Traps

- **Precopy** = copy memory first (reliable, preferred).
- **Postcopy** = transfer CPU first, fetch memory on-demand (faster but less stable).
- **LAN migration**: same private IP, unsolicited ARP reply for MAC update.
- **WAN migration**: IPs change; use DNS names.

### OpenStack Core Projects (Memorise)

| Project | Function |
|---------|----------|
| **Nova** | Compute |
| **Neutron** | Network (SDN) |
| **Cinder** | Block storage |
| **Swift** | Object storage |
| **Glance** | Image service |
| **Keystone** | Identity |
| **Horizon** | Dashboard |

### Miscellaneous Exam Facts

- **Moore's Law**: transistors double every 2 years.
- **Law of Accelerating Returns** (Kurzweil): exponential progress feeds itself.
- **Utility computing vision** (Leonard Kleinrock, 1969): “computer utilities like electricity”.
- **El Capitan** (2024 fastest supercomputer): 1.742 exaflops/s.
- **Colossus 2** AI datacentre: peak 1.2 GW, 7 gas turbines, 168 Tesla Megapacks.
- **1 rack power**: 42 servers × 500W = 21 kW (≈3× average UK house).
- **Data centre construction**: 24+ months.
- **Google File System (GFS) replication**: at least 3 replicas on local disks.
- **AMI types** (AWS): Private (you), Public (community), Paid (commercial).
- **S3**: object storage (1B–5GB per object), not block storage (EBS).

---

## Quick Reference – Formulas & Numbers

| Item | Value / Formula |
|------|-----------------|
| Dynamic Energy | α × Vdd² × Ncycle |
| DVFS voltage for double time | Vmax / 2 |
| MapReduce output files | r (reducers) |
| MapReduce shuffle copy ops | m × r |
| HDFS block size | 128 MB |
| HDFS replication | 3 |
| PUE ideal | 1.0 |
| PUE median (2022) | 1.55 |
| Server idle power | up to 70% of max |
| Server utilisation typical | 5–20% |
| InfiniBand NDR | 400 Gb/sec |
| InfiniBand XDR (projected) | 800 Gb/sec |
| LoRa range | 2–10 km |
| LoRa battery life | 1000+ days |
| Raspberry Pi cores | 4 (ARM Cortex) |
| AWS Lambda max execution time | 15 minutes |

---

## Docker Commands Reference

### Management Commands

| Command | Description |
|---------|-------------|
| `docker dockerd` | Launch the Docker daemon |
| `docker info` | Display system-wide information |
| `docker inspect` | Return low-level information on a container or image |
| `docker version` | Show the Docker version information |

### Image Commands

| Command | Description |
|---------|-------------|
| `docker build` | Build an image from a Dockerfile |
| `docker commit` | Create a new image from a container’s changes |
| `docker history` | Show the history of an image |
| `docker images` | List images |
| `docker import` | Import from a tarball to create a filesystem image |
| `docker load` | Load an image from a tar archive or STDIN |
| `docker rmi` | Remove one or more images |
| `docker save` | Save images to a tar archive |
| `docker tag` | Tag an image into a repository |

### Container Commands

| Command | Description |
|---------|-------------|
| `docker attach` | Attach to a running container |
| `docker cp` | Copy files/folders between container and host |
| `docker create` | Create a new container |
| `docker diff` | Inspect changes on a container’s filesystem |
| `docker events` | Get real time events from the server |
| `docker exec` | Run a command in a running container |
| `docker export` | Export a container’s filesystem as a tar archive |
| `docker kill` | Kill a running container |
| `docker logs` | Fetch the logs of a container |
| `docker pause` | Pause all processes within a container |
| `docker port` | List port mappings for the container |
| `docker ps` | List containers |
| `docker rename` | Rename a container |
| `docker restart` | Restart a running container |
| `docker rm` | Remove one or more containers |
| `docker run` | Run a command in a new container |
| `docker start` | Start one or more stopped containers |
| `docker stats` | Display live stream of container(s) resource usage |
| `docker stop` | Stop a running container |
| `docker top` | Display running processes of a container |
| `docker unpause` | Unpause all processes within a container |
| `docker update` | Update configuration of one or more containers |
| `docker wait` | Block until a container stops, then print its exit code |

### Hub and Registry Commands

| Command | Description |
|---------|-------------|
| `docker login` | Register or log in to a Docker registry |
| `docker logout` | Log out from a Docker registry |
| `docker pull` | Pull an image or repository from a registry |
| `docker push` | Push an image or repository to a registry |
| `docker search` | Search Docker Hub for images |

### Network Commands

| Command | Description |
|---------|-------------|
| `docker network connect` | Connect a container to a network |
| `docker network create` | Create a new network |
| `docker network disconnect` | Disconnect a container from a network |
| `docker network inspect` | Display information about a network |
| `docker network ls` | List all networks the Engine daemon knows about |
| `docker network rm` | Remove one or more networks |

### Volume Commands

| Command | Description |
|---------|-------------|
| `docker volume create` | Create a new volume |
| `docker volume inspect` | Display information about a volume |
| `docker volume ls` | List all volumes |
| `docker volume rm` | Remove one or more volumes |

### Swarm Commands

| Command | Description |
|---------|-------------|
| `docker swarm init` | Initialize a swarm |
| `docker swarm join` | Join a swarm as a manager or worker |
| `docker swarm leave` | Remove the current node from the swarm |
| `docker swarm update` | Update attributes of a swarm |
| `docker swarm join-token` | Display or rotate join tokens |
| `docker node promote` | Promote a node to manager |
| `docker node demote` | Demote a manager to worker |
| `docker node inspect` | Inspect a node in the swarm |
| `docker node update` | Update node attributes |
| `docker node ps` | List tasks running on a node |
| `docker node ls` | List nodes in the swarm |
| `docker node rm` | Remove one or more nodes |
| `docker service create` | Create a new service |
| `docker service inspect` | Inspect a service |
| `docker service ls` | List services |
| `docker service rm` | Remove a service |
| `docker service scale` | Set the number of replicas for a service |
| `docker service ps` | List tasks of a service |
| `docker service update` | Update service attributes |

---

*End of Exam Revision Master Document*