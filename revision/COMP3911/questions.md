
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
## Outline
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
## Practice Qs
### Question 1: Threat Modelling Fundamentals
This question concerns the foundational steps of threat modelling and the STRIDE classification.

**(a)** You are tasked with performing a **threat modelling** exercise for a new online banking portal. The first step is **System Characterisation**. List **three** distinct types of information or models you would need to define or create to complete this step effectively.
**[3 marks]**

**(b)** For the same banking portal, an **asset** is identified as "Customer Payment Instruction Data". **Identify** two plausible **access points** through which an attacker might attempt to reach this asset.
**[4 marks]**

**(c)** The STRIDE model is used to classify threats. For each of the following banking portal incidents, **state** the single most applicable STRIDE threat category (Spoofing, Tampering, Repudiation, Information Disclosure, Denial of Service, Elevation of Privilege). Justify your choice in five words or fewer.
(i) An attacker uses a phishing site to steal user login credentials.
(ii) A flaw in the transaction API allows a user to mark any transaction as "failed", reversing the payment without logging the action.
(iii) An attacker floods the login page with random requests, preventing legitimate customers from accessing their accounts.
**[6 marks]**

**(d)** An **Advanced Persistent Threat (APT)** actor targets the bank. Describe **two** key characteristics, from the provided definition, that distinguish an APT from a typical **black hat** hacker. Your answer should not mention specific attack methods like malware.
**[4 marks]**

**(e)** From the **Threat Identification** step, the following threat profile is drafted:
**Threat:** Unauthorised funds transfer.
**Attack Goal:** Initiate a transfer from a victim's account to one controlled by the attacker.
**Adversary Type:** External attacker with no prior access.
Construct a simple **attack tree** for this threat. Your tree must have the **root node** ("Transfer funds unauthorised") and at least **two** distinct first-level child nodes, each representing a high-level method (e.g., "Compromise user credentials", "Exploit application flaw"). You do not need to develop sub-nodes.
**[8 marks]**

---
#### Model Solution
**(a)** _(1 mark per valid item)_
1. **Data Flow Diagrams (DFDs)** to show how data moves between system components.
2. **Usage Scenarios** to understand how legitimate users interact with the system.
3. **System Assumptions and Dependencies** (e.g., relies on specific third-party APIs, assumes internal network is secure).

**(b)** _(2 marks per valid access point)_
1. The public-facing **customer login webpage** (a network access point).
2. The backend **database API** used by the web server (a component interaction access point).

**(c)** _(2 marks per item: 1 for category, 1 for valid justification)_
(i) **Spoofing.** _Masquerade as legitimate site._
(ii) **Repudiation.** _User can deny transaction._
(iii) **Denial of Service.** _Prevents access to service._

**(d)** _(2 marks per characteristic)_
1. **Targeted and Prolonged:** APT campaigns are focused on a specific organisation and occur over a long duration (months/years), unlike broad, opportunistic attacks.
2. **High Capability/Resources:** APTs are typically **highly skilled** and backed by significant resources (e.g., **state actors**), enabling complex, multi-faceted attacks.

**(e)** _(2 marks for correct root, 3 marks per valid first-level child node)_
- **Root:** Transfer Funds Unauthorised
    - **Child 1:** Compromise User Credentials (e.g., via phishing, keylogger).
    - **Child 2:** Exploit Application Logic Flaw (e.g., bypass transaction validation).

---
### Question 2: STRIDE Analysis & Requirements
This question applies the STRIDE model to derive security requirements.

**(a)** A cloud file storage service allows users to upload, share, and collaborate on documents. For the data "in transit" between a user's device and the cloud server, **identify** the two STRIDE threat categories that most directly threaten the **confidentiality** and **integrity** of that data. For each, provide a **one-sentence** description of a specific attack that falls into that category.
**[6 marks]**

**(b)** The service's audit log, which records file access, is itself a critical **asset**. **State** which STRIDE threat category is most relevant if a user wishes to **repudiate** having accessed a file. Propose **one** security mechanism that would mitigate this specific threat.
**[4 marks]**

**(c)** Using Bellovin’s Threat Matrix (Attacker Capability vs. System Penetrability), **deduce** the likely scenario for a system rated as **High Penetrability** being attacked by an adversary with **Low Capability**. Explain what this implies for the system's **threat profile**.
**[5 marks]**

**(d)** For the cloud storage service, a threat is identified: "An attacker exhausts disk space with junk files, preventing legitimate storage."
(i) **Classify** this threat using the STRIDE model.
(ii) Following the template, specify a corresponding **security requirement**.
(iii) **Identify** one plausible **security mechanism** to meet this requirement.
**[6 marks]**

**(e)** During **Threat Identification**, designers must estimate "the strength of the attacker." **Explain** why this estimation is a critical input for both **prioritising** threats and making cost-effective decisions about **security mechanisms**.
**[4 marks]**

---
#### Model Solution
**(a)** _(3 marks per category: 1 for ID, 2 for attack description)_
- **Threat to Confidentiality: Information Disclosure.**
  _Attack:_ A **Man-in-the-Middle (MitM)** attacker intercepts and reads unencrypted file data during upload.
- **Threat to Integrity: Tampering.**
  _Attack:_ A MitM attacker alters the contents of a file while it is in transit to the server.

**(b)** _(2 marks for category, 2 for mechanism)_
- **STRIDE Category: Repudiation.**
- **Mitigation Mechanism:** Implement **cryptographically secure, append-only audit logs** where each entry is digitally signed or hashed with the previous entry, making log **tampering** detectable.

**(c)** _(5 marks for correct deduction and implication)_
- **Scenario:** A **"Script Kiddie"** (low capability) using widely available automated tools can successfully exploit the system (high penetrability).
- **Implication:** The system's **threat profile** must consider even low-skill, high-volume attacks as **high risk**. Threats from **low-capability** adversaries cannot be ignored and require immediate, robust preventative controls.

**(d)** _(2 marks per item)_
(i) **Denial of Service.**
(ii) **REQUIREMENT:** The service must implement quotas and monitoring to prevent any single user or process from exhausting shared storage resources.
(iii) **MECHANISM:** Implement **user storage quotas** and **automated monitoring/alerting** for rapid disk space consumption.

**(e)** _(4 marks for coherent explanation)_
Estimating attacker strength (**capability**) allows designers to **prioritise** defending against the most likely and dangerous adversaries (e.g., an APT vs. a script kiddie). This ensures limited security budgets are spent on **mechanisms** proportionate to the threat (e.g., not deploying expensive anti-APT controls if the primary threat is low-capacity). It directs resources cost-effectively to where they are most needed.

---
### Question 3: Attack Trees & System Analysis
This question involves constructing attack trees and analysing a system characterisation.

**(a)** During the **Asset and Access Point Identification** step for a smart home thermostat, the **asset** "User's weekly schedule and temperature preferences" is listed. **Identify** two **access points** an attacker might use to target this asset, considering both digital and physical vectors.
**[4 marks]**

**(b)** The primary threat to the thermostat is "Unauthorised Control of Heating System." Construct an **attack tree** for this threat. The root node is "Control Thermostat Unauthorised." You must include at least **three** distinct first-level child nodes, each representing a different high-level attack vector (e.g., "Compromise User Account", "Compromise Device Locally").
**[9 marks]**

**(c)** For the threat "Tampering with firmware update files," **map** this to the relevant STRIDE category. Then, **identify** which core **security property** (Confidentiality, Integrity, Availability) is primarily violated. Justify the property choice in one sentence.
**[4 marks]**

**(d)** A **threat profile** classifies the risk of "Spoofing of control signals from the mobile app" as **High**.
Translate this into a **security requirement**. Then, **propose** one specific **security mechanism** that would satisfy this requirement.
**[4 marks]**

**(e)** **Explain** why **threat modelling** is considered a cost-effective part of the **security engineering** process. Your answer must reference the idea of avoiding future, similar mistakes.
**[4 marks]**

---
#### Model Solution
**(a)** _(2 marks per access point)_
1. The thermostat's **Wi-Fi/Network interface** (digital).
2. The thermostat's **physical serial/USB debugging port** (physical).

**(b)** _(3 marks for correct root, 2 marks per valid first-level child node)_
- **Root:** Control Thermostat Unauthorised.
    - **Child 1:** Spoof/MitM Mobile App Communications.
    - **Child 2:** Exploit Vulnerability in Web/Cloud API.
    - **Child 3:** Physically Access and Tamper with Device.

**(c)** _(2 marks for STRIDE, 2 for property & justification)_
- **STRIDE Category: Tampering.**
- **Security Property: Integrity.**
  _Justification:_ Tampering with firmware corrupts the legitimate software, violating the **trustworthiness and correctness** of the system code.

**(d)** _(2 marks for requirement, 2 for mechanism)_
- **REQUIREMENT:** All control communications between the mobile app and the thermostat must be authenticated and integrity-protected.
- **MECHANISM:** Implement **mutual TLS (mTLS)** authentication for the app-to-cloud and cloud-to-thermostat connections.

**(e)** _(4 marks for explanation)_
**Threat modelling** is cost-effective because it identifies **threats** and **vulnerabilities** during the design phase, where fixes are cheapest. By understanding **attack trees** and **adversary capabilities** early, designers can build in appropriate **security mechanisms** from the start. This avoids the far greater cost of fixing **security problems** post-deployment or responding to **breaches** caused by threats that could have been foreseen and mitigated. It systematically learns from potential mistakes before they are made.
# 02. Threat Modelling pt. 2
## STRIDE Model Goals
##

## Outline

## Practice Qs
# 03. Managing Vulnerabilities
## Outline
- Exploits
    - Responsible Disclosure
- 0Day Attacks
- The Vulnerability Cycle
    - Discussion/Analysis
    - QA Techniques
        - The ‘Many Eyeballs’ Fallacy
        - Static Analysis Tools
        - Limitations of Static Analysis
            - Testing != Security Testing
    - Whittaker’s Fault Model
            - Diagram
        - Testing
        - Using Threat Models
        - ‘Secure From Day One’
    - Run-time Fault Injection
## Practice Qs
# 04. Security Policy Models
## Outline
- Security Policy
    - Policy Language
- Policy Models
        - Access Control
    - BELL-LaPADULA (BLP) Model
        - Property: SImple Security
        - Formal BLP
        - Lattices
        - Reference Monitor
    - BIBA Model
    - Chinese Wall Model
        - Property: SImple Security
        - Star property
    - Resurrecting Duckling Model
    - Other
## Practice Qs
# 05. Command Injection and Input Validation
## Outline
- Input Validation
    - Tust Boundaries and Choke Points
    - Phishing via Homograph Attacks
    - Malicious URLs e.g., Directory Traversal
## Practice Qs
# 06. Web App Vulnerabilities
## Outline
- Web Attacks
    - GET and POST Requests
    - Sessions
        - Session ID Dangers
- Attacking the Connection
    - HTTPS issues
        - DROWN (Decrypting RSA with Obsolete and Weakened eNcryption)
    - Lack of HSTS (HTTPS Strict Transport Security)
    - Miuse of TLS Certificates
    - Open Redirects
    - URL Jumping
    - Malicious XML Payloads
- Cross-site Scripting (XSS)
    - Reflected XSS
    - Stored XSS
    - HTML Injection
        - Frame attack
- Cross-site Request Frogery XSRF/CSRF
        - Example
        - To Avoid This
    - Validation: Client or Server?
        - When to validate?
        - Comparison with older OWASP Top 10s
## Practice Qs
# 07. User Authentication
## Outline
- Entropy
        - Example
    - Key Sweeper
    - Password Hashing
        - Hash Cracking Algorithm
    - Physical Tokens & 2FA
    - Biometrics
        - The Revocation Problem
## Practice Qs
# 08. DNS, ARP & Application Protocols
## Outline
- Address Resolution
    - DNS Resolvers
            - DNS Uncached Response
        - DNS Caching
            - DNS Cached Response
    - DNS Cache Poisoning (Spoofing)
        - Defence
    - DNS Hijacking
    - ARP
    - ARP Poisoning (Spoofing)
- Remote Access
    - Banner Grabbing Attack
    - Sniffing a telnet session
        - Fix: Secure SHell (SSH)
    - Fix: Secure SHell (SSH)
        - Man In The Middle Attacks
        - Sending emails: SMTP
        - Receiving emails
        - SSH mitigation
        - Better Approaches
    - STRIPTLS Attack
## Practice Qs
# 09. Execution Monitoring (EM)
## Outline
- OS-Based Software Security
        - Example
    - Which policies are enforceable?
- Characterising EM Mechanisms
    - Example 1: Mutual Exclusion of Semaphore Locks in Memory
        - Representing the states
    - Example 2: Simple Running Program
    - Defining Enforceable Policies
    - Takeaway
## Practice Qs
# 10. Example Safety
## Outline
## Practice Qs
# 11. Firewalls
## Outline
- Definition
    - Example
        - Challenges
- Model and Notation
    - Mail Server Firewall Example
            - Initial Rules
        - Problems
        - Fixed Rules
        - Model and Notation (continued)
- Firewall Decision Diagram (FDD)
    - Example
    - Results: Rules
        - Theorem of FDDs
- Reducing The Number of Rules
    - Isomorphic Nodes
        - Reduced FDD Definition
    - Algorithm 1: Reduced FDD
        - Steps (Repeat until satisfied)
    - Algorithm 2: FDD Marking (ordering)
        - What does this marked version look like?
        - Steps (Recursive)
    - Algorithm 2.5: Minimal Load Marked FDD
        - Steps (repeat)
    - Algorithm 3: Firewall Generation
        - Steps#
        - Example
        - Matching and Resolving Predicates
    - Algorithm 4: Firewall Compaction
    - Algorithm 5: Firewall Simplification
## Practice Qs