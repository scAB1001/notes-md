## Comparison Tables
### MPI vs OpenMP vs MapReduce vs TensorFlow

| Aspect          | MPI                   | OpenMP                  | MapReduce                       | TensorFlow               |
| --------------- | --------------------- | ----------------------- | ------------------------------- | ------------------------ |
| **Paradigm**    | Message passing       | Shared memory           | Data-parallel                   | Data-flow graph          |
| **Memory**      | Distributed           | Shared                  | Distributed (HDFS)              | Distributed (optional)   |
| **Granularity** | Process               | Thread                  | Task (Map/Reduce)               | Operation                |
| **Best for**    | HPC simulations       | Single-node parallelism | Batch data processing           | Machine Learning         |
| **Cloud use**   | HPC on cloud clusters | Limited to single VM    | Big data analytics              | AI/ML training/inference |
| **Languages**   | C, Fortran, Python    | C, C++, Fortran         | Java, Python (Hadoop Streaming) | Python, C++              |
### Hadoop 1.0 vs Hadoop 2.0 (YARN) vs Spark

| Feature | Hadoop 1.0 | Hadoop 2.0 (YARN) | Spark |
|---------|------------|-------------------|-------|
| **Resource management** | JobTracker (monolithic) | ResourceManager + NodeManager | Own manager or YARN/Mesos/K8s |
| **Processing model** | MapReduce only | Multiple frameworks | Batch, interactive, streaming, iterative |
| **Storage** | HDFS (disk-based) | HDFS (disk-based) | In-memory + disk |
| **Speed** | Baseline | ~2× throughput | 10–100× faster (in-memory) |
| **Fault tolerance** | Task re-execution | Task re-execution | RDD lineage (recompute) |
| **Programming model** | Rigid (map/reduce) | Flexible | Unified APIs (SQL, ML, streaming) |
| **Iterative processing** | Poor (many disk writes) | Poor | Excellent (in-memory caching) |
### HPA vs Cluster Autoscaler

| Feature | HPA | Cluster Autoscaler |
|---------|-----|-------------------|
| **Scales** | Pods (replicas) | Nodes (cluster size) |
| **Trigger** | CPU utilisation, custom metrics | Pods pending due to insufficient resources |
| **Scale-to-zero** | No (min replicas >0) | Yes (idle nodes removed) |
### Serverless vs Containers vs VMs

| Aspect | Serverless | Containers | VMs |
|--------|------------|------------|-----|
| **Unit of deployment** | Function (code) | Container image | VM image |
| **Scale-to-zero** | **Yes** | No (min replicas usually 1) | No |
| **Cold start** | **Yes** – latency penalty | No | No (but boot time minutes) |
| **Billing** | Per invocation + compute time | Pay for running instances | Pay for running VMs |
| **State** | Stateless | Stateful possible | Stateful possible |
### Virtualisation Techniques

| Feature | Full | Para | Hardware-assisted |
|---------|------|------|-------------------|
| Guest OS modification | No | Yes | No |
| Binary translation | Yes | No | No |
| Hypercalls | No | Yes | No |
| CPU support required | No | No | Yes (VT-x/AMD-V) |
| Performance | Lowest | Medium | Highest |
| Compatibility | High | Low | High |
### VMs vs Containers

| Feature   | Virtual Machines | Containers            |
| --------- | ---------------- | --------------------- |
| Isolation | Full OS-level    | Process-level         |
| Guest OS  | Each VM has own  | Shared host kernel    |
| Boot time | Minutes          | Seconds/milliseconds  |
| Size      | GBs              | MBs                   |
| Overhead  | High             | Near-zero             |
| Use cases | Legacy, multi-OS | Microservices, DevOps |
### Deployment Options (Dedicated HW → VM → Container → Unikernel)

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
### Wireless IoT Protocols Comparison

| Feature | LoRaWAN | NB-IoT | Wi-Fi 6 | BLE | Zigbee |
|---------|---------|--------|---------|-----|--------|
| Range | 2–10 km | 1–10 km | 1–100 m | 1–100 m | 1–100 m |
| Battery life | 1000+ days | 1000+ days | 100–1000 days | 100–1000 days | 100–1000 days |
| Bandwidth | 0.3–50 Kbps | 20–250 Kbps | 600+ Mbps | 125–2000 Kbps | 20–250 Kbps |
### Hardware Accelerators Comparison

| Feature | CPU | GPU | FPGA | ASIC | TPU |
|---------|-----|-----|------|------|-----|
| Programmability | Easy | Moderate | Hard | None (fixed) | Via frameworks |
| Flexibility | High | Medium | Medium | Low (rigid) | Low (ML-specific) |
| Power efficiency | Low | Medium | High | Highest | Very high |
| Best for | Sequential logic | Parallel, matrix ops | Custom pipelines | Mass production | ML inference/training |
### OpenStack vs OpenNebula

| Feature | OpenNebula | OpenStack |
|---------|------------|-----------|
| Complexity | Simple, lightweight | Complex, full-featured |
| Target scale | Medium (hundreds) | Large (thousands+) |
| Architecture | Monolithic | Modular (many projects) |
| Networking | Basic bridge | Neutron (SDN) |
| Use case | Simple private clouds | Large-scale, carrier-grade |
## Hadoop 2.0 Improvements
> Hadoop 2 moves from restricted batch-oriented model to **multi-purpose platform** (batch, interactive, online, streaming). 2× throughput with same hardware.

**Major changes**: HDFS High Availability, HDFS Federation, **YARN**, Container concept, highly available NameNode.
### HDFS High Availability
> **Problem**: Single NameNode was single point of failure. **Solution**: Run **two redundant NameNodes** in **Active/Passive** configuration.
### HDFS Federation
> **Problem**: Two NameNodes don't provide horizontal scalability. **Solution**: **Federate multiple independent NameNodes** – no coordination required. DataNodes serve as common storage for all NameNodes; each DataNode registers with all NameNodes.
### YARN (Yet Another Resource Negotiator)
> **Fundamental idea**: **Decouple cluster resource management from data processing frameworks**. Many application types (not just MapReduce) can run on YARN.
#### YARN Components

| Component | Function |
|-----------|----------|
| **ResourceManager (RM)** | Central authority; accepts submissions; allocates resources; schedules work |
| **Scheduler** (within RM) | Allocates resources to running applications; does NOT monitor or restart them |
| **ApplicationsManager Service (AMService)** | Manages submissions; starts ApplicationMasters; handles lifecycle |
| **NodeManager (NM)** | Per-node daemon; monitors local resources; manages container lifecycle; sends heartbeats to RM |
| **ApplicationMaster (AM)** | Per-application coordinator; runs in container; negotiates resources; coordinates tasks (does NOT execute) |
| **Container** | Resource allocation (CPU, memory) on a NodeManager; where tasks run |

**Example ApplicationMasters**: **MR AM** (MapReduce), **MPI AM** (MPI applications on YARN).
## Apache Spark
> **Apache Spark** = general-purpose data processing engine. Originated at UC Berkeley AMPLab (2009) to be **faster and more flexible than Hadoop MapReduce**.

**Key features**: Designed for faster batch processing, interactive query processing, streaming data, iterative algorithms (machine learning). **In-memory computation engine**. Almost **100× faster** than Hadoop MapReduce with in-memory computations; almost **10× faster** using disk I/O.
### Spark Core Concepts

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
## Power-Aware Computing
### Energy and Power Definitions

| Term | Definition | Formula |
|------|------------|---------|
| **Energy** | Physical currency to accomplish task. Units: Joule (J), Watt-hour (Wh), Kilowatt-hour (kWh) | Energy = AvgPower × Time |
| **Power** | Instantaneous rate of energy use. Units: Watt (W) | Power = Energy / Time |
| **Energy Efficiency (EE)** | Ratio of work done per unit of energy consumed | EE = Work Done / (Power × Time) = Performance / Power |
> **Joule**: Work required to produce one Watt of power for one second.
### Power Measurement Tools

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
### Hardware Optimisation Approaches

| Approach | Description | Trade-off |
|----------|-------------|-----------|
| **Hardware specialisation** | ASICs, FPGAs, accelerators | Less flexibility, better efficiency |
| **Hardware optimisation** | Instruction-level parallelism, hardware threading | Diminishing returns |
| **Hardware-software co-design** | Large one-off engineering cost | Expensive but optimal |
| **Software closer to hardware** | Fewer abstractions | Harder to program; tools are performance-oriented |
| **Optimal software operation** | Off-line and on-line optimisation | Overhead may pay off |
### Energy Formulation
> **Energy = Power / Performance** OR **Energy = Power × Time**

**Trade-offs**:

| Action | Effect on Performance | Effect on Power | Effect on Energy |
|--------|----------------------|-----------------|------------------|
| Increase frequency/voltage | Increases | Increases more (quadratic) | Often increases |
| Decrease frequency/voltage | Decreases | Decreases more | Often decreases |
| Add more cores | Increases | Increases | Depends on parallelism |
### DVFS (Dynamic Voltage and Frequency Scaling)
> **Formula**: Dynamic Energy = α × Vdd² × Ncycle (quadratic with voltage)

**Exam calculation (2024 Q1g, 2025 Q1l)**: Server at Vmax finishes task in T/2 seconds. Voltage to finish in T seconds? **Answer: Vmax / 2** (time inversely proportional to voltage).

**Example effect**: Reduce voltage and frequency by 10% → program slows ~8% → dynamic power reduces ~27% (quadratic), total energy reduces ~17%.

**Exam trap**: Voltage drop → frequency must drop (cannot lower voltage alone on most processors).
### Server Consolidation
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
### PUE (Power Utilisation Effectiveness)
> **PUE** = Total facility power / IT equipment power. Ideal = 1.0, median ~1.55, target ~1.1.

**Limitations**: PUE does not measure useful work; can be deflated.
### Power Models
- **Linear**: PMx_predPwr = α × util + β
- **Polynomial (more accurate)** : cubic regression
### Metrics for Measuring Energy Consumption
#### By Metric Type | By Context

| Metrics Type       | Units                 | Example               |     | Context           | Example Metric                               |
| ------------------ | --------------------- | --------------------- | --- | ----------------- | -------------------------------------------- |
| Energy             | J, W, A, kWh          | Total consumption     |     | Application       | Computational energy cost (CPU, memory, I/O) |
| Performance        | GFLOPS/kWh, %, s      | Work per energy       |     | Architecture      | Distributed system energy consumption        |
| Throughput         | Requests/sec per Watt | Service efficiency    |     | Service           | Execution plan energy efficiency             |
| Utilisation        | %, MB, MHz, GB/s      | CPU/memory/disk usage |     | Virtual Machine   | Disk energy model over time                  |
| Economics          | £, $                  | Lifecycle cost        |     | Data Centre       | Data centre energy productivity (bytes/kWh)  |
| Performance/Energy | GFLOPS/Watt           | Power efficiency      |     | Embedded Software | Executed instructions count                  |
| Pollution          | CO₂ units             | Carbon emissions      |     | Server            | Server power utilisation vs CPU utilisation  |
|                    |                       |                       |     | DBMS              | Power-aware query plan cost                  |
## IoT, Edge Computing, and 6G
### Building Blocks of the Internet of Things

| Category | Elements | Examples |
|----------|----------|----------|
| **Identification** | Naming, Addressing | EPC, uCode, IPv4, IPv6 |
| **Sensing** | Sensors, Actuators | Smart sensors, wearable sensing, RFID tags |
| **Communication** | Protocols | RFID, NFC, BLE, IEEE 802.15.4, Z-Wave, WiFi, LTE-A |
| **Computation** | Hardware, Software | Arduino, Raspberry Pi, Contiki, TinyOS, LiteOS, RIOT OS, Android |
| **Services** | Types | Identity-related, Information Aggregation, Collaborative-Aware, Ubiquitous |
| **Semantic** | Data models | RDF, OWL, EXI |
### The Challenges of IoT

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
### Example Slices for IoT

| Slice Type | Characteristics | Use Cases |
|------------|----------------|-----------|
| **Massive IoT (mMTC)** | Many devices, low bandwidth, long battery life | Sensors, smart meters, asset tracking |
| **Ultra-Reliable Low Latency (URLLC)** | Very low latency, high reliability | Autonomous vehicles, remote surgery, industrial control |
| **Enhanced Mobile Broadband (eMBB)** | High bandwidth, moderate latency | Video streaming, VR/AR, fixed wireless |
### Edge Pipeline
Typical processing flow on edge: **Pod instantiation** → **Data ingestion** (MQTT/Kafka) → **Pre-processing** (Apache Edgent, NumPy) → **Local inference** (TinyML) → **Feedback loops**. Orchestrated by **lightweight Kubernetes** (**K3s/MicroK8s**) with **Grafana** for observability.
### Edge Intelligence (EI) Hardware

| Hardware | Type | Use Cases |
|----------|------|-----------|
| **NVIDIA Jetson** | Embedded GPU (CUDA) | Autonomous robotics, real-time video analytics |
| **Google Coral TPU** | ASIC for TensorFlow Lite | Industrial IoT sensors, local anomaly detection |
| **Intel Movidius NCS** | USB VPU accelerator | Rapid prototyping, upgrading legacy hardware |
| **Smartphones with Neural Engines** | Dedicated NPU | Computational photography, AR, real-time translation |
### LLM Deployment Strategies

| Strategy | Description | Trade-off |
|----------|-------------|-----------|
| **Cloud Deployment** | LLMs hosted centrally (e.g., GPT-4) | Abundant resources but high latency, high bandwidth cost |
| **Network Edge Deployment** | LLMs at network edge (e.g., Llama2 13B) | Lower latency but constrained resources |
| **On-Device Deployment** | LLMs on user devices (e.g., Mistral 7B) | Fastest response, personalisation, limited by hardware |
| **Cache-Based Deployment** | Model split/cached across cloud, edge, devices | Flexible but complex synchronisation |
| **Cooperative Deployment** | Cloud trains large models; edge runs small tailored models | Best of both but requires coordination |
### Wasm & Trusted Execution Environments (TEEs)
**WebAssembly (Wasm)**: Portable, lightweight, safe execution format providing **software-level sandboxing**. **Intel SGX**: Provides **hardware-isolated enclaves** protecting code/data from host OS. **TWINE Runtime** combines both: executes Wasm inside SGX creating a **two-way sandbox**. Uses **WASI** for controlled OS access and **attestation** to verify integrity.
### Service Delivery Models (SDMs)

| Model | Description |
|-------|-------------|
| **MNO** (Mobile Network Operator) | Owns its network infrastructure |
| **MVNO** (Virtual Mobile Network Operator) | Leases network from MNO |
| **DeWi** (Decentralised Wireless) | Community-owned wireless networks |
| **DePIN** (Decentralised Physical Infrastructure Nets) | Blockchain-incentivised decentralised infrastructure sharing |
### Digital Twin (DT)
> **Digital Twin** = near-real-time virtual representation of a physical asset, enabling indirect observability and programmability via service-level APIs. Can run as a smart contract. Receives data from physical asset, sends control commands back.
## 6G Starting Points
### 5G Network Slicing (Recap)
> **Network Slicing** uses NFV and SDN to create multiple virtual networks (slices) on a single physical infrastructure, each customised for a specific use case with its own QoS guarantees.

**Exam trap (2024 Q1e)** : 5G uses **slice** to support NFV (D).
### From 5G to 6G — Key Differences

| Aspect | 5G | 6G |
|--------|----|----|
| **Peak data rate** | ~20 Gbps | ~1 Tbps |
| **Latency** | ~1 ms | ~0.1 ms (sub-millisecond) |
| **Intelligence** | Some AI-assisted | **Native AI/ML** embedded throughout |
| **Architecture** | Centralised core + edge add-ons | **Cloud/Fog/Edge continuum** as default |
| **Trust model** | Centralised operators | **Decentralised** via DLT/blockchain |
| **New enablers** | NFV, SDN, MEC | THz comms, digital twins, quantum, neuromorphic computing |
### Disruptive 6G (D6G) Enabler Families (8 Building Blocks)

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
### D6G Vision — Core Pillars
- **Native Cloud/Edge Intelligence**: AI/ML as first-class component.
- **Smart Contracts**: Automate agreements, resource allocation, digital monetisation (e.g., paying for network slice usage via blockchain).
- **Decentralized AI**: Distributing intelligence across the network for autonomy.
- **Digital Twins**: Virtual representations enabling mirrored reality.
- **Focus areas**: Flexibility, open digital markets, automated resource sharing, enhanced security/trust via Distributed Ledger Technology (DLT).
### On-Chain/Off-Chain Interoperability
**Oracles** (e.g., **Chainlink**) act as bridges between blockchain (on-chain) smart contracts and external data sources (off-chain). In D6G, operator expresses **intents** on-chain; oracle translates into **slicing parameters** via intent decoder (SLOrion), configuring **Network Slice as a Service (NSaaS)**.
## Industry 5.0 Integration Challenges
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
## Generic Usage Patterns

| Operation                        | Command pattern                                                     |
| -------------------------------- | ------------------------------------------------------------------- |
| **Build image**                  | `docker build -t <name>:<tag> .` (from Dockerfile in current dir)   |
| **Run container**                | `docker run -d --name <cname> -p host:container <image>` (detached) |
| **Stop container**               | `docker stop <cname>`                                               |
| **Remove container**             | `docker rm <cname>`                                                 |
| **Remove image**                 | `docker rmi <image>`                                                |
| **Pull image**                   | `docker pull <image>`                                               |
| **Push image**                   | `docker push <repo>/<image>:<tag>`                                  |
| **Execute in running container** | `docker exec -it <cname> <command>`                                 |
| **View logs**                    | `docker logs -f <cname>`                                            |
# Docker Commands – Width-Efficient Multi-Column Reference

## Generic Usage Patterns (copy-paste ready)

| Operation                        | Pattern                                                  | Example                                     |
| -------------------------------- | :------------------------------------------------------- | ------------------------------------------- |
| **Build image**                  | `docker build -t <name>:<tag> .`                         | `docker build -t myapp:1.0 .`               |
| **Run container**                | `docker run -d --name <cname> -p HOST:CONTAINER <image>` | `docker run -d --name web -p 8080:80 nginx` |
| **Stop container**               | `docker exec -it <cname> <cmd>`                          | `docker exec -it web bash`                  |
| **Remove container**             | `docker logs -f <cname>`                                 | `docker logs -f web`                        |
| **Remove image**                 | `docker stop <cname> && docker rm <cname>`               | `docker stop web && docker rm web`          |
| **Pull image**                   | `docker pull <image>`                                    | `docker pull nginx:alpine`                  |
| **Push image**                   | `docker push <repo>/<image>:<tag>`                       | `docker push myrepo/myapp:1.0`              |
| **Execute in running container** | `docker rmi <image>`                                     | `docker rmi myapp:1.0`                      |
| **View logs**                    |                                                          |                                             |

| Command | Description | | Command | Description | | Command | Description |
|---------|-------------|-|---------|-------------|-|---------|-------------|
| **MANAGEMENT** | | | **IMAGE LIFECYCLE** | | | **CONTAINER LIFECYCLE** | |
| `dockerd` | launch daemon | | `build` | build from Dockerfile | | `attach` | attach to running container |
| `info` | system info | | `commit` | image from container changes | | `cp` | copy files host↔container |
| `inspect` | low-level details | | `history` | show image history | | `create` | create (not start) |
| `version` | show version | | `images` | list images | | `diff` | inspect filesystem changes |
| | | | `import` | from tarball to filesystem | | `events` | real-time daemon events |
| | | | `load` | load from tar (STDIN) | | `exec` | run command in running container |
| | | | `rmi` | remove image(s) | | `export` | export filesystem as tar |
| | | | `save` | save to tar | | `kill` | kill running container |
| | | | `tag` | tag image | | `logs` | fetch logs |
| | | | | | | `pause/unpause` | pause/unpause processes |
| | | | | | | `port` | list port mappings |
| | | | | | | `ps` | list containers |
| | | | | | | `rename` | rename container |
| | | | | | | `restart` | restart running container |
| | | | | | | `rm` | remove container(s) |
| | | | | | | `run` | create + start |
| | | | | | | `start` | start stopped container(s) |
| | | | | | | `stop` | stop running container(s) |
| | | | | | | `stats` | live resource usage |
| | | | | | | `top` | running processes inside |
| | | | | | | `update` | update resource limits |
| | | | | | | `wait` | block until stop, print exit code |

| Command | Description | | Command | Description | | Command | Description |
|---------|-------------|-|---------|-------------|-|---------|-------------|
| **HUB / REGISTRY** | | | **NETWORKING** | | | **VOLUMES (STORAGE)** | |
| `login` | log in to registry | | `network connect` | connect container to network | | `volume create` | create volume |
| `logout` | log out of registry | | `network create` | create new network | | `volume inspect` | show volume details |
| `pull` | pull image/repo | | `network disconnect` | disconnect container | | `volume ls` | list volumes |
| `push` | push image/repo | | `network inspect` | show network details | | `volume rm` | remove volume(s) |
| `search` | search Docker Hub | | `network ls` | list networks | | | |
| | | | `network rm` | remove network(s) | | | |

| Command | Description | | Command | Description |
|---------|-------------|-|---------|-------------|
| **SWARM ORCHESTRATION** | | | **SWARM SERVICES (continued)** | |
| `swarm init` | initialize swarm | | `service create` | create a service |
| `swarm join` | join as manager/worker | | `service inspect` | inspect service |
| `swarm leave` | leave swarm | | `service ls` | list services |
| `swarm update` | update swarm attributes | | `service rm` | remove service |
| `swarm join-token` | manage join tokens | | `service scale` | set number of replicas |
| `node promote` | promote to manager | | `service ps` | list tasks of service |
| `node demote` | demote to worker | | `service update` | update service attributes |
| `node inspect` | inspect node | | | |
| `node update` | update node | | | |
| `node ps` | list tasks on node | | | |
| `node ls` | list nodes | | | |
| `node rm` | remove node(s) | | | |
*Note: commands are shown without the `docker` prefix except where needed for clarity. Add `docker` before each command in actual use.*
# Past Exam Questions & Model Answers (2018–2026)
## 1. NIST Cloud Characteristics

**Question variations:**
- “In Cloud Computing, what does measured service refer to?”
- “A company wants complete control over its own resources, data, security and regulatory compliance, and is willing to purchase and maintain the underlying hardware itself. Which cloud deployment model best fits this requirement?”
- “A company’s IT usage peaks in summer, exceeding internal capacity. Best approach?”
- “Four cloud companies store user data with different replication strategies. Which provides highest availability?”

**Model answer with explanation:**
- **Measured service** = cloud systems automatically control and optimise resource use by leveraging a metering capability at some level of abstraction appropriate to the service type (e.g., pay‑per‑use billing, capacity planning). It is one of the five NIST essential characteristics.
- **Private cloud** = owned and operated by a single organisation, hosted in its own datacentre, offering maximum control over hardware, security and compliance; no external access.
- **Hybrid cloud / cloud bursting** = keep baseline workload on private infrastructure and burst the seasonal peak into a public cloud, avoiding over‑provisioning of idle hardware.
- **Highest availability** = geographic replication (e.g., primary in London, replica in Edinburgh) protects against site‑wide failures.
## 2. Virtualisation Types & Comparisons
**Question variations:**
- “Which statement best describes full virtualisation using binary translation?”
- “Key benefit of paravirtualisation?”
- “Two statements that define hardware‑assisted virtualisation.”
- “Common mechanism of communication among VMs?”
- “Which statement about containers, compared with VMs, is correct?”
- “In Docker, what is a Docker image?”

**Model answer with explanation:**
- **Full virtualisation with binary translation** = hypervisor traps and translates sensitive / non‑virtualisable instructions at runtime so that an unmodified guest OS can run. (No guest OS modification required.)
- **Paravirtualisation** = improves performance by reducing the overhead of full virtualisation; the guest OS is modified to issue explicit hypercalls instead of trapping sensitive instructions.
- **Hardware‑assisted virtualisation** = (1) CPU provides support (Intel VT‑x / AMD‑V) that reduces software emulation; (2) the hypervisor still presents and manages the virtual hardware environment.
- **VM communication** = each VM receives a private IP address attached to the host OS software Ethernet bridge (Linux bridge), allowing Layer‑2 communication without public IPs.
- **Container vs VM** = a container virtualises the operating system and shares the host kernel, is typically megabytes in size, and boots in milliseconds. A VM virtualises the underlying hardware, contains a full guest OS (gigabytes), and boots in minutes.
- **Docker image** = a read‑only template (binary artefact) that defines how to create a container; it includes the application code, runtime, dependencies, and configuration.
## 3. DVFS Calculation (Dynamic Voltage and Frequency Scaling)
**Question variations:**
- “A DVFS‑enabled server running at its maximum voltage Vmax finishes a particular task in T/2 seconds. What voltage should it run at to finish the task in T seconds?”
- “T/3 seconds → T seconds?”
- “If the amount of energy used at Vmax is E, what is it at the reduced voltage?”

**Model answer with explanation:**
- **Voltage for T seconds** = Vmax / 2 (or Vmax / 3 if the original time was T/3).
  **Explanation:** clock frequency scales approximately linearly with supply voltage; execution time is inversely proportional to frequency. To double the execution time, halve the frequency → halve the voltage.
- **Energy at reduced voltage** = E / 4 (or E / 9).
  **Explanation:** dynamic energy ∝ V² × number of cycles. For the same number of cycles (same task), energy is proportional to V². Reducing voltage to half gives ¼ the energy. (If original time was T/3, voltage to Vmax/3 gives 1/9 the energy.)
## 4. MapReduce & Hadoop
**Question variations:**
- “A MapReduce job has m mappers and r reducers. How many output files? How many copy operations in shuffle?”
- “When can the reduce method of a given reducer be called?”
- “Each mapper must generate the same number of key/value pairs as its input. True/false?”
- “A reducer is applied to all values associated with the same key. True/false?”
- “Calculate for each conference the average number of authors per paper. Describe map and reduce functions.”
- “Major features of HDFS that make it ideal for big data.”
- “Hadoop 2.0 improvements over Hadoop 1.0.”

**Model answer with explanation:**
- **Output files** = r (one per reducer). **Copy operations in shuffle** = m × r (each mapper partitions its output to every reducer).
- **Reduce method** can only be called after all mappers have finished processing all records (the shuffle/sort phase must gather all values for each key).
- **Map output** = false – a mapper can emit zero, one, or many key/value pairs per input record (e.g., word‑count emits one per word; a filter emits none).
- **Reducer** = true – each reducer invocation receives one key and the complete list of its values.
- **Average authors per conference (MapReduce)**
  - **Map:** split line on ‘|’; from field 1 (authors), split on ‘,’ to get author count; emit (conference, (author_count, 1)).
  - **Combine (optional):** locally sum author_counts and paper counts per conference to reduce shuffle traffic.
  - **Shuffle/sort:** group by conference.
  - **Reduce:** sum author_counts → total_authors; sum the 1s → total_papers; emit (conference, total_authors / total_papers).
- **HDFS features:** runs on commodity hardware; large block size (128 MB) for high‑throughput streaming reads; 3‑way replication with rack‑awareness for fault tolerance; write‑once read‑many model; NameNode (metadata) / DataNode (blocks) architecture; data locality (move compute to data).
- **Hadoop 2.0 improvements:** YARN (decouples resource management from processing, allows non‑MapReduce applications); HDFS High Availability (active/passive NameNodes); HDFS Federation (multiple independent NameNodes sharing DataNodes).
## 5. Apache Spark
**Question variations:**
- “Key difference between Hadoop and Spark?”
- “Primary feature of a Resilient Distributed Dataset (RDD)?”

**Model answer with explanation:**
- **Hadoop vs Spark** = all of the following: Hadoop stores intermediate data on disk, Spark keeps data in memory (10–100× faster); Hadoop uses MapReduce, Spark uses its own APIs (RDDs, DataFrames, streaming, MLlib); Hadoop is batch‑oriented, Spark supports batch, interactive, streaming and iterative processing.
- **RDD** = an immutable, fault‑tolerant, distributed collection of objects that can be processed in parallel. Fault tolerance is achieved by lineage (recomputation from the DAG of transformations) rather than data replication.
## 6. Serverless Computing / FaaS
**Question variations:**
- “How does serverless (AWS Lambda) handle sporadic, unpredictable workloads? Discuss cold start and cost.”
- “AWS Lambda execution model?”
- “Cold start overhead – does it affect user experience?”
- “Flixnet video streaming with daily file validation – serverless or containers?”

**Model answer with explanation:**
- **Serverless execution** = functions are triggered by events (HTTP, queue, storage). The platform automatically scales to zero when idle. On a new invocation after idle, a **cold start** occurs – the platform instantiates a container, causing extra latency. **Cost** = zero when idle, pay per invocation and compute time. **Unsuitable** for always‑running services, strict sub‑second latency, or executions longer than provider limits (e.g., 15 minutes for AWS Lambda).
- **Lambda execution model** = invoked and executed only when an event occurs (not continuously running).
- **Cold start** = true – it negatively impacts time‑sensitive applications.
- **Flixnet recommendation** = use serverless for the event‑driven validate‑and‑back‑up tasks (bursty, no idle cost); use containers for the core streaming service (constant load, no cold starts). If forced to choose one for the validation workload, serverless is better because files change sporadically and execution is short.
## 7. Kubernetes & Container Orchestration
**Question variations:**
- “Primary function of Horizontal Pod Autoscaler (HPA)?”
- “Comment on these statements: (i) A Pod always contains exactly one container. (ii) A Deployment ensures replicas and recreates failed pods. (iii) HPA adds/removes physical nodes. (iv) A Service provides a stable endpoint. (v) A Namespace provides hardware isolation.”
- “How does Kubernetes enable disaggregated storage?”

**Model answer with explanation:**
- **HPA** = automatically adjusts the number of pod replicas in a workload based on observed resource utilisation (e.g., CPU). Scaling nodes is the Cluster Autoscaler.
- **Statement corrections:**
  (i) False – a Pod can contain multiple containers.
  (ii) True – a Deployment manages ReplicaSets to maintain desired replicas and performs rolling updates.
  (iii) False – HPA scales pods; Cluster Autoscaler adds/removes nodes.
  (iv) True – a Service provides a stable IP/DNS name and load‑balances across pods selected by labels.
  (v) False – Namespace provides logical isolation (resource quotas, access control), not hardware isolation.
- **Disaggregated storage with Kubernetes** = PersistentVolumes (PV) and PersistentVolumeClaims (PVC) decouple storage from Pods. A PV exists independently of any Pod and is backed by network‑attached storage (Ceph, NFS, cloud block storage). A Pod can be rescheduled to any node while its PVC re‑binds to the same volume, allowing storage to be provisioned, scaled and managed separately from compute.
## 8. Energy Efficiency & Server Consolidation
**Question variations:**
- “Explain through an example how data locality contributes to energy efficiency.”
- “Schedule 3/4 VMs on 3 physical servers to minimise total power. Idle powers and per‑VM powers given. What allocation? Total power?”
- “Propose a DVFS‑based VM allocation mechanism to minimise power.”
- “What is PUE? Ideal value? Limitations?”

**Model answer with explanation:**
- **Data locality example** = In MapReduce, the scheduler places map tasks on the DataNode that already holds the input block. This avoids network transfer of terabytes of data → reduces switch/NIC energy and shortens completion time → total energy (Power × Time) is lower.
- **VM consolidation calculation** = pack all VMs onto the server with the lowest combined (idle power + total per‑VM power), then switch off the other servers.
  Example (4 VMs; idle: S1=110, S2=95, S3=120; per‑VM: 15,25,10): consolidate onto S2 → 95 + (4×25) = 195W; S1 and S3 off → total 195W. (If servers cannot be powered off, sum idle powers plus added per‑VM power.)
- **DVFS‑based allocation** = monitor CPU load on physical hosts and the application/service requirements (deadlines). Use a power‑aware scheduler (e.g., best‑fit bin‑packing) to place VMs, then scale each host’s voltage/frequency to the minimum that still meets the deadline, minimising energy while respecting SLAs. Migrate VMs off overloaded or underloaded hosts.
- **PUE** = Total facility power / IT equipment power. Ideal = 1.0 (all power to IT). Median ~1.55. **Limitations:** does not measure useful work (IT equipment may be idle); can be deflated by creative accounting.
## 9. SDN, NFV & 5G
**Question variations:**
- “Which statement about an SDN controller is correct?”
- “What concept does 5G use to support network function virtualisation?”

**Model answer with explanation:**
- **SDN controller** = communicates with forwarding devices over the **southbound interface** (e.g., OpenFlow, P4Runtime) to program flow tables, and exposes a **northbound interface** (e.g., REST/JSON API) to applications. The control plane is centralised; the data plane (packet forwarding) remains in switches.
- **5G concept for NFV** = **network slicing** – creates multiple virtualised, isolated end‑to‑end logical networks (slices) over a shared physical infrastructure, each customised for a specific use case (e.g., URLLC, mMTC, eMBB).
## 10. Edge / IoT / Fog Computing (Scenario Questions – 7 marks)
**Question variations:**
- “Forest fire detection with battery‑powered sensors and intermittent connectivity.”
- “Strawberry greenhouse monitoring (temperature, irrigation).”
- “Blind navigation headset with limited compute.”
- “Smart city air‑quality and traffic management.”

**Model answer structure (compact):**

**Edge layer (sensor / headset / camera):**
- Run lightweight, quantised ML model (TinyML / MobileNet) for real‑time anomaly detection (fire, obstacle, temperature threshold).
- Actuate locally (alarm, valve, voice alert) – works offline.
- Use low‑power communication (LoRa, BLE, ZigBee) to conserve battery.

**Fog / gateway layer:**
- Aggregates data from multiple nodes; performs filtering, compression, and cross‑node correlation.
- Runs containerised services orchestrated by lightweight Kubernetes (K3s).
- Sends alerts and summaries to cloud when connectivity available.

**Cloud layer:**
- Long‑term storage, historical analytics, ML model retraining (e.g., fire risk prediction).
- Dashboard for operators, notification services (SMS/email).
- Pushes updated models back to edge via federated learning.

**Justification (choose 2–3 relevant to scenario):**
- **Latency** – urgent corrections cannot wait for cloud round‑trip.
- **Bandwidth** – edge filtering reduces data sent over expensive/slow networks.
- **Reliability** – edge continues working when cloud link is down.
- **Privacy** – sensitive data (camera feeds) stays local.
- **Energy** – low‑power edge devices run on batteries for months/years.
## 11. Virtual Machine Live Migration
**Question variations:**
- “Application deployment where migration is key – VMs or containers? Explain.”
- “Pre‑copy vs post‑copy memory migration.”
- “LAN vs WAN migration – what changes?”

**Model answer with explanation:**
- **VMs** are preferred when **live migration of a running, stateful workload** is key. VM live migration (pre‑copy / post‑copy) transfers the complete state (memory, disk, network) with minimal downtime and strong hardware isolation. Containers are usually stateless and are rescheduled rather than live‑migrated.
- **Pre‑copy** = copies memory state iteratively while the VM runs, then pauses briefly to transfer CPU state and final dirty pages – more reliable. **Post‑copy** = transfers CPU state first, then fetches memory pages on‑demand from the source – faster but less stable.
- **LAN migration** = VM retains its private IP address; an unsolicited ARP reply updates the MAC address so traffic reaches the new host. **WAN migration** = private and public IPs generally change; use DNS names instead of hardcoded IPs; disk state must be recreated or replicated (largest cost).
## 12. OpenStack vs OpenNebula
**Question variation:** “Compare OpenStack with OpenNebula using five criteria of your choice.”

**Model answer (table form for compactness):**

| Criterion        | OpenStack                                                                           | OpenNebula                          |
| ---------------- | ----------------------------------------------------------------------------------- | ----------------------------------- |
| **Architecture** | Modular (7+ core projects: Nova, Neutron, Cinder, Swift, Glance, Keystone, Horizon) | Monolithic (single integrated core) |
| **Target scale** | Large data centres (thousands+ nodes, 25M+ cores in production)                     | Medium (hundreds of servers)        |
| **Networking**   | Neutron – advanced SDN, pluggable drivers                                           | Basic Linux bridge networking       |
| **Scheduling**   | Nova scheduler with filters/weights                                                 | Rank‑based match‑making scheduler   |
| **Dashboard**    | Horizon (web GUI)                                                                   | Sunstone (web GUI)                  |
| **Use case**     | Carrier‑grade, large‑scale, federated clouds                                        | Simple private/hybrid clouds        |
## 13. Docker Commands (Quick Reference – not heavily examined)

| Command                       | Purpose                                  |
| ----------------------------- | ---------------------------------------- |
| `docker build -t name .`      | Build image from Dockerfile              |
| `docker run name`             | Start container from image               |
| `docker ps`                   | List running containers                  |
| `docker stop` / `docker rm`   | Stop / remove container                  |
| `docker images`               | List images                              |
| `docker rmi`                  | Remove image                             |
| `docker pull` / `docker push` | Download / upload image from/to registry |
| `docker exec`                 | Run command inside running container     |
## 14. Clock Synchronisation (Cristian / Berkeley)

**Question variations:**
- “Cristian’s algorithm: client clock reads HH:MM:SS, server clock reads HH:MM:SS, RTT = 2 seconds. What is client time after synchronisation?”
- “Berkeley algorithm: coordinator clock at HH:MM, other clocks are given. Compute adjustments and final time.”

**Model answer with explanation:**
- **Cristian’s algorithm** = Client time = Server time + (RTT / 2).
  *Example:* Client reads 5:26:08, server reads 5:16:44, RTT = 2 seconds → Client time = 5:16:44 + 1 sec = 5:16:45.
- **Berkeley algorithm** = Coordinator reads all clocks, computes average (including its own), then sends each node its adjustment (difference from average). All clocks set to the average time.
  *Example:* Coordinator 08:45, B 08:43, C 08:49, D 08:42, E 08:46 → average = 08:45. Adjustments: A 0, B +2, C -4, D +3, E -1. Final: all at 08:45.
## 15. Bully Election Algorithm
**Question variations:** “Nodes 0..5, coordinator 5 crashes, node 0 notices first. Describe election using bully algorithm.”

**Model answer with explanation:**
- **Message types:** ELECTION (sent to higher‑numbered nodes), OK/ANSWER (reply from a live higher node), COORDINATOR (winner announces itself).
- **Process (example with nodes 0‑5, coordinator 5 crashes, node 0 notices):**
  1. Node 0 sends ELECTION to 1,2,3,4,5.
  2. Nodes 1‑4 reply OK; node 5 silent. Node 0 drops out.
  3. Node 1 sends ELECTION to 2,3,4,5 – nodes 2‑4 reply OK; node 1 drops.
  4. Node 2 sends ELECTION to 3,4,5 – nodes 3‑4 reply OK; node 2 drops.
  5. Node 3 sends ELECTION to 4,5 – node 4 replies OK; node 3 drops.
  6. Node 4 sends ELECTION to 5 – no reply.
  7. Node 4 sends COORDINATOR to 0,1,2,3.
- **New coordinator** = node 4 (highest‑numbered live node).
## 16. Other Common MCQ Answers

| Topic                                                  | Correct answer                                                            |
| ------------------------------------------------------ | ------------------------------------------------------------------------- |
| TPU advantage over CPU/GPU                             | Specifically designed for high‑performance machine learning computations. |
| Unstructured data example                              | Emails, social media posts, images.                                       |
| TensorFlow programming model                           | Data‑flow graph (nodes = operations, edges = tensors).                    |
| Two most important network performance characteristics | Latency and packet loss rate.                                             |
| Bare‑metal hypervisor                                  | Runs directly on server hardware.                                         |
| HPA vs Cluster Autoscaler                              | HPA scales pods; Cluster Autoscaler scales nodes.                         |
| PUE ideal value                                        | 1.0.                                                                      |
| AWS Lambda execution model                             | Invoked only when an event occurs.                                        |
| Cold start effect on user experience                   | True – delays time‑sensitive applications.                                |
