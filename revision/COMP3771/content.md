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
