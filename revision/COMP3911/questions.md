
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
## Practice Qs
### Question 1 (25 marks)  
This question concerns foundational security concepts, assets, and threats.

**(a)** A new e-health application stores patient medical records and allows remote consultations between doctors and patients. For each of the following, **identify** the primary **security goal** (from Confidentiality, Integrity, Availability, Authenticity) that is most critically at risk. Justify your choice in one sentence per item.

(i) An attacker eavesdrops on a video consultation.  
(ii) A system fault corrupts a patient's prescription data in the database.  
(iii) A Distributed Denial of Service (DDoS) attack makes the appointment booking system unreachable for 48 hours.  
(iv) An impersonator gains access using a stolen doctor's login credentials.
**[4 marks]**

**(b)** Consider the **M.O.M. model** for an attacker. For the e-health application, provide a plausible example for each element of M.O.M. that would describe a **black hat** hacker targeting patient data.
**[6 marks]**

**(c)** Using the four-type model of **threats** (Interception, Interruption, Modification, Fabrication), classify the following security incidents related to the e-health system:  
(i) An attacker deletes a patient's allergy history from their record.  
(ii) A ransomware attack encrypts all patient records, making them inaccessible.  
(iii) An attacker inserts a false blood test result into a record.  
(iv) An unauthorised employee copies a database of patient addresses.
**[4 marks]**

**(d)** The developers initially assumed that only doctors would access patient records via a secure internal network. This **assumption** proved incorrect when nurses needed mobile access. Explain, using the concept of **vulnerabilities**, why this incorrect assumption created a security problem. In your answer, specify the **threat** and the resulting **problem**.
**[5 marks]**

**(e)** The system manager proposes two **controls**:
1. Implementing strict **access control** lists for all data.
2. Keeping an encrypted, off-site backup of all records.  
    For each control, **identify** its primary type from the following list: **Prevention, Detection, Deflection, Recovery**. Justify your choice in one sentence per control.
**[6 marks]**
---
#### Model Solution
**(a)** *(1 mark per correct identification + justification)*  
(i) **Confidentiality.** The attack involves the unauthorised _disclosure_ of private information (the consultation content).  
(ii) **Integrity.** The threat is the unauthorised _modification_ (corruption) of stored data, affecting its correctness and trustworthiness.  
(iii) **Availability.** The attack's goal is to _deny access_ to the system's service for legitimate users.  
(iv) **Authenticity.** The system fails to correctly _verify the identity_ of the user, allowing an impostor to be accepted as genuine.

**(b)** _(2 marks per plausible, coherent example)_
- **Method:** The attacker has skills in **SQL injection** and knows the application uses a common database framework with a known vulnerability.
- **Opportunity:** The application's patient portal has a public-facing login page that is accessible from the internet 24/7.
- **Motive:** The attacker's goal is **financial gain**, intending to sell the stolen patient data on the dark web or use it for insurance fraud.

**(c)** _(1 mark per correct classification)_  
(i) **Interruption** (of access to the correct/complete data) _or_ **Modification** (by deletion). _(Both are acceptable; Modification is more precise)_.  
(ii) **Interruption.** Access to the asset (the records) is completely blocked.  
(iii) **Fabrication.** A new, false data item is added to the system.  
(iv) **Interception.** The attacker gains unauthorised access to and copies the asset (the data).

**(d)** _(5 marks for a coherent explanation linking assumption, vulnerability, threat, and problem)_
- The incorrect **assumption** was a **vulnerability** in the system's design specifications. It led to the system being designed without secure mechanisms for **mobile access** (e.g., strong mobile authentication, encrypted channels).
- This created an opportunity for the **threat** of **interception** (unauthorised access to data via mobile devices).
- The resulting **problem** was that nurses' mobile devices could become weak points for attackers to exploit, risking a **breach of confidentiality**.

**(e)** _(3 marks per control: 1 for correct type, 2 for valid justification)_
1. **Type: Prevention.**  
    **Justification:** It aims to _remove the vulnerability_ of unauthorised access by proactively defining and enforcing who can access what data.
2. **Type: Recovery.**  
    **Justification:** It provides a mechanism to _restore the system_ to a functional state with valid data after an attack (like **interruption** from ransomware) has succeeded.
### Question 2 (25 marks)  
A university develops a new online exam proctoring system. The system streams video/audio from students' webcams, records their screen, and stores the final exam answers.

**(a)** For the proctoring system, identify **two** distinct **assets**. For each asset, state which of the four main **threat types** (Interception, Interruption, Modification, Fabrication) would be most severe if realised. Justify your choices concisely.
**[6 marks]**

**(b)** A **white hat** security consultant is hired to test the system. Using the **M.O.M. model**, describe what constitutes the consultant's **Method** and **Opportunity**. Explain how their **Motive** differs fundamentally from that of a **black hat** attacker.
**[6 marks]**

**(c)** The system logs all events (e.g., "student looked away", "copy-paste detected"). Explain which primary **security goal** (Confidentiality, Integrity, Availability, Authenticity) is most relevant for these **system logs** and why. Then, identify the most appropriate type of **control** (from Prevention, Deterrence, Deflection, Detection, Recovery) that should be applied to these logs and justify your choice.
**[6 marks]**

**(d)** The developers state: "Our system is secure because we use 256-bit encryption." Identify **two** distinct reasons from the list of "Why security is hard" that explain why this statement is likely an over-simplification or incorrect **assumption**. Provide a brief explanation for each.
**[7 marks]**

---
#### Model Solution
**(a)** _(3 marks per asset: 1 for asset, 1 for correct threat type, 1 for justification)_
1. **Asset:** The recorded video/audio stream of the student.
    - **Most Severe Threat Type: Interception.**
    - **Justification:** Unauthorised access (interception) of this asset would be a gross violation of **student privacy (confidentiality)**, potentially causing significant personal harm.
2. **Asset:** The stored final exam answers and grades.
    - **Most Severe Threat Type: Modification.**
    - **Justification:** Unauthorised alteration (modification) of this asset directly compromises **academic integrity**, making results untrustworthy and unfair.

**(b)** _(2 marks per M.O.M. element, focusing on the contrast in Motive)_
- **Method:** The consultant possesses skills in **penetration testing**, vulnerability scanning, and ethical hacking tools.
- **Opportunity:** The university provides **authorised access** to the system in a controlled testing environment for a defined period.
- **Motive Difference:** The white hat's motive is **ethical improvement** – to find and report vulnerabilities so they can be fixed. The black hat's motive is typically **malicious gain** (financial, reputational damage) or disruption.

**(c)** *(3 marks for security goal + justification, 3 marks for control + justification)*
- **Security Goal: Integrity.**
    - **Why:** The logs must be **tamper-proof** to provide a reliable, accurate, and non-repudiable audit trail for investigating incidents or disputes. If their **integrity** is compromised, they become worthless as evidence.
- **Control Type: Detection.**
    - **Justification:** Logs are a **detection** control. Their primary function is to _observe and record_ actions and potential policy violations (e.g., login attempts, flagged behaviours) for later analysis. They do not prevent the initial action but enable its discovery.

**(d)** _(~3.5 marks per reason with explanation)_
1. **Reason: Incorrect Assumptions.**
    - **Explanation:** The statement assumes that encryption alone is sufficient for security (**"secure because we use encryption"**). This ignores other critical vulnerabilities, such as weak authentication, software bugs, or **insider threats**, which encryption does not address.
2. **Reason: Security is not easily quantified.**
    - **Explanation:** Stating a cryptographic key length (256-bit) implies a quantifiable measure of security. However, overall system security is an **emergent property** of design, implementation, and operation. A single strong component does not guarantee a secure whole; the system may remain vulnerable in other, unmeasured ways.
### Question 3 (25 marks)
A national bank launches "SwiftSave," a mobile-only banking app. The app allows money transfers, bill payments, and real-time balance checking.

**(a)** For the SwiftSave app, **confidentiality** and **integrity** are paramount. Provide one specific, realistic example of a **vulnerability** that could lead to a breach of each.
(i) A vulnerability threatening **data confidentiality**.
(ii) A vulnerability threatening **data integrity**.
**[4 marks]**

**(b)** An attacker executes a sophisticated attack that results in small, random amounts (e.g., £0.01) being deducted from thousands of accounts and transferred to a mule account. Classify this attack using the four-type **threat** model. Then, analyse the attacker's likely **M.O.M.**, focusing on what unique **method** and **opportunity** this attack vector suggests.
**[8 marks]**

**(c)** The bank's Chief Security Officer (CSO) proposes the following **controls**:
A. Implementing biometric login (fingerprint/face ID) for all users.
B. Deploying AI to monitor transactions for anomalous patterns.
C. Creating a 24/7 incident response team to reverse fraudulent transactions.
For each control (A, B, C), **identify** its primary type from: **Prevention, Detection, Recovery**. Justify your choice in one sentence.
**[6 marks]**

**(d)** The SwiftSave development team followed all recommended coding practices. Despite this, a major security flaw was discovered post-launch. Using the concept of **emergent system properties**, explain how this could occur. Then, identify which other reason from "Why security is hard" best explains why such flaws are common, linking it to the **PEBKAC** principle.
**[7 marks]**
#### Model Solution
**(a)** _(2 marks per example)_
(i) **Vulnerability for Confidentiality:** The app transmits sensitive session tokens or account data without using **TLS encryption** (or uses a weak implementation), allowing interception.
(ii) **Vulnerability for Integrity:** The app's API endpoint for updating a payee's details lacks proper **input validation** and **authorisation checks**, allowing an authenticated user to manipulate another user's payment details.

**(b)** _(8 marks total: 2 for threat classification, 3 for Method analysis, 3 for Opportunity analysis)_
- **Threat Classification: Fabrication.** The attack fabricates unauthorised transaction records.
- **M.O.M. Analysis:**
    - **Method:** The attacker likely exploited a **logic flaw** or **arithmetic overflow** in the batch transaction processing system, rather than a simple buffer overflow. This requires deep understanding of the app's financial **protocols** and backend systems.
    - **Opportunity:** The attack required the **opportunity** to submit or influence a _batch processing job_. This suggests either a compromised insider account with elevated privileges, or a vulnerability in a scheduled, automated transaction system that processes low-value transactions with less scrutiny.


**(c)** _(2 marks per control: 1 for type, 1 for justification)_
A. **Type: Prevention.** It aims to _stop_ unauthorised access by verifying identity with a unique physiological factor before any transaction can be initiated.
B. **Type: Detection.** It _observes_ ongoing activity to _identify_ suspicious patterns that may indicate a breach or fraud that has already bypassed preventive controls.
C. **Type: Recovery.** It provides a mechanism to _restore_ assets (funds) to their rightful owners _after_ a fraudulent transaction (**fabrication**) has been detected and confirmed.

**(d)** _(4 marks for emergent properties explanation, 3 marks for PEBKAC link)_
- **Emergent Properties:** The flaw is an **emergent system property**. While individual components (e.g., encryption module, UI code) were securely built, the _unpredictable interaction_ between these components, the mobile OS, the banking backend, and user behaviour created a new, unforeseen vulnerability. Security is a property of the _whole system in operation_, not just the sum of its securely built parts.
- **Link to PEBKAC:** The core reason is **"Humans make mistakes" (PEBKAC)**. While developers may follow practices, they are human and can make errors in design logic, configuration, or in understanding complex component interactions. Furthermore, _users_ (**"Between Keyboard and Chair"**) can behave in unexpected ways that expose emergent flaws. Rigorous design does not eliminate human error from the development _or_ usage lifecycle.
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