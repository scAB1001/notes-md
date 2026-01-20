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

# More
## Topic: Advanced Hybridisation & ML Pipelines
### Question 1: The "ChefPal" Recipe & Meal Planning App
ChefPal is an adaptive app that generates weekly meal plans. It uses a **multi-stage pipeline**: first, a constraint-based filter removes recipes containing allergens; second, a **neural network** predicts a user's rating for remaining recipes based on their past ratings and recipe features; third, a **diversity optimizer** ensures the weekly plan includes varied cuisines.

**(a) Identify the **hybridisation method** used in ChefPal's pipeline. Justify your answer by mapping each stage of the pipeline to a component of the hybrid method.**
[4 marks]

**(b) The neural network in stage two uses **embedding layers** for both users and recipe ingredients. Explain what an embedding layer does in this context and **two advantages** it provides over using one-hot encoded categorical variables.**
[6 marks]

**(c) The **diversity optimizer** (stage three) is critiqued for sometimes replacing a highly predicted recipe with a less-liked but more diverse one, potentially reducing short-term user satisfaction. From the **EU Ethics Guidelines**, which requirement (R1-R7) does this trade-off most directly engage with? Justify your answer.**
[3 marks]

---
#### Model Answer 1
**(a) Hybridisation Method:**
- **Method**: **Cascade Hybrid**. [1 mark]
- **Justification**: The process is **strictly sequential**, where the output of one stage becomes the constrained input for the next. [1 mark]
    1.  **Stage 1 (Constraint Filter)**: Acts as the **first algorithm** in the cascade, producing a candidate set free of allergens.
    2.  **Stage 2 (Neural Network)**: Acts as the **second algorithm**, taking the filtered candidate set and re-ranking it by predicted rating.
    3.  **Stage 3 (Diversity Optimizer)**: Acts as the **third (final) algorithm**, taking the re-ranked list and applying a final re-ordering to enforce diversity. Each stage operates on the output of the previous one. [2 marks]

**(b) Embedding Layers:**
- **What it does**: An **embedding layer** learns to map categorical data (e.g., user IDs, ingredient names) into a **dense, low-dimensional vector space**. During training, it adjusts these vectors so that similar users or ingredients end up **close together** in this learned space. [2 marks]
- **Advantage 1: Captures Semantic Relationships**. Learned embeddings can capture **latent similarities** that one-hot encoding cannot. For example, the embeddings for "thyme" and "rosemary" might become close in the vector space because they often co-occur in recipes, even though they are lexically distinct. One-hot encoding treats all ingredients as orthogonal. [2 marks]
- **Advantage 2: Handles High Cardinality & Sparsity Efficiently**. One-hot encoding for thousands of users/ingredients creates huge, sparse vectors that are computationally inefficient. Embeddings **compress** this information into a fixed, dense size (e.g., 64 dimensions), drastically reducing model parameters and improving learning efficiency. [2 marks]

**(c) Ethical Requirement:**
- **Requirement**: **R1: Human Agency & Oversight**. [1 mark]
- **Justification**: This trade-off engages with the tension between **system autonomy and user preference**. The system is making an autonomous decision to **override a user's predicted preference** (high-rated recipe) for a perceived long-term benefit (dietary diversity). This risks **diminishing user agency** if the user feels their tastes are being ignored for the system's agenda. The guideline emphasises that users should retain **meaningful control**; this scenario necessitates transparency about the trade-off and possibly user controls over the diversity vs. preference balance. [2 marks]

---
## Topic: Stereotypes, Bias, & Fairness
### Question 2: The "CareerPath" AI Career Advisor
CareerPath uses stereotypes to provide initial career suggestions to students. One stereotype is "TECH_INCLINED": triggered if a student's grades in Maths and Computing are >70%. The stereotype suggests high ratings for careers like "Software Developer" and "Data Scientist," and low ratings for "Primary School Teacher" or "Social Worker."

**(a) This stereotype, while efficient, poses a **fairness risk**. Name this specific type of algorithmic bias and explain how it could manifest and cause harm in this educational context.**
[4 marks]

**(b) Describe a **technical mitigation strategy** (during system design) and a **procedural mitigation strategy** (during system use) to address the bias identified in (a).**
[4 marks]

**(c) CareerPath switches from stereotypes to a **Collaborative Filtering (CF)** model after collecting sufficient data on a student's app interactions. Explain why this switch might **perpetuate or even amplify** the initial bias from the stereotype, rather than correcting it.**
[3 marks]

---
#### Model Answer 2
**(a) Fairness Risk:**
- **Type of Bias**: **Historical/Representational Bias** and **Social Stereotyping Bias**. [1 mark]
- **Manifestation & Harm**: The stereotype encodes and automates **existing societal biases** that equate high STEM grades with technical careers and undervalue caring professions. [1 mark]
- **Harmful Impact**:
    1.  **Self-Fulfilling Prophecy**: A student who excels in Maths but has a passion for teaching might be steered away from it, narrowing their perceived options based on a biased algorithm.
    2.  **Reinforcement of Gender/Social Biases**: If historical data shows more males in "TECH_INCLINED," the stereotype may disproportionately steer male students towards tech, **perpetuating gender imbalances** in both tech and education fields. This is a clear violation of **fairness (R5)**. [2 marks]

**(b) Mitigation Strategies:**
- **Technical Strategy**: **Debiasing the Training Data & Model**. Use techniques like **adversarial debiasing** during the stereotype creation. Train the model to predict careers while simultaneously making it impossible to predict a protected attribute (e.g., gender) from its internal representations. This encourages the model to learn features uncorrelated with bias. [2 marks]
- **Procedural Strategy**: **Implement a "Bias Audit" and "Override Explanation" Requirement**. Regularly audit the system's outputs across demographic groups. Furthermore, if the system recommends against a career a student has explicitly expressed interest in (e.g., teaching), it must **provide a clear, scrutable explanation** based on the stereotype's logic ("We suggested this because of your high Maths grade"), allowing the student to understand and contest the biased recommendation. [2 marks]

**(c) Perpetuation of Bias via CF:**
The initial stereotype influences the **early interactions** of the affected student. A student steered towards tech articles in the app will generate an **interaction history** skewed towards tech. [1 mark]
The **CF algorithm** then finds neighbours based on this skewed history—these neighbours will likely be other students who were also initially classified as "TECH_INCLINED" or who genuinely prefer tech. [1 mark]
The resulting CF recommendations will be a **tech-heavy echo chamber**, amplifying the initial steering effect. The bias is **baked into the interaction data**, which CF then uses as its "ground truth," creating a **feedback loop of bias**. [1 mark]

---
## Topic: Layered Evaluation & Usability Threats
### Question 3: The "FitBot" Conversational Coaching Agent
FitBot is an LLM-powered chatbot that provides real-time form correction during workouts via a user's camera. It uses computer vision to analyse posture, infers incorrect form (User Model), and generates corrective verbal instructions (Adaptation).

**(a) During a **Layer 2 (Interpretation)** evaluation, evaluators find FitBot often misinterprets a user taking a short rest between sets as "exercise abandonment." Propose a **specific refinement** to the interpretation logic and an **evaluation method** to validate the refinement.**
[4 marks]

**(b) One major **usability threat** for FitBot is **Obtrusiveness**. Describe two distinct design choices that could make FitBot obtrusive in this context. For each, suggest an **alternative design choice** to mitigate it.**
[6 marks]

**(c) A summative **A/B test** compares FitBot (Group B) to a pre-recorded video guide (Group A). The primary metric is "correct form adherence." After 4 weeks, Group B shows better adherence but also a **30% higher dropout rate**. Which **usability threat** does the higher dropout rate likely indicate? Propose a **hypothesis** for why this threat manifested more in Group B.**
[4 marks]

---
#### Model Answer 3
**(a) Refinement & Evaluation:**
- **Refinement**: Implement **state-based interpretation**. Integrate a simple **workout state machine** (e.g., "preparing," "set_active," "resting," "completed"). The "resting" state should have a **duration threshold** (e.g., 2 minutes). Only if the user is stationary beyond this threshold during an "active" workout should it be interpreted as "abandonment." [2 marks]
- **Evaluation Method**: **Video-Cued Retrospective Think-Aloud**. Record users' workouts. Later, show them video clips where the system applied the old and new logic. Ask: "Here you stopped. Were you resting between sets, or were you stopping the workout?" Compare the system's interpretation under the new logic to the user's stated intent to calculate **validity metrics**. [2 marks]

**(b) Obtrusiveness & Mitigation:**
1.  **Obtrusive Choice**: **Continuous, Unsolicited Verbal Feedback**. The chatbot narrates every minor imperfection: "Knee slightly inward. Back not straight. Elbow drop detected."
    **Mitigation**: **Threshold-Based & Summarised Feedback**. Only provide verbal corrections when form deviation exceeds a safety threshold. Provide a single, multi-part correction at the end of a set ("Next set, focus on knee alignment and elbow height"), not during the movement. [3 marks]
2.  **Obtrusive Choice**: **Interrupting Music/Media**. The chatbot's voice interrupts the user's workout playlist.
    **Mitigation**: **Non-Verbal, Ambient Feedback**. Use **short, distinctive non-verbal sounds** (e.g., a specific chime for "knee," a buzz for "back") paired with a **minimal visual icon** on-screen. This allows correction without breaking the user's auditory flow. [3 marks]

**(c) Dropout Rate Analysis:**
- **Indicated Usability Threat**: **Diminished Controllability** and **Frustration due to Rigidity**. [1 mark]
- **Hypothesis**: The pre-recorded video (Group A) is a **passive, predictable resource** the user controls. FitBot (Group B) is an **active, autonomous critic**. Users may feel **constantly monitored and judged** by the AI, leading to **performance anxiety** or annoyance at its imperfections (e.g., incorrect corrections). This loss of control and negative emotional response increases **frustration**, leading to higher dropout, despite better short-term form adherence. The AI's adaptiveness, in this case, created a **coercive rather than supportive** experience. [3 marks]

---
## Topic: Transparency & Privacy by Design
### Question 4: The "BudgetGuard" Financial Wellness App
BudgetGuard connects to users' bank accounts, analyses transactions, categorises spending, and provides personalised saving tips. It uses complex clustering to identify "spending personas."

**(a) Using the **Transparency Checklist**, design **two features**: one addressing **BP3 (Processing Transparency)** and one addressing **BP9 (Participatory Control)**. Be specific to BudgetGuard's context.**
[6 marks]

**(b) A user is concerned about **inferential privacy**. Explain what inferential privacy means in the context of BudgetGuard. What **sensitive inference** could the system make from seemingly neutral transaction data?**
[3 marks]

**(c) BudgetGuard uses **differential privacy** when aggregating user data to benchmark spending habits. In simple terms, what is the core guarantee differential privacy provides to the individual user? What is the inevitable **trade-off** for providing this guarantee?**
[4 marks]

---
#### Model Answer 4
**(a) Transparency Features:**
- **Feature for BP3 (Processing)**: **"How This Tip Was Generated" Drill-Down**. Next to a tip like "You spend 40% more on dining than similar users," an "Explain" link reveals: "This is based on: 1) Your 'Restaurant' transactions totalling £300, 2) Your assigned 'Urban Foodie' spending persona, 3) The average dining spend for your persona is £214." This explains the **factors, criteria, and reasoning** behind the specific output. [3 marks]
- **Feature for BP9 (Control)**: **"Persona Editor & Influence Sliders"**. In settings, users can view their inferred "Urban Foodie" persona profile. They can: 1) **Edit/Remove categorisations** ("That wasn't a restaurant, it was a supermarket"), and 2) Adjust **sliders** for "How much should persona benchmarks influence my tips?" and "How much should my transaction history influence my persona?" This gives **direct, participatory control** over the key modelling components. [3 marks]

**(b) Inferential Privacy:**
- **Definition**: The risk that sensitive personal information, **not directly provided**, can be **inferred** from other, less sensitive data the user has consented to share. [1 mark]
- **Sensitive Inference Example**: From a pattern of transactions at a **specific pharmacy** (location, time, frequency) combined with occasional purchases of soft foods, the system could **infer a user's medical condition** (e.g., undergoing chemotherapy) or pregnancy. This is a profound privacy violation far beyond the intent of sharing financial data for budgeting. [2 marks]

**(c) Differential Privacy:**
- **Core Guarantee**: It ensures that the **inclusion or exclusion of any single individual's data** from the dataset has a **negligible statistical effect** on the output of any analysis. In practice, it means a user can look at the aggregated benchmark (e.g., "Urban Foodies spend £214 on dining") and know that their specific data **cannot be reliably identified or extracted** from that published figure. [2 marks]
- **Trade-off**: **Utility vs. Privacy Loss Budget**. Adding the necessary **random noise** to achieve the guarantee **reduces the accuracy (utility)** of the aggregated data. The more privacy you demand (a smaller "privacy loss budget" ε), the noisier and less useful the benchmarks become. The system designer must tune this parameter: perfect privacy renders the data useless; perfect utility offers no formal privacy guarantee. [2 marks]

---
## Topic: Utility-Based & Knowledge-Based Recommenders
### Question 5: The "EcoHome" Smart Device Configurator
EcoHome helps users choose a suite of smart home products (thermostats, lights, solar) to maximise energy savings. It is a **utility-based recommender** where users manually set the importance (0-10) of attributes like "Upfront Cost," "Annual Savings," "Installation Complexity," and "Brand Trust."

**(a) Contrast the **user experience and required effort** of EcoHome's utility-based approach with that of a standard **Collaborative Filtering (CF)** system for the same task. List one pro and one con for the user in each case.**
[6 marks]

**(b) The team considers adding a **Knowledge-Based (KB) component** to assist users who don't know how to set the utility weights. Describe how a **critique-based interaction** in this hybrid system would work. Give a concrete example dialogue.**
[4 marks]

**(c) A pure utility-based system suffers from the **"tyranny of small decisions."** Explain what this means in EcoHome's context and how a **hybrid with a CF component** could alleviate it.**
[3 marks]

---
#### Model Answer 5
**(a) Comparison: Utility-Based vs. CF:**

| Aspect | Utility-Based (EcoHome) | Collaborative Filtering (CF) |
| :--- | :--- | :--- |
| **User Experience** | **High Control, Transparent, Deliberative**. User actively defines their value function. | **Low Effort, Serendipitous, Opaque**. User just sees what "people like them" bought. |
| **Pro for User** | **Complete Transparency & Trust**. User understands exactly why product X is top-ranked (e.g., "It scores highest on your weighted formula"). | **No Configuration Effort**. The system works from implicit data (clicks, purchases); the user doesn't need to be an expert to articulate trade-offs. |
| **Con for User** | **High Cognitive Load & Knowledge Requirement**. User must know and accurately quantify their own preferences for abstract, technical attributes. | **Low Control & Potential Irrelevance**. Recommendations may be popular but ignore the user's specific constraints (e.g., recommending an expensive system when budget is the top concern). |

[3 marks for a clear, accurate row/column; 6 marks for a fully fleshed-out table]

**(b) Critique-Based KB Interaction:**
- **Process**: The system would first generate an initial recommendation using **default weights** or a simple rule. The user then **critiques** this proposal to steer the system. [1 mark]
- **Example Dialogue**:
    - **System**: "Based on average preferences, I suggest the 'GreenWave Thermostat Pro' (£250, saves £120/yr, complex install)."
    - **User**: **"That's too expensive."** (Critique: "Cheaper")
    - **System**: (Recomputes, prioritising cost) "Okay. The 'EcoBasic Thermostat' (£120, saves £80/yr, easy install) is a better match. However, your annual savings are lower."
    - **User**: **"I want higher savings, but keep it simple."** (Critique: "Higher savings" + "Simpler")
    - **System**: (Finds compromise) "The 'SmartSave Balance' (£180, saves £100/yr, medium install) balances your critiques." [3 marks]

**(c) "Tyranny of Small Decisions" & CF Hybrid:**
- **Meaning in Context**: It refers to users making **locally optimal but globally sub-optimal choices** when setting weights. A user might slightly favour "Brand Trust" over "Annual Savings," not realising this small preference leads the system to recommend a vastly inferior product overall, missing a much better trade-off available in the market. The user's **limited knowledge** of the product space leads to poor global outcomes. [2 marks]
- **How CF Hybrid Alleviates It**: A **Weighted Hybrid** combining utility score with a CF score (`Final_Score = w1*Utility + w2*CF_Score`) injects the **"wisdom of the crowd."** A product that is highly popular among users with *similar utility profiles* would get a boost. This can surface products the user's own utility function might undervalue, revealing those **globally better trade-offs** discovered by the collective experience of other buyers. [1 mark]
## Topic: Reinforcement Learning & Sequential Adaptation
### Question 1: "NewsFlow RL" Adaptive News Feed
NewsFlow uses a **Reinforcement Learning (RL)** agent to personalize its news feed. The agent selects articles (actions) to maximize long-term user engagement, measured as total reading time over a 30-day period.

**(a) Define the **State (s_t)**, **Action (a_t)**, and **Reward (r_t)** for NewsFlow's RL formulation. Your definitions must be specific to this news domain.**
[3 marks]

**(b) The RL agent must balance **exploration** (showing diverse articles to learn user preferences) and **exploitation** (showing articles it believes the user will like). Describe **one risk** if the agent explores too much, and **one risk** if it exploits too much, from the **user's perspective**.**
[4 marks]

**(c) How would you evaluate whether the RL agent's **exploration strategy is effective**? Describe a **specific metric** and the **methodology** for calculating it from the system's logs.**
[3 marks]

---
#### Model Answer 1
**(a) RL Formulation:**
- **State (s_t)**: A representation of the user's **current context and history**. This includes: the user's recent click history (last 10 article topics), time of day, day of week, current device (mobile/desktop), and a summary of the user's long-term interest vector (e.g., high in "politics", low in "sports"). [1 mark]
- **Action (a_t)**: The selection of a **specific article** from the candidate pool to present in the next slot in the user's feed. This is a discrete choice from thousands of possible articles. [1 mark]
- **Reward (r_t)**: The **immediate user engagement** resulting from presenting article *a_t*. A simple formulation: `r_t = log(seconds_read + 1)`. This gives a positive reward for any reading, with diminishing returns for very long reads, closely correlating with the long-term goal of total reading time. [1 mark]

**(b) Exploration vs. Exploitation Risks:**
- **Risk of Too Much Exploration**: **Poor Short-Term User Experience and Loss of Trust**. If the system constantly shows irrelevant or uninteresting articles (e.g., sports to a user who only reads politics) in the name of exploration, the user will perceive the feed as **low-quality and random**. This leads to frustration, reduced immediate engagement, and may cause the user to abandon the platform, defeating the long-term goal. [2 marks]
- **Risk of Too Much Exploitation**: **Accelerated Filter Bubble and User Boredom**. If the system only shows articles very similar to past clicks (e.g., only progressive politics to a left-leaning user), it creates an **extreme filter bubble**. The user misses important counter-perspectives or novel topics, leading to a **diminished breadth of experience**. Over time, the feed becomes predictable and boring, causing engagement to plateau or decline as the user seeks novelty elsewhere. [2 marks]

**(c) Evaluating Exploration Effectiveness:**
- **Metric**: **Discovery Rate** or **Novelty @ K**. This measures the proportion of recommended articles that are on topics the user has **not engaged with in a defined past period** (e.g., the last 7 days). [1 mark]
- **Methodology**:
    1.  From the logs, for each user, identify the set of **article topic tags** they clicked on in the previous 7 days (`Past_Topics`).
    2.  For a test period, collect the top-K articles recommended each day and extract their topic tags.
    3.  Calculate: `Discovery_Rate = (Number of recommended articles with at least one topic NOT in Past_Topics) / (Total number of recommendations)`.
    4.  Aggregate this rate across users and time. A well-tuned RL agent should maintain a **stable, positive Discovery Rate**, indicating it is successfully introducing novel content without collapsing into pure exploitation. [2 marks]

---
## Topic: Graph-Based Models & Semantic Reasoning
### Question 2: "ResearchHub" Academic Paper Recommender
ResearchHub uses a **graph-based knowledge model** where nodes represent papers, authors, and concepts, and edges represent relationships like "cites," "authored_by," and "is_about."

**(a) Explain **one key advantage** of this graph-based model over a standard **Content-Based Filtering (CBF)** model that uses TF-IDF vectors of paper abstracts. Use a specific example of a recommendation that the graph model could make but the CBF model would likely miss.**
[4 marks]

**(b) The system infers a user's interest in the concept "Graph Neural Networks (GNNs)" because they frequently read papers connected to that node. Describe **two distinct types of evidence** the system could use from the graph to **strengthen or weaken** this inference, beyond simple reading frequency.**
[4 marks]

**(c) A **privacy concern** arises because the graph can reveal a user's **nascent research interests** before they publish. Why is this a particular concern in an academic context? Suggest a **privacy-preserving technique** specific to graph-based learning that could mitigate this.**
[4 marks]

---
#### Model Answer 2
**(a) Advantage of Graph-Based Model:**
- **Key Advantage**: **Capability for Multi-Hop, Semantic Reasoning**. A CBF model based on TF-IDF can only find papers with **lexical similarity** in their abstracts. A graph model can traverse **chains of relationships** to find semantically related work that uses different terminology. [2 marks]
- **Example**: A user reads paper A on "attention mechanisms in transformers." A CBF model would recommend papers with the terms "attention" and "transformer." The **graph model** could traverse: Paper A `[is_about]` → "Self-Attention" `[subclass_of]` → "Graph Attention" `[is_about]` → Paper B on "Graph Attention Networks for Molecular Property Prediction." Paper B uses **different key terms** ("graph," "molecular") but is fundamentally related via the concept hierarchy. The graph model can make this **serendipitous, cross-disciplinary recommendation**; the CBF model cannot. [2 marks]

**(b) Evidence for Inference Strength:**
1.  **Temporal Proximity in Traversal Paths**: If the user reads paper X, and then shortly after reads paper Y, and the **shortest path** between X and Y in the graph goes through the "GNNs" node, this is strong evidence the user is actively connecting ideas via GNNs, strengthening the inference beyond independent reading events. [2 marks]
2.  **Diversity of Connection Types**: The inference is strengthened if the user interacts with papers connected to "GNNs" via **different relationship types** (e.g., one paper that *cites* a seminal GNN paper, another that *is_about* GNNs, a third *authored by* a GNN expert). This indicates a broad interest. Conversely, if all connections are of the same type (e.g., only reading papers from one author), the interest might be narrow or coincidental, weakening the general inference. [2 marks]

**(c) Privacy Concern & Mitigation:**
- **Concern in Academic Context**: In academia, **novel ideas are currency**. Revealing a user's nascent interest in a specific, niche intersection of fields (e.g., "GNNs for archaeology") could allow competitors or reviewers to **infer their unpublished research direction**, potentially leading to intellectual property theft, being "scooped," or biased peer review. This is a high-stakes **inferential privacy** leak. [2 marks]
- **Privacy-Preserving Technique**: **Graph-Based Federated Learning**. Instead of centralizing the detailed user-graph interaction data, the learning of user embeddings (vector representations of their interests within the graph) is performed **locally on the user's device**. Only **aggregated model updates** (not raw traversal paths) are sent to the server to improve the global graph model. This ensures that the precise sequence of nodes a user explores—which reveals their thought process—never leaves their device. [2 marks]

---
## Topic: Evaluation Metrics & Trade-offs
### Question 3: "StyleGen" AI Fashion Outfit Generator
StyleGen generates complete outfits. It is evaluated both **offline** (using historical "save" data) and **online** via A/B tests.

**(a) The offline evaluation uses **Normalized Discounted Cumulative Gain (NDCG)**. Explain why NDCG is more appropriate than **Precision@K** for evaluating StyleGen's ranked list of generated outfits.**
[3 marks]

**(b) The A/B test's primary metric is **"outfit save rate."** After two weeks, the test is inconclusive (no significant difference). The team suspects a **"novelty effect"** in the treatment group. What is the novelty effect, and how could it have masked the true performance in the **early days** of the test? Propose a change to the **test design** to account for this.**
[4 marks]

**(c) Beyond accuracy and engagement, the team wants to evaluate **diversity**. Propose a **computable diversity metric** for StyleGen's outputs and describe **one challenge** in interpreting this metric.**
[3 marks]

---
#### Model Answer 3
**(a) NDCG vs. Precision@K:**
NDCG is more appropriate because it is a **rank-aware metric** that rewards putting the most relevant items at the top of the list. [1 mark]
- **Precision@K** treats all items in the top-K equally. If StyleGen's best outfit is ranked 3rd and its worst is ranked 1st, Precision@5 would still be 1/5=0.2 (if only one is saved), failing to capture this mis-ranking. [1 mark]
- **NDCG** assigns higher weight (gain) to higher ranks. A saved outfit at position 1 contributes more to the score than a saved outfit at position 5. This correctly penalizes StyleGen for **burying good recommendations** and aligns with the user experience of scanning a list from the top. [1 mark]

**(b) Novelty Effect & Test Design:**
- **Novelty Effect**: The tendency for users to interact with a new feature simply because it is **new and different**, not because it is inherently better. This inflates engagement metrics temporarily. [1 mark]
- **Masking True Performance**: In the first few days, users in the treatment group (seeing the new StyleGen outfits) might **save more outfits out of curiosity**, making the treatment appear better. This initial spike then decays as the novelty wears off, potentially to a level equal to or below the control. If the 2-week average is calculated, this early inflated period and later decay might average out to "no significant difference," hiding a possible **short-term gain or long-term loss**. [1 mark]
- **Improved Test Design**: Implement an **"Elimination Period"** or analyze metrics with **time-series segmentation**. Discard the data from the first 3-5 days of the test to allow the novelty effect to dissipate, and then compare the groups only on the subsequent "steady-state" data. Alternatively, analyze the metric **day-by-day** to observe the trend and see if the treatment effect stabilizes. [2 marks]

**(c) Diversity Metric & Challenge:**
- **Proposed Metric**: **Pairwise Attribute Dissimilarity (Intra-List Diversity)**. For a user's generated set of N outfits, for each outfit, extract a feature vector (e.g., one-hot encoded: `[color:black, style:formal, item:dress,...]`). Compute the average **cosine distance** (1 - cosine similarity) between all unique pairs of outfit vectors in the set. A higher average indicates more diverse outfits. [2 marks]
- **Challenge in Interpretation**: **Correlation with Relevance**. Maximizing this metric alone could lead to **bizarre, incoherent outfits** (e.g., a ball gown, then swimwear, then a business suit) that are diverse but useless. The metric must be interpreted **in conjunction with relevance/accuracy metrics**. A good system achieves **high diversity within a space of relevant items**. Disentangling whether low diversity is due to a narrow user profile or a failure of the system is difficult. [1 mark]

---
## Topic: Adaptive Presentation & Fragments
### Question 4: "LangBot" Adaptive Language Learning Chat Interface
LangBot teaches Spanish via a chat interface. It uses a **fragment-based approach** to construct its messages. Fragments include grammar explanations, vocabulary hints, cultural notes, and encouragement. Its rules are complex, considering the user's current lesson, error rate, and time of day.

**(a) The current system uses **Optional Fragments**. Describe a scenario where this could lead to a **confusing or overwhelming message** for the learner. Your answer must include specific fragments and their conditions.**
[3 marks]

**(b) To solve this, the team switches to an **Altering Fragments** approach with four slots: `Greeting`, `Core_Content`, `Feedback`, `Closing`. For the `Feedback` slot, design **two alternative fragments** and the **user model condition** that would trigger each one.**
[3 marks]

**(c) The team now wants to **dynamically generate** the `Core_Content` using an LLM, prompting it with the user's learning history. This shifts from a fragment-based to an **automatic generation** approach. State **one major advantage** and **one major risk** of this shift in the context of language learning.**
[4 marks]

---
#### Model Answer 4
**(a) Problem with Optional Fragments:**
- **Scenario**: A user is struggling with the past tense (`error_rate_this_session > 70%`). It is also their 5th consecutive day using the app (`streak_days >= 5`), and the current lesson touches on Mexican culture (`lesson_topic == "food"`). [1 mark]
- **Applicable Fragments**:
    - F1 (Grammar Tip): Condition `error_rate > 50%` -> "Remember, for regular -ar verbs in the past..."
    - F2 (Encouragement): Condition `streak_days >= 3` -> "Great dedication on your 5-day streak!"
    - F3 (Cultural Note): Condition `lesson_topic == "food"` -> "In Mexico, 'tacos al pastor' have a fascinating history..."
    - F4 (Vocabulary Hint): Condition `new_vocab_count > 5` -> "The word 'sabor' (flavor) is related to 'sabroso' (tasty)." [1 mark]
- **Resulting Confusing Message**: The bot sends all four fragments in one block:
    *"Remember, for regular -ar verbs in the past... Great dedication on your 5-day streak! In Mexico, 'tacos al pastor' have a fascinating history... The word 'sabor' (flavor) is related to 'sabroso' (tasty)."*
    This is **informationally overloaded and thematically jumbled**, mixing grammar, encouragement, culture, and vocabulary without a coherent narrative, likely overwhelming the learner. [1 mark]

**(b) Altering Fragments for Feedback Slot:**
- **Slot**: `Feedback`
    1.  **Fragment F_Feedback_Corrective**: "Let's review that. The correct form is 'hablé' (I spoke). The ending for 'yo' is '-é'. Try the next one!"
        **Condition**: `last_response_correct == FALSE`
    2.  **Fragment F_Feedback_Reinforcing**: "¡Excelente! You used 'comí' (I ate) perfectly. That's the correct irregular form."
        **Condition**: `last_response_correct == TRUE AND response_used_irregular_verb == TRUE`
[3 marks - 1 for each fragment, 1 for appropriate conditions]

**(c) Shift to LLM Generation:**
- **Major Advantage**: **Unprecedented Adaptability and Conversational Fluidity**. An LLM can generate `Core_Content` that seamlessly incorporates the user's past errors, stated interests, and current context into a **single, coherent, and naturally flowing response**. For example: "Ah, you mixed up 'ser' and 'estar' again, like you did last Tuesday when describing your mood. Let's tackle this with a quick story about your favorite footballer, Messi, being from Argentina..." This level of **personalized, contextual weaving** is impossible with pre-authored fragments. [2 marks]
- **Major Risk**: **Loss of Pedagogical Control and Hallucination**. The LLM might generate explanations that are **linguistically incorrect**, pedagogically unsound (teaching a complex rule too early), or culturally inappropriate. It could **"hallucinate"** false grammar rules or vocabulary. In language learning, where accuracy is paramount, this could **actively teach the user incorrect Spanish**, causing significant harm that is hard to correct later. Ensuring the LLM's outputs are **grounded in a verified knowledge base** is critical and challenging. [2 marks]

---
## Topic: Cold-Start & Hybrid Solutions
### Question 5: "ArtFolio" Personalized Digital Art Gallery
ArtFolio recommends digital artworks (NFTs and traditional digital art) to new users. It faces severe **cold-start problems**: new users (user cold-start) and new artworks added daily (item cold-start).

**(a) Propose a **hybrid recommendation strategy** specifically designed to address **both cold-start problems simultaneously**. Name the techniques combined and the **hybridisation method**, and explain the role of each technique.**
[5 marks]

**(b) For the **item cold-start** component of your hybrid, the system uses **visual feature vectors** (extracted via a CNN) of the artwork images. Why is this a **Content-Based (CBF)** approach? What is a **key limitation** of using only these visual features for art recommendation?**
[3 marks]

**(c) After 10 user interactions, the system switches to a different hybrid method. What **usability threat** could this sudden switch pose, and how would you mitigate it in the UI?**
[2 marks]

---
#### Model Answer 5
**(a) Hybrid Strategy for Dual Cold-Start:**
- **Techniques**: **Knowledge-Based (KB) + Content-Based Filtering (CBF)**. [1 mark]
- **Hybridisation Method**: **Mixed Hybrid** (or **Weighted** with very high initial weight on KB). [1 mark]
- **Role of Each Technique**:
    1.  **KB System (Addresses User Cold-Start)**: On first login, engages the user in a **dialogue** ("What art styles do you like? Abstract or figurative? What's your favorite color palette? What's your budget?"). Uses these explicit constraints to filter the entire catalogue. This provides immediate, relevant recommendations without any history. [1.5 marks]
    2.  **CBF System (Addresses Item Cold-Start)**: For every artwork, including brand new ones, a **visual feature vector** is pre-computed. The system can recommend new artworks whose visual features are similar to those the user has liked (from KB choices or early clicks). This ensures new items can be recommended from day one. [1.5 marks]

**(b) Visual Features as CBF & Limitation:**
- **Why it's CBF**: The visual feature vector (e.g., a 512-dim vector encoding style, color, texture, composition) acts as the **item's "content" or metadata**. The system recommends art by finding items with **similar feature vectors** to those the user has shown interest in. This is the hallmark of CBF: recommendation via **item attribute similarity**. [1.5 marks]
- **Key Limitation**: **Misses Conceptual, Narrative, and Contextual Meaning**. Art appreciation often hinges on **concept, story, cultural context, or artist's intent**, which are not captured by low-level visual features. A CBF system might recommend two visually similar abstract paintings, missing that one is about joy and the other about despair, or that one is by a famous political artist. It reduces art to its **visual form, ignoring its function and meaning**, leading to shallow recommendations. [1.5 marks]

**(c) Usability Threat of Sudden Switch:**
- **Threat**: **Diminished Predictability**. The user has grown accustomed to the initial recommendation logic (e.g., based on their stated preferences). A sudden, unannounced switch to a different algorithm (e.g., to collaborative filtering) can make the recommendations feel **unpredictable and confusing**, breaking the user's mental model of how the system works. [1 mark]
- **UI Mitigation**: **Introduce a Transparent Transition**. When the switch is triggered, display a **non-obtrusive, educational tooltip**: "Now that we've learned a bit about your tastes, we're also starting to suggest artworks loved by people with similar interests." This manages user expectations and maintains a sense of predictability by explaining the change in logic. [1 mark]

 # Additional Exam Practice Questions & Model Answers
## Topic: Multi-Armed Bandits & Exploration Strategies
### Question 1: "AdOpt" Adaptive Advertising Platform
AdOpt uses a **multi-armed bandit algorithm** to select which ad creative to show users in real-time. Each "arm" is a different ad variant (e.g., humorous, serious, discount-focused). The goal is to maximize click-through rate (CTR).

**(a) Compare and contrast the **ε-greedy** and **Upper Confidence Bound (UCB)** exploration strategies for this application. For each, state one practical advantage and one disadvantage in the context of ad delivery.**
[6 marks]

**(b) The system initially uses a **context-free bandit** (ignores user traits). They upgrade to a **contextual bandit** that considers user demographics. Explain, with a concrete example, how this change could improve both **short-term CTR** and **long-term user experience**.**
[4 marks]

**(c) Describe an ethical concern related to **autonomous optimization** in this advertising context. Which EU AI Ethics Requirement does this most directly violate, and why?**
[3 marks]

---
#### Model Answer 1
**(a) ε-greedy vs. UCB:**
**ε-greedy Strategy**:
- **Mechanism**: With probability ε (e.g., 5%), select a random ad (exploration). With probability 1-ε, select the ad with the highest historical CTR (exploitation).
- **Advantage**: **Simple to implement and understand**. The ε parameter provides direct, intuitive control over the exploration/exploitation trade-off.
- **Disadvantage**: **Inefficient Exploration**. When exploring, it chooses randomly from all ads, including clearly poor performers. This wastes impressions that could be used for more **directed exploration** of promising alternatives. [3 marks]

**Upper Confidence Bound (UCB) Strategy**:
- **Mechanism**: Always selects the ad with the highest **upper bound of the confidence interval** for its CTR. Ads with high uncertainty (few views) get artificially inflated scores, encouraging their selection.
- **Advantage**: **Optimal Balance of Exploration/Exploitation**. It automatically and efficiently reduces uncertainty by targeting exploration towards ads with potential (high variance), leading to **faster convergence** on the best ad.
- **Disadvantage**: **More Complex and Computationally Intensive**. Requires maintaining and updating confidence intervals for every ad. Can be sensitive to initial conditions and may perform poorly with non-stationary environments (if user preferences shift). [3 marks]

**(b) Contextual Bandit Improvement:**
- **Improvement Explanation**: A context-free bandit finds the single "best ad for everyone." A contextual bandit learns **which ad is best for which user segment**. [1 mark]
- **Example**: The context-free bandit might find the "humorous ad" has the highest overall CTR. It shows this to everyone. [1 mark]
- A contextual bandit could learn:
    - For `user_age < 25`: "Discount-focused ad" has highest CTR.
    - For `user_age > 50`: "Serious, feature-based ad" has highest CTR.
- **Short-Term CTR**: Increases because ads are better matched to segments. [1 mark]
- **Long-Term UX**: Reduces **ad fatigue and annoyance** because users see ads more relevant to their likely interests, making the advertising experience less intrusive. [1 mark]

**(c) Ethical Concern & EU Requirement:**
- **Ethical Concern**: **Manipulative Optimization and Exploitation of Vulnerabilities**. The autonomous system could learn to target specific user segments with ads that exploit psychological biases or vulnerable states (e.g., targeting gambling ads to users showing patterns of addictive behavior, or high-interest loan ads to users researching financial distress). [1.5 marks]
- **EU Requirement**: **R1: Human Agency and Oversight** and **R5: Diversity, Non-discrimination and Fairness**.
- **Justification**: This violates **R1** because the system autonomously makes decisions that can undermine user autonomy and lead to harmful financial or psychological consequences. It violates **R5** because it can lead to **discriminatory outcomes**, systematically targeting vulnerable groups with predatory content. The system prioritizes click probability over user wellbeing, lacking meaningful human oversight. [1.5 marks]

---
## Topic: Sequential Decision Making & State Representation
### Question 2: "StudyMate" Adaptive Study Scheduler
StudyMate creates personalized study plans for exams. It models the student's **knowledge state** across topics and decides which topic to study next, for how long, and with what activity (e.g., read, quiz, video).

**(a) This is a **sequential decision-making problem**. Propose a **state representation** for the system that balances richness with computational feasibility. Your representation should include at least three distinct types of information.**
[4 marks]

**(b) The system could use a **rule-based planner** or a **Reinforcement Learning (RL) agent** to make decisions. Compare these two approaches in terms of **transparency**, **ability to handle complexity**, and **adaptation speed**.**
[6 marks]

**(c) A key challenge is **student compliance**. If the system plans a 2-hour study session but the student only completes 30 minutes, how should the **user model** be updated? Describe **two different update strategies** and the rationale for each.**
[4 marks]

---
#### Model Answer 2
**(a) State Representation:**
An effective state `s_t` could be a tuple containing:
1.  **Knowledge Vector**: A vector of estimated mastery levels (0-1) for each topic in the syllabus (e.g., `{Topic_A: 0.8, Topic_B: 0.3, Topic_C: 0.6}`). This is the core **overlay model**.
2.  **Student Context**: Time of day, day until exam, historical study duration preference (e.g., `prefers_short_sessions: True`), and current self-reported energy level (if available). This captures **context**.
3.  **Recent History**: The last 2-3 study actions taken (topic, activity, duration) and their outcomes (e.g., quiz score). This provides a **short-term memory** to avoid repetition and capture immediate effects.
This representation is rich enough to inform good decisions but remains a fixed-size vector, making it feasible for rule-based or RL algorithms. [4 marks]

**(b) Rule-Based vs. RL Comparison:**

| Criterion | Rule-Based Planner | Reinforcement Learning (RL) Agent |
| :--- | :--- | :--- |
| **Transparency** | **High**. Decisions are made by explicit, human-readable rules (e.g., "IF topic_mastery < 0.5 THEN schedule quiz"). Easy to explain and debug. | **Very Low (Black Box)**. Decisions come from a complex value function or policy network. It's often impossible to articulate *why* a specific topic was chosen. |
| **Ability to Handle Complexity** | **Low**. Rules become unmanageably complex for multi-dimensional states and long-term dependencies. Capturing nuances like "topic B is best studied after A but before C" is hard. | **High**. RL agents, especially with deep learning, can learn **complex, non-linear policies** from high-dimensional state representations, capturing subtle patterns humans might not encode in rules. |
| **Adaptation Speed** | **Slow**. Requires manual analysis and reprogramming by experts to adapt to new patterns or student feedback. | **Fast (in theory)**. Can adapt **online** as it interacts with more students, continuously improving its policy. However, initial learning requires much data. |

[6 marks - 2 marks per row with clear, accurate comparison]

**(c) User Model Update Strategies:**
1.  **Strategy 1: Downgrade Mastery & Adjust Engagement Model**.
    - **Update**: Decrease the mastery estimate for the studied topic slightly (e.g., by 0.1) because the planned deep study didn't occur. Simultaneously, update a **compliance/engagement model** to reflect a higher likelihood of shorter sessions.
    - **Rationale**: Treats non-compliance as **negative evidence** about both knowledge (incomplete study) and user behavior. Makes future plans more conservative. [2 marks]
2.  **Strategy 2: Treat as Partial Evidence & Re-plan**.
    - **Update**: Treat the 30 minutes as **partial positive evidence**, increasing mastery for the topic but by a smaller amount than a full session. Do not penalize the student. Instead, **trigger an immediate re-planning** for the remaining time based on the new, partially updated state.
    - **Rationale**: More **positive and supportive**. Acknowledges the effort made. Focuses on agile adaptation rather than modeling "failure," which may be better for maintaining motivation. [2 marks]

---
## Topic: Critique-Based Interaction & Preference Elicitation
### Question 3: "HomeStyle" Interior Design Configurator
HomeStyle helps users choose furniture sets. It uses a **critique-based, knowledge-driven** interface. Users start with a baseline design and provide critiques like "more modern," "cheaper," or "lighter colors."

**(a) Explain the difference between a **compound critique** and a **unit critique**. Give an example of each in the HomeStyle context.**
[4 marks]

**(b) A naive implementation might treat "cheaper" as a simple filter on price. Why is this **oversimplified**? Describe a more sophisticated way the system's **knowledge base** should handle the "cheaper" critique.**
[3 marks]

**(c) After several critique cycles, the system's suggestions seem to converge, but the user is still not satisfied. This may indicate a **"human-in-the-loop"** problem. Describe this problem and suggest a **system feature** to overcome it.**
[3 marks]

---
#### Model Answer 3
**(a) Critique Types:**
- **Unit Critique**: A critique on a **single, specific attribute** of the current suggestion.
    - *Example*: The user sees a grey sofa and says "**Darker grey**." This critiques only the `color` attribute. [2 marks]
- **Compound Critique**: A critique that implicitly involves **changes to multiple attributes** simultaneously to satisfy a higher-level goal.
    - *Example*: The user sees an ornate, dark wood dining set and says "**More Scandinavian**." This implies multiple changes: `style: ornate → minimalist`, `color: dark → light`, `material: heavy wood → light wood/plywood`. The system must understand this **multi-faceted mapping** in its knowledge base. [2 marks]

**(b) Handling "Cheaper" Sophisticatedly:**
- **Oversimplification**: A simple price filter may eliminate *all* alternatives, or only show drastically inferior quality items, frustrating the user. "Cheaper" is often a **trade-off request**, not a hard constraint. [1.5 marks]
- **Sophisticated Handling**: The knowledge base should treat "cheaper" as a **preference shift on a utility function**. It should:
    1.  Identify **substitutable items** that offer similar style/function at lower cost (e.g., laminate instead of solid wood).
    2.  Suggest **configurational changes** (e.g., a smaller rug, fewer accent chairs) that lower total cost while preserving the design's core.
    3.  Present a **choice of compromises**: "To make it cheaper, we can: A) Use a synthetic fabric (saves £200), B) Choose a smaller size (saves £150), or C) Remove the matching footstool (saves £100)." This respects the user's intent while leveraging domain knowledge. [1.5 marks]

**(c) Human-in-the-Loop Problem & Solution:**
- **The Problem**: The user may lack the **vocabulary or visual literacy** to articulate what they want through critiques. They know they don't like the suggestions but can't specify why ("I'll know it when I see it"). The system is trapped in a local optimum of the **user's expressible preferences**, not their true preferences. [1.5 marks]
- **System Feature to Overcome It**: **Diverse Example-Based Exploration**. Introduce a "**Show me different directions**" button. When clicked, the system generates **three radically different designs** that are all *somewhat* consistent with past critiques but explore different regions of the design space (e.g., one bold, one neutral, one rustic). The user can then **select a direction** ("I like something about option 2") or provide a new, more informed critique based on these examples ("I like the bold colors from option 1 but the clean lines from option 2"). This breaks the cycle by giving the user new reference points. [1.5 marks]

---
## Topic: Utility Theory & Multi-Criteria Decision Making
### Question 4: "CitySelect" Relocation Recommendation Engine
CitySelect helps users choose a city to relocate to. Users specify the **importance** (weight) of criteria like Job Market (J), Cost of Living (C), Culture (Cu), and Safety (S). The system scores each city on these criteria and computes a **weighted utility score**.

**(a) A user sets weights: J=10, C=8, Cu=5, S=9. City X has scores: J=0.7, C=0.9, Cu=0.4, S=0.8. Calculate the **weighted utility score** for City X. Show your working.**
[2 marks]

**(b) The system uses **Multi-Attribute Utility Theory (MAUT)**. Describe **two fundamental assumptions** of MAUT that often break down in real-world decision-making like city selection.**
[4 marks]

**(c) To improve recommendations, the system introduces **non-compensatory filters**. What does "non-compensatory" mean in this context? Give an example filter and explain how it changes the recommendation logic from pure weighted utility.**
[4 marks]

---
#### Model Answer 4
**(a) Weighted Utility Calculation:**
1.  Normalize weights (optional but good practice): Total weight = 10+8+5+9 = 32. Normalized weights: J=10/32≈0.3125, C=8/32=0.25, Cu=5/32≈0.15625, S=9/32≈0.28125.
2.  **Weighted Utility Score** = Σ (weight_i * score_i).
    Using raw weights: `Score_X = (10*0.7) + (8*0.9) + (5*0.4) + (9*0.8) = 7 + 7.2 + 2 + 7.2 = **23.4**`
    Using normalized weights: `Score_X ≈ (0.3125*0.7)+(0.25*0.9)+(0.15625*0.4)+(0.28125*0.8) = 0.21875 + 0.225 + 0.0625 + 0.225 = **0.73125**` (on a 0-1 scale).
    **Both methods are acceptable if consistent.** [2 marks]

**(b) MAUT Assumptions & Breakdowns:**
1.  **Assumption of Preference Independence**. MAUT assumes your preference for the level of one criterion (e.g., Job Market) is **independent** of the level of another (e.g., Cost of Living). This breaks down because preferences are often **interactive**. For example, a user might value a "vibrant Culture" **more** if "Job Market" is also high (they'll have money to enjoy it), but value it **less** if jobs are poor (making culture irrelevant). MAUT cannot model these interactions. [2 marks]
2.  **Assumption of Full Comparability & Linear Trade-offs**. MAUT assumes all trade-offs can be captured by constant weights, implying a **linear relationship**. For example, it assumes the trade-off between Safety and Cost is constant: you'd always give up the same amount of safety for a unit decrease in cost. In reality, this is **non-linear**. A user might accept a slightly less safe city for major savings, but would **never** consider a city below a "catastrophic" safety threshold, regardless of cost. This is a **threshold effect** MAUT misses. [2 marks]

**(c) Non-Compensatory Filters:**
- **Meaning**: A **non-compensatory filter** is a **hard constraint** or **elimination condition**. If a candidate fails on this criterion, no amount of excellence on other criteria can compensate for it. The candidate is **rejected outright**. This contrasts with the **compensatory** nature of weighted utility, where a low score on one criterion can be offset by high scores on others. [2 marks]
- **Example Filter**: `Safety Score >= 0.7` (on a 0-1 scale). [1 mark]
- **Change in Logic**: With this filter, the system **first removes all cities** with a safety score < 0.7 from consideration. **Only then** does it compute the weighted utility score for the remaining cities and ranks them. A city with a perfect 1.0 on Job, Cost, and Culture but a 0.69 on Safety would be **eliminated before scoring**, whereas in pure weighted utility it might have been the top recommendation. This reflects a more realistic, **satisficing** decision model. [1 mark]

---
## Topic: Social Recommenders & Trust Networks
### Question 5: "BookWeb" Social Reading Platform
BookWeb combines **social network data** with reading history. Users follow others, see what they're reading, and get recommendations based on friends' ratings (**social filtering**) and global patterns (**collaborative filtering**).

**(a) Define **social filtering**. How does it differ fundamentally from standard **user-user collaborative filtering (CF)** in terms of the data used and the underlying assumption?**
[4 marks]

**(b) A user's feed shows: "Your friend **Alex** rated 'Project Hail Mary' 5 stars." This is a **social explanation**. Describe **two distinct benefits** this type of explanation provides over a generic "Recommended for you" label.**
[3 marks]

**(c) A **privacy threat** emerges from **social inference**. Describe how a malicious user could exploit the social recommendation system to infer a private fact about another user (e.g., their political leaning or health condition).**
[3 marks]

---
#### Model Answer 5
**(a) Social Filtering vs. User-User CF:**
- **Social Filtering**: Recommends items liked or consumed by people in the user's **explicit social network** (friends, follows). The core data is the **social graph** (who follows whom) combined with item interactions. The underlying assumption is that **social ties imply trust and similarity of taste**. "I trust my friend's judgment." [2 marks]
- **User-User Collaborative Filtering**: Recommends items liked by users who are **algorithmically similar** based on their entire interaction history, regardless of any social connection. The core data is the **user-item interaction matrix**. The underlying assumption is that **similarity in past behavior predicts similarity in future preferences**. "People who rated the same books as me have similar tastes." [2 marks]
- **Fundamental Difference**: Social filtering uses **explicit, declared relationships** (social graph). User-user CF uses **inferred, behavioral similarity** (interaction matrix). One is based on **trust/affiliation**, the other on **statistical correlation**.

**(b) Benefits of Social Explanations:**
1.  **Increased Trust and Perceived Credibility**. A recommendation from a known friend ("Alex liked this") carries more weight and feels more trustworthy than an anonymous algorithmic suggestion. The user has a **pre-existing positive association** with the source. [1.5 marks]
2.  **Fosters Social Engagement and Shared Experience**. It transforms recommendation from a solitary act into a **social activity**. It can spark conversations ("Why did Alex love this?"), create a sense of community, and give the user a reason to engage with both the content and their friend on the platform. [1.5 marks]

**(c) Privacy Threat - Social Inference Attack:**
- **Attack Method**: A malicious user (M) can carefully **curate their own profile** and **observe social recommendations** to make inferences.
- **Concrete Example to Infer Health Condition**:
    1.  M wants to know if target user T has depression.
    2.  M **friends/follows** T on BookWeb.
    3.  M then **rates several books** known to be popular within support communities for depression (e.g., specific memoirs, self-help guides) with very high scores.
    4.  M monitors their own feed for social recommendations of the form "T also read [Book X]."
    5.  If books about depression start appearing in M's recommendations **with T as the social link**, M can infer T has been reading those books, strongly suggesting the health condition.
- **Mechanism**: The system, using **social filtering**, sees M and T are connected and that M has rated niche books highly. It recommends to M other books that their *social connections* (like T) have read. This **leaks T's reading history** through the recommendation engine itself. [3 marks]
# Last year's exam paper's
## 2023/4
### Question 1: Amazon Personalised Shopping
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
## 2024/5
### Question 1: MovieLens Recommendation System
#### Question 1(a)
**Suggest one possible recommender method that can be used to generate the recommendations shown in the image above. For the method you have suggested, describe and illustrate with examples: what background data will be used, what input data will be provided by the user, how the algorithm will work.**
[9 marks]
#### Model Answer with Detailed Explanation

> **Recommended Method**: **User-User Collaborative Filtering (CF)**.
> **Justification**: MovieLens is a classic research testbed for CF. The scenario describes new users rating a seed set of movies, which is a standard technique to bootstrap a **user profile vector** for finding similar users.

> **1. Background Data Used**:
> The system requires a **User-Item Rating Matrix**. This is a large, pre-existing database where each row represents a user, each column represents a movie, and each cell contains the **rating** (e.g., 1-5 stars) that user gave to that movie. This matrix is the core "wisdom of the crowd" that the algorithm mines for patterns. [3 marks]

> **2. Input Data Provided by the User**:
> The user provides **explicit ratings** for a **seed set of movies** presented during registration (e.g., "Rate 15 movies to get started"). This input creates an initial, sparse rating vector for the new user. For example, the user might rate *The Godfather*: 5 stars, *Toy Story*: 4 stars, *The Room*: 1 star. [3 marks]

> **3. How the Algorithm Works**:
> 1.  **Similarity Computation**: The system calculates the **similarity** (e.g., using **Pearson Correlation** or **Cosine Similarity**) between the new user's rating vector and every other user's vector in the background matrix. It finds the **k-nearest neighbours**—users with the most similar taste patterns.
> 2.  **Rating Prediction**: For a movie the new user hasn't seen (e.g., *Goodfellas*), the system looks at the ratings given to *Goodfellas* by the identified neighbours. It computes a **weighted average** of these neighbours' ratings, where weights are the similarity scores.
> 3.  **Recommendation Generation**: The algorithm repeats step 2 for all movies the user hasn't rated. It then ranks them by the **predicted rating** and recommends the top-N (e.g., top 20 shown in the image). [3 marks]

---
#### Question 1(b)
**Describe one strength and one limitation of the recommender method you have proposed in (a), considering the technical implementation of the algorithm. For both the strength and the limitation include justification why this would be a strength or a limitation, illustration with an example related to MovieLens.**
[6 marks]
#### Model Answer with Detailed Explanation

> **Strength: No Requirement for Content Analysis**.
> **Justification**: User-User CF operates purely on the **user-item interaction matrix**. It does not need any metadata about the movies (genre, actors, director). This makes it **simpler to implement** from a data engineering perspective, as it avoids the complex task of feature engineering and domain modelling.
> **MovieLens Example**: The algorithm can successfully connect users who love *2001: A Space Odyssey* (sci-fi) with users who love *There Will Be Blood* (drama) based on rating patterns alone, even if the movies share no obvious content features. It discovers **latent associations** that are not semantically obvious. [3 marks]

> **Limitation: User Cold-Start Problem and Data Sparsity**.
> **Justification**: The algorithm's core function relies on comparing users via their rating vectors. A **new user** has a very sparse vector (only 15 ratings), making similarity computations **unreliable and noisy**. Furthermore, the global rating matrix is typically extremely sparse (most users haven't seen most movies), which degrades the quality and coverage of neighbourhoods and predictions.
> **MovieLens Example**: A new user who rates only popular blockbusters may be incorrectly matched to a broad group of users, leading to generic recommendations. If they have a niche taste (e.g., only rates Polish arthouse films), they may find **no sufficiently similar neighbours** in the database, causing the algorithm to fail entirely for them. [3 marks]

---
#### Question 1(c)
**Assume that you have to evaluate the recommender method you proposed in (a) considering its accuracy. Suggest one accuracy metric that you can use. Describe how to define the accuracy metric and how to apply it in the context of MovieLens...**
[6 marks]
#### Model Answer with Detailed Explanation

> **Accuracy Metric**: **Root Mean Squared Error (RMSE)**.
>
> **1. Definition of Correct Recommendation & Comparison**:
> In this context, a "correct" prediction is one where the system's **predicted rating** for a movie is **close to the user's actual future rating**. To apply RMSE, you conduct an **offline evaluation**:
> - **Step 1**: Take MovieLens's historical dataset and hide a subset of known user-movie ratings (e.g., hide 20% of each user's ratings to form a **test set**).
> - **Step 2**: Train your User-User CF algorithm on the remaining 80% of data (the **training set**).
> - **Step 3**: Use the trained algorithm to **predict the ratings** for the hidden user-movie pairs in the test set.
> - **Step 4**: **Compare** each predicted rating ($\hat{r}_{ui}$) with the actual, hidden true rating ($r_{ui}$). RMSE is calculated as: $$RMSE = \sqrt{\frac{1}{N} \sum_{(u,i) \in Test} (\hat{r}_{ui} - r_{ui})^2}$$ where N is the number of ratings in the test set. [4 marks]

> **2. Why RMSE is Appropriate**:
> RMSE is the **standard metric for rating prediction tasks**. It is appropriate because:
> - It **penalises large errors heavily** (due to the squaring). A prediction that is off by 4 stars is treated as more than twice as bad as one off by 2 stars, which aligns with user experience.
> - It is **widely used and understood** in the recommender systems research community (including the Netflix Prize), making results comparable.
> - It directly measures the **core function** of the proposed CF algorithm: predicting a user's exact rating score. A lower RMSE indicates a more accurate algorithm. [2 marks]

---
#### Question 1(d)
**Describe two usability challenges that can apply to the recommender method you proposed in (a). For each challenge: state the challenge, give an illustration in the context of MovieLens, suggest a way to reduce the impact, justify why the suggested way will reduce the impact.**
[8 marks]
#### Model Answer with Detailed Explanation

> **Challenge 1: Diminished Transparency (The "Black Box" Problem)**.
> **Illustration**: A MovieLens user sees a recommendation for *Parasite*. They wonder, "Why is this recommended to me?" The User-User CF system can only provide a weak explanation like "Other users with similar tastes liked it." This is **unsatisfying and uninformative**, reducing trust and the user's ability to correct their profile if the recommendation is bad.
> **Mitigation Strategy**: Implement a **"Hybrid Explanation"** by complementing CF with a lightweight **Content-Based (CBF)** analysis.
> **Justification**: When explaining the *Parasite* recommendation, the system can now say: "Recommended because **users like you loved it**, and it shares **themes of social satire** with *The Great Dictator* which you rated highly." This combines the collaborative signal with **feature-based reasoning**, making the logic clearer and more actionable for the user. [4 marks]

> **Challenge 2: The Filter Bubble (Overspecialisation via Popularity Bias)**.
> **Illustration**: A user who rates several Marvel movies highly will be matched with neighbours who also like blockbusters. The CF system will then **continuously recommend more popular action/superhero movies**, creating a feedback loop. The user may never be exposed to brilliant dramas, documentaries, or foreign films they might love, **diminishing their breadth of experience**.
> **Mitigation Strategy**: Introduce **Serendipity Injections** into the ranking algorithm.
> **Justification**: Modify the final recommendation list by **demoting** some items that are extremely similar to the user's history and **promoting** items that are highly rated globally but have low predicted scores for this user. For example, occasionally slot in a critically acclaimed anime film. This **breaks the similarity loop** by explicitly balancing **accuracy** with **novelty**, directly countering the filter bubble effect. [4 marks]

---
#### Question 1(e)
**MovieLens uses an interest-based user model. Which of the applications listed below can use interest-based user models?**
[2 marks]
#### Model Answer
> **Correct Answers: A, B, C**.
> - **A (News apps)**: Model interests in topics (politics, sports).
> - **B (Online bookstores)**: Model interests in genres, authors.
> - **C (E-commerce)**: Model interests in product categories, brands.
> - **D (Location navigation)**: Uses **contextual** and **goal-based** models (current location, destination, traffic), not primarily interest-based. [2 marks for all correct]

---
#### Question 1(f)
**Concept-level models of user interests are generally more powerful than keyword-level models. Which of the statements from the list below can be used to justify the use of concept-level models to represent users’ interests?**
[2 marks]
#### Model Answer
> **Correct Answers: A, C**.
> - **A**: **True**. They capture semantic meaning, not just lexical matches.
> - **C**: **True**. They allow modelling hierarchical and relational detail (e.g., "science fiction" -> "cyberpunk" -> "Neuromancer").
> - **B**: **False**. They are **harder** to implement (require ontologies, taxonomies).
> - **D**: **False**. Acquisition is often **slower** (requires semantic analysis). [2 marks for all correct]

---
#### Question 1(g)
**Assume that MovieLens has to represent users’ familiarity with movie genres, for which a scalar user model can be used. Circle the letters corresponding to a statement that is true.**
[1 mark]
#### Model Answer
> **Correct Answers: A, C**.
> - **A**: **True**. This is the definition of a scalar model.
> - **C**: **True**. A single "familiarity" score is an average over all genre knowledge.
> - **B**: **False**. Scalar models have **low precision** (they are reductive).
> - **D**: **False**. Scalar models do **not** require a graph structure. [1 mark for all correct]

---
### Question 2: Personalised Healthy Living App
#### Question 2(a)
**Describe one implicit user information collection method which can be used in the personalised healthy living app to extract a user profile...**
[6 marks]
#### Model Answer with Detailed Explanation

> **Method**: **Passive Logging and Sensor-Based Activity Tracking**.
>
> **1. Information Collected**:
> The app collects: (i) **Physical Activity Logs**: Type, duration, and intensity of exercise (e.g., 30-min run, GPS route, heart rate via wearable). (ii) **Dietary Logs**: Food items logged via barcode scans or photos, along with timestamps. (iii) **App Interaction Logs**: Which motivational messages are dismissed/read, which recipe suggestions are clicked. [2 marks]

> **2. Information Collection Technique**:
> This uses **implicit, unobtrusive data collection**. For activity, it uses **device sensors** (accelerometer, GPS) and **wearable integration** (smartwatch API). For diet, it uses **image recognition** or **barcode scanning**. Interactions are logged via standard app analytics. [2 marks]

> **3. Appropriateness**:
> This method is highly appropriate because:
> - **Minimises User Burden**: Manually logging every meal and exercise is tedious and leads to dropout. Automatic tracking is sustainable.
> - **Provides Objective, Rich Data**: Sensor data is more accurate and detailed than self-reports (e.g., actual heart rate vs. perceived exertion).
> - **Enables Real-Time Adaptation**: Continuous data flow allows the app to detect patterns (e.g., skipped workouts) and adapt messages **in context**, making interventions more timely and relevant. [2 marks]

---
#### Question 2(b)
**Describe four features which can be used in the personalised healthy living app to provide transparency of the implicit profiling method you have suggested in (a). Two features should relate to the input for implicit user profiling. Two features should relate to user control.**
[8 marks]
#### Model Answer with Detailed Explanation

> **Features Related to Input Transparency**:
> 1.  **"Data Collection Dashboard" (BP2)**:
>     A screen showing **exactly what data is being collected right now**. Icons indicate: "GPS: Active", "Heart Rate: Reading", "Camera: Inactive". A log below shows: "9:15 AM - Logged: 30 min run", "1:00 PM - Logged: Salad scan". This makes the **normally invisible collection process visible and concrete**. [2 marks]
> 2.  **"Why We Ask For This" Tooltips (BP2/BP4)**:
>     Next to each data permission request or sensor icon, a "?" button reveals a short explanation. E.g., next to "Heart Rate Access": "We use your heart rate to estimate calorie burn and adjust exercise difficulty. This data stays on your device." This explains the **purpose and scope** of collection, not just the fact of it. [2 marks]

> **Features Related to User Control**:
> 1.  **Granular Privacy Toggles (BP9)**:
>     In settings, separate switches for: "Track location during walks", "Analyse food photos", "Use heart rate data for recommendations", "Share anonymised data for research". This provides **participatory control**, allowing users to opt out of specific profiling methods while keeping others, aligning with their personal comfort levels. [2 marks]
> 2.  **Profile Inspection and Edit (BP8/BP9)**:
>     A "Your Inferred Profile" page showing: "The app thinks your fitness level is: **Intermediate**", "Your favourite exercise is: **Running**". Each item has an **"Edit"** or "Not Right?" button. The user can manually adjust these inferences. This provides **corrective control**, ensuring the model driving adaptations is accurate and respects the user's self-view. [2 marks]

---
#### Question 2(f)
**Consider the effect the system could have on the user’s behaviour. Describe one possible ethical violation regarding human agency and oversight.**
[4 marks]
#### Model Answer with Detailed Explanation

> **Ethical Violation: Coercive Nudging and Undermining Autonomy**.
>
> **Description**: The app, through its constant tracking, personalised notifications, and adaptive goals, could transition from a **supportive tool** to a **coercive supervisor**. By leveraging data on a user's vulnerabilities (e.g., detecting stress from heart rate variability), it could deliver **manipulative messages** that are hard to ignore, effectively **dictating behaviour** rather than supporting informed choice.
>
> **Example Scenario**: The app detects a user has had a sedentary week. Instead of offering supportive choices, it sends a notification: "Your activity is **23% below your peers**. You're at risk of weight gain. Your next scheduled workout is **NOW**." It then locks the phone's entertainment apps until a workout is logged. This uses **shame, social comparison, and restriction** to compel action, stripping the user of **volition**.
>
> **Why it Violates Human Agency (EU R1)**: This violates the core principle of **Human Agency and Oversight**. The system is not preserving the user's freedom to make choices; it is **engineering those choices** through manipulative design and punitive constraints. The user becomes a **subject of the system** rather than a partner, leading to potential psychological harm (anxiety, guilt) and eroding the very **self-regulation** skills the app claims to build. [4 marks]

---
### Question 3: Music Recommender System
#### Question 3(a)
**Describe how the click-through method can be applied to determine whether a user is interested in a given song.**
[4 marks]
#### Model Answer with Detailed Explanation

> The **click-through method** is an **implicit feedback technique** that interprets a user's click (or tap) on a recommended item as a **positive signal of interest**.
>
> **Application in a Music Recommender**:
> 1.  **Presentation**: The system includes a recommended song in a playlist, "Discover Weekly" list, or as a "Recommended Next" button.
> 2.  **Action & Interpretation**: If the user **clicks to play** that song, the system logs this as a **click-through event**. This action is interpreted as the user expressing interest in that song. The system may apply additional heuristics to strengthen the signal:
>     - **Dwell Time**: Did the user listen for more than **30 seconds** (indicating genuine interest vs. accidental click)?
>     - **Skip Action**: Did they skip before the end (potentially negative signal)?
> 3.  **Profile Update**: This click-through data is then fed into the **user model acquisition** component. The user's interest profile (e.g., a vector of genre/artist weights) is updated to **increase the weight** for the features (genre, artist, tempo) of the clicked song. This refined profile is used for future **content-based or collaborative recommendations**. [4 marks]

---
#### Question 3(b)
**A machine learning algorithm is used to detect the user’s mood... Describe how a formative evaluation of the mood detection algorithm can be conducted, considering two components: data collection and user modelling...**
[10 marks]
#### Model Answer with Detailed Explanation

> **Component 1: Data Collection**
> - **Evaluation Criterion**: **Interpretive Validity**.
> - **Justification**: We need to verify that the **raw data** (listening history, skips, song metadata) is being **correctly interpreted** as evidence for a specific mood. Does "listening to a slow, minor-key song" truly mean "sad" for *this* user in *this* context?
> - **Evaluation Method**: **Experience Sampling Method (ESM) / Ecological Momentary Assessment**.
>     - **Procedure**: During normal app use, randomly prompt the user with a brief survey: "How are you feeling right now? (Happy/Sad/Energetic/Calm)". Simultaneously, log the system's raw input data and its inferred mood.
>     - **Analysis**: Correlate the system's inference with the user's self-reported **ground truth**.
> - **Challenge**: **Intrusiveness and Prompt Fatigue**. Frequent prompts interrupt the music experience and may lead users to drop out of the study or give careless responses, biasing the data. [5 marks]

> **Component 2: User Modelling (The Mood Detection Algorithm Itself)**
> - **Evaluation Criterion**: **Predictive Accuracy**.
> - **Justification**: The ultimate test is whether the modelled mood state can **accurately predict** future user behaviour or preferences (e.g., the next song they'll choose).
> - **Evaluation Method**: **Temporal Cross-Validation**.
>     - **Procedure**: Split the timestamped log data chronologically. Train the mood detection model on the first 80% of the session data. Use it to predict mood for the next 10% of the session. Then, test if the predicted mood, combined with other factors, can predict the song choices in the **final held-out 10%** of the session. Compare against a baseline (e.g., always predicting "neutral").
>     - **Analysis**: Use metrics like **Precision/Recall for mood-specific recommendations**.
> - **Challenge**: **Concept Drift**. A user's mood-music associations may change over time (e.g., a breakup changes what "sad" music means). A model validated on old data may not generalise to future behaviour. [5 marks]

---
#### Question 3(c)
**The music recommender system uses a fragment-based approach to generate the interface suggesting songs and playlists tailored to the user’s mood and music interests. Describe three advantages of using a fragment-based approach in this case.**
[6 marks]
#### Model Answer with Detailed Explanation

> **1. Dynamic Personalisation Across Contexts**:
> The system can conditionally include/exclude interface **fragments** based on the real-time **user model**. For example, a "**Upbeat Workout Mix**" fragment is included `IF` (inferred_mood == "energetic") `AND` (time_of_day == "morning"). A "**Chill Evening Wind-Down**" fragment is included `IF` (inferred_mood == "calm") `AND` (location == "home"). This allows the **same core app** to serve radically different, contextually appropriate interfaces without rebuilding entire pages. [2 marks]

> **2. Efficient Reuse of Curated Content**:
> Fragments represent reusable UI components. A single, well-designed "**Artist Spotlight**" fragment (with bio, top songs, similar artists) can be plugged into the interface under many conditions: `IF` (user_interest_in_artist > threshold) `OR` (current_song.artist == featured_artist). This **saves development and design effort** compared to hard-coding this information into multiple static pages. [2 marks]

> **3. Incremental Adaptation and Testing**:
> New personalisation features can be developed as independent fragments and safely deployed. For instance, a new "**Nostalgia Track**" fragment (based on listening history from this date years ago) can be added with its own applicability condition. Its performance (click-through rate) can be **A/B tested** in isolation without affecting the rest of the interface. This supports **agile, data-driven development** of the adaptive system. [2 marks]

---
#### Question 3(d)
**State one disadvantage of using a fragment-based approach. Suggest an alternative approach that could overcome this disadvantage.**
[4 marks]
#### Model Answer with Detailed Explanation

> **Disadvantage: Coherence and Layout Risk (Especially with Optional Fragments)**.
> When using **optional fragments**, the page is assembled by including all fragments whose conditions are true. This can lead to a **cluttered, jumbled, or illogical interface** if fragments are not designed to fit together in all possible combinations. For example, a "Happy Mood Mix" fragment followed by a "Breakup Songs" fragment might appear simultaneously if the mood detection is uncertain, creating a confusing user experience. There is no **guaranteed information hierarchy or narrative flow**. [2 marks]

> **Alternative Approach: Altering Fragments (Slots and Constituents)**.
> This approach defines a **fixed template** for the main screen with specific **slots** (e.g., `Header_Slot`, `Primary_Recommendation_Slot`, `Secondary_Recommendation_Slot`, `Mood_Context_Slot`). For each slot, the system selects **one fragment** from a set of alternatives. For the `Primary_Recommendation_Slot`, it selects *either* the "Happy Mood Mix" *or* the "Breakup Songs" fragment based on the most confident mood inference. This **ensures a clean, structured layout** and logical coherence, as only one piece of content occupies each designated screen region. [2 marks]

---
#### Question 3(e)
**Which of the following recommender algorithms do not suffer from the item cold start problem?**
[2 marks]
#### Model Answer
> **Correct Answers: A, B**.
> - **A (Content-based)**: Uses item **features/metadata**, available as soon as the song is added to the catalogue.
> - **B (Knowledge-based)**: Uses a **knowledge base** of constraints and song properties.
> - **C & D (Collaborative Filtering)**: **Rely on user-item interactions**, so a new song with no plays cannot be recommended. [2 marks for all correct]

---
#### Question 3(f)
**The text below refers to a specific user information collection method, called here XXX. What is this method?**
[2 marks]
#### Model Answer
> **Method**: This describes **Local Storage/Client-Side Profiling**.
> **Explanation**: The profile is stored **unobtrusively** on the user's device (e.g., browser cache, app local storage). Different computers have **separate local storage**, hence separate profiles. If a computer is shared, multiple users get the **same profile** because it's tied to the device, not the person. This highlights a key **limitation** of this method. [2 marks]

---
#### Question 3(g)
**A/B testing is used to evaluate personalisation features. Which of the metrics below can be used in A/B testing?**
[2 marks]
#### Model Answer
> **Correct Answers: C, D, E**.
> - **C (Utility)**: Primary goal of A/B tests (e.g., engagement, conversion).
> - **D (Efficiency)**: Can be a business metric (e.g., faster task completion).
> - **E (User’s trust)**: Measurable via post-test surveys.
> - **A (Prediction Accuracy)**: An **offline, algorithmic metric**, not a live user behaviour.
> - **B (Coverage)**: An **offline, system-centric metric**. [2 marks for all correct]

---
#### Question 3(h)
**Which of the following hybridisation methods are order-insensitive?**
[2 marks]
#### Model Answer
> **Correct Answers: A, C**.
> - **A (Weighted)**: Final score = $w_1*score_1 + w_2*score_2$. Addition is **commutative**; order doesn't matter.
> - **C (Feature combination)**: Features from both algorithms are merged into a set; set union is **order-insensitive**.
> - **B (Switching)**: **Order-sensitive**. Which algorithm runs first defines the switch condition.
> - **D (Cascade)**: **Highly order-sensitive**. Output of first is input to second.
> - **E (Feature augmentation)**: **Order-sensitive**. Which algorithm provides the base features vs. augmented features matters. [2 marks for all correct]

---
#### Question 3(i)
**Is the statement below true or false? The switching hybridisation method switches between recommendation techniques depending on the current situation. This guarantees that the resultant hybrid algorithm will not suffer the user-cold-start problem.**
[1 mark]
#### Model Answer
> **False**.
> **Reasoning**: A switching hybrid only **mitigates** the user-cold-start problem if one of the techniques it switches *to* is specifically designed to handle it (e.g., a **Demographic** or **Knowledge-Based** recommender for new users). The statement says it *guarantees* no cold-start problem, which is incorrect. If both techniques in the switch are CF-based, the hybrid will **still suffer** from cold-start. The guarantee is not inherent to the switching method itself. [1 mark]