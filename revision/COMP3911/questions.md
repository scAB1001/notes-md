
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
## Outline
- STRIDE Model Goals
    - 1. Assets
    - 2. Attackers
    - 3. Software
- Trust Boundaries
    - Entry & Exit Points
    - Importance
- Attack Trees
    - Risk Assessment: DREAD
        - Issues With DREAD as a scoring system
    - Common Vulnerability Scoring System (CVSS)
    - Mitigation
## Practice Qs
### Question 1: Trust Boundaries & Attack Surface
This question concerns the identification of trust boundaries and attack surfaces within a system diagram.

**(a)** A web application is structured as follows: An **Internet User** (untrusted) connects to a **Public Web Server**. This server queries a backend **Database Server** located on a separate, protected network segment. The database server only accepts connections from the web server's IP address.
(i) **Identify** the **principals** in this system.
(ii) **Draw** the implied **trust boundaries**. You may describe them textually (e.g., "TB1: Internet", "TB2: Web Server Zone", "TB3: Database Zone").
**[5 marks]**

**(b)** For the system in part (a), **identify** two distinct **entry points** where data or control crosses a **trust boundary**. For each, state which boundary is crossed.
**[4 marks]**

**(c)** **Explain** why a **software-focused** approach (using system diagrams and STRIDE) is generally considered more effective for threat modelling than an **attacker-focused** approach. Limit your answer to two key reasons.
**[4 marks]**

**(d)** The threat "SQL Injection leading to data theft" is identified for the web application. This threat exploits an entry point where user input crosses a trust boundary.
(i) **State** the most relevant STRIDE category for this threat.
(ii) **Identify** the **asset** type (tangible or intangible) that is primarily at risk.
(iii) Propose **one** design or implementation **mitigation** that directly addresses this threat at the identified entry point.
**[6 marks]**

**(e)** An **attack tree** is created for the threat "Compromise Database Server." The root node has three child nodes with an OR relationship: A. "Exploit Web Server to gain foothold," B. "Direct Network Attack on DB port," C. "Physical Access to DB Server."
Given the system description in part (a), which child node (**A, B, or C**) represents the attack path with the *highest* **Exploitability** score in a **DREAD** assessment for an external attacker? Justify your choice in one sentence.
**[6 marks]**

---
#### Model Solution
**(a)** _(3 marks for principals, 2 for boundaries)_
(i) **Principals:** Internet User, Public Web Server, Database Server.
(ii) **Trust Boundaries:** TB1 (Internet/User), TB2 (Web Server & its network), TB3 (Database Server & its protected segment).

**(b)** _(2 marks per entry point with boundary)_
1. **Entry Point:** The HTTP request from the Internet User to the Public Web Server. _Crosses TB1 → TB2._
2. **Entry Point:** The SQL query from the Web Server to the Database Server. _Crosses TB2 → TB3._

**(c)** _(2 marks per reason)_
1. It is **structured** and systematic (using diagrams), reducing reliance on subjective, biased lists of attacker profiles.
2. It directly maps **threats** (via STRIDE) to **software components** and **data flows**, making it easier to derive specific **security requirements** and **mitigations**.

**(d)** _(2 marks per item)_
(i) **Information Disclosure.**
(ii) **Tangible Asset** (the confidential data stored in the database).
(iii) **Mitigation:** Implement **parameterised queries** (prepared statements) in the web server code to separate user input from SQL commands.

**(e)** _(2 marks for correct node, 4 for justification)_
- **Node A: "Exploit Web Server to gain foothold."**
- **Justification:** The web server is the only component with a direct **entry point** from the untrusted Internet (TB1), making it the most exposed and likely initial target for an external attacker, hence highest **Exploitability**.

---
### Question 2: Attack Trees & Risk Prioritisation
This question involves constructing and analysing attack trees using Boolean logic and simple risk assessment.

**(a)** Consider the attack tree fragment below for the threat "Steal Physical Access Card".
```
Root: Steal Card
├─ 1. Take from Owner
│  ├─ 1.1 Distract Owner (AND)
│  └─ 1.2 Remove from Bag
└─ 2. Take from Storage
   ├─ 2.1 Pick Lock
   └─ 2.2 Copy Master Key
```
(i) How many distinct **attack paths** exist to achieve the root threat?
(ii) **Justify** your answer by explaining the Boolean relationships shown.
**[5 marks]**

**(b)** Using the **DREAD** model, a threat is scored: Damage=3, Reproducibility=2, Exploitability=3, Affected Users=1, Discoverability=3.
(i) Calculate the **risk rating** *R* (using a simple average).
(ii) **State** which DREAD dimension is often criticised as being unhelpfully subjective or assumed to be maximal, and explain why.
**[5 marks]**

**(c)** **Compare** the **DREAD** and **CVSS** scoring systems. **State** one key advantage CVSS has over DREAD in terms of objectivity or granularity.
**[3 marks]**

**(d)** The following conditions are nodes in an attack tree for "Unauthorised Admin Access":
1. Bribe existing admin.
2. Crack weak admin password.
3. Exploit zero-day in admin panel.
A risk assessment must **prioritise** mitigation. **Order** these three conditions (1, 2, 3) from *highest* to *lowest* **Exploitability** for a typical external attacker. Justify your ordering in one sentence per condition.
**[6 marks]**

**(e)** Referring to the attack tree diagram and mitigation principle in the content (with nodes 1.1, 1.2, 1.3), **explain** the logic behind the claim that mitigating condition **1.1** first is the most effective way to reduce the number of **attack paths**. Your answer should reference the Boolean **AND** relationship.
**[6 marks]**

---
#### Model Solution
**(a)** _(3 marks for count, 2 for justification)_
(i) **3 attack paths.**
(ii) **Justification:** Path 1 requires **1.1 AND 1.2** (one path). Path 2 has options 2.1 **OR** 2.2 (two paths). Total = 1 + 2 = 3 paths.

**(b)** _(3 marks for calculation, 2 for critique)_
(i) $R = (3+2+3+1+3)/5 = 12/5 = 2.4$
(ii) **Discoverability.** It is criticised because it is highly subjective and the prudent assumption for risk assessment is that a vulnerability, if it exists, *will* eventually be discovered (i.e., treat it as 100% or max score).

**(c)** _(3 marks for valid advantage)_
**CVSS** provides a more **objective** and **granular** scoring system with defined metrics and formulae, reducing reliance on subjective opinion compared to **DREAD**.

**(d)** _(2 marks per ordered item with justification)_
1. **2. Crack weak admin password.** _Highest exploitability; can be automated with low skill._
2. **3. Exploit zero-day in admin panel.** _Moderate exploitability; requires skill/knowledge of the specific flaw._
3. **1. Bribe existing admin.** _Lowest exploitability for external attacker; requires insider threat, not a technical exploit._

**(e)** _(6 marks for coherent explanation)_
Node 1.1 is part of an **AND** condition with node 1.2. Mitigating 1.1 makes the entire **AND** branch (1.1 & 1.2) impossible, regardless of the state of sub-nodes 1.2.1 or 1.2.2. This eliminates *two* attack paths at once (1.1+1.2.1 and 1.1+1.2.2). Mitigating a node in an **OR** branch (like 1.3.1) only eliminates one specific path, leaving the alternative (1.3.2) viable. Therefore, targeting the mandatory condition in an **AND** relationship provides the greatest reduction in total **attack paths**.

---
### Question 3: STRIDE Perspectives & Mitigation
This question evaluates different perspectives in threat modelling and the application of mitigation strategies.

**(a)** When considering **threats** from an **assets** perspective, both tangible and intangible assets are considered.
(i) For an online auction website, give **one example** of a **tangible asset** and one of an **intangible asset**.
(ii) For the intangible asset example, **identify** a STRIDE threat category that could specifically harm it.
**[5 marks]**

**(b)** A **trust boundary** exists between a mobile banking app (running on a user's phone) and the bank's cloud API.
(i) **Identify** the **principals** on either side of this boundary.
(ii) **State** one **entry point** at this boundary.
(iii) For that entry point, name **one** STRIDE threat that is particularly relevant.
**[6 marks]**

**(c)** A principle of **mitigation** states: "every security feature should address at least one threat from the threat model." **Explain** why following this principle is important for avoiding security **anti-patterns**, such as adding unnecessary complexity without improving security.
**[4 marks]**

**(d)** An **attack tree** for "Execute Arbitrary Code on Server" has a root with two main branches: A. "Remote Exploit" (OR: A.1 "Buffer Overflow", A.2 "SQL Injection to RCE") and B. "Local Privilege Escalation" (requires B.1 "Gain User Shell" AND B.2 "Exploit Kernel Flaw").
**Calculate** the total number of **attack paths** in this tree. Show your working.
**[5 marks]**

**(e)** You must choose to mitigate **one** of the following conditions from the tree in part (d): A.1, A.2, or B.1.
Based **only** on the goal of reducing the total number of possible **attack paths**, **state** which condition you would mitigate and **justify** your answer with reference to the Boolean structure of the tree.
**[5 marks]**

---
#### Model Solution
**(a)** _(3 marks for examples, 2 for STRIDE category)_
(i) **Tangible Asset:** User payment information (credit card details). **Intangible Asset:** The website's **reputation** for fairness and security.
(ii) **STRIDE Threat to Reputation:** **Denial of Service** (making site unavailable damages trust) or **Information Disclosure** (a data breach destroys reputation).

**(b)** _(2 marks per item)_
(i) **Principals:** Mobile App (User Device), Bank Cloud API.
(ii) **Entry Point:** The HTTPS request/response channel for the login API.
(iii) **Relevant STRIDE Threat:** **Spoofing** (of the app by a fake API or of the API by a fake app/MitM).

**(c)** _(4 marks for explanation)_
This principle ensures **security mechanisms** are traceable to specific, identified **threats**. It prevents "security theatre" – adding features (like complex logging that isn't monitored) that don't mitigate actual risks. It forces justification, ensuring each control reduces the **attack surface** or mitigates a documented **vulnerability**, thereby avoiding wasted effort and **complexity** that does not improve security.

**(d)** _(5 marks for correct calculation with working)_
- Branch A (OR): 2 paths (A.1, A.2).
- Branch B (AND): 1 path (B.1 & B.2).
- Total Attack Paths = 2 + 1 = **3 paths**.

**(e)** _(2 marks for choice, 3 for justification)_
- **Mitigate Condition B.1 ("Gain User Shell").**
- **Justification:** B.1 is part of an **AND** condition in branch B. Mitigating it eliminates the *entire* branch B (1 path). Mitigating A.1 or A.2 (in an **OR** branch) would only eliminate 1 of the 2 paths in branch A, leaving the other path open. Eliminating a *necessary* condition in an **AND** branch removes more attack paths overall.
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
### Question 1: Vulnerability Lifecycle & Disclosures
This question covers the vulnerability lifecycle, responsible disclosure, and scoring systems.

**(a)** A security researcher discovers a critical buffer overflow in a widely used web server software. They email full exploit details to the vendor but also immediately publish a blog post with proof-of-concept code.
(i) **State** whether this action constitutes **responsible disclosure**.
(ii) **Justify** your answer by explaining the key principle of responsible disclosure that was violated.
**[4 marks]**

**(b)** Referring to the **Vulnerability Cycle** diagram:
(i) **Identify** the stage at which a **CVE** identifier would most likely be assigned.
(ii) **Explain** the purpose of the **CWE** classification system and how it differs from the purpose of CVE.
**[6 marks]**

**(c)** An exploit is being actively used in attacks, but the software vendor is unaware of the underlying vulnerability. **State** the specific term for this type of exploit. **Explain** why this situation represents the highest level of threat to organisations using the software.
**[5 marks]**

**(d)** **Compare** the **CVSS** and **CWSS** scoring systems. **State** one key difference in their primary focus or use case.
**[3 marks]**

**(e)** A company runs a **Bug Bounty Program**. **Explain** two distinct incentives this provides to security researchers compared to a scenario with no formal programme.
**[7 marks]**

---
#### Model Solution
**(a)** _(2 marks per part)_
(i) **No.**
(ii) The researcher violated the principle of allowing the vendor a **silence period** to develop and distribute a patch before public **disclosure**, which maximises risk to users.

**(b)** _(3 marks per part)_
(i) Stage 1: "Vulnerability discovered and disclosed" (or early in Stage 4 during diagnosis).
(ii) **CWE** classifies vulnerability *types* (e.g., CWE-120: Buffer Overflow) for awareness and prevention. **CVE** uniquely identifies a specific *instance* of a vulnerability in a product (e.g., CVE-2024-12345 in Product X v1.2).

**(c)** _(2 marks for term, 3 for explanation)_
- **Term: 0day (Zero-day) attack.**
- **Explanation:** It is the highest threat because no patch or mitigation exists, and defenders have **zero days** of advance warning. Attackers have a window of uncontested access until the vendor independently discovers the flaw or the exploit is reverse-engineered.

**(d)** _(3 marks for valid difference)_
**CVSS** scores the severity of a specific **vulnerability instance** (CVE). **CWSS** scores the severity of a **weakness type** (CWE) in a broader context, potentially considering factors like business impact.

**(e)** _(3.5 marks per incentive)_
1. **Financial Reward:** Provides a direct, legal **incentive** (bounty) for researchers to report findings, channelling their effort towards **responsible disclosure** rather than criminal exploitation or silence.
2. **Structured Recognition & Trust:** Offers a clear, safe, and legal channel for engagement, granting researchers **acknowledgement** (e.g., hall of fame) and building a trusted relationship with the company's security team.

---
### Question 2: QA Techniques & Static Analysis
This question focuses on quality assurance techniques for finding vulnerabilities and their limitations.

**(a)** A development team implements **peer code review** for security.
(i) **Identify** one psychological effect that can improve code quality during such reviews.
(ii) **State** one major limitation of relying solely on the **"Many Eyeballs"** fallacy for finding security bugs in open-source software.
**[5 marks]**

**(b)** **Static analysis tools** are used to scan source code.
(i) **Describe** the key difference between *pattern-matching* tools (e.g., Flawfinder) and *data flow analysis* tools (e.g., Splint).
(ii) **State** one inherent **limitation** common to all static analysis tools regarding the detection of vulnerabilities.
**[6 marks]**

**(c)** The **CWE** list includes **CWE-120** ("Buffer copy without checking size of input"). A static analysis tool reports a potential instance of this in a codebase.
(i) **Classify** this finding using the standard categories for analysis tool errors.
(ii) **Explain** the risk of **"flaw fatigue"** in this context and how it can undermine security.
**[6 marks]**

**(d)** **Explain** why thorough functional **Testing** is not equivalent to **Security Testing**. Refer to the provided diagram's concept of overlapping but distinct problem sets.
**[4 marks]**

**(e)** A tool like **Holodeck** is used for **run-time fault injection**.
(i) **State** the primary goal of this technique.
(ii) Provide **two** examples of faults it might simulate to stress-test an application.
**[4 marks]**

---
#### Model Solution
**(a)** _(3 marks for i, 2 for ii)_
(i) The **Hawthorne Effect** – developers write more carefully knowing their work will be reviewed.
(ii) It assumes all reviewers have the **"right kind of eyeballs"** – i.e., the specific security expertise needed to recognise subtle **vulnerabilities**, which is often not the case.

**(b)** _(3 marks per part)_
(i) **Pattern-matching** tools search for known dangerous code patterns (strings, functions). **Data flow analysis** tools parse code, track variable values, and identify paths where untrusted input could reach a vulnerable function.
(ii) They cannot detect vulnerabilities that depend on **run-time state** or complex external interactions (false negatives) and often produce **false positives**.

**(c)** _(3 marks per part)_
(i) It is a potential **true positive** (a real flaw) or a **false positive** (benign code flagged incorrectly).
(ii) **Flaw fatigue** occurs when tools generate many **false positives**. Developers start to ignore all warnings, causing real **vulnerabilities** (true positives) to be overlooked, thus negating the tool's security benefit.

**(d)** _(4 marks for explanation)_
**Testing** aims to find bugs where the software doesn't do what it *should* do. **Security Testing** aims to find **vulnerabilities** where the software does what it *should not* do (allowing unauthorised actions). The diagram shows these as overlapping but distinct sets; passing functional tests does not guarantee absence of security flaws.

**(e)** _(2 marks for goal, 1 mark per example)_
(i) To **stress-test** the system's resilience and error handling by forcing it into unexpected, erroneous states.
(ii) Simulating **insufficient memory (out-of-memory errors)** or **network disconnection** during a critical transaction.

---
### Question 3: Secure Development & Fault Models
This question integrates threat modelling into the development lifecycle and applies fault models.

**(a)** The principle **"Secure From Day One"** advocates integrating security early.
(i) **State** at which project stage the **threat model** should first be created.
(ii) **List** two standard security design principles that should drive the design process according to this approach.
**[5 marks]**

**(b)** **Whittaker's Fault Model** categorises attack targets.
For each of the following test activities, **identify** the fault model category it belongs to (Attack Environmental Dependencies, Attack User Interfaces, Attack the Design, Attack the Implementation):
(i) Feeding a 10MB string into a username field.
(ii) Deleting a required configuration file at runtime.
(iii) Using a debugger to call an internal admin function bypassing the UI.
**[6 marks]**

**(c)** A **threat model** is used to drive security testing.
(i) **State** which aspect of the threat model (e.g., from STRIDE) informs *what* types of tests to perform.
(ii) **State** which aspect (e.g., from DREAD) can be used to *prioritise* the order of test execution.
**[4 marks]**

**(d)** Consider a threat modelled as **Spoofing** of a client application, with a **DREAD** score indicating high risk.
Outline a **test plan** to validate the system's resistance to this threat. Your plan should include two specific test actions.
**[6 marks]**

**(e)** **Run-time fault injection** tools like Holodeck simulate environmental failures. **Explain** why this technique is particularly valuable for testing the **reliability** of a system's **security controls** (e.g., access control logic). Use an example in your explanation.
**[4 marks]**

---
#### Model Solution
**(a)** _(2 marks for i, 3 for ii - 1.5 per principle)_
(i) During the initial **planning** stage.
(ii) **Minimal privilege** (granting only necessary access) and **reluctance to trust** (validating all inputs, not trusting external entities).

**(b)** _(2 marks per correct classification)_
(i) **Attack User Interfaces.** (Input overrun).
(ii) **Attack Environmental Dependencies.** (Missing config file).
(iii) **Attack the Implementation.** (Exploiting test/internal APIs).

**(c)** _(2 marks per part)_
(i) The **STRIDE** classification informs the *type* of test (e.g., a **Tampering** threat requires integrity validation tests).
(ii) The **DREAD** risk rating (or **CVSS** score) informs the *priority* of testing.

**(d)** _(3 marks per test action)_
**Test Plan for Spoofing:**
1. **Action:** Intercept and modify network packets to change the client identity field using a tool like Wireshark/Proxy.
2. **Action:** Create a custom, malicious client that mimics the legitimate app's protocol but uses forged credentials.

**(e)** _(4 marks for explanation with example)_
It tests if **security controls** fail gracefully or catastrophically under stress. For example, if **access control** logic crashes or fails open when a simulated **disk full** error occurs during a log write, an attacker could trigger this state to bypass authentication. **Fault injection** uncovers such **implementation** flaws in error handling that pure functional testing misses.
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
### Question 1: Policy, Mechanism, & Middleware
This question tests understanding of the core concepts of security policies and their implementation.

**(a)** For a system designed to prevent data exfiltration via USB drives, define the **Policy**, **Mechanism**, and **Middleware** components in this context.
(i) **Policy:** A one-sentence high-level goal.
(ii) **Mechanism:** The specific technical control.
(iii) **Middleware:** The software component that enforces the mechanism.
**[6 marks]**

**(b)** **Compare** **high-level** and **low-level** policy languages. **State** one key characteristic of each and explain which is more suitable for expressing a rule like "patients can only read their own medical records."
**[6 marks]**

**(c)** A **security model** is described as a "guide" when defining policies.
(i) **Explain** why using an existing model (like BLP) is preferable to designing a policy from scratch.
(ii) **State** the primary risk of choosing an *incorrect* model for a given security goal (e.g., using a confidentiality model for an integrity problem).
**[5 marks]**

**(d)** Consider a simple policy: "A user can delete a file only if they are the owner."
**Identify** whether this policy is more likely to be enforced via **Mandatory Access Control (MAC)** or **Discretionary Access Control (DAC)**. Justify your choice in one sentence.
**[4 marks]**

**(e)** The **Resurrecting Duckling Model** describes a transient security policy.
(i) **Name** the two key states in this model.
(ii) Describe the event that causes the transition from the **imprinted** state back to the **imprintable** state.
**[4 marks]**

---
#### Model Solution
**(a)** _(2 marks per component)_
(i) **Policy:** Prevent unauthorised copying of data to removable media.
(ii) **Mechanism:** Disable USB mass storage driver at the OS kernel level.
(iii) **Middleware:** A Group Policy Object (GPO) or mobile device management (MDM) agent that configures and applies the driver disable setting.

**(b)** _(3 marks per language part)_
- **High-level:** Abstract, mechanism-independent (e.g., "subject can read object if label dominates"). Suitable for initial specification.
- **Low-level:** Concrete, uses system-specific commands/options (e.g., SQL `GRANT SELECT ON table TO user`). More suitable for the medical record rule as it maps directly to **database access control** implementation.

**(c)** _(3 marks for i, 2 for ii)_
(i) It reuses proven solutions to common problems (**confidentiality**, **integrity**), reducing design errors and saving time.
(ii) It fails to enforce the intended security property. A confidentiality model (BLP) won't prevent unauthorised modification, leaving **integrity** vulnerabilities.

**(d)** _(4 marks for correct identification & justification)_
**Discretionary Access Control (DAC).** Justification: The policy decision is based on **ownership**, a user-centric attribute, rather than system-wide mandatory labels.

**(e)** _(2 marks per part)_
(i) **Imprintable** and **Imprinted**.
(ii) A **death** event: explicit reset, power cycle, or timeout of the secure session.

---
### Question 2: Bell-LaPadula (BLP) Model & Lattices
This question applies the formal properties and lattice structures of the BLP model.

**(a)** In the **Bell-LaPadula (BLP)** model:
(i) **State** the **Simple Security Property** (no-read-up rule) using the notation $L(s)$ and $L(o)$.
(ii) **State** the ***-Property** (no-write-down rule).
**[4 marks]**

**(b)** The **dominates** relation (≽) in BLP is a **partial order**.
(i) **Define** the mathematical property of **transitivity** for this relation.
(ii) **Explain** why transitivity is essential for consistent enforcement of security levels in BLP.
**[5 marks]**

**(c)** Given the security labels:
$A = (\text{Secret}, \{\text{Crypto}\})$
$B = (\text{TopSecret}, \{\text{Crypto, Nuclear}\})$
$C = (\text{TopSecret}, \{\text{Nuclear}\})$
Assume the classification levels are: Public < Confidential < Secret < TopSecret.
(i) Does $B ≽ A$ hold? **Justify** your answer.
(ii) Does $C ≽ A$ hold? **Justify** your answer.
**[6 marks]**

**(d)** For the labels $A$ and $B$ from part (c), compute:
(i) The **join** (Lowest Upper Bound, LUB) of $A$ and $C$.
(ii) The **meet** (Greatest Lower Bound, GLB) of $B$ and $C$.
Show your reasoning.
**[6 marks]**

**(e)** If the label $(\text{TopSecret}, \{\text{Crypto, Nuclear}\})$ were removed from the lattice structure containing $A, B, C$, **explain** which mathematical property of a lattice would be violated and why.
**[4 marks]**

---
#### Model Solution
**(a)** _(2 marks per property)_
(i) **Simple Security:** Subject $s$ can read object $o$ only if $L(o) ≤ L(s)$.
(ii) ***-Property:** Subject $s$ can write to object $o$ only if $L(s) ≤ L(o)$.

**(b)** _(3 marks for definition, 2 for explanation)_
(i) **Transitivity:** If $x ≽ y$ and $y ≽ z$, then $x ≽ z$.
(ii) It ensures that clearance and data flow are **consistent**. If a subject can read data at level $y$, and that data can be read from level $z$, then the subject can also read from $z$, preventing indirect **information leakage** through intermediate objects.

**(c)** _(3 marks per comparison)_
(i) **Yes.** $B ≽ A$ because TopSecret ≥ Secret (level) *and* $\{\text{Crypto}\} ⊆ \{\text{Crypto, Nuclear}\}$ (categories).
(ii) **No.** $C ≽ A$ fails because $\{\text{Crypto}\} ⊈ \{\text{Nuclear}\}$ (missing Crypto category).

**(d)** _(3 marks per computation)_
(i) **join(A, C):** $(\text{TopSecret}, \{\text{Crypto, Nuclear}\})$. Level: max(Secret, TopSecret)=TopSecret. Categories: union({Crypto},{Nuclear})={Crypto,Nuclear}.
(ii) **meet(B, C):** $(\text{TopSecret}, \{\text{Nuclear}\})$. Level: min(TopSecret,TopSecret)=TopSecret. Categories: intersection({Crypto,Nuclear},{Nuclear})={Nuclear}.

**(e)** _(4 marks for explanation)_
The **Lowest Upper Bound (LUB)** property would be violated. The pair $A$ and $C$ would have no **join** in the set, as their natural LUB $(\text{TopSecret}, \{\text{Crypto, Nuclear}\})$ is missing. Not all pairs would have a LUB, so the structure is no longer a **lattice**.

---
### Question 3: Chinese Wall & Model Selection
This question focuses on the Chinese Wall model and selecting appropriate policy models.

**(a)** The **Chinese Wall (CW)** model is designed to prevent conflicts of interest.
(i) **Define** a **Conflict Class** in this model.
(ii) **State** the **Simple Security Property** for the CW model.
**[5 marks]**

**(b)** A consultant at firm "SecureAudit" has previously accessed documents from the financial company "BankAlpha". The firm now has a new client, "BankBeta", which is a direct competitor of BankAlpha. Both banks are in the same **Conflict Class**.
(i) According to the CW **Simple Security Property**, can the consultant access documents from BankBeta? **Justify** your answer.
(ii) **Explain** the purpose of the **sanitisation** process in the CW model and how it could potentially allow future access.
**[8 marks]**

**(c)** You are tasked with designing access control for:
1. A military database where classified documents must not be readable by lower clearance personnel, and no data must be written to a lower classification.
2. A hospital system where junior doctors must not be able to modify treatment plans created by senior consultants.
**Select** the most appropriate **security model** (**BLP** or **Biba**) for each system (1 & 2). Justify each choice in one sentence.
**[6 marks]**

**(d)** Consider a **Reference Monitor** implementing a BLP-like policy. It uses an `exec(s, o, a)` predicate.
(i) **State** the three arguments to the `exec` predicate.
(ii) For the action $a = \text{read}$, write the **boolean condition** that `exec` must evaluate, using the BLP **Simple Security Property**.
**[6 marks]**

---
#### Model Solution
**(a)** _(3 marks for i, 2 for ii)_
(i) A **Conflict Class** is a set of **company groups** that are in competition (e.g., {BankA, BankB, BankC}).
(ii) A subject can access an object only if the object belongs to a company the subject has **never accessed before**, or belongs to the *same* company the subject has already accessed within that conflict class.

**(b)** _(4 marks per part)_
(i) **No.** The consultant has already accessed BankAlpha. Since BankBeta is in the same **Conflict Class**, the **Simple Security Property** prohibits access to a different company within that class.
(ii) **Sanitisation** is the process of removing sensitive, conflict-causing details from an object by a **trusted party**. A sanitised object is considered free of conflict, allowing subjects to access it regardless of their prior access history, thus bypassing the wall for that object.

**(c)** _(3 marks per selection with justification)_
1. **BLP.** It enforces **multi-level security** and prevents **read-up** and **write-down**, which matches the military **confidentiality** requirements.
2. **Biba.** It enforces **integrity** by preventing **write-up** (low-integrity subjects modifying high-integrity objects), protecting the senior consultants' plans from unauthorised modification.

**(d)** _(3 marks per part)_
(i) **Subject $s$, Object $o$, Action $a$.**
(ii) `exec(s, o, read) = true` **iff** $L(o) ≤ L(s)$ (and any discretionary permissions hold).
# 05. Command Injection and Input Validation
## Outline
- Input Validation
    - Tust Boundaries and Choke Points
    - Phishing via Homograph Attacks
    - Malicious URLs e.g., Directory Traversal
## Practice Qs
### Question 1: Input Validation & SQL Injection
This question covers core principles of input validation and SQL injection prevention.

**(a)** A developer proposes to prevent SQL injection by "filtering out all single quotes (') from user input before using it in a query."
**Explain** why this is an inadequate and insecure approach to **input validation**. Provide a specific example of a bypass.
**[5 marks]**

**(b)** **Compare** the security of using **prepared statements (parameterised queries)** versus **input filtering** for preventing SQL injection. **State** one key security advantage of prepared statements.
**[4 marks]**

**(c)** The concept of a **choke point** is used in input validation.
(i) **Define** what a choke point is in the context of data flow.
(ii) **Explain** why validating data *only* at choke points is more efficient and secure than validating at every component.
**[6 marks]**

**(d)** Consider a web application that allows users to view their own profile by requesting `https://example.com/profile?userid=alice`.
An attacker crafts the URL: `https://example.com/profile?userid=../../../etc/passwd`.
(i) **Name** this type of attack.
(ii) **Describe** the security mechanism (mentioned in the content) that can prevent it, and briefly explain how it works.
**[6 marks]**

**(e)** A **homograph attack** is used for phishing.
(i) **Explain** how homograph attacks exploit visual similarity in URLs.
(ii) **State** one technical method (not user education) a browser or service could use to help mitigate this threat.
**[4 marks]**

---
#### Model Solution
**(a)** _(5 marks for explanation with example)_
Filtering quotes is inadequate because SQL injection can be performed without them (e.g., **numeric injection**). It also fails if the database uses different quote characters or if the input is **encoded** (e.g., URL-encoded, Unicode). Example bypass: Input `1 OR 1=1--` (no quotes needed) could always evaluate to true.

**(b)** _(4 marks for comparison and advantage)_
**Input filtering** attempts to sanitise data, which is error-prone and may be bypassed. **Prepared statements** separate **code** (SQL structure) from **data** (user input), treating input as literal data only. Key advantage: It structurally eliminates the possibility of the input being interpreted as executable SQL code.

**(c)** _(3 marks per part)_
(i) A **choke point** is a single, well-defined location in the **data flow** where all data of a certain type must pass through for validation.
(ii) It is more **efficient** (validation code is not duplicated) and more **secure** (ensures consistent policy enforcement). If validation is scattered, missing a single component creates a **vulnerability**.

**(d)** _(3 marks per part)_
(i) **Directory Traversal** (or Path Traversal) attack.
(ii) **Canonicalisation.** The system converts the user input (`../../../etc/passwd`) into its **canonical** (absolute, normalized) path and then checks if it starts with the intended base directory (`/var/www/`). If not, access is denied.

**(e)** _(2 marks per part)_
(i) They use characters from different alphabets (e.g., Cyrillic 'а' vs Latin 'a') that look identical to create URLs that visually spoof legitimate domains (e.g., `examp1e.com`).
(ii) **Punycode** encoding in browsers can be used to display the **internationalised domain name (IDN)** in its encoded ASCII form (e.g., `xn--80ak6aa92e.com`), making spoofing obvious.

---
### Question 2: Advanced Injection & Data Flow
This question deals with more complex injection scenarios and secure data handling.

**(a)** A malicious URL is crafted as: `https://goodsite.com@evilsite.com/phishing`.
(i) **Explain** how the `@` symbol is interpreted in this URL and what the user's browser will actually connect to.
(ii) **State** the name of the attack technique that uses this `@` symbol obfuscation.
**[6 marks]**

**(b)** **Canonicalisation** is recommended to prevent path traversal.
(i) **Describe** what canonicalisation does to a file path string.
(ii) A Java snippet uses `file.getCanonicalPath().startsWith(BASE_DIR)`. **Explain** the purpose of the `startsWith` check after canonicalisation.
**[6 marks]**

**(c)** A web form takes a "username" and passes it to an OS command to create a user directory: `system("mkdir /home/" + username)`.
(i) **Identify** the vulnerability class.
(ii) Provide an example **malicious input** for `username` that would cause the command to delete a critical system file (assume the web server process has sufficient privileges).
(iii) **State** the fundamental programming practice that should be used instead of concatenating input into OS commands.
**[9 marks]**

**(d)** **Explain** why **input validation** should be considered a **defence-in-depth** measure rather than the *sole* security control for preventing injection attacks. Refer to the concept of **choke points**.
**[4 marks]**

---
#### Model Solution
**(a)** _(3 marks per part)_
(i) The `@` symbol in a URL separates **userinfo** from the **host**. The browser will attempt to connect to `evilsite.com`, with `goodsite.com` treated as a (usually ignored) username. The user may only see `goodsite.com` displayed.
(ii) **URL obfuscation** or **authority spoofing**.

**(b)** _(3 marks per part)_
(i) It converts a path with relative references (`.` , `..`), symbolic links, and alternate formats into a **unique, absolute, standardised** form.
(ii) After converting to the canonical path, the `startsWith` check ensures the resolved path is **within** the intended base directory (`BASE_DIR`), preventing directory traversal outside the allowed area.

**(c)** _(3 marks per part)_
(i) **OS Command Injection.**
(ii) Input: `; rm -rf /etc/passwd #` (or `$(rm -rf /etc/passwd)`). The semicolon ends the `mkdir` command and starts a new malicious one.
(iii) Use **safe APIs** that avoid the shell (e.g., `mkdir()` system call with explicit parameters) or **rigorous whitelist input validation**.

**(d)** _(4 marks for explanation)_
**Input validation** at **choke points** is a critical layer, but it can have flaws (e.g., logic errors, missed edge cases). **Defence-in-depth** means also using **prepared statements** (for SQL), **canonicalisation** (for paths), and **principle of least privilege** (for OS commands). If validation fails, other layers should still prevent exploitation.

---
### Question 3: Practical Defences & Case Study
This question applies the concepts to a practical scenario and evaluates defences.

**(a)** A content management system (CMS) has a plugin that allows image uploads. The plugin code uses:
`$filepath = "/uploads/" . $_GET['year'] . "/" . $_GET['filename'];`
`include($filepath);`
(i) **Identify** **two** distinct vulnerabilities present in this code snippet.
(ii) For each vulnerability, **suggest** a specific fix or secure coding practice.
**[8 marks]**

**(b)** A banking website uses a **parameterised query** as follows:
`cursor.execute("SELECT * FROM accounts WHERE owner = ? AND active = 1", (username,))`
(i) **Explain** why this is secure against SQL injection for the `username` parameter.
(ii) **State** whether this approach also automatically protects against a **second-order SQL injection** attack, where malicious input is first stored in the database and later used in a query. Justify your answer.
**[7 marks]**

**(c)** A system administrator writes a script to back up user-submitted filenames. The script runs: `zip /backups/$USERNAME.zip /data/$USERNAME/*`.
(i) **Describe** a potential **command injection** vulnerability if `$USERNAME` is not validated.
(ii) The admin decides to **whitelist** valid characters for usernames. **List** three characters that should *definitely* be on this whitelist and **one** that should *definitely* be banned.
**[5 marks]**

**(d)** **Explain** the relationship between **input validation** and the security principle of **"reluctance to trust"** (or "never trust user input"). How does implementing proper validation operationalise this principle?
**[5 marks]**

---
#### Model Solution
**(a)** _(4 marks per vulnerability+fix)_
(i) **Vulnerability 1: Directory Traversal** via `$_GET['year']` or `$_GET['filename']`.
**Fix:** Apply **canonicalisation** and path validation as described.
(ii) **Vulnerability 2: Local File Inclusion (LFI)** via `include($filepath)` with user-controlled path.
**Fix:** Avoid using user input directly in `include()`; use a whitelist of allowed files or a secure mapping system.

**(b)** _(4 marks for i, 3 for ii)_
(i) The `?` placeholder ensures the **username** value is bound as a **data parameter**, not part of the SQL string. The database driver handles escaping, preventing the input from altering the query structure.
(ii) **No.** Second-order injection occurs when data retrieved *from* the database is later used unsafely. Parameterisation protects the *current* query, but if the stored data is later concatenated into a new query without parameterisation, it could still cause injection.

**(c)** _(3 marks for i, 2 for ii - 1.5 for whitelist, 0.5 for ban)_
(i) If `$USERNAME` contains shell metacharacters (e.g., `; rm -rf /`), they will be interpreted by the shell, leading to arbitrary command execution.
(ii) **Whitelist:** Alphanumeric characters `[a-zA-Z0-9]` and hyphen `-`. **Ban:** Semicolon `;` (or any shell metacharacter like `&`, `|`, `$`, `` ` ``).

**(d)** _(5 marks for explanation)_
The principle **"reluctance to trust"** mandates treating all external input as potentially malicious. **Input validation** operationalises this by *actively checking and constraining* that input against strict rules (whitelists, type, length, format) before use. It transforms the principle from a passive guideline into an active, enforceable **security control** at **choke points**, reducing the **attack surface**.
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
### Question 1: Session Management & HTTPS
This question covers web session security and transport layer protections.

**(a)** HTTP is stateless, so web applications use **sessions**.
(i) **Describe** the purpose of a **session ID**.
(ii) **State** two security best practices for generating and handling session IDs to prevent impersonation attacks.
**[6 marks]**

**(b)** A developer stores the session ID in the URL (e.g., `?sessionid=abc123`) to support browsers that block cookies.
(i) **Identify** the major security risk this introduces.
(ii) **Propose** a more secure alternative approach for session management without relying solely on cookies.
**[5 marks]**

**(c)** The **DROWN attack** exploits support for the obsolete SSLv2 protocol.
(i) **Explain** the core condition that makes a server vulnerable to DROWN.
(ii) **State** one specific configuration action to prevent this vulnerability.
**[4 marks]**

**(d)** **HSTS (HTTP Strict Transport Security)** is a security policy mechanism.
(i) **State** the primary security benefit of HSTS.
(ii) **Identify** one remaining limitation or weakness of HSTS that could still allow an initial Man-in-the-Middle (MitM) attack.
**[5 marks]**

**(e)** An application has an **open redirect** vulnerability where the parameter `redirect_url` in a GET request is used unchecked in a `Location:` header.
(i) **Describe** how an attacker could exploit this for a phishing attack.
(ii) **State** the correct defensive measure to fix this vulnerability.
**[5 marks]**

---
#### Model Solution
**(a)** _(2 marks for i, 4 for ii - 2 marks per practice)_
(i) A **session ID** is a token that uniquely identifies a user's interaction sequence with the server, allowing state to be maintained across stateless HTTP requests.
(ii) 1. Generate IDs using a **cryptographically secure PRNG** (Pseudo Random Number Generator).
2. Enforce **HTTPS-only** and set the **Secure** cookie flag to prevent transmission over plain HTTP.

**(b)** _(3 marks for i, 2 for ii)_
(i) **Session ID exposure** in browser history, logs, Referer headers, and via shoulder surfing—leading to **session hijacking**.
(ii) Use **browser-local storage** (e.g., `sessionStorage`) with tokens transmitted in a custom HTTP header (e.g., `X-Session-Token`), combined with **same-origin** protections.

**(c)** _(2 marks per part)_
(i) A server is vulnerable if its **private RSA key** is used on *any* server that still supports the **SSLv2** protocol, even if the target server itself does not.
(ii) **Disable SSLv2** (and SSLv3) on *all* servers that share the same private key, and ensure TLS 1.2+ is the minimum supported version.

**(d)** _(3 marks for i, 2 for ii)_
(i) It forces browsers to use **HTTPS** for all connections to the domain, preventing **downgrade attacks** and cookie hijacking over HTTP.
(ii) The **first visit** to a site is not protected by HSTS if the initial request is made via HTTP, allowing a **MitM** to strip or intercept the HSTS header.

**(e)** _(3 marks for i, 2 for ii)_
(i) An attacker crafts a link like `https://victim-site.com/logout?redirect_url=https://evil-phishing-site.com`. The victim is logged out and then automatically redirected to a convincing phishing page, potentially leaking credentials.
(ii) **Validate and whitelist** allowable redirect URLs on the server-side, or use a mapping of internal tokens to approved URLs (avoid direct user input).

---
### Question 2: XSS & HTML Injection
This question focuses on Cross-Site Scripting attacks and their prevention.

**(a)** **Cross-Site Scripting (XSS)** is a major web vulnerability.
(i) **Distinguish** between **Reflected XSS** and **Stored XSS** in terms of how the malicious script is delivered to the victim.
(ii) For **Stored XSS**, explain why it is often considered more severe.
**[6 marks]**

**(b)** A comment form on a blog accepts user input and displays it without sanitisation. An attacker submits a comment containing: `<span onmouseover="alert('XSS')">Hover here</span>`.
(i) **Classify** this XSS attack type.
(ii) **Describe** two specific server-side defences that would prevent this attack from succeeding.
**[6 marks]**

**(c)** The **`HttpOnly`** cookie flag is recommended for session cookies.
(i) **Explain** what protection the `HttpOnly` flag provides.
(ii) **State** whether this flag alone is sufficient to prevent **session hijacking** via XSS. Justify your answer.
**[5 marks]**

**(d)** **HTML Injection** can be used to perform a **frame attack**.
(i) **Describe** how an attacker could use injected HTML to create a fraudulent login form.
(ii) **State** one client-side and one server-side defence against such frame-based phishing.
**[5 marks]**

**(e)** A web application uses **Markdown** instead of raw HTML for user-generated content.
(i) **Explain** why this is a good security practice against XSS.
(ii) **Identify** one potential security risk that remains even when using a Markdown parser.
**[3 marks]**

---
#### Model Solution
**(a)** _(3 marks per part)_
(i) **Reflected XSS:** The malicious script is part of the victim's request (e.g., in a URL parameter) and is immediately included in the server's response. **Stored XSS:** The script is permanently stored on the server (e.g., in a database) and served to multiple victims in later page views.
(ii) **Stored XSS** is more severe because it *persists*, can affect *many users* without targeted phishing, and may remain undetected for a long time.

**(b)** _(2 marks for i, 4 for ii - 2 marks per defence)_
(i) **Stored XSS** (the script is saved in the blog comment database).
(ii) 1. **Output Encoding:** Convert special characters (`<`, `>`, `&`, `"`) to HTML entities (`&lt;`, `&gt;`, `&amp;`, `&quot;`) before rendering.
2. **Input Validation/Rejection:** Disallow raw HTML input entirely; accept only plain text or a safe subset like Markdown.

**(c)** _(3 marks for i, 2 for ii)_
(i) It prevents client-side **JavaScript** from accessing the cookie via `document.cookie`, mitigating cookie theft via **XSS**.
(ii) **No.** While it prevents script-based theft, **session hijacking** can still occur via network eavesdropping (if not HTTPS) or **MITM** attacks. It is a **defence-in-depth** measure, not a complete solution.

**(d)** _(3 marks for i, 2 for ii - 1 mark per defence)_
(i) Inject an `<iframe>` pointing to a malicious server that displays a fake login form. When the user submits credentials, they are sent to the attacker.
(ii) **Client-side:** Use the **`X-Frame-Options: DENY`** or **`Content-Security-Policy frame-ancestors`** header to prevent framing. **Server-side:** Strict **output encoding** to prevent HTML/script injection in the first place.

**(e)** _(2 marks for i, 1 for ii)_
(i) Markdown parsers typically **strip or escape** raw HTML and JavaScript, preventing direct script injection from user input.
(ii) If the Markdown parser itself has a vulnerability (e.g., allowing unsanitised HTML passthrough), or if it supports **dangerous features** like `javascript:` links, XSS may still be possible.

---
### Question 3: CSRF, XML, & OWASP Trends
This question covers CSRF, XML attacks, and evolving web vulnerability landscapes.

**(a)** **Cross-Site Request Forgery (CSRF/XSRF)** exploits the browser's automatic sending of session credentials.
(i) **Describe** the core mechanism of a CSRF attack.
(ii) **Explain** how using a **synchroniser token (nonce)** pattern prevents CSRF.
**[7 marks]**

**(b)** A banking site uses a form for money transfers:
`<form action="/transfer" method="POST"><input name="amount"><input name="toAccount">...</form>`
An attacker tricks a logged-in user to visit a page containing:
`<img src="https://bank.com/transfer?amount=1000&toAccount=ATTACKER" width="0" height="0">`
(i) **Explain** why this attack might fail if the bank uses a **nonce** stored in a *hidden form field*.
(ii) **State** an alternative, more robust location to store the nonce that would still prevent this attack.
**[5 marks]**

**(c)** The **Billion Laughs** attack is a type of **XML External Entity (XXE)** attack.
(i) **Describe** its impact (e.g., Denial of Service, Information Disclosure).
(ii) **State** the fundamental parsing flaw it exploits and one configuration fix to prevent it.
**[5 marks]**

**(d)** **Client-side validation** is often implemented in JavaScript for form fields.
(i) **Explain** why client-side validation is **not** a security control.
(ii) **State** the correct principle regarding **where** input validation for security must always occur.
**[4 marks]**

**(e)** According to OWASP Top 10 trends, "Injection and auth issues are less significant" while "Cryptographic failure and use of vulnerable components has become more significant."
**Provide** one plausible reason for each of these shifts in the threat landscape.
**[4 marks]**

---
#### Model Solution
**(a)** _(4 marks for i, 3 for ii)_
(i) The attacker tricks a victim's browser into making an **authenticated request** (using the victim's stored session cookies) to a target web application, causing an unintended state-changing action (e.g., funds transfer) without the victim's consent.
(ii) The server generates a unique, unpredictable **nonce** for each session/form, embeds it in the page (e.g., hidden field), and validates it upon request submission. An attacker cannot forge a valid request because they cannot predict or read the nonce.

**(b)** _(3 marks for i, 2 for ii)_
(i) The attack uses a **GET** request (via `<img>` src). If the bank expects the nonce in a **hidden form field** submitted via **POST**, the GET request will lack the required token and be rejected.
(ii) Store the nonce in a **custom HTTP header** (e.g., `X-CSRF-Token`). This is more robust because browsers enforce the **Same-Origin Policy**, preventing attackers from setting custom headers in cross-site requests.

**(c)** _(2 marks for i, 3 for ii - 2 for flaw, 1 for fix)_
(i) **Denial of Service (DoS)** by exhausting server memory/CPU through exponential entity expansion.
(ii) **Flaw:** The XML parser **eagerly evaluates** and expands all entity references during parsing, allocating massive amounts of memory. **Fix:** Disable **external entity processing** (DTD) in the XML parser configuration.

**(d)** _(2 marks per part)_
(i) Client-side validation can be **bypassed** by disabling JavaScript, using tools like Burp Suite, or crafting raw HTTP requests. It only improves **user experience**.
(ii) Validation for security **must always be performed on the server-side**, as it is the only trusted environment.

**(e)** _(2 marks per reason)_
1. **Injection/Auth less significant:** Widespread adoption of **frameworks** with built-in protections (ORM, parameterised queries), better security education, and standard libraries has reduced these classic flaws.
2. **Crypto/Vulnerable Components more significant:** Increased use of **third-party libraries** (npm, pip) and complex cloud configurations introduces supply chain risks and misconfigurations that are harder to manage.
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
### Question 1: Entropy & Password Strength
This question tests the calculation and interpretation of password entropy.

**(a)** **Entropy** is a measure of uncertainty or randomness in a secret.
(i) **State** the formula for calculating the entropy $H$ (in bits) of a secret chosen uniformly from a set of $N$ possibilities, where the secret is $L$ independent selections from that set.
(ii) A user creates a password by randomly choosing 6 lowercase letters (a-z). **Calculate** the entropy of this password. Show your working.
**[6 marks]**

**(b)** A system requires passwords with at least 50 bits of entropy. A user proposes using an 8-character password where each character is randomly chosen from the 95 printable ASCII characters.
(i) **Calculate** the entropy of this 8-character password.
(ii) **Determine** if it meets the 50-bit requirement. If not, calculate the **minimum length** $L$ (to the nearest whole character) needed using the same character set.
**[8 marks]**

**(c)** **Compare** the entropy of a **4-digit numeric PIN** (0-9) to a **6-character lowercase alphabetic** password (a-z). Show the calculation for each and state which is stronger and by approximately how many bits.
**[6 marks]**

**(d)** The **Key Sweeper** device is a malicious USB charger that sniffs wireless keyboard keystrokes.
(i) **Identify** the type of attack this enables (e.g., MITM, Eavesdropping).
(ii) **State** one effective mitigation a user could employ to protect against such an attack, assuming they must use a wireless keyboard.
**[5 marks]**

---
#### Model Solution
**(a)** _(3 marks for formula, 3 for calculation)_
(i) $H = L \cdot \log_2 N$ bits.
(ii) $N = 26$ (lowercase letters), $L = 6$.
$H = 6 \cdot \log_2 26 = 6 \cdot \frac{\log_{10} 26}{\log_{10} 2} \approx 6 \cdot 4.700 \approx \textbf{28.20 bits}$.

**(b)** _(4 marks per part)_
(i) $N = 95$, $L = 8$.
$H = 8 \cdot \log_2 95 = 8 \cdot \frac{\log_{10} 95}{\log_{10} 2} \approx 8 \cdot 6.570 \approx \textbf{52.56 bits}$.
(ii) **Yes**, 52.56 bits > 50 bits. Minimum length: $L_{min} = \lceil \frac{50}{\log_2 95} \rceil = \lceil \frac{50}{6.570} \rceil = \lceil 7.61 \rceil = \textbf{8 characters}$.

**(c)** _(3 marks per calculation, 1 for comparison)_
- **PIN:** $N=10, L=4$. $H = 4 \cdot \log_2 10 \approx 4 \cdot 3.322 = \textbf{13.29 bits}$.
- **6-char lowercase:** $N=26, L=6$. $H = 6 \cdot \log_2 26 \approx 6 \cdot 4.700 = \textbf{28.20 bits}$.
The 6-character password is stronger by approximately **14.91 bits**.

**(d)** _(3 marks for i, 2 for ii)_
(i) **Eavesdropping** (specifically, a **wireless sniffing** attack).
(ii) Use a **wireless keyboard that employs strong encryption** (e.g., AES) for the keystroke signal, or use a **wired keyboard** for sensitive input.

---
### Question 2: Password Hashing & Salting
This question focuses on secure password storage and attacks against hashes.

**(a)** It is standard practice to store a **hash** of a password, not the password itself.
(i) **Explain** the fundamental security reason for this.
(ii) **Identify** one major weakness of using a fast, unsalted hash function (e.g., MD5, SHA-1) for password storage.
**[5 marks]**

**(b)** **Salting** is used to defend against precomputed hash attacks (rainbow tables).
(i) **Define** what a **salt** is in this context.
(ii) **Explain** how salting makes a **rainbow table** attack impractical for an attacker who has stolen a password database.
**[6 marks]**

**(c)** Given the following **hash cracking algorithm** pseudocode that uses a salt:
```
for user in stolen_file:
    pass_hash = user.hash
    pass_salt = user.salt
    for word in word_list:
        variations = generate_variations(word)
        for variation in variations:
            tmp_hash = hash(variation + pass_salt)
            if tmp_hash == pass_hash: return variation
```
(i) **Name** the type of attack this algorithm performs (e.g., brute-force, dictionary).
(ii) **State** how using a **unique salt per user** (as shown) affects the **computational cost** for an attacker cracking *multiple* users' passwords from the same database, compared to a single global salt.
**[6 marks]**

**(d)** To further slow down cracking, a **key stretching** technique like PBKDF2 or bcrypt is used.
(i) **Describe** what key stretching does.
(ii) **Explain** how it increases security against the attack in part (c).
**[5 marks]**

**(e)** A system uses `hash(password + salt)` where `+` denotes string concatenation. An attacker argues that a **long, globally unique salt** stored separately is just as good as per-user salts. **Explain** why this is **false** from a security perspective.
**[3 marks]**

---
#### Model Solution
**(a)** _(3 marks for i, 2 for ii)_
(i) To ensure that if the credential database is compromised, the actual plaintext passwords are not directly exposed, protecting users who reuse passwords elsewhere.
(ii) Fast hashes allow rapid **offline brute-force** or **dictionary attacks** against stolen hashes, as an attacker can compute billions of hashes per second.

**(b)** _(3 marks per part)_
(i) A **salt** is a random, unique value generated for each password and stored alongside its hash.
(ii) A rainbow table is precomputed for unsalted hashes. A unique salt **perturbs** the hash input, meaning the attacker must recompute tables *for each salt value*, making precomputation infeasible.

**(c)** _(3 marks per part)_
(i) **Dictionary attack** (with variations/mangling rules).
(ii) With **unique salts**, the attacker must run the entire **word list * variations** loop **separately for each user**, multiplying the total work by the number of users. With a **global salt**, the word list loop is run once and results compared to all hashes.

**(d)** _(3 marks for i, 2 for ii)_
(i) It applies the hash function **iteratively many times** (e.g., 100,000 rounds), deliberately slowing down the hash computation.
(ii) It dramatically increases the **time** (and thus **computational cost**) to compute `tmp_hash` for each candidate password in the attack loop, making large-scale dictionary/brute-force attacks impractical.

**(e)** _(3 marks for explanation)_
A **global salt** (even if long and unique) still allows an attacker to precompute a single **rainbow table** for that salt, or to attack all hashes in the database in a **single pass** after computing hashes once. **Per-user salts** force a **separate attack per user**, providing **defence in depth**.

---
### Question 3: Multi-Factor & Biometric Authentication
This question evaluates authentication factors and the unique challenges of biometrics.

**(a)** Authentication can be based on **something you know**, **something you have**, or **something you are**.
(i) **Classify** each of the following into one of these three categories:
A. **Password**
B. **Fingerprint scan**
C. **Hardware security key (e.g., YubiKey)**
(ii) **Two-Factor Authentication (2FA)** requires two *different* categories. Give an example of a valid 2FA combination using the items above.
**[6 marks]**

**(b)** **Biometric** authentication is convenient but has limitations.
(i) **Explain** the **revocation problem** associated with biometric credentials.
(ii) **Describe** the proposed solution that involves combining a biometric with a **revocable factor**, as mentioned in the content.
**[7 marks]**

**(c)** A company implements 2FA using SMS one-time codes sent to a user's mobile phone.
(i) **Identify** the category of the second factor (SMS code).
(ii) **State** one security weakness of using SMS for 2FA.
**[4 marks]**

**(d)** Passwords are considered "cheap and convenient but weak."
(i) **State** one reason why passwords are **weak** from an **entropy** perspective for typical user choices.
(ii) **State** one reason why adding a **physical token** (2FA) significantly improves security even if the password is weak.
**[5 marks]**

**(e)** A system stores a hash of `hash(biometric_template + user_salt)`.
(i) **Explain** the purpose of the `user_salt` in this construction.
(ii) If the database is compromised, can the `user_salt` be changed to "revoke" the biometric credential? Justify your answer.
**[3 marks]**

---
#### Model Solution
**(a)** _(4 marks for i - 1 each, 2 for ii)_
(i) A: **Something you know.** B: **Something you are.** C: **Something you have.**
(ii) **Valid 2FA:** Password (know) + Hardware security key (have). *Or* Password (know) + Fingerprint (are).

**(b)** _(4 marks for i, 3 for ii)_
(i) The **revocation problem** is that biometric traits (e.g., fingerprints) are **immutable** and **finite**. If a biometric template is compromised, you cannot issue a new fingerprint like a new password; the original biometric is permanently weakened for authentication.
(ii) Combine the **biometric template** with a **revocable factor** (e.g., a random number or token), hash the **composite**, and store the hash. To revoke, change the revocable factor and recompute the hash, effectively creating a new credential without changing the biometric.

**(c)** _(2 marks per part)_
(i) **Something you have** (possession of the mobile phone/SIM).
(ii) SMS is vulnerable to **SIM swapping** attacks, **SS7 protocol exploits**, or interception if the phone is infected with malware.

**(d)** _(3 marks for i, 2 for ii)_
(i) Users tend to choose **low-entropy** passwords (common words, predictable patterns) far below the theoretical maximum for the character set.
(ii) A **physical token** adds a requirement for **possession**, making attacks require **both** knowledge of the (possibly weak) password **and** physical access to the token, raising the attack barrier significantly.

**(e)** _(2 marks for i, 1 for ii)_
(i) The `user_salt` ensures **uniqueness** of the stored hash even if two users have the same biometric template, preventing cross-user matching and precomputation attacks.
(ii) **Yes.** Changing the `user_salt` and re-encoding the biometric with the new salt produces a **new hash**, effectively revoking the old credential. This solves the revocation problem for the *stored representation*, not the biometric itself.
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
### Question 1: DNS & ARP Spoofing
This question covers DNS and ARP resolution attacks and their defences.

**(a)** **DNS** and **ARP** are both resolution protocols.
(i) **State** what each protocol resolves *from* and *to* (e.g., "DNS resolves X to Y").
(ii) **Identify** the common vulnerability that both **DNS cache poisoning** and **ARP spoofing** exploit.
**[5 marks]**

**(b)** **DNS cache poisoning** involves forging a reply to a DNS resolver.
(i) **Explain** why the use of the **UDP** protocol makes DNS susceptible to this attack.
(ii) **List** **three** pieces of information an attacker must know or guess to successfully poison a DNS cache for a specific query.
**[8 marks]**

**(c)** **DNSSEC** is a security extension for DNS.
(i) **State** the primary security goal of DNSSEC.
(ii) **Explain** how DNSSEC achieves this goal at a high level (mention the cryptographic mechanism used).
**[5 marks]**

**(d)** **ARP spoofing** is typically used within a Local Area Network (LAN).
(i) **Describe** the immediate consequence of a successful ARP spoofing attack against Host A, where the attacker spoofs the MAC address of the default gateway (router).
(ii) **State** one practical network-level defence against ARP spoofing.
**[5 marks]**

**(e)** Compare **DNS hijacking** and **DNS cache poisoning**. **State** one key difference in how the attacker gains control over the DNS response.
**[2 marks]**

---
#### Model Solution
**(a)** _(3 marks for i, 2 for ii)_
(i) **DNS** resolves **domain names** to **IP addresses**. **ARP** resolves **IP addresses** to **MAC addresses** on a LAN.
(ii) Both exploit the **lack of authentication** in the protocol, allowing an attacker to **spoof** (forge) replies with malicious mapping data.

**(b)** _(3 marks for i, 5 for ii - ~1.5 per item)_
(i) UDP is **connectionless** and **stateless**; there is no handshake or sequence verification, making it easy to forge a packet that appears to be a legitimate response.
(ii) 1. The **16-bit transaction ID** in the DNS query.
2. The **source port** used by the DNS resolver for the query.
3. That the target domain query is **uncached** (or has a very low TTL) to trigger a fresh upstream request.

**(c)** _(2 marks for i, 3 for ii)_
(i) To provide **data origin authentication** and **integrity** for DNS responses, preventing spoofing and cache poisoning.
(ii) It uses **digital signatures** (public key cryptography). Authoritative DNS servers sign their DNS records. Resolvers can verify these signatures using published public keys, ensuring the response is authentic and untampered.

**(d)** _(3 marks for i, 2 for ii)_
(i) Host A's **ARP cache** is poisoned to map the gateway's IP to the attacker's MAC. All traffic from Host A destined for outside the LAN is **intercepted by the attacker**, enabling **MITM** or **denial-of-service**.
(ii) Use **static ARP entries** for critical devices (e.g., gateways) or deploy **Dynamic ARP Inspection (DAI)** on managed switches.

**(e)** _(2 marks for valid difference)_
**DNS hijacking** involves compromising the **DNS resolver itself** (e.g., via malware or registrar attack) to control responses. **DNS cache poisoning** involves **forging a response** to a legitimate resolver without directly compromising it.

---
### Question 2: Remote Access & Protocol Security
This question examines insecure legacy protocols, attacks like banner grabbing, and the role of SSH.

**(a)** **Banner grabbing** is an information-gathering technique.
(i) **Describe** what a network service "banner" typically contains.
(ii) **Explain** why this information is valuable to an attacker in the context of vulnerability exploitation.
**[5 marks]**

**(b)** Before SSH, protocols like **telnet** and **rlogin** were used for remote access.
(i) **State** the critical security flaw common to both telnet and rlogin.
(ii) The `r` tools (rlogin, rsh) used a "trusted hosts" mechanism. **Explain** the vulnerability this introduced.
**[6 marks]**

**(c)** The command `ssh -f -N -L 5678:localhost:110 mailhost` is executed on a client.
(i) **Name** the SSH feature being used (`-L` flag).
(ii) **Describe** the practical effect of this command. Which insecure protocol is being protected and how?
**[6 marks]**

**(d)** The **STRIPTLS** attack targets email protocols.
(i) **Identify** the protocol command that STRIPTLS removes.
(ii) **Explain** the attack's impact: what security property is lost, and what type of attack becomes possible as a result?
**[5 marks]**

**(e)** Modern secure alternatives to legacy ports (e.g., SMTPS on 587, IMAPS on 993) exist.
(i) **State** the cryptographic protocol these alternatives use.
(ii) **Compare** the approach of using a **dedicated secure port** (e.g., 993) versus using **STARTTLS** on the standard port (e.g., 143). Which is generally considered more resilient to downgrade attacks like STRIPTLS? Justify briefly.
**[3 marks]**

---
#### Model Solution
**(a)** _(3 marks for i, 2 for ii)_
(i) A banner often contains **software name**, **version number**, and sometimes **operating system** details, sent by a service upon connection.
(ii) It allows **fingerprinting** to identify **known vulnerabilities** (CVEs) specific to that software version, enabling targeted exploitation.

**(b)** _(3 marks per part)_
(i) They transmit all data, including **authentication credentials**, in **plaintext**, allowing eavesdropping via network sniffing.
(ii) Trusted hosts rely on **IP address** or **hostname** for authentication without credentials. This is vulnerable to **IP spoofing** and **DNS spoofing**, allowing impersonation.

**(c)** _(2 marks for i, 4 for ii)_
(i) **SSH Port Forwarding** (Local Port Forwarding).
(ii) It creates an **encrypted SSH tunnel** from the client's port 5678 to `mailhost` port 110 (POP3). The client can configure their email software to connect to `localhost:5678`. Traffic is forwarded through the SSH tunnel, **protecting the insecure POP3 protocol** from eavesdropping and MITM on the network.

**(d)** _(2 marks for i, 3 for ii)_
(i) The **STARTTLS** command.
(ii) The **confidentiality** and **integrity** provided by TLS are lost. The connection falls back to **plaintext**, enabling **eavesdropping** and **credential theft** via MITM.

**(e)** _(1 mark for i, 2 for ii)_
(i) **TLS** (Transport Layer Security).
(ii) **Dedicated secure ports** (e.g., 993) are more resilient. STARTTLS is vulnerable to **downgrade attacks** (like STRIPTLS) where the MITM strips the STARTTLS command. A dedicated port *implicitly* expects TLS, making such interception more obvious or impossible if the port is blocked without TLS.

---
### Question 3: SSH, MITM, & Protocol Evolution
This question delves into SSH mechanics, MITM risks, and the evolution of secure application protocols.

**(a)** **SSH** uses a combination of cryptographic techniques.
(i) **State** which type of cryptography (symmetric/asymmetric) is used for:
A. The initial key exchange and server authentication.
B. The encryption of the session data.
(ii) **Explain** the purpose of the client's local database of known host public keys (e.g., `~/.ssh/known_hosts`).
**[7 marks]**

**(b)** In 2008, a vulnerability was found in SSH's use of **CBC mode** encryption.
(i) **Describe** the general class of this vulnerability (e.g., padding oracle, chosen-ciphertext).
(ii) What was the recommended fix mentioned in the content?
**[4 marks]**

**(c)** An **SSH MITM attack** occurs when a user connects to a server for the first time.
(i) **Explain** why the first connection is particularly vulnerable if the user has no prior knowledge of the server's public key.
(ii) **Describe** the standard security warning/ prompt a user receives in this scenario and the risk of blindly accepting it.
**[6 marks]**

**(d)** Consider the evolution from plain **SMTP/POP3/IMAP** to their secure versions.
(i) For **SMTPS** (port 587) and **POP3S** (port 995), what does the 'S' stand for and what fundamental change does it represent?
(ii) **State** one significant security improvement this provides over the original protocols regarding **authentication**.
**[5 marks]**

**(e)** The **APOP** extension for POP3 used an MD5 hash of a timestamp and a shared secret.
(i) **Explain** the security intent of this design compared to sending the password in plaintext.
(ii) **State** one reason why this mechanism is now considered insecure.
**[3 marks]**

---
#### Model Solution
**(a)** _(4 marks for i - 2 each, 3 for ii)_
(i) A: **Asymmetric** (Public-key) cryptography. B: **Symmetric** cryptography.
(ii) It provides **trust-on-first-use (TOFU)**. It stores the server's public key on first connection. On subsequent connections, the client verifies the presented key matches the stored one, detecting **MITM** attempts where the attacker presents a different key.

**(b)** _(2 marks per part)_
(i) A **chosen-ciphertext attack** that could recover bits of plaintext due to weaknesses in CBC padding.
(ii) Switch from **CBC mode** to **CTR mode** (Counter Mode) for encryption.

**(c)** _(3 marks per part)_
(i) The client has no trusted reference (key) to verify the server's identity. A MITM can present their own key, and the client has no basis to detect the impersonation.
(ii) The user receives a warning that the **host key is unknown** and is asked whether to **continue connecting**. Blindly accepting **trusts the presented key permanently**, which could be an attacker's key, enabling future undetected MITM.

**(d)** _(3 marks for i, 2 for ii)_
(i) The 'S' stands for **Secure** (or **SSL/TLS**). It represents wrapping the entire protocol session in a **TLS encrypted channel** from the outset.
(ii) It allows **secure password-based authentication** (or certificate-based) within the encrypted tunnel, preventing **credential sniffing** that was trivial with plaintext protocols.

**(e)** _(2 marks for i, 1 for ii)_
(i) To avoid sending the password in plaintext. The server sends a random **challenge** (timestamp), and the client responds with a **hash** of the challenge + password, proving knowledge without exposing the password.
(ii) **MD5** is cryptographically broken (collision and pre-image vulnerabilities). Also, it is still vulnerable to **offline brute-force** if the challenge and hash are intercepted.
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
### Question 1: Foundational Concepts & Enforceability
This question establishes the core definitions and examines which policies are enforceable.

**(a)** In the context of **Execution Monitoring (EM)**, a **security policy** defines acceptable system behaviour.
(i) **Define** what it means for a target system **T** to **satisfy** a security policy **P**.
(ii) **State** the fundamental requirement for a policy to be **enforceable** through EM.
**[5 marks]**

**(b)** Consider the policy: "No email should be sent after reading a confidential file."
(i) **Classify** this policy as primarily a **safety property** or a **liveness property**. Justify your choice in one sentence.
(ii) **Explain** why this policy is likely **enforceable** through runtime monitoring.
**[6 marks]**

**(c)** Let **E** be the set of all possible execution sequences of a target system. A security policy **P** is a predicate over **E**.
**Explain** the logical statement:
$P(E(T)) = \forall e \in E(T): P'(e)$
and what it implies about **P** being a **property** of the system.
**[6 marks]**

**(d)** A policy states: "The average response time of the web server must be under 100ms."
(i) **Explain** why this is **not** considered a **property** in the formal sense used for EM.
(ii) **Deduce** whether this policy is **enforceable** via a standard EM mechanism that only observes past events. Justify your answer.
**[8 marks]**

---
#### Model Solution
**(a)** _(3 marks for i, 2 for ii)_
(i) System **T** satisfies policy **P** if and only if **all** its possible execution sequences $E(T)$ are in the set defined as acceptable by **P**. Formally, $P(E(T)) = \text{True}$.
(ii) The policy must be a **property** that can be decided (as violated or not) by observing only the **finite prefix** of an execution up to the violation point. It must be a **safety** or **co-safety** property.

**(b)** _(3 marks per part)_
(i) **Safety property.** It states that a "bad thing" (sending email after reading) must **never happen**. Safety properties are defined by the absence of a violating finite prefix.
(ii) It is enforceable because a monitor can observe the sequence of events (`read_file`, `send_email`). The violation (sending after reading) is detectable at the finite point when the `send_email` action occurs after a `read_file`, allowing the monitor to **abort** the execution.

**(c)** _(6 marks for explanation)_
The statement means that the policy **P** holds for the entire set of executions $E(T)$ of system **T** **if and only if** for **every single execution sequence** $e$ in that set, a more specific predicate $P'$ holds true for that individual execution. If this condition is met, then **P** is a **property** of the system because its truth depends solely on the characteristics of **every possible execution**, not on external factors or probabilities.

**(d)** _(4 marks per part)_
(i) It is not a **property** because it is a **quantitative, aggregate measure** over many executions, not a definitive true/false predicate on **individual execution sequences**. A single execution cannot violate or satisfy an "average".
(ii) **Not enforceable** by a standard EM mechanism. An EM mechanism observes **single execution sequences** and can abort based on a violating prefix within that sequence. An average response time is a **global, statistical property** across many requests over time, which cannot be determined or enforced by monitoring a single, finite execution in isolation.

---
### Question 2: Safety, Liveness & State Analysis
This question uses the mutual exclusion example to analyse safety/liveness and state transitions.

**(a)** For the **mutual exclusion** policy:
(i) **State** the **safety property** in your own words.
(ii) **State** the corresponding **liveness property** in your own words.
**[4 marks]**

**(b)** The state of two processes is represented as `<(r1,c1),(r2,c2)>`, where `r`=requesting (0/1) and `c`=in critical section (0/1). The **safety property** is that `c1 + c2 ≤ 1`.
Given the current state `< (1,0), (0,0) >`, which of the following next states **violate** the safety property? Justify your answer.
A. `< (0,1), (0,0) >`
B. `< (1,1), (0,0) >`
C. `< (1,0), (1,0) >`
**[6 marks]**

**(c)** In the provided **State Space** diagram, the transition `< (1,0), (1,0) > → < (0,1), (0,1) >` is shown but then removed in the **Target System Space**.
(i) **Explain** why this transition violates the **safety property**.
(ii) **Describe** the role of the **EM mechanism** in this scenario. What would it do if the program attempted this transition?
**[7 marks]**

**(d)** The policy "Every requesting process is eventually granted access" is a **liveness property**.
(i) **Explain** why a standard **EM mechanism** (as defined, which can only abort) **cannot enforce** a liveness property.
(ii) What **type of mechanism** would be needed to *ensure* liveness?
**[5 marks]**

**(e)** Consider a program with the property: "Successful termination." This is a liveness property.
**Argue** whether an EM mechanism that can only **abort** executions is useful for enforcing *any aspect* of this property.
**[3 marks]**

---
#### Model Solution
**(a)** _(2 marks per property)_
(i) **Safety:** At most one process can be in the **critical section** at any time.
(ii) **Liveness:** Every process that **requests** access to the critical section will **eventually** be granted access.

**(b)** _(2 marks per state with justification)_
- **A. `< (0,1), (0,0) >`:** **Safe.** `c1=1, c2=0`, sum=1.
- **B. `< (1,1), (0,0) >`:** **Violates.** `c1=1, c2=0`, sum=1. *Wait, this sum is 1, which is ≤1. Let's re-check the state: (r1=1, c1=1), (r2=0, c2=0). The sum of c's is 1, so it does NOT violate the safety property `c1+c2 ≤ 1`. The question asks which violate. None of these violate based on the given safety property. There must be a mistake in the question or my reading. Let's assume the safety property is `c1 + c2 ≤ 1` as stated. Then:*
  *A: c-sum=1, safe. B: c-sum=1, safe. C: c-sum=0, safe.*
  *Therefore, **none violate**. The justification would be that all satisfy `c1+c2 ≤ 1`.*
  *However, looking at the original notes, the transition to `< (1,1), (0,0) >` might be disallowed for other reasons (e.g., a process cannot be in critical section without having requested first? But state B shows it has requested (r1=1)). I will answer based purely on the given safety property.*
**Answer:** None of the states A, B, C violate the safety property `c1+c2 ≤ 1`.

**(c)** _(4 marks for i, 3 for ii)_
(i) The resulting state `< (0,1), (0,1) >` has `c1=1` and `c2=1`. The sum `c1+c2 = 2`, which is **greater than 1**, directly violating the safety property that at most one process can be in the critical section.
(ii) The **EM mechanism** (a reference monitor for mutual exclusion) would **detect** that the attempted transition leads to a violating state. It would **abort** the execution (or block the second process's entry) **before** the transition occurs, preventing the safety violation.

**(d)** _(3 marks for i, 2 for ii)_
(i) An EM mechanism enforces by **aborting** executions that show a violating finite prefix. A liveness violation ("never granted access") is not evidenced by any **finite prefix**—you cannot tell from a finite sequence that access will *never* come. Therefore, an abort-based monitor cannot enforce "eventually".
(ii) A **scheduler** or **resource manager** that actively **guarantees progress** (e.g., a fair scheduler) is needed to ensure liveness.

**(e)** _(3 marks for argument)_
An abort-based EM mechanism is **not useful** for ensuring "successful termination" (a liveness property). It can only **prevent** bad things (safety violations) from happening within the finite execution observed. It cannot **force** the program to progress to a termination state. However, it could be argued it is useful in a negative sense: it can abort if it detects an infinite loop or deadlock (if detectable via a finite prefix), but this is not general enforcement of liveness.

---
### Question 3: Policy Analysis & EM Limitations
This question involves analysing different policies for their classification and enforceability.

**(a)** For each of the following proposed security policies, **classify** it as primarily a **Safety (S)**, **Liveness (L)**, or **Neither/Other (N)** property. **Justify** each classification in one sentence.
(i) "The system must not enter a deadlock state."
(ii) "All user requests must be logged within 24 hours."
(iii) "The credit card transaction failure rate must be below 0.1%."
**[9 marks]**

**(b)** Policy: "A user can only read a file if their security clearance dominates the file's classification." (This is the BLP Simple Security rule).
(i) **Classify** this policy as **Safety** or **Liveness**.
(ii) **Explain** why this policy is **enforceable** by an EM mechanism like a reference monitor.
**[5 marks]**

**(c)** A policy states: "The program shall output the correct result for the given input."
(i) **Break down** this policy into a **safety** component and a **liveness** component.
(ii) **Discuss** the enforceability of each component via a standard EM mechanism that can only abort.
**[8 marks]**

**(d)** **Explain** the statement: "Not every security policy is a property." Use the example of a policy based on **average behaviour** or **aggregate statistics** to illustrate your explanation.
**[3 marks]**

---
#### Model Solution
**(a)** _(3 marks per item: 1 for classification, 2 for justification)_
(i) **Safety (S).** A deadlock is a "bad thing" (a specific global state) that should never occur; its occurrence is evident in a finite prefix.
(ii) **Neither/Other (N).** It involves a **timing constraint** ("within 24 hours") on an event. This is a **real-time** property, not a pure safety (bad thing never happens) or liveness (good thing eventually happens) property in the classic formal sense.
(iii) **Neither/Other (N).** It is a **statistical** property defined over an aggregate of many executions, not a predicate on individual execution sequences.

**(b)** _(2 marks for i, 3 for ii)_
(i) **Safety property.** It forbids the "bad" action of reading without sufficient clearance.
(ii) It is enforceable because the violation (a `read` action where `L(user) ≱ L(file)`) is detectable at the **finite moment** the read is attempted. A reference monitor can intercept the call, check the predicate, and **abort** (deny) the operation if it violates the policy.

**(c)** _(4 marks per part)_
(i) - **Safety Component:** "The program shall **not output an incorrect result**." (Bad thing never happens).
- **Liveness Component:** "The program shall **eventually output a (correct) result**." (Good thing eventually happens).
(ii) - **Safety Component:** **Enforceable.** An EM mechanism could, in theory, compare the output to a known-correct result (if available) and abort if they mismatch. However, this is often impractical (requires the correct result to be known a priori).
- **Liveness Component:** **Not enforceable** by an abort-only EM. The monitor cannot force the program to produce output; it can only stop it. It cannot guarantee termination.

**(d)** _(3 marks for explanation with example)_
A **property** is a predicate that is **definitively true or false for each individual execution sequence**. A policy like "average response time < 100ms" is **not a property** because its truth value cannot be assigned to a single execution—it depends on the **aggregate of many executions** over time. Therefore, it is a policy that is **not** a formal property and is not enforceable by monitoring single executions.

---
### Question 4: EM Mechanisms & the Prefix Property
This question explores the technical limits of EM based on the concept of execution prefixes and the classes of enforceable policies.

**(a)** An **Execution Monitoring (EM) mechanism** observes a target system's execution sequence.
(i) **State** the critical limitation on the EM mechanism's knowledge: what can it *only* access?
(ii) **Explain** why this limitation means a **compiler** (which analyses the entire program source) is *not* classified as an EM mechanism.
**[6 marks]**

**(b)** A **safety property** is defined as a property where any violation is evident in some **finite prefix** of an execution.
(i) **Explain** how this definition directly enables **enforcement by an EM mechanism** that can abort.
(ii) Provide a **simple example** of a non-security safety property (not from the notes) and show the violating finite prefix.
**[8 marks]**

**(c)** Consider the policy: "The system must not enter more than three distinct error states during its lifetime."
(i) **Classify** this as a **safety property** or **liveness property**. Justify your answer.
(ii) **Design** a simple **stateful monitor** that could enforce this policy. Describe what it would track and when it would abort.
**[8 marks]**

**(d)** The **liveness property** "every request is eventually granted" is not enforceable by an abort-only EM.
**Propose** a **modified EM mechanism** with *additional capabilities* beyond just aborting that *could* help enforce this liveness property in the context of mutual exclusion. Describe its action briefly.
**[3 marks]**

---
#### Model Solution
**(a)** _(3 marks per part)_
(i) It can only access the **past events** (the finite prefix) of the *current, single execution* up to the present point. It cannot see future events, alternate executions, or the program's internal structure.
(ii) A compiler has **full static knowledge** of the entire program source code and can analyse all possible execution paths before runtime. An EM mechanism only observes the **dynamic, unfolding runtime behaviour** of one execution.

**(b)** _(4 marks per part)_
(i) Because the violation becomes apparent at the *end* of that finite violating prefix. The EM mechanism, observing events in real-time, can detect the violation as soon as the prefix completes and then **abort** the execution before any further (violating) actions occur.
(ii) **Example:** "A robot must never move more than 10 meters from its start point."
**Violating Finite Prefix:** The sequence of move actions that results in the robot's calculated position being 10.01 meters from start. The violation is clear at the end of that sequence.

**(c)** _(4 marks per part)_
(i) **Safety property.** The "bad thing" (entering a fourth distinct error state) would be evident in the finite prefix where the fourth error state is entered. The property demands the *absence* of that event.
(ii) **Monitor Design:** The monitor maintains a **set** (or counter) of distinct error state identifiers encountered. On each state transition, if the new state is an error state not already in the set, it adds it. If the size of the set becomes **greater than 3**, the monitor **aborts** the execution.

**(d)** _(3 marks for feasible proposal)_
A **scheduler-integrated monitor** that, upon detecting that a process has been in the "requesting" state for an *unreasonably long* time (suggesting potential starvation), could **intervene** by **temporarily elevating the priority** of that process or **forcing a resource grant**, rather than just aborting. This extends the EM mechanism's capability from pure prevention to active remediation.

---
### Question 5: Formal Modelling & Policy Satisfaction
This question involves working with the formal notation of executions, policies, and target systems.

**(a)** Let $E$ be the set of all possible finite and infinite execution sequences of a system. Let $T$ be a specific target system. Let $P$ be a policy.
(i) **Interpret** the formal statement: $E(T) \subseteq E$.
(ii) **Interpret** the formal statement: $P(E(T)) = \text{True}$.
**[6 marks]**

**(b)** Consider a simple system with actions {A, B, C}. Its complete set of possible executions $E$ includes sequences like `A B C`, `A A B`, `C B A`, etc. A target system $T_1$ can only produce executions starting with 'A'. A policy $P_1$ states: "Action B must never occur."
(i) Is $P_1$ a **property** of $T_1$?
(ii) **Justify** your answer by referencing the definitions of $E(T_1)$ and $P_1$.
**[7 marks]**

**(c)** A policy $P_2$ states: "Action C must occur at least once."
(i) **Classify** $P_2$ as a **safety** or **liveness** property. Justify.
(ii) A target system $T_2$ has $E(T_2) = \{ \text{A B}, \text{A A B}, \text{A A A B}, ... \}$ (infinite sequences ending in B, no C). Does $T_2$ **satisfy** $P_2$? Explain why or why not.
**[8 marks]**

**(d)** The notes conclude: "Policies are properties that can be enforced via monitoring."
**Explain** the logical flow of this conclusion, connecting the concepts of:
1. Policy as a predicate on executions ($P(E)$).
2. The need for the policy to be a **property** ($P'(e)$ for all $e$ in $E(T)$).
3. The **enforceability** requirement (detectable violation in a finite prefix).
**[4 marks]**

---
#### Model Solution
**(a)** _(3 marks per interpretation)_
(i) The set of all execution sequences that the specific target system $T$ can actually produce is a **subset** of the universal set of all sequences the abstract system model could possibly produce.
(ii) Applying the predicate (policy) $P$ to the set $E(T)$ yields True. This means **every single execution sequence** that $T$ can produce is deemed acceptable by the policy $P$. Therefore, the system $T$ **satisfies** the policy $P$.

**(b)** _(3 marks for i, 4 for justification)_
(i) **Yes**, $P_1$ is a property of $T_1$.
(ii) $E(T_1)$ contains only executions starting with 'A' and, by the system definition, may or may not include B. However, policy $P_1$ rules out any execution containing B. For $P_1$ to be a property of $T_1$, **every** execution in $E(T_1)$ must satisfy $P_1$. If $T_1$ is defined such that it *can* produce an execution with a B (e.g., `A B C`), then $P_1(E(T_1))$ would be False, and it would not be a property. The question suggests $T_1$'s behaviour is constrained. If $T_1$ **cannot** produce any execution with B, then all executions in $E(T_1)$ satisfy "B never occurs", making $P_1$ a property of $T_1$.

**(c)** _(4 marks per part)_
(i) **Liveness property.** It states that a "good thing" (action C) must **eventually happen**. A violation (C never occurs) cannot be determined from any finite prefix, as C might still happen in the future.
(ii) **No**, $T_2$ does **not** satisfy $P_2$. The set $E(T_2)$ contains only infinite sequences that **never** contain action C. Therefore, **for every execution** $e$ in $E(T_2)$, the predicate "C occurs at least once" is false. Hence, $P_2(E(T_2)) = \text{False}$.

**(d)** _(4 marks for logical flow)_
For monitoring, we need a clear rule to abort. 1. A policy must first be a well-defined predicate $P$ on sets of executions. 2. To be meaningful for a specific system $T$, it must be a **property** of $T$—i.e., it must hold consistently for *all* of $T$'s possible executions ($P'(e)$ true for all $e$ in $E(T)$). 3. For runtime enforcement, a violation must be **decidable upon observation**; this is only possible if the property is a **safety** (or similar) property, where a violating finite prefix exists. Therefore, enforceable policies are exactly those that are **properties** of the system and belong to the class of **safety properties** (or co-safety properties) monitorable via finite prefixes.
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
### Question 1: Firewall Rules & Core Problems
This question tests understanding of basic firewall concepts, rule analysis, and the three core problems.

**(a)** A firewall processes packets as 5-tuples: (Interface, Source IP, Destination IP, Destination Port, Protocol). It uses the following rules in order:
1. `(I=0) ∧ (S=any) ∧ (D=Web_Server) ∧ (N=443) ∧ (P=TCP) → accept`
2. `(I=0) ∧ (S∈Blacklist) ∧ (D=any) ∧ (N=any) ∧ (P=any) → discard`
3. `(I=1) ∧ (S=any) ∧ (D=any) ∧ (N=any) ∧ (P=any) → accept`
4. `(I=any) ∧ (S=any) ∧ (D=any) ∧ (N=any) ∧ (P=any) → accept`

(i) A packet arrives from a **Blacklist** IP to the **Web_Server** on port **443**. **Deduce** its fate (accept/discard) and explain which rule determines this.
(ii) **Identify** which of the three core firewall problems (Consistency, Completeness, Compactness) is demonstrated by this interaction between rules 1 and 2.
**[6 marks]**

**(b)** **Define** the following terms in the context of a firewall rule list:
(i) Two rules **overlap**.
(ii) Two rules **conflict**.
(iii) A rule is **redundant**.
**[6 marks]**

**(c)** For the rule list in part (a):
(i) **Identify** a **completeness** problem. Describe a *type of packet* that the default rule (4) would handle, but which should likely be denied for security reasons.
(ii) Propose a **new rule** to fix this problem and state where it should be inserted.
**[6 marks]**

**(d)** Rule 3 in the list accepts all outgoing traffic from the private network (I=1).
(i) **Explain** why rule 3 is **redundant** in the presence of rule 4.
(ii) **State** the impact of this redundancy on firewall **performance**.
**[4 marks]**

**(e)** The number of possible orderings for N firewall rules is N! (factorial). **Explain** why this combinatorial explosion makes designing a correct, efficient rule list by manual trial-and-error practically impossible for large N.
**[3 marks]**

---
#### Model Solution
**(a)** _(4 marks for i, 2 for ii)_
(i) **Accepted.** The packet matches rule 1's predicate (I=0, D=Web_Server, N=443, P=TCP) *and* rule 2's predicate (I=0, S∈Blacklist). Because rule 1 is first and has decision `accept`, the packet is accepted.
(ii) **Consistency Problem.** Rules 1 and 2 **conflict** (they overlap on this packet and have different decisions). The order is critical and may lead to an unintended security policy (allowing malicious traffic).

**(b)** _(2 marks per definition)_
(i) **Overlap:** There exists at least one packet that matches the predicates of both rules.
(ii) **Conflict:** The rules overlap **and** have different decisions (`accept` vs `discard`).
(iii) **Redundant:** Removing the rule does **not change the decision** of the firewall for any possible packet.

**(c)** _(3 marks per part)_
(i) **Completeness Problem:** The default rule accepts *any* packet not caught earlier. For example, a packet `(I=0, S=any, D=Web_Server, N=80, P=TCP)` (HTTP to web server) would be accepted by rule 4. This is problematic if the web server should only serve HTTPS (port 443), as HTTP traffic could be malicious or indicative of misconfiguration.
(ii) **New Rule:** `(I=0) ∧ (S=any) ∧ (D=Web_Server) ∧ (N=80) ∧ (P=TCP) → discard`. Insert it **immediately after rule 1** to take precedence over the default rule.

**(d)** _(2 marks per part)_
(i) Any packet matching rule 3 (I=1) **also** matches rule 4 (I=any). Since both rules have the same decision (`accept`), rule 3 has no effect; packets from I=1 will be accepted by rule 4 if rule 3 is removed.
(ii) It causes **unnecessary processing** (low-level performance overhead) as the firewall checks rule 3 before reaching rule 4. It also increases the **size** of the rule set, which is critical for hardware (TCAM) firewalls with limited space and higher power consumption per rule.

**(e)** _(3 marks for explanation)_
The search space for the correct order grows **factorially** with N. For N=10, there are 3.6 million orderings; for N=20, ≈2.4×10¹⁸. Manually evaluating even a tiny fraction for correctness, consistency, and completeness is infeasible. This necessitates **structured design methods** (like FDDs) and automated analysis tools.

---
### Question 2: Firewall Decision Diagrams (FDDs)
This question covers the structure, properties, and interpretation of FDDs.

**(a)** A **Firewall Decision Diagram (FDD)** is defined over packet fields $F_1 ... F_n$.
(i) **State** the two possible labels for a **terminal node**.
(ii) For a **non-terminal node** labelled with field $F_i$, what must be true about the sets $I(e)$ labelling its outgoing edges $e$? Provide **two** conditions.
**[5 marks]**

**(b)** Consider the following FDD fragment for fields $F_1, F_2$ with domains {1..10}:
*   Root node `v1` labelled $F_1$.
*   From `v1`, edge labelled {1,2,3} points to node `v2` (labelled $F_2$).
*   From `v1`, edge labelled {4,5,6,7,8,9,10} points to terminal node `d` (discard).
*   From `v2`, edge labelled {1,2} points to terminal node `a` (accept).
*   From `v2`, edge labelled {3,4,5,6,7,8,9,10} points to terminal node `d`.
(i) For a packet $(F_1=2, F_2=4)$, **trace** the path through the FDD and state the final decision.
(ii) **List** the **decision path** for the packet that results in `accept`.
**[8 marks]**

**(c)** The **Theorem of FDDs** states: for any FDD $f$,
1. $f$.accept $\cap$ $f$.discard = $\emptyset$.
2. $f$.accept $\cup$ $f$.discard = $\Sigma$.
**Explain** what each part of this theorem guarantees about the firewall policy represented by the FDD. Use the terms **consistency** and **completeness**.
**[4 marks]**

**(d)** **Explain** the relationship between an FDD and a firewall rule list. Specifically, how does the **number of decision paths** in an FDD relate to the **number of rules** in an equivalent firewall?
**[3 marks]**

**(e)** In the FDD from part (b), are the two terminal nodes `a` and `d` **isomorphic**? Justify your answer using the definition of isomorphic nodes.
**[5 marks]**

---
#### Model Solution
**(a)** _(2 marks for i, 3 for ii - 1.5 per condition)_
(i) `accept` or `discard`.
(ii) 1. **Consistency:** For any two distinct edges $e, e'$, $I(e) \cap I(e') = \emptyset$ (no overlapping values).
2. **Completeness:** $\bigcup_{e \in E(v)} I(e) = D(F_i)$ (the union of all edge labels covers the entire domain of field $F_i$).

**(b)** _(4 marks for i, 4 for ii)_
(i) Packet (F1=2, F2=4).
- At `v1` (F1): 2 ∈ {1,2,3} → follow edge to `v2`.
- At `v2` (F2): 4 ∈ {3,4,5,6,7,8,9,10} → follow edge to terminal node `d`.
**Decision: discard.**
(ii) **Decision path for `accept`:** $\langle v_1, e_1, v_2, e_2, a \rangle$ where:
- $v_1$ is F1 node.
- $e_1$ is edge with $I(e_1) = \{1,2,3\}$.
- $v_2$ is F2 node.
- $e_2$ is edge with $I(e_2) = \{1,2\}$.
- $a$ is accept terminal node.
The corresponding condition is $F_1 \in \{1,2,3\} \land F_2 \in \{1,2\} \rightarrow \text{accept}$.

**(c)** _(2 marks per part)_
1. Guarantees **Consistency:** No packet can be classified as both `accept` and `discard`. The sets of packets leading to each decision are **disjoint**.
2. Guarantees **Completeness:** Every possible packet in $\Sigma$ (the universe of all packets) is classified as either `accept` or `discard`. There are no "holes" or unclassified packets.

**(d)** _(3 marks for explanation)_
Each **decision path** from the root to a terminal node in an FDD corresponds to **exactly one firewall rule**. The predicate of the rule is the conjunction of the field constraints defined by the edges on the path. Therefore, the **number of rules** in an equivalent firewall equals the **number of decision paths** in the FDD.

**(e)** _(5 marks for correct justification)_
**No.** According to the definition, two terminal nodes are isomorphic **iff** they have **identical labels**. Node `a` is labelled `accept`, and node `d` is labelled `discard`. These labels are **not identical**, therefore the nodes are **not isomorphic**.

---
### Question 3: FDD Reduction & Isomorphism
This question focuses on Algorithm 1 for reducing an FDD by removing single-edge nodes and merging isomorphic nodes.

**(a)** **Isomorphic nodes** are central to FDD reduction.
(i) **State** the condition for two **terminal nodes** to be isomorphic.
(ii) **State** the condition for two **non-terminal nodes** (labelled with fields) to be isomorphic.
**[4 marks]**

**(b)** An FDD is **reduced** iff it satisfies three conditions.
**List** these three conditions.
**[3 marks]**

**(c)** Consider the following FDD fragment:
- Node $u$ (labelled $F_1$) has a **single outgoing edge** labelled {1,2,3} pointing to node $w$ (labelled $F_2$).
- Node $w$ has two outgoing edges: {1}→`accept` and {2,3}→`discard`.
Apply **Algorithm 1, Step 1** to this fragment.
(i) **Describe** the transformation.
(ii) Draw or describe the resulting structure **after** the step.
**[5 marks]**

**(d)** Consider a different FDD fragment:
- Node $x$ (labelled $F_2$) has edges: {1,2}→`accept`, {3,4}→`accept`, {5}→`discard`.
- Node $y$ (labelled $F_2$) has edges: {1,2}→`accept`, {3,4}→`accept`, {5}→`discard`.
Nodes $x$ and $y$ are isomorphic.
(i) **Apply** **Algorithm 1, Step 2** (merging isomorphic nodes). Describe the action.
(ii) What is the impact of this step on the total **number of nodes** and **number of decision paths** in the FDD?
**[6 marks]**

**(e)** **Explain** the purpose of **Algorithm 1, Step 3**, which merges multiple edges between the same pair of nodes. How does this step contribute to producing a **reduced FDD**?
**[4 marks]**

---
#### Model Solution
**(a)** _(2 marks per part)_
(i) Two terminal nodes are isomorphic **iff** they have the **same label** (both `accept` or both `discard`).
(ii) Two non-terminal nodes $v$ and $v'$ are isomorphic **iff** 1. They are labelled with the **same field** $F(v)=F(v')$, and 2. There is a **one-to-one correspondence** between their outgoing edges such that corresponding edges have **identical labels** $I(e)$ and point to **isomorphic** child nodes.

**(b)** _(1 mark per condition)_
1. No node has only **one outgoing edge**.
2. No **two nodes** are isomorphic.
3. No **two edges** connect the same pair of nodes.

**(c)** _(3 marks for i, 2 for ii)_
(i) Step 1 removes node $u$ and its single outgoing edge. The parent(s) of $u$ will now have their edges pointing directly to $w$ instead.
(ii) **Result:** The parent(s) of $u$ now have an edge labelled {1,2,3} pointing directly to node $w$ (F2). Node $u$ and its edge are deleted.

**(d)** _(4 marks for i, 2 for ii)_
(i) Step 2 removes node $y$ and all its outgoing edges. Any edge(s) that previously pointed to $y$ are **redirected** to point to $x$ instead.
(ii) **Impact:** The **number of nodes** decreases by 1 (and associated edges are removed/redirected). The **number of decision paths** remains **unchanged** because the logical mapping from packets to decisions is preserved; the structure is simply consolidated.

**(e)** _(4 marks for explanation)_
Step 3 merges two edges $e$ and $e'$ between the same nodes $v$ and $v'$ into a **single edge** $e''$ with label $I(e'') = I(e) \cup I(e')$. This contributes to a **reduced FDD** by eliminating redundant structural complexity (multiple edges representing disjoint subsets of the same field's domain). It ensures the **"no two edges between the same pair of nodes"** condition is met, simplifying the graph without changing its semantic function.

---
### Question 4: FDD Marking & Load Calculation
This question covers Algorithm 2 (Marking) and the calculation of load for generating efficient simple rules.

**(a)** A **marked FDD** is identical to a base FDD except for one addition.
(i) **What** is added to exactly one outgoing edge of each non-terminal node?
(ii) **State** the purpose of creating a marked FDD in the structured firewall design process.
**[4 marks]**

**(b)** The **load** of a non-empty set of integers $S$, $load(S)$, is defined.
(i) **Define** $load(S)$.
(ii) **Calculate** $load(\{1, 3, 4, 5, 7, 8, 9\})$.
**[4 marks]**

**(c)** The load of an **edge** $e$ in a marked FDD is:
\[
load(e) = \begin{cases}
1 & \text{if } e \text{ is marked "all"} \\
load(I(e)) & \text{otherwise}
\end{cases}
\]
The load of a **node** $v$ is defined recursively.
(i) What is $load(v)$ if $v$ is a **terminal node**?
(ii) If $v$ is a non-terminal node with $k$ outgoing edges $e_1...e_k$ pointing to nodes $v_1...v_k$, state the formula for $load(v)$.
**[4 marks]**

**(d)** Consider a non-terminal node $v$ (field $F$) with two outgoing edges:
- Edge $e_1$: label {1,2,3}, points to node $v_1$ where $load(v_1)=2$.
- Edge $e_2$: marked "all", points to node $v_2$ where $load(v_2)=1$.
Assume $D(F) = \{1,2,3,4,5\}$.
(i) **Calculate** $load(e_1)$ and $load(e_2)$.
(ii) **Calculate** $load(v)$. Show your working.
**[6 marks]**

**(e)** **Algorithm 2.5** aims to find a marked FDD with **minimum load**.
(i) **Explain** why minimizing the load of the **root node** is the objective.
(ii) **Describe** the high-level strategy of the algorithm: how does it decide which edge of a node to mark as "all"?
**[7 marks]**

---
#### Model Solution
**(a)** _(2 marks per part)_
(i) A mark of **"all"**.
(ii) To **order the traversal** of edges during firewall rule generation (Algorithm 3). The "all" edge is traversed last, which minimizes the number of resulting **simple rules** derived from the FDD.

**(b)** _(2 marks per part)_
(i) $load(S)$ is the **minimum number of non-overlapping integer intervals** whose union equals $S$.
(ii) $S = \{1, 3, 4, 5, 7, 8, 9\}$. Intervals: [1,1], [3,5], [7,9]. **$load(S) = 3$**.

**(c)** _(2 marks per part)_
(i) $load(v) = 1$ for a terminal node.
(ii) $load(v) = \sum_{i=1}^{k} (load(e_i) \times load(v_i))$.

**(d)** _(3 marks per part)_
(i) - $load(e_1) = load(\{1,2,3\})$. {1,2,3} is a single interval [1,3], so $load(e_1)=1$.
- $load(e_2) = 1$ (because it is marked "all").
(ii) $load(v) = (load(e_1) \times load(v_1)) + (load(e_2) \times load(v_2)) = (1 \times 2) + (1 \times 1) = 2 + 1 = 3$.

**(e)** _(4 marks for i, 3 for ii)_
(i) The load of the **root node** is defined as the **load of the entire marked FDD**. Since the number of generated **simple rules** is equal to this load, minimizing the root's load directly minimizes the firewall's rule count.
(ii) The algorithm works **bottom-up**. For each non-terminal node, it calculates the load for each possible choice of which outgoing edge to mark "all". It then **marks the edge whose selection results in the smallest load for that node**. This greedy/local choice, applied recursively, aims to produce the globally minimal load FDD.

---
### Question 5: Rule Generation & Firewall Compaction
This question covers generating rules from a marked FDD (Algorithm 3) and the concept of rule redundancy (Algorithm 4).

**(a)** **Algorithm 3** generates firewall rules from a marked FDD via a depth-first traversal.
(i) **State** the traversal rule regarding the edge marked **"all"** at each node.
(ii) Each produced rule corresponds to one ______? (Complete the sentence).
**[4 marks]**

**(b)** From a marked FDD, a decision path is:
$\langle v_1(F_1), e_1(\{2,3\}), v_2(F_2), e_2(\text{"all"}), v_3(\text{discard}) \rangle$.
Domains: $D(F_1)=\{1..10\}, D(F_2)=\{1..10\}$.
**Write** the firewall rule $r$ generated from this path. Use the format: $F_1 \in S_1 \land F_2 \in S_2 \rightarrow \text{decision}$.
**[4 marks]**

**(c)** For a generated rule $r$, we define $r.mp$ (matching predicate) and $r.rp$ (resolving predicate).
(i) **Explain** the purpose of the **resolving predicate** $r.rp$ in the context of detecting redundant rules.
(ii) In the rule from part (b), would $r.rp$ be **different** from $r.mp$? Justify your answer.
**[6 marks]**

**(d)** **Algorithm 4** (Firewall Compaction) removes redundant rules.
(i) **Define** a **redundant rule** in terms of its $r.mp$ and the $r.rp$ of rules preceding it in the list.
(ii) **Explain** why removing redundant rules is important for firewall implementations using **TCAM**.
**[6 marks]**

**(e)** Consider two consecutive rules in a generated firewall:
$r_i: F_1 \in [1,5] \land F_2 \in [1,10] \rightarrow \text{accept}$
$r_{i+1}: F_1 \in [6,10] \land F_2 \in [1,10] \rightarrow \text{accept}$
Could these two rules be **combined** into a single, simpler rule without changing firewall semantics? If yes, give the combined rule.
**[5 marks]**

---
#### Model Solution
**(a)** _(2 marks per part)_
(i) At each non-terminal node, **all non-"all" edges are traversed first**, then the edge marked "all" is traversed last.
(ii) Each produced rule corresponds to one **decision path** from the root to a terminal node.

**(b)** _(4 marks for correct rule)_
$r: F_1 \in \{2,3\} \land F_2 \in \{1,2,3,4,5,6,7,8,9,10\} \rightarrow \text{discard}$.
*(Or $F_2 \in [1,10]$)*.

**(c)** _(3 marks per part)_
(i) The **resolving predicate** $r.rp$ defines the **set of packets for which rule $r$ is the *first* matching rule**. It is $r.mp$ **minus** the union of the matching predicates of all preceding rules. It identifies the rule's *actual effect*.
(ii) **Yes, $r.rp$ would be different.** Because $e_2$ is marked "all", $S_2$ in $r.mp$ is the full domain $D(F_2)$. However, $r.rp$ would exclude any packets matched by rules generated from paths that took non-"all" edges from $v_2$. This typically makes $r.rp$'s condition for $F_2$ a **subset** of the full domain.

**(d)** _(3 marks per part)_
(i) A rule $r_i$ is redundant if its **resolving predicate $r_i.rp$ is empty**, meaning no packet has $r_i$ as its first match. Equivalently, if $r_i.mp$ is **completely covered** by the union of $r_j.mp$ for all $j < i$.
(ii) **TCAM** (Ternary Content Addressable Memory) stores rules in hardware for fast matching. It has **limited size** and **high power consumption** proportional to the number of rules. Removing redundant rules **saves space** and **reduces power**, directly improving performance and cost.

**(e)** _(5 marks: 1 for yes, 4 for combined rule)_
**Yes.** The rules are contiguous and have the same decision. They can be combined by taking the union of their predicates for $F_1$.
**Combined Rule:** $F_1 \in [1,10] \land F_2 \in [1,10] \rightarrow \text{accept}$.
# Previous Material
[2024/25](file:///home/andreas/Downloads/COMP3911/exam/main-comp3911.pdf)
[2023/24](file:///home/andreas/Downloads/COMP3911/exam/comp3911-exam-q-2324.pdf)[file:///home/andreas/Downloads/COMP3911/exam/sample-questions.pdf](sample)