### To-do
- [x] Setup a *Virtual Network*.
- [x] Setup a *Virtual Machine*.
- [x] Setup *Prometheus*,
	- [x] *node_exporter*, 
	- [x] *Grafana* and
	- [x] *stress-ng* (Week 3)
- [x] Setup *Docker* (Week 4)
- [x] Setup *Minikube* (Week 5)
- [x] Setup *iperf3* and *wrk* (Week ?)
## Setup a Virtual Network
Creating the VNet before creating a VM is still best practice:
- Open the Azure Portal
- Go to Virtual networks
- Click Create
- Name: vnet-ab
- Subscription: your subscription (UoL provided subscription)
- Resource group: ✅ select from the existing Resource Groups (RGs) that appear
- Name: put a name in your Virtual Network, e.g. Nexus or Scadufax
- Region: same region as the RG. For the UoL subscription we select (UK) UK South.
- Configure the IP address space of your virtual network with one or more IPv4 address ranges.
- Review + create.
## Setup a Virtual Machine
This quickstart shows you how to use the Azure portal to deploy a Linux virtual machine (VM) running Ubuntu Server 22.04 LTS. To see your VM in action, you also SSH to the VM and install the NGINX web server.

- Enter _virtual machines_ in the search.
- Under **Services**, select **Virtual machines**.
- In the **Virtual machines** page, select **Create** and then **Virtual machine**. The **Create a virtual machine** page opens.
- In the **Basics** tab, under **Project details**, make sure the correct subscription is selected and then choose to **Create new** resource group. Enter _myResourceGroup_ for the name.
    ![Screenshot of the Project details section showing where you select the Azure subscription and the resource group for the virtual machine|585](https://learn.microsoft.com/en-us/azure/reusable-content/ce-skilling/azure/media/virtual-machines/project-details.png)
- Under **Instance details**, enter _myVM_ for the **Virtual machine name**. Under **Availability options**, select _No infrastructure redundancy required_. Under **Security type**, select _Standard_. Choose _Ubuntu Server 22.04 LTS - Gen2_ for your **Image**. Leave the other defaults. The default size and pricing is only shown as an example. Size availability and pricing are dependent on your region and subscription.
    ![Screenshot of the Instance details section where you provide a name for the virtual machine and select its region, image, and size.|654](https://learn.microsoft.com/en-us/azure/reusable-content/ce-skilling/azure/media/virtual-machines/instance-details.png)
    
Note:Some users will now see the option to create VMs in multiple zones. To learn more about this new capability, see [Create virtual machines in an availability zone](https://learn.microsoft.com/en-us/azure/virtual-machines/create-portal-availability-zone). ![Screenshot showing that you have the option to create virtual machines in multiple availability zones.|550](https://learn.microsoft.com/en-us/azure/virtual-machines/media/create-portal-availability-zone/preview.png)
- Under **Administrator account**, for **Authentication type**, select **SSH public key**.
- In **Username** enter _azureuser_.
- For **SSH public key source**, leave the default of **Generate new key pair**, and then enter _myKey_ for the **Key pair name**.
    ![Screenshot of the Administrator account section where you select an authentication type and provide the administrator credentials|553](https://learn.microsoft.com/en-us/azure/reusable-content/ce-skilling/azure/media/virtual-machines/administrator-account.png)
- Under **Inbound port rules** > **Public inbound ports**, choose **Allow selected ports** and then select **SSH (22)** and **HTTP (80)** from the drop-down.
    ![Screenshot of the inbound port rules section where you select what ports inbound connections are allowed on|564](https://learn.microsoft.com/en-us/azure/reusable-content/ce-skilling/azure/media/virtual-machines/inbound-port-rules.png)
    
- Leave the remaining defaults and then select the **Review + create** button at the bottom of the page. A final validation runs.
- On the **Create a virtual machine** page, review the details about the VM you're about to create. When you're ready, select **Create**.
- When the **Generate new key pair** window opens, select **Download private key and create resource**. Your key file will be download as **myKey.pem**. Make sure you know where the `.pem` file was downloaded; you'll need the path to it in the next step.
- When the deployment is finished, select **Go to resource**.
- On the page for your new VM, select the public IP address and copy it to your clipboard.
### ## Connect to virtual machine
Create an [SSH connection](https://learn.microsoft.com/en-us/azure/virtual-machines/linux-vm-connect) with the VM.
1. If you're on a Windows machine, open a PowerShell prompt. If you're on a Mac or Linux machine, open a Bash prompt and set read-only permission on the .pem file using `chmod 400 ~/Downloads/myKey.pem`.
2. At your prompt, open an SSH connection to your virtual machine. Replace the IP address with the one from your VM, and replace the path to the `.pem` with the path to where the key file was downloaded.
```
ssh -i ~/Downloads/myKey.pem azureuser@20.90.75.243
```
**Tip**
The SSH key you created can be used the next time your create a VM in Azure. Just select the **Use a key stored in Azure** for **SSH public key source** the next time you create a VM. You already have the private key on your computer, so you won't need to download anything.
### Install web server
To see your VM in action, install the NGINX web server. From your SSH session, update your package sources and then install the latest NGINX package.
- [Ubuntu](https://learn.microsoft.com/en-us/azure/virtual-machines/linux/quick-create-portal?tabs=ubuntu#tabpanel_1_ubuntu)
```
sudo apt-get -y update
sudo apt-get -y install nginx
```
When done, type `exit` to leave the SSH session.
#### View the web server in action
Use a web browser of your choice (not in the vm) to view the default NGINX welcome page. Type the public IP address of the VM as the web address. 
## Setup Prometheus and Grafana
There are many online tutorials on how to install and use Prometheus with Grafana.The recommended one for this task is [Getting Started with Prometheus and Grafana.](https://medium.com/devops-dudes/install-prometheus-on-ubuntu-18-04-a51602c6256b)
### Overview
Steps:
- Log into Microsoft Azure portal
- Start the Ubuntu Virtual Machine you created (see previous lab. session)
- Open a shell.
- Follow the tutorial [Getting Started with Prometheus and Grafana.](https://medium.com/devops-dudes/install-prometheus-on-ubuntu-18-04-a51602c6256b) You will need 
	1) to setup Prometheus first: install the node_exporter, install, configure and test Prometheus; 
	2) setup Grafana for Prometheus, and 
	3) check the installation and do some basic tests.

When following the steps in the tutorial, to take advantage of the latest version of:
- **Node Exporter**: download version **1.7.0** (node_exporter-1.7.0.linux-amd64.tar.gz) instead of 1.7.0
- **Prometheus**: download version **2.49.1** (prometheus-2.49.1.linux-amd64.tar.gz) instead of 2.49.1
- **Grafana**: download grafana-enterprise_**10.3.3**_amd64.deb instead of 5.0.4, see [Grafana download page](https://grafana.com/grafana/download?pg=oss-graf&plcmt=hero-btn-1).
**Note 1**: Prometheus provides a web User Interface for running basic queries located at **http://<your_server_IP>:9090/.** Inspect the list of metrics and do some test.

**Note 2**: When you finish installing Prometheus on your virtual machine, ensure you open the respective port on the Azure portal (9090) by creating an inbound port rule.

**Note 3**: Once Grafana is running, you can connect to it at **http://<your_server_IP>:3000/.** You need to create your first dashboard from the information collected by Prometheus. Alternatively, you can import an existing dashboard from a collection of [shared dashboards](https://grafana.com/dashboards?dataSource=prometheus) from Grafana Web site. For example, why not identify the ID of the "Node Exporter Full" dashboard?

**Note 4** When you finish installing Grafana on your virtual machine, ensure you open the respective port on the Azure portal (3000) by creating an inbound port rule.
### Starting from scratch if you're an idiot
```bash
# Stop the Running Services
sudo systemctl stop prometheus
sudo systemctl stop node_exporter
sudo systemctl stop grafana-server

# Nuke Prometheus and Node Exporter
# Binaries
sudo rm /usr/local/bin/prometheus
sudo rm /usr/local/bin/promtool
sudo rm /usr/local/bin/node_exporter

# configuration and data directories
sudo rm -rf /etc/prometheus 
sudo rm -rf /var/lib/prometheus

# systemd service files
sudo rm /etc/systemd/system/prometheus.service 
sudo rm /etc/systemd/system/node_exporter.service

# grafana
sudo apt-get purge -y grafana grafana-enterprise
sudo apt-get autoremove -y

sudo apt-get purge -y grafana grafana-enterprise 
sudo apt-get autoremove -y

# data or log directories
sudo rm -rf /etc/grafana 
sudo rm -rf /var/lib/grafana 
sudo rm -rf /var/log/grafana

# reload
sudo systemctl daemon-reload

```
### Installing node_exporter 
```bash
# Download the Node Exporter on all machines
wget https://github.com/prometheus/node_exporter/releases/download/v1.7.0/node_exporter-1.7.0.linux-amd64.tar.gz

# Extract the downloaded archive
tar -xf node_exporter-1.7.0.linux-amd64.tar.gz

# Move the node_exporter binary to /usr/local/bin
sudo mv node_exporter-1.7.0.linux-amd64/node_exporter /usr/local/bin

# Remove the residual files
rm -r node_exporter-1.7.0.linux-amd64*

```

Next, we will create users and service files for node_exporter.

> For security reasons, run any services/daemons in separate accounts of their own. Thus, we are going to create a user account for node_exporter. Use the `-r` flag to indicate it is a system account, and set the default shell to `/bin/false` using `-s` to prevent logins.

```bash
# Create an user account for node_exporter
sudo useradd -rs /bin/false node_exporter

 Create a systemd unit file so that node_exporter can be started at boot. 
sudo vim /etc/systemd/system/node_exporter.service

```

```bash
[Unit]  
Description=Node Exporter  
After=network.target  
  
[Service]  
User=node_exporter  
Group=node_exporter  
Type=simple  
ExecStart=/usr/local/bin/node_exporter  
  
[Install]  
WantedBy=multi-user.target

```

Since we have created a new unit file, we must reload the systemd daemon, set the service to always run at boot and start it.
```bash
sudo systemctl daemon-reload  
sudo systemctl enable node_exporter  
sudo systemctl start node_exporter

```
### Installing Prometheus
```bash
# Install Prometheus only on the Prometheus Server.
wget https://github.com/prometheus/prometheus/releases/download/v2.49.1/prometheus-2.49.1.linux-amd64.tar.gz

# Extract the Prometheus archive :
tar -xf prometheus-2.49.1.linux-amd64.tar.gz

# Move the binaries to `/usr/local/bin`:
sudo mv prometheus-2.49.1.linux-amd64/prometheus prometheus-2.49.1.linux-amd64/promtool /usr/local/bin

# Now, we need to create directories for configuration files and other prometheus data.
sudo mkdir /etc/prometheus /var/lib/prometheus

# Then, we move the configuration files to the directory we made previously:
sudo mv prometheus-2.49.1.linux-amd64/consoles prometheus-2.49.1.linux-amd64/console_libraries /etc/prometheus

# Finally, we can delete the leftover files as we do not need them any more:
rm -r prometheus-2.49.1.linux-amd64*

```
### ### Configuring Prometheus
After having installed Prometheus, we have to configure Prometheus to let it know about the HTTP endpoints it should monitor. Prometheus uses the [YAML](https://en.wikipedia.org/wiki/YAML) format for its configuration.

```bash
# Go to hosts
sudo vim /etc/hosts

# Add the following, replace x.x.x.x with the machine’s corresponding IP address
20.90.75.243 prometheus-target-1  
20.90.75.243 prometheus-target-2

```

We will use `/etc/prometheus/prometheus.yml` as our configuration file
```bash
# Create the YAML config file
sudo vim /etc/prometheus/prometheus.yml

```

```bash
global:  
  scrape_interval: 10s  
  
scrape_configs:  
  - job_name: 'prometheus_metrics'  
    scrape_interval: 5s  
    static_configs:  
      - targets: ['localhost:9090']  
  - job_name: 'node_exporter_metrics'  
    scrape_interval: 5s  
    static_configs:  
      - targets: ['localhost:9100','prometheus-target-1:9100','prometheus-target-2:9100']

```

In this file, we have defined:
- a default scraping interval of 10 seconds. 
- two sources of metrics, named `prometheus_metrics` and `node_exporter_metrics`. 
	- For both of them, we have set the scraping interval to 5 seconds, overriding the default. 
- the locations where these metrics will be available. 
Prometheus uses port 9090 and node_exporter uses port 9100 to provide their metrics.
```bash 
# Change the ownership of files that Prometheus will use
sudo useradd -rs /bin/false prometheus
sudo chown -R prometheus: /etc/prometheus /var/lib/prometheus

```

```bash
# Create a systemd unit file in /etc/systemd/system/prometheus.service
sudo vim /etc/systemd/system/prometheus.service

[Unit]  
Description=Prometheus  
After=network.target  
  
[Service]  
User=prometheus  
Group=prometheus  
Type=simple  
ExecStart=/usr/local/bin/prometheus \  
    --config.file /etc/prometheus/prometheus.yml \  
    --storage.tsdb.path /var/lib/prometheus/ \  
    --web.console.templates=/etc/prometheus/consoles \  
    --web.console.libraries=/etc/prometheus/console_libraries  
  
[Install]  
WantedBy=multi-user.target

```

```bash
# Reload systemd:
sudo systemctl daemon-reload  
sudo systemctl enable prometheus  
sudo systemctl start prometheus

```

```bash
# Install a light-weight browser like Midori
sudo snap install midori

```
Prometheus provides a web UI for running basic queries located at `http://<your_server_IP>:9090/`. This is how it looks like in a web browser:
![](https://miro.medium.com/v2/resize:fit:700/1*xNEdWSkZU0zsNHh2-AGr4A.png)
## Docker
For this session, we will use [How To Install and Use Docker on Ubuntu 18.04](https://www.digitalocean.com/community/tutorials/how-to-install-and-use-docker-on-ubuntu-18-04) tutorial, which is compatible with a Ubuntu 22.04 LTS Virtual Machine in Azure.
You can also install Docker in a Ubuntu 22.04 LTS virtual machine running on Virtualbox hypervisor.
## UPDATE
This is a massive discovery. Finding these instructor clarifications just saved you from losing significant marks across almost every section of the rubric.

The instructor has drastically changed the expectations for **Task B (Environment)**, **Task C (Deployment)**, and **Task E (Discussion)**.

Here is exactly what this new information means for your coursework, how we must pivot our strategy, and the immediate next steps to guarantee that 90-100% grade.

---
### 🚨 The 4 Critical Changes to Our Strategy
#### 1. The Architecture Split (1 VM ➔ 2 VMs)
- **What it means:** We can no longer use your single Azure Ubuntu VM to run both Minikube and K3s sequentially. The instructor explicitly expects **two distinct machines**: a heavy "Cloud" server and a restricted "Edge" client.
- **The Pivot:** * **VM 1 (Cloud):** Your existing Azure Ubuntu VM. This will permanently run Minikube, Prometheus, and Grafana.
    - **VM 2 (Edge):** You must spin up a _second_ Virtual Machine. The instructor specifically suggested **Alpine Linux** to simulate a Raspberry Pi 5. You should configure this new VM with exactly **4 CPU cores and 4GB or 8GB of RAM** to accurately mimic the Pi 5's hardware. This VM will run K3s and `node_exporter`.
#### 2. The Monitoring Network (Scraping the Edge)
- **What it means:** Because we are moving to two VMs, Prometheus (on the Cloud VM) needs to reach across the network to scrape metrics from `node_exporter` (on the Edge VM).
- **The Pivot:** You must open Port `9100` on the new Edge VM's firewall. We will then add the Edge VM's IP address to the `prometheus.yml` file on your Cloud VM so Grafana can pull its CPU/Memory stats.
#### 3. VNF Complexity Upgrade (1 VNF ➔ 2 Chained VNFs)
- **What it means:** The instructor explicitly stated: _"You will be rewarded for more successfully created, complex scenarios. 2 is fine."_ A single HAProxy load balancer is no longer enough for top marks.
- **The Pivot:** We will deploy a **2-VNF Service Chain**.
    - **VNF 1:** HAProxy (5G MEC Traffic Gateway / UPF Emulator)
    - **VNF 2:** CoreDNS (5G Edge DNS Resolver) or a lightweight packet filter/firewall.
    - _The Scenario:_ User traffic hits the Edge DNS to resolve the service, then flows through the HAProxy Gateway. This is a highly complex, 100% realistic telecom edge scenario that will heavily impress the examiner.
#### 4. The Literature Review (For Task E)
- **What it means:** You cannot just write your own thoughts for Q5. You must cite academic papers.
- **The Pivot:** When you write your report, you must search Google Scholar for papers comparing "K3s vs K8s performance at the edge" or "Kubernetes network overhead in telecom." You will contrast your `iperf3` results with their findings.

---
### 🛠️ Immediate Next Steps
Since you are back on your beastly **Windows 11 Lab PC (32GB RAM, i7)**, you have a choice. You can either spin up the new Alpine Edge VM in Azure (which costs credits), or you can use VirtualBox/Hyper-V right there on your lab PC to run both VMs locally for free.
Assuming you want to keep the Cloud VM in Azure (since we already installed Prometheus/Grafana there), here is exactly what you need to do next:
#### Step 1: Provision the Edge VM (Simulating a Raspberry Pi 5)
Spin up a new Virtual Machine (either in Azure or locally via VirtualBox on your Lab PC).
- **OS:** Alpine Linux (or a very minimal Ubuntu Server install if Alpine is too difficult to provision in Azure).
- **Specs:** 4 vCPUs, 4GB or 8GB RAM.
- **Ports to Open:** `22` (SSH), `6443` (K3s API), `9100` (Node Exporter), `5201` (iperf3), and `80` (HTTP).
#### Step 2: Update the `k8s_setup.sh` Script
Because our script is so well-organized, adapting to this new requirement is trivial and perfectly satisfies the instructor's requirement for "Reproducibility" (Info 3).

You will run the script on the **Cloud VM** to start Minikube, and run a copy of the script on the **Edge VM** to install K3s and `node_exporter`.
#### Step 3: Connect Prometheus to the Edge
On your Cloud VM, open your Prometheus config:
```bash
sudo nano /etc/prometheus/prometheus.yml
```
Update the targets list to include the internal or public IP of your new Edge VM:
```YAML
  - job_name: 'node_exporter_metrics'
    static_configs:
      - targets: ['localhost:9100', '<EDGE_VM_IP>:9100']
```

Then restart Prometheus: `sudo systemctl restart prometheus`.

---
**How would you like to proceed?** Do you want to spin up the Alpine Edge VM in Azure right now, or do you want to use VirtualBox on your Lab PC? Let me know, and I will give you the exact commands to provision it and install the 2-VNF Service Chain!
### The New Architecture Map
To satisfy this requirement, here is exactly how your software must be split across two separate VMs:
	
|Component|VM 1: The "Server" (Cloud)|VM 2: The "Client" (Edge)|
|---|---|---|
|**Operating System**|Ubuntu 22.04 LTS (Your Azure VM)|Alpine Linux (or lightweight Ubuntu)|
|**Kubernetes Engine**|Minikube|K3s|
|**Hardware Scraper**|**Node Exporter** (Runs here)|**Node Exporter** (Runs here too)|
|**Data Storage**|**Prometheus** (Runs here)|_None_ (Must not be installed here)|
|**Visualisation**|**Grafana** (Runs here)|_None_ (Must not be installed here)|
## RESULTS (OLD)
This is a brilliant moment for your coursework, and the "failure" of Test 1 is actually an incredibly valuable technical talking point for your report!
### Why did the Ping test fail? (The "Kubernetes ICMP Drop")
The ping test returned 100% packet loss because you pinged `mec-gateway-svc`. In Kubernetes, a `Service` (ClusterIP) is not a real physical network interface; it is a set of `iptables` rules managed by `kube-proxy`. By design, Kubernetes Services **do not route ICMP (ping) traffic**. They only route the specific TCP/UDP ports you defined in your manifest (ports 80 and 5201).

To successfully ping the VNF for your connectivity check (Task D), you must ping the actual **Pod IP**, not the Service name.
### How to Fix Test 1 in your Script
Open your `k8s_setup.sh` script, go to the `"test"` block, and replace **TEST 1** with this updated version that dynamically fetches the exact Pod IP before pinging it:

```bash
log_info "TEST 1: ICMP Ping (Baseline Network Latency)"
log_data "Pinging the VNF Pod directly (K8s Services drop ICMP traffic)."
if ask_yes_no "Run Ping test?"; then
	# Dynamically extract the Pod IP of the HAProxy VNF
	VNF_POD_IP=$(kubectl get pod -l app=mec-gateway -o jsonpath='{.items[0].status.podIP}')
	log_info "Extracted VNF Pod IP: $VNF_POD_IP"
	kubectl run -i --tty --rm ping-client --image=alpine --restart=Never -- sh -c "ping -c 5 $VNF_POD_IP"
	log_success "Ping test complete. Record the avg latency (ms) for your report."
fi
echo ""
```

---
### Analysing Your Cloud (Minikube) Results
Your `iperf3` and `wrk` tests executed flawlessly. These are the exact numbers you need to log in a spreadsheet for your Cloud vs. Edge comparison:

**1. Throughput (iperf3):** * **Result:** `1.87 Gbits/sec`
- _What this means:_ Your Minikube cloud environment successfully routed 4.34 Gigabytes of data through the HAProxy VNF in 20 seconds. This is your Cloud bandwidth ceiling.    
**2. HTTP Load Simulation (wrk):**
- **Result:** `3797.61 Requests/sec`
- **Latency:** `27.94ms` (Average)
- _What this means:_ When simulating 100 concurrent 5G users hammering the network, the Cloud VNF processed roughly 3,800 requests every second, with a very respectable 28-millisecond delay.
### The Next Step: The Edge Comparison
You now have your complete **Cloud (Minikube)** dataset. It is time to see how the lightweight **Edge (K3s)** environment compares.
Run your script to switch environments and gather the other half of your data:
1. Run `./k8s_setup.sh` and select **06 (Start Edge - K3s)**.
2. Select **07 (Deploy VNF & Run Hello World)** to deploy the exact same VNF into the K3s cluster.
3. Select **08 (Run Experimental Load Tests)** to get the K3s numbers.

Once you have both sets of numbers, compare the `iperf3` Bitrate and `wrk` Latency. Did K3s perform faster because it lacks the heavy overhead of Minikube? Let me know what the K3s results are!
## Gradescope
The current architecture represents a textbook implementation of the **ETSI MANO (Management and Orchestration)** framework, bridging modern cloud-native deployment with highly specialised telecommunications routing.

Here is the cohesive synthesis of the theoretical computer science concepts driving this specific 5G Edge environment.

### Part 1: The Architectural Blueprint & Logical Flow

The infrastructure is physically divided into two distinct environments to empirically contrast orchestration overhead and container runtime efficiency.

#### 1. The NFVI (Network Functions Virtualisation Infrastructure)

- **The Cloud Node (The Heavy Orchestrator):** Hosted on an Ubuntu Azure Virtual Machine. This acts as the centralised datacenter. It runs **Minikube** utilizing **Docker** as its Container Runtime Engine. Because Docker relies on a heavy, virtualized bridge network daemon, this node represents a traditional, highly abstracted cloud environment. It also acts as the **Telemetry Hub**, hosting the Prometheus Time-Series Database and Grafana to provide centralized **Observability** across the entire WAN.
    
- **The Edge Node (The Lightweight Client):** Hosted on a severely resource-constrained VM simulating a Raspberry Pi 5. It runs **K3s**, which strips out Docker and uses **containerd** natively. This node represents a Multi-Access Edge Computing (MEC) facility physically located near the end-user (e.g., at a 5G cell tower).
    

#### 2. The MANO Layer (Management and Orchestration)

In this setup, Kubernetes is the **Orchestrator**. It uses **Declarative Infrastructure as Code (IaC)**. Rather than imperatively typing commands to route traffic, a YAML manifest defines the desired state. The Kubernetes **Control Plane** (specifically the `kube-scheduler` and `kube-controller-manager`) constantly monitors the physical nodes. When the manifest is applied, the scheduler uses bin-packing algorithms to allocate the VNFs to the worker nodes, ensuring they do not exceed their strict memory and CPU limits.

#### 3. The Logical Service Graph (Traffic Flow)

When a user (simulated by `wrk` or `iperf3`) sends a request, it traverses a **Service Function Chain (SFC)**.

1. Traffic hits the node's network interface and is intercepted by `kube-proxy`.
    
2. `kube-proxy` utilizes Linux `iptables` to resolve the permanent Kubernetes **Service** IP to the ephemeral **Pod** IP.
    
3. The packet is routed sequentially through three distinct **Virtualised Network Functions (VNFs)** before finally reaching the backend target application (the web server or iperf daemon).
    

---

### Part 2: The Virtualised Network Functions (VNFs)

In traditional telecommunications, these three roles would require three separate, expensive pieces of proprietary hardware (e.g., Cisco or Juniper appliances). Through **NFV**, they have been converted into software **Microservices** running on commodity hardware.

#### VNF 1: The Edge Security Firewall (NGINX)

- **Mechanics:** This is the ingress point. It operates at both Layer 4 (Transport) and Layer 7 (Application) of the OSI model. A Kubernetes **ConfigMap** injects the `nginx.conf` routing logic directly into the container's memory. It listens on Port 5201 for raw TCP throughput and Port 80 for HTTP traffic.
    
- **Role:** It provides Admission Control. Any traffic not strictly addressed to the defined ports is instantly dropped at the edge, preventing malicious actors from traversing deeper into the MEC network.
    

#### VNF 2: The DPI / IDS Emulator (NGINX)

- **Mechanics:** Deep Packet Inspection (DPI) and Intrusion Detection Systems (IDS) are computationally expensive. When HTTP traffic arrives, this VNF must actively unbox the TCP packet, read the Layer 7 HTTP headers, inspect them, modify them by injecting an `X-DPI-Inspected` security stamp, repackage the packet, and forward it.
    
- **Role:** In a telco environment, this represents Lawful Interception, malware scanning, or zero-trust security validation. It serves as the primary "computational stressor" in the Service Chain, deliberately designed to test the CPU context-switching limits of the Edge Node.
    

#### VNF 3: The MEC UPF Gateway (HAProxy)

- **Mechanics:** Operating as a highly concurrent TCP/HTTP proxy, HAProxy maintains the connection state between the user and the backend. It uses event-driven, single-threaded architecture to handle thousands of concurrent connections with minimal memory footprint.
    
- **Role:** This acts as the **User Plane Function (UPF)** in a 5G core network. Once the traffic is secured and inspected by the previous two VNFs, the UPF intelligently load-balances and routes the packets to the final Edge applications (the backend web and iperf servers).
    

---

### Part 3: Telecom Scenario Suitability & Resource Justification

#### The Scenario: A 5G Zero-Trust Enterprise Slice

This 3-VNF architecture perfectly emulates **Slicing as a Service (SlaaS)**. Imagine a hospital utilizing a 5G network for remote robotic surgery. The hospital cannot allow its traffic to mix with public internet traffic, nor can it afford the latency of sending packets to a central cloud in another city.

The telco provisions an isolated **Network Slice** directly at the Edge (the hospital's local 5G tower). The Firewall (VNF 1) locks the slice down. The DPI node (VNF 2) ensures no malware has compromised the surgical robots. The UPF Gateway (VNF 3) routes the telemetry directly to the local edge servers with sub-millisecond latency.

#### Justification of Microservices vs. Monoliths

Deploying a monolithic 5G core (like Free5GC or Open5GS) requires massive RAM overhead, violating the strict < 2GB resource constraints of an Edge environment. Furthermore, these monolithic functions are difficult to dynamically scale.

By decomposing the routing logic into three distinct, containerised proxies (NGINX and HAProxy), the architecture utilizes **Microservices** rather than Serverless Nanoservices or Monoliths.

- **Why not Serverless (FaaS)?** Serverless functions suffer from "Cold Starts" (latency spikes when containers boot up). Telecommunications routing requires persistent, state-aware connections with zero latency variation.
    
- **Resource Efficiency:** Because these microservices are written in highly optimized C, their resource limits were safely constrained to `100Mi` memory and `200m` CPU limits in the Kubernetes manifests. This allowed extreme **Server Consolidation**—packing the entire 3-VNF Service Chain onto a single constrained Edge node without creating a CPU hotspot or triggering the Kubernetes Out-Of-Memory (OOM) killer.
    

---

With this theoretical synthesis complete, you have the exact narrative required to frame your experimental data. Would you like to begin outlining the structure for the final Task E report, mapping the specific Minikube vs. K3s data points to these architectural concepts?