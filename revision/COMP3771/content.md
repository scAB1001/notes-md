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
# Topic 1: General Schema of User-Adaptive Systems (Practical Applications)

## 1.4 Applied Analysis & System Design

This section reinforces the **general schema** through practical case studies and design exercises, highlighting how theoretical components map to real-world systems and their associated challenges.

### Case Study 1: LILSYS (Call Screening System)

![[generic-adaptive-architecture.png|500]]
*(Focus on components for LILSYS: Sensors gather data, model decides on call handling, system adapts by ringing/blocking)*

> **Main Purpose**: To act as an **intelligent secretary**, screening incoming phone calls based on the user's **current context and inferred availability**, minimizing disruptive interruptions.

**Information Collected (User Data Gathering):**
*   **Implicit/Sensor Data**: Physical environment sensors (movement in room, door open/closed), user activity (keyboard/mouse activity, phone off-hook).
*   **Explicit/Stored Data**: Calendar entries (meetings).
*   **Explicit User Input**: Manual "on/off" or "inactive" switches.

**Concerns & Challenges:**
1.  **Privacy & Ethics**: The system performs **continuous, pervasive monitoring** of the user's presence and actions in their private space. This creates a detailed behavioural log, raising significant **surveillance concerns**.
2.  **Reliability & Latency**: Sensor data can be noisy (movement doesn't equal availability), and processing delays could cause a call to be wrongly blocked or allowed.
3.  **Transparency & Controllability**: The user may not understand why a specific call was blocked, leading to frustration and a **loss of control** over their own communications.

**Contemporary Similar Systems**: Modern smartphone **"Focus" or "Do Not Disturb" modes** that use calendar, location, and device usage activity to automatically filter notifications and calls.

### Case Study 2: AGENTSALON (Conversational Matchmaking System)

![[generic-adaptive-architecture.png|500]]
*(Focus on components for AGENTSALON: User input/stored data informs model, which decides on social matches, system adapts by suggesting conversations)*

> **Main Purpose**: To act as a **social facilitator** at events, recommending **who to talk to** and **what to talk about** based on shared interests and profiles, enhancing networking efficiency.

**Adaptation Offered (Adaptive Component):**
*   Recommends another attendee to initiate a conversation with.
*   Suggests a relevant, common topic to discuss.

**Concerns & Challenges:**
1.  **Appropriateness & Social Nuance**: The algorithm may suggest matches that are professionally or socially inappropriate, lacking human understanding of subtle social dynamics.
2.  **Obtrusiveness & Naturalness**: Pushy suggestions could feel unnatural and awkward, undermining the organic flow of social interaction.
3.  **Data Reliability & Privacy**: Relies on accurate, up-to-date user profiles (which may be embellished) and involves sharing personal interest data, raising **privacy concerns**.

**Contemporary Similar Systems**: **Conference networking apps** (e.g., Grip, Brella), **professional networking platforms** (LinkedIn suggestions), and **dating apps** (match algorithms).

### Comparative Analysis: LILSYS vs. AGENTSALON

**Three Key Similarities:**
1.  **Both Mediate Human Interaction**: They adaptively filter or facilitate communication between people.
2.  **Both Require Sensitive Data Processing**: They rely on personal data (context/activity or interests) to function, creating **privacy challenges**.
3.  **Both Aim to Increase User Efficiency**: LILSYS saves time/attention; AGENTSALON saves social discovery effort.

**Three Key Differences:**
1.  **Adaptation Goal**: LILSYS **discourages/delays** interaction (calls); AGENTSALON **encourages/initiates** interaction (conversations).
2.  **Focus of Adaptation**: LILSYS adapts **others' behaviour** (the caller's ability to reach the user). AGENTSALON adapts **the user's own behaviour** (who they talk to and about what).
3.  **Primary Data Source**: LILSYS heavily uses **implicit sensor data** about the real-world context. AGENTSALON primarily uses **explicit user profiles** and stated interests.

---
#### **Exam Practice Question 1.5**
**A modern "Smart Meeting Room" system uses sensors to detect room occupancy and calendar data to automatically project the correct meeting materials when the host enters. Comparing it to *LILSYS*, identify one shared usability threat and one key architectural difference.**
**[4 marks]**

**Model Answer**:
**Shared Usability Threat**: **Diminished Predictability/Controllability**. Both systems act automatically. If the Smart Room projects the wrong materials, users may not know why (predictability) and may struggle to manually override it quickly (controllability), similar to LILSYS blocking an important call.
**Architectural Difference**: The **Domain Model**. LILSYS's domain model is about "caller importance" and "user availability states." The Smart Room's domain model is about "meeting entities," "presentation files," and "display devices." The adaptation logic uses this different domain knowledge to drive different actions (blocking vs. projecting).

---
## 1.5 System Design Exercise: Module Recommender

**Scenario**: Designing a University of Leeds module recommender to help students choose optional modules.

**Architecture Following the General Schema:**

![[generic-adaptive-architecture.png|500]]
*(Annotate the generic diagram for this specific case)*

1.  **User Data Gathering (What & How)**:
    *   **Explicit**: Student's **degree programme**, **past module grades**, **stated interests** (from a form).
    *   **Implicit**: **Browsing history** on module catalogue pages (dwell time, clicks).
    *   **From Institutional Systems**: **Enrolment records**, **prerequisite maps**.

2.  **User Model Acquisition (Processing)**:
    *   A **stereotype** could be assigned initially based on programme and grades (e.g., "High-Achieving CS Student").
    *   An **overlay model** is built: compares student's **transcript** (known topics) against the **module learning outcomes** in the domain model to identify knowledge gaps/advancements.
    *   A **preference vector** is updated from browsing behaviour, weighting interests towards modules viewed for long periods.

3.  **User Model (Contents)**:
    *   Stereotype label (for cold-start).
    *   Vector of **mastered topics** (from past grades).
    *   Vector of **interest strengths** in various topics (e.g., AI: 0.9, Security: 0.4).
    *   **Constraints**: Mandatory programme requirements, prerequisite chains, timetable slots.

4.  **User Model Application (Decision Logic)**:
    *   **Filtering**: Rule-based system removes modules that violate constraints (wrong year, missing prerequisites).
    *   **Scoring/Ranking**: Content-based filtering scores remaining modules by similarity between module topic vector and user's interest vector. Collaborative filtering could score modules popular among students in the same stereotype.
    *   **Diversification**: Ensures the shortlist isn't all in one very specific area.

5.  **Adaptive Component (Presentation)**:
    *   A personalised web page titled "Recommended For You".
    *   Modules presented in ranked order, with a brief **explanation** ("Matches your interest in AI and complements your strong grades in programming").
    *   Option to **explore** or **tune** preferences (mixed-initiative adaptation).

---
#### **Exam Practice Question 1.6**
**For the Module Recommender, one proposed data source is the implicit analysis of module catalogue browsing. Justify why this is useful, and describe a specific challenge in interpreting this data for modelling.**
**[4 marks]**

**Model Answer**:
**Justification**: Browsing data is **unobtrusive** and captures **real, evolving curiosity** that a student may not explicitly state. It can reveal emerging interests (e.g., spending time on Robotics pages despite no prior background) and helps overcome the **cold-start problem** for students who don't fill out interest forms thoroughly.
**Interpretation Challenge**: **Ambiguity of Intent**. A long dwell time on a module page might indicate **genuine interest**, but it could also indicate **confusion** (the description is hard to understand), **distraction**, or the student is **researching it for a friend**. Using this signal as a strong positive preference could lead to an **inaccurate user model** and poor recommendations.
# Topic 2: User Model Representation & Building (Continued)
## 2.2 User Model Representation (Detailed)

> The **User Model** is a structured data representation of the system's beliefs about various aspects of the user. The choice of *what* to model and *how* to represent it depends on the system's adaptive goals.

### What Can Be Modelled?
| Aspect | Description | Example | Relevance for Adaptation |
| :--- | :--- | :--- | :--- |
| **Background** | Stable, domain-adjacent experience or demographics. | Profession, native language, years of experience. | Coarse-grained adaptation (e.g., medical system adapting terminology for student vs. doctor). |
| **Individual Traits** | Stable psychological characteristics. | Learning style (visual/verbal), cognitive style, personality (Big Five). | Personalising interaction *style* or content *presentation format*. |
| **Context** | Dynamic situation of user & environment. | Location, time, device, social setting, affective state (mood). | Ensures adaptations are **relevant to the immediate situation** (e.g., mobile tourist guide). |
| **Interests** | Topics or items the user prefers. | Preference for "AI news" over "sports". | Core to **recommender systems** and **content filtering**. |
| **Knowledge/Skills** | User's understanding of domain concepts. | Understanding of SQL JOINs vs. basic SELECT. | Core to **adaptive learning systems** (Intelligent Tutoring Systems). |
| **Goals & Tasks** | User's current objective or activity. | Goal: "Book a flight to Berlin." Task: "Compare hotel prices." | Drives **goal-oriented adaptation** (e.g., a help system suggesting relevant functions). |

**Critical Principle**: Model **only what is needed** for the intended adaptation. Adding unnecessary parameters increases complexity and privacy risk without benefit.

### Detailed Representation Methods by Aspect

#### 1. Representing Interests
Used primarily in **information filtering** and **recommender systems**.

| Representation Method | Description | Pros | Cons | Example |
| :--- | :--- | :--- | :--- | :--- |
| **Keyword-Level (Vector Model)** | User profile is a **weighted list of keywords** extracted from content they interact with. | Simple; captures user's own vocabulary; good for niche interests. | No semantic relationships; "vocabulary mismatch" with content. | `{business:0.7, travel:0.5, environment:0.3}` |
| **Overlay on Fixed List** | Profile is a vector over a **system-defined list** of topics/categories. | Direct mapping to content tags; easy to implement. | Inflexible; no relationships between topics. | Interests over `[Tech, Sports, Politics]` = `[0.9, 0.1, 0.4]` |
| **Concept-Level (Semantic Overlay)** | Profile is an **overlay on a domain ontology or concept graph**. | Enables **semantic reasoning** (e.g., recommending "global warming" articles if interested in "environment"); supports richer relationships. | Depends on **quality & completeness** of the ontology; complex to build and maintain. | User node linked to "Computer Science" concept in an ACM taxonomy graph, inheriting interest in sub-concepts like "AI". |

**Situation for Use**: A simple news aggregator might use a **fixed list overlay**. A research paper recommender like Google Scholar should use a **concept-level model** (e.g., based on ACM classification) to understand that a user interested in "machine learning" might also appreciate papers on "neural networks."

#### 2. Representing Knowledge/Skills
Core to **Intelligent Tutoring Systems (ITS)** like SQL-Tutor.

| Representation Method | Description | Pros | Cons | Example |
| :--- | :--- | :--- | :--- | :--- |
| **Scalar Model** | Single value on a scale (e.g., novice to expert). | Extremely simple. | **Low granularity & precision**; boundaries are fuzzy; cannot drive fine-grained adaptation. | `knowledge_physics = "intermediate"` |
| **Overlay Model** | Represents knowledge as a **subset of an expert domain model**. Each domain concept has a user state (e.g., known, unknown, struggling). | Direct link to instructional content; enables **fine-grained adaptation** targeting specific gaps. | Requires a well-structured, complete **domain model**. | In SQL-Tutor, the domain model is a graph of SQL concepts; the user model marks `SELECT` as `mastered` and `JOIN` as `needs_practice`. |
| **Bug Model / Perturbation Model** | Extends overlay model to include specific **misconceptions or incorrect rules**. | Powerful for diagnosing and remediating deep errors. | Very complex to build; requires extensive cognitive task analysis. | A math ITS models not just that a student got division wrong, but that they hold the specific bug "ignore remainder". |
	**Situation for Use**: Most practical AES use the **Overlay Model** as it balances expressive power with implementability. The Bug Model is reserved for domains where specific, common misconceptions are well-documented (e.g., physics, algebra).

#### 3. Representing Context
![[user-vs-env-context.png|500]]
*User vs. Environment Context Dimensions*

**Situation Analysis - Tourist Guide App**:
*   **User Context (Essential)**: **Location** (to suggest nearby places), **Temporal Context** (visit duration, time of day), **Social Context** (alone, family, wheelchair user).
*   **Environment Context (Essential)**: **Weather** (suggest indoor activities if raining), **Traffic Conditions**.
*   **Acquisition Challenge**: Requires **sensor data** (GPS), **APIs** (weather), and potentially **explicit input** (group size, accessibility needs).

#### 4. Representing Goals & Tasks
*   **Method**: Typically a **pre-defined goal catalog or hierarchy**. The system performs **goal/task recognition** to place the user's current activity within this structure.
*   **Representation**: Often an **overlay** on the goal hierarchy, combined with a **probability** if recognition is uncertain.
*   **Challenge**: **Goal recognition is difficult**. It must be inferred from ambiguous user actions.
*   **Example**: A student's goal hierarchy: `Degree > Pass Year 3 > Complete Module X > Submit Assignment 2`. The system infers current goal as `Submit Assignment 2 (P=0.8)` based on opened files and browsing history, triggering adaptations like showing relevant library links.

---
#### **Exam Practice Question 2.3**
**An Intelligent Tutoring System for Python programming uses an *overlay model* to represent student knowledge. Describe how this model is initially built for a new student and how it is subsequently updated based on the student solving a problem incorrectly.**
**[5 marks]**

**Model Answer**:
**Initial Build (Cold-Start)**: The student is typically assigned a **stereotype** (e.g., "Complete Beginner") or takes a **pre-test**. Their overlay model is initialized by marking all concepts in the domain model (e.g., variables, loops, functions) as "unknown" or with a prior probability based on the stereotype/pre-test results.
**Update Process**: When the student fails a problem on "while loops", the system analyses their solution against the domain model. It identifies which specific concepts were misapplied. The overlay model is then updated to **reduce the mastery value or probability** for the "while loop" concept and potentially for prerequisite concepts (e.g., "boolean expressions") that the error suggests are weak. This **fine-grained update** allows the system to select the next problem targeting these specific gaps.

---
## 2.3 Building the User Model: Acquisition & Update

> **User Model Acquisition** is the process of **constructing** and **maintaining** the user model from the collected data. It involves inference, update rules, and consistency checks.

### Key Acquisition Techniques
1.  **Stereotype Reasoning**: **If-Then rules** assign users to pre-defined stereotypes based on **trigger conditions**. The stereotype provides a full set of default attribute values.
    *   `IF (occupation="student" AND course="Computer Science") THEN assign stereotype CS_Student (P=0.8)`.
2.  **Machine Learning/Data Mining**: Algorithms (e.g., classification, clustering) automatically infer patterns from user data to assign attributes or predict missing values.
3.  **Plan & Goal Recognition**: Inferring high-level goals from sequences of low-level actions (e.g., inferring "writing a report" from opening Word, searching the web, citing sources).
4.  **Bayesian Networks**: Probabilistic graphical models that represent dependencies between user attributes and evidence, allowing for **probabilistic inference** under uncertainty.

### The Cold-Start Problem Revisited
*   **User Cold-Start**: Solved by **stereotypes** (fast initialisation) and **explicit initial profiling**.
*   **Item Cold-Start**: **Content-based filtering** solves this by using item attributes (metadata) which are available from the start. **Knowledge-based recommenders** also avoid it, as they don't rely on usage data.

| Acquisition Challenge | Mitigation Strategy |
| :--- | :--- |
| **Sparse Data** | Use **hybrid models** (combine multiple data sources), **stereotypes**. |
| **Noisy/Unreliable Data** | Use **probabilistic models** (Bayesian nets), **confidence measures**, require **corroborating evidence**. |
| **Changing User State** (concept drift) | Implement **forgetting mechanisms** (decay older evidence), allow **manual profile editing**. |

---
#### **Exam Practice Question 2.4**
**A streaming service uses a simple vector model to represent user interests in movie genres. Describe a specific strategy for updating this model *implicitly* when a user watches only the first 15 minutes of a "Horror" film before switching it off.**
**[3 marks]**

**Model Answer**:
The system should interpret the early abandonment as a **negative implicit signal**. The update strategy would be to **decrease the weight** for the "Horror" genre in the user's interest vector. Additionally, it could increase weights for the genre of the film they switched *to*, treating that as a positive signal. The decrease for Horror should be significant but not absolute (e.g., reduce by 0.3), as the user might have stopped for reasons unrelated to genre (e.g., interruption).
# Topic 2: User Model Representation & Building (Continued)
## 2.4 Building the User Model: Interests in Detail

> Building a model of user **interests** is a core task for recommender systems and adaptive information filters. It involves translating raw user **measurements** into **metrics**, and finally into a structured **user model value**.

### The Click-Through Rate (CTR) Method

A fundamental **implicit feedback** technique for inferring interest.

| **Measurement** → **Metric** → **User Model Value** |
| :--- |
| ![[Fig2-click-through.jpg\|500]] |

**Process**:
1.  **Measurement**: Count `#Seen` (impressions) and `#Clicks` on an item.
2.  **Metric Calculation**: Compute **Click-Through Rate (CTR)**.
    $$CTR = \frac{\#Clicks}{\#Seen}$$
3.  **Interpretation for User Model**: A high CTR for a specific item or category is interpreted as **interest/engagement**. A very low CTR may indicate **disinterest**. This binary or scaled value is stored in the user's interest profile.

**Situation for Use**: Extremely common in **online advertising**, **news recommenders**, and **e-commerce** to gauge immediate response to presented items. It is a direct, real-time engagement signal.

**Limitation**: **Position Bias**—items placed in prominent positions (top of list) get more clicks regardless of interest, potentially skewing the metric. Requires normalisation techniques to account for bias.

### Building Keyword-Based Interest Models
Used when interests are represented as a **weighted vector of keywords**.

**Process Flow**: `User -> Browsing Agent -> Positive Feedback (Clicks/Likes) -> Keyword Extraction & Weighting -> Interest Vector`

**Core Technique: TF-IDF (Term Frequency-Inverse Document Frequency)**
This algorithm extracts and weights keywords from documents the user has interacted with (e.g., clicked articles). It identifies terms that are **frequent in the user's positive documents** but **relatively rare across all documents**, making them good discriminators of personal interest.

| **TF-IDF Example Calculation** |
| :--- |
| ![[Fig3-TFIDF.jpg\|500]] |

**Formulas**:
- **Term Frequency (TF)**: How important a term is *within a single user document*.
  $$tf(t,d) = \frac{f_d(t)}{\max_{w \in d} f_d(w)}$$
  where $f_d(t)$ is the raw count of term $t$ in document $d$.
- **Inverse Document Frequency (IDF)**: How important a term is *across the entire collection* (rarity).
  $$idf(t, D) = \ln \left( \frac{|D|}{|\{d \in D : t \in d\}|} \right)$$
  where $|D|$ is the total number of documents in the corpus.
- **TF-IDF Score**:
  $$tfidf(t,d,D) = tf(t,d) \cdot idf(t, D)$$

**User Model Construction**: The system aggregates TF-IDF vectors from all documents the user has positively interacted with, creating a **composite keyword vector** that represents their interest profile. This profile can then be compared to new documents using cosine similarity for recommendation.

### Building Graph-Based & Concept-Based Interest Models
These methods move beyond keywords to **semantic representations**.

| Method | Process | Output | Advantage |
| :--- | :--- | :--- | :--- |
| **Graph-Based** | `Positive Examples -> Semantic Tagging -> Graph Overlay` | A **graph-based profile** where the user is linked to nodes (concepts) in a semantic network (e.g., ontology). | Captures **relationships** between interests; enables **inference** (if interested in "AI", maybe interested in "Machine Learning"). |
| **Concept-Based (i)** | `Positive Examples -> Semantic Tagging -> Graph Overlay -> Concept Frequency` | **Top Concepts**: A ranked list of high-level concepts from the ontology. | Reduces **dimensionality** and **noise** compared to keywords; more generalisable. |
| **Concept-Based (ii)** | `Positive Examples -> Clustering -> Top Extraction` | **Top Concepts**: Identified by clustering positive items and extracting common thematic labels. | Discovers latent **topical themes** without a pre-defined ontology. |

**Key Insight from Research**: User interests are **dynamic** and influenced by both **long-term genuine preference** and **short-term public trends** (e.g., news cycles). Effective models (like the **Bayesian framework** in the Google News paper) should separate and combine these factors.

### Critical Preprocessing: Isolating Interest from Engagement
Raw behavioural counts (e.g., 10 clicks on Sports, 2 on Politics) conflate:
1.  **Interest Profile**: The *relative distribution* of attention (e.g., prefers Sports to Politics).
2.  **Engagement Level**: The *total amount* of activity (e.g., high vs. low usage).

**Solution (Two-Step Normalisation for Clustering)**:
1.  **Apply TF-IDF** to raw user-category counts. This down-weights ubiquitous categories and boosts distinctive ones.
2.  **Apply L2 Normalisation** to the resulting TF-IDF vector.
    $$\mathbf{v}_u^{\text{(norm)}} = \frac{\mathbf{v}_u}{||\mathbf{v}_u||_2}$$
    This projects the vector onto a unit sphere, **preserving its direction (interest distribution)** while **removing its magnitude (engagement level)**.

**Result**: Users with similar interest patterns but different activity levels (e.g., a sports fanatic and a casual sports fan) will have very similar normalised vectors, allowing clustering algorithms to group them based on **true interest alignment**.

---
#### **Exam Practice Question 2.5**
**A news website uses a simple keyword-based user interest model built from TF-IDF on clicked articles. Describe one specific limitation of this approach for modelling interests in *breaking news* stories about a new, unforeseen event (e.g., a sudden natural disaster).**
**[4 marks]**

**Model Answer**:
A key limitation is the **vocabulary mismatch and cold-start problem for new terms**. TF-IDF relies on terms extracted from *previously clicked* articles. A breaking news event involves **new named entities and keywords** (e.g., "Hurricane X", "location Y") that have never appeared in the user's historical click data. Therefore, the user's existing TF-IDF vector will have zero weight for these new terms, making it impossible for a pure keyword-matching system to identify the story as potentially relevant, even if the user is highly interested in the general topic of "disasters". This highlights the need for **concept-based or trend-aware models** that can map new terms to known interest categories.

---
## 2.5 Representing Goals & Tasks

Goal and task modelling drives proactive, context-sensitive adaptation.

| Goals and Tasks Hierarchy Example          |
| :----------------------------------------- |
| ![[Fig1-goals-and-tasks-example.jpg\|500]] |
**Process**:
1.  **Define a Goal Catalogue**: A pre-defined hierarchy of possible user goals/tasks within the system's domain.
2.  **Goal/Task Recognition**: The system infers the user's current goal from their actions (e.g., sequence of menu selections, search queries). This is often probabilistic.
3.  **Overlay Representation**: The user model contains an **overlay** on the goal hierarchy, marking the inferred current goal(s) and their **confidence probabilities**.
4.  **Adaptation Trigger**: Adaptation rules are fired based on the active goal node. For example, if the goal is identified as `Submit Assignment`, the system can adapt by showing links to the submission portal and relevant style guides.

**Challenge**: **Goal recognition is inherently uncertain and error-prone**. Systems must handle ambiguity and allow for **mixed-initiative correction** (e.g., "Are you trying to book a flight?").

---
#### **Exam Practice Question 2.6**
**The research on Google News found that a user's news reading interests change over time, and the predictive power of their click history decays. Describe the two-component Bayesian framework proposed to address this and how it improves recommendations.**
**[5 marks]**

**Model Answer**:
The framework decomposes a user's observed behaviour into two latent components:
1.  **Genuine Interest**: A **relatively stable** long-term personal preference, inferred from the user's historical clicks after *factoring out* temporary trends.
2.  **News Trend Influence**: A **short-term, location-based** effect representing what the general public is currently clicking on in the user's country.

Using **Bayes' theorem**, the system isolates the genuine interest from trend-inflated clicks. For prediction, it **combines** the estimated genuine interest with the *current* public trend. This improves recommendations because it simultaneously respects the user's core preferences while ensuring recommendations are **timely and relevant to the current news cycle**, leading to the observed 30.9% increase in CTR.