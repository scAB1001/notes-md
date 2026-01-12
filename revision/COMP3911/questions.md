
# 00. Intro
## Outline
- Security Goals & Properties
- Attackers follow the M.O.M. acronym
	- Assets and Adversaries
	- Vulnerabilities
	- Threats
	- Problem
- Threats and Controls
- Why is security hard
- Hackers
## Q
# 01. Threat Modelling pt. 1
   - Intro
	- Advanced Persistent Threats
    - Security Engineering
- Main steps for threat Modelling
    - 1. System Characterisation
    - 2. Asset and Access Point Identification
    - 3. Threat Identification
        - Threat Enumeration
        - Attack Trees
- The STRIDE Threat Model Classification
    - 1. Spoofing - masquerade e.g., unauthorised access.
    - 2. Tampering - violates data integrity.
    - 3. Repudiation - Deny performing action.
    - 4. Info disclosure - violate confidentiality.
    - 5. Denial of Service
    - 6. Elevation of privilege - Gaining special status.
    - STRIDE Per Element
- Specifying Security Requirements


# 1. System Characterisation
### 2. Asset and Access Point Identification
### 3. Threat Identification
#### Threat Enumeration
#### Attack Trees
## The STRIDE Threat Model Classification
##
# 1. Spoofing - masquerade e.g., unauthorised access.
### 2. Tampering - violates data integrity.
### 3. Repudiation - Deny performing action.
### 4. Info disclosure - violate confidentiality.
### 5. Denial of Service
### 6. Elevation of privilege - Gaining special status.
### STRIDE Per Element
## Specifying Security Requirements

# 02. Threat Modelling pt. 2
## STRIDE Model Goals
##
# 1. Assets
### 2. Attackers
### 3. Software
## Trust Boundaries
### Entry & Exit Points
### Importance
## Attack Trees
##### Attack Tree Example ->
### ### Risk Assessment: DREAD
#### Issues With DREAD as a scoring system
### Common Vulnerability Scoring System (CVSS)
### Mitigation

# 03. Managing Vulnerabilities
## Exploits
### Responsible Disclosure
##
# 0Day Attacks
## The Vulnerability Cycle
### Discussion/Analysis
### QA Techniques
#### The ‘Many Eyeballs’ Fallacy
#### Static Analysis Tools
#### Limitations of Static Analysis
##### Testing != Security Testing
### Whittaker’s Fault Model
##### Diagram
#### Testing
#### Using Threat Models
#### ‘Secure From Day One’
### Run-time Fault Injection

# 04. Security Policy Models
#### Example
## Security Policy
### Policy Language
## Policy Models
#### Access Control
### BELL-LaPADULA (BLP) Model
#### Property: SImple Security
#### Formal BLP
#### Lattices
#### Reference Monitor
### BIBA Model
### Chinese Wall Model
#### Property: SImple Security
#### Star property
### Resurrecting Duckling Model
### Other

# 05. Command Injection and Input Validation
## Input Validation
### Tust Boundaries and Choke Points
### Phishing via Homograph Attacks
### Malicious URLs e.g., Directory Traversal

# 06. Web App Vulnerabilities
## Web Attacks
### GET and POST Requests
### Sessions
#### ### Session ID Dangers
## Attacking the Connection
### HTTPS issues
#### DROWN (Decrypting RSA with Obsolete and Weakened eNcryption)
### Lack of HSTS (HTTPS Strict Transport Security)
### Miuse of TLS Certificates
### Open Redirects
### URL Jumping
### Malicious XML Payloads
## Cross-site Scripting (XSS)
### Reflected XSS
### Stored XSS
### HTML Injection
#### Frame attack
## Cross-site Request Frogery XSRF/CSRF
#### Example
#### To Avoid This
### Validation: Client or Server?
#### When to validate?
#### Comparison with older OWASP Top 10s

# 07. User Authentication
## Entropy
#### Example
### Key Sweeper
### Password Hashing
#### Hash Cracking Algorithm
# Loop through file data
	# Generate combinations of the current word
		# Create a hash for each word using the combination and salt
			# If the hashes are the same, that word is the password.
				return word  # the password
### Physical Tokens & 2FA
### Biometrics
#### The Revocation Problem

# 08. DNS, ARP & Application Protocols
## Address Resolution
### DNS Resolvers
##### DNS Uncached Response
#### DNS Caching
##### DNS Cached Response
### DNS Cache Poisoning (Spoofing)
#### Defence
### DNS Hijacking
### ARP
### ARP Poisoning (Spoofing)
## Remote Access
### Banner Grabbing Attack
### Sniffing a telnet session
# Output
#### Fix: Secure SHell (SSH)
### Fix: Secure SHell (SSH)
#### Man In The Middle Attacks
#### Sending emails: SMTP
#### Receiving emails
#### SSH mitigation
##### `ssh -f -N -L 5678:localhost:110 mailhost`
#### Better Approaches
### STRIPTLS Attack

# 09. Execution Monitoring (EM)
## OS-Based Software Security
#### Example
### Which policies are enforceable?
## Characterising EM Mechanisms
### Example 1: Mutual Exclusion of Semaphore Locks in Memory
#### Representing the states
### Example 2: Simple Running Program
### Defining Enforceable Policies
### Takeaway

# 10. Example Safety

# 11. Firewalls
## Definition
### Example
| Rule # |     Source     |   Destination   | Protocol | Port |     Action     |
#### Challenges
## Model and Notation
### Mail Server Firewall Example
##### Initial Rules
#### Problems
#### Fixed Rules
#### Model and Notation (continued)
## Firewall Decision Diagram (FDD)
### Example
### Results: Rules
#### Theorem of FDDs
## Reducing The Number of Rules
### Isomorphic Nodes
#### Reduced FDD Definition
### Algorithm 1: Reduced FDD
#### Steps (Repeat until satisfied)
### Algorithm 2: FDD Marking (ordering)
#### What does this marked version look like?
#### Steps (Recursive)
### Algorithm 2.5: Minimal Load Marked FDD
#### Steps (repeat)
### Algorithm 3: Firewall Generation
#### Steps#
#### Example
#### Matching and Resolving Predicates
### Algorithm 4: Firewall Compaction
### Algorithm 5: Firewall Simplification