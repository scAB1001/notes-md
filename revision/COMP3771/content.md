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
## 1.3 General Schema & Applied Examples

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
## 1.4 Types of User-Adaptivity Support

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

## 1.5 Applied Analysis & System Design

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
# Topic 2: User Model Representation and  Building, User Information Collection
## 2.1 System Design Exercise: Module Recommender

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


|       | u1  | u2  | u3    | u4  | u5  | u6  |
| ----- | --- | --- | ----- | --- | --- | --- |
| item1 | 5   | 1   | 5     | 4   | 0   | 3   |
| item2 | 3   | 3   | 1     | 1   | 5   | 1   |
| item3 | 0   | 1   | **0** | 2   | 1   | 4   |
| item4 | 1   | 1   | 4     | 1   | 1   | 2   |
| item5 | 3   | 2   | 5     | 0   | 0   | 3   |
| item6 | 4   | 3   | **0** | 0   | 4   | 0   |
| item7 | 0   | 1   | 5     | 1   | 1   | 1   |

|                    | u1    | u2    |    u3     | u4    | u5    | u6    |
| ------------------ | ----- | ----- | :-------: | ----- | ----- | ----- |
| item1              | 5     | 1     |   ==5==   | 4     | 0     | 3     |
| item2              | 3     | 3     |   ==1==   | 1     | 5     | 1     |
| ==item3==          | ==0== | ==1== | ==**?**== | ==2== | ==1== | ==4== |
| item4              | 1     | 1     |   ==4==   | 1     | 1     | 2     |
| item5              | 3     | 2     |   ==5==   | 0     | 0     | 3     |
| item6              | 4     | 3     | ==**0**== | 0     | 4     | 0     |
| item7              | 0     | 1     |   ==5==   | 1     | 1     | 1     |
| similarity measure | 0.63  | 0.56  |           | 0.71  | 0.22  | 0.93  |
# Topic 3: Recommender Systems
## 3.1 Introduction & Core Techniques

> **Recommender Systems** are a primary application of user-adaptivity, designed to address **information overload** by predicting a user's preference for items and presenting a personalised selection.

| **Main Recommendation Techniques** |
| :--- |
| ![[recommendation-techniques.png\|500]] |

### Overview of Core Techniques
| Technique | Core Idea | Background Data | Input Data | Core Algorithm (Simplified) |
| :--- | :--- | :--- | :--- | :--- |
| **Collaborative Filtering (CF)** | Leverage the **wisdom of the crowd**. "People similar to you liked X." | User-Item interaction matrix (ratings, purchases). | Target user's interaction history. | Find similar users/items, aggregate their ratings. |
| **Content-Based Filtering (CBF)** | Leverage **item attributes**. "You liked items with features A, B; here are more with A, B." | **Domain Model**: Item feature vectors. **User Model**: Feature preference vector. | Target user's interaction history (to build profile). | Compute similarity between user profile vector and item feature vectors. |
| **Knowledge-Based (KB)** | Leverage **explicit knowledge** about user needs and item suitability. | **Knowledge Base**: Rules, constraints, utility functions linking user needs to items. | Explicit user requirements/constraints. | Search/retrieve items that satisfy the stated constraints and utility criteria. |
| **Demographic (DM)** | Leverage **user demographic categories**. "People in your demographic liked X." | Demographic user profiles (age, occupation, etc.). | Target user's demographic attributes. | Classify user into a demographic segment, recommend items popular in that segment. |
| **Utility-Based (UT)** | Leverage a **user-specific utility function**. "This item maximises your defined utility." | Utility function for the user over item features. | Target user's utility function (explicitly defined). | Calculate utility score for each candidate item, rank. |

**Key Insight**: Each technique uses a different type of **background knowledge** (social, content, domain knowledge) and suffers from different weaknesses (cold-start, overspecialisation). This motivates **hybrid systems**.

---
## 3.2 Collaborative Filtering (CF) In-Depth

CF predicts a user's preference for an item based on the preferences of **similar users** (User-User) or the similarity of the item to other items the user liked (Item-Item).

### User-User Collaborative Filtering
**Methodology**:
1.  **Represent Data**: Construct a **User-Item Matrix** with ratings.
2.  **Define Neighbourhood**: For the target user, compute similarity to all other users (e.g., **Cosine Similarity** or **Pearson Correlation**). Select the **k-nearest neighbours**.
3.  **Make Prediction**: Compute a **weighted average** of the neighbours' ratings for the target item.

**Example Scenario (Movie Recommendations)**:
We want to predict user **u3**'s rating for **item3**.

|           | u1  | u2  | u3 (Target) | u4  | u5  | u6  |
| :-------- | :-: | :-: | :---------: | :-: | :-: | :-: |
| **item1** |  5  |  1  |    **5**    |  4  |  0  |  3  |
| **item2** |  3  |  3  |    **1**    |  1  |  5  |  1  |
| **item3** |  0  |  1  |    **?**    |  2  |  1  |  4  |
| ...       | ... | ... |     ...     | ... | ... | ... |

**Step 1: Calculate Similarities** (e.g., Cosine between rating vectors).
`sim(u3,u1)=0.63`, `sim(u3,u4)=0.71`, `sim(u3,u6)=0.93`.
**Step 2: Neighbourhood (k=3)**: u6, u4, u1.
**Step 3: Prediction (Weighted Sum)**:
$$p_{u3,item3} = \frac{(4 \cdot 0.93) + (2 \cdot 0.71) + (0 \cdot 0.63)}{0.93+0.71+0.63} \approx 2.26$$
**Situation for Use**: When the **user base is relatively stable** and you want to leverage diverse taste communities. Prone to scalability issues.
#### Problem Setup
Predict user **u3**'s rating for **item3** using User-User CF with **k=3 nearest neighbours**. We use **Cosine Similarity** to find similar users.

**Rating Matrix (Subset for calculation)**:
We need the rating vectors for **u3** and the other users **for the items they have both rated**. For similarity, we only consider items where **both users have a rating** (non-zero in this example). We'll calculate `sim(u3, u1)`.

| Item | u1's Rating ($r_{u1}$) | u3's Rating ($r_{u3}$) |
| :--- | :---: | :---: |
| item1 | 5 | 5 |
| item2 | 3 | 1 |
| item4 | 1 | 4 |
| item5 | 3 | 5 |
| item6 | 4 | 0 |
| item7 | 0 | 5 |
*Note: `item3` is omitted because u1 hasn't rated it (0). `item6` is included because u3's rating is 0, which is a valid value for the similarity calculation.*

##### Step 1: Calculate Cosine Similarity

**Cosine Similarity Formula**:
For two vectors **A** and **B**, the cosine similarity is:
$$sim(A, B) = \cos(\theta) = \frac{A \cdot B}{\|A\| \|B\|} = \frac{\sum_{i=1}^{n} A_i B_i}{\sqrt{\sum_{i=1}^{n} A_i^2} \cdot \sqrt{\sum_{i=1}^{n} B_i^2}}$$
**Calculation for `sim(u3, u1)`**:
1.  **Compute the Dot Product (Numerator)**:
$$\begin{align}
u3 \cdot u1 = \\
(5\cdot5) + (1\cdot3) + (4\cdot1) + (5\cdot3) + (0\cdot4) + (5\cdot0) \\ 
= 25 + 3 + 4 + 15 + 0 + 0 = 47
\end{align}$$

2.  **Compute the Magnitude (Euclidean Norm) of each vector**:
    - $\|u3\| = \sqrt{5^2 + 1^2 + 4^2 + 5^2 + 0^2 + 5^2} = \sqrt{25 + 1 + 16 + 25 + 0 + 25} = \sqrt{92} \approx 9.5917$
    - $\|u1\| = \sqrt{5^2 + 3^2 + 1^2 + 3^2 + 4^2 + 0^2} = \sqrt{25 + 9 + 1 + 9 + 16 + 0} = \sqrt{60} \approx 7.7460$

3.  **Compute Cosine Similarity**:
$$sim(u3, u1) = \frac{47}{9.5917 \times 7.7460} = \frac{47}{74.302} \approx 0.6325 \approx 0.63$$
**Repeat for other users** (conceptually):
- `sim(u3, u4)` and `sim(u3, u6)` are calculated **using the same method**, comparing u3's rating vector to u4's and u6's vectors over their co-rated items.
- The results given are: `sim(u3, u4)=0.71`, `sim(u3, u6)=0.93`.

##### Step 2: Define Neighbourhood (k=3)
Rank users by similarity to u3 (descending):
1.  u6 (0.93)
2.  u4 (0.71)
3.  u1 (0.63)
These are the **3-nearest neighbours**.

##### Step 3: Make Prediction for `item3` via Weighted Sum

We now predict $p_{u3, item3}$. We need the **neighbours' ratings for `item3`** and their similarity weights.

| Neighbour | Rating for `item3` ($r_{u,item3}$) | Similarity to u3 ($w_u$) |
| :--- | :---: | :---: |
| u6 | 4 | 0.93 |
| u4 | 2 | 0.71 |
| u1 | 0 | 0.63 |
**Weighted Sum Prediction Formula**:
$$p_{u,i} = \frac{\sum_{v \in N} (sim(u,v) \cdot r_{v,i})}{\sum_{v \in N} sim(u,v)}$$Where $N$ is the set of k-nearest neighbours.

**Calculation**:
1.  **Weighted Rating Sum (Numerator)**:
  $$(r_{u6} \cdot w_{u6}) + (r_{u4} \cdot w_{u4}) + (r_{u1} \cdot w_{u1}) = (4 \cdot 0.93) + (2 \cdot 0.71) + (0 \cdot 0.63)$$
    $$= 3.72 + 1.42 + 0 = 5.14$$
2.  **Similarity Sum (Denominator)**:$$0.93 + 0.71 + 0.63 = 2.27$$
3.  **Final Prediction**:  $$p_{u3, item3} = \frac{5.14}{2.27} \approx 2.2643 \approx 2.26$$
**Interpretation**: The system predicts u3 would rate `item3` approximately **2.26 out of 5**. This is a **relatively low prediction**, largely influenced by u1's low rating (0), tempered by the higher ratings from more similar users (u4 and u6).

---
#### **Exam Practice Question 3.7**
**Using the same rating matrix, calculate the *Cosine Similarity* between user u3 and user u2. Show your working. You may use the following ratings: u3: [item1:5, item2:1, item4:4, item5:5, item6:0, item7:5]; u2: [item1:1, item2:3, item4:1, item5:2, item6:3, item7:1].**
**[5 marks]**

**Model Answer**:
1.  **Dot Product**: $(5*1) + (1*3) + (4*1) + (5*2) + (0*3) + (5*1) = 5 + 3 + 4 + 10 + 0 + 5 = 27$
2.  **Magnitude of u3**: $\sqrt{5^2+1^2+4^2+5^2+0^2+5^2} = \sqrt{25+1+16+25+0+25} = \sqrt{92} \approx 9.592$
3.  **Magnitude of u2**: $\sqrt{1^2+3^2+1^2+2^2+3^2+1^2} = \sqrt{1+9+1+4+9+1} = \sqrt{25} = 5$
4.  **Cosine Similarity**: $sim(u3, u2) = \frac{27}{9.592 \times 5} = \frac{27}{47.96} \approx 0.563$
**Therefore, the similarity is approximately 0.56.**

### Item-Item Collaborative Filtering
**Methodology**:
1.  **Represent Data**: Same User-Item Matrix.
2.  **Define Neighbourhood**: For the target item, compute similarity to all other items (based on how users rated them). Select **k-most similar items** that the target user has rated.
3.  **Make Prediction**: Compute a **weighted average** of the target user's ratings for those similar items.

**Example Continued**:
Predict **u3**'s rating for **item3** by finding items similar to item3 that u3 has rated.
`sim(item3,item4)=0.9`, `sim(item3,item5)=0.64`, `sim(item3,item7)=0.85`.
**Prediction**:
$$p_{u3,item3} = \frac{(4 \cdot 0.9) + (5 \cdot 0.64) + (5 \cdot 0.85)}{0.9+0.64+0.85} \approx 4.62$$

**Situation for Use**: **Industry standard** (e.g., Amazon). More stable than user-user because item similarities change less frequently. Scales better.

### Amazon's Scalable Item-Item CF (Binary Case)
For implicit data (bought/not bought).

| | u1 | u2 | u3 (Target) | u4 | u5 | u6 |
| :--- | :---: | :---: | :---: | :---: | :---: | :---: |
| **item1** | 1 | 0 | **1** | 1 | 0 | 0 |
| **item2** | 0 | 1 | **0** | 1 | 0 | 0 |
| **item4** | 0 | 1 | **1** | 1 | 0 | 0 |

**Process**:
1.  Find customers who bought the same items as u3 (u1, u2, u4 bought item1 or item4).
2.  Find other items those customers bought (item2, item3, item5, item6, item7).
3.  Calculate **item-item similarity** (e.g., cosine) between u3's items (i1, i4) and these candidate items.
4.  Recommend items with highest similarity (e.g., `sim(i4,i2)=0.82`, `sim(i1,i7)=0.58`).

**Why it Scales**: **Similarities between items are pre-computed offline**. The online step just aggregates pre-calculated lists for the user's purchased items, which is very fast.

### CF: Advantages & Disadvantages
| Advantages | Disadvantages |
| :--- | :--- |
| **Social Wisdom**: Can recommend **serendipitous** items outside user's normal scope. | **Cold-Start**: Fails for **new users** (no ratings) and **new items** (no ratings). |
| **No Domain Knowledge Needed**: Works purely on interaction data. | **Sparsity**: The user-item matrix is typically very sparse, making similarity computations unreliable. |
| **Effective & Popular**: Proven in e-commerce, media. | **Popularity Bias**: Tends to recommend already popular items, amplifying the "rich-get-richer" effect. |
| | **Scalability**: User-User CF requires O(M) comparisons online (M=users). |
| | **Lack of Transparency**: Hard to explain *why* an item was recommended ("people like you..."). |

---
#### **Exam Practice Question 3.1**
**Using the provided rating matrix, calculate the predicted rating for *user5* on *item7* using *Item-Item Collaborative Filtering* with a neighbourhood of k=2. Show your similarity calculations and final prediction.**
**[6 marks]**
*(Assume a mini-matrix is provided in the exam. Model answer would show steps: 1) Calculate item7's similarity to other items user5 has rated. 2) Pick top 2. 3) Weighted average.)*

---
## 3.3 Content-Based Filtering (CBF) In-Depth

> CBF recommends items **similar in content/attributes** to those the user has liked in the past. It is a direct application of the **user model as a feature preference vector**.

| **Content-Based Recommender Architecture** |
| :--- |
| ![[Content-based-recommender-system.png\|500]] |

### Methodology
1.  **Content Representation**: Each item is represented as a **feature vector** (e.g., TF-IDF keywords, ontology concepts, genre tags).
2.  **User Profile Construction**: The user's profile is an **aggregated feature vector** from items they have liked/consumed. This can be a weighted average.
3.  **Similarity Computation**: For a candidate item, compute the similarity (e.g., **Cosine Similarity**) between its feature vector and the user's profile vector.
4.  **Recommendation**: Rank items by similarity score and recommend the top-N.

**Example Scenario (News Recommender)**:
- **User Profile (U)**: Built from clicked articles: `[politics:0.7, technology:0.9, sports:0.2]`
- **Article (I) Feature Vector**: `[politics:0.8, technology:0.6, sports:0.1]`
- **Cosine Similarity**:
$$sim(U,I) = \frac{(0.7\cdot0.8)+(0.9\cdot0.6)+(0.2\cdot0.1)}{\sqrt{0.7^2+0.9^2+0.2^2} \cdot \sqrt{0.8^2+0.6^2+0.1^2}} \approx 0.98$$
High similarity leads to recommendation.

### CBF with Keyword, Graph, and Concept Models
- **Keyword Model**: As above. Simple but suffers from synonymy/polysemy.
- **Graph/Concept Model**: Items and user profiles are linked to nodes in a **domain ontology** (e.g., ACM Computing Classification for CS papers). Similarity is based on **semantic relatedness** in the graph (e.g., path distance, shared ancestors). Enables deeper reasoning.

### CBF: Advantages & Disadvantages
| Advantages | Disadvantages |
| :--- | :--- |
| **No Cold-Start for Items**: Can recommend new items if their features are known. | **User Cold-Start**: Needs user history to build profile. |
| **Transparency**: Can explain recommendations ("because you like Technology"). | **Over-Specialisation (Filter Bubble)**: Rarely recommends items outside user's existing profile. |
| **Independence**: Doesn't need data from other users. | **Limited Serendipity**: Cannot make cross-topic discoveries. |
| **Domain-Specific Tuning**: Can incorporate domain knowledge via feature engineering. | **Feature Dependency**: Quality depends entirely on **quality and availability of item metadata**. |

**Situation for Use**: **Museum Guides** (Rijksmuseum CHIP project). The system uses a **knowledge graph** of artworks (artist, period, subject). A user's indicated interest in "Rembrandt" and "portraits" (concepts in the graph) allows the system to recommend other portrait paintings from the Dutch Golden Age, even by different artists, by reasoning through the semantic graph.

---
## 3.4 Knowledge-Based Recommenders

> KB recommenders use **explicit knowledge** about the domain, user needs, and how items satisfy those needs. They are often **interactive** and **constraint-based**.

**Core Idea**: The system engages the user in a **dialogue** to understand their specific requirements (e.g., "I need a laptop for gaming under £1000"), then uses a **knowledge base** of item specifications and rules to filter and rank options.

**Example Scenario (Car Recommender - EntréeC)**:
1.  **User states need**: "Family car, good safety, under £30k."
2.  **System retrieves** cars matching constraints.
3.  **User critiques**: "Less expensive." "More cargo space."
4.  **System uses knowledge** (e.g., semantic relationships: "Less expensive" is opposite of "More luxurious") to refine search.
5.  **Output**: A refined list satisfying the evolving utility function.

**How it works**: It often uses **Case-Based Reasoning (CBR)**. The knowledge base is a set of cases (items). The user's requirements are a query. The system finds the most similar cases, and the user's critiques guide the adaptation of the query for subsequent retrieval.

### KB: Advantages & Disadvantages
| Advantages | Disadvantages |
| :--- | :--- |
| **No Cold-Start Problem**: Works immediately for new users and items. | **Knowledge Engineering Bottleneck**: Requires manual creation and maintenance of the knowledge base/rules. |
| **Handles Complex Needs**: Can reason about **non-product attributes** (delivery time, vendor reputation). | **Static Recommendations**: Unless the knowledge base is updated, suggestions don't improve from usage data. |
| **Highly Transparent & Controllable**: User understands the process (filtering by their stated constraints). | **User Effort**: Requires explicit input and iterative refinement from the user. |

**Situation for Use**: **High-involvement purchases** (cars, houses, complex financial products) where user needs are specific and items have many technical attributes.

---
## 3.5 Hybrid Recommender Systems

> **Hybrid systems** combine two or more recommendation techniques to **mitigate the weaknesses** of individual approaches.

### Hybridisation Methods (Burke's Taxonomy)
| Method | Description | Order-Sensitive? | Example |
| :--- | :--- | :--- | :--- |
| **Weighted** | Combine scores from multiple algorithms linearly. | **No** | `final_score = 0.7*CF_score + 0.3*CBF_score` |
| **Switching** | Use algorithm A in some contexts, B in others. | **Yes** | Use **Knowledge-Based** for new users, switch to **CF** after 10 ratings. |
| **Mixed** | Present outputs from different algorithms simultaneously in the UI. | **No** | Amazon's "Customers also bought" (CF) and "Related items" (CBF). |
| **Feature Combination** | Merge features from different sources into a single algorithm. | **No** | Use both user ratings (CF) and item genres (CBF) as input to a neural network. |
| **Cascade** | One algorithm produces a coarse list, a second refines it. | **Yes** | **KB** retrieves 100 candidates, **CF** re-ranks the top 20. |
| **Feature Augmentation** | Output of one algorithm is an input feature to another. | **Yes** | A CBF predicted rating is added as a feature in a CF model. |
| **Meta-level** | Model from one algorithm is input to another. | **Yes** | A CBF-generated user profile is used as the input vector for a CF method. |

**Example - EntréeC (KB/CF Cascade Hybrid)**:
1.  **First Stage (KB)**: The knowledge-based Entrée system uses **critique-based navigation** to produce a shortlist of restaurants.
2.  **Second Stage (CF)**: A collaborative filter breaks ties within this shortlist by leveraging past users' **semantic actions** (e.g., "Nicer", "Cheaper") as enriched implicit ratings. This preserves recommendation rationale while adding social wisdom.

### Why Hybridise? Problem-Solution Mapping
- **Cold-Start (User)**: Combine with **Knowledge-Based** (Switching, Cascade).
- **Cold-Start (Item)**: Combine with **Content-Based** (Weighted, Feature Combination).
- **Sparsity**: Combine **CF** with **Demographic** or **Content** (Feature Combination).
- **Overspecialisation (Filter Bubble)**: Combine **CBF** with **CF** (Mixed, Weighted) to add serendipity.
- **Transparency**: Combine any with **Knowledge-Based** to provide explanations.

---
#### **Exam Practice Question 3.2**
**A music streaming service suffers from the *item cold-start problem* for newly released songs. Describe a *hybridisation method* that could effectively address this, specifying the two base techniques to combine and your justification.**
**[5 marks]**

**Model Answer**:
Use a **Weighted Hybrid** of **Content-Based Filtering (CBF)** and **Collaborative Filtering (CF)**.
**Justification**: New songs have no play history (CF fails), but they have rich metadata (genre, artist, tempo). **CBF** can immediately recommend them to users whose profiles match these features. The **Weighted Hybrid** allows the system to blend the CBF score for new items with CF scores for established items. Over time, as the new song gains plays, the CF component's weight can automatically increase. This ensures new items are recommendable from day one while maintaining overall recommendation quality.
## 3.6 Hybrid Recommender Systems: Detailed Methods & Applications

> **Hybrid Recommender Systems** combine multiple base recommendation techniques to **leverage their complementary strengths** and **mitigate their individual weaknesses**. The Netflix Prize winner used a **blend of over 100 different models**, demonstrating the power of hybridisation.

| **Hybridisation Methods Overview** |
| :--- |
| ![[Hybridization-Methods.png\|500]] |

### 1. Weighted Hybrid
**Methodology**: Computes a **linear combination** of the prediction scores from multiple algorithms.
$$R_{final} = \frac{R_1 \cdot W_1 + R_2 \cdot W_2 + ... + R_n \cdot W_n}{W_1 + W_2 + ... + W_n}$$
Where $R_i$ is the score from algorithm $i$ and $W_i$ is its assigned weight.

**Example Scenario (Movie Streaming)**:
- **Algorithm A (CF)**: Predicts a rating of **4.2/5** for *Movie X* for user Alice.
- **Algorithm B (CBF)**: Predicts a rating of **3.8/5** for the same movie.
- **Weights**: CF weight = 0.6, CBF weight = 0.4 (reflecting greater trust in collaborative signals).
- **Final Score**: $R_{final} = \frac{4.2 \cdot 0.6 + 3.8 \cdot 0.4}{1.0} = 4.04$.

**When to Use**: When you have **multiple reliable but imperfect predictors** and want a stable, blended result. It is **order-insensitive**.

### 2. Switching Hybrid
**Methodology**: Selects **one algorithm** from the available set based on a **contextual rule or condition**. The output is the recommendation from the selected algorithm alone.

**Example Scenario (E-commerce with New Users)**:
- **Condition**: IF `user_rating_count < 5` THEN use **Knowledge-Based (KB)** algorithm ELSE use **Collaborative Filtering (CF)**.
- **Execution**: A new user with 2 ratings gets recommendations via a **KB** system that asks for preferences (e.g., "I need a gaming laptop under £1000"). After they provide 5 ratings, the system **switches** to using CF to leverage the wisdom of similar users.

**When to Use**: To handle **specific system states or user segments** where one algorithm is distinctly superior (e.g., cold-start vs. warm-start). It is **order-sensitive** (the switching logic defines the sequence).

### 3. Mixed Hybrid
**Methodology**: Presents recommendations from **different algorithms simultaneously** in separate UI sections. The user sees the outputs side-by-side.

**Example Scenario (Amazon Product Page)**:
- **Section A**: **"Customers who bought this also bought..."** (Item-Item Collaborative Filtering).
- **Section B**: **"Related to items you've viewed"** (Content-Based Filtering).
The user sees both lists on the same page.

**When to Use**: To **increase diversity and serendipity** by exposing the user to different recommendation rationales. It is **order-insensitive** in terms of algorithm combination, though UI layout matters.

### 4. Feature Combination Hybrid
**Methodology**: Merges **features** from different data sources into a **single, unified feature set**, which is then fed into one recommendation algorithm.

**Example Scenario (Music Recommender)**:
- **Source 1 (CF Data)**: User-song interaction matrix (implicit ratings).
- **Source 2 (CBF Data)**: Song audio features (tempo, genre, energy).
- **Combined Feature Vector**: For a user-song pair, the feature vector includes both the **user's historical interaction pattern** (encoded) and the **song's audio features**.
- **Single Algorithm**: A **neural network** or matrix factorization model is trained on this combined feature set to make predictions.

**When to Use**: When you want a **single, powerful model** that can learn complex interactions between different data types. It is **order-insensitive** for feature merging.

### 5. Cascade Hybrid
**Methodology**: Arranges algorithms in a **sequential pipeline**. The first algorithm produces a **coarse ranking or candidate set**. The second (and subsequent) algorithm(s) **refine this list**.

**Example Scenario (High-Precision News Recommender - EntréeC)**:
1.  **Stage 1 (Knowledge-Based)**: The system uses a knowledge base of news topics and user-stated interests to retrieve **100 candidate articles** that are *generally relevant*.
2.  **Stage 2 (Collaborative Filtering)**: The CF algorithm re-ranks these 100 candidates based on what **similar users engaged with**, promoting the most socially validated articles to the top 10.

**When to Use**: When you have a **high-precision, high-recall requirement** and one algorithm is good at broad recall (KB, CBF) while another is good at precision (CF). It is **highly order-sensitive**.

### 6. Feature Augmentation Hybrid
**Methodology**: Uses the **output of one algorithm** as an **input feature** for another algorithm.

**Example Scenario (Improved Rating Prediction)**:
1.  **Algorithm A (Content-Based)**: Predicts a rating for every user-item pair based on content similarity.
2.  **Algorithm B (Collaborative Filtering)**: Uses the **CBF-predicted rating** as an *additional feature* in its user-item matrix, alongside the real ratings. The CF model then makes its final prediction using this enriched data.

**When to Use**: To **boost the signal** for a primary algorithm (often CF) when data is sparse. The secondary algorithm provides "synthetic" data points. It is **order-sensitive**.

### 7. Meta-Level Hybrid
**Methodology**: Uses the **model generated by one algorithm** (not just its output) as the **input to another algorithm**.

**Example Scenario (Complex User Profiles)**:
1.  **Algorithm A (Content-Based)**: Analyzes a user's reading history and generates a **detailed user profile model** (e.g., a vector of interest weights across 500 topics).
2.  **Algorithm B (Collaborative Filtering)**: Instead of using raw ratings, the CF algorithm operates on these **CBF-generated profile vectors**. It finds users with similar *profile vectors* (not similar ratings) and recommends items they liked.

**When to Use**: When the **intermediate model** of one algorithm is a richer representation than the raw data for another algorithm to use. It is **order-sensitive**.

---
#### **Exam Practice Question 3.3**
**A travel booking site uses a Switching hybrid. For users with no booking history, it uses a Knowledge-Based system asking for destination, budget, and interests. For users with history, it uses Item-Item Collaborative Filtering. Explain one significant *advantage* and one potential *disadvantage* of this specific hybrid design.**
**[4 marks]**

**Model Answer**:
**Advantage**: It **effectively solves the user cold-start problem**. New users get immediate, useful recommendations via the interactive KB system without needing a history, providing a good initial experience.
**Disadvantage**: It creates a **potential "cliff edge" or inconsistency** in user experience. When a user crosses the threshold (e.g., makes their 5th booking), the recommendation logic switches abruptly from transparent, constraint-based KB to opaque, social CF. This sudden change could confuse users if not communicated well, potentially reducing trust.

---
## 3.7 Comparing & Selecting Hybrid Methods

**Decision Guide: Which Hybrid Method to Use?**

| If your primary challenge is...            | Consider this hybrid method...                         | Because it...                                    |
| :----------------------------------------- | :----------------------------------------------------- | :----------------------------------------------- |
| **Cold-Start (User)**                      | **Switching** or **Cascade** (KB first).               | Uses a non-CF method initially.                  |
| **Cold-Start (Item)**                      | **Weighted** or **Feature Augmentation** (with CBF).   | Incorporates item features from day one.         |
| **Data Sparsity**                          | **Feature Combination** or **Feature Augmentation**.   | Enriches the data available to the model.        |
| **Overspecialisation / Lack of Diversity** | **Mixed** or **Weighted** (with CF).                   | Introduces serendipity from other users' tastes. |
| **Need for Explainability**                | **Mixed** (show KB results) or **Cascade** (KB first). | Preserves a transparent reasoning component.     |
| **Maximising Predictive Accuracy**         | **Weighted** (ensemble) or **Cascade** (refinement).   | Combines multiple signals for a precise score.   |

**Key Features Recap for Any Algorithm**:
When analysing or designing a recommender, always specify:
1.  **Background Data**: What knowledge does it require? (e.g., user-item matrix, item features, knowledge base).
2.  **Input Data**: What does it need at runtime for a specific user? (e.g., user's rating history, current query).
3.  **Algorithm**: What is the core computational process? (e.g., find k-NN, compute cosine similarity, apply constraint rules).

---
#### **Exam Practice Question 3.4**
**For a *music streaming service*, propose a specific *Cascade Hybrid* design to address both *item cold-start* (new songs) and *user taste diversification*. Name the two base techniques, specify the order, and briefly describe the data flow.**
**[5 marks]**

**Model Answer**:
**Cascade Hybrid: Content-Based Filtering (CBF) followed by Collaborative Filtering (CF)**.
**Order & Data Flow**:
1.  **First Stage (CBF)**: For a given user, the system uses their profile (based on listened songs) and *all songs in the catalogue* (including new ones with metadata). It computes content similarity and produces a **broad candidate list of 500 songs**. This ensures **new songs are included**.
2.  **Second Stage (CF)**: The system takes this candidate list and applies **Item-Item CF**. It re-ranks the 500 songs based on what users with *similar tastes* have actually played, promoting socially validated songs. This introduces **diversification** based on community wisdom, moving beyond the user's own profile bubble.
**Result**: New songs are in the running (via CBF), but the final ranking is influenced by broader community trends (via CF).

## 3.8 Evaluation of Recommender Systems

> Systematic **evaluation** is critical for selecting, tuning, and improving recommender algorithms. It moves from offline **prediction accuracy** to online **business impact** and **user-centric qualities**.

### 3.8.1 Data-Driven (Offline) Evaluation
Evaluates algorithms using pre-collected historical data (e.g., MovieLens dataset). A **training-test split** is used.

#### 1. Rating Prediction Accuracy Metrics
Assess how close predicted ratings are to actual user ratings.

| Metric | Formula | Interpretation & Use |
| :--- | :--- | :--- |
| **Mean Absolute Error (MAE)** | $$MAE = \frac{1}{n} \sum_{i=1}^{n} \|p_i - r_i\|$$ | Average **magnitude** of error. Simple, interpretable. |
| **Root Mean Squared Error (RMSE)** | $$RMSE = \sqrt{\frac{1}{n} \sum_{i=1}^{n} (p_i - r_i)^2}$$ | Penalises **large errors more severely** than MAE. Standard in competitions (e.g., Netflix Prize). |

**Example Calculation**:

| Item | Predicted (p) | Actual (r) | \|p-r\| | (p-r)² |
| :--- | :---: | :---: | :---: | :---: |
| i1 | 1 | 2 | 1 | 1 |
| i2 | 4 | 1 | 3 | 9 |
| i3 | 2 | 2 | 0 | 0 |
| i4 | 2 | 4 | 2 | 4 |
| i5 | 3 | 1 | 2 | 4 |
| i6 | 1 | 1 | 0 | 0 |
| i7 | 3 | 3 | 0 | 0 |
| **Sum/Avg** | | | **8** | **18** |
| **MAE** = 8/7 ≈ **1.14** | | | **RMSE** = √(18/7) ≈ **1.60** |

**Situation for Use**: When the system's core task is to **predict exact ratings** (e.g., a movie rating prediction service). **RMSE is more sensitive to large errors**, which may be critical if you want to avoid recommending items the user will strongly dislike.

#### 2. Decision Support Accuracy (Top-N Recommendation)
Assesses the quality of a **ranked list of recommendations**. Treats recommendation as a **retrieval task**.

**Confusion Matrix for a Single User & Item**:
| | User **Likes** Item | User **Dislikes** Item |
| :--- | :---: | :---: |
| **System Recommends** | **True Positive (TP)** | **False Positive (FP)** |
| **System Does Not Recommend** | **False Negative (FN)** | **True Negative (TN)** |

**Derived Metrics**:
- **Precision@N**: Of the top N recommended items, how many were actually relevant?
  $$Precision@N = \frac{\#\text{ of relevant items in top N}}{N}$$
  *Focus: Minimising false positives (bad recommendations).*
- **Recall@N**: Of all the relevant items, how many did we manage to recommend in the top N?
  $$Recall@N = \frac{\#\text{ of relevant items in top N}}{\text{Total \# of relevant items}}$$
  *Focus: Minimising false negatives (missed good items).*
- **F1-Score@N**: Harmonic mean of Precision and Recall.
  $$F1@N = 2 \cdot \frac{Precision@N \cdot Recall@N}{Precision@N + Recall@N}$$

**Example Scenario (Music Recommender - Top 5)**:
- System recommends songs: {S1, S2, S3, S4, S5}.
- User actually likes: {S1, S3, S6, S7}.
- **Relevant in top N**: S1, S3.
- **Precision@5** = 2/5 = **0.4**.
- **Recall@5** = 2/4 = **0.5** (assumes 4 total liked songs).
- **Trade-off**: Increasing N typically **increases Recall** (catch more good items) but **decreases Precision** (more bad items sneak in).

**Situation for Use**: For **real-world recommenders** that produce a shortlist (e.g., "Recommended for You" row). More reflective of user experience than rating accuracy.

### 3.8.2 Beyond Accuracy: Other Critical Metrics
Accuracy alone is insufficient. A system with high accuracy might recommend only obvious, popular items.

| Property | Metric/Description | Why it Matters |
| :--- | :--- | :--- |
| **Coverage** | % of items in catalogue the system can recommend. | Ensures the **"long tail"** of niche items is reachable. A system recommending only blockbusters has low coverage. |
| **Novelty** | Recommends items **new to the user** (not consumed before). | Prevents boredom and repetitiveness. |
| **Serendipity** | Recommends **surprisingly relevant** items—new to the user *and* unexpectedly good. | Drives discovery and user delight. Essential to break **filter bubbles**. |
| **Diversity** | How **dissimilar** recommended items are from each other. Measured by intra-list distance. | Provides choice and caters to multiple interests within a single list. |

**Algorithm Tendencies**:
- **Collaborative Filtering**: Naturally provides some novelty/serendipity via social discovery, but suffers from **popularity bias**.
- **Content-Based Filtering**: Poor at novelty/serendipity (trapped in filter bubble) but can have high precision.
- **Knowledge-Based Systems**: Can explicitly engineer for serendipity via reasoning in knowledge graphs.

### 3.8.3 Experimental Studies with Users

#### A/B Testing (Online Experiment)
The **gold standard** for evaluating impact on real user behaviour in a live system.

**Methodology**:
1.  Randomly split user traffic into **Control Group (A)** and **Treatment Group (B)**.
2.  Group A sees the **original** recommender (or no personalisation). Group B sees the **new** recommender algorithm/interface.
3.  Measure **Key Performance Indicators (KPIs)** over a set period.
4.  Perform statistical tests to determine if differences are significant.

**Example Metrics for A/B Testing**:
- **Utility Metrics**: **Click-Through Rate (CTR)**, conversion rate, purchase value, session length.
- **Engagement Metrics**: Number of return visits, time spent.
- **Business Metrics**: Revenue, retention rate.

**Situation for Use**: To **validate the real-world business impact** of a new algorithm before full deployment. It measures what users *do*, not just what they say.

#### User Studies (Lab/Controlled Experiment)
Involves a smaller group of participants performing tasks with the system, followed by surveys and interviews.

**Measures**: **Subjective feedback** on trust, satisfaction, perceived usefulness, comprehensibility of recommendations.
**Situation for Use**: To evaluate **user experience qualities** that logs cannot capture, especially during the design phase.

### 3.8.4 The Netflix Prize Case Study
**Goal**: Improve Netflix's rating prediction (Cinematch) by 10% (reduce RMSE).
**Outcome**: The winning team (**BellKor's Pragmatic Chaos**) used a **blended ensemble of over 100 models**, including:
- **Matrix Factorization** variants (SVD, SVD++).
- **Restricted Boltzmann Machines (RBMs)**.
- **Neighbourhood models**.
**Key Insight**: No single algorithm was best. The **hybrid ensemble** (a form of **Weighted hybridisation**) achieved the winning result by **averaging out the errors** of diverse models. This demonstrates the supremacy of hybrid approaches for maximising **accuracy metrics** like RMSE.

---
#### **Exam Practice Question 3.5**
**A/B testing is used to compare a new hybrid recommender (B) against the old content-based one (A). After one week, the *Click-Through Rate (CTR)* on recommendations is 5.2% for Group A and 5.5% for Group B. The product manager wants to deploy B immediately. As a responsible data scientist, what critical question would you ask before agreeing?**
**[3 marks]**

**Model Answer**:
**Is the difference statistically significant?** A 0.3% point increase could be due to **random variation** and not a true effect of the new algorithm. We must perform a **statistical significance test** (e.g., a chi-squared test or t-test on the proportions) to calculate a p-value. Only if the p-value is below a threshold (e.g., 0.05) can we confidently attribute the increase to the algorithm change and justify deployment.

---
#### **Exam Practice Question 3.6**
**Calculate the *Precision@3* and *Recall@3* for a user given the following: The system's top 3 recommendations are [ItemA, ItemB, ItemC]. The user's set of *truly relevant* items (based on their hidden ratings) is {ItemA, ItemD, ItemF}.**
**[3 marks]**

**Model Answer**:
- **Relevant items in top 3**: Only **ItemA**.
- **Precision@3** = (Number of relevant in top 3) / 3 = **1/3 ≈ 0.33**.
- **Recall@3** = (Number of relevant in top 3) / (Total number of relevant items) = **1/3 ≈ 0.33**.
*(Note: Recall uses the total relevant set size, which is 3 in this case.)*
## 3.9 Machine Learning-Based Recommender Systems

> **ML-based Recommender Systems** use advanced machine learning models to learn complex patterns from multi-dimensional data (user, item, context, sequence) to generate highly personalised, scalable, and adaptive recommendations.

### 3.9.1 Core Components & Pipeline
The development and deployment of an ML-based recommender follows a structured pipeline.

| **ML-Based Recommender System Architecture** |
| :--- |
| ![[ml-based-recommender-arch-steps.png\|500]] |

#### 1. Data Collection & Storage
Gathers diverse data needed for modelling.
- **User Data**: Demographics, preferences.
- **Item Data**: Features, categories, metadata.
- **Interaction Data**: Historical clicks, ratings, purchases (the user-item matrix).
- **Contextual Data**: Time, location, device, weather (critical for real-time adaptation).
- **Storage**: Data lakes, SQL/NoSQL databases.

**Example - MoveApp (Physical Activity Recommender)**:
- **Context Data**: Time of day, current weather (from API), user's location (GPS), today's step count (accelerometer).
- **User Profile**: Explicit goals (e.g., "Walk 10,000 steps/day").
- **Micro-profile**: Current mood, motivation (via in-app feedback).
- **Feedback**: User responses to suggestions ("too intense", "I'm at work").

#### 2. Data Preprocessing
Prepares raw data for model consumption.
- **Cleaning**: Handle missing values, remove outliers.
- **Normalization/Scaling**: Ensure features (e.g., step count, time) are on comparable scales.
- **Feature Engineering**: Create informative features (e.g., "is_weekend", "steps_remaining_today").
- **Encoding**: Convert categorical data (e.g., weather type) to numerical form (one-hot encoding).
- **Dimensionality Reduction**: Use PCA or autoencoders if feature space is too large.

**Example - MoveApp Preprocessing**: Weather categories (`rain`, `sunny`) are one-hot encoded. Step count is normalized relative to user's goal. Time is converted to cyclical features (sine/cosine of hour) to represent 24-hour periodicity.

#### 3. Model Selection & 4. Training/Optimization
Choosing and training the ML model.

| Model Category | Example Algorithms | Characteristics & Use Case |
| :--- | :--- | :--- |
| **Traditional ML** | **Random Forest (RF)**, Decision Trees, SVM, Bayesian Networks. | **Interpretable**, handles tabular data well, good for **feature importance analysis**. Use when explainability is key. |
| **Deep Learning** | **Neural Networks**, Autoencoders. | Captures **complex non-linear patterns** in high-dimensional data (e.g., raw text, images). |
| **Temporal/Sequential DL** | **Recurrent Neural Networks (RNNs)**, LSTMs, Transformers. | Models **user behaviour sequences** (e.g., watch history). Essential for "next-in-sequence" recommendations. |

**Example - MoveApp Model Selection**:
- **Chosen Algorithm**: **Random Forest**.
- **Justification**:
    1.  **Handles mixed data types** (categorical weather, numerical steps).
    2.  Provides **feature importance** (to understand what factors—weather, time—drive recommendations).
    3.  **Robust to overfitting** via ensemble of trees.
    4.  **Fast training & inference**, suitable for a mobile app.
- **Training & Optimization**:
    - **Metric**: Classification **Accuracy** (predicting if user will accept/reject an activity).
    - **Hyperparameter Tuning**: Used **Randomized Search** with **5-fold cross-validation**.
    - **Optimal Parameters**: `max_depth=6`.
    - **Result**: Train accuracy = 0.764, Test accuracy = 0.663.

#### 5. Recommendation Generation
The trained model is used to score and rank items for a user.
- **Prediction**: The model outputs a score (e.g., probability of engagement) for each candidate item.
- **Ranking**: Items sorted by predicted score.
- **Filtering**: Apply business rules (e.g., remove already purchased items, enforce diversity).

#### 6. Deployment & Serving
Putting the model into production.
- **Deployment Platforms**: TensorFlow Serving, AWS SageMaker, custom REST API.
- **Real-Time Serving**: Use low-latency databases (Redis) for feature lookup and model scoring.
- **Scalability**: Use distributed systems (Apache Spark) for batch recommendations or model training.

**Example - MoveApp Deployment (7-Step Cascade)**:
The system is not a single model but a **cascade of filters and recommenders**:
1.  **User Profile Filter**: Remove activities mismatching explicit goals (e.g., no running if knee injury).
2.  **Weather/Daylight Filter**: Remove outdoor activities if raining/dark.
3.  **Micro-Profile Filter**: Adjust for current mood/motivation.
4.  **Content-Based Recommendation**: Score remaining activities based on similarity to past enjoyed activities (using 24 metadata attributes).
5.  **Context-Based Post-Filter**: Re-rank based on immediate context (e.g., location near a park).
6.  **Adaptive Progression**: Gradually increase suggested activity duration/intensity.
7.  **Just-in-Time Intervention**: Deliver the recommendation at an opportune moment.

#### 7. User Interface & Feedback Loop
- **UI**: Presents recommendations in the app/website.
- **Feedback Collection**: **Implicit** (did they start the activity? for how long?) and **Explicit** (star ratings, "too intense" feedback).
- **Continuous Learning**: The system **retrains periodically** (e.g., daily) with new feedback data to adapt to changing user preferences and contexts.

**Example - MoveApp Feedback Loop (A/B Testing)**:
- **Experimental Design**: **Randomized Controlled Trial**.
    - **Group A (Experimental)**: Received the full 7-step cascade algorithm.
    - **Group B (Control)**: Received only steps 1-2, 6-7 + **random suggestions** instead of personalised steps 3-5.
- **Results**: Group A showed **significantly higher star ratings**, **greater motivation**, **larger increase in physical activity**, and **lower dropout rates**. This proved the value of the personalised ML components.

---
#### **Exam Practice Question 3.7**
**The MoveApp team chose a *Random Forest* model. For a different recommender system that must predict the *next movie a user will watch* based on their *sequential viewing history*, why would a Random Forest be a *poor* choice compared to a model like an LSTM?**
**[4 marks]**

**Model Answer**:
**Random Forest** is a poor choice because it **cannot inherently model temporal sequences or long-term dependencies**. It treats each data point (e.g., a user-movie interaction) as independent and identically distributed (i.i.d.), ignoring the **order** of movies watched. An **LSTM (Long Short-Term Memory)**, a type of Recurrent Neural Network, is specifically designed to process **sequential data**. It maintains a hidden state that captures context from previous items in the sequence, allowing it to learn patterns like "users who watched Action A then Comedy B often watch Drama C next." This makes LSTMs far more suitable for next-in-sequence prediction tasks.

---
### 3.9.2 Industry Case Studies

#### Amazon: From Item-Item CF to Deep Learning
**Evolution**:
1.  **Foundational Algorithm (c. 1998)**: **Item-to-Item Collaborative Filtering**. Solved **scalability** by pre-computing item similarities offline. Corrected early statistical bias related to heavy buyers.
2.  **Modern Prime Video (c. 2016)**: **Deep Learning Autoencoders**. Initially failed because they reconstructed the *entire* user history, ignoring **temporal dynamics** (users want recent content). The breakthrough was the **Temporal Autoencoder**, trained to predict what a user would watch in the **next 1-2 weeks**. This **doubled performance** over item-item CF.

**Key Insight**: Success requires adapting the ML model to the **domain's fundamental characteristics**—for video, **relevance decays rapidly with time**.

#### Netflix & YouTube: Deep Hybrid Systems
- **Netflix**: Uses a **hybrid of CF and Deep Learning**. Models consider viewing history, time of day, device, and even **video artwork** to predict engagement.
- **YouTube**: Employs **deep candidate generation models** (using user and video embeddings) followed by a **separate ranking model** that weighs predicted watch time, user satisfaction, and diversity. Heavily uses **sequence models** for "next video" recommendation.

### 3.9.3 Reinforcement Learning for Real-Time Recommendation
**Concept**: Treats recommendation as a **sequential decision-making problem**. The system (agent) recommends an item (action) to the user (environment), receives feedback (reward—e.g., click, purchase), and updates its strategy (policy) to maximise long-term cumulative reward (e.g., total engagement).

| E-commerce Recommender using RL     |
| :--- |
| ![[ecommerce-recommender.png\|500]] |

**Example - Real-Time E-commerce**:
- **State (s_t)**: User's current session history, profile, context.
- **Action (a_t)**: Which product to recommend next.
- **Reward (r_t)**: Immediate feedback (click, add to cart, purchase).
- **Policy (π)**: The RL model that learns to map states to actions that maximise expected future purchases.

**Advantage**: Optimises for **long-term user value** rather than just immediate click-through. Can strategically explore new items to learn user preferences.
# Topic 4: Adaptive Content Presentation

> **Adaptive Content Presentation** tailors not just *what* information a user sees (selection), but also *how* that information is structured and presented (presentation) based on their user model. It is a two-step process: **Content Selection** followed by **Content Presentation**.

### Link to Recommender Systems
- **Content Selection** is analogous to a **recommender system's filtering/ranking** stage.
- **Content Presentation** is the **adaptive generation of the UI/content layout** that delivers those selected items.

## 4.1 Static & Semi-Automatic Approaches

These methods use **pre-authored content components** assembled dynamically.

### 1. Page-Based Approach
The simplest method. The system selects from a set of **complete, pre-defined pages**.

| **Page-Based Adaptation** |
| :--- |
| ![[page-based-adaptation.png\|500]] |

**Methodology**:
1.  Authors create multiple versions of a page for different user states (e.g., "Beginner Page", "Expert Page").
2.  The user model (e.g., `knowledge_level`) is evaluated.
3.  The system selects and serves the appropriate pre-built page.

**Example - KBS Hyperbook**: An adaptive educational system that selects different **pre-authored project pages, learning trails, and goal descriptions** based on the student's knowledge and learning goals.

**Advantages**:
- **Versatile & Simple**: Easy to implement and control.
- **High-Quality Content**: Pages are fully authored/curated.

**Disadvantages**:
- **Static & Inflexible**: Cannot create novel combinations.
- **Authoring Bottleneck**: Requires creating and maintaining many page variants, which is **expensive and unscalable**.

### 2. Fragment-Based Approach (Semi-Automatic)
A more flexible method. Pages are constructed from **smaller, reusable content fragments**.

#### a) Optional Fragments
- **Methodology**: Each fragment has **applicability conditions** based on the user model. The page is composed by including all fragments whose conditions are true.
- **Architecture**: `Page = {Fragment | Condition(Fragment, UserModel) = TRUE}`

| **Optional Fragments Example** |
| :--- |
| ![[optional-fragments.png\|500]] |

**Example - AVANTI (Web Accessibility System)**: A page for a tourist site includes a basic description fragment for all users. An **optional fragment** with detailed historical context is included **only if** `user_knowledge > beginner`. Another optional fragment with wheelchair access details is included **only if** `user_has_mobility_impairment = TRUE`.

**Advantages**:
- **Flexible & Reusable**: Fragments can be mixed and matched across many pages.
- **Easier Authoring**: Creating small fragments is less work than full pages.

**Disadvantages**:
- **Combinatorial Complexity**: Managing conditions for many fragments is **error-prone**.
- **Coherence Risk**: Combined fragments may not flow well together stylistically.

#### b) Altering Fragments
- **Methodology**: The page has a fixed **structure of slots (constituents)**. For each slot, there is a set of alternative fragments. The system selects the most appropriate fragment for each slot.
- **Architecture**: `Page = [Slot1: Fragment_X, Slot2: Fragment_Y, ...]` where Fragment_X is chosen from a set for Slot1.

| **Altering Fragments Example** |
| :--- |
| ![[altering-fragments.png\|500]] |

**Example - AHA! (Adaptive Hypermedia System)**:
- A page has a **navigation frame** (a constituent) and a **content frame** (another constituent).
- For the navigation constituent, the system selects a fragment containing links appropriate to the user's knowledge (hiding advanced links for novices).
- For the content constituent, it selects a text fragment at the right detail level.

**Advantages**:
- **Better Coherence**: The fixed slot structure ensures a logical page layout.
- **Controlled Flexibility**: Authors define the slots, maintaining design control.

**Disadvantages**:
- **Authoring Overhead**: Requires defining the slot structure upfront.
- **Static Structure**: The slot template itself cannot adapt.

---
#### **Exam Practice Question 4.1**
**A university's online module description page uses an *Altering Fragments* approach. It has two constituents: 'Prerequisites' and 'Assessment Details'. Describe two different user model attributes that could drive the selection of different fragment alternatives for these constituents.**
**[4 marks]**

**Model Answer**:
1.  **'Prerequisites' Constituent**: Selection driven by **user knowledge level**. For a user model with `knowledge_level = novice`, the system selects a fragment listing *all* prerequisite modules with brief explanations. For `knowledge_level = expert` (e.g., a lecturer), it selects a minimal fragment listing only module codes.
2.  **'Assessment Details' Constituent**: Selection driven by **user role**. For `role = student`, the fragment details deadlines, submission formats, and marking criteria. For `role = external_examiner`, the fragment focuses on assessment strategy and moderation procedures.

---
## 4.2 Automatic Approaches (Dynamic Generation)

These methods **generate content on-the-fly** from underlying data/knowledge models, offering maximum flexibility. This is an active research area, increasingly using **Natural Language Generation (NLG)** and **Large Language Models (LLMs)**.

### Key Systems & Techniques
| System/Technique | Core Idea | Adaptation Mechanism |
| :--- | :--- | :--- |
| **ILEX** | Generates **museum object descriptions** in natural language. | Uses a **domain model** (semantic network of artifacts) and a **user model** (interests). Selects concepts based on **structural relevance** in the network and **user interest**. Generates coherent text linking these concepts. |
| **GEA (Generator of Evaluative Arguments)** | Generates **justifications for recommendations** (e.g., why a house is good for you). | Uses a **hierarchical user preference model** (value tree). Computes how much each attribute (e.g., garden size) contributes to the item's overall utility for the user. Selects attributes whose contribution exceeds a threshold and generates a persuasive argument focusing on them. |
| **RIA (Responsive Information Architect)** | Generates **multi-dimensional data presentations** (e.g., charts, text summaries). | Formalises selection as an **optimisation problem**. Maximises a *desirability* score based on content features, user features (e.g., expertise), and interaction history. Can produce radically different presentations (a detailed table vs. a simple chart) for the same data based on the user. |

### Modern Examples with LLMs & NLG
1.  **Recipe Recommender with Justifications (Starke et al.)**:
    - **Task**: Recommend healthy recipes and **explain why** they are suitable.
    - **Method**: Uses a **rule-based NLG system** to generate sentences like "This recipe is a good choice because it is **low in sugar** and **high in fibre**, which aligns with your health goals."
    - **Adaptation**: The justification focuses on the **user's stated health goals** (from the user model).

2.  **Automated Movie Explanations with ChatGPT (Silva et al.)**:
    - **Task**: Generate **natural language explanations** for movie recommendations.
    - **Method**: Uses **ChatGPT** prompted with user profile data (liked movies, genres) and movie metadata.
    - **Adaptation**: The LLM tailors the explanation's focus. For a user who likes directors, it might say "Recommended because it's by the same director as *Movie X* which you rated highly." For a genre-focused user, it highlights genre alignment.

3.  **Personalised Video Narrative Generation (Abrar Mohammed)**:
    - **Task**: Assemble educational videos from segmented clips.
    - **Method**: 1) Selects video segments based on concepts linked via a **domain taxonomy**. 2) Generates **linking voiceover text** automatically using NLG to create a coherent narrative.
    - **Adaptation**: The selection of concepts and the complexity of the linking narrative are adapted to the learner's **knowledge level** in the user model.

### Presentation Techniques: Managing Relevance & Focus
Once content is selected, it must be presented effectively. A key trade-off is **Focus vs. Context**.

| Technique | Description | Preserves Context? | Conveys Priority? |
| :--- | :--- | :--- | :--- |
| **Stretchtext** | Secondary content is hidden behind clickable placeholders/headings. | **Yes** (structure visible). | **Moderate** (indicates there is more). |
| **Dimming/Fading** | Less relevant content is visually de-emphasised (lower contrast). | **Yes**. | **Strong** (clear visual hierarchy). |
| **Colouring** | Relevant content is highlighted with a background colour. | **Yes**. | **Very Strong**. |
| **Sorting** | Lists are ordered by relevance (most relevant first). | **No** (changes order). | **Strong** (position indicates priority). |
| **Scaling (Fisheye View)** | Font size is proportional to the "Degree of Interest" (relevance). | **Partial** (some context is shrunk). | **Very Strong**. |

**Situation for Use**: **Dimming/Fading** is good for preserving full context while guiding attention. **Sorting** is best for unstructured lists where order doesn't convey intrinsic meaning.

---
#### **Exam Practice Question 4.2**
**Comparing *Optional Fragments* and *Altering Fragments* approaches, which one is more likely to guarantee a coherent and well-structured final page? Justify your answer by referring to their underlying methodologies.**
**[3 marks]**

**Model Answer**:
**Altering Fragments** is more likely to guarantee coherence. Its methodology is based on a **pre-defined page structure (slots/constituents)** set by the author, which ensures a logical layout and that all necessary page components are present. **Optional Fragments** lacks this structural backbone; it simply includes all fragments that match conditions, which can lead to pages missing key components or having a jumbled, incoherent flow if fragments are not meticulously designed to fit together in any combination.
