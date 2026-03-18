### To-do
- [x] Setup a *Virtual Network*.
- [x] Setup a *Virtual Machine*.
- [ ] Setup *Prometheus*, *node_exporter* and *Grafana* (Week 3)
- [ ] Setup *Docker* (Week 4)
- [ ] Setup *Minikube* (Week 5)
- [ ] Setup *stress-ng*, *iperf3* and *wrk* (Week )
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
ssh -i ~/Downloads/myKey.pem azureuser@10.111.12.123
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

Steps:
- Log into Microsoft Azure portal
- Start the Ubuntu Virtual Machine you created (see previous lab. session)
- Open a shell.
- Follow the tutorial [Getting Started with Prometheus and Grafana.](https://medium.com/devops-dudes/install-prometheus-on-ubuntu-18-04-a51602c6256b) You will need 
	1) to setup Prometheus first: install the node_exporter, install, configure and test Prometheus; 
	2) setup Grafana for Prometheus, and 
	3) check the installation and do some basic tests.

When following the steps in the tutorial, to take advantage of the latest version of:
- **Node Exporter**: download version **1.7.0** (node_exporter-1.7.0.linux-amd64.tar.gz) instead of 0.15.2
- **Prometheus**: download version **2.49.1** (prometheus-2.49.1.linux-amd64.tar.gz) instead of 2.1.0
- **Grafana**: download grafana-enterprise_**10.3.3**_amd64.deb instead of 5.0.4, see [Grafana download page](https://grafana.com/grafana/download?pg=oss-graf&plcmt=hero-btn-1).
**Note 1**: Prometheus provides a web User Interface for running basic queries located at **http://<your_server_IP>:9090/.** Inspect the list of metrics and do some test.

**Note 2**: When you finish installing Prometheus on your virtual machine, ensure you open the respective port on the Azure portal (9090) by creating an inbound port rule.

**Note 3**: Once Grafana is running, you can connect to it at **http://<your_server_IP>:3000/.** You need to create your first dashboard from the information collected by Prometheus. Alternatively, you can import an existing dashboard from a collection of [shared dashboards](https://grafana.com/dashboards?dataSource=prometheus) from Grafana Web site. For example, why not identify the ID of the "Node Exporter Full" dashboard?

**Note 4** When you finish installing Grafana on your virtual machine, ensure you open the respective port on the Azure portal (3000) by creating an inbound port rule.
## Docker
For this session, we will use [How To Install and Use Docker on Ubuntu 18.04](https://www.digitalocean.com/community/tutorials/how-to-install-and-use-docker-on-ubuntu-18-04) tutorial, which is compatible with a Ubuntu 22.04 LTS Virtual Machine in Azure.

You can also install Docker in a Ubuntu 22.04 LTS virtual machine running on Virtualbox hypervisor.