# Test Questions
## Outline
**Topic 1: General architecture of user-adaptive systems**
- introduction, main components, role and importance
- examples and application in real contexts
**Topic 2: User model representation and building**
- user model representation
- user model building
- explicit and implicit models
- cold start, stereotypes
**Topic 3: Recommender systems**
- recommender systems types
- content-based filtering
- knowledge-based recommenders
- collaborative filtering
- hybrid recommender systems
- adapting recommendations to groups
- recommender systems evaluation
**Topic 4: Adaptive content presentation**
- static approaches for content adaptation
- dynamic approaches for content adaptation
**Topic 5: Evaluation of user-adaptive systems**
- layered evaluation
- usability threats
**Topic 6: Responsible personalisation**
- responsible personalisation principles
- privacy, transparency, explanation, and trust
## Topic 1.1:  Core Definitions & Principles
### Question 1.1: General Architecture & Component Roles
A city council is developing a **"Smart Park" mobile app**. The app uses GPS to detect when a user enters a park. It then checks the user's profile (e.g., "dog owner", "jogger", "family with young children") and current weather data to send personalised push notifications. For example, it might notify a dog owner about a nearby dog-friendly area, or a family about a children's event starting soon.

**(a) Map the description of the Smart Park app onto the *general architecture* of a user-adaptive system. For each of the four core components (excluding the Domain Model), state what it would be in this specific case.**
[6 marks]

**(b) The system uses the current *weather* (e.g., rainy vs. sunny) as a key factor in deciding what to recommend. According to the framework discussed in lectures, is weather part of the *User Context* or the *Environment Context*? Justify your answer.**
[2 marks]

**(c) One proposed feature is to let users manually correct their inferred profile (e.g., change from "jogger" to "walker"). Explain which major *usability threat* of adaptive systems this feature directly helps to mitigate.**
[2 marks]

---
#### Model Answer 1.1
**(a) Mapping to General Architecture:**
1.  **User Data Gathering**: This component collects **raw input data**. In the Smart Park app, this includes the user's **GPS location** (to detect park entry), their **stored user profile** (e.g., "dog owner"), and the **current weather data** fetched from an API.
2.  **User Model Acquisition**: This is the **inference engine**. It processes the raw data to create/update the **user model**. Here, it takes the GPS signal and matches it to a park boundary (interpretation), and retrieves the user's stored profile tags. It may also infer temporary states (e.g., "likely exercising" if speed is high).
3.  **User Model**: This is the **structured internal representation**. For this app, the user model contains the **categorical tags** (dog owner, jogger), potentially with associated **confidence levels**, and may include the **current inferred activity**.
4.  **User Model Application (Adaptation Model)**: This is the **decision logic**. It uses the user model and external data (weather, event database) to choose an adaptation. Its rules might be: `IF (user_model includes "dog_owner") AND (weather = "dry") THEN recommend "dog park area"`.
5.  **Adaptive Component**: This is the **output effector**. In this case, it is the **push notification system** that delivers the personalised message to the user's phone screen.

**(b) Weather Context Classification:**
Weather is part of the **Environment Context**.
**Justification**: The framework distinguishes between **User Context** (attributes directly pertaining to the user, e.g., their emotional state, current task) and **Environment Context** (attributes of the surrounding physical and social environment). Weather is an **external environmental condition** that affects the appropriateness of recommendations (e.g., suggesting an outdoor event is poor in the rain) but is not an attribute *of* the user themselves.

**(c) Mitigated Usability Threat:**
This feature mitigates the threat of **Diminished Controllability**.
**Explanation**: A system that automatically infers a user's profile (e.g., labels them as a "jogger") can make mistakes. If the user cannot correct this, they feel a **loss of agency and control** over the system's behaviour. Allowing **manual profile correction** directly restores user control by letting them rectify erroneous inferences, ensuring the system adapts based on an accurate model that aligns with their self-view.

---
### Question 1.1.1: Definitions and Drivers
A major online newspaper is struggling with declining user engagement. Analytics show that readers often leave the site after viewing only one article, citing "too much irrelevant content."

**(a) Identify *two* distinct **drivers for personalisation** from the provided context that justify implementing a user-adaptive system for this newspaper. Explain how each driver relates to the problem described.**
[4 marks]

**(b) The newspaper's technical team proposes a simple 'customisable' homepage where users can manually select their favourite topics (e.g., Politics, Sports). State whether this is an example of a **User-Adaptable** or **User-Adaptive** system. Using the **core principle** of personalisation, explain one limitation of this approach compared to a fully adaptive one.**
[4 marks]

---
#### Model Answer 1.1.1
**(a) Drivers for Personalisation:**
1.  **Information Abundance and Noise**: The site has "too much irrelevant content." This represents **information overload** where the sheer volume and heterogeneity of articles makes it difficult for users to find relevant information. A user-adaptive system can **filter and prioritise** content, cutting through the noise.
2.  **Diverse User Interests and Goals**: Readers have different preferences (some want Politics, others Sports). The **one-size-fits-all** front page fails because people have **diverse backgrounds and intentions**. Personalisation aims to deliver the **right information to the right person**, matching content to individual user profiles inferred from their behaviour.

**(b) System Type and Limitation:**
- **Type**: This is a **User-Adaptable (Customisable)** system, as the user **manually modifies** the system's configuration by selecting their preferred topics.
- **Limitation (Using the Core Principle)**: A key part of the core principle is delivering the right information at the **right time**. A static, user-configured topic list is **inflexible and cannot adapt to changing context or evolving interests**. For example, if a major sports event ends and a user's interest in that topic wanes, the adaptable system will keep showing it, failing to deliver the "right" content for the user's *current* needs. An adaptive system could learn this shift implicitly and adjust the feed dynamically.

---
### Question 1.1.2: Applying Principles to Examples
Consider the **ECoach** system (personalised university coaching) and the **MoCoMapps** system (personalised travel assistant).

**(a) For *each* system, provide a concrete example of how it implements the principle of delivering the **right information at the right time**. Your example must refer to a specific adaptive feature of the system.**
[4 marks]

**(b) These systems collect different types of data to function. **ECoach** has access to student information system data (grades, enrolment). **MoCoMapps** primarily uses location from a phone's GPS. For *one* of these systems, identify a potential **privacy concern** arising from this data collection and suggest a **mitigating design practice**.**
[4 marks]

---
#### Model Answer 1.1.2
**(a) Right Information at the Right Time:**
- **ECoach**: The system delivers **targeted study advice and reminders** shortly before an upcoming assignment deadline or exam ("the right time"), based on the student's calendar and past performance data. The advice is the "right information" as it is tailored to the specific module and the student's identified knowledge gaps.
- **MoCoMapps**: When the system detects the user is **physically near a point of interest (POI)** such as a tourist attraction ("the right time"), it pushes a notification with relevant details about that POI. The information is "right" because it is filtered by the user's stated interests (e.g., history, food) and is immediately actionable in that location.

**(b) Privacy Concern and Mitigation:**
**System Chosen: ECoach**
- **Privacy Concern**: **Inferential Privacy and Lack of Student Control**. Using data from the student information system (SIS) for adaptive coaching could lead to **sensitive inferences** about a student's mental health, academic struggles, or potential for dropping out, without the student's full awareness or consent. This data, used for a purpose (coaching) beyond its original administrative purpose, creates a **transparency and control** deficit.
- **Mitigating Design Practice**: Implement a **scrutable user model** with clear **opt-in/opt-out controls**. Students should be able to inspect what data ECoach has sourced from the SIS, understand what inferences have been made (e.g., "classified as 'at-risk'"), and have the ability to **correct data or disable specific adaptive features** based on that data. This practice aligns with the principles of **transparency and user controllability**.

---
### Question 1.1.3: Learning Objectives and System Categorisation
A new "Smart Recipe Manager" app is described. It learns your cooking preferences from the recipes you view and save. Over time, it automatically highlights recipes on food blogs that match your taste and filters out recipes containing ingredients you always skip. It also has a "Surprise Me" button that uses this learned profile to suggest a novel recipe you might like.

**(a) This app's core functionality is best described as which type of personalisation: **User-Adaptable**, **User-Adaptive**, or **Intermediate/Mixed-Initiative**? Justify your answer by referencing *who* controls the key adaptation.**
[2 marks]

**(b) The development of this app directly addresses two of the module's **Learning Objectives (LOs)**. Identify **LO2** and **LO3** and briefly explain how the app's described features relate to each.**
[4 marks]

---
#### Model Answer 1.1.3
**(a) System Type and Justification:**
- **Type**: **User-Adaptive**.
- **Justification**: The key adaptations—**automatically highlighting** matching recipes and **filtering out** disliked ingredients—are performed **autonomously by the system** based on its learned model of user preferences. The user does not manually set rules for highlighting or filtering; the system **modifies its own behaviour** independently. (The "Surprise Me" button is an optional user-initiated action on top of this adaptive backbone).

**(b) Learning Objectives:**
- **LO2: Identify & apply common user modelling & adaptation techniques**. The app **builds a user model** (a profile of taste and ingredient preferences) through **implicit information collection** (monitoring views and saves). It then **applies** this model using **content-based filtering** (matching recipe features to profile) to perform adaptation (highlighting, filtering).
- **LO3: Implement recommender system techniques**. The core adaptive feature is a **recommender system**. The "Surprise Me" function is a direct application of a recommendation algorithm (likely a hybrid of content-based and novelty-seeking) that generates a personalised item suggestion for the user.
## Topic 1.2: Components & Schema
### Question 1.2: Case Study Analysis & Comparison
Compare and contrast the **LILSYS** call-screening system and a modern **Smart Speaker** (e.g., Amazon Alexa) that adapts its responses based on the user's voice tone and time of day.

**(a) Describe one key *similarity* in the type of *user data* both systems rely on for adaptation.**
[2 marks]

**(b) Describe one fundamental *difference* in their *primary adaptation goal*.**
[2 marks]

**(c) The smart speaker uses voice tone analysis to infer if the user is stressed and might then respond with a calmer tone. Identify the *layer* in the layered evaluation framework where you would test whether the tone analysis correctly identifies stress, and name a suitable *evaluation method* for this layer.**
[4 marks]

---
#### Model Answer 1.2
**(a) Similarity in User Data:**
Both systems rely heavily on **implicitly collected contextual and behavioural data** about the user's **current situation**. LILSYS uses **sensor data** (movement, keyboard activity) to infer availability. The smart speaker uses **vocal prosody** (tone, pitch, speed) and **temporal context** (time of day) to infer emotional state and intent. Neither requires the user to explicitly state their state ("I'm busy" / "I'm stressed").

**(b) Difference in Adaptation Goal:**
The **primary adaptation goal** of LILSYS is to **discourage or mediate interaction** (from the outside world) by screening calls to prevent interruptions. In contrast, the primary adaptation goal of the smart speaker is to **encourage and facilitate interaction** (with itself) by tailoring its responses to be more effective and engaging for the user. LILSYS adapts to *protect* the user's attention; the smart speaker adapts to *capture* and retain the user's attention.

**(c) Layered Evaluation:**
- **Layer**: This problem belongs to **Layer 2: Interpretation of the Collected Data**.
- **Reasoning**: The raw data (audio signal) has been collected. The challenge is whether the system's **interpretation** of that data—mapping specific acoustic features to the internal state label "stressed"—is **valid**.
- **Evaluation Method**: A suitable method would be a **user study with ground truth validation**. Participants would use the speaker while also self-reporting their stress levels via a validated method (e.g., a simple questionnaire or physiological sensor). The system's inferences would then be compared to the user-reported ground truth to calculate **accuracy metrics** (e.g., precision, recall) for stress detection, diagnosing the validity of the interpretation algorithm.
### Question 1.2.1: Component Identification & Role
A university library introduces a "Personalised Research Assistant" on its website. It monitors the abstracts of journal articles a student reads online. It then uses a subject ontology (e.g., the ACM Computing Classification System) to tag those articles with topics. Based on the frequency of these topics, it builds a profile of the student's research interests. Finally, it uses this profile to recommend new, recently published articles in the library's database that align with those interests.

**(a) For this system, identify the components that fulfil the roles of the **User Data Gathering** and the **User Model**. For each, specify the *specific data or structure* involved in this scenario.**
[4 marks]

**(b) The system relies heavily on the **Domain Model**. Describe what the Domain Model is in this case and explain its **critical importance** for the system's function.**
[3 marks]

---
#### Model Answer 1.2.1
**(a) Component Identification:**
1.  **User Data Gathering**: This component collects the **raw behavioural data**. In this scenario, it is the system that **monitors and records the abstracts of journal articles the student reads** online.
2.  **User Model**: This is the **structured internal representation** of the user. Here, it is the built **profile of the student's research interests**, which is most likely a **vector or weighted list of topics** (e.g., {Machine Learning: 0.8, Human-Computer Interaction: 0.5, Databases: 0.2}) derived from the frequency of tags assigned to read articles.

**(b) Domain Model Role and Importance:**
- **Domain Model**: In this case, the Domain Model is the **subject ontology** (the ACM Computing Classification System). It provides the structured "vocabulary" of the domain, defining **concepts** (e.g., "Machine Learning", "Algorithms"), their **attributes**, and the **relationships** between them (e.g., "is a sub-field of").
- **Critical Importance**: The Domain Model is **essential for interpretation and interoperability**. It allows the system to map the unstructured text of article abstracts to a consistent set of concepts. This enables it to **understand that two articles using different terminology may be about the same topic**, and to compute meaningful similarity between a user's interest profile and new articles. Without it, the system would be limited to simplistic keyword matching, severely reducing its accuracy and usefulness.

---
### Question 1.2.2: Data Flow & Adaptation Logic
A fitness tracking app for runners proposes personalised training plans. It gathers data: the user's past run distances and paces (User Data Gathering). It models the user's current fitness level and goals (User Model). It has a knowledge base of training principles and workout types (Domain Model).

**(a) Trace the **data flow and process** for one cycle of adaptation. Begin with the app proposing a 'Bridge to 10K' plan and end with the app updating the plan after the user completes a run. Name the relevant components and the actions they perform in sequence.**
[5 marks]

**(b) The **Adaptation Model** in this app uses a set of rules. Propose **one** specific example of a rule it might use that combines information from the User Model and the Domain Model to decide on an adaptation.**
[2 marks]

---
#### Model Answer 1.2.2
**(a) Data Flow and Adaptive Cycle:**
1.  **Adaptation Model & Adaptive Component**: Based on the User Model (fitness level = beginner, goal = 10K) and Domain Model (training principles), the **Adaptation Model** decides to adapt by proposing the 'Bridge to 10K' plan. The **Adaptive Component** presents this plan to the user via the app interface.
2.  **User Interaction**: The user accepts and begins the plan, completing the first run.
3.  **User Data Gathering**: The app's sensors and logs **gather raw data** about the completed run (distance: 3km, average pace: 6:30 min/km).
4.  **User Model Acquisition**: The system **processes the raw data**, comparing the run performance to the plan's target. It infers the run was successful and updates the **User Model** (e.g., increases `fitness_level_estimate` slightly, records completion).
5.  **Adaptation Model (again)**: The updated User Model is fed back into the **Adaptation Model**. Using its rules and the Domain Model, it decides the user is ready for the next week's plan. It triggers the **Adaptive Component** to update the interface, displaying the next set of workouts.

**(b) Example Adaptation Rule:**
`IF` (User Model: `most_recent_run_pace` < `target_pace` **AND** User Model: `reported_fatigue` = 'low')
`AND` (Domain Model: workout_type 'interval' is recommended for `improving_speed`)
`THEN` Adaptation: Schedule an interval training session for the next workout.
## Topic 1.3: Design Application & Comparative Analysis
### Question 1.3.1: Schema Mapping & Critical Component
Consider a language learning app like Duolingo. It tracks user performance on exercises (correct/incorrect answers, time taken). It uses this to estimate proficiency in different language skills (grammar, vocabulary) and to select the next exercise difficulty.

**(a) Map this description onto the **five components of the General Schema**. For each, provide the specific *instance* from the Duolingo scenario.**
[5 marks]

**(b) The developers are debating whether to spend resources improving the accuracy of the proficiency estimation algorithm or the exercise selection algorithm. Referring to the **relative importance of components**, argue which one they should prioritise and why.**
[3 marks]

---
#### Model Answer 1.3.1
**(a) Schema Mapping:**
1.  **User Data Gathering**: The system that **tracks raw user performance** on exercises (records correct/incorrect answers and time taken).
2.  **User Model Acquisition**: The **algorithm that processes** the raw performance data to **infer and update** the estimates of proficiency in grammar, vocabulary, etc. This is the inference engine.
3.  **User Model**: The **data structure storing the current estimates** of the user's proficiency in each language skill (e.g., `{grammar: 0.7, vocabulary: 0.5}`).
4.  **User Model Application**: The **logic/algorithm** that uses the proficiency estimates (User Model) and a curriculum plan (Domain Model) to **decide** which specific exercise to present next, at what difficulty.
5.  **Adaptive Component**: The **app interface** that **presents the selected exercise** to the user.

**(b) Prioritisation Argument:**
They should prioritise improving the **proficiency estimation algorithm (User Model Acquisition)**.
**Justification**: The **User Model is the most critical component**. It is the system's "knowledge" of the user. If the proficiency estimates (the User Model) are **inaccurate**, then even a perfect exercise selection algorithm (User Model Application) will make decisions based on faulty premises, leading to poorly adapted exercises (too easy or too hard). Improving the accuracy of the model ensures that *all* subsequent adaptation decisions are founded on correct information. You cannot have good adaptation from a bad model.

---
### Question 1.3.2: Interpreting Applied Examples
Using the applied examples table:

| System | User Data Gathered | User Model (Acquisition) | Adaptation (Application) | Adaptive Component |
| :--- | :--- | :--- | :--- | :--- |
| **SQL-Tutor** | Student's problem-solving steps, errors. | Overlay model of student's knowledge vs. expert domain model. | Selects next practice problem targeting knowledge gaps. | Personalised problem sequence. |
| **BBC iPlayer** | Program views, clicks, search history. | Vector of inferred genre/topic preferences. | Ranks/promotes programs in catalogue based on preference similarity. | "Recommended for you" rows. |

**(a) **SQL-Tutor** and **BBC iPlayer** both perform **User Model Acquisition**, but they produce different types of models. Contrast the **nature of the user model** each system builds and explain why this difference is appropriate for their respective domains.**
[4 marks]

**(b) For **BBC iPlayer**, a user watches three episodes of a comedy series in one evening. Describe how this event flows through the **General Schema**, from User Data Gathering to the Adaptive Component, in the context of updating the "Recommended for you" section.**
[4 marks]

---
#### Model Answer 1.3.2
**(a) Contrasting User Models:**
- **SQL-Tutor** builds a **knowledge overlay model**. This is a **fine-grained, diagnostic model** that maps the student's understanding onto a detailed expert domain model (e.g., specific SQL concepts like SELECT, JOIN, WHERE). It identifies precise gaps and misconceptions.
- **BBC iPlayer** builds a **preference vector**. This is a **coarser, quantitative model** representing the user's affinity for various genres or topics (e.g., Comedy: 0.9, Drama: 0.4). It captures taste, not knowledge.
- **Appropriateness**: The difference is domain-driven. **Education** requires diagnosing *capability* to provide corrective, scaffolded instruction. **Media recommendation** requires modelling *taste* to provide engaging, enjoyable content. A knowledge model is unnecessary for picking a TV show, and a simple preference vector is insufficient for targeted tutoring.

**(b) Data Flow for BBC iPlayer:**
1.  **User Data Gathering**: The system **logs the event**: user U watched three episodes of comedy series S.
2.  **User Model Acquisition**: The **inference engine processes** this log. It identifies series S's genre (Comedy) and updates the **User Model**—increasing the weight for "Comedy" in the user's preference vector.
3.  **User Model Application**: The **recommendation algorithm** (e.g., content-based filtering) is re-run. It uses the updated preference vector to re-score all programs in the catalogue, calculating a new similarity score for each.
4.  **Adaptive Component**: The system **regenerates the "Recommended for you" rows** on the homepage. The new ranking, which now gives higher positions to other comedy programs due to the updated model, is displayed to the user.
## Topic 1.4: Case Studies & System Classification
### Question 1.4.1: Classifying Adaptive Support
A new software plugin for a video editing suite analyses a user's editing history (frequently used effects, typical project length). It then adapts its interface by promoting the relevant effect palettes and suggesting customisable project templates when a new project is started.

**(a) Identify which of the two broad classes of user-adaptivity support (**Supporting System Use** or **Supporting Information Acquisition**) this plugin primarily provides. Justify your answer by linking the described features to the sub-categories of that class.**
[3 marks]

**(b) The plugin could be extended with an AI "assistant" that watches the user edit and pops up with suggestions like "That clip might look better with a colour correction." State which **major usability threat** this new feature is most likely to introduce and explain why.**
[2 marks]

---
#### Model Answer 1.4.1
**(a) Class of Support:**
- **Primary Class**: **Supporting System Use**.
- **Justification**: The plugin's features align with the sub-categories of this class. **Adapting the interface** (promoting relevant effect palettes) and **Helping with system use** (suggesting project templates) are both aimed at making interaction with the video editing software itself more efficient and less cognitively demanding. The adaptation is about *how* the user uses the tool, not about finding external information.

**(b) Usability Threat:**
- **Threat**: **Obtrusiveness**.
- **Explanation**: An AI assistant that automatically "pops up" with suggestions **interrupts the user's primary task** (editing). This can break the user's flow, distract them, and be perceived as annoying, especially if the suggestions are frequent or poorly timed. The system's attempt to help becomes a disruptive hindrance.

---
### Question 1.4.2: Comparative Analysis - LILSYS vs. AGENTSALON
Review the case studies of LILSYS and AGENTSALON.

**(a) The developers of a modern **smart home hub** (e.g., Google Nest) want it to proactively manage household notifications (e.g., from doorbells, appliances) based on who is home and what they are doing. Explain **one** key way in which this system's design challenges are more similar to **LILSYS** than to **AGENTSALON**.**
[2 marks]

**(b) Both LILSYS and AGENTSALON were designed to reduce user effort. However, they could both potentially lead to a **Diminished Breadth of Experience**. For **one** of the systems, explain concretely how this threat could manifest.**
[3 marks]

---
#### Model Answer 1.4.2
**(a) Similarity to LILSYS:**
The smart home hub's challenge is more similar to LILSYS because, like LILSYS, it fundamentally **mediates interaction with the real world**. It filters and manages real-world notifications and events (doorbell rings, appliance alerts) based on user context, aiming to shield the user from unwanted interruptions. This is analogous to LILSYS screening real-world phone calls. AGENTSALON, in contrast, mediates access to *information* (news), not physical-world interactions.

**(b) Manifestation of Diminished Breadth of Experience:**
- **System**: **AGENTSALON**.
- **Explanation**: AGENTSALON learns a user's stated news interests and tailors the presented stories. This creates a **filter bubble**. If a user initially expresses interest in, say, technology and sports, the system will increasingly show them only those types of stories. Consequently, the user might **miss important news** about politics, science, or culture that falls outside their initially stated profile. Their understanding of the world becomes narrow and specialised, diminishing the breadth of their information diet, all in the name of reducing the effort of searching for relevant news.
## Topic 1.5: Full Exam-Style Scenario Analysis
### Question 1.5.1: Design from Schema - A Module Recommender
**Scenario**: The University of Leeds is (hypothetically) considering developing a module recommender to aid students in choosing optional modules.
You are part of the design team. Following the general architecture of user-adaptive systems:

**(a) For the **User Model Acquisition** component, describe **two** distinct sources of data it could use and the **type of user model** it would aim to construct from them.**
[4 marks]

**(b) The **Adaptation Model** needs to combine academic suitability with student interest. Propose a simple **hybrid approach** for this component, naming the two basic recommendation techniques you would combine and the hybridisation method (e.g., weighted, switching).**
[3 marks]

**(c) One senior academic argues the system is unethical because it could "track students' every click." Identify the **usability threat** they are invoking and suggest **one** design feature to explicitly address this concern in the system's **User Data Gathering** stage.**
[3 marks]

---
#### Model Answer 1.5.1
**(a) User Model Acquisition:**
1.  **Data Source**: **University Student Information System (SIS)**. This provides explicit data like past module grades and enrolment records.
   **User Model Constructed**: An **overlay knowledge model** indicating which academic topics/areas the student has already mastered or studied, and their proficiency level.
2.  **Data Source**: **Implicit browsing logs** from the module catalogue website (clicks, dwell time on module pages).
   **User Model Constructed**: A **preference vector** of inferred student interests in various subject areas (e.g., AI, Security, Human-Centred Computing), based on the content of the modules they explored.

**(b) Hybrid Adaptation Approach:**
- **Techniques**: **Content-Based Filtering (CBF)** for academic suitability and **Collaborative Filtering (CF)** for leveraging peer interest patterns.
- **Hybridisation Method**: **Weighted Hybrid**.
- **Explanation**: A final recommendation score would be calculated as:
  `Final_Score = (w1 * CBF_Score) + (w2 * CF_Score)`.
  The CBF score matches module learning outcomes to the student's knowledge profile (from SIS). The CF score reflects the module's popularity among students with similar academic profiles or interests. Weights (`w1`, `w2`) can be tuned.

**(c) Threat and Mitigating Feature:**
- **Usability Threat**: **Infringement of Privacy** (specifically, surveillance and lack of transparency).
- **Design Feature**: Implement an **explicit, granular consent dialogue** at the User Data Gathering stage. When a student first uses the recommender, a clear pop-up would explain *what* data will be collected (e.g., "which modules you view and for how long"), *why* (to suggest relevant modules), and offer **opt-in/opt-out toggles** for different data types (e.g., "Use my browsing history" ON/OFF). This gives control and ensures informed consent.

---
### Question 1.5.2: Comparative Analysis in a New Context
A museum is planning two new systems:
- **System A (Gallery Navigator)**: Uses Bluetooth beacons to track visitor location. It then pushes information to their phone about the exhibit they are near, tailoring the detail of the description based on estimated time spent at previous exhibits (inferred engagement level).
- **System B (Virtual Curator Chatbot)**: An LLM-powered chatbot on the museum website. Users tell it their interests (e.g., "I like modern art and history"). It then generates a personalised tour plan and answers questions in a style adapted to the user's language complexity.

**(a) System A's method of inferring engagement level is most similar to the data collection approach of **LILSYS** or **AGENTSALON**? Justify your choice.**
[2 marks]

**(b) For System B, identify a concern related to **Reliability & Accuracy** (a challenge seen in LILSYS) that is specifically heightened by its use of an LLM.**
[2 marks]

**(c) Both systems aim to "tailor information." Classify which of the two broad **Types of User-Adaptivity Support** (Supporting System Use / Supporting Information Acquisition) each system primarily provides.**
[2 marks]

---
#### Model Answer 1.5.2
**(a) Similarity in Data Collection:**
- **System A is most similar to LILSYS**.
- **Justification**: Both System A and LILSYS rely primarily on **passive, implicit sensor data** collected without direct user input to infer user state. LILSYS uses motion/keyboard sensors; System A uses Bluetooth beacons to track location and dwell time. AGENTSALON, in contrast, relies primarily on **explicit user profiles** and feedback.

**(b) LLM-Specific Reliability Concern:**
A primary concern is **Hallucination and Factual Inaccuracy**. The LLM in System B might generate a tour plan that includes **non-existent exhibits**, **incorrect historical facts**, or **illogical navigation routes** through the museum. Unlike a simple rule-based system, the LLM's generative nature makes its outputs **unpredictably and plausibly wrong**, posing a significant reliability threat that could mislead and frustrate users.

**(c) Type of Adaptive Support:**
- **System A (Gallery Navigator)**: **Supporting Information Acquisition**. It helps users find and understand information about exhibits based on their location and engagement.
- **System B (Virtual Curator)**: **Supporting Information Acquisition**. It helps users find information (a tour plan) and tailors the presentation of information (answers) based on their stated interests and language level.
## Topic 2.1: User model representation and building
### Question 2.1.1: Detailed Component Design
Continuing with the University of Leeds **Module Recommender** scenario:

**(a) The User Model Acquisition** component is tasked with creating the "interest strengths" vector. Describe a **step-by-step process** it could use to convert raw "dwell time on a module page" into a numerical interest strength for a topic (e.g., "Robotics"). Assume the module pages are already tagged with topics from a Domain Model.**
[4 marks]

**(b) The system uses a stereotype** (e.g., "High-Achieving CS Student") for cold-start. Explain **one** clear **advantage** and **one** significant **risk** of using stereotypes in this educational context.**
[4 marks]

**(c) The Adaptive Component** plans to include an explanation. Generate an example explanation that **combines information** from two different parts of the User Model ("interest strengths" and "mastered topics") for a recommended module in "Computer Vision".**
[2 marks]

---
#### Model Answer 2.1.1
**(a) From Dwell Time to Interest Strength:**
1.  **Aggregation**: For a given user, sum the total dwell time across all module pages tagged with the topic "Robotics".
2.  **Normalization**: Divide this sum by the user's total dwell time on *all* module pages. This gives a **proportion of attention** devoted to Robotics topics, controlling for overall browsing activity.
3.  **Weighting**: Apply a **non-linear scaling** (e.g., a logarithmic function) to this proportion. This prevents a single very long page view from disproportionately skewing the vector and dampens the effect of outliers.
4.  **Update**: This calculated strength for "Robotics" is then used to update the existing value in the user's interest vector, potentially using a moving average to incorporate new evidence smoothly over time.

**(b) Stereotype Advantage and Risk:**
- **Advantage**: **Effective Cold-Start Solution**. It provides **immediate, plausible recommendations** to a new student before any personal data (grades, browsing) is available. It leverages the "wisdom of the crowd" by suggesting modules that have been successful for similar students in the past, giving a useful starting point.
- **Risk**: **Reinforcement of Bias and Limiting Discovery**. The stereotype is based on historical data. If certain modules (e.g., theory-heavy modules) were traditionally popular with "High-Achieving CS Students," the system will recommend them, potentially **steering students away from non-traditional, innovative, or interdisciplinary options** they might personally love. This perpetuates historical trends and limits personal exploration and diversity of student pathways.

**(c) Combined Explanation:**
"Recommended because it aligns with your **strong interest in AI** (from your browsing history) and builds directly on your **excellent grades in Linear Algebra and Programming**."

---
### Question 2.1.2: Evaluating Design Choices
The Module Recommender design document includes the following debate:
- **Proposal X**: Use **Collaborative Filtering (CF)** to rank modules based on what students in the same stereotype enrolled in and rated highly.
- **Proposal Y**: Rely only on **Content-Based Filtering (CBF)** using the student's interest vector and the module topic vector.

**(a) Proposal X (CF) is susceptible to a common recommender systems problem. Name this problem and explain why it is particularly problematic in the **module recommendation** context.**
[3 marks]

**(b) Proposal Y (CBF) is strong at transparency but suffers from a key limitation. Identify this limitation and describe how it could negatively affect a student's **breadth of experience**.**
[3 marks]

**(c) The team decides on a **cascade hybrid**: first use CBF to filter, then use CF to re-rank the shortlist. What is the primary **benefit** of applying CF *second* in this cascade, compared to using it first?**
[2 marks]

---
#### Model Answer 2.1.2
**(a) Problem with Collaborative Filtering:**
- **Problem**: **Popularity Bias**.
- **Contextual Explanation**: CF will recommend modules that are **popular within the student's stereotype**. This can create a **feedback loop** where already-popular modules become even more recommended, overshadowing high-quality but niche or new modules. In an educational context, this is problematic because it could **stifle diversity in module uptake**, push students toward "easy" or "famous" modules rather than the best for their development, and make it hard for new or specialised modules to gain traction.

**(b) Limitation of Content-Based Filtering:**
- **Limitation**: **Overspecialisation / Filter Bubble**.
- **Effect on Breadth**: A pure CBF system will only recommend modules that are *similar* to those the student has already shown interest in. If a Computer Science student only browses AI and Security modules, the CBF system will **only recommend more AI and Security modules**. This denies the student exposure to potentially valuable **adjacent or interdisciplinary fields** (e.g., Human-Computer Interaction, Bioinformatics) that they might not know to search for but could find fascinating and career-enhancing. Their academic experience becomes narrowed.

**(c) Benefit of Cascade (CBF then CF):**
The primary benefit is that the CF stage **operates on a pre-filtered, relevant shortlist**. This means the "wisdom of the crowd" (CF) is used to **break ties** and **add serendipity** among modules that are already a good content-based fit. It prevents CF from recommending popular but completely irrelevant modules (e.g., a popular but introductory module to an advanced student), thereby improving the **precision and appropriateness** of the final recommendations.
## Topic 2.2: Representation Methods & Stereotypes
### Question 2.2.1: Selecting Appropriate Representations
A company is developing two distinct adaptive systems:

1.  **System A (Corporate Learning Platform)**: Delivers mandatory compliance training (e.g., data privacy, health & safety) to all employees. It must ensure each employee achieves a passing understanding of each policy.
2.  **System B (Internal News Hub)**: Aggregates company news, project updates, and industry articles. It aims to keep employees informed about topics relevant to their role and personal interests.

**(a) For representing **employee knowledge** in *System A*, which representation method—**Scalar**, **Overlay**, or **Bug Model**—is most appropriate? Justify your choice by linking the system's goal to the method's characteristics.**
[3 marks]

**(b) For representing **employee interests** in *System B*, which representation method—**Keyword-Level**, **Overlay on Fixed List**, or **Concept-Level**—would be most effective if the company has a well-defined, stable set of departments and project areas? Justify your choice.**
[3 marks]

**(c) *System B* also wants to consider the **Context** of "time of day" (e.g., morning vs. late afternoon). According to the context dimensions framework, is this **User Context** or **Environment Context**? Explain your reasoning.**
[2 marks]

---
#### Model Answer 2.2.1
**(a) Knowledge Representation for System A:**
- **Most Appropriate**: **Overlay Model**.
- **Justification**: The system's goal is to ensure passing understanding of *each specific policy*. This requires **fine-grained tracking** of knowledge on discrete concepts (e.g., "GDPR Article 5", "Fire Drill Procedure"). The **Scalar Model** is too coarse (a single "compliance knowledge" score). The **Bug Model** is overly complex for this declarative knowledge domain. The **Overlay Model** perfectly matches a domain model of policy concepts, allowing the system to identify *which* specific policies an employee is weak on and target training accordingly.

**(b) Interest Representation for System B:**
- **Most Effective**: **Overlay on a Fixed List**.
- **Justification**: The company has a "well-defined, stable set of departments and project areas." This provides a natural, bounded **fixed list of topics** (e.g., [Engineering, Marketing, Sales, Project-X]). A simple vector over this list is **easy to implement**, directly maps to how content can be tagged, and avoids the complexity of building a full ontology (**Concept-Level**) or the noise of free-form keywords. It provides sufficient granularity for role-based personalisation.

**(c) Context Classification for "Time of Day":**
- **Classification**: **User Context**.
- **Reasoning**: Time of day is a **temporal attribute of the user's situation**. It influences the user's **cognitive state, routine, and availability** (e.g., more receptive to detailed reports in the morning, preferring brief updates in the afternoon). It is not an attribute of the external physical environment (like weather or lighting), which would be Environment Context.

---
### Question 2.2.2: Modelling Challenges & Construction
A "Smart Recipe Manager" app aims to adapt recipe suggestions based on a user's **cooking skill**. It must also recognise when a user is performing the **goal** of "cooking a weekday dinner" vs. "planning a weekend feast."

**(a) Propose a method for representing the user's **cooking skill**. Choose between a **Scalar Model** and an **Overlay Model**. Justify your choice by contrasting the two methods in this specific context.**
[4 marks]

**(b) Describe how the system could perform **goal recognition** to distinguish between "weekday dinner" and "weekend feast." Your answer should mention at least **two** distinct pieces of evidence the system could use and how they would be interpreted.**
[4 marks]

---
#### Model Answer 2.2.2
**(a) Representing Cooking Skill:**
- **Proposed Method**: **Scalar Model**.
- **Justification**: Cooking skill, for the purpose of recipe adaptation, is often effectively represented on a broad continuum (e.g., *Beginner*, *Intermediate*, *Advanced*). An **Overlay Model** would require decomposing "cooking" into hundreds of fine-grained concepts (knife skills, sauce making, baking, etc.), which is **excessively complex and difficult to map** to individual recipes. A **Scalar Model**, while less precise, is **simple to derive** (e.g., from self-report or from the complexity of recipes successfully completed) and provides **sufficient granularity** to filter out recipes with advanced techniques for a beginner. The trade-off of **lower precision** is acceptable for this application.

**(b) Goal Recognition Process:**
The system would use a **probabilistic overlay** on a pre-defined goal catalog. Evidence would include:
1.  **Temporal Context (Time & Day)**: Cooking activity on a **Tuesday at 6:30 PM** is strong evidence for the "weekday dinner" goal (probability P=0.8). Activity on a **Saturday at 11:00 AM** increases the probability of the "weekend feast" goal, as it suggests meal *planning* or preparing a more elaborate dish.
2.  **Interaction Patterns with the App**: If the user is **quickly selecting a saved "quick meal" recipe**, this supports "weekday dinner." If they are **browsing extensively, saving multiple recipes, or viewing recipes with long prep times**, this supports "weekend feast."
   The system would combine these evidence streams (and potentially others like number of servings selected) using a simple probabilistic model (e.g., a Naive Bayes classifier) to infer the most likely current goal and adapt suggestions accordingly (quick vs. elaborate recipes).
## Topic 2.3: Acquisition Techniques, Cold-Start & Model Maintenance
### Question 2.3.1: Acquisition Techniques & Cold-Start
A new "Campus Buddy" app for university students aims to provide personalised event recommendations (societies, talks, sports). It faces the **user cold-start problem** as soon as a student installs it.

**(a) Propose a **stereotype-based acquisition technique** to give initial recommendations. Define **two** plausible stereotypes, and for each, provide a **trigger condition** based on data available at sign-up (e.g., from the university's student information system).**
[6 marks]

**(b) After the initial phase, the app switches to using **collaborative filtering (CF)**. Explain why this switch helps overcome a **limitation of the stereotype approach** used during cold-start.**
[2 marks]

**(c) The app also lists events from brand new student societies. Which **type of recommender technique** (CF, CBF, or KB) would be inherently capable of recommending these new events from day one, and why?**
[2 marks]

---
#### Model Answer 2.3.1
**(a) Stereotype Design:**
1.  **Stereotype 1: "The Engaged Academic"**
    - **Trigger Condition**: `IF` (enrolled_course = "Computer Science" OR "Physics" OR "Mathematics") `AND` (year_of_study >= 2).
    - **Default Profile**: High interest weight for events tagged [Research_Talks, Coding_Workshops, Academic_Societies]; low weight for [Sports_Socials, Arts_Performances].
2.  **Stereotype 2: "The Social Connector"**
    - **Trigger Condition**: `IF` (enrolled_course includes "Business" OR "Media") `OR` (university_accommodation = "Halls of Residence").
    - **Default Profile**: High interest weight for events tagged [Social_Mixers, Sports_Clubs, Volunteering]; moderate weight for [Careers_Fairs].

**(b) Overcoming Stereotype Limitation:**
- **Stereotype Limitation**: Stereotypes are **over-generalised and static**. They assume all students in a category have identical interests.
- **CF Advantage**: Collaborative filtering **learns the individual's unique taste** from their actual interactions (attending/ignoring events). It finds *specific* similar users, not a broad category, leading to **more precise and personalised** recommendations as data accumulates, moving beyond the coarse stereotype.

**(c) Recommending New Events (Item Cold-Start):**
- **Technique**: **Content-Based Filtering (CBF)** or **Knowledge-Based (KB)** techniques.
- **Reason**: These techniques do not rely on historical user-item interaction data. **CBF** can recommend a new society's event if its **metadata** (tags: "debating", "political") matches a user's interest profile. A **KB** system could recommend it based on the user's stated goal to "improve public speaking." **Collaborative Filtering fails** because a new event has no attendance history.

---
### Question 2.3.2: Model Maintenance & Challenges
A financial wellness app tracks users' spending categories (e.g., groceries, entertainment) to provide personalised budgeting tips. Users' financial habits and priorities can change over time (e.g., after getting a new job, having a child).

**(a) The app uses a **vector model** of spending priorities. Describe a **forgetting mechanism** the app could implement to handle the **changing user state** ("concept drift") and prevent the model from being overly influenced by old, no-longer-relevant spending patterns.**
[3 marks]

**(b) The raw spending data from bank feeds can be **noisy** (e.g., a supermarket transaction might be categorised as "groceries" but was actually for garden supplies, a non-essential). Propose **two** complementary strategies to mitigate the impact of noisy data on the user model.**
[4 marks]

---
#### Model Answer 2.3.2
**(a) Forgetting Mechanism:**
The app could use **exponential decay** on the weights in the spending priority vector. Each spending event's contribution to a category's weight would be multiplied by a **decay factor** (e.g., 0.95) for each subsequent week. For example, a £100 grocery spend from 10 weeks ago would contribute `100 * (0.95^10) ≈ £60` to the current "groceries" weight, while a similar spend from last week would contribute `100 * (0.95^1) ≈ £95`. This automatically **down-weights older evidence**, allowing the model to adapt to recent changes in behaviour.

**(b) Mitigating Noisy Data:**
1.  **Probabilistic Modelling & Confidence Measures**: Instead of hard categorisation, assign **probabilities** to categories for each transaction (e.g., P(groceries)=0.7, P(gardening)=0.3). Update the user model using these probabilities. Also, maintain a **confidence score** for each inferred priority; require multiple corroborating transactions (high confidence) before making strong adaptive decisions like issuing a warning.
2.  **Hybrid Data Source & User Correction**: Combine the automated bank feed categorisation with **explicit user input**. Implement a **scrutable model** where users can review and correct categorisations (e.g., "Was this £50 at Tesco for Groceries or Gardening?"). Use these corrections not only to fix that instance but also to **retrain the categorisation algorithm** for future transactions, creating a feedback loop that improves data quality over time.
## Topic 2.4: From Measurements to Models (TF-IDF, etc.)
### Question 2.4.1: From Measurements to Models
An e-commerce site uses a panel of 1000 users to test a new recommendation widget. For a specific product, the widget is shown 5000 times (impressions) and receives 250 clicks.

**(a) Calculate the **Click-Through Rate (CTR)** for this product. The product team considers a CTR above 5% as indicating "high interest." Does this product meet that threshold?**
[2 marks]

**(b) The widget always appears at the very top of the page. Explain the **primary threat to validity** if the team uses this CTR to definitively conclude the product is "interesting," and suggest a **better analysis approach** to assess true interest.**
[4 marks]

**(c) The site wants to build a long-term interest profile using **TF-IDF**. A user has clicked on 3 product descriptions. For the term "wireless," the raw counts in the three descriptions are 4, 6, and 0. The maximum raw count for any term in those documents is 10. The term "wireless" appears in 150 of the site's 10,000 product descriptions. **Calculate the TF-IDF weight** for "wireless" for this user. Show your working for TF and IDF.**
[6 marks]

---
#### Model Answer 2.4.1
**(a) CTR Calculation and Threshold:**
- **CTR** = (Number of Clicks) / (Number of Impressions) = 250 / 5000 = **0.05** or **5%**.
- **Conclusion**: Yes, it **meets the 5% threshold** exactly.

**(b) Threat to Validity and Better Approach:**
- **Primary Threat**: **Position Bias**. Items at the top of a page receive disproportionately many clicks simply due to their prominent location, regardless of inherent interest. A high CTR may reflect position, not product appeal.
- **Better Approach**: Conduct an **A/B test** with **randomised positioning**. Randomly assign users to see the product in the top position (Group A) or in a lower, standard position (Group B). Compare the **CTR in Group B** to the baseline. If the CTR remains high even when not at the top, you can more confidently attribute it to interest.

**(c) TF-IDF Calculation:**
**Step 1: Calculate Term Frequency (TF) for each document.**
- Formula: $tf(t,d) = f_d(t) / \text{max}_{w \in d} f_d(w)$
- Doc1: `tf("wireless", d1) = 4 / 10 = 0.4`
- Doc2: `tf("wireless", d2) = 6 / 10 = 0.6`
- Doc3: `tf("wireless", d3) = 0 / 10 = 0`
- **Aggregate TF for user**: Often the average is used. `(0.4 + 0.6 + 0) / 3 = 1.0 / 3 ≈ 0.333`

**Step 2: Calculate Inverse Document Frequency (IDF).**
- Formula: $idf(t, D) = \ln ( |D| / |\{d \in D : t \in d\}| )$
- $|D|$ = 10,000 (total products)
- $|\{d \in D : t \in d\}|$ = 150 (products containing "wireless")
- $idf("wireless", D) = \ln (10000 / 150) = \ln (66.67) ≈ 4.20$

**Step 3: Calculate TF-IDF.**
- $tfidf = \text{(Aggregate TF)} \cdot idf = 0.333 \cdot 4.20 ≈ **1.40**$

---
### Question 2.4.2: Modelling Techniques and Preprocessing
A music streaming service wants to cluster its users into "taste profiles" based on their play counts across 20 genres. The raw data for two users is:
- **User A (High Engagement)**: [Pop: 100, Rock: 200, Jazz: 50] (Total plays = 350)
- **User B (Low Engagement)**: [Pop: 10, Rock: 20, Jazz: 5] (Total plays = 35)

**(a) The raw vectors are very different due to engagement level. Describe the **two-step preprocessing procedure** (involving TF-IDF and L2 normalisation) that would transform these vectors to reveal their similar *interest distributions* for clustering.**
[4 marks]

**(b) After preprocessing, the service wants to build a **graph-based interest model** for a user who listens extensively to "Indie Rock" and "Alternative." What is the key **advantage** of a graph-based model over a simple genre list for recommending new music to this user?**
[2 marks]

**(c) The research on Google News concluded that interests are dynamic. Propose a **simple update rule** for the user's interest vector that balances **long-term preference** with **recent listening trends**. You may use a mathematical notation or a clear descriptive rule.**
[2 marks]

---
#### Model Answer 2.4.2
**(a) Two-Step Preprocessing:**
1.  **Apply TF-IDF across the user-genre matrix**. This re-weights raw play counts. The IDF component will down-weight ubiquitous genres (e.g., Pop) and boost distinctive ones (e.g., Classical), helping to distinguish true niche interests from common listening habits.
2.  **Apply L2 Normalisation** to each user's resulting TF-IDF vector. This is computed as:
    $\mathbf{v}_{\text{norm}} = \mathbf{v} / ||\mathbf{v}||_2$, where $||\mathbf{v}||_2$ is the Euclidean norm (square root of the sum of squared vector values).
    This step **removes the magnitude (engagement level)** and preserves only the **direction (relative proportion of interest across genres)**. After this, User A and User B's vectors will be nearly identical, showing they have the same *relative* taste profile (Rock > Pop > Jazz).

**(b) Advantage of Graph-Based Model:**
The key advantage is **semantic reasoning and serendipitous discovery**. A graph-based model understands that "Indie Rock" is *related to* "Psychedelic Rock," "Post-Punk," and perhaps certain "Folk" artists via defined relationships in a music ontology. It can therefore recommend music that is **semantically related but not lexically identical**, leading to more diverse and accurate discoveries than a model that just looks for other items tagged "Indie Rock."

**(c) Update Rule for Dynamic Interests:**
A simple rule is **exponential moving average**.
$\text{Interest}_{\text{new}} = \alpha \cdot \text{Interest}_{\text{current}} + (1 - \alpha) \cdot \text{Interest}_{\text{recent}}$
Where $\text{Interest}_{\text{current}}$ is the existing long-term vector, $\text{Interest}_{\text{recent}}$ is a vector calculated from the last week of listening, and $\alpha$ is a smoothing factor (e.g., 0.9) that controls the influence of new evidence. This gradually integrates recent trends while retaining a memory of long-term preference.
## Topic 2.5: Detailed Design & Evaluation
### Question 2.5.1: Goal Recognition & Adaptation
A "Smart Writing Assistant" plugin for word processors is designed to help users with different writing goals, such as "Writing a Research Paper," "Drafting a Business Email," or "Composing a Creative Story."

**(a) The system uses a **goal hierarchy**. Sketch a simple hierarchy for the goals mentioned and add one sub-goal for "Writing a Research Paper."**
[2 marks]

**(b) Describe **two distinct types of evidence** the system could use to perform **goal recognition** and infer which goal a user is currently pursuing. For each, state how it would support a specific goal.**
[4 marks]

**(c) If the system infers the goal "Writing a Research Paper" with a confidence of 0.7, what **adaptive action** could it take? Also, identify the **major usability threat** that arises if the system's inference is wrong and it takes this action autonomously.**
[2 marks]

---
#### Model Answer 2.5.1
**(a) Goal Hierarchy:**
```
Writing Goals
├── Writing a Research Paper
│   └── Citing Sources  // Example sub-goal
├── Drafting a Business Email
└── Composing a Creative Story
```

**(b) Evidence for Goal Recognition:**
1.  **Document Metadata and Stylistic Features**: The system can analyse the document's **template, title, and initial keywords**. A document titled "Literature_Review.docx" with section headers like "Introduction," "Methodology," and a bibliography section provides strong evidence for the "Research Paper" goal. A document starting with "Dear Team," is evidence for "Business Email."
2.  **User Interaction Patterns**: Monitoring the user's **search queries within the plugin** (e.g., searching for "APA citation format" vs. "corporate email salutations") and **tools accessed** (e.g., frequent use of a citation manager vs. an emoji picker) provides implicit evidence of their current task and supports the corresponding goal inference.

**(c) Adaptive Action and Usability Threat:**
- **Adaptive Action**: The system could **automatically activate the citation manager sidebar** and **suggest academic phrasing** or relevant reference sources.
- **Usability Threat**: **Diminished Controllability / Obtrusiveness**. If the inference is wrong (e.g., the user is actually writing a blog post about research), the autonomous activation of the citation tools would be **intrusive, distracting, and could disrupt the user's workflow**, making them feel the system is working against them rather than assisting them.

---
### Question 2.5.2: Dynamic Interest Modelling (Bayesian Framework)
Referring to the Google News research and the provided user-item matrix:

**(a) The matrix shows user u3's ratings. If we consider these ratings as **observed behaviour**, explain what the **Bayesian framework** would consider as the two latent components contributing to u3's rating for `item1` (rating=5).**
[2 marks]

**(b) Using the **similarity measures** provided, calculate the predicted rating for user u3 on item3 using **User-User Collaborative Filtering** with a neighbourhood of k=2. Show your working.**
[4 marks]

|                    | u1    | u2    |    u3     | u4    | u5    | u6    |
| ------------------ | ----- | ----- | :-------: | ----- | ----- | ----- |
| similarity measure | 0.63  | 0.56  |           | 0.71  | 0.22  | 0.93  |

**(c) **Collaborative Filtering** and the **Bayesian framework** both aim to predict preferences. State one key advantage the Bayesian framework has over standard CF in the context of a fast-changing domain like news.**
[2 marks]

---
#### Model Answer 2.5.2
**(a) Latent Components for u3's Rating:**
The Bayesian framework would decompose the observed rating of 5 for `item1` into:
1.  **Genuine Interest**: u3's underlying, stable personal preference for the content of `item1`.
2.  **Trend Influence**: The effect of the current news trend (what the general population is clicking/rating highly at that moment) on u3's decision to rate `item1` a 5. The high rating might be partly because the topic is currently very popular.

**(b) User-User CF Prediction for u3 on item3:**
1.  **Identify Neighbours (k=2)**: The two highest similarity measures to u3 are **u6 (0.93)** and **u4 (0.71)**.
2.  **Retrieve Neighbours' Ratings for item3**: u6 rated item3 as **4**. u4 rated item3 as **2**.
3.  **Calculate Weighted Average Prediction**:
    $p_{u3,item3} = \frac{(r_{u6} \cdot sim_{u6}) + (r_{u4} \cdot sim_{u4})}{sim_{u6} + sim_{u4}}$
    $p_{u3,item3} = \frac{(4 \cdot 0.93) + (2 \cdot 0.71)}{0.93 + 0.71} = \frac{3.72 + 1.42}{1.64} = \frac{5.14}{1.64} ≈ **3.13**$

**(c) Advantage of Bayesian Framework over CF:**
The key advantage is **explicit modelling and adaptation to temporal dynamics**. Standard CF treats all past ratings equally. The Bayesian framework explicitly **separates transient trend effects from long-term interest** and can **down-weight older data** as its predictive power decays. This allows it to remain responsive to shifting trends (crucial for news) while maintaining a stable core profile, whereas CF would be slower to adapt and could recommend outdated trending topics.
## Topic 3.1: Core Techniques & Characterisation
### Question 3.1.1: Technique Identification & Characterisation
A company is developing three different recommender systems:

1.  **System 1 (MovieStream)**: Suggests films by finding users with similar rating histories and recommending movies those similar users enjoyed.
2.  **System 2 (GourmetGuide)**: A chatbot that asks "What's your budget? Any dietary restrictions? Favourite cuisine?" then suggests restaurants.
3.  **System 3 (StyleMatch)**: An online clothing store that recommends items by analysing the visual features (colour, pattern, style) of clothing a user has previously 'favourited' and finding visually similar items.

**(a) Identify the **core recommendation technique** used by each system (CF, CBF, KB, DM, or UT).**
[3 marks]

**(b) For **System 1 (MovieStream)**, describe its **primary weakness** and suggest **one** way to overcome it without changing the core technique.**
[2 marks]

**(c) **System 2 (GourmetGuide)** and **System 3 (StyleMatch)** use different types of *background data*. Contrast the nature of the background data each system relies on.**
[2 marks]

---
#### Model Answer 3.1.1
**(a) Technique Identification:**
- **System 1 (MovieStream)**: **Collaborative Filtering (CF)**. It leverages the "wisdom of the crowd" by finding similar users.
- **System 2 (GourmetGuide)**: **Knowledge-Based (KB)**. It uses an interactive dialogue to elicit explicit user constraints and needs, then applies domain knowledge (restaurant features) to satisfy them.
- **System 3 (StyleMatch)**: **Content-Based Filtering (CBF)**. It recommends items based on the similarity of their *attributes/features* (visual characteristics) to those of items the user has liked.

**(b) Weakness and Mitigation for System 1 (CF):**
- **Primary Weakness**: The **User Cold-Start Problem**. It cannot make good recommendations for a new user who has no rating history, as it cannot find similar users.
- **Mitigation**: Implement an **initial explicit profiling step**. Before showing CF recommendations, ask the new user to rate a small, diverse set of popular movies. This "seed" data provides an initial vector to find similar users, bootstrapping the CF process.

**(c) Contrast in Background Data:**
- **System 2 (KB)**: Relies on a **knowledge base of rules and constraints**. This is typically hand-crafted or curated knowledge about the domain, linking user needs (budget, diet) to item properties (price, menu).
- **System 3 (CBF)**: Relies on a **domain model of item feature vectors**. This is structured data (metadata) about each item's attributes (e.g., colour histogram, pattern classification, style tags). The system does not need rules about *why* features are good, just the features themselves.

---
### Question 3.1.2: Analysing the Recommendation Landscape
The table below summarises key aspects of core recommendation techniques.

| Technique | Core Idea | Typical Background Data | Classic Weakness |
| :--- | :--- | :--- | :--- |
| **Collaborative (CF)** | Wisdom of the crowd. | User-Item Matrix. | Cold-Start (User & Item). |
| **Content-Based (CBF)** | Similarity of item features. | Item Features, User Profile. | Overspecialisation (Filter Bubble). |
| **Knowledge-Based (KB)** | Match constraints to items. | Knowledge Base (Rules/Constraints). | Static, requires knowledge engineering. |

**(a) A **Demographic (DM)** recommender suggests news articles to users based on their age and postcode. According to the table's logic, what would be its most likely **Classic Weakness**?**
[1 mark]

**(b) A music service uses a **Utility-Based (UT)** approach where users manually set importance weights for features like "danceability," "artist familiarity," and "release year." What is the **key trade-off** for the user with this approach compared to an implicit CF system?**
[2 marks]

**(c) A video platform suffers from the **item cold-start problem** for newly uploaded videos. Referring to the table, which **two** techniques would *not* suffer from this problem for the new videos? For each, briefly explain why.**
[4 marks]

---
#### Model Answer 3.1.2
**(a) Weakness of Demographic Recommender:**
The most likely classic weakness is **Over-generalisation and Stereotyping**. Demographic segments are coarse, assuming all users of a certain age in a postcode have identical tastes, which leads to inaccurate, non-personalised recommendations.

**(b) Key Trade-off of Utility-Based vs. CF:**
The key trade-off is **Control and Transparency vs. Effort and Completeness**.
- **UT (User's Perspective)**: Provides **high control and transparency** (user understands exactly why recommendations are made) but requires **significant upfront and ongoing effort** to define and maintain the utility function. The user must also have the self-knowledge to completely define their preferences.
- **CF (User's Perspective)**: Requires **no effort** (works implicitly) and can discover unknown preferences, but offers **low control and transparency** (hard to understand why something was recommended).

**(c) Techniques Not Suffering from Item Cold-Start:**
1.  **Content-Based Filtering (CBF)**: Does not suffer because it relies on the **item's features/metadata** (e.g., video title, description, tags, uploader), which are available as soon as the video is uploaded. It can recommend the new video to users whose profiles match these features.
2.  **Knowledge-Based (KB)**: Does not suffer because it uses a **knowledge base of constraints and item properties**. If the new video's properties (e.g., category="Educational", length="short") are known, the system can match it to users with relevant constraints (e.g., "I want short educational videos"), regardless of the video having no view history.
## Topic 3.2: Collaborative Filtering (CF) - Calculations & Analysis
### Question 3.2.1: User-User CF Calculation & Analysis
**Use the following subset of the rating matrix for calculations:**

|       | u1  | u2  | u3  | u4  | u5  | u6  |
| ----- | --- | --- | --- | --- | --- | --- |
| item1 | 5   | 1   | 5   | 4   | 0   | 3   |
| item2 | 3   | 3   | 1   | 1   | 5   | 1   |
| item4 | 1   | 1   | 4   | 1   | 1   | 2   |
| item5 | 3   | 2   | 5   | 0   | 0   | 3   |

**(a) Calculate the **Cosine Similarity** between user **u5** and user **u6**. Show your working.**
[5 marks]

**(b) Using the **similarity results** from part (a) and the following provided similarities for u5—`sim(u5,u1)=0.22`, `sim(u5,u3)=0.45`, `sim(u5,u4)=0.10`—predict u5's rating for **item1** using **User-User CF with k=2**. Show your working.**
[4 marks]

**(c) Based on your prediction, identify **one** potential issue with the **neighbourhood selection** in this specific case and suggest how it might affect prediction quality.**
[2 marks]

---
#### Model Answer 3.2.1
**(a) Cosine Similarity between u5 and u6:**
1.  **Identify co-rated items**: u5 and u6 have both rated item2, item4, and item5.
2.  **Vectors for co-rated items**:
    - u5: `[item2:5, item4:1, item5:0]`
    - u6: `[item2:1, item4:2, item5:3]`
3.  **Dot Product**: $(5*1) + (1*2) + (0*3) = 5 + 2 + 0 = 7$
4.  **Magnitude of u5**: $\sqrt{5^2 + 1^2 + 0^2} = \sqrt{25 + 1 + 0} = \sqrt{26} \approx 5.099$
5.  **Magnitude of u6**: $\sqrt{1^2 + 2^2 + 3^2} = \sqrt{1 + 4 + 9} = \sqrt{14} \approx 3.742$
6.  **Cosine Similarity**: $sim(u5, u6) = \frac{7}{5.099 \times 3.742} = \frac{7}{19.08} \approx 0.367$

**(b) Prediction for u5 on item1 using k=2:**
1.  **Rank similarities for u5**:
    - sim(u5,u3) = 0.45
    - sim(u5,u6) = 0.367 (from part a)
    - sim(u5,u1) = 0.22
    - sim(u5,u4) = 0.10
    **Nearest 2 neighbours: u3 and u6.**
2.  **Retrieve neighbours' ratings for item1**:
    - u3 rated item1 as **5**.
    - u6 rated item1 as **3**.
3.  **Weighted Sum Prediction**:
    $p_{u5,item1} = \frac{(5 \cdot 0.45) + (3 \cdot 0.367)}{0.45 + 0.367} = \frac{2.25 + 1.101}{0.817} = \frac{3.351}{0.817} \approx 4.10$

**(c) Neighbourhood Selection Issue:**
- **Issue**: **Low Absolute Similarity / Sparse Neighbourhood**. The two "best" neighbours (u3 and u6) have relatively low similarity scores (0.45 and 0.37). This indicates u5 is not *very* similar to any other user in the dataset.
- **Effect on Quality**: Predictions based on weakly similar neighbours are **unreliable and noisy**. The system is essentially making a guess based on users who are only marginally alike, which increases the risk of a poor recommendation.

---
### Question 3.2.2: Item-Item CF & Amazon's Method
**Consider the binary purchase matrix for Amazon's method:**

|       | u1  | u2  | u3 (Target) | u4  | u5  | u6  |
| ----- | --- | --- | :---------: | --- | --- | --- |
| item1 | 1   | 0   |    **1**    | 1   | 0   | 0   |
| item2 | 0   | 1   |    **0**    | 1   | 0   | 0   |
| item3 | 0   | 1   |    **0**    | 0   | 0   | 1   |
| item4 | 0   | 1   |    **1**    | 1   | 0   | 0   |
| item5 | 1   | 0   |    **0**    | 0   | 1   | 1   |
| item6 | 1   | 1   |    **0**    | 0   | 1   | 0   |
| item7 | 0   | 0   |    **0**    | 1   | 0   | 0   |

**(a) Following **Amazon's process**, identify the **candidate items** for recommendation to u3. List the steps you take.**
[3 marks]

**(b) Calculate the **Cosine Similarity** between item4 (which u3 bought) and item2 (a candidate). Use the binary vectors for all users (u1 to u6).**
[3 marks]

**(c) Explain **why** this item-item approach, with pre-computed similarities, solves the **scalability problem** of user-user CF for a giant like Amazon.**
[2 marks]

---
#### Model Answer 3.2.2
**(a) Amazon's Process - Candidate Items:**
1.  **Step 1**: Find customers who purchased the same items as u3. u3 purchased **item1** and **item4**.
    - Customers who bought **item1**: u1, u4.
    - Customers who bought **item4**: u2, u4.
    - **Union**: u1, u2, u4.
2.  **Step 2**: Find other items bought by these customers (u1, u2, u4).
    - u1 bought: item1, item5, item6.
    - u2 bought: item2, item3, item4, item6.
    - u4 bought: item1, item2, item4, item7.
    - **Candidate items (excluding item1 & item4)**: item2, item3, item5, item6, item7.

**(b) Cosine Similarity between item4 and item2:**
1.  **Binary Vectors**:
    - item4: `[u1:0, u2:1, u3:1, u4:1, u5:0, u6:0]`
    - item2: `[u1:0, u2:1, u3:0, u4:1, u5:0, u6:0]`
2.  **Dot Product**: $(0*0)+(1*1)+(1*0)+(1*1)+(0*0)+(0*0) = 0+1+0+1+0+0 = 2$
3.  **Magnitude of item4**: $\sqrt{0^2+1^2+1^2+1^2+0^2+0^2} = \sqrt{3} \approx 1.732$
4.  **Magnitude of item2**: $\sqrt{0^2+1^2+0^2+1^2+0^2+0^2} = \sqrt{2} \approx 1.414$
5.  **Cosine Similarity**: $sim(item4, item2) = \frac{2}{1.732 \times 1.414} = \frac{2}{2.449} \approx 0.816$

**(c) Solving the Scalability Problem:**
In user-user CF, to make a recommendation for a user, you must compare them to **all M users** in the database online, an O(M) operation. In Amazon's item-item approach, the heavy lifting—calculating **similarities between all N items**—is done **offline** in batch (O(N²), but N is items, not users). The online step is just a **fast lookup**: fetch the pre-computed similar-items lists for the few items the user has purchased and aggregate them. This scales because the online computation is **proportional to the user's purchase history**, not the total number of users or items.
## Topic 3.3: Content-Based Filtering (CBF)
### Question 3.3.1: CBF Methodology & Calculation
A book recommendation service uses **Content-Based Filtering**. Books are represented by feature vectors across four genres: `[Fantasy, SciFi, Mystery, Biography]`. The values are based on expert tagging (0 to 1).

**User Profile (U)**: `[Fantasy:0.9, SciFi:0.7, Mystery:0.3, Biography:0.1]`
**Book A Feature Vector (I_A)**: `[Fantasy:0.8, SciFi:0.2, Mystery:0.1, Biography:0.0]`
**Book B Feature Vector (I_B)**: `[Fantasy:0.3, SciFi:0.9, Mystery:0.0, Biography:0.0]`

**(a) Calculate the **Cosine Similarity** between the user profile and **Book A**. Show your working.**
[4 marks]

**(b) Based on your calculation and the vector for Book B, which book (**A** or **B**) would the system recommend to this user? Justify your answer briefly.**
[2 marks]

**(c) This user has only ever read fantasy books. Identify the **key disadvantage** of CBF that this situation illustrates and describe its likely effect on the user's experience.**
[2 marks]

---
#### Model Answer 3.3.1
**(a) Cosine Similarity between U and Book A:**
1.  **Dot Product**: $(0.9*0.8) + (0.7*0.2) + (0.3*0.1) + (0.1*0.0) = 0.72 + 0.14 + 0.03 + 0 = 0.89$
2.  **Magnitude of U**: $\sqrt{0.9^2 + 0.7^2 + 0.3^2 + 0.1^2} = \sqrt{0.81 + 0.49 + 0.09 + 0.01} = \sqrt{1.4} \approx 1.183$
3.  **Magnitude of I_A**: $\sqrt{0.8^2 + 0.2^2 + 0.1^2 + 0.0^2} = \sqrt{0.64 + 0.04 + 0.01 + 0} = \sqrt{0.69} \approx 0.831$
4.  **Cosine Similarity**: $sim(U, I_A) = \frac{0.89}{1.183 \times 0.831} = \frac{0.89}{0.983} \approx 0.905$

**(b) Recommendation Decision:**
- **Book A similarity**: ~0.905
- **Book B similarity (calculated similarly)**: Dot product = $(0.9*0.3)+(0.7*0.9)+(0.3*0)+(0.1*0)=0.27+0.63+0+0=0.90$. Magnitude of I_B = $\sqrt{0.3^2+0.9^2+0+0}=\sqrt{0.09+0.81}= \sqrt{0.90}=0.949$. $sim(U, I_B) = \frac{0.90}{1.183 \times 0.949} = \frac{0.90}{1.122} \approx 0.802$.
- **Decision**: The system would recommend **Book A**.
- **Justification**: Book A has a **higher cosine similarity** (0.905 > 0.802) to the user's profile. It more closely matches the user's strong preference for Fantasy, while Book B, despite matching the user's SciFi interest, has a lower overall match.

**(c) Disadvantage and Effect:**
- **Key Disadvantage**: **Over-Specialisation / Filter Bubble**.
- **Effect on Experience**: Because the user's profile is dominated by Fantasy, the CBF system will **only recommend books highly similar to Fantasy**. It will **never recommend** a highly-rated SciFi or Mystery book that the user might actually enjoy, **limiting discovery and leading to a repetitive, narrow reading experience**. The user is trapped in a "fantasy bubble."

---
### Question 3.3.2: Advanced CBF Models & Applications
The **Rijksmuseum CHIP project** uses a semantic knowledge graph for artwork recommendation. A user expresses interest in the concept "Rembrandt" and the subject "Portraits."

**(a) Explain how a **graph/concept-based CBF model** would be superior to a simple **keyword-based model** in this museum context.**
[3 marks]

**(b) The system recommends a portrait by **Frans Hals**, an artist the user has never heard of. Describe the **reasoning path** through the knowledge graph that could lead to this recommendation.**
[3 marks]

**(c) While CBF solves the *item cold-start* problem, it suffers from the *user cold-start* problem. Describe **one** specific strategy the museum guide could use to overcome user cold-start for a first-time visitor.**
[2 marks]

---
#### Model Answer 3.3.2
**(a) Advantage of Graph-Based over Keyword-Based Model:**
A **keyword model** would only match on the literal terms "Rembrandt" and "portrait." A **graph-based model** understands **semantic relationships**. It knows "Rembrandt" *is-a* "Dutch Golden Age painter," that "portraits" *is-a-type-of* "painting," and that other artists like "Frans Hals" are *related-to* "Dutch Golden Age painting." This allows it to recommend **semantically related but lexically different** artworks (e.g., portraits by other Dutch masters), enabling **serendipitous discovery and richer cultural understanding**, which is a key goal of a museum visit.

**(b) Reasoning Path for Frans Hals Recommendation:**
The knowledge graph would enable the following inference:
1.  User interest node: **"Rembrandt"**.
2.  Traverse relationship: Rembrandt `[is-a]` **"Dutch Golden Age Painter"**.
3.  Traverse relationship: "Dutch Golden Age Painter" `[includes]` **"Frans Hals"**.
4.  User interest node: **"Portraits"**.
5.  Traverse relationship: Frans Hals `[specialised-in]` **"Portraits"**.
6.  **Intersection/Scoring**: The system identifies artworks where the `[created-by]` node is "Frans Hals" and the `[depicts]` node is "Portraits." These artworks receive a high recommendation score because they are connected to *both* of the user's interest concepts via short semantic paths.

**(c) Overcoming User Cold-Start:**
The museum guide could use an **explicit, interactive profiling session** at the start of the visit. For example, it could show the user a set of **representative artwork images** from different periods, styles, and subjects (e.g., a Rembrandt portrait, a landscape, a modern sculpture) and ask them to select which ones they find most interesting. This quick explicit feedback provides an **initial interest vector** to bootstrap the CBF system, avoiding the need for a lengthy browsing history.
## Topic 3.4: Knowledge-Based (KB)
### Question 3.4.1: Knowledge-Based Recommender Operation
A **Knowledge-Based (KB)** recommender system is built to help students choose a laptop for their university course. The system's knowledge base contains specifications for various laptop models and rules about course requirements.

**Example Interaction**:
- **User Input**: "I need a laptop for Computer Science, budget under £800, must run virtual machines."
- **System Action**: Filters laptops, showing those with ≥16GB RAM, a multi-core CPU, and price < £800.
- **User Critique**: "Could be lighter."
- **System Action**: Re-ranks results, prioritising laptops with weight < 2kg.

**(a) In this example, the user's critique "Could be lighter" is a form of **navigation**. Name this specific type of interaction commonly used in KB systems and explain how it differs from simply re-specifying the constraint (e.g., "weight < 2kg").**
[3 marks]

**(b) The system uses **Case-Based Reasoning (CBR)**. Describe the **two main phases** of the CBR cycle as they occur in this laptop recommender.**
[4 marks]

**(c) A major **advantage** of this KB system is its ability to handle the **cold-start problem**. Explain why neither the *user cold-start* nor the *item cold-start* problem affects this system.**
[2 marks]

---
#### Model Answer 3.4.1
**(a) Type of Interaction:**
- This is **critique-based navigation** (or **preference-based navigation**).
- **Difference from Re-specification**: A critique like "Could be lighter" is a **relative, directional preference** applied to the *current set of results*. It tells the system to find items that are *similar to the current candidates but improved on a specific dimension*. This is more natural and requires less precise knowledge from the user than stating an absolute new constraint like "weight < 2kg," which might eliminate all options or require the user to know the reasonable threshold.

**(b) CBR Cycle Phases:**
1.  **Retrieve**: The system takes the user's query (initial needs: CS, <£800, runs VMs) as a "new case." It **retrieves** the most similar laptop "cases" from its knowledge base that match these core constraints.
2.  **Reuse & Revise**: The system **presents** these retrieved cases. The user's critique ("could be lighter") provides feedback. The system **revises** the query case by **adjusting the importance or value of the 'weight' attribute** and re-executes the retrieval, or directly re-ranks the current cases based on weight. This cycle of critique and revision can continue iteratively until the user is satisfied.

**(c) Immunity to Cold-Start:**
- **User Cold-Start**: Does not occur because the system does **not rely on the user's historical interaction data**. It works purely from the **explicit needs stated in the current session**. A brand-new user can get a recommendation immediately.
- **Item Cold-Start**: Does not occur because the system does **not rely on community usage data (ratings/purchases)**. A brand-new laptop model can be recommended as long as its **technical specifications are entered into the knowledge base**. Its recommendation power comes from its attributes, not its popularity.

---
### Question 3.4.2: Comparing KB with Other Techniques
A company is choosing a recommender system for its **online store selling high-end kitchen appliances** (e.g., coffee machines, stand mixers). These are considered "high-involvement" purchases.

**(a) Give **two** reasons why a **Knowledge-Based (KB)** recommender is particularly well-suited for this domain, compared to a **Collaborative Filtering (CF)** system.**
[4 marks]

**(b) The company also considers a **Content-Based Filtering (CBF)** system using product features. What is the **key functional difference** in how a KB system and a CBF system would process the user constraint "must be easy to clean"?**
[2 marks]

**(c) Despite its advantages, the KB system has a significant **business cost**. Identify this cost and explain why it is ongoing.**
[2 marks]

---
#### Model Answer 3.4.2
**(a) Suitability of KB for High-Involvement Appliances:**
1.  **Handles Complex, Technical Constraints**: Kitchen appliance purchases involve specific needs (e.g., "bean hopper capacity > 500g," "must have steam wand"). A KB system can explicitly reason about these **technical attributes** in its knowledge base, whereas CF can only recommend based on what similar users bought, ignoring these precise technical matchings.
2.  **Transparency and Trust Building**: For expensive items, users need to understand *why* a product is recommended. A KB system can provide a clear, logical explanation ("Recommended because it has a 15-bar pump, meets your budget, and has an integrated grinder"), which **builds trust**. CF's explanation "people like you bought this" is weak and unpersuasive for a technical purchase.

**(b) Processing "Easy to Clean" - KB vs. CBF:**
- **KB System**: Would have an **explicit rule or attribute** in its knowledge base modelling "ease of cleaning." This might be a categorical value (e.g., `cleanability: high`) or derived from other features (e.g., `dishwasher_safe_parts = TRUE`). It would filter or rank items based on this **engineered knowledge**.
- **CBF System**: Would rely on the term **"easy to clean"** appearing as a keyword in the product description or a related tag in the item's feature vector. It would match this term to the user's profile. It **lacks semantic understanding**; a product described as "simple maintenance" might not match unless the feature engineering explicitly links those terms.

**(c) Business Cost of KB Systems:**
- **Cost**: **High Knowledge Engineering and Maintenance Cost**.
- **Why Ongoing**: The knowledge base (attributes, rules, relationships) is not learned automatically from data; it must be **manually created and curated by domain experts**. This is a significant upfront investment. Furthermore, it is **ongoing** because every new product must be meticulously annotated with all relevant attributes, and rules may need updating as product lines or consumer understanding evolves. This is in contrast to CF or CBF systems where new products can be integrated more automatically (via metadata or initial usage data).
## Topic 3.5: Hybrid Recommender Systems
### Question 3.5.1: Selecting a Hybridisation Method
A video streaming service has a strong **Collaborative Filtering (CF)** algorithm but wants to improve its recommendations in two specific scenarios:
- **Scenario 1**: Provide good recommendations to **brand new users** (user cold-start).
- **Scenario 2**: Increase the **diversity** of recommendations for long-term users who are stuck in a "filter bubble" of very similar content.

**(a) For **Scenario 1**, propose a **hybrid approach**. Name the second technique to combine with CF and specify the **hybridisation method**. Justify your choice.**
[3 marks]

**(b) For **Scenario 2**, propose a different **hybrid approach**. Again, name the second technique and the **hybridisation method**, justifying how it increases diversity.**
[3 marks]

**(c) The service implements the solution for Scenario 1 as a **Switching** hybrid. What is one **practical challenge** the service must manage when implementing this switch?**
[2 marks]

---
#### Model Answer 3.5.1
**(a) Hybrid for User Cold-Start (Scenario 1):**
- **Technique to combine with CF**: **Knowledge-Based (KB)** or **Demographic (DM)**.
- **Hybridisation Method**: **Switching Hybrid**.
- **Justification**: For a new user with no viewing history, CF cannot function. The system should **switch** to using a KB system (asking for favourite genres/actors) or a DM system (using age/location) to provide initial recommendations. After the user has accumulated a minimum threshold of interactions (e.g., 10 ratings), the system switches to the main CF algorithm.

**(b) Hybrid for Increasing Diversity (Scenario 2):**
- **Technique to combine with CF**: **Content-Based Filtering (CBF)**.
- **Hybridisation Method**: **Mixed** or **Weighted Hybrid**.
- **Justification**: A **Mixed** hybrid would present separate recommendation rows: "Because you watched X" (CBF) and "Popular with similar viewers" (CF). This explicitly injects diverse, content-based options into the interface. A **Weighted** hybrid would create a final score = `(1-α)*CF_Score + α*CBF_Score`, where the CBF component is tuned to promote items that are *dissimilar* to the user's recent watches, directly increasing intra-list diversity.

**(c) Practical Challenge of a Switching Hybrid:**
A key challenge is **defining a robust and fair switching criterion**. The service must decide **when** to switch from the cold-start method (KB/DM) to CF. Using a simple threshold (e.g., 10 ratings) may switch users too early (while their profile is still noisy) or too late (frustrating them with poor KB recommendations). The threshold must be carefully tuned and may need to be personalised, adding complexity.

---
### Question 3.5.2: Designing a Cascade Hybrid - EntréeC Analysis
Recall the **EntréeC** restaurant recommender, which uses a **Cascade** hybrid of **Knowledge-Based (KB)** and **Collaborative Filtering (CF)**.

**(a) In the EntréeC cascade, **which technique is applied first and why is this order logically necessary?**
[2 marks]

**(b) The CF stage in EntréeC uses a novel **Heuristic Similarity** method for processing user critiques (e.g., "Nicer", "Cheaper"). Explain how this is an example of **Feature Augmentation** and why it's better than using simple numeric ratings.**
[4 marks]

**(c) A competitor builds a simple **Weighted** hybrid of KB and CF for restaurants. Contrast the **fundamental operational difference** between their Weighted hybrid and EntréeC's **Cascade** hybrid.**
[2 marks]

---
#### Model Answer 3.5.2
**(a) Order in the Cascade:**
- **First Technique**: The **Knowledge-Based (KB)** system is applied first.
- **Logical Necessity**: The KB system is necessary to **solve the cold-start problem** and to **narrow down the massive search space** (all restaurants) to a manageable shortlist of candidates that satisfy the user's fundamental constraints (cuisine, location, price). The CF system cannot operate effectively on the full set due to sparsity and lacks the ability to handle explicit constraints. The KB stage provides a viable candidate set for CF to refine.

**(b) Heuristic Similarity as Feature Augmentation:**
- **Feature Augmentation Explanation**: The KB system's output is not just a list of restaurants, but **semantic actions** (critiques like "Nicer") performed by users on those restaurants. These actions are **augmented features** that are fed into the CF stage. Instead of just a user-item rating matrix, the CF stage now has a richer matrix of *user-item-semantic_action* data.
- **Advantage over Numeric Ratings**: Simple numeric ratings (e.g., 1-5 stars) lose semantic meaning. The **Heuristic Similarity** method preserves the meaning of critiques by using a handcrafted matrix that defines, for example, that "Nicer" is semantically *opposite* to "Cheaper." This allows the CF stage to find users who made similar *qualitative judgements*, leading to more nuanced and accurate similarity calculations than if all feedback was flattened into a single number.

**(c) Weighted vs. Cascade Operational Difference:**
- **Weighted Hybrid**: Computes a **single, blended recommendation score** for each restaurant from the start. The KB and CF algorithms run independently on the *full* dataset, and their scores are combined linearly (e.g., `Score = w1*KB_Score + w2*CF_Score`).
- **Cascade Hybrid**: Operates in **strict sequence**. The **first algorithm (KB) selects a subset** of the entire item catalogue. The **second algorithm (CF) operates only on this pre-filtered subset**, re-ranking or scoring items within it. The CF stage never sees items rejected by the KB stage.
## Topic 3.6: Exam Practice Questions & Model Answers
### Question 3.6.1: Detailed Hybrid Method Application
A video game store wants a hybrid recommender. It has two core algorithms:
- **Algorithm P (Popularity-Based)**: Recommends the top-selling games.
- **Algorithm C (Content-Based)**: Recommends games similar to those the user owns, based on genre, theme, and developer.

The store wants to ensure new users see popular games (to catch trends) but also wants to quickly personalise recommendations based on their first purchase.

**(a) Design a **Cascade Hybrid** using Algorithm P and Algorithm C. Specify the order and describe the precise function of each stage.**
[3 marks]

**(b) The store instead implements a **Feature Augmentation Hybrid**. Describe how this would work with the same two algorithms.**
[3 marks]

**(c) Compare the **likely recommendation results** for a new user who just bought "The Witcher 3" under the Cascade design (part a) versus the Feature Augmentation design (part b).**
[2 marks]

---
#### Model Answer 3.6.1
**(a) Cascade Hybrid Design:**
- **Order**: **Algorithm P (Popularity) → Algorithm C (Content-Based)**.
- **Stage 1 (P)**: The popularity-based algorithm generates a **broad, initial shortlist** of, for example, the top 100 best-selling games. This ensures new users are exposed to current trends and hits.
- **Stage 2 (C)**: The content-based algorithm takes this shortlist of 100 games. It computes the similarity between each game in the shortlist and the user's purchased game ("The Witcher 3"). It then **re-ranks the 100 games** based on this content similarity, promoting games like other RPGs, open-world games, or from the same developer to the top.

**(b) Feature Augmentation Hybrid Design:**
In this design, **Algorithm C (Content-Based)** runs first. For every game in the catalogue, it predicts a **content-based affinity score** for the user based on their purchase. This score becomes a **new feature** for each game. **Algorithm P (Popularity)** is then modified to use an **enhanced scoring function** that combines the raw popularity metric (e.g., sales count) with this content-based affinity feature. For example: `Final_Score = (Sales_Count) + β*(Content_Affinity_Score)`. A single ranked list is produced by this augmented popularity algorithm.

**(c) Comparison of Results:**
- **Cascade Results**: The final list will be **heavily personalised**. It will contain **only popular games** (from stage 1), but the top recommendations will be exclusively those popular games that are very similar to "The Witcher 3." The list may lack variety.
- **Feature Augmentation Results**: The final list will be a **blend of popularity and personalisation**. A very popular but dissimilar game (e.g., "FIFA") could still rank highly if its sales count is huge, even if its content affinity is low. The top of the list might show a mix of similar RPGs *and* mega-popular titles from other genres, offering a **more diverse but less purely personalised** result.

---
### Question 3.6.2: Analysing Complex Hybrids - The Netflix Prize
The winning solution for the Netflix Prize was an ensemble of **over 100 models**. This can be viewed as an advanced form of hybridisation.

**(a) The ensemble combined models including **SVD (Matrix Factorization)**, **Restricted Boltzmann Machines (RBMs)**, and **K-Nearest Neighbours (KNN)**. This overall approach is best described as which **hybridisation method**?**
[1 mark]

**(b) One of the key insights was that **blending many models reduced error**. Explain the statistical principle behind this, relating it to a **weakness of individual recommendation techniques**.**
[3 marks]

**(c) A student suggests that instead of a complex blend, Netflix should just use the **single best-performing model** (e.g., the best SVD variant) to simplify their system. Give **two** reasons why the blended ensemble approach is superior for a production system like Netflix.**
[4 marks]

---
#### Model Answer 3.6.2
**(a) Hybridisation Method:**
This is a **Weighted Hybrid** (specifically, a **weighted ensemble or blending**). The final prediction is a linear (or non-linear) combination of the predictions from all 100+ models.

**(b) Statistical Principle and Weakness:**
- **Principle**: **Error Reduction through Variance Averaging**. Different models make different errors because they **overfit to different parts of the training data** (they have high variance). By averaging their predictions, these individual errors tend to **cancel out**, leading to a more stable and accurate aggregate prediction.
- **Relation to Weakness**: Individual techniques like KNN or a specific SVD configuration have inherent **limitations and biases** (e.g., KNN's popularity bias, SVD's assumption of linear interactions). Their errors are often **uncorrelated**. Blending models that make *different types of mistakes* results in a system whose overall mistake is smaller than any component's.

**(c) Superiority of Blending over a Single Model:**
1.  **Improved Robustness and Generalisation**: A single model, even the best on average, will have **systematic blind spots or failure cases** for certain users or movie types. The ensemble is **more robust** because when one model fails for a particular case, other models in the blend can compensate, leading to consistently good performance across the entire diverse user base and catalogue.
2.  **Practical Maintainability and Evolution**: A production system needs to evolve. With an ensemble, new and improved models can be **gradually incorporated** into the blend (assigned a small initial weight). This allows for **smooth, low-risk deployment and A/B testing**. Relying on a single "best" model creates a **monolithic dependency**; any update requires a risky "big bang" replacement, and if the new model has an unforeseen flaw, the entire recommendation quality collapses.
## Topic 3.7: Hybridisation Methods & Advanced Designs
### Question 3.7.1: Selecting a Hybrid Method
An online magazine for hobbyists (e.g., gardening, DIY, model trains) is implementing a recommender for its article library. It has two core problems:
1.  **Problem A**: Many articles are old and have very few clicks or ratings (**data sparsity**).
2.  **Problem B**: Users often specialise in one hobby (e.g., only gardening) and miss excellent articles in related hobbies (e.g., DIY projects for garden sheds) (**overspecialisation**).

The magazine has a good taxonomy (ontology) of topics and tags for all articles.

**(a) For **Problem A (Sparsity)**, refer to the decision guide. Select a **hybrid method** and justify your choice by explaining *how* it mitigates sparsity.**
[3 marks]

**(b) For **Problem B (Overspecialisation)**, select a **different hybrid method** from the guide. Justify your choice and specify the **two base techniques** you would combine.**
[3 marks]

**(c) Considering both problems, the engineering team prefers a single, unified solution. Which **one hybrid method** from the guide could potentially address **both** sparsity and overspecialisation? Explain briefly.**
[2 marks]

---
#### Model Answer 3.7.1
**(a) Hybrid for Data Sparsity:**
- **Selected Method**: **Feature Combination**.
- **Justification**: Data sparsity in the user-article interaction matrix makes pure **Collaborative Filtering (CF)** unreliable. Feature Combination merges the sparse interaction data with rich **Content-Based (CBF) features** (article tags, topic vectors from the ontology) into a single feature set for a machine learning model (e.g., a neural network). This model can learn from the *content* of articles when interaction data is missing, effectively **enriching the sparse signal** and making accurate predictions possible even for rarely clicked articles.

**(b) Hybrid for Overspecialisation:**
- **Selected Method**: **Mixed Hybrid**.
- **Base Techniques**: **Content-Based Filtering (CBF)** and **Collaborative Filtering (CF)**.
- **Justification**: A Mixed hybrid presents two separate recommendation lists side-by-side. A **"Because you read..."** list (CBF) provides familiar, similar gardening articles. A **"Readers also enjoyed..."** list (CF) can surface articles popular with gardeners who also explored DIY. This **explicitly injects serendipity** by leveraging the diverse tastes of the user's collaborative neighbourhood, directly combating the filter bubble created by a pure CBF system.

**(c) Unified Solution for Both Problems:**
- **Method**: **Feature Combination** (or a sophisticated **Weighted** ensemble).
- **Explanation**: A well-designed Feature Combination model (e.g., a neural network) trained on both interaction and content data can inherently handle sparsity (by relying on content features when interactions are absent) and can promote diversity. During training, it can learn that users who like gardening also have a latent interest in DIY based on patterns in the *combined* data of *all* users, allowing it to recommend cross-topic articles even for a user with a sparse, single-topic history. It unifies the signals in one model.

---
### Question 3.7.2: Specifying Algorithmic Components
A company is building a **movie recommender** and documents its design with the three key features: Background Data, Input Data, and Algorithm.

**Proposed Design**: "Our system uses a **Weighted Hybrid**. It combines a **Content-Based Filtering (CBF)** model that uses movie genres and directors with a **Collaborative Filtering (CF)** model that uses user ratings."

**(a) This documentation is **incomplete**. For the **CBF component**, specify its:
    (i) **Background Data**,
    (ii) **Input Data** for a specific user,
    (iii) **Algorithm** (name and one-sentence description).**
[3 marks]

**(b) For the overall **Weighted Hybrid**, what is the **Background Data** required?**
[1 mark]

**(c) The product manager wants to add a **Knowledge-Based (KB)** component for new users. This would change the hybrid to a **Switching** hybrid. What additional piece of **Background Data** is now absolutely required?**
[1 mark]

---
#### Model Answer 3.7.2
**(a) CBF Component Specification:**
(i)  **Background Data**: A **Domain Model** consisting of **feature vectors for every movie**, where features include genres, director, actors, keywords, etc. (A pre-computed vector space).
(ii) **Input Data**: The **target user's profile**, which is a **feature preference vector** derived from the features of movies they have rated highly or watched.
(iii) **Algorithm**: **Cosine Similarity computation and ranking**. The algorithm calculates the cosine similarity between the user's preference vector and each candidate movie's feature vector, then ranks movies by this similarity score.

**(b) Weighted Hybrid Background Data:**
The Weighted Hybrid requires **the union of the background data for both components**. Specifically, it requires: (1) The **User-Item Rating Matrix** (for CF), and (2) The **Movie Feature Vectors/Domain Model** (for CBF).

**(c) Additional Background Data for Switching Hybrid (with KB):**
The system now requires a **Knowledge Base**. This is a structured set of **rules, constraints, and utility functions** that link user needs (e.g., "I want a funny movie for kids") to movie attributes (e.g., genre="Comedy", certification="PG"). This knowledge base is used by the KB component during the cold-start phase.
## Topic 3.8: Evaluation of Rec Sys (Offline Metrics), Beyond Accuracy & A/B Testing
### Question 3.8.1: Offline Accuracy Metrics & Trade-offs
A team is evaluating two movie recommendation algorithms, **Rec1** and **Rec2**, on a test set of 5 users. The table shows the **Mean Absolute Error (MAE)** and **Root Mean Squared Error (RMSE)** for each.

| User | MAE (Rec1) | MAE (Rec2) | RMSE (Rec1) | RMSE (Rec2) |
| :--- | :---: | :---: | :---: | :---: |
| 1 | 0.8 | 0.9 | 1.0 | 1.1 |
| 2 | 1.2 | 1.0 | 1.5 | 1.3 |
| 3 | 0.5 | 0.7 | 0.6 | 0.9 |
| 4 | 1.5 | 1.8 | 2.0 | 2.4 |
| 5 | 0.9 | 0.9 | 1.2 | 1.2 |
| **Average** | **1.0** | **1.1** | **1.3** | **1.4** |

**(a) Based on the **average metrics**, which algorithm appears better for minimising prediction error?**
[1 mark]

**(b) Examine the error for **User 4**. The RMSE for Rec1 is 2.0 and for Rec2 is 2.4. What does this tell you about the **nature of the errors** Rec2 made for this user compared to Rec1?**
[2 marks]

**(c) The team also computes **Precision@5**. They find Rec2 has a significantly higher Precision@5 than Rec1. Considering this and the accuracy metrics, which algorithm might you **deploy for a real-world streaming service** and why?**
[3 marks]

---
#### Model Answer 3.8.1
**(a) Better Algorithm for Prediction Error:**
**Rec1** appears better. It has a lower average MAE (1.0 < 1.1) and a lower average RMSE (1.3 < 1.4), indicating both lower average error magnitude and lower penalty for large errors across the test set.

**(b) Nature of Errors for User 4:**
The higher RMSE for Rec2 (2.4 > 2.0) while the MAE difference is smaller (1.8 vs 1.5) indicates that Rec2 made **at least one very large prediction error** (an "outlier" error) for User 4. RMSE penalises large errors more heavily. This suggests Rec2 might have **completely mispredicted a rating** (e.g., predicted 5 for a movie the user actually hated), whereas Rec1's errors were more consistently moderate.

**(c) Deployment Decision:**
- **Algorithm to Deploy**: **Rec2**.
- **Reasoning**: For a real-world streaming service, the **primary goal** is often to generate a **good shortlist of recommendations** (high precision) that users will engage with, not to predict exact star ratings perfectly. **Precision@5** is a more direct measure of this real-world utility than MAE/RMSE. Rec2's superior Precision@5 suggests it creates more engaging top-5 lists, even if its average rating prediction is slightly less accurate. The business impact of higher engagement likely outweighs a marginal increase in rating prediction error. The large error for User 4 is a concern but may be an outlier.

---
### Question 3.8.2: Beyond Accuracy & A/B Testing
A news website's recommender has high **accuracy** (low RMSE) but user surveys indicate they find the recommendations "repetitive and boring."

**(a) Identify **two** "beyond accuracy" metrics the team should measure to diagnose this problem. For each, briefly explain how a deficiency in that metric could cause the user feedback.**
[4 marks]

**(b) The team develops a new algorithm focused on **serendipity**. They plan an **A/B test** where Group A (control) gets the old accurate algorithm and Group B (treatment) gets the new serendipitous one. What is the **key risk** in using **Click-Through Rate (CTR)** as the sole success metric for this test?**
[2 marks]

**(c) Suggest **two** additional metrics, **one behavioural** and **one subjective**, that would provide a more complete evaluation of the serendipitous algorithm in the A/B test.**
[2 marks]

---
#### Model Answer 3.8.2
**(a) Beyond-Accuracy Metrics:**
1.  **Diversity (Intra-List)**: Measures how dissimilar the recommended articles are from each other. **Low diversity** means all recommendations are on the same topic (e.g., all politics), leading to a **repetitive** experience.
2.  **Novelty/Serendipity**: Measures how often recommendations are for articles **new to the user** and **unexpectedly good**. **Low novelty** means the system only recommends articles similar to those the user has already read many times, leading to a **boring** experience with no discovery.

**(b) Risk of Using CTR Alone:**
The key risk is that **CTR might decrease** for the serendipitous algorithm, even if it is improving user experience in the long term. Serendipitous recommendations are, by definition, unexpected. Users might be less likely to click immediately on something unfamiliar, causing a **short-term dip in CTR** even though the recommendations are more valuable for engagement and satisfaction over time. Using CTR alone could wrongly condemn a better algorithm.

**(c) Additional A/B Test Metrics:**
- **Behavioural Metric**: **Long-term Engagement**—e.g., **Return Visits per User** over a month or **Session Length**. This captures whether serendipitous recommendations make the site more "sticky" and enjoyable.
- **Subjective Metric**: **Post-Experience Survey Score**—e.g., asking users to rate "How interesting and diverse were today's recommendations?" on a scale. This directly measures the perceived quality the algorithm aims to improve.
## Topic 3.9: Machine Learning-Based Recommender Systems
### Question 3.9.1: ML Recommender Pipeline & Model Selection
A streaming service is building a new **"Next Episode"** recommender. The system must analyse a user's sequential watch history (the order of episodes viewed) and contextual data (time of day, device) to predict the single next episode they are most likely to start.

**(a) The data science team proposes using a **Random Forest** model. Explain why this is a **suboptimal choice** for this specific task, citing **two** fundamental limitations of Random Forests in this context.**
[4 marks]

**(b) Instead, the team opts for a **Long Short-Term Memory (LSTM)** network. Describe **two** key architectural or functional properties of an LSTM that make it well-suited for the "Next Episode" prediction problem.**
[4 marks]

**(c) During the **Data Preprocessing** stage, the team has a 'timestamp' feature for each watch event. Explain **one** specific preprocessing technique they should apply to this timestamp feature to better help the LSTM model learn patterns, and justify your answer.**
[2 marks]

---
#### Model Answer 3.9.1
**(a) Limitations of Random Forest:**
1.  **Inability to Model Temporal Sequences**: **Random Forests** treat each data point (user-episode interaction) as **independent and identically distributed (i.i.d.)**. They fundamentally **ignore the order** of events, which is the core predictive signal for a "next in sequence" task. [2 marks]
2.  **Poor Handling of Variable-Length Input**: A user's watch history is a **variable-length sequence**. Random Forests require fixed-length feature vectors. While sequences can be manually engineered into features (e.g., "last 5 episodes"), this is **arbitrary and loses information** compared to models natively designed for sequences. [2 marks]

**(b) Strengths of LSTM:**
1.  **Memory Cells & Gating Mechanisms**: LSTMs have a **cell state** that acts as a conveyor belt of information, regulated by **input, forget, and output gates**. This allows them to **selectively retain and forget information** over long sequences, capturing dependencies like "users who binge a series often skip the recap episode." [2 marks]
2.  **Native Sequence Processing**: LSTMs **process input sequentially**, one element at a time, updating a hidden state at each step. This makes them **inherently suited for variable-length sequences** and allows them to directly learn patterns from the **raw order of watched episodes** without manual feature engineering. [2 marks]

**(c) Preprocessing for Timestamps:**
- **Technique**: Convert the raw timestamp (e.g., "14:30") into **cyclical features** using sine and cosine transformations: `sin(2π * hour / 24)`, `cos(2π * hour / 24)`. [1 mark]
- **Justification**: Raw hour (14) treats 23:00 and 01:00 as far apart (22 difference), when they are actually close in a 24-hour cycle. Cyclical encoding preserves this **periodic nature**, helping the LSTM learn that viewing behaviour at midnight is similar to behaviour at 1 am, but different from behaviour at noon. This is crucial for modelling **daily routine-based watching habits**. [1 mark]

---
### Question 3.9.2: Deployment, Evaluation & The Feedback Loop
The streaming service from Question 3.9.1 deploys its LSTM-based "Next Episode" recommender. The **offline evaluation** on historical data showed excellent **Recall@10**.

**(a) Shortly after launch, user complaints arise that the recommendations feel "repetitive and safe." Which **beyond-accuracy metric** has likely been neglected during offline evaluation? Define this metric and explain how improving it could address the user feedback.**
[3 marks]

**(b) To address this, the team develops a new **Reinforcement Learning (RL)**-based recommender. The RL agent's goal is to maximise **long-term user engagement** (total watch time over a month).
i. Define the **State (s_t)**, **Action (a_t)**, and **Reward (r_t)** for this RL formulation.
ii. What is the key **advantage** of this RL approach over the previous LSTM model that was optimised only for offline recall?**
[5 marks]

**(c) The team plans an **A/B test** to compare the new RL agent (Treatment) against the old LSTM model (Control).
i. Why would **Click-Through Rate (CTR) on the recommended episode** be an **insufficient** primary success metric for this test?
ii. Suggest **two** more appropriate **behavioural metrics**, and justify their relevance.**
[4 marks]

---
#### Model Answer 3.9.2
**(a) Neglected Beyond-Accuracy Metric:**
- **Metric**: **Serendipity** (or **Novelty**). [1 mark]
- **Definition**: **Serendipity** measures the system's ability to recommend **surprising yet relevant items**—things the user would not have found on their own but appreciates upon discovery. [1 mark]
- **Addressing Feedback**: The LSTM, trained to predict the *most likely* next episode, will consistently recommend the obvious, safe choice (e.g., the very next episode in the series). Actively optimising for **serendipity** would encourage the system to occasionally recommend a **different but thematically related series** or a **hidden gem** from the user's watch history, breaking the repetition and making the service feel more discoverable. [1 mark]

**(b) Reinforcement Learning Formulation:**
i.  **Definitions**:
    - **State (s_t)**: The user's current **context**: recent watch history sequence, time of day, current device, inferred mood (e.g., "bingeing" vs. "casual"), remaining watch time budget. [1 mark]
    - **Action (a_t)**: The specific **episode or shortlist of episodes** to recommend next. [1 mark]
    - **Reward (r_t)**: The **immediate engagement** resulting from the action, e.g., *minutes watched* of the recommended episode, or a composite signal (click= +0.1, watch >75%= +1.0). [1 mark]
ii. **Key Advantage**: The RL agent optimises for **long-term cumulative reward**, not just immediate prediction accuracy. It can learn to make **strategic sacrifices** (e.g., recommending a slightly less certain but more engaging genre to prevent fatigue) or **explore** new content to gather information, all to maximise **total watch time over a month**. The LSTM, in contrast, is myopic, aiming only to predict the next click. [2 marks]

**(c) A/B Test Metrics:**
i.  **Insufficiency of CTR**: CTR only measures the **initial click**. It ignores **engagement quality**. The RL agent might recommend a longer, more captivating episode that the user watches completely, while the LSTM might trigger a click on a short, obvious next episode that is immediately skipped. **CTR could be equal or lower for the RL agent even if it generates far more watch time.** [2 marks]
ii. **Appropriate Behavioural Metrics**:
    1.  **Average Watch Time Per Session**: Directly measures the **engagement depth** the recommender facilitates. An increase would indicate the RL agent is better at keeping users watching. [1 mark]
    2.  **User Retention at 7 Days**: The percentage of users who return to the platform one week after the test starts. This measures **long-term satisfaction and habit formation**, which is the RL agent's ultimate goal. [1 mark]

---
### Question 3.9.3: Case Study Analysis & Hybridisation
Analyse the following description of a real-world system:
> "Our video platform's recommender uses a **two-stage approach**. First, a **deep candidate generation model** scans millions of videos to produce a few hundred relevant candidates for a user. This model uses **user and video embeddings** learned from past interactions. Second, a separate **ranking model** scores and ranks these candidates using a richer set of features, including predicted watch time, user satisfaction score, and a **diversity penalty**."

**(a) This architecture is characteristic of which major company's recommender system? What is the primary **engineering motivation** for this two-stage (candidate generation + ranking) design?**
[2 marks]

**(b) The candidate generation model uses **learned embeddings**.
i. What is a **vector embedding** in this context?
ii. How are these embeddings typically generated, and what key **relationship** do they capture?**
[3 marks]

**(c) The ranking model includes a "diversity penalty." Explain what this is and **justify** its importance from a **business and user experience perspective**.**
[3 marks]

**(d) This system can be viewed as a **hybrid recommender**. Identify the **hybridisation method** it uses and **briefly justify** your answer based on the description.**
[2 marks]

---
#### Model Answer 3.9.3
**(a) Company & Motivation:**
- **Company**: This is the core architecture of **YouTube's** recommender system. [1 mark]
- **Engineering Motivation**: **Scalability and Precision**. It is computationally impossible to run a complex ranking model over **millions of videos** in real-time. The **candidate generation** stage is a **high-recall**, efficient filter that reduces the pool to a manageable size. The **ranking** stage can then apply a **more complex, precision-oriented model** to the shortlist to produce the final, high-quality ordering. [1 mark]

**(b) Embeddings:**
i.  **Definition**: A **vector embedding** is a **dense, low-dimensional vector representation** (e.g., 64 floats) of a user or a video in a continuous vector space. [1 mark]
ii. **Generation & Relationship**: They are typically **learned automatically** by a neural network (e.g., a matrix factorization model or a deep network) trained on interaction data. The key relationship they capture is **proximity in the vector space indicates similarity in interest**. Videos often watched by the same users, or users who watch similar videos, will have **close embedding vectors**. [2 marks]

**(c) Diversity Penalty:**
- **Explanation**: A **diversity penalty** is a term added to the ranking model's loss function that **reduces the score** of items that are too similar to each other or to items already recommended in the current session. It encourages the final list to contain a **mix of content**. [1 mark]
- **Business & UX Justification**: From a **user experience** perspective, it **combats boredom and the filter bubble**, making the platform feel fresh and exploratory. From a **business** perspective, it **increases platform stickiness** by exposing users to a broader catalogue, reduces the risk of user churn due to monotony, and can surface more niche content that drives engagement from different user segments. [2 marks]

**(d) Hybridisation Method:**
- **Method**: **Cascade Hybrid**. [1 mark]
- **Justification**: The description clearly shows a **sequential process** where one technique (deep candidate generation) produces an output that is then **passed as input** to a second, different technique (the feature-rich ranking model). The result of the first stage directly enables and constraints the second stage, which is the hallmark of a **cascade**. [1 mark]
## Topic 4.1: Adaptive Content Presentation
### Question 4.1: Static & Semi-Automatic Approaches
An e-learning platform for programming uses adaptive techniques to present course material. The platform's architecture is based on **pre-authored content components**.

**(a) The platform initially used a **Page-Based Approach**, creating separate "Beginner," "Intermediate," and "Expert" versions of each lesson. Identify **one major disadvantage** of this approach from the **content author's perspective** and explain how it impacts system maintenance.**
[2 marks]

**(b) To improve flexibility, the platform migrates to a **Fragment-Based Approach**. For a lesson on "Python Functions," the page is assembled from the following fragments, each with an applicability condition:
*   F1: Basic syntax example (`user.knowledge_level = 'novice'`)
*   F2: Advanced decorator example (`user.knowledge_level = 'expert'`)
*   F3: Interactive code simulator (`user.preferred_learning_style = 'active'`)
*   F4: Text-based theory deep dive (`user.preferred_learning_style = 'reflective'`)
If a user has `knowledge_level = 'expert'` and `preferred_learning_style = 'active'`, which fragments will be included in the page? What **potential problem** with the *Optional Fragments* method does this illustrate?**
[3 marks]

**(c) To solve the problem identified in (b), the platform could switch to an **Altering Fragments** approach. Describe how the page structure would need to be re-designed to use this method, and state **one advantage** this redesign would bring for this e-learning scenario.**
[3 marks]

---
#### Model Answer 4.1
**(a) Major Disadvantage of Page-Based Approach:**
- **Disadvantage**: **Authoring Bottleneck / High Authoring Overhead**. [1 mark]
- **Impact on Maintenance**: It requires authors to **create, update, and synchronise multiple full versions of every single lesson**. A change to the core material (e.g., a new Python library) must be manually propagated across **three separate pages**, making maintenance **expensive, time-consuming, and error-prone**. This approach **does not scale** with the number of adaptation dimensions or user states. [1 mark]

**(b) Fragment Inclusion & Problem:**
- **Included Fragments**: **F2** (expert example) and **F3** (interactive simulator). [1 mark]
- **Illustrated Problem**: This illustrates the **Coherence Risk** (or **Combinatorial Jumbling**) problem inherent to *Optional Fragments*. [1 mark]
- **Explanation**: The included fragments (F2 and F3) are **independent components** selected solely because their individual conditions are true. There is **no guarantee they form a coherent, well-structured lesson**. The advanced decorator example (F2) might assume theoretical knowledge that the interactive simulator (F3) does not provide, leading to a confusing or disjointed learning experience. The page lacks a governing narrative or structure. [1 mark]

**(c) Altering Fragments Redesign & Advantage:**
- **Redesign**: The page must be decomposed into a **fixed template with specific slots (constituents)**. For example: `[Learning_Objective_Slot, Core_Example_Slot, Practice_Activity_Slot]`. For each slot, authors define **alternative fragments** (e.g., for `Core_Example_Slot`: a novice example, an expert example). The system then selects **one fragment per slot** based on the user model. [2 marks]
- **Advantage**: **Guarantees Pedagogical Coherence**. The fixed template ensures every lesson contains a logically ordered sequence of components (objective → example → practice). This provides a consistent learning structure while still allowing the *content within each slot* to adapt to the user's knowledge level and learning style. [1 mark]

---
### Question 4.2: Automatic Generation & LLMs
A financial news app wants to automatically generate **personalised summaries** of company earnings reports. The system has a user model containing `investment_expertise` (novice, expert) and `portfolio_holdings` (list of stocks user owns).

**(a) The team first builds a rule-based **Natural Language Generation (NLG)** system, inspired by GEA. It identifies key facts from the earnings data (e.g., "Revenue grew 5%", "EPS missed estimates") and has templates to phrase them. Describe **how the user model should influence** the content selection and phrasing for a `novice` vs. an `expert` user.**
[4 marks]

**(b) The team then experiments using a **Large Language Model (LLM)** like GPT-4, providing it with the raw earnings data and the user model in the prompt. What is the **key methodological advantage** of using an LLM over the rule-based NLG system? What is a **potential risk** specific to using an LLM in this financial context?**
[4 marks]

**(c) For users who own the stock being reported on, the app uses a **presentation technique** to immediately highlight the most critical information (e.g., "EPS MISS"). Suggest **two** different presentation techniques from the **Focus vs. Context** taxonomy that would be appropriate, and for each, give a **brief example** of how it would be applied in the app's summary text.**
[4 marks]

---
#### Model Answer 4.2
**(a) Influence of User Model on Rule-Based NLG:**
- **For a `novice` user**: The system should **select fewer, more fundamental metrics** (e.g., "Profit: Up or Down?"). **Phrasing** should use **plain language, avoid jargon**, and include **explanatory clauses** (e.g., "EPS (Earnings Per Share, a key profit measure) missed expectations."). The focus is on **high-level takeaways and education**. [2 marks]
- **For an `expert` user**: The system can **select a wider range of detailed metrics** (e.g., "Q4 EBIT margin expanded 120 bps year-over-year"). **Phrasing** can use **technical jargon and standard financial abbreviations** without explanation. The focus is on **precise, granular data and forward-looking guidance**. [2 marks]

**(b) LLM vs. Rule-Based NLG:**
- **Key Methodological Advantage**: **Fluency and Coherence**. An LLM can generate **more natural, varied, and contextually coherent narrative text** that connects disparate data points into a smooth summary. It can infer and articulate **implicit relationships** (e.g., "The revenue growth was driven by strong performance in Asia, offsetting weakness in Europe") that would be extremely complex to hard-code in a rule-based system. [2 marks]
- **Potential Risk**: **Hallucination / Factual Inaccuracy**. The LLM might **generate plausible-sounding but incorrect figures, trends, or conclusions** not present in the source earnings data. In a financial context, this could lead to **misinformed investment decisions** and serious legal/regulatory consequences. Rule-based systems, while rigid, are inherently more **controllable and verifiable**. [2 marks]

**(c) Appropriate Presentation Techniques:**
1.  **Colouring (Highlighting)**: The most critical sentence or phrase (e.g., "ADVERSE: Gross margin declined sharply") is given a **bright background colour (e.g., yellow)** within the text block, making it instantly visible upon scanning. [2 marks]
2.  **Sorting (Priority Ordering)**: In a bullet-point list of key takeaways, the points are **reordered** so that the most impactful information for the shareholder (e.g., "Dividend cut announced") appears **at the very top of the list**, regardless of its sequence in the original report. This uses **positional prominence** to convey priority. [2 marks]

---
### Question 4.3: Case Study & Hybrid Application
A travel planning website uses adaptive presentation to generate a **personalised "Trip Brief"** document for users researching a destination. The brief combines selected attractions, hotels, and logistical advice.

The system uses a **hybrid method**: It first employs a **Fragment-Based (Altering Fragments)** approach for the document's core structure, and then uses **Automatic Generation** to fill in specific details.

**Core Structure (Altering Fragments Slots):**
1.  **Header Section Slot**
2.  **Top 3 Attractions Slot**
3.  **Accommodation Advice Slot**
4.  **Travel Tips Slot**

**(a) For the **Header Section Slot**, two alternative fragments are: `F_Header_Casual` (title: "Your Awesome Trip to [City]!") and `F_Header_Formal` (title: "Travel Itinerary for [City]"). What **user model attribute** should drive the selection between these, and why?**
[2 marks]

**(b) The content for the **"Top 3 Attractions"** slot is **not pre-authored**. Instead, the system uses a **recommender algorithm** to select the three most relevant attractions, and then an **NLG module** to generate a one-sentence description for each. Which of the two broad **Adaptive Content Presentation approaches** (Static/Semi-Automatic vs. Automatic) does this part of the system represent? Justify your answer.**
[2 marks]

**(c) Considering the **entire hybrid system**, describe **one clear advantage** it has over a purely **Page-Based Approach**. Then, describe **one clear advantage** it has over a fully **Automatic Generation Approach** (e.g., an LLM generating the entire document from scratch).**
[4 marks]

---
#### Model Answer 4.3
**(a) User Model Attribute for Header Selection:**
- **Attribute**: **User's inferred or stated travel style/persona** (e.g., `travel_style = {'backpacker', 'family', 'business_traveller'}`) or potentially `formality_preference`. [1 mark]
- **Justification**: The header sets the tone of the entire document. A `business_traveller` or a user with `formality_preference = high` would expect a professional, concise header (`F_Header_Formal`). A `backpacker` or `family` user planning a leisure trip would likely respond better to an enthusiastic, casual header (`F_Header_Casual`). This adaptation increases perceived relevance and engagement. [1 mark]

**(b) Approach for "Top 3 Attractions" Slot:**
- **Approach**: **Automatic Generation**. [1 mark]
- **Justification**: The content is **generated dynamically on-the-fly** from underlying data (attraction database, user preferences) using algorithmic selection and natural language techniques. It is **not selected from a pre-authored set of fixed fragments**, which is the defining characteristic of Static/Semi-Automatic approaches. [1 mark]

**(c) Advantages of the Hybrid System:**
- **Advantage over Page-Based Approach**: **Superior Scalability and Flexibility**. The hybrid system does not require a pre-authored "Trip Brief" page for every possible combination of destination, user style, and season. The **Automatic Generation** component for attractions can handle countless destinations, and the **Altering Fragments** structure allows modular reuse of advice fragments (e.g., the same "family-friendly dining tips" fragment can be plugged into many different city briefs). [2 marks]
- **Advantage over Fully Automatic Generation (LLM-only)**: **Guaranteed Structural Quality and Control**. A pure LLM might produce a beautifully written but poorly structured document (e.g., missing a critical "Travel Tips" section, or burying vital visa information). The hybrid's **Altering Fragments** backbone **ensures a consistent, complete, and logically organised document structure** every time, as defined by domain experts. The LLM/Automatic components are then confined to generating high-quality content *within* that reliable structure. [2 marks]
## Topic 5.1: Layered Evaluation Framework
### Question 5.1: Layered Evaluation Framework
A team is developing "StudyPal," an adaptive learning app that recommends practice exercises. It collects data on time spent per question, correctness, and clicks on hints. It models student knowledge and decides which exercise to show next.

**(a) During a formative evaluation, it is discovered that the app frequently logs a "hint click" even when the user accidentally taps the hint button and immediately closes it. According to the **Layered Evaluation Framework**, which **specific layer** does this fault belong to? Justify your answer.**
[2 marks]

**(b) To fix this, the team changes the interpretation rule: a "hint click" is only registered if the hint panel stays open for >2 seconds. They now need to evaluate this new rule. Propose an **evaluation method** suitable for this layer and describe how you would apply it to test the new rule's validity.**
[3 marks]

**(c) The team proceeds to evaluate **Layer 4: Deciding Upon Adaptation**. Describe **two distinct evaluation criteria** appropriate for this layer in the context of StudyPal.**
[2 marks]

---
#### Model Answer 5.1
**(a) Fault Layer and Justification:**
- **Layer**: **Layer 1: Collection of Input Data**. [1 mark]
- **Justification**: The problem is with the **accuracy and reliability of the raw data capture**. The sensor (touch screen) is correctly detecting a tap, but the logging mechanism is failing to distinguish between an **intentional, meaningful interaction** and an **accidental tap**. The fault lies in the initial **collection logic**, before any interpretation of *what* the click means occurs. [1 mark]

**(b) Evaluation Method for the New Interpretation Rule:**
- **Method**: **User Test with Retrospective Think-Aloud** (or **Cross-Validation with Ground Truth**). [1 mark]
- **Application**: Recruit students to complete exercises using the app. **Record their screen and actions**. Afterwards, replay the session to the participant. For each instance where the new rule triggered (or didn't trigger) a "hint click," ask the participant: **"Was your intention here to use the hint, or was it an accident?"** [1 mark]
- **Analysis**: Compare the system's interpretation (hint click yes/no) with the participant's stated intent (ground truth). Calculate metrics like **precision** (% of registered hint clicks that were intentional) and **recall** (% of all intentional hint uses that were correctly registered). This directly evaluates the **validity** of the new interpretation rule. [1 mark]

**(c) Criteria for Layer 4 (Decision):**
1.  **Appropriateness**: Given the student's current knowledge model (e.g., weak on topic X), is the selected exercise (e.g., a hard problem on X) the **most pedagogically suitable** next step? Does it match learning theory (e.g., zone of proximal development)? [1 mark]
2.  **Acceptance**: Would an expert tutor or the student themselves **find the decision helpful and reasonable**? This assesses the decision's perceived utility before it is rendered. [1 mark]

---
## Topic 5.2: Usability Threats & A/B Testing
### Question 5.2: Usability Threats & A/B Testing
"NewsFlow" is a personalised news aggregator. An A/B test is conducted to evaluate a new recommendation algorithm designed to increase user engagement.

- **Group A (Control)**: Uses the old algorithm.
- **Group B (Treatment)**: Uses the new algorithm.

After two weeks, key results are:
- **Group B** shows a **15% higher average "articles read per session."**
- **Group B** shows a **10% lower "diversity score"** (measure of topic variety in consumed articles).
- A post-test survey indicates **Group B users report lower trust in the platform**.

**(a) The decrease in **diversity score** for Group B indicates the presence of a specific **usability threat** of adaptive systems. **Name** this threat and **explain** how it manifests in this scenario.**
[2 marks]

**(b) The survey result about **lower trust** in Group B likely relates to **two other usability threats**. Identify these **two threats** and briefly explain how the new algorithm might have caused them.**
[4 marks]

**(c) Based on the **mixed results** of this A/B test, should the team deploy the new algorithm? **Justify your recommendation** by weighing the measured benefits against the identified threats.**
[2 marks]

---
#### Model Answer 5.2
**(a) Usability Threat from Low Diversity:**
- **Threat**: **Filter Bubble / Diminished Breadth of Experience**. [1 mark]
- **Manifestation**: The new algorithm is likely over-specialising, recommending articles that are extremely similar to the user's past clicks. This creates a **narrow, reinforcing information loop**, trapping the user in a limited set of topics and perspectives, as evidenced by the lower diversity score. [1 mark]

**(b) Threats Leading to Lower Trust:**
1.  **Diminished Predictability**: Users cannot anticipate *why* they are being shown certain articles. The new algorithm's logic may be more complex or opaque, making the feed feel random or manipulative, eroding trust. [2 marks]
2.  **Diminished Controllability**: The new algorithm may offer **fewer or less effective ways for users to correct or influence** their recommendations (e.g., "Not Interested" buttons that don't work). This loss of agency makes users feel the system is controlling them, not serving them, reducing trust. [2 marks]

**(c) Deployment Recommendation:**
- **Recommendation**: **Do not deploy** the new algorithm in its current state. [1 mark]
- **Justification**: While the algorithm succeeds on a **single engagement metric** (articles/session), it **fails on critical qualitative dimensions** (diversity, trust) that are essential for long-term user retention and platform health. Increasing engagement at the cost of creating filter bubbles and eroding trust is a **short-sighted trade-off** that will likely lead to user churn and reputational damage over time. The algorithm needs redesign to incorporate **diversity safeguards** and **transparency features** before deployment. [1 mark]

---
## Topic 6.1: Ethics & Transparency with LLMs
### Question 6.1: Ethics & Transparency with LLMs
"HealthGuide" is a proposed LLM-powered chatbot that provides personalised lifestyle and basic symptom advice. It asks users about their diet, exercise, and symptoms to generate tailored recommendations.

**(a) Using the **EU's Ethics Guidelines for Trustworthy AI**, identify the **two most critical requirements** that HealthGuide's designers must prioritise to ensure safety and ethics. For each, **give a specific example** of a harm that could occur if the requirement is neglected.**
[6 marks]

**(b) To address **transparency**, the team uses the **Transparency Checklist**. They consider adding this feature: *"A 'Why this advice?' button that shows the main user-inputted symptoms used to generate the response."*
Which **Best Practice (BP)** from the checklist does this feature most directly address? Is this feature **sufficient** for full transparency regarding the *processing* of the advice? Justify your answer.**
[4 marks]

**(c) The team is debating whether to include a **clear disclaimer** that HealthGuide is an AI, not a medical professional. Arguing from the **EU Guidelines**, which requirement provides the strongest justification for including this disclaimer? Explain.**
[2 marks]

---
#### Model Answer 6.1
**(a) Critical Requirements and Potential Harms:**
1.  **R2: Technical Robustness & Safety**. This is paramount for health-related advice. [1 mark]
    - **Example Harm**: The LLM could **hallucinate** and recommend a dangerous interaction (e.g., "Mixing your medication with grapefruit juice is fine" when it is contraindicated), leading to serious patient harm. [2 marks]
2.  **R1: Human Agency & Oversight**. Users must not over-rely on the AI for critical health decisions. [1 mark]
    - **Example Harm**: A user with early signs of a heart attack might be convinced by the chatbot's reassuring but incorrect advice to "rest at home," delaying crucial emergency care and resulting in severe health deterioration or death. [2 marks]

**(b) Transparency Feature Analysis:**
- **Best Practice Addressed**: **BP3** ("Explain which data, factors, or criteria were used"). The button discloses the **specific input data** (symptoms) that contributed to the output. [1 mark]
- **Sufficiency**: **No, it is not sufficient**. [1 mark]
- **Justification**: While it shows the *input*, it does not explain the *reasoning* or *logic* (the "processing"). It fails to disclose **how** those symptoms were weighted, combined with medical knowledge, or used to arrive at the final recommendation. For full processing transparency, it should also explain the **inferential step** (e.g., "Symptom X + Y suggests condition Z, therefore the advice is...") and the **system's confidence level**. This aligns with the deeper goal of BP3/BP4. [2 marks]

**(c) Justification for AI Disclaimer:**
- **Requirement**: **R1: Human Agency & Oversight** (specifically the principle of **Clear Demarcation**). [1 mark]
- **Explanation**: The disclaimer is a **fundamental safeguard** to preserve human agency. It ensures users maintain an accurate **mental model** of the system as a fallible machine tool, not a qualified human expert. This mitigates **over-reliance** and encourages users to exercise their own judgment and seek professional human oversight for serious health concerns, thus upholding their autonomy and safety. [1 mark]

---
## Topic 6.2: Integrating Ethics into Evaluation
### Question 6.2: Integrating Ethics into Evaluation
A social media company is planning a **layered evaluation** of its new LLM-powered content moderation system, which automatically flags and explains its reasoning for potentially harmful posts.

**(a) For **Layer 2: Interpretation of Collected Data**, the system must interpret raw text posts as "hate speech," "harassment," or "safe." Beyond technical validity, which **ethical requirement** from the EU framework becomes crucial to evaluate here? Name the requirement and explain what the evaluation should check for.**
[3 marks]

**(b) When evaluating **Layer 6: The System as a Whole**, the team plans an A/B test measuring the **rate of harmful content** slipping through. What **additional, non-behavioural metric** must they **also** collect to responsibly assess the system's overall impact, and why?**
[3 marks]

**(c) The transparency checklist highlights that most systems fail to explain *processing*. Draft a **sample explanation** this moderation system could show to a user whose post was flagged, that would satisfy **BP3** by explaining the *processing* (not just the input).**
[2 marks]

---
#### Model Answer 6.2
**(a) Ethical Requirement for Layer 2:**
- **Requirement**: **R5: Diversity, Non-Discrimination & Fairness**. [1 mark]
- **Evaluation Check**: The evaluation must assess whether the interpretation logic exhibits **bias**. It should check if the system **disproportionately flags posts** from, or mentioning, certain **demographic groups** (e.g., racial minorities, LGBTQ+ individuals) as "hate speech" when similar sentiment expressed about majority groups is labelled "safe." This involves testing the model's **false positive rates across protected attributes**. [2 marks]

**(b) Additional Layer 6 Metric:**
- **Metric**: **Perceived Fairness / Justice** among affected user subgroups, gathered via **surveys or interviews**. [1 mark]
- **Why**: A/B tests only measure aggregate behavioural outcomes. A system could reduce overall harmful content (a success) but do so in a **biased manner**, unfairly censoring marginalised voices. This would constitute a major ethical failure (violating **R5**) and could cause societal harm. Measuring subjective perceptions of fairness from those whose content is moderated is essential to detect this. [2 marks]

**(c) Sample Processing Explanation:**
"**Why this post was flagged**: Your post contains the phrase '[quote].' Our system identified this as a **common derogatory trope associated with [protected group X]**. This matched **pattern #D4** in our hate speech policy, which prohibits dehumanizing language based on protected characteristics. The confidence of this classification was **85%**." [2 marks]
*(This explains the **criteria** (policy pattern) and the **reasoning** (matching a known trope), going beyond just highlighting keywords.)*

# Last year's exam paper's
### Question 1: Amazon Personalised Shopping (2023/4)
![[amazon-question-2023-24-screenshot.png|400]]
#### Question 1(a)
**Describe what recommender method has been applied in this case. Indicate one strength and one weakness of the approach.**
[6 marks]
#### Model Answer with Detailed Explanation
> **Method Applied**: The interface demonstrates a **Mixed Hybrid Recommender** approach. Specifically, it shows two different recommendation algorithms operating in parallel:
> 1.  **"Products related to this item"** – This appears to be a **Content-Based Filtering (CBF)** approach, recommending items with similar features (category, brand, specifications) to the one the user is viewing.
> 2.  **"Customers also bought these items from Amazon Devices"** – This is a classic **Item-Item Collaborative Filtering (CF)** approach, recommending items frequently purchased together by other users.
>
> The **Mixed** hybridisation method presents these two distinct recommendation lists **side-by-side** in the same interface. [2 marks]

> **One Strength**: **Increased Diversity and Serendipity**. By combining CBF and CF, the system mitigates the key weakness of each. Pure CBF tends to create a **filter bubble** of overly similar items. Pure CF can be biased towards popular items. The CF component in the hybrid can suggest **serendipitous items** that are functionally different but contextually relevant (e.g., a case for a device), while the CBF component ensures **relevance** based on item attributes. This diversifies the user's options and can lead to more satisfactory discovery. [2 marks]

> **One Weakness**: **Potential for User Confusion and Interface Clutter**. Presenting two separate lists with different underlying logics ("similar items" vs. "popular combos") can overwhelm or confuse users who may not understand why they are seeing different things. It can also lead to a **cluttered interface**, requiring more cognitive effort from the user to parse the information. Additionally, a simple mixed approach gives **equal visual weight** to both methods, which may not be optimal if one method is significantly more accurate or useful for that particular user or product category. [2 marks]

---
#### Question 1(b)
**Amazon uses collaborative filtering to suggest items from other users (e.g., "Customers also bought these items from Amazon Devices"). Describe two strengths and two limitations of implementing collaborative filtering in Amazon and illustrate with examples referring to the specific application context.**
[8 marks]
#### Model Answer with Detailed Explanation
> **Strength 1: Leverages the "Wisdom of the Crowd" for Discovery**.
> **Explanation**: CF does not require deep knowledge of product features. It identifies patterns from the **user-item interaction matrix** (purchases, views). This allows it to surface **non-obvious associations** that content-based systems might miss.
> **Amazon Example**: CF can reveal that people who buy a specific Kindle often buy a **particular brand of screen protector** and a **popular mystery novel series**. A CBF system looking at Kindle features would never recommend a book. This cross-category discovery drives additional sales and enhances user satisfaction by meeting unstated needs. [2 marks]

> **Strength 2: Automatically Adapts to Trends and Seasonality**.
> **Explanation**: As community purchasing behaviour changes, the CF model updates. Popular items rise to the top of recommendations organically.
> **Amazon Example**: During back-to-school season, CF will quickly start recommending **laptops, notebooks, and dorm supplies** together, as the collective purchase data reflects this trend, without any manual rule updates. It effectively captures real-time market dynamics. [2 marks]

> **Limitation 1: Item Cold-Start Problem**.
> **Explanation**: A new item has no purchase history, so it cannot be recommended by CF until it accumulates sufficient interactions.
> **Amazon Example**: When Amazon launches a **new, innovative product** (e.g., a new Echo model), CF cannot recommend it in "customers also bought" lists for the first few days or weeks, significantly hampering its initial visibility and sales velocity. It relies entirely on other marketing channels initially. [2 marks]

> **Limitation 2: Popularity Bias and Reduced Diversity**.
> **Explanation**: CF tends to recommend items that are already popular, creating a **positive feedback loop** where popular items get more recommendations and become even more popular. This can suppress niche or high-quality but less-known items.
> **Amazon Example**: For a niche product like a **specialised engineering textbook**, CF will overwhelmingly recommend best-selling novels or mainstream tech gadgets in the "also bought" section, rather than other specialised academic texts. This narrows the user's perceived choices and disadvantages long-tail sellers. [2 marks]

---
#### Question 1(c)
**Suggest two accuracy metrics that Amazon can use to compare different recommender algorithms and justify why you have selected these metrics.**
[6 marks]
#### Model Answer with Detailed Explanation
> **Metric 1: Precision@K (e.g., Precision@10)**.
> **Definition**: The proportion of items in the **top-K recommended list** that are relevant to the user (where relevance is defined by a positive action like a purchase or click). $$\text{Precision@K} = {\text{\# of relevant items in top K} \over K}$$**Justification for Amazon**: This metric directly measures the **business utility** of the recommender's most prominent output—the shortlist shown on screen. Amazon's goal is to maximise the chance a user clicks or buys from the recommended set. High Precision@K means the interface real estate dedicated to recommendations is being used effectively to drive conversions. It's more actionable than rating prediction error. [3 marks]

> **Metric 2: Root Mean Squared Error (RMSE)**.
> **Definition**: A measure of the **average magnitude of prediction error** for explicit ratings. $RMSE = \sqrt{\frac{1}{N} \sum_{i=1}^{N}(predicted_i - actual_i)^2}$.
> **Justification for Amazon**: While Amazon focuses on implicit data (clicks/purchases), it also collects explicit **star ratings**. RMSE is suitable for evaluating algorithms that predict these ratings (e.g., for "rate products you've bought" features or internal quality estimation). A lower RMSE indicates the system can more accurately predict how much a user will *like* an item, which is a foundational goal of personalisation. It is more sensitive to large errors than MAE, penalising severe mispredictions. [3 marks]

---
#### Question 1(d)
**Describe why accuracy metrics can be insufficient for evaluating recommender algorithms; suggest one other metric that can be used and justify your suggestion in the context of Amazon product recommendations.**
[6 marks]
#### Model Answer with Detailed Explanation
> **Why Accuracy Metrics are Insufficient**:
> Accuracy metrics like Precision and RMSE measure **predictive performance against observed data**. Their key insufficiency is that they evaluate a **narrow slice of the user experience**. They assume the "ground truth" (what the user *did* interact with) is all that matters. However, users **"don't know what they don't know"**—they cannot click on items never shown to them. An algorithm could have high precision by only recommending extremely safe, popular items the user is already aware of, while completely failing its **discovery role**. Accuracy metrics also ignore **user satisfaction, trust, perceived diversity, and long-term engagement**, which are critical for business success. [2 marks]

> **Alternative Metric: Intra-List Diversity**.
> **Definition**: A measure of how **dissimilar** the items within a single recommendation list are from each other. Can be calculated as the average pairwise dissimilarity (1 - similarity) between all items in the list.
> **Justification for Amazon**: For Amazon, maximising user engagement and basket size requires exposing users to a **varied catalogue**. Low diversity (a list of 10 nearly identical phone cases) leads to a **poor user experience** and limits cross-selling opportunities. High diversity (phone cases, screen protectors, headphones, charging bricks) increases the chance of satisfying multiple user needs and encourages exploration. Monitoring diversity ensures the algorithm does not fall into an **overspecialisation trap** and maintains the commercial health of the marketplace by distributing visibility across more products. [4 marks]

---
#### Question 1(e)
**To generate the interface with product recommendations (as shown in the image), Amazon could use optional fragments. Give two example fragments that could be used and define corresponding applicability conditions. Based on the examples, describe one problem with using optional fragments and identify an alternative algorithm which can overcome the problem.**
[8 marks]
#### Model Answer with Detailed Explanation
> **Example Fragment 1: Customer Review Snippet Fragment**.
> **Applicability Condition**: `IF` (product.average_rating >= 4.0) `AND` (number_of_reviews > 50). This ensures the fragment showing a positive review quote only appears for well-established, highly-rated products, adding social proof. [2 marks]

> **Example Fragment 2: "Frequently Bought Together" Discount Promotion Fragment**.
> **Applicability Condition**: `IF` (item_item_similarity(primary_item, candidate_item) > threshold) `AND` (candidate_item.in_stock = TRUE) `AND` (bundle_discount_available = TRUE). This fragment, which shows a combo deal, only appears if there's a strong CF association, the item is available, and a promotional bundle exists. [2 marks]

> **Problem with Optional Fragments: Combinatorial Explosion and Coherence Risk**.
> **Explanation**: As the number of fragments and conditions grows, managing them becomes **error-prone and unscalable**. More critically, the method simply includes *all* fragments whose conditions are true, with **no governing page structure**. This could lead to an **incoherent or cluttered layout**. For instance, the "Review Snippet" and "Frequently Bought Together" fragments might appear visually jumbled or in a illogical order, degrading the user experience. The system lacks a **template** to ensure a logical flow of information. [2 marks]

> **Alternative Algorithm: Altering Fragments (Slots and Constituents)**.
> **Explanation**: This approach defines a **fixed template** for the product page with specific **slots** (e.g., `Slot_A: Product_Media`, `Slot_B: Social_Proof`, `Slot_C: Cross_Sell`). For each slot, a set of alternative fragments is defined. The system selects the **single most appropriate fragment** for each slot based on the user and product context. For the `Social_Proof` slot, it might choose *either* the "Review Snippet" fragment *or* a "Award Badge" fragment, but not both, ensuring a clean, structured layout. This guarantees **coherence and predictable page structure** while still allowing adaptation. [2 marks]

---
### Question 2: ECoach Student Coaching System
#### Question 2(a)
![[ecoach-question-2023-24-screenshot.png|400]]
**Define two possible stereotypes that could be used in ECoach. For each stereotype, suggest: (i) one trigger and the stereotype probability associated with this trigger and (ii) two facets, associate three values with each facet and indicate the corresponding ratings. Give a brief justification for each stereotype.**
[16 marks]
#### Model Answer with Detailed Explanation
> **Stereotype 1: The Proactive Planner**.
> **Trigger and Probability**: `IF` (average_assignment_submission_time > 3 days before deadline) `AND` (calendar_usage = high) → `P = 0.8`. The trigger captures early submission and tool use; the high probability reflects that these are strong, observable indicators of planning behaviour. [2 marks]
>
> **Facets, Values, and Ratings**:
> 1.  **Facet: Study Strategy Preference**
>     - Value: `Spaced Repetition` → Rating: 90/100
>     - Value: `Cramming` → Rating: 20/100
>     - Value: `Group Study` → Rating: 60/100
> 2.  **Facet: Stress Intervention Need**
>     - Value: `Time Management Tips` → Rating: 30/100 (already good at this)
>     - Value: `Mindfulness Exercises` → Rating: 70/100 (to maintain balance)
>     - Value: `Breathing Techniques` → Rating: 50/100
> [4 marks for facets]
>
> **Justification**: This stereotype identifies students who are organised but may still benefit from **wellbeing support to prevent burnout**. The high rating for spaced repetition informs the system to recommend related tools, while the moderate rating for mindfulness suggests promoting those resources proactively. It helps ECoach transition from pure academic support to **holistic coaching**. [2 marks]

> **Stereotype 2: The At-Risk Disengager**.
> **Trigger and Probability**: `IF` (lecture_access_logs.percentage_accessed < 50%) `AND` (forum_posts = 0) → `P = 0.7`. The trigger uses easily obtainable log data on content access and participation. The probability is not maximum (1.0) because low access could have other causes (e.g., technical issues, using offline materials). [2 marks]
>
> **Facets, Values, and Ratings**:
> 1.  **Facet: Academic Support Priority**
>     - Value: `Catch-Up Lecture Summaries` → Rating: 90/100
>     - Value: `Office Hours Encouragement` → Rating: 80/100
>     - Value: `Past Paper Practice` → Rating: 40/100 (premature if behind)
> 2.  **Facet: Barrier to Engagement**
>     - Value: `Lack of Confidence` → Rating: 85/100
>     - Value: `Time Poverty` → Rating: 75/100
>     - Value: `Content Difficulty` → Rating: 60/100
> [4 marks for facets]
>
> **Justification**: This stereotype is **diagnostic and intervention-focused**. The high ratings for catch-up summaries and office hours direct ECoach to provide **immediate, actionable academic support**. The "Barrier" facet helps tailor motivational messaging—for high "Lack of Confidence," ECoach might highlight growth mindset content. It enables **early, targeted intervention** before formal academic warnings. [2 marks]

---
#### Question 2(b)
**Describe one implicit user information collection technique which can be used to extract stereotype-based user profiles in ECoach. Identify one advantage and one limitation of the chosen technique in the specific context.**
[6 marks]
#### Model Answer with Detailed Explanation
> **Technique**: **Analysis of Learning Management System (LMS) Interaction Logs**.
> **Description**: ECoach can be integrated with the university's LMS (like Minerva) to **passively analyse log data**. This includes timestamps of when a student accesses lecture slides, video views (and re-watches), time spent on quizzes, frequency of visiting discussion forums, and submission times for assignments. Patterns in this data (e.g., last-minute access, avoiding difficult materials) are used to **infer engagement levels, study habits, and potential struggles**, which feed into the stereotype matching engine. [2 marks]

> **Advantage**: **Unobtrusive and Scalable Data Collection**.
> **Explanation**: This method requires **no extra effort** from the student, avoiding survey fatigue. It captures **authentic, behavioural data** at scale across thousands of students, providing a rich, continuous stream of evidence for stereotype triggers and profile updates. It's far more efficient than manual observation or frequent explicit check-ins. [2 marks]

> **Limitation**: **Risk of Misinterpretation and Ethical Ambiguity**.
> **Explanation**: Log data reveals *what* was done, not *why*. A student who doesn't watch lecture videos might be disengaged (**At-Risk Disengager**), or they might be using superior textbooks or attending in person. This can lead to **false positives** and stigmatising labels. Ethically, there are concerns about **transparency** (do students know they're being profiled this way?) and **privacy** (continuous monitoring can feel like surveillance), especially if the data is used for purposes beyond supportive coaching. [2 marks]

---
#### Question 2(c)
**Describe one explicit user information collection technique which can be used to extract the stereotype-based user profiles in ECoach. Identify one advantage and one limitation of the chosen technique.**
[6 marks]
#### Model Answer with Detailed Explanation
> **Technique**: **Periodic Self-Reflection and Goal-Setting Questionnaires**.
> **Description**: ECoach can prompt students at regular intervals (e.g., start of term, after exams) to complete a structured questionnaire. This would ask for **explicit self-assessment** on facets like perceived stress, confidence in topics, study hours, and personal goals (as seen in the "GET THINGS DONE" area of the screenshot). Students could also set and adjust **short-term challenges**. Their direct inputs would **override or strongly weight** the corresponding values in their user profile. [2 marks]

> **Advantage**: **Promotes Student Agency, Metacognition, and Provides Ground Truth**.
> **Explanation**: This technique actively involves the student in the modelling process, fostering a sense of **control and partnership** (Human-Computer Partnership). It encourages **metacognition**—thinking about one's own learning—which is a valuable educational outcome in itself. Most importantly, it provides a **direct, ground-truth signal** about the student's internal state, correcting potential misinterpretations from implicit data and making the model more accurate and trustworthy. [2 marks]

> **Limitation**: **Reliability and Honesty Concerns, and Increased Burden**.
> **Explanation**: Self-reported data can be **unreliable**. Students may misrepresent their state due to social desirability bias (e.g., under-reporting stress) or lack of self-awareness. They might also see it as a **burdensome task** and rush through it, providing noisy or random answers. If the system's adaptive advice changes dramatically based on this input, students might learn to "game" the system to get desired outputs, breaking the adaptive loop. [2 marks]

---
#### Question 2(d)
**Compose an example from the stereotypes in (a) which illustrates a problem with stereotypes and suggest a way to address the problem.**
[5 marks]
#### Model Answer with Detailed Explanation
> **Example Illustrating the Problem**:
> Consider a student who fits the trigger for the **"At-Risk Disengager"** stereotype (low lecture access, no forum posts) due to a **hidden disability** like chronic fatigue, requiring them to study in short, intense bursts from downloaded materials. The stereotype would assign high ratings for "Lack of Confidence" (85) and "Catch-Up Summaries" (90). Consequently, ECoach might flood them with **confidence-building messages and remedial content**, which is **irrelevant, patronising, and potentially demoralising**. This illustrates the core problem: **Stereotypes are over-generalised and can perpetuate bias, misrepresenting individuals and leading to inappropriate, one-size-fits-all adaptations.** [2 marks for problem, 1 mark for relating to example]

> **Way to Address the Problem**: **Implement a Scrutable User Model with Mixed-Initiative Refinement**.
> **Explanation**: The system should make its inferred profile (the stereotype and its facet ratings) **visible and editable** to the student. The interface could say: "ECoach thinks you might be finding the course challenging because you're accessing fewer lectures. Is this accurate?" It would then allow the student to: 1) **Confirm or deny** the stereotype assignment, and 2) **Manually adjust the facet ratings** (e.g., slide "Lack of Confidence" down to 20). This **human-in-the-loop** approach combines the efficiency of stereotyping for initialisation with the accuracy of explicit user control, **mitigating bias and increasing model fidelity**. [2 marks]

---
### Question 3: Sustainable Living App
#### Question 3(a)
**Following the general architecture of user-adaptive systems, answer the following questions...**
[10 marks]
#### Model Answer with Detailed Explanation
> 1.  **What is included in the user model?**
>     The **User Model** is a structured representation containing: (i) **Preference scores** for different sustainable activity categories (e.g., `{recycling: 0.8, low_transport: 0.5, diet: 0.9}`), inferred from explicit and implicit data. (ii) **Knowledge level** about sustainability concepts (e.g., `beginner`, `intermediate`). (iii) **Media preference vector** (e.g., `{video: 0.7, text: 0.3, audio: 0.5}`). This directly corresponds to the data collected at registration and refined via logs. [2 marks]

> 2.  **What user data is gathered and how?**
>     Data is gathered via a **hybrid acquisition** strategy:
>     - **Explicitly**: Upon registration via a **form** (stated preferences, knowledge self-assessment, media choice).
>     - **Implicitly**: During use via **log data** tracking (which tips are clicked/read/completed, time spent on resources, search queries within the app). This is **unobtrusive data collection**. [2 marks]

> 3.  **How is the user data used to maintain the user model?**
>     The **User Model Acquisition** component processes the raw data. Explicit registration data creates the **initial model**. Implicit log data is then used for **continuous model update**. For example, if a user repeatedly clicks and completes "cycling tips," their preference score for `low_transport` is increased. A **forgetting mechanism** might be applied to decay old interests and highlight recent ones, handling **concept drift** as the user's lifestyle changes. [2 marks]

> 4.  **What adaptation features are provided?**
>     The app provides **adaptive content selection and presentation**. Key features include: (i) **Personalised activity suggestions** (e.g., "Try meat-free Monday" for a user with high `diet` preference). (ii) **Tailored educational content** (basic explanations for `beginner`, policy debates for `expert`). (iii) **Adapted media format** (serving videos to users with high `video` preference). [2 marks]

> 5.  **How is the user model utilised to implement the adaptation features?**
>     The **User Model Application** component (adaptation engine) uses the model to drive decisions. For a `beginner` user with high `recycling` preference, it applies a **Content-Based Filtering (CBF)** algorithm: it selects tips from the knowledge base whose **features** (topic="recycling", complexity="low") best match the user's **profile vector** (high recycling weight, low knowledge score). It then presents the selected tip in the user's preferred `video` format. The model is the **query** against the domain's **item features**. [2 marks]

---
#### Question 3(b)
**Discuss how a layered approach can be applied to conduct formative evaluation of the personalised health recommendations...**
[15 marks]
#### Model Answer with Detailed Explanation
> **Layer 1: Collection & Interpretation of Input Data**.
> - **Criteria**: **Accuracy** (does the app correctly log a tip being read?), **Completeness** (is all relevant behaviour captured?), and **Interpretive Validity** (does "spent 30s on a tip" accurately imply "interest"?).
> - **Evaluation Method**: **Data Log Analysis & Cross-Validation with User Interviews**. Analysing logs for missing events. Then, conducting **retrospective think-aloud** sessions: show users their activity timeline and ask, "Here you spent 30 seconds on this tip—what were you thinking?" Compare the system's interpretation with the user's stated intent.
> - **Challenge**: **Ethical and Practical Hurdles in Ground Truth Collection**. Getting honest, accurate self-reports about sustainable behaviour can be subject to **social desirability bias** (users over-reporting green actions), making validation difficult. [5 marks]

> **Layer 2: Modelling the Current State (User & Domain Model)**.
> - **Criteria**: **Predictive Accuracy** (does the user model correctly predict which tip the user will click next?), **Comprehensiveness** (does the domain model cover all relevant sustainability aspects?).
> - **Evaluation Method**: **Offline Testing with Historical Data**. Split historical log data into training/test sets. Train the user modelling algorithm on the training set and test its predictions (e.g., will the user click?) on the held-out test set. Calculate metrics like **precision, recall, or F1-score**.
> - **Challenge**: **Non-Stationarity of the Domain**. Sustainability knowledge and best practices evolve rapidly. A model trained on last year's data may be **outdated**, and continuous re-evaluation is needed. [5 marks]

> **Layer 3: Adaptation Decision & Application**.
> - **Criteria**: **Perceived Usefulness** (do users find the recommendations helpful?), **Behavioural Change Efficacy** (do the adaptations lead to more sustainable actions?).
> - **Evaluation Method**: **Controlled User Studies & Heuristic Evaluation**. In a lab, observe users interacting with the adapted recommendations and conduct post-session interviews/surveys on usefulness. Separately, **domain experts** (environmental scientists) can evaluate if the recommended actions are **appropriate and scientifically sound** for the user's inferred profile.
> - **Challenge**: **Long-Term Impact Measurement**. True success is measured in sustained lifestyle change, which requires **longitudinal field studies** that are costly and time-consuming. Short-term perceived usefulness may not correlate with long-term behavioural impact. [5 marks]

---
#### Question 3(c)
**Describe two features that can be added to the app to improve the transparency of the input for its personalised sustainable living recommendations.**
[6 marks]
#### Model Answer with Detailed Explanation
> **Feature 1: A "Your Profile & Data" Dashboard (Addresses BP1 & BP2)**.
> **Description**: Create a dedicated settings page titled "How we personalise your experience." This dashboard would **visually show the user** the key data points in their profile: "Based on your sign-up, we know you're interested in: [Diet, Recycling]. We've noticed you've been reading about: [Composting]. You prefer to learn via: [Video]." It would also list the **implicit data sources** (e.g., "We track which tips you open to understand what interests you").
> **Transparency Improvement**: This directly addresses **Best Practice 1 (Accessibility)** and **BP2 (Input Data Disclosure)**. It makes the collected data and the resulting model **accessible, understandable, and actionable**, allowing the user to see the direct link between their actions and the system's "understanding" of them. [3 marks]

> **Feature 2: Inline "Why This Suggestion?" Explanations (Addresses BP3)**.
> **Description**: Next to each recommended tip (e.g., "Visit a local farmer's market"), include a small icon (ℹ️) or link labelled "Why this for me?". Clicking it reveals a concise, **feature-based explanation**: "This suggestion combines your **strong interest in sustainable diet** with an opportunity to **reduce transport emissions** (a topic you've recently read about). It's also a **video**, which you prefer."
> **Transparency Improvement**: This tackles the most common industry failure identified by the transparency checklist: explaining the **processing** (**Best Practice 3**). It moves beyond just stating *what* data was used to explain *how* that data was combined (reasoning) to produce the specific output, demystifying the personalisation logic. [3 marks]

---
#### Question 3(d)
**Describe one privacy concern about the app which users may have and justify why this concern may occur.**
[2 marks]
#### Model Answer with Detailed Explanation
> **Privacy Concern**: **Profiling of Sensitive Lifestyle and Beliefs Leading to Discrimination or Unwanted Targeting**.
> **Justification**: The app builds a detailed profile of a user's **sustainable behaviours, dietary choices, and political/ethical leanings** (e.g., veganism, anti-consumerism). This constitutes **sensitive inferential data**. Users may fear this profile could be:
> 1.  **Shared with third parties** (e.g., health insurers who might penalise "high-carbon" lifestyles, or political campaigns for micro-targeting).
> 2.  **Used for manipulative advertising** (e.g., targeting "guilt-based" ads for expensive eco-products).
>
> This concern is valid because privacy policies are often complex, and **data monetisation** is a common business model. The very act of **tracking** for personalisation (e.g., logging that a user researches "flight shame") creates a permanent record of potentially sensitive **intentions and values**, which could be misused if the data is breached or sold. [2 marks]