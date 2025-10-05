### Overview
You have two storage drives:
- **SATA SSD (69GB)**: `/` - Operating system and installed programs
- **NVMe SSD (469GB)**: `/mnt/fast-data` - Fast storage for projects and data

| Purpose             | Location                          |
| ------------------- | --------------------------------- |
| New GitHub projects | `/mnt/fast-data/github-projects/` |
| Workspace & builds  | `/mnt/fast-data/code/`            |
| Large data archives | `/mnt/fast-data/documents/`       |
| System files        | `~/` (home)                       |
### Running Programs from Different Locations

#### Python Projects
```bash
# Run Python script from NVMe
cd ~/github-projects/my-python-app
python3 main.py

# Create virtual environment on NVMe
python3 -m venv /mnt/fast-data/venvs/myapp
source /mnt/fast-data/venvs/myapp/bin/activate
pip install -r requirements.txt
```
#### Rust Projects
```bash
# Create new Rust project on NVMe
cd ~/github-projects
cargo new my-rust-app
cd my-rust-app
cargo run

# Build release on NVMe
cargo build --release
# Binary created in ~/github-projects/my-rust-app/target/release/
```
#### C/C++ Projects
```bash
# Clone and build on NVMe
cd ~/github-projects
git clone https://github.com/user/c-project.git
cd c-project
mkdir build && cd build
cmake ..
make -j4
./my-program
```
#### Node.js Projects
```bash
# Node project on NVMe
cd ~/github-projects/my-node-app
npm install
npm start

# Or use nvm (stays on system drive)
nvm use node
node app.js
```
### Docker on NVMe Storage
**Move Docker Data to NVMe**
```bash
# Stop Docker
sudo systemctl stop docker

# Move Docker directory to NVMe
sudo mv /var/lib/docker /mnt/fast-data/

# Create symlink
sudo ln -s /mnt/fast-data/docker /var/lib/docker

# Start Docker
sudo systemctl start docker

# Verify
docker system df
```
**Use Docker with Projects on NVMe**
```bash
# Docker compose from NVMe project
cd ~/github-projects/my-docker-app
docker-compose up -d

# Build image from NVMe project
docker build -t my-app .

# Run container with NVMe volume mount
docker run -v /mnt/fast-data/workspace/data:/app/data my-app
```
### Data Locations
#### Browser and installs
1. **Firefox**: 
   - Settings → General → Files and Applications
   - Change "Save files to" to `/mnt/fast-data/Downloads`
```bash
# Set global git config to clone to NVMe by default
git config --global init.defaultBranch main

# Go-to NVMe and clone there explicitly
cd /mnt/fast-data/github-projects
git clone https://github.com/user/repo.git

# Or clone anywhere and move after
mv repo ~/github-projects/
```
**Wget/cURL to NVMe**
```bash
# Download directly to NVMe
wget -P /mnt/fast-data/Downloads https://example.com/large-file.zip

# Or use the workspace
cd ~/workspace
wget https://example.com/large-file.tar.gz
```
#### Moving Existing Data to NVMe
**Move Large Directories**
```bash
# Move and create symlink (for configs you want to keep on system)
mv ~/LargeProject /mnt/fast-data/
ln -s /mnt/fast-data/LargeProject ~/LargeProject

# Or just move (for data only)
mv ~/Videos /mnt/fast-data/
# Access at /mnt/fast-data/Videos
```
**Archive Old Projects**
```bash
# Compress and move to archives
tar -czf old-project-$(date +%Y%m%d).tar.gz ~/old-project
mv old-project-*.tar.gz /mnt/fast-data/archives/
rm -rf ~/old-project
```
### Monitoring Storage Usage
**Check Space Anytime**
```bash
# Quick check
df -h

# Detailed analysis
ncdu /mnt/fast-data  # for NVMe
ncdu ~              # for system drive

# GUI analysis
baobab

# Go to NVMe storage
cd /mnt/fast-data

# Go to NVMe projects (via symlink)
cd ~/github-projects

# Go to system home
cd ~

# Check which drive you're on
df -h .
```
**Find Large Files**
```bash
# Find files >100MB on NVMe
find /mnt/fast-data -type f -size +100M -exec ls -lh {} \; 2>/dev/null

# Find files >50MB in home
find ~ -type f -size +50M -exec ls -lh {} \; 2>/dev/null
```
### Best Practices
**Do Store on NVMe:**
- GitHub repositories and source code
- Docker images and containers
- Large datasets
- Build outputs and binaries
- Virtual environments
- Downloads and archives

**Keep on System Drive:**
- System programs (Python, Rust, Node.js themselves)
- Configuration files (`~/.config/`, `~/.bashrc`)
- System libraries and dependencies
- Small projects and scripts

**Performance Tips:**
- Use NVMe for compilation (faster builds)
- Keep active projects in `~/github-projects/` (symlink to NVMe)
- Use system drive for OS and installed programs
- Monitor space with `df -h` regularly
### Emergency Commands
**If NVMe Doesn't Mount:**
```bash
sudo mount -a
sudo systemctl daemon-reload
```
**Check Drive Health:**
```bash
# SATA SSD
sudo smartctl -a /dev/sda

# NVMe SSD  
sudo nvme smart-log /dev/nvme0
```
**Backup Important Data:**
```bash
# Backup critical files from system drive
tar -czf system-backup-$(date +%Y%m%d).tar.gz ~/Documents ~/Code
mv system-backup-*.tar.gz /mnt/fast-data/archives/
```
