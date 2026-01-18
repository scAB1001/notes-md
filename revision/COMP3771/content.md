# Topic 1: General Architecture of User-Adaptive Systems
## 1.1 Introduction & Importance of Personalisation

> **Personalisation** is the tailoring of a system's interface, information, or functionality to an **individual user's needs, preferences, or context**.

**Drivers for Personalisation:**
1.  **Information**: **Abundance, heterogeneity, noise**, and delivery **constraints** (time, bandwidth).
2.  **People**: **Diverse capabilities, backgrounds, tasks, goals, intentions**, and **affective states** (mood).
3.  **Context**: Physical environment, device, social setting.

> **Core Principle**: **One size does not fit all**. The goal is to deliver the **right information**, to the **right person**, at the **right time**, in the **right way**.

### Types of Personalisation
| Type | Definition | Control | Example |
| :--- | :--- | :--- | :--- |
| **User-Adaptable (Customisable)** | User **manually modifies** system aspects. | **User-controlled**. | Changing phone home screen layout, theme colours. |
| **User-Adaptive** | System **automatically modifies** its behaviour based on user data. | **System-controlled**. | Netflix recommendations, Google search ranking. |
| **Intermediate/Mixed-Initiative** | System **proposes** adaptations; user **accepts/rejects**. | **Shared control**. | "Would you like to switch to dark mode?" prompt. |

> **User-Adaptive Systems** are the core focus of this module. They require **machine intelligence** to perform **user modelling** and **adaptation**.

**Key Examples:**
- **MoCoMapps (IBM)**: A travel app that adapts maps and recommends points of interest (e.g., bike racks) based on user's location and interests.
- **ECoach (Univ. Michigan)**: A personalised coaching system for students, providing adaptive study plans, motivational messages, and wellbeing tips based on academic data and psychometric profiles.
- **YouTube/Netflix**: Recommends media based on watch history, clicks, and metadata.

### Core Module Learning Objectives (LOs)
- **LO1**: Apply HCI methodology to **design & evaluate** adaptive systems.
- **LO2**: Identify & apply common **user modelling & adaptation** techniques.
- **LO3**: **Implement recommender system** techniques.
- **LO4**: Reason about the **significance & future** of the field.

---
#### **Exam Practice Question 1.1**
**Using the examples of *MoCoMapps* and *ECoach*, contrast how they demonstrate the principle of delivering the "right information at the right time".**
**[4 marks]**

**Model Answer**:
Both systems deliver contextually relevant information. **MoCoMapps** delivers the *right information* (nearby bike racks/restaurants) at the *right time* (when the user is mobile and in a specific location), adapting to **physical context**. **ECoach** delivers the *right information* (personalised study materials) at the *right time* (e.g., before an exam or when a student's engagement drops), adapting to **temporal and behavioural context**. The "right way" differs: MoCoMapps adapts a map interface, while ECoach adapts textual advice and reminders.

---
## 1.2 General Architecture & Main Components

> The **generic architecture** of a user-adaptive system defines the core components and data flows required for adaptation.

![[generic-adaptive-architecture.png|500]]
*(Diagram showing: User -> [User Data Gathering] -> [User Model] <-> [Domain Model] -> [Adaptation Model] -> [Adaptive Component] -> User)*

### Component Roles & Importance
1.  **User Data Gathering (Sensor/Input)**
    - **Role**: Collects **raw data** about the user. The input to the entire process.
    - **Importance**: Quality and validity of data determines overall system success.
    - **Methods**: Explicit (forms, ratings) and Implicit (clicks, dwell time, logs).

2.  **User Model (Core Representation)**
    - **Role**: An internal, structured **representation of beliefs** about the user (knowledge, preferences, goals, traits).
    - **Importance**: It is the system's "understanding" of the user; all adaptations are based on it.
    - **Format**: Often a set of `<attribute, value>` pairs, a vector, or a set of rules.

3.  **Domain Model (World Knowledge)**
    - **Role**: A representation of the **application domain**—its concepts, relationships, and constraints.
    - **Importance**: Provides the "vocabulary" for the user model and defines what *can* be adapted. Essential for **content-based** techniques.
    - **Example**: In music: concepts = {Song, Artist, Genre}; relationships = {Song *hasGenre* Genre, Artist *creates* Song}.

4.  **Adaptation Model (Decision Engine)**
    - **Role**: Contains the **logic/rules/algorithm** that decides *if*, *what*, and *how* to adapt. Uses the User Model and Domain Model as input.
    - **Importance**: The "brain" of the adaptive system. Embodies the adaptation strategy (e.g., recommendation algorithm, rule-based planner).

5.  **Adaptive Component (Effector/Output)**
    - **Role**: The part of the system **presented to the user** that changes (interface, content, functionality).
    - **Importance**: The tangible manifestation of adaptation. Must be usable and effective.

### Data Flow & Process
The process is a **cycle**: (1) Gather data, (2) Update user model, (3) Adaptation model uses user & domain models to decide on adaptation, (4) Adaptive component changes, (5) User interacts, generating new data.

---
#### **Exam Practice Question 1.2**
**For a news website that personalises its front page, describe the likely contents of its *Domain Model* and explain how the *Adaptation Model* might use it together with the *User Model*.**
**[5 marks]**

**Model Answer**:
The **Domain Model** would contain entities like **Article**, **Topic** (e.g., Politics, Sports), **Author**, and **Publisher**. It would define attributes (article length, publication date) and relationships (Article *isAbout* Topic, Article *writtenBy* Author). The **Adaptation Model** (e.g., a content-based filtering algorithm) would use this to compare the **User Model** (a vector of the user's inferred interest in each Topic) with each candidate Article's topic vector (from the Domain Model). It would then calculate a similarity score and select the highest-scoring articles for the adaptive component (the personalised front page).
## 1.2 General Schema & Applied Examples

> **General Schema**: The **conceptual blueprint** defining the main components and data flow in any user-adaptive system.

### Core Schema Components (Detailed)
1.  **User Data Gathering (Information About User)**: The **input sensor**. Collects raw data.
2.  **User Model Acquisition (Computer Process)**: The **inference engine**. Processes raw data to create/update the **user model**.
3.  **User Model (Data Repository)**: The **structured belief** about the user. A persistent store.
4.  **User Model Application (Computer Process)**: The **decision engine**. Uses the user model to decide on and generate adaptations.
5.  **Adaptive Component (Adapting to User)**: The **output effector**. The changed interface/content presented to the user.
![[generic-adaptive-architecture.png]]
### Importance of Each Component
- **User Model is the most critical component**. It is the system's **knowledge** of the user. If it is **inaccurate or poorly constructed**, all subsequent adaptations will be flawed, regardless of the sophistication of the application logic. It is the **central link** between observation (acquisition) and action (application).

### Applied Schema Examples
| System                      | User Data Gathered                       | User Model (Acquisition)                                                                           | Adaptation (Application)                                                            | Adaptive Component                                  |
| :-------------------------- | :--------------------------------------- | :------------------------------------------------------------------------------------------------- | :---------------------------------------------------------------------------------- | :-------------------------------------------------- |
| **Smart Menus (MS Office)** | Menu item clicks, use of expand arrows.  | Frequency/recency of command use.                                                                  | Promotes frequently/recently used commands to main menu.                            | Modified menu layout.                               |
| **SQL-Tutor**               | Student's problem-solving steps, errors. | Overlay model of student's knowledge vs. expert domain model.                                      | Selects next practice problem targeting knowledge gaps.                             | Personalised problem sequence.                      |
| **BBC iPlayer**             | Program views, clicks, search history.   | Vector of inferred genre/topic preferences.                                                        | Ranks/promotes programs in catalogue based on preference similarity.                | "Recommended for you" rows.                         |
| **Amazon**                  | Purchases, clicks, ratings, browsing.    | **Collaborative Filtering**: User-Item rating matrix. **Content-Based**: Item feature preferences. | Computes item scores via CF (users like you) and CBF (items like those you bought). | "Today's Recommendations", "Customers also bought". |

| Smart Menus (MS Office)                           | SQL-Tutor and BBC iPlayer                                |
| ------------------------------------------------- | -------------------------------------------------------- |
| ![[generic-adaptive-arch-smart-menu-ex.png\|400]] | ![[generic-adaptive-arch-smart-sql-tutor-ex.png\|400]]   |
|                                                   | ![[generic-adaptive-arch-smart-bbc-iplayer-ex.png\|400]] |

---
#### **Exam Practice Question 1.3**

| Amazon                                              | Example                                               |
| --------------------------------------------------- | ----------------------------------------------------- |
| ![[generic-adaptive-arch-smart-amazon-ex.png\|400]] | ![[generic-adaptive-arch-smart-amazon-ex-2.png\|400]] |
**Using the *Amazon* example from the schema diagram, describe what happens in the "User Model Acquisition" step when a user clicks on a product but does not buy it. What is a potential challenge in interpreting this data?**
**[4 marks]**

**Model Answer**:
In **User Model Acquisition**, the click is likely converted into a **positive implicit rating** (e.g., an indication of interest) and stored in the user-item interaction matrix or used to update a content-based preference profile. The challenge is **interpretation validity**: a click may indicate interest, but it could also be a mistake, a result of misleading imagery, or mere curiosity without purchase intent. Relying solely on clicks can lead to a **noisy and inaccurate user model**.

---
## 1.3 Types of User-Adaptivity Support

Adaptive systems provide two broad classes of support:

### 1. Supporting System Use
Aims to make **interaction with the system itself** more efficient.
- **Taking over routine tasks**: Email filtering, automated form filling.
- **Adapting the interface**: Smart menus, adaptive toolbars.
- **Helping with system use**: Intelligent help systems, adaptive documentation.
- **Mediating interaction with the real world**: Managing interruptions (e.g., LILSYS call screening), controlling smart home devices.
- **Controlling a dialogue**: Conversational agents, automated phone systems.

### 2. Supporting Information Acquisition
Aims to help users **find and understand information or products**.
- **Helping users to find information**: Personalised search, adaptive news feeds.
- **Recommending products**: E-commerce recommenders (Amazon, Netflix).
- **Tailoring information presentation**: Adaptive educational content, health info.
- **Supporting collaboration**: Matching team members, adapting shared workspaces.
- **Supporting learning**: Intelligent Tutoring Systems (ITS) like SQL-Tutor.

### Case Studies from Reading
**LILSYS (Call Screening System):**
- **Information Collected**: Caller ID, time of day, user's current activity (via sensors), manually entered user availability.
- **Privacy Concern**: **Continuous monitoring** of user's presence and activity is highly intrusive.
- **Contemporary Similar System**: Modern smartphone "Do Not Disturb" or "Focus" modes, which use calendar, location, and activity to filter notifications.

**AGENTSALON (Conversational News Agent):**
- **Information Collected**: User's stated interests, feedback on presented news stories.
- **Contemporary Similar System**: AI news curators (e.g., Google News) or conversational agents (e.g., Alexa briefings) that learn preferences.
- **Similarities to LILSYS**: Both (1) build a **user model**, (2) use it to **filter information** (calls/news), and (3) aim to reduce **user effort/cognitive load**.
- **Differences from LILSYS**: LILSYS mediates **real-world interactions** (calls), AGENTSALON mediates **information access**. LILSYS uses more **sensor data**; AGENTSALON relies more on **explicit preferences**. LILSYS's adaptations are more **critical** (missing an important call).

### Major Usability Threats (Challenges)
Adaptivity introduces key **usability threats** that must be designed against:
1.  **Diminished Predictability & Comprehensibility**: User doesn't understand *why* the system behaved as it did.
2.  **Diminished Controllability**: User feels loss of control over the system.
3.  **Obtrusiveness**: Adaptations interrupt and distract from the primary task.
4.  **Infringement of Privacy**: Data collection and usage concerns.
5.  **Diminished Breadth of Experience**: "**Filter Bubble**" – user is only exposed to things similar to past choices, limiting discovery.

---
#### **Exam Practice Question 1.4**
**The *LILSYS* system screens phone calls based on the user's context. Identify *two* of the major usability threats this adaptivity could cause and briefly explain each in the context of call screening.**
**[4 marks]**

**Model Answer**:
1.  **Diminished Controllability**: The user may feel they have lost control over their own communications if the system incorrectly screens out an important call (e.g., a job interview callback) based on its autonomous decision.
2.  **Infringement of Privacy**: The system's need to **continuously monitor** the user's activity (via sensors) to infer availability constitutes a significant **privacy invasion**, as it creates a log of the user's presence and actions in their own home.