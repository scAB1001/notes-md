# 1
#### General
1. Find a supervisor
2. Align it with your specification and speak to career coach, manager, tutor, etc
3. Core component must be a computer science problem
4. The project must contain some coded implementation, demonstrating your project’s work but this is not the focus (it can be a small amount)
5. Book supervisor meetings every 2 weeks (minimum) no matter what and prepare for them as best as possible. Think SEP meetings.

Create a GitHub repo:
- Wiki for documentation
- Code repo
- Planning boards
- Actions for tests

There will be an Ethical section

Referring to point 5, come prepared to each meeting with the mark scheme as bullet points/questions

Per week spend 10 hours on your project.

Formal deadline
Preference form in week 1

Short written form on gradescope in week 6.

# 2
### To-do
- Research
- Send list of titles suing project 10: VR/AR
	- Consider deliverables first
- Share word-doc/overleaf project + email
- Meet after project synopsis
- Research how to use unity - mesh simplification, *meshlab*
- ==Gradescope==
#### Notes
- Liver examples already exist, use the existing paper as a starting point
- VR/AR (Dora)  - computer access, unity software, camera system is an option and could be integrated as part of the project
- Hand tracking device (£500)
	- XR-4 SERIES, SoC
	- Can only work on-premise in the lab
- Use magic leap2, connect with unity value (headset)
	- idea is to replace the joy-sticks with hand-based rendering (software project)
	- API exists already but need to integrate your own 
		- REPLACE joystick with hand-movements
			- CV: "I divised this handtracked for my project to do 3D manipulation of the medical scene (LIVER)"
			- Loading in the 3D models llike liver, etc but the hand-tracking/movements are the goal. Immersion 
			- Interactive, user-friendly, VR/AR clinical training with real 3D models
	- How to transform the 3D segmentation of a model, there are many problems there (scaling etc)
		- Mesh issues, holes in the mesh, mesh simplification - how would you simplify the dense meshes?
		- Take mesh, simplify so that it is topologically consistent to preserve shape, load mesh into AR/VR environment, make a user-friendly navigation system through hand-tracking - existing tracking software is a C program that uses joystick
	- **CANNOT BE PUBLIC** -  code snippet in thesis
	- Ethics: Publicly available datasets
	- Business wise: company funded by hollowcare, used in gaming industry and visualisation - healthcare technologies, growing currently, requires bespoke software engineering and skills, combines SME + Engineering (BA)
		- Mr Mikolaj R Kowal

### Neat
##### Artificial intelligence in Medicine and Surgery (AIMS group)
*Sharib Ali*, PhD, School of Computer Science, Faculty of Engineering and Physical Sciences, University of Leeds, UK, s.s.ali@leeds.ac.uk https://artificial-intelligence.leeds.ac.uk/aims/

*Gerardo Loza Omar Choudhry*
*Edward Ellis Patryk W.*
*Raneem T. Pedro C.*
##### Original Problem
**Project 10: Virtual Reality for right hemicolectomy planning**
Example segmentation of the trunk of Henle. This is a type 3 (GPCT with two colic veins), involving SRCV, RCV, ASPDV and RGEV - *Mr Mikolaj R Kowal*
![[right-hemicolectomy-image.png]]
![[right-hemicolectomy-model.png]]
##### New problem
The old model, much like others, is controlled using joysticks. 
- [Downsides]
##### Solution
- There are plenty of real liver and colon 3D models available to use
- Varjo XR-4 series - VR headset (Can only work on-premise in the lab, property of SoC)
- Magic Leap 2 - VR headset
- Using one of the VR headsets and connecting to the API, load in a 3D model and integrate the handtracking to allow user-friendly navigation around it

https://varjo.com/blog/introducing-integrated-hand-tracking-for-varjo-xr-4-series
https://www.magicleap.com/magic-leap-2
##### Project title ideas
1. Clinical Training: Hand-based Rendering for Topologically Consistent Anatomy Navigation in Virtual Reality
2. Replacing Joystick Control: A Hand-Tracking Interface for Virtual Reality in Surgical Planning
3. Enhancing Clinical Training: Intuitive Hand-Tracking for 3D Anatomy Manipulation in Virtual Reality
4. 3D Anatomy Manipulation: Surgical Anatomy through Hand Tracking Software in AR
5. Hand Tracking Clinical Training Software for Clinical Model Navigation in Virtual Reality
6. Hand-Tracking for Immersive Surgical Anatomy Visualisation
7. An Immersive Hand-Tracking Interface for 3D Medical Models
8. Gesture-Based Navigation of Anatomical Models in Virtual Reality
9. A Hand-Gesture Navigation System for Patient-Specific Anatomy in Augmented and Virtual Reality
10. Developing a Hand-Tracking Interface for Virtual Reality-Based Surgical Simulation
11. A Software Framework for Hand-Controlled Manipulation of Medical Meshes in Immersive Environments
12. An Immersive Hand-Tracking Interface for Surgical Anatomy Visualisation in Virtual Reality
##### Top 3
1. Surgical Simulation: A Hand-Tracking Interface for Anatomical Models in Virtual Reality
2. Replacing Joystick Control: A Hand-Gesture Based Navigation System for 3D Anatomy Manipulation in Virtual Reality
3. Replacing Joystick Control: Gesture-Based Navigation of Anatomical Models in Virtual Reality
# 3
#### Key
**Student**: Andreas Bazigos 
**Supervisor**: Sharib Ali 
**Assessor**: Natasha Shakhlevich
### 1. Title
A concise title that accurately describes the subject of your project.
The subject should be the computer science problem that you are investigating.
It should not be, for example, a software artefact (e.g. a mobile app or web site) – that is a
Deliverable of the project, and part of your solution, but not the subject.

--- 
*Replacing Joystick Control: A Hand-Gesture Based Navigation System for 3D Anatomy Manipulation in Virtual Reality*
### 2. Aim
A short paragraph describing the computer science problem that your project is
investigating.

You can describe the context of the problem but need to separate out the specifics of what
you will be studying.

This does not need to describe how you solve the problem or with what algorithms or tools,
unless that is fundamental to the work, e.g. your project is studying a particular algorithm or
technique.

---
The aim of this project is to develop and evaluate a hand-gesture based interaction system for intuitive 3D anatomical model manipulation in virtual reality, addressing the usability limitations of traditional joystick-controlled interfaces.

**Computer science problem:** Current 3D anatomical visualization systems rely on joystick-based navigation, which presents significant human-computer interaction challenges including non-intuitive control mappings, limited degrees of freedom, and high cognitive load during complex spatial manipulation tasks. These limitations result in steep learning curves and reduced efficiency in surgical planning applications where precise spatial understanding is critical.

**What will be produced:** A prototype VR system with integrated hand-gesture recognition for anatomical model navigation and a formal usability study comparing task completion times, error rates, along with a comparative evaluation of its usability against conventional joystick interfaces.
### 3. Objectives (up to 5)
Objectives should be SMART – Specific, Measurable, Achievable, Relevant, Time-bound.
Objectives should be a list of tasks that collectively meet the Aim of your project (makes
them Specific and Relevant)
Consider what you need to achieve to reach your Aim, as stages of your project.
Normal parts of the project such as literature review and report writing are not Objectives.

---
1. **Develop a 3D model preprocessing pipeline** that automatically repairs, simplifies, and optimizes anatomical meshes for real-time VR rendering while preserving critical topological features for surgical accuracy.
    
2. **Implement a real-time hand-gesture recognition system** using the Varjo XR-4/Magic Leap 2 APIs that accurately interprets complex 3D hand movements with precision for intuitive model manipulation.
    
3. **Design and develop a gesture-to-action mapping framework** that translates recognized hand movements into precise 3D navigation commands (rotation, zoom, pan, selection) with appropriate feedback and visual confirmation.
    
4. **Conduct a comparative usability evaluation** measuring task completion time, error rates, and user satisfaction between the hand-gesture interface and traditional joystick control with at least 10 participants from technical backgrounds.
    
5. **Optimize the integrated system performance** to achieve consistent high framerate rendering in VR while maintaining reasonable latency for gesture recognition to ensure a comfortable, user-friendly experience.
### 4. Deliverables (up to 5)
Deliverables are concrete items produced as part of your project. They are the evidence
required to show you have met your Objectives, and ultimately your Aim.
You should link them to your Objectives such that it is clear which Deliverable relates to
which objective (makes the Objective Measurable and Achievable).

Your final report and your software repository can both be considered Deliverables. You
may wish to further sub-divide this, for example if you project delivers several distinct
software items or particular chapters of your report are relevant.
This is the starting point for a plan, which you should also work on with your supervisor.

---
 1. Final report
 2. Software Repository
	 1. 3D mesh preprocessing toolkit with automated hole-filling, decimation, and optimization algorithms
	 2. Real-time hand gesture recognition module with trained models and calibration utilities
	 3. Unity-based VR integration framework with customizable gesture mappings
	 4. Performance benchmarking and testing suite
 3. Functional Prototype Application demonstrating complete workflow from model import to immersive hand-controlled navigation with support for multiple anatomical structures.
 4. Evaluation Dataset & Results including recorded user sessions, performance metrics, comparative analysis, and structured feedback from usability testing.
### 5. Plan
A schedule for your project from now until the final submission of the report (week 10 of
semester 2). Weekly is probably an appropriate level of planning for most people.
Use your Deliverables as milestones for your progress (makes the Objective Achievable and
Time-bound).

Allow time for completing evaluation of your work as well as completing development.
Allow time for writing up, and consider how you will write up – regularly and incrementally,
or later, once work is complete.

Please consider when there are other demands there are on your time, e.g. exams,
coursework, holidays.

---
#### Semester 1
**Week 06 (w/c 03/11)**
- Project outline approval
- Literature review: VR interaction techniques & medical visualization
- Setup development environment (Unity, Varjo SDK/Magic Leap2 software)

**Week 07 (w/c 10/11)**
- Research 3D mesh processing algorithms
- Acquire and test sample anatomical models
- Begin mesh preprocessing implementation

**Week 08 (w/c 17/11)**
- Complete mesh preprocessing pipeline
- Test with complex liver models
- Start hand tracking API integration

**Week 09 (w/c 24/11)**
- Implement basic gesture recognition (grab, rotate, zoom)
- Integrate with simple 3D model in VR
- **Milestone: Basic gesture control working**

**Week 10 (w/c 01/12)**
- Refine gesture accuracy and sensitivity
- Add advanced gestures (pan, select, reset view)
- Begin writing Chapter 2 (Literature Review)

**Week 11 (w/c 08/12)**
- Complete core gesture mapping system
- Initial performance optimization
- **Milestone: All planned gestures implemented**
#### Break
**Week 12-13 (w/c 15/12 - 22/12)
- Holiday

**Week 13- 15 (w/c 22/12 - 05/01)**
- Light work: Continue literature review writing
- Plan evaluation methodology
- Prepare ethics considerations documentation

#### Semester 2
**Week 01 (w/c 12/01)**
- System integration testing
- Fix compatibility issues between components
- Begin Chapter 3 (Methodology)

**Week 02 (w/c 19/01)**
- Develop evaluation protocol
- Create testing scenarios and tasks
- Prepare participant materials
  
**Week 03 (w/c 26/01)**
- Conduct pilot testing (3-5 participants)
- Refine system based on feedback    
- **Milestone: System ready for evaluation**

**Week 04 (w/c 02/02)**
- Run formal user evaluation sessions
- Collect performance data and user feedback
- Begin data analysis

**Week 05 (w/c 09/02)**
- Complete all user testing
- Analyze comparative results
- Start Chapter 4 (Results)

**Week 06 (w/c 16/02)**
- Complete results analysis
- Draft Chapter 5 (Discussion)
- **Milestone: Evaluation complete**

**Week 07 (w/c 23/02)**
- Full draft completion (all chapters)
- Initial proofreading and formatting
- Prepare appendices

**Week 08 (w/c 02/03)**
- Supervisor feedback incorporation
- Technical refinement based on findings
- Final performance optimization

**Week 09 (w/c 09/03)**
- Final proofreading and formatting
- Reference checking
- Submission preparation

**Week 10 (w/c 16/03)**
- **FINAL SUBMISSION**
- Buffer week for unexpected delays
### 6. Risk
A brief discussion of how to mitigate risk in your project and ensure sufficient work will be
completed for final submission.
This could include prioritisation of Objectives and Deliverables or development of
prototypes as early-stage deliverables.
This could include some contingency in your plan for delays.

---
**Key Project Risks and Mitigation Strategies:**

1. **Scope Creep Risk** - The project could expand beyond what's achievable in the timeframe
    - **Mitigation**: Define a "minimum viable product" (MVP) upfront: basic rotation/zoom gestures with one anatomical model. Additional features (pan, selection, multiple models) are stretch goals only if time permits
    - **Mitigation**: Weekly progress reviews with supervisor to ensure focus remains on core objectives
2. **Technical Blockers Risk** - Hand tracking API integration or VR hardware issues could cause significant delays
    - **Mitigation**: Develop a "simulation mode" early that mimics hand gestures using mouse/keyboard, allowing continued development even if hardware is unavailable
    - **Mitigation**: Start with simple proof-of-concept integration in Week 1 to identify API issues immediately
3. **Time Management Risk** - Other coursework commitments could reduce project time
    - **Mitigation**: Use Gantt chart with buffer weeks (Weeks 8-9 of Semester 2) for catch-up
    - **Mitigation**: Prioritize writing dissertation concurrently with development (write Chapter 2 during development phase)
4. **Hardware Dependency Risk** - Limited lab access to Varjo XR-4/Magic Leap 2 headsets
    - **Mitigation**: Schedule lab time 2 weeks in advance and have backup development plan for Unity Editor testing
    - **Mitigation**: Document all hardware-specific code clearly to minimize rework if equipment changes
5. **Evaluation Failure Risk** - Difficulty recruiting participants for usability testing
    - **Mitigation**: Plan evaluation early (Week 3 Semester 2); have backup pool of computing students if medical professionals are unavailable
    - **Mitigation**: Design evaluation to require only 5-8 participants for meaningful results

**Prioritization Strategy (if delays occur):**
1. **Essential for submission**: Working gesture system with one model + basic evaluation + completed dissertation
2. **Can reduce**: Number of gesture types tested, number of evaluation participants, complexity of models used
3. **Can omit entirely**: Advanced features like mesh preprocessing automation, complex gesture mappings

**Early Prototyping**: A functional prototype demonstrating basic hand tracking will be completed by Week 9 of Semester 1, ensuring core technology viability before major development investment.

- Hand tracking accuracy issues: Some form of confidence scoring will be needed to assess accuracy
- Performance bottlenecks: Progressive mesh loading may severely impact the system; maintain joystick compatibility as backup
- VR motion sickness: Include comfort settings (snap turning, reduced movement); rigorous testing with multiple users early in development
### 7. Ethics
Describe the ethical issues associated with your project and how you will address them.
For example, proper handling of data sets, user testing, etc.
There is a lecture in Week 6 that you must attend and a further advice session in Week 7 if
you need guidance on how to properly consider ethics.
If you believe there are no ethical issues associated with your project you should state that
here.

---
- User Testing: All participants will provide informed consent; right to withdraw at any time; no medical professionals required for initial testing
- Health and Safety: VR usage guidelines provided; regular breaks enforced; participants screened for epilepsy or motion sickness susceptibility
- Intellectual Property: Clear acknowledgment of university and individual contributions; no use of proprietary medical data.
Ethical approval is required for the user-testing portion.

#### Alternative if you're **only** doing technical testing (no human participants)
**Ethical Considerations:**
Given that this project involves:
- No human participants in testing
- No access to medical or personal data
- Only publicly available, anonymized 3D models
- Technical performance evaluation only (no user studies)

**There are no significant ethical concerns requiring formal approval.** Any system testing will be conducted by the researcher only, focusing on technical metrics (frame rates, tracking accuracy) rather than human factors.

**However,** if user testing is added later, formal ethical approval will be sought through the appropriate university channels before any participant recruitment begins.
# 4
### Outline
We'll be looking at ethical issues that might arise in your projects and how to manage these.
1. Two common issues in computing projects
	a) Consent
	b) Privacy and anonymity
2. Six areas of block ethical approval
	a) Images of people
	b) Medical images
	c) Use of religious texts
	d) User testing
	e) Use of data from the internet
	f) Working with NHS staff
3. Applying this to a case study
#### 1 . Common Issues in Computing Projects
##### Consent
Each person has a right to control their body, property, and who has access to these.
- Includes access to data, which is property of the subject and is about them.
- Consent is a kind of permission-giving; it often, but not perhaps always, makes an act ethically permissible.
- Securing a person’s consent before collecting or accessing their data is important for respecting their autonomy and boundaries.
- Sometimes people can’t consent due to mental impairment, e.g. very old and very young.
- A person does not properly consent to something if they are pressured into agreeing or do not understand what they are agreeing to.
- So, consent must be:
	- Free
	- Informed
- If your project involves collecting data about users, this presents a risk.
- In that case, you must have the informed consent of users.
- Fully informed about what their data is used for, and what data is collected.
##### Privacy and Anonymity
Consent is also important because it relates to privacy.
- Privacy is important:
- For individuality of thought and expression
- For freedom from control
- For regulating boundaries in relationships
- For control over who experiences us
- Lack of privacy hinders human flourishing in fiction (George Orwell’s 1984) and totalitarian regimes (eg. North Korea).

If data identifies a person, then it is personal data.
- Collecting personal data creates a risk of harm:
- Discrimination (belonging to oppressed groups; religion, sexuality, ethnicity)
- Social disadvantages (mental health history, criminal record)
- Identity fraud, targeted marketing, harassment
- Violating someone’s choice/autonomy: should be up to individuals what data is collected about them
##### Personal Data: Direct and Indirect Indicators
**Direct Indicators**
Can be used to directly identify the data subject.
- Unique to a person.
- Includes:
- Name/initials
- Address, including full or partial post code
- Telephone numbers or email addresses
- Unique identifying numbers (NI number, NHS number)
- Vehicle identifiers
- Medical device identifiers
- IP addresses
- Facial photographs
- Names of relatives
- Individual dates

**Indirect Indicators**
Can be used in conjunction with other information (direct or indirect) to identify data subjects.
- Includes:
- Place of treatment or GP name
- Sex
- Place of birth
- Socio-economic data (income, etc.)
- Ethnicity
- Age
- Household or family constitution
- Illicit drug use, or other substance use
- Rare diseases and treatments
- Transcripts or verbatim responses
##### Data Linkage
- “Data linkage” can occur when two (or more) pieces of information from different sources are brought together.
-  This can identify a data subject, or reveal information that is not available in one dataset.
-  This means that even if data is anonymized within the context of its own data set, linkage may de-anonymize the data.
### 2. Six Areas of Block Ethical Approval
- There are some kinds of data that you are approved to collect as part of this module.
- However, each of these must be collected, stored, and processed in line with certain guidelines and restrictions.
##### a) Images of people
- Your project might involve using still or moving images of
people
- For instance:
- Tracking individuals in crowded scenes
- Facial feature recognition
- Projects might use new or pre-existing images

- New images:
	- Proper consent forms collected
	- Participants given all appropriate information necessary for informed consent.
- Existing images only be taken from legitimate sources
- When public filming, impact assessments performed to
determine whether individuals can be identified.
##### b) Medical images
- Your project might involve the application of algorithms to medical images.
- For instance:
	- Automating the detection of cancerous tissue
	- Developing interfaces to help with the visualization of tissue samples
- The project might use images from people’s medical records.

**Ethical issues involved in using medical images?**
- Anonymization – Medical data is private; can be sensitive, embarrassing
- Storage / misuse / theft – medical data desirable
- Legitimacy of sources
**What should be done to avoid potential problems?**
- Ensure that the images are taken from legitimate source
- Ensure images anonymized (you should receive them anonymized, but there could be mistakes)
- Ensure storage is secure
##### c) Use of religious texts
Projects in the field of Natural Language Processing can involve the automated analysis of text
- These can be religious texts
- For instance:
	- Categorization of verses in the Quran
	- Machine Translation of the Quran into other languages

**Ethical issues involved in using religious texts?**
- Objects of sacred importance to some; respectful use
- Misinterpretation or translation by the program
- Types of interpretation to use? Literal (word for word) or dynamic (sense for sense)?
- Copyright law violation
##### d) User testing
- Project might involve getting user feedback on a system being designed, developed, or evaluated.
- For example:
	- Testing the usability of a graphical user interface
	- Evaluating whether a visualization technique helps people to understand and interpret data more easily
- Obtaining this feedback might involve: observation, questionnaires, or interviews

- You must provide each participant with an information sheet fully detailing the project, the data that will be collected, how the data will be stored and used.
- You must assure users that they can leave at any time, to avoid coercion.
- When appropriate, the user will complete a written consent form.
- No sensitive information will be recorded, and any personal information will be securely stored.
##### e) Use of data from the internet
- Your project might involve analysis of data collected from the internet
- For instance:
	- Publicly available databases, eg. government data could be analyzed to identify trends and patterns
	- Data about website use may be analyzed to extract trends

**Ethical issues in data drawn from the internet?**
- Legitimacy of sources?
- Anonymized?
- Reliable data?
- Consent from appropriate sources, eg. website owners?

**What should be done to avoid potential problems?**
- Only draw data from reliable and legitimate sources
- Any data relating to individuals to be anonymized
- Consent given when appropriate
##### f) Working with NHS staff
- Your project might:
	- Aim to understand how specific elements of technology are used
	- Assess the benefits or drawbacks of some new element of technology
- This might involve observing staff, getting them to read documents or fill out questionnaires, or performing interviews
- Provide information sheet about your project, obtain written consent when appropriate, assure staff they can withdraw from participating
- Discuss with staff beforehand how to avoid sensitive information/being left alone with patients
- Not requesting/accessing information about individual patients
- No sensitive information recorded, any personal information securely stored
- No participant named without express consent
- Students briefed on health and safety protocols
### 3. Applying this to a case study
#### Example 1: Target
- In 2002, US shop chain Target employed a data scientist called Andrew Pole to “figure out if a customer is pregnant, even if she didn’t want us to know”.
- They intended to use the results of this work to send personalised coupons for relevant products to customers they expected to be pregnant.
- Pole started by looking at the dataset of customers who told Target they were pregnant. He analysed the shopping habits of these customers to discover patterns. On the basis of this data, developed a “pregnancy prediction” score.
- Using this software, Pole could estimate due dates and send coupons timed for specific times in the pregnancy.
- One year later an angry customer demanded: “Are you encouraging my teenage daughter to get pregnant?” Target had been sending her coupons for pregnancy products.
- One week later, the manager contacted the man again. This time, the man disclosed that his daughter was actually pregnant, but had not told him until the coupons prompted her to do so.
- Target knew that the teenage girl was pregnant, on the basis of Pole's predictive software, before her father knew.
##### Observations
- What are the ethical issues here?
- Did Andrew Pole do anything wrong?
- Imagine you were doing his job. Would you have done anything differently?
### - Summarised the nature of ethics and why it is important
- Considered some important ethical concepts: consent, anonymity, privacy
- Examined six specific areas of ethical concern, which your projects might involve
- Applied these notions to a specific case study
#### Example 2: Help in identifying deep-learning
Write about the fact the ethical consideration is part of the motivation of the project 
# 5
### To-do
- Lit review
- Create a questionnaire for the user testing of performance and intuition etc.
- No need to process .obj, just load in.
- Read hand gesture input
- See previous projects
	- They plan what's important in core project then the rest in the appendix
### Questions
- How do I record my code and settings? Put in the appendix (table format --make a block diagram (point)) -can I export config settings of Unity Project?
- Break unity into parameters
	- Code in github ofc
	- Make hand gesture tutorial?
	- print different rotation angles for example
	- if hand gesture fails - what can you do?
	- How do you scale and rotate model 
		- -> what's the angel of rotation (new feature of metrics)
		- Show the metrics/data that isn't usually shown to users (unique code)

- Which metrics?
- User ethics
# 6 
In the field of Human-Computer Interaction (HCI) and Virtual Reality (VR), evaluation is not just about "does it work?" but rather "how well does it facilitate human intent?" For a high-scoring Computer Science project, you need a mixed-methods approach that balances **objective telemetry** (what the computer sees) with **subjective feedback** (what the user feels).

The industry standard for evaluating a new interaction paradigm involves a **Within-Subjects Design**, where each participant tests both the baseline (joystick) and your experimental system (hand gestures) to eliminate individual skill variance.

---

## 1. Subjective Metrics: Standard Questionnaires

To justify your claims in the "Results and Discussion" chapter, you should use validated, peer-reviewed scales. This prevents your evaluation from being dismissed as "subjective opinion."

### System Usability Scale (SUS)

The SUS is a ten-item Likert scale (1-5) that provides a "quick and dirty" but reliable tool for measuring usability.

- **Why use it?** It gives you a single score out of 100, which is highly effective for a "Summary Table of Methods" in your report.
- **Metric:** A score above 68 is considered above average.
### NASA Task Load Index (NASA-TLX)

This is critical for your project aim of reducing cognitive load. It measures:
- **Mental Demand:** How much mental and perceptual activity was required?
- **Physical Demand:** This is vital for hand-tracking to detect "Gorilla Arm" fatigue.
- **Temporal Demand:** Did the user feel rushed?
- **Effort/Frustration:** How hard did they have to work to reach their performance level?
### VR Sickness Questionnaire (VRSQ)
Since your project involves 3D manipulation, measuring nausea, oculomotor strain, and disorientation is a professional touch that demonstrates a "deeper understanding" of VR safety.

---

## 2. Objective Metrics: The CS Telemetry

While the survey captures the user's perception, your **HandMetricsLogger** should capture the hard data. This is what differentiates a CS project from a design project.

|**Metric**|**Data Source**|**Calculation / Justification**|
|---|---|---|
|**Task Completion Time (TCT)**|`VarjoTime.GetVarjoTimestamp()`|Total nanoseconds from the start of the task to the final alignment.|
|**Transform Efficiency**|`Transform.eulerAngles`|The sum of total rotation applied. High efficiency = low total degrees moved to reach the target.|
|**Gesture Precision**|`PinchStrength`|The variance in pinch strength during a "grab." Does the user struggle to maintain the 0.8 threshold?.|
|**Focus Stability**|`GazeData.focusStability`|Measure if users look at the liver or their hands. High focus stability on the model suggests higher intuition.|

---
## 3. The Qualitative Survey: Guided Feedback
Beyond the numbers, you need "clever summary forms" to guide user feedback. Structure your survey to ask about specific features:

1. **Intuition:** "On a scale of 1-5, how much did the 'Pinch' gesture feel like picking up a physical object?"
2. **Mapping:** "Was the relationship between your hand's rotation and the liver's rotation clear?"
3. **Discovery:** "How long did it take for you to feel 'in control' of the scaling mechanic?"
4. **Open-Ended:** "What was the most frustrating part of the hand-tracking experience?" (This is where you look for mentions of **occlusion** or **jitter**).

---
## 4. Evaluation Protocol: A Standard Way
To ensure your results are statistically meaningful ($p < 0.05$), follow this sequence for every participant:

1. **Pre-Test:** Sign ethics consent and Briefing.
2. **Training:** A 2-minute "sandbox" mode to learn the gestures.
3. **Task A (Baseline):** Perform the liver alignment task using the Joystick.
4. **Task B (Experimental):** Perform the same task using Hand Gestures.
5. **Post-Task Survey:** Fill out the NASA-TLX and SUS for **each** method separately.
6. **Interview:** Brief qualitative discussion on their preference.
### Statistical Analysis Tip
In your report, do not just list the averages. Use a **Paired Samples t-test** to compare the TCT (Time to Completion) of the joystick vs. gestures. If your $p$-value is less than 0.05, you can formally claim that your gesture system is "statistically faster/more efficient."

Would you like me to draft the specific 10 questions for the System Usability Scale (SUS) tailored to your medical anatomy navigation context?
# 02/04/2026
## Update on Project Implementation
### The Developmental Recap (Logically Stepped)
#### Phase 1: Architectural Foundation & Environment
**Goal:** Establish a pristine, non-distracting VR environment (the Clinical Void) that protects cognitive load metrics and optimizes HDRP lighting.
* **Action:** Configured a minimalist "shoebox" room using scaling and rotation of basic 3D planes to enclose the user.
* **Fixes:** * *Lighting:* Addressed dark interior walls by creating a `Directional Light_Fill` with disabled shadows to bounce ambient light, preventing double shadows on the liver.
    * *HDRP Baking:* Disabled Auto-Baking and forced real-time lighting to stop Unity from throwing render pipeline errors during dynamic object manipulation.
    * *Camera Origins:* Diagnosed a severe spatial offset error by enforcing the `XR Origin` to `0,0,0`, ensuring the Varjo headset calculates world space without interference.
#### Phase 2: Ultraleap Hand Tracking Integration
**Goal:** Test physical controllers then Replace physical controllers with optical hand tracking, utilizing Varjo's embedded Leap Motion hardware.
* **Action:** Cleared out bloated demo assets and integrated the `Service Provider (XR)` directly beneath the Main Camera.
* **Fixes:**
    * *Data Severing:* Fixed invisible tracking by manually mapping the `Hand Model Manager` and ensuring the `Leap Provider` reference was intact.
    * *The Neon Pink Shader:* Diagnosed Unity's immutable package cache bug. Bypassed the procedural (and broken) `CapsuleHands` generation entirely by transitioning to standard Skinned Mesh `Ghost Hands` with native HDRP material compatibility (`Mat_ClinicalHands`).
#### Phase 3: Kinematic Interaction & Telemetry 
**Goal:** Create a physics-free interaction system capable of precision manipulation, supported by asynchronous background data logging.
* **Action:** Wrote `UltraleapKinematicManipulator.cs` and `AlignmentMetricsLogger.cs`.
* **Fixes:**
    * *The Hysteresis Loop:* Implemented a strict pinch-to-grab system. Fixed the "Loose Grab" bug by forcing an absolute Vector3 calculation between the index and thumb tip, combined with a `GrabStrength` check.
    * *Occlusion Loss:* Implemented a 0.25-second coyote-time grace period to prevent the liver from dropping when wrist rotations momentarily block the cameras.
    * *Telemetry Flatline:* Fixed a GameObject referencing error in the Inspector that was causing `TranslationalError` to flatline at `0.3m`.
#### Phase 4: Trial Orchestration
**Goal:** Automate the 4-task progression (Translation, Rotation, 6-DoF, Scaling) and provide native UI feedback.
* **Action:** Created `ClinicalTrialManager.cs` to act as the central state machine.
* **Fixes:** * *Feedback Clarity:* Removed material-swapping scripts that fought the render pipeline. Implemented a native World Space UI text monitor (`System_Status_Text`) for state communication.
    * *Success State Validation:* Added a 2.0-second spatial Dwell Time to prevent "lucky" fly-by alignments, culminating in an automated TCT (Task Completion Time) calculation and success-state visual feedback.

---
### Hierarchy Reorganization & Known Configurations
Looking at your screenshot, your hierarchy is actually quite clean, but we can organize it to industry-standard "System Grouping" to make it impenetrable to future bugs.
#### Suggested Reorganization
**1. Create a `[Core_Systems]` Empty Object:**
* Move `TrialManager` into this.
* Move `Global Volume` into this (Extract it from Environment, as it is a post-processing system, not a physical object).
* Move `XR Interaction Manager` into this.

**2. Create an `[Interaction_Rig]` Empty Object:**
* Move `XR Origin (XR Rig)` into this.

**3. Create a `[Clinical_Assets]` Empty Object:**
* Move `Patient4_3D_Liver_Model_Solid` into this.
* Move `Patient4_3D_Liver_Model_Holo` into this.
#### Final Object List & Configurations

| Object Name | Component | Key Configuration / Script Data |
| :--- | :--- | :--- |
| **Env_OperatingTable** | Transform | Pos: `0.02, 0.679, 1.246`, Rot: `345, 0, 0` |
| **Directional Light_Main** | Light (Realtime) | Lux: `41945`, Shadows: `Enabled`, Rot: `50, 330, 0` |
| **Directional Light_Fill** | Light (Realtime) | Lux: `15000`, Shadows: `None`, Rot: `321, 102, 34` |
| **Global Volume** | Volume | Profile: Fixed Exposure `12.8` |
| **Service Provider (XR)** | LeapServiceProvider | Multiple Device Mode: `Specific`, Optimization: `HMD` |
| **Ghost Hand (Left/Right)** | SkinnedMeshRenderer | Material Element 0: `Mat_ClinicalHands` |
| **Patient4_..._Solid** | Transform / Rigidbody | Pos: `-0.085, 0.871, 1.172` (Base). Is Kinematic: `True` |
| **Patient4_..._Holo** | Transform | Pos: `0, 0.871, 1.172` (Base). Material: `Mat_ClinicalHologram` |
| **System_Status_Text** | TextMeshProUGUI | Render Mode: `World Space`. Scale: `0.001` |
| **TrialManager** | AlignmentMetricsLogger | Solid Liver: `Patient4...Solid`, Target: `Patient4...Holo`, Polling: `0.05` |
| **TrialManager** | UltraleapManipulator | Enter: `0.025`, Exit: `0.05`, Max Grab: `0.4`, Grace: `0.25` |
| **TrialManager** | ClinicalTrialManager | Dwell Time: `2.0`, Dist Error: `0.015`, Ang Error: `5.0` |

---
### Granular Checklist for Completion
* [x] Establish Clinical Void architecture and real-time HDRP lighting.
* [x] Zero out XR Origin to fix Varjo headset spatial offsets.
* [x] Bypass Package Cache immutable bug by switching to Rigged Ghost Hands.
* [x] Apply `Mat_ClinicalHands` to SkinnedMeshRenderers.
* [x] Code `AlignmentMetricsLogger` to record 20Hz spatial Euclidean/Quaternion errors.
* [x] Validate telemetry targeting (fixing the `0.3m` flatline).
* [x] Code strict Vector3 thumb-to-index pinch thresholds.
* [x] Code 0.25s Coyote-Time for rotational occlusion.
* [x] Wire native World Space UI Canvas for state feedback.
* [x] Code 2.0s Dwell Timer for Task Success validation.
* [x] Output Final TCT to UI.
### Testing
- **The 6-DoF (Degrees of Freedom) Docking Task** is the _objective_ side of your evaluation. It mathematically measures performance. You are asking the user to match Translation (X, Y, Z axes) and Rotation (Pitch, Yaw, Roll) simultaneously. It proves whether the physical interaction is accurate and efficient.
- **The NASA-TLX** is the _subjective_ side of your evaluation. It measures cognitive cost. It answers the crucial question: "How hard did the user's brain have to work to achieve that 6-DoF docking performance?"

Together, they directly answer your core research problem: 
> Does replacing abstract joystick controls with natural hand-gestures *reduce* mental friction *without* sacrificing clinical spatial accuracy?
## Reviewing the NASA-TLX 
### Source 1: Guide
NASA Task Load Index
Acronym
NASA TLX
Description

The NASA task load index (NASA TLX) is a tool for measuring and conducting a subjective mental workload (MWL) assessment. It allows you to determine the MWL of a participant while they are performing a task. It rates performance across six dimensions to determine an overall workload rating. The six dimensions are as follows:

1. Mental demand how much thinking, deciding, or calculating was required to perform the task.
2. Physical demand the amount and intensity of physical activity required to complete the task.
3. Temporal demand the amount of time pressure involved in completing the task.
4. Effort how hard does the participant have to work to maintain their level of performance?
5. Performance the level of success in completing the task.
6. Frustration level how insecure, discouraged, or secure or content the participant felt during the task.

Each subscale is presented to the participants either during or after the experimental trial. They are asked to rate their score on an interval scale ranging from low (1) to high (20). The TLX also employs a paired comparisons procedure. This involves presenting 15 pairwise combinations to the participants and asking them to select the scale from each pair that has the most effect on the workload during the task under analysis. This procedure accounts for two potential sources of between-rater variability: differences in workload definition between the raters and differences in the sources or workload between the tasks.

The subscales are given to the participants either during or following their experimental trial. The participants self-rate on a scale of 1 (low) to 20 (high) using 15 pairwise combinations designed to elicit from the participants the pair that has the greatest effect on workload while performing the task.
Uses

To evaluate mental workload demand on an individual performing a specific task.
How do I use this tool?

1. DEFINE THE TASK(S).
2. (Optional) CONDUCT A HIERARCHICAL TASK ANALYSIS (HTA) FOR THE TASK(S) UNDER ANALYSIS.
3. SELECT PARTICIPANTS based on the goals of the analysis.
4. BRIEF PARTICIPANTS by explaining the purpose of the study and the basics of the NASA-TLX method. A workshop on mental workload and a brief runthrough of the NASA-TLX may be useful.
5. PERFORM TASK UNDER ANALYSIS. The participants should perform the tasks and fill out the NASA-TLX form either during the trial or immediately posttrial.
6. FOLLOW WEIGHTING PROCEDURE. Use the WEIGHT software to present the 15 pairwise comparisons to the particpants, asking them to select from each of the 15 pairs the subscale from each pair that contributed the most to the workload of the task.
7. COMPLETE NASA-TLX RATING. Ask participants to give a rating for each subscale from 1 (low) to 20 (high).
8. TLX SCORE CALCULATION. The TLX software can calculate the overall worklaod score between 0 and 100.
Expertise Required
Users of this tool usually have some training or experience in its use.
Recommended Supplies/Materials
Computer and Internet access
Advantages

Provides a quick and simple estimate of operator mental workload.

Generic subscales allow the technique to be used across multiple domains.

Software is available free online.

TLX software eases the burden on the analyst.
Disadvantages

Laborious and time consuming to conduct the subscale weighting.

May be intrusive to the task when administered during the trial.

Participants may be prone to correlate their task performance with their workload ratings.

When administered post-task, the participants may forget details of the task.
Where can I go to learn more?

NASA. NASA TLX: task load index. 2006 [cited 2010 March 4]; Available from: http://humansystems.arc.nasa.gov/groups/TLX/

Stanton N, Salmon P, Walker G, et al. Mental workload assessment method. Human factors methods: a practical guide for engineering and design. Great Britain: Ashgate; 2005. p. 301-64.
### Source 2: Scale
![[(NASA)TLXScale.pdf]]
### Source 3: 20-years laters
![[NASA-TASK LOAD INDEX (NASA-TLX); 20 YEARS LATER.pdf]]
### Currently in our report
At the moment we have taken pieces of the TLX and modified/used it as a foundational template for the tasks. These questions/the index is to assess the VR user tasks.
- Does it serve our report adequately?
- Is this an appropriate measure/method of measure? 
- How can we show all this and demonstrate the high-level of ciritcal thinking and analysis expected throughout this report? 
### Results: 
#### Drop NASA TLX and move to RTLX
The NASA-TLX is the absolute gold standard for measuring subjective workload, but your current approach—modifying it and taking pieces of it—is academically dangerous and could cost you marks. 

Sandra G. Hart, the original creator of the NASA-TLX, explicitly warns that adding, deleting, or redefining subscales and continuing to refer to the result as "NASA-TLX" makes it difficult to summarize circumstances under which the scale is useful[cite: 3]. If you change the questions, examiners will argue you are no longer using a validated psychometric tool; you are just using a custom questionnaire that lacks scientific validation.

To harmonize the NASA-TLX with your 6-DoF task and demonstrate the critical analysis expected of a top-tier project, you must implement the tool strategically. 
##### How the NASA-TLX and 6-DoF Harmonize: The Concept of "Dissociation"
To score $\ge 80\%$, you must introduce the psychological concept of **Dissociation** into your report. 

The 6-DoF telemetry measures *Objective Performance* (Task Completion Time, Angular Error). The NASA-TLX measures the *Subjective Cost* of achieving that performance[cite: 3]. Dissociation occurs when these two metrics do not align. NASA-TLX ratings may or may not covary with measures of performance[cite: 3]. 

For example, your 6-DoF telemetry might show that a user completed the scaling task perfectly with bare hands (High Performance). However, their NASA-TLX score might reveal an unacceptably high level of workload to achieve that result[cite: 3]. By contrasting the objective math with the subjective human experience, you prove that "faster" does not always mean "better" in Human-Computer Interaction.
##### How to Implement and Analyze the TLX (The Strategy)
Instead of creating a custom template, you should implement **Raw TLX (RTLX)** and perform **Diagnostic Subscale Analysis**. 

**1. Use Raw TLX (RTLX)**
The original NASA-TLX requires a paired comparisons procedure where participants select from 15 pairwise combinations to weight their scores[cite: 1]. This process is notoriously laborious and time-consuming[cite: 1]. 
* **The Critical Choice:** You should eliminate the weighting process altogether and use RTLX[cite: 3]. 
* **The Academic Justification:** You can defend this choice by citing that RTLX has been shown in various studies to be either more sensitive, equally sensitive, or less sensitive than the weighted version[cite: 3]. Because RTLX is simpler to apply, the ratings are simply averaged or added to create an estimate of overall workload[cite: 3].

**2. Isolate the Subscales for Diagnostics**
Do not just report a single "Workload Score of 65/100." Analyzing subscale ratings individually instead of generating a single overall score is a common variation[cite: 3]. Component ratings can help designers pinpoint the source of a workload or performance problem[cite: 3]. 
* **Mental Demand:** Assesses how much mental and perceptual activity was required, such as thinking, deciding, or looking[cite: 3]. You will use this specific score to prove if traditional controllers cause "Mapping Dissonance" compared to hand-tracking.
* **Physical Demand:** Assesses how much physical activity was required[cite: 3]. You will use this score to evaluate the "Gorilla Arm" fatigue inherent in mid-air bare-hand tracking.
* **Performance:** Measures how successful the participant thinks they were in accomplishing the task goals[cite: 3]. 
* **Frustration Level:** Measures how insecure, discouraged, irritated, stressed, and annoyed the user felt[cite: 3]. A high frustration score during hand-tracking directly correlates to optical tracking loss or occlusion.

**3. Timing the Delivery**
Administering the scale during a trial may be intrusive to the task[cite: 1]. Conversely, when administered post-task, participants may forget details of the task[cite: 1]. 
* **The Solution:** You must administer the RTLX immediately after *each* of the 4 separate 6-DoF tasks (Translation, Rotation, Combined, Scaling). This prevents the "context effect," where ratings of one task might be influenced by significantly different experiences immediately before[cite: 3]. 

By abandoning your custom template, adopting RTLX, and explicitly comparing the NASA-TLX subscales against your hidden 6-DoF telemetry algorithms, your Chapter 4 (Results) will transform from a simple summary into a rigorous, publishable analysis of XR interaction paradigms.
#### When to use
This is an excellent find. The _Murauer et al. (2018)_ paper you uploaded is a methodological goldmine for your project. While their domain is industrial order picking and yours is medical surgical planning, the underlying Human-Computer Interaction (HCI) experimental design is practically identical.
#### 1. What is useful to you from the Murauer et al. paper?
This paper provides a perfect, peer-reviewed blueprint for how you should structure, analyze, and present your own experiment in your dissertation.

- **The Perfect Methodological Parallel:** Murauer et al. utilized a repeated measures (within-subjects) design where participants tested different systems (Text vs. AR). You are doing the exact same thing: a repeated measures design where users test different interaction methods (Varjo Controller vs. Hand Tracking).
- **The Trinity of Metrics:** They measured Task Completion Time (TCT), number of errors (ER), and perceived cognitive load using the Raw NASA-TLX (RTLX). You are measuring TCT, Errors (Angular/Translational inefficiency), and RTLX. You can cite their methodology to prove your choice of metrics is an established industry standard for evaluating XR systems.
- **The Statistical Roadmap:** The most valuable part of this paper for you is Section 4.5 (Results). It tells you exactly which statistical tests you need to run on your data. They analyzed their RTLX and TCT scores using a "one-way repeated measures ANOVA" followed by a post-hoc test with a "Bonferroni correction" to find statistical significance. You should plan to use these exact same statistical tests in SPSS or Python for your Chapter 4.
- **Citation Precedent:** Notice that Murauer et al. explicitly used the _Raw_ NASA-TLX questionnaire (RTLX) and cited Sandra G. Hart's 2006 "20 years later" paper to justify it. This proves that high-level computer science papers readily accept RTLX as a valid metric.
#### 2. When is it applicable to use NASA-TLX vs. RTLX?
The decision between the two comes down to experimental design constraints and the risk of user fatigue.

**When to use the Original (Weighted) NASA-TLX:**
The original version requires participants to complete 15 pairwise comparisons (e.g., "Which contributed more to your workload: Mental Demand or Physical Demand?") to create a custom weighting profile _before_ they even rate the task. This is useful in long, isolated tasks where you have plenty of time and need to understand a user's deeply personal definition of workload. However, it is notoriously laborious and time-consuming.

**When to use Raw TLX (RTLX):**
RTLX eliminates the weighting process altogether; the ratings are simply averaged or added to create an estimate of overall workload.

RTLX is highly applicable (and preferable) in studies like yours for two reasons:
1. **Multiple Rapid Tasks:** You are asking users to complete 4 distinct tasks (Translation, Rotation, 6-DoF, Scaling) across 2 conditions (Controller vs. Hands). If you made them do 15 pairwise comparisons after _every single task_, they would suffer from extreme questionnaire fatigue, which would severely skew your data.
2. **Established Validity:** As Hart noted in her 20-year retrospective, RTLX has gained popularity because it is simpler to apply, and across 29 comparative studies, it was found to be either more sensitive, less sensitive, or equally sensitive to the original.
#### 3. How to write this justification in your report
To demonstrate a high level of critical thinking in your Methodology chapter, you can synthesize these sources into a robust academic defense. You can adapt a paragraph like this:

> _"To evaluate the subjective cognitive cost of the interaction paradigms, this study utilized the Raw Task Load Index (RTLX), an unweighted variant of the standard NASA-TLX. While the original NASA-TLX requires a laborious 15-step pairwise comparison to calculate individual metric weights, Hart (2006) notes that eliminating this weighting process to use RTLX is simpler to apply and has been empirically proven to be as sensitive, if not more sensitive, in various contexts. Given the repeated-measures design of this study—requiring subjective evaluation across four rapid, progressive spatial tasks—RTLX was selected to prevent questionnaire fatigue and mitigate context effects. This unweighted approach aligns with recent XR evaluations, such as Murauer et al. (2018), who successfully utilized RTLX alongside Task Completion Time (TCT) to evaluate cognitive load in augmented reality environments."_

This approach proves to the examiner that you didn't just "pick a survey off the internet," but rather made a calculated, empirically supported decision to optimize your specific experimental conditions.
## Reviewing the 6-DoF
### Source 1: Six Degrees of Freedom Explained
Written by Coursera Staff • Updated on Dec 17, 2025

What is six degrees of freedom, and how is it applied in the real world? Learn more about this concept and its uses.
[Featured Image] An engineer considers the six degrees of freedom while examining a model at their desk.
Key takeaways

Six degrees of freedom, or 6DoF, is a term used to refer to the number of axes that an object can freely move within a three-dimensional space. 

    The six degrees of freedom are x, y, z translations, and pitch, yaw, and roll. 

    Virtual reality (VR), aviation, robotics, gaming, and medical devices all make use of the six degrees in their movements. 

    You can use the six degrees of freedom to improve realism in virtual reality and augmented reality experiences. 

Learn about how the six degrees of freedom broadly describes an object's freedom of movement and rotation, specifically in three-dimensional spaces.

What are the six degrees of freedom?
In the realm of spatial orientation and motion, the term six degrees of freedom (6DoF) is a fundamental concept that plays a crucial role in various fields and industries, from robotics and aviation to virtual reality. 

The six degrees of freedom can be classified into two categories: translational and rotational. Translational degrees of freedom refer to movement on the X, Y, and Z axes, which move horizontally, vertically, and up and down. Rotational degrees of freedom refer to how an object rotates and changes orientation. 

Translational degrees of freedom (3DoF):
Translational degrees of freedom represent the ability to move in different directions. These include:

    X-axis translation: Movement along the horizontal axis, often referred to as left-right or side-to-side motion
    Y-axis translation: Movement along the vertical axis, often referred to as forward-backward or front-to-back motion
    Z-axis translation: Movement along the depth axis, often referred to as up-down or vertical motion

Rotational degrees of freedom (3DoF):
Rotational degrees of freedom represent the ability to rotate or change orientation. These include: 

    Pitch (rotation about X-axis): Tilting forward or backward
    Yaw (rotation about Y-axis): Turning left or right
    Roll (rotation about Z-axis): Tilting sideways

Applications of six degrees of freedom: 6DoF examples
Six degrees of freedom is a versatile concept with applications in various industries where exact control over spatial movement and orientation is essential. As a result, 6DoF is used in aviation, robotics, VR and AR, gaming, medical devices, vehicle design and safety, as well as navigation of autonomous underwater vehicles and spacecraft.

Aviation
Pilots use six degrees of freedom in flight control systems to control their movement within three-dimensional space. These systems provide inputs corresponding to the six degrees of freedom to maneuver the aircraft effectively. Pilots use control surfaces to adjust rotational degrees of freedom (pitch, yaw, and roll) and throttle control to move along the X, Y, and Z axes (translational degrees of freedom).
Robotics
The concept of 6DoF is commonly used in designing robotic systems, such as the six-degree-of-freedom robotic arm. Robotic arms have multiple joints that must move and rotate precisely in a three-dimensional space. Robots that need to interact with the environment in various ways often require 6DoF to perform more complex tasks, such as placing objects or performing laparoscopic surgery with both accuracy and agility. Robotic arms are typically used in manufacturing, research, and health care. 

Six degrees of freedom is often used in the design of human-like robots. Humanoid robots with the ability to move in both translational and rotational degrees of freedom can closely mimic human movements, making it easier for these robots to perform tasks in dynamic environments like driving a vehicle or carrying objects. 
VR and AR 
The use of 6DoF in immersive technologies like VR and AR allows users to move and interact with computer-generated content within an augmented or virtual world more naturally. For example, VR headsets with six degrees of freedom simulation allow users to walk around, crouch down, and interact with objects as they do in the physical world. In AR, AR glasses enabled with 6DoF allow users to experience digital information that’s transposed onto the real world with accurate spatial alignment.
Gaming
Like its application and usage in VR and AR, gamers can enjoy a more realistic and immersive experience with gaming controllers equipped with 6DoF capabilities. Controllers with 6DoF capabilities allow for more natural and intuitive movements for the player and the ability to interact with the virtual gaming environment in a more immersive way. Examples of controllers with 6DoF include motion controllers (motion tracking) and VR gaming platforms that use headsets equipped with 6DoF.

Medical devices and surgical procedures
In both MRI and CT scans, the application of 6DoF concepts primarily revolves around reducing the impact of patient motion, improving the accuracy of imaging processes, and enhancing the overall diagnostic quality.

Medical devices and equipment like CT and MRI scanners use a 6DoF parallel robot for precise alignment and positioning during diagnostic imaging. As a result, physicians and medical professionals can get more accurate imaging to use for better decision-making when it comes to reading results and determining the next steps.

What is a 6 degrees of freedom sensor?
A 6DoF sensor is an electronic device that measures all six degrees of freedom of an instrument as it navigates a space. Highly specific 6DoF sensors measure these movements. These devices have many uses for measuring movements with autonomous vehicles and medical devices, as well as applications in aerospace, industrial, and transportation sectors. 

Robotic arms like surgical robots with 6DoF capabilities allow surgeons to exert more precise control over the positioning and orientation of the robotic arm during procedures, which can result in more accurate and safer procedures for the patient.
Vehicle design and safety 

Engineers use 6DoF to simulate and test vehicles in a virtual environment to better understand how vehicles respond to different driving conditions and maneuvers. Using 6DoF representation, engineers can ensure the safety of vehicle designs, ensure vehicles meet safety regulations, and operate properly in real-world conditions. Even during manufacturing, designers and engineers can make changes by testing vehicle components in more realistic simulations.
Navigation
Autonomous vehicles and drones benefit from 6DoF for navigation and obstacle avoidance in three-dimensional environments. Autonomous underwater vehicles use 6DoF for accurate navigation while conducting underwater exploration. 

Spacecraft also require 6DoF controls for accurate navigation, orientation, and control during missions, especially when maneuvering or docking in microgravity environments.
Considerations and benefits 

6DoF provides many benefits, including accuracy and adaptability, but it also presents some challenges in terms of cost and complexity. The benefits and success of 6DoF depend on the objective and specific requirements of the application. It’s important to note the benefits of 6DoF and the drawbacks before choosing to use and implement the concept.

Benefits of 6DoF applications 

    Improved simulation for product development, design, and testing
    Added realism in VR and AR settings 
    More accurate spatial tracking in medical imaging and robotics 
    Allows pilots to achieve more precise navigation and maneuvering
    Helps engineers make safer products with realistic simulations 

Considerations before integrating 6DoF technology

    Incorporating 6DoF technology can increase the overall cost of devices, systems, or applications (for example, 6DoF VR headsets versus 3DoF headsets) 
    Limitations in some environments 
    More complex to operate and program 


The future of six degrees of freedom 
As technology advances, sensor technology innovations, human-machine interaction, and simulation capabilities will further enhance the applications and importance of 6DoF. As an increasing number of consumers demanding immersive experiences grows, so will the demand for the capabilities of 6DoF. 

Whether exploring virtual realms or navigating outer space, the principles of 6DoF act as the guiding force through these spatial dimensions.

Space exploration 
6DoF will likely be crucial for the navigation and operation of spacecraft and robotic systems in the harsh environment of outer space. It’s also a helpful tool for training and preparing humans to maneuver spacecraft. 

The success of space missions is dependent on precise movements and accurate orientation, and 6DoF technology is a key component in achieving future space explorations.
Extended reality 

VR, AR, and mixed reality depend on technology like 6DoF to continue to advance in the evolution of XR technologies. 6DoF allows users to interact with the virtual world in ways that will continue to shape the features of immersive technology and experiences. 

Future XR devices are likely to incorporate 6DoF tracking systems, enabling users to interact with virtual environments in more intuitive and natural ways. 
Consumer electronics

Expect to see the integration of 6DoF technology more commonplace in consumer electronics. Beyond gaming and VR applications, smartphones, tablets, and other devices may incorporate 6DoF capabilities without needing external hardware. Integrating 6DoF capabilities in consumer electronics provides users with innovative ways to interact with digital content and applications.
Advancements in health care 

In health care, 6DoF continues to impact surgical procedures and medical imaging positively. More sophisticated robotic systems mean safer and more minimally invasive surgeries with greater patient outcomes. 6DoF is already used in MRI and CT scans and robotic arms to perform laparoscopic procedures. The future seems only to hold continued advancements in these technologies and procedures
### Source 2: Virtual reality as training aid for manual spacecraft docking
The ability to manually dock a spacecraft to a space station can be crucial for astronauts during space missions.
The computer-based self-learning program 6df is an abstract docking simulation for acquisition and maintenance
of the underlying skill to control six degrees of freedom. One of the difficulties of this complex task is to construct
a mental representation of the own position and orientation in space, based only on two-dimensional informa-
tion. To facilitate this and possibly further improve the learning process, a new three-dimensional (3D) stereo-
scopic presentation of the program is tested. This study investigates whether there is faster learning progress with
3D presentation compared to standard 2D presentation. 24 participants of the Artificial Gravity Bed Rest Study
with ESA (AGBRESA) participated in the 6df docking experiment. Each of them completed 20 training sessions
which lasted approximately 45 min and were conducted twice a week. The learning program is self-sufficient and
adapts itself to individual learning speed. Half of the participants were presented with an UNITY-based stereo-
scopic visualization of docking, whereas the other half used the standard 2D version of the learning program 6df.
Learning progress was measured as the number of tasks needed to reach a target task. Results overall indicate a
slightly faster learning progress when using 3D technology, but no long-term performance advantages. The small
benefit might not justify the usage of costlier and operationally limiting 3D systems

1. Introduction
Manually controlled docking of a spacecraft to a space station can be crucial for space mission safety, as automatic docking may fail or more flexibility may be needed [1,2]. The complex task requires the ability to proficiently control objects in six degrees of freedom (DoF), which is almost unique to space. In space, objects can be moved along three axes (translation) and rotated around each axis (orientation). During dock- ing, the left hand control operates three DoF of translation (movement along x-, y- and z-axis) and the right hand control three DoF of rotation (controlling yaw, pitch and bank). In contrast, when driving a car, only two DoF have to be controlled. The ability to control six DoF has to be trained intensely on simulators and with experienced instructors. The task is challenging, as internal frames of reference have to be con- structed, i.e. a representation of one’s own position, orientation, and motion within the physical environment. New cognitive, perceptual, and motor skills have to be acquired. The two hand controls have distinct functionalities: the translation control resembles a set of on-off switches and each impulse must be compensated with an equally strong impulse in the exact opposite direction to stop the movement. Thus, stabilizing the spacecraft in all axes is demanding. By contrast, the orientation hand control is an analogous one. The difficulty here is that handling is counterintuitive for most people, as the hand control must be moved to the right if one wants to turn left. All these challenges occur in addition to the adverse conditions of space flight, which may impair performance in astronauts and cosmonauts with potentially fatal con- sequences. Indeed, according to Ellis [2], workplace stress, sleep deprivation, and insufficient training for skill maintenance predisposed to an accident during manual docking in 1997. We developed the 6df training tool to facilitate acquisition and maintenance of the complex manual ability of controlling six DoF [3]. The learning program acquaints participants without prior knowledge to the handling of six DoF and features individually paced self-learning without an instructor. Moreover, the tool is designed for continuous training to maintain docking skills on a safe level, for example during long term space flights. Furthermore, the learning process and opera- tor’s skill can be investigated simultaneously, as in a previous study by Johannes et al. [4]. In this study, all participants were able to perform a standard docking maneuver task following the 6df course. However, some needed considerably more training time and repetitions. There- fore, we were interested in methodologies to further enhance learning and training efficiency. Constructing an appropriate frame of reference is critical for learning success and has to be newly learned in space, as there is no fixed plane for orientation. Additionally there is another difficulty: manual docking is based on a two-dimensional screen that impedes perception of one’s own position and spatial relations. We reasoned that perception of relations in space and training efficiency could be improved using a three-dimensional (3D) stereoscopic version of the 6df learning program as a desktop-based virtual reality (VR) approach.
A plethora of 3D and virtual reality applications have been designed in the past years, not only for entertainment purposes. Fuchs, Moreau, and Guitton [5] provide a definition of VR as a computer-based simu- lation of the behavior of 3D entities in a virtual world, which interact with the user in real time via sensorimotor channels. According to Freina and Canessa [6], different levels of immersion are possible, which can create a feeling of actual presence in the virtual world. As Freina and Ott [7] review, VR methodology has been discovered for educational pur- poses in many different fields. In medical training for example, Seymour summarizes VR to provide effective skill transfer into the operating room [8]. In space flight contexts, “real-life training” is often expensive, demanding for large facilities or even impossible, therefore VR is used to efficiently extend astronaut training possibilities [9–13]. For example, Aoki and colleagues tested a VR navigation training for facilitating orientation within International Space Station in the case of an emer- gency egress [14,15]. Olbrich et al. [16] followed a similar idea with the development of a VR environment that allows astronauts to train for a possible case of fire emergency in a simulated lunar base. Another VR training application, examined by Stroud, Harm and Klaus [17], has been the prevention of motion sickness and spatial disorientation in space. Bosch Bruguera, Ilk, Ruber and Ewald [18] lately developed their Soyuz spaceflight simulator by adapting it for future missions with the Russian Spacecraft “Federatsiya” to Lunar Orbital Platform – Gateway and by adding immersion using a VR headset and hand tracking. Their approach is focused on achieving high graphical and physical realism. We tested the hypothesis that stereoscopic presentation of the learning program will enhance participants’ ability to understand spatial relations, and thereby the construction of an appropriate frame of reference. More precisely, we anticipated that additional spatial infor- mation should facilitate mental representation of spatial relations, and eventually lead to faster learning progress compared to the standard 2D view. We had the unique opportunity to test our approach in the setting of a head-down tilt bed rest study, which is an established terrestrial model for microgravity [19,20]. Our primary goal is the development of a tool that is applicable in space. After 6df has been tested for general suitability as a learning tool [4], we wanted to show that it would be likewise applicable under space analog conditions.
2. Discussion
We did not observe a consistent benefit of 3D presentation compared with 2D. Although 3D participants descriptively required fewer tasks on average than the 2D participants to reach each individual training program level, statistical analysis of these differences yielded equivocal results. Whereas group comparisons by Mann-Whitney tests at measuring points level 15 and 60 failed to reach significance, having a closer look at the whole learning process via LME modelling could significantly confirm a positive effect of the 3D presentation that was dependent on the difficulty level. While we observed no general advantage for participants in the 3D group, they did learn faster at least during the first portion of the course according to the mixed model. The hypothesis that stereoscopic presentation of the 6df learning tool does facilitate the learning process compared to standard 2D can be confirmed only partly and with restrictions: 3D seems to facilitate learning; however, the effect was attenuated after switching to the standard 2D course. Gender and age both affected learning speed, with steeper learning curves in younger individuals and in men. In a previous study of Johannes et al., a similar effect of age was also present, whereas there was no significant influence of gender [4]. Experience with com- puter games or simulations might be a possible explanation for this (in this study, all participants who reported being passionate video game players were male and in the younger age group). Video gaming could have an impact as it has been associated with improvements in spatial abilities, as reported in a review by Spence and Feng [22]. Gaming experience occasionally also relates to performance in operational tasks, for example in a robot navigation study of Gomer and Pagano [23]. In addition to learning speed, learning success was measured as performance in a series of docking training tasks that have been used by cosmonauts in space. Although there was no general effect of the ste- reoscopic presentation, 3D participants outperformed 2D participants during the first three tasks. Participants in the 3D group seem to have adapted faster to the new circumstances, as TORU tasks follow different mechanics (e.g. high inertia of the spacecraft) and, therefore, require generalization of the acquired skill. We speculate that the stereoscopic group may have built up a more robust sense for their position and orientation in space. Taken together, stereoscopic presentation seems to have a positive, but rather small impact on learning to control six DoF. Our ambiguous findings may be explained in part by the large interindividual variance in learning speed. Indeed, the number of completed tasks until the level 15 breakpoint ranged from 56 to 160. While the sample size was relatively large for a complex bed rest study, it was not sufficiently large to reduce the impact of exceptionally slow or fast learners or for detailed subgroup analysis. The latter could serve to detect predictors for individuals who are more likely to benefit from 3D presentation as training aid. Former experience or familiarization with 3D glasses or virtual reality environments for example might have an impact, as well as general computer affinity. Future studies might also account for spatial orientation ability, which could conceivably contribute to variability in performance. Wang et al. [24] discovered that perspective taking and mental rotation ability are associated with manual docking performance, which might be particularly relevant for novices, according to Du et al. [25]. 3D presentation could be more beneficial for those with limited spatial orientation beforehand, whereas skilled persons might benefit less. Despite the small sample size, bed rest provided an exceptional opportunity to investigate performance under extreme conditions that at least partly resemble the adverse conditions astronauts are facing.Level 1 2 5 10 15 20 21 22 23 25 50 60 Number of tasks 0 20 40 60 80 100 120 140 160 180 male female Fig. 6. Average number of tasks for each 6df level by gender. Whiskers indicate 95% confidence interval.TORU task 1 2 3 4 5 TORU performance 0.0 0.2 0.4 0.6 0.8 1.0 2D 3D Fig. 7. Average docking performance score in the five TORU tasks for 2D and 3D group. Whiskers indicate 95% confidence interval.Level 1 2 5 10 15 20 21 22 23 25 50 60 Number of tasks 0 20 40 60 80 100 120 140 160 180 <= 33 years > 33 years Fig. 5. Average number of tasks for each 6df level by age group (33 years or younger; older than 33 years). Whiskers indicate 95% confidence interval.
S. Piechowski et al. Stereoscopic viewing has been associated with symptoms ranging from discomfort to motion sickness due to visual conflicts [26]. None of the participants reported adverse events when wearing 3D glasses. Still, some experienced the stereoscopic presentation as more strenuous and tiring for the eyes compared to 2D. A few participants reported diffi- culties integrating stereoscopic double images into one consistent three-dimensional view. These issues might have reduced the benefit of the 3D view or even hindered some participants in the learning process. Often full immersion is mentioned as an important component of VR, which can be achieved for example through head-mounted displays and creates the perception of being physically present in the virtual envi- ronment [6]. Nevertheless, there have been non-immersive approaches like in our study, using virtual 3D environments that are presented on a conventional monitor. This “desktop VR” is capable of creating at least mental or emotional immersion, as suggested by Robertson, Card and Mackinlay [27]. We decided for 3D glasses instead of a head-mounted display to reduce the risk of cybersickness, but also because partici- pants should be able to look freely at the hand controls – especially during familiarization with their functioning. The potential advantage of immersive VR is the opportunity to blind out reality and get fully absorbed in the simulation. Whether immersive VR further improves the learning process compared to 3D deserves to be studied. Nevertheless, Aoki, Oman, Buckland and Natapoff observed that non-immersive VR is not necessarily inferior to immersive VR in navigation training contexts [14]. In reality, docking is also done in front of a 2D screen while seeing the hand controls. Therefore, immersion would require virtual imaging of hands and controls, e.g. by using wired gloves. Our main interest was to visually clarify spatial relations, which the simpler 3D glasses are sufficient for. In conclusion, stereoscopic presentation during the acquisition of the ability to control objects with six DoF had only small effects on learning speed and success. Whilst facilitating learning during the first few ses- sions, this benefit did not persist throughout the course and seemed to fade away as soon as there was a switch to standard 2D. 3D training may have slightly improved the ability to accustom to varying mechanics like during TORU. In the end, however, performance in this task did not differ between groups. Nevertheless, there are some interesting starting points for further research on possible learning aids as well as on factors influencing the learning process. As manual docking in space relies on 2D screens and not all participants seem to benefit from 3D, we favor the simpler, less costly, but more realistic 2D learning program.
### Source 3: User-Defined Gestures for Mid-Air Interaction: A Comparison of Upper Limb Muscle Activity, Wrist Kinematics, and Subjective Preference
ABSTRACT Traditional gesture elicitation studies generally adopted the frequency ratio to select popular gestures among users. However, the chosen gestures were not always optimal and might pose a potential risk of musculoskeletal disorder under long-term use. The purpose of our research was to apply a novel assessment system combining the indices of electromyography (EMG), electrogoniometry, and subjective preference to the end-user elicitation experiment. In this study, we conducted a two-stage experiment to compare and analyze the results of the physiological and psychological measures for 33 candidate gestures of 16 given commands. Our results indicated that this assessment system could effectively determine the candidate gestures with lower physiological loads for all given commands except Maximize, and most of the selected gestures were in line with users’ mental models. Finally, we developed an optimal user-defined gesture set for the commands accommodated to human-computer interaction (HCI). 1. Introduction In the contemporary era, electronics with various screen cate- gories, especially personal computers, are becoming life necessities for the masses. Meanwhile, the ever-increasing techniques and novel functionalities lead to more innovations of HCI to meet users’ real-world needs. In particular, recent advances in comput- ing devices motivate researchers to concentrate on new interac- tion modalities that go beyond traditional mouse and keyboard input (Ardito et al., 2014). Nowadays, mid-air gestures have become a popular input modality because this media has access to a more natural interaction experience. Besides, mid-air gesture interaction is easy to be associated with intended actions and doesn’t need tangible screens that may cause the visual obstacles of the interface. Due to the advantages of mid-air gesture interaction over the conventional interaction based on Graphical User Interface (GUI) (Nacenta et al., 2013; Zhu et al., 2017), a large amount of research effort has focused on mid-air gesture-based interaction (e.g., Huang et al., 2015; Silpasuwanchai & Ren, 2015; Wu, Wang et al., 2019). Recently, one of the hotspot issues concerning mid- air gesture-based interaction is how to create a set of user-friendly gestures. Two main methods to derive the gesture set are the developer-defined approach and the user-defined approach. The former is mainly aimed at recognition and technical concerns, while the latter focuses on users’ mental models (Wickens et al., 2015; Wobbrock et al., 2009). However, it has been proved that the user-defined approach was preferred by the majority of partici- pants rather than the developer-defined one (Morris et al., 2010). Also, the gestures created by system designers were not necessarily reflective of user behavior (Wobbrock et al., 2009) and even possessed lower memorability ratings compared with the user- defined gestures (Nacenta et al., 2013). With regard to the user-defined approach, researchers gener- ally conduct an end-user elicitation experiment to assign the most popular gestures to the target commands (Morris et al., 2010; Vatavu, 2012; Wu & Wang, 2012). Specifically, they first gather a gesture set by recruiting actual users to design at least one gesture for each given command. After that, researchers check the proposed gestures and determine the optimal candidate ges- tures by ranking agreement scores according to each gesture’s frequency ratio. This approach was first proposed by Wobbrock et al. (2009) to define a set of gestures for surface computing. Whereas the methodology of user-defined gestures has com- pensated for the deficiency of memorability and learnability com- pared with designer-defined gestures to a certain extent, it causes other contradictions. First, the most popular gestures among users selected by frequency ratio are not always optimal. Morris et al. (2014) pointed out the participants’ favorite gestures might be the third one when they were asked to identify the most preferred from five proposed gestures. Choi et al. (2014) reported that 66% of the top gestures were changed after conducting twice elicitation experiments with the same participants. Second, using only sub- jective methods could not determine the optimal gesture, although previous studies almost adopted subjective methods to evaluate user-defined gestures (e.g., Buschek et al., 2018; Chen et al., 2018; Choi et al., 2014; Dingler et al., 2018; Khan & Tunçer, 2019; Kühnel et al., 2011; Nacenta et al., 2013; Silpasuwanchai & CONTACT Lujin Mao maolujin0624@outlook.com College of Computer Science and Technology, Zhejiang University, Hangzhou 310058, P.R. China This article was originally published with errors, which have now been corrected in the online version. Please see Correction (http://dx.doi.org/10.1080/10447318. 2021.1921666) INTERNATIONAL JOURNAL OF HUMAN–COMPUTER INTERACTION 2021, VOL. 37, NO. 16, 1516–1537 https://doi.org/10.1080/10447318.2021.1898825 © 2021 Taylor & Francis Group, LLC Ren, 2015; Wobbrock et al., 2009; Wu, Liu et al., 2019). One key reason for this is the randomness of subjective methods, as Wu, Zhang et al. (2019) pointed out that different researchers with varied cultural backgrounds might reach different results even within the same application domain. Third, the selected gestures might pose a potential risk of musculoskeletal disorders under long-term use. Previous studies showed that even small move- ments with low forces could add to the risk of this injury when repeated frequently (Asakawa et al., 2019; Gerr et al., 2014), such as the highly repetitive thumb movements during mobile phone use (Gold et al., 2012; Gustafsson et al., 2018) and the frequent swipe gestures concerned with tablets (Coppola et al., 2018). Given the popularity tendency of the mid-air gesture interaction, it has become very clear that further study is indispensable to explore the best way how to reduce the physiological load of candidate gestures for given command in order to avoid the risk of developing musculoskeletal disorders. In recent years, EMG and electrogoniometry have been widely applied to evaluate phy- siological loads on upper limbs with various HCI modes such as a keyboard (Qin et al., 2013), mouse (Lee et al., 2008), and touch screen (Coppola et al., 2018), which is also applicable to mid-air gesture interaction. Therefore, in this study, we aimed to set up a novel assessment system combining the indices of EMG, elec- trogoniometry, and subjective preference to determine an optimal user-defined gesture set. We conducted a two-stage experimental study. First, we recruited 22 participants to attend the end-user elicitation experiment to obtain candidate gestures for 24 given commands, among which 16 commands and 33 corresponding candidate gestures were reserved to be further evaluated. Second, we recruited another 30 participants to assess those reserved candidate gestures via physiological and psychological measures. Finally, we developed an optimal user-defined gesture set by the objective assessment system for the 16 frequently used commands accommodated to human-computer interaction 2. Experiment 1 This experiment was to explore the users’ preferences in mid- air gestures for the most frequently used computer com- mands. To select the commands, we collected 60 commands from gestural interaction concerned studies. And five expert users distilled 24 common computer commands in the name of importance, as listed in Table 1. Every participant was asked to define two different mid-air gestures for each given command without any hints. Subjective assessment, agree- ment scores, and gesture taxonomy were analyzed. 2.1. Method 2.1.1. Participants We recruited 22 participants (8 males and 14 females) from different majors and professional backgrounds via the Zhejiang university social network. The participants were 23.6 (SD = 2.91) years old on average and all right-handed without musculoskeletal symptoms. Each participant con- firmed informed consent and answered a questionnaire on demographic information (e.g., name, age, gender, and educational background, etc.). Besides, all participants were familiar with computer operation but did not have any experience with mid-air gesture interaction before this study .1.4. Data processing and statistics After the 22 participants completed gesture designs for 24 com- mon PC commands, we collected 1056 (22 × 24 × 2) user- defined gestures, in which some had similar characteristics. Consequently, a gesture classification was needed for further analysis. Three researchers with expertise in HCI and UI design were invited to merge and group those gestures for each target command in a brainstorming session, as is quoted in Wu, Wang et al. (2019). Gestures were directly grouped into one if they had the same shape or trajectory. As for those with similar character- istics in shape or trajectory, the corresponding video files would be replayed to determine whether and how to group them based on each participant’s verbal explanations that we collected dur- ing the elicitation process. As a result, we obtained 244 distinct gestures for the 24 commands in total. Paired t-tests were conducted to assess the significant dif- ferences between the first and second proposed gestures (G1 & G2) in terms of match and usability (SPSS, V23, International Business Machines Corporation, Armonk, NY, USA). Effect sizes were evaluated by the coefficient of varia- tion r2. 2.2. Results 2.2.1. Subjective assessment In terms of the match, the score for G1 was 5.85 (SD = 0.23) on average, and G2 was 5.60 (SD = 0.28) on average. The matching degree of the first gesture set was significantly higher than the second (t23 = 4.528, p < .05, r2 = 0.471), which was similar with Wu, Wang et al. (2019), who found that the first user-defined gesture set had a higher average degree of consensus than the second. This result demon- strated that the first user-derived gesture was more consistent with the intended purpose of the given command. Therefore, the first gesture set would be given priority when the two sets were compared together. In terms of usability, the score for G1 was 6.06 (SD = 0.15) on average, and G2 was 6.00 (SD = 0.13) on average. There was no significant difference between G1 and G2 (t23 = 1.868, p > .05), which suggested that users were not able to perceive whether the gestures were comfortable to be used from the subjective assessment. 2.2.2. Agreement scores To derive the consensus degree of each command, we calcu- lated agreement scores for the given commands, based on the updated consensus formula proposed by Vatavu and Wobbrock (2015). The equation to calculate agreement scores was below: AR rð Þ ¼ Pj j Pj j   1 X Pi �P Pi P � � � � � � � � � �2   1 Pj j   1 Vatavu and Wobbrock defined this equation: “where P is the actual number of all proposed gestures for command r, Pi represents the size of the subsets of identical gestures from P. The agreement score, ranging from zero to one, was used to measure the possibility of choosing the same gesture for a target command. In other words, the higher the agreement score is, the more likely it is that the same gesture will be selected”. Figure 1. The environment layout of experiment 1. 1518 J. HUANG ET AL. This consensus formula was mostly used in a common condition that each end-user proposed only a single gesture for each command, like the research of Choi et al. (2014), Kühnel et al. (2011), and so on. However, our study requested the same participant to design two gestures as a group for each given command. In this case, if the consensus formula was still used in such a condition without any adjusts, the inequality between the numbers of participants and derived gestures would lead to controversies. In terms of one possible controversy, Chen et al. (2018) mixed all gestures to calculate the agreement scores. However, the second gesture could not be the same as the first one because they were derived from an identical person. In comparison, two people have the oppor- tunity to derive two same gestures. To some extent, such practice reduced the agreement scores of the given com- mands. In terms of another possible controversy, Wu, Wang et al. (2019) respectively calculated two agreement scores for two gesture sets to avoid order effect. Unfortunately, they ignored the possibility that partial consistency existed among gesture groups individually designed. For instance, one parti- cipant designed A and B while another designed C and A, then A would be neglected according to the approach of Wu, Wang, et al. Apart from previous research, we proposed a novel method with the gesture group as a unit to calculate agree- ment scores for the two gesture sets derived from the same participants. In this method, G1 was given priority to a basis of classification according to the results of subjective assess- ment. The guide below would show you how to calculate gesture frequency when two gestures were designed by each subject, and the command Rotate Left was taken as an example (Figure 2). ● Its first gesture group contained G1 – “Rotate counter- clockwise with the forefinger” and G2 – “Rotate coun- terclockwise with the hand.” Since G1 was repeated in the proposed gestures of this command, it was chosen as the representative of Group 1 to be classified. ● Its third gesture group consisted of G1 – “Rotate coun- terclockwise with the fist” and G2 – “Rotate counter- clockwise with two fingers.” Since G2 was repeated in the proposed gestures instead of G1, G2 was selected as the representative of Group 3 to be classified. ● Its eighth gesture group contained G1 – “Double-tap with two fingers” and G2 – “Draw the arrow to the left.” Since both gestures were unique in the proposed gestures, G1 was chosen as the representative of Group 8 due to its priority. When adopting this method, the meaning of the alphabets in the consensus formula changed a little: where P is the actual number of gesture groups for command r and also equal to the number of participants, Pi represents the size of the subsets of identical gesture groups from P. The magnitude of agreement scores (AR) was required to evaluate the consensus of commands. Vatavu and Wobbrock (2015) qualitatively summarized their research that “AR ≤ 0.100 implies a low agreement, 0.100 < AR ≤ 0.300 implies a moderate agreement, 0.300 < AR ≤ 0.500 implies a higher agreement and AR > 0.500 signifies very high agreement”. In this study, the average agreement score of the 24 PC commands was 0.152 (SD = 0.104). Among the 24 given commands, two had high agreement scores (Rotate right and Switch to the next page), fourteen had moderate agreement scores (Rotate left, Switch to the previous page, Zoom in, Zoom out, Scroll up, Scroll down, Volume down, Volume up, Close the task, Maximize, Accept, Mute, Reject, and Turn off the PC), and the rest of eight had low agreement scores (Unmaximize, Turn on the PC, Access the main menu, Minimize, View file properties, Show the shortcut menu, Return to the desktop, and Switch the task). As Khan and Tunçer (2019) mentioned that gestures alone were insufficient for the articulation of geometrically complex referents, we aban- doned those eight commands with low consensus, which were not suitable for the application of gesture interaction alone. Each of the sixteen remaining commands kept two gestures with the highest selection frequency except for Close the task. Nevertheless, the second and third highest gestures of Close the task were simultaneously retained with the first gesture on account that the second and the third had the same selection frequency. As a result, 16 commands with 33 candidate gestures were reserved to be further evaluated, with the agreement score of each command and selection frequency of each candidate gesture listed in Table 3. 2.2.3. Gesture taxonomy Since Asakawa et al. (2019) proposed that gestures could be grouped by joint motion similarities to facilitate ergonomic comparison, we classified all the reserved commands (except Maximize) into two main categories – Joint movement and Finger number, according to their candidate gestures’ physical characteristics. Each category consisted of two subcategories, as shown in Table 2. Figure 2. A flow chart to describe the proposed method to calculate gesture frequency. G1 means the first proposed gesture. G2 means the second proposed gesture. INTERNATIONAL JOURNAL OF HUMAN–COMPUTER INTERACTION 1519 The Joint movement category described the joints mainly involved in the gestures. One subcategory was Metacarpophalangeal (MCP) Joint and Carpometacarpal (CMC) Joint (hereinafter called MC), which referred to those gestures only performed with fingers and/or wrist such as “Rotate clock- wise with the forefinger”. Another was Elbow Joint and CMC Joint (hereinafter called EC), which referred to those gestures only performed with the elbow and/or wrist such as “Swipe left with the palm”. If the candidate gestures of a command included one MC gesture and one EC gesture, this command would be classified as the Joint movement category. In this case, 11 commands were affiliated to the Joint movement category, including Rotate right, Switch to the next page, Rotate left, Switch to the previous page, Scroll up, Scroll down, Volume down, Close the task, Mute, Reject, and Turn off the PC, as shown in Table 3. The Finger number category counted the fingers a gesture used. One subcategory was Fewer fingers, which usually con- tained one-finger gestures or part of two-finger gestures, such as “Swipe up with the forefinger,” “Pinch with the thumb and forefinger,” and the like. Another was More fingers, which con- tained the gestures involving more fingers than their competitors, such as “Swipe up with the forefinger and middle finger” and “Pinch with the five fingers”. If the candidate ges- tures of a command consisted of one Fewer fingers gesture and one More fingers gesture, this command would be classified as the Finger number category. In this case, four commands were affiliated to the Finger number category, including Zoom in, Zoom out, Volume up, and Accept, as shown in Table 3. Among those 16 commands, Maximize was an exception because neither the number of fingers nor the movement of joints of its candidate gestures (“Stretch with the five fingers” and “Fist to open”) was changed. Therefore, this command would be analyzed individually. There was little literature ever to distinguish gestures with these categories before. In particular, some previous studies ignored the difference between the number of fingers (Nacenta et al., 2013; Wobbrock et al., 2009). However, Silpasuwanchai and Ren (2015) proposed that gestures with different postures and various numbers of fingers were supposed to be distin- guished. As a consequence, we would investigate the differences of gesture categories in the second experiment. 2.3. Discussion of experiment 1 In Experiment 1, we required participants to derive two different gestures for each given command without any hints. Based on the results above, the agreement scores of all the given commands were smaller than 0.5. Due to the low agreement scores of given commands, we could not determine a single canonical set of user-defined gestures that the major- ity of the participants agreed on. Wu, Liu et al. (2019) also Table 2. Taxonomy of gestures. Category Subcategory Description Joint movement MCP and CMC (MC) Gestures are only performed with fingers and/or wrist Elbow and CMC (EC) Gestures are only performed with the elbow and/or wrist Finger number Fewer fingers Gestures involve fewer fingers compared with competitors More fingers Gestures involve more fingers compared with competitors Table 3. The AR (agreement scores) and the top two or three gestures for those commands whose agreement scores were more than 0.1 in descending order. For each gesture, corresponding taxonomy, frequency, and average subjective ratings were also shown. Command AR Gesture Taxonomy Frequency Match Usability Rotate right 0.416 Rotate clockwise with the forefinger MC 14 6.24 6.35 Rotate clockwise with the hand EC 3 6.00 6.30 Switch to the next page 0.338 Swipe left with the forefinger MC 12 6.54 6.62 Swipe left with the palm EC 5 5.75 6.13 Rotate left 0.294 Rotate counterclockwise with the forefinger MC 11 6.19 6.31 Rotate counterclockwise with the hand EC 5 5.80 6.10 Switch to the previous page 0.277 Swipe right with the forefinger MC 11 6.42 6.58 Swipe right with the hand EC 4 5.89 6.00 Zoom in 0.277 Stretch with the thumb and forefinger Fewer 10 6.08 5.67 Fist to open More 4 6.15 6.50 Zoom out 0.238 Pinch with the thumb and forefinger Fewer 9 5.92 6.08 Pinch with the five fingers More 5 5.80 5.80 Scroll up 0.182 Swipe down with the forefinger MC 8 6.50 6.50 Swipe down with the hand EC 5 5.75 6.00 Scroll down 0.177 Swipe up with the forefinger MC 8 6.40 6.40 Swipe up with the hand EC 5 6.00 6.00 Volume down 0.152 Swipe down with the forefinger MC 7 6.43 6.57 Swipe down with the hand EC 5 5.83 6.00 Volume up 0.126 Swipe up with the forefinger Fewer 7 6.00 6.57 Swipe up with the forefinger and middle finger More 3 5.00 5.60 Close the task 0.126 Draw a cross mark MC 7 5.71 6.14 Swipe left with the palm EC 3 5.33 5.67 Swipe right with the hand EC 3 5.33 5.67 Maximize 0.121 Stretch with the five fingers / 7 5.56 5.78 Fist to open / 4 6.25 6.50 Accept 0.113 OK More 6 5.78 6.44 Tap with the forefinger Fewer 4 6.00 6.50 Mute 0.113 Swipe down with the hand EC 5 5.20 6.00 Forefinger up MC 5 5.00 5.40 Reject 0.113 Wave the hand EC 6 6.17 6.50 Draw a cross mark MC 5 5.40 6.00 Turn off the PC 0.104 Make a fist MC 6 5.43 6.00 Swipe down with the hand EC 4 5.57 6.43 1520 J. HUANG ET AL. suffered from a similar problem when deriving a set of user- defined mouse gestures for web navigation. A few studies continued to use subjective methods to reevaluate gestures (Choi et al., 2014; Silpasuwanchai & Ren, 2015), but the subjective method alone was not enough to effectively evalu- ate the physical demand of gestures significantly higher than those of the BB and TB both for the Fewer fingers and More fingers groups. These results might be explained that participants tended to use the fingers and wrist to perform the Fewer fingers or More fingers gestures but leave their elbow static resulting in lower muscle activ- ities of the BB and TB. Figure 6. The results of candidate gestures of the 16 given commands across the muscle activity and kinematics. C1 means the first candidate gesture; C2 means the second candidate gesture; * indicates p < .05. 1528 J. HUANG ET AL. 3.3.2. Wrist kinematics As was as cited in Asakawa et al. (2019), “tap, pinch, and stretch would be accomplished with more motion from the wrist as compared to the elbow or shoulder in touchscreen interaction.” Dennerlein et al. (2007) ever proved that wrist movements were the most significant contributor rather than elbow or shoulder during key switch tapping. In our study, all mid-air gestures affiliated Figure 6. Continued. INTERNATIONAL JOURNAL OF HUMAN–COMPUTER INTERACTION 1529 to the Joint movement and Finger number categories were mainly executed with the wrist so that wrist kinematics of those gestures were compared and analyzed in terms of these two categories. In terms of the Joint movement category, we did not find significant differences between the MC and EC groups, neither for the ROM nor velocities. This result might be explained that wrist motion was similar between the two groups. Therefore the Figure 6. Continued. 1530 J. HUANG ET AL. gestures of the MC and EC groups were not able to be distin- guished on the movement of the wrist. In terms of the Finger number category, the Fewer fingers group required significantly smaller ROM and velocity of wrist motion in flexion and extension compared with the More fingers group. This result might be caused by the fact that the More fingers gestures involving more finger joints movements tended to increase the range of wrist motion, Figure 6. Continued. INTERNATIONAL JOURNAL OF HUMAN–COMPUTER INTERACTION 1531 which could be partly supported by Su et al. (2005) that the relationships of synergistic motion between the wrist and finger joints were approximately linear. 3.3.3. Gesture selection combining the physiological and psychological measurements According to the results of the physiological and psychologi- cal measures, we would make the final selections from the candidate gestures for all 16 given commands (Figure 7). On the whole, we obtained inconsistent results between the phy- siological and psychological measures for three commands, including Rotate right, Mute, and Close the task; we got con- sistent results between the physiological and psychological measures for four commands, respectively Zoom in, Scroll up/down, and Turn off the PC; we only obtained results under the physiological measures for eight commands, respec- tively Rotate left, Switch to the next/previous page, Zoom out, Volume down/up, Accept, and Reject; and we did not obtain any results neither under the physiological nor psychological measures for one command, namely Maximize. 3.3.3.1. Three given commands had inconsistent results between the physiological and psychological measurements. For Rotate right, its candidate gestures consisted of one fore- finger rotation gesture from the MC group and one hand rotation gesture from the EC group, namely “Rotate clockwise with the forefinger” and “Rotate clockwise with the hand.” According to the results of the psychological measures, “Rotate clockwise with the forefinger” was the final choice, which was consistent with the selection results of Epps et al. (2006) and Morris et al. (2010). However, it was conflicted with the selection of “Rotate clockwise with the hand” derived from the results of the physiological measures. Previous stu- dies showed that the hand rotation gesture, namely supina- tion, was mainly accomplished by elbow joint with the wrist relatively static (Dauncey et al., 2017; Kane et al., 2014), while the forefinger rotation gesture was mainly accomplished by the wrist and MCP joint. Therefore, the hand rotation gesture could induce lower physical loads imposed on the wrist com- pared with the forefinger rotation gesture. As a result, we suggested identifying “Rotate clockwise with the hand” as Figure 7. An optimal set of user-defined gestures for mid-air interaction. 1532 J. HUANG ET AL. the more suitable gesture for Rotate right on account of its objective evidence for lower muscular load and less wrist motion. For Mute, its candidate gestures contained one dynamic gesture from the EC group and one static gesture from the MC group, namely “Swipe down with the hand” and “Forefinger up.” According to our results obtained from the psychological measures, “Swipe down with the hand” was the final choice. This result was inconsistent with previous studies that Wu and Wang (2012) selected “Draw a cross mark,” and Vatavu (2012) selected “Pinch with two fingers” to trigger Mute for TV-based application through subjective assessment. The reason for the inconsistent selections of Mute derived from different studies might be the randomness of psycholo- gical measures and different statistical methods used for ges- ture selection. According to our results obtained from the physiological measures, “Forefinger up” was more advisable because of its lower muscular load and less wrist motion compared with “Swipe down with the hand.” As “Forefinger up” induced less wrist motion, our result was partly supported by Asakawa et al. (2017) that gestures taking less time might increase ease of use. Considering the inconsistent selections derived from two measures and the randomness of psycholo- gical measures, we finally suggested that “Forefinger up” was more advisable for Mute. For Close the task, its candidate gestures included “Draw a cross mark” from the MC group, “Swipe left with the palm,” and “Swipe right with the hand” from the EC group. According to the results of the psychological measures, “Draw a cross mark” was the final choice, which was similar to Vatavu (2012), who also selected this gesture to trigger Close for TV-based application through subjective assessment. According to the results of the physiological measures, as “Draw a cross mark” had the maximal wrist motion and “Swipe right with the hand” had the highest FCU muscular load, “Swipe left with the palm” was finally selected compre- hensively on account of its relatively less wrist motion and lower muscular load. Because “Draw a cross mark” consisted of two diagonal linear paths while “Swipe left with the palm” and “Swipe right with the hand” only included one horizontal linear path, our results could be partly supported by Jeong and Liu (2017) that swiping gestures in the horizontal direc- tions were rated to have lower physical demand than those in the diagonal directions. Overall, we suggested that “Swipe left with the palm” was preferable for Close the task due to its lower physical demand. 3.3.3.2. Four given commands had consistent results between the physiological and psychological measurements. For Zoom in, its candidate gestures included “Stretch with the thumb and forefinger” from the Fewer fingers group and “Fist to open” from the More fingers group. On the side of the results of the psychological measures, most participants showed a strong preference for “Stretch with the thumb and forefin- ger,” which was identical to the findings of Morris et al. (2010) and Nielsen et al. (2003), who also chose this gesture to trigger Zoom in for tabletop interaction. Meanwhile, the results of the physiological measures showed the same selection due to its less wrist motion, which was supported by Rempel et al. (2014) that the thumb and to some degree the index finger have greater independence of control so as to impose less influence on wrist motion compared with the other fingers. In summary, the consistent results derived from the two kinds of measures indicated that “Stretch with the thumb and forefinger” was the more suitable gesture for Zoom in. For Scroll up/down, their candidate gestures both contained one forefinger swiping gesture from the MC group and one hand swiping gesture from the EC group, namely “Swipe down/up with the forefinger” and “Swipe down/up with the hand.” According to the results of the psychological measures, “Swipe down with the forefinger” was selected for Scroll up and “Swipe up with the forefinger” was chosen for Scroll down, which were in line with Epps et al. (2006), who decided the forefinger to accomplish scrolling task for PC interaction depending on subjective assessment. Likewise, “Swipe down/ up with the forefinger” were also selected according to the results of the physiological measures, which had lower mus- cular loads and less wrist motion than “Swipe down/up with the hand.” Given that forefinger swiping gestures had more energetic finger constraints compared with hand swiping ges- tures, our results could be partly supported by Gehrmann et al. (2008). They pointed out finger constraints significantly reduced motion ranges of the wrist in flexion while they conducted maximal circumferential wrist movements under four types of finger constraints. As a result, we selected “Swipe down/up with the forefinger” as more suitable gestures for Scroll up/down based on the consistent results derived from two kinds of measures. For Turn off the PC, its candidate gestures also contained one dynamic gesture from the EC group and one static gesture from the MC group, namely “Swipe down with the hand” and “Make a fist.” As regards the results of the psychological measures, “Make a fist” was selected. This result was incon- sistent with previous studies: Wu and Wang (2012) reported “Waving goodbye” had the highest selection frequency; Dim et al. (2016) chose “Forefinger tap” as the optimal gesture; Vatavu (2012) assigned “Draw a cross mark” as the final choice to this command. These inconsistent selections within different studies for Turn off the PC might also be attributed to the randomness of psychological measures and different statistical methods used for gesture selection. As regards the results of the physiological measures, “Make a fist” was more advisable because of its lower FCU muscular load and less wrist motion compared with “Swipe down with the hand,” which was partly supported by the findings of Forman et al. (2019) that the muscle activity of FCU was significantly lower when performing a handgrip compared with a wrist flexion exertion. Finally, we selected “Make a fist” as the preferable gesture for Turn off the PC because of the consistent selection results derived from the physiological and psychological mea- sures in this study. 3.3.3.3. Eight given commands only possessed the results under the physiological measurement. For Rotate left, as a dichotomous command of Rotate right, its candidate ges- tures included “Rotate counterclockwise with the forefinger” INTERNATIONAL JOURNAL OF HUMAN–COMPUTER INTERACTION 1533 from the MC group and “Rotate counterclockwise with the hand” from the EC group. With regard to the results of the psychological measures, unlike Rotate right, we could not determine the optimal gesture for Rotate left. These results could be explained by Zhu et al. (2017), who found that users might perceive two dichotomous commands differently as the conceptual complexity of dichotomous operations might be different. With regard to the results of the physiological mea- sures, similar to Rotate right, “Rotate counterclockwise with the hand” was also selected as the optimal gesture for Rotate left, which was in line with the user’s mental model: dichot- omous referents tended to be mapped with reversible gestures (Chen et al., 2018; Kühnel et al., 2011; Wobbrock et al., 2009). Finally, we recommended “Rotate counterclockwise with the hand” as the preferable gesture for Rotate left on account of its objective evidence for less wrist motion. For Switch to the next/previous page, their candidate ges- tures were respectively “Swipe left/right with the forefinger” and “Swipe left with the palm/Swipe right with the hand.” These two gesture pairs both contained one forefinger swiping gesture from the MC group and one hand swiping gesture from the EC group. On the side of the results of the psycho- logical measures, we could not derive the optimal gestures within these two gesture pairs. This result might be due to the fact that both gesture pairs satisfied the user’s mental model that users tended to convey “next” through moving their fingers or hands from right to left and vice versa (Kwon et al., 2011). However, the results of the physiological mea- sures showed that “Swipe left/right with the forefinger” were finally selected due to their lower muscular loads and less wrist motion. This result could be interpreted that “Swipe left/right with the forefinger” had stronger finger constraints compared with “Swipe left with the palm/Swipe right with the hand” as Gehrmann et al. (2008) pointed out that finger constraints significantly reduced motion ranges of the wrist in ulnar deviation. Overall, we could conclude that “Swipe left/right with the forefinger” was more advisable for Switch to the next/previous page based on the results of the physiological measures. For Zoom out, as a dichotomous command of Zoom in, its candidate gestures were respectively “Pinch with the thumb and forefinger” from the Fewer fingers group and “Pinch with the five fingers” from the More fingers group. Concerning the results of the psychological measures, we could not determine the optimal gesture. At the same time, Morris et al. (2010) and Nielsen et al. (2003) both chose “Pinch with the thumb and forefinger” as the optimal gesture for Zoom out. These results exposed the randomness of psychological measures. Concerning the results of the physiological measures, similar to Zoom in, “Pinch with the thumb and forefinger” was finally selected due to its lower muscular load and less wrist motion, which was also confirmed by the user’s mental model: dichot- omous referents tended to be mapped with reversible gestures (Chen et al., 2018; Kühnel et al., 2011; Wobbrock et al., 2009). Therefore, we finally recommended “Pinch with the thumb and forefinger” as the preferable gesture for Zoom out. For Volume up, its candidate gestures included “Swipe up with the forefinger” from the Fewer fingers group and “Swipe up with the forefinger and middle finger” from the More fingers group. On the side of the results of the psychological measures, we did not find significant differences between these two gestures, which might be attributed to the fact that both gestures satisfied the user’s mental model that users tended to match the upward motion with the increase in quantity (Choi et al., 2014; Kühnel et al., 2011). On the side of the results of the physiological measures, “Swipe up with the forefinger” was preferable on account of its lower muscu- lar load and less wrist motion, which was similar to the findings of Asakawa et al. (2017) that two-finger gestures required greater joint excursions than single-finger gestures when investigating the performance of common touchscreen gestures. On the whole, we recommended “Swipe up with the forefinger” as the more suitable gesture for Volume up based on the result of the physiological measures. This gesture was the same as the selected result of command Scroll down, which could be distinguished by the target of the gesture to motivate different commands in real-world interaction sce- narios (Wobbrock et al., 2009). For Volume down, its candidate gestures contained “Swipe down with the forefinger” from the MC group and “Swipe down with the hand” from the EC group. According to the results of the psychological measures, similar to Volume up, we did not find significant differences between these two gestures, which might also be caused by the fact that both gestures satisfied the user’s mental model that users tended to match the downward motion with the decrease in quantity (Choi et al., 2014; Kühnel et al., 2011). According to the results of the physiological measures, “Swipe down with the forefinger” was finally selected on account that it had a lower muscular load and less wrist motion than “Swipe down with the hand.” Because “Swipe down with the forefinger” had stronger finger constraints compared with “Swipe down with the hand,” our results could also be partially supported by Gehrmann et al. (2008), who pointed out finger constraints significantly reduced motion ranges of the wrist in flexion. Besides, Nguyen and Dingwell (2012) proposed that distal joints were more effective and less costly compared with proximal joints. Therefore, we suggested that “Swipe down with the forefinger” might be the more suitable gesture for Volume down on account of its objective evidence for lower physical demand. This gesture was the same as the selected result of command Scroll up, which could also be distin- guished by the target of the gesture in real-world interaction scenarios (Wobbrock et al., 2009). For Accept, its candidate gestures included “Tap with the forefinger” from the Fewer fingers group and “OK” from the More fingers group. Concerning the results of the psychologi- cal measures, we did not find significant differences between these two gestures, which was consistent with Wobbrock et al. (2009), who proposed that it was too difficult for participants to comprehend such complex commands and elicit favored gesture. Concerning the results of the physiological measures, we found that “Tap with the forefinger” was related to more significant wrist motion, while “OK” induced a higher mus- cular load. These results were consistent with Huang et al. (2015), who pointed out that “OK” as a static gesture hardly involving movement but could be quite accurately classified using EMG. Dim et al. (2016) pointed out “OK” was preferred 1534 J. HUANG ET AL. by users because it was simple and intuitive for mimicking metaphors in users’ daily lives. Therefore, we suggested iden- tifying “OK” as the preferable gesture for Accept. For Reject, its candidate gestures included “Wave the hand” from the EC group and “Draw a cross mark” from the MC group. As regards the results of the psychological measures, we did not find significant differences between these two gestures. As regards the results of the physiological measures, we found that “Wave the hand” caused the higher FCU muscular load while “Draw a cross mark” induced the larger ROM and velocities of the wrist. As Rempel et al. (2014) indicated that it was uncomfortable when the wrist was in ulnar deviation and fingers were extended, “Wave the hand” with such extreme joint posture might be involved in a higher risk of physical damage. Vatavu (2012) reported that partici- pants preferred to perform “Draw a cross mark” in mid air to mimic the close icon of windows on PCs. Therefore, we suggested that “Draw a cross mark” might be the more sui- table gesture for Accept on account of its objective evidence for the lower muscular load. 3.3.3.4. One given command was assigned two similar ges- tures. For Maximize, its candidate gestures included “Stretch with the five fingers” and “fist to open.” We did not find any significant differences between these two gestures by way of the physiological and psychological measures. The reason might be that “Stretch with the five fingers” and “fist to open” were too similar to be distinguished either by the subjective or objective method. In this case, we suggested that both gestures could be regarded as suitable gestures for Maximize. 4. Conclusion In this study, we conducted two experiments to identify the optimal gestures for 16 given commands using a comprehensive assessment system and made the following main conclusions: ● We confirmed that this assessment system could effec- tively determine the candidate gestures with lower phy- siological loads for all given commands except Maximize. Furthermore, most of the selected gestures are also in line with users’ mental models for human- computer interaction. ● We provided an optimal user-defined gesture set for 16 frequently used commands accommodated to human- computer interaction. This is the first study that focused on the physiological effects on identifying optimal candidate user-defined gestures for given commands using the indices of EMG, electrogoniome- try. Our findings could provide a scientific basis for designing mid-air gestures in the future HCI field. The implications of these findings could be beneficial to avoid the risk of muscu- loskeletal disorder for repetitive mid-air gesture use. There are some limitations to our research that should be addressed in the future. First, because this study mainly focuses on understanding physical demands and mental models of users when performing candidate gestures for given commands regardless of technical concerns, further study is needed to examine the issue of the recognition accu- racy and interaction efficiency for these gestures. Second, since the present study only evaluates a typical set of gestures for common commands, further study is required to extend the scope to other necessary commands for human-computer interaction in the future. Third, our assessment system so far was applied to the condition of two gesture proposals for each given target command, and further study would take more gesture proposals into consideration to verify the generaliza- tion ability of this system.
### Currently in our report
At the moment we have based our tasks of off the 6-DoF tasks. We have taken the standard 3 translational and  3 rotational DoF's as well as some scaling to gather more data. Four tasks have been divised. First, measuring each 3DoF then the 6DoF combined then the 6 plus Scaling. These tasks are to be performed by Varjo VR controller first, then by pure hand-gestures.
- Does it serve our report adequately?
- Is this an appropriate measure/method of measure? 
- How can we show all this and demonstrate the high-level of ciritcal thinking and analysis expected throughout this report? 
#### The "6-DoF Target Alignment" Task (The Gold Standard)
You will then explicitly state that for the purposes of your empirical evaluation, the traditional "joystick" paradigm is represented by the 6-DoF Varjo VR controllers. This shows the examiner that you understand the breadth of the field but have made a calculated, practical decision for your experiment's methodology.
In academic VR research, the most widely used and validated method for testing spatial manipulation is a **6-DoF (Degrees of Freedom) Docking Task** (also known as Target Alignment).
Instead of moving objects into boxes, the user must grab an object and perfectly align it with a target silhouette in 3D space.

**How to implement this with your liver:**
1. **The Environment:** The user stands at a virtual surgical table.
2. **The Object:** The solid, textured 3D liver model is spawned in front of them at a random rotation.
3. **The Target:** A translucent "ghost" or wireframe outline of the liver is positioned a short distance away at a specific, required orientation.
4. **The Objective:** The user must use their hands (or the joystick baseline) to grab the solid liver, move it to the ghost liver, and rotate it until the two models overlap perfectly.
#### Why This Task is Perfect for Your Evaluation
- **It tests all your gestures seamlessly:** To complete the task, the user _must_ use your grab (translation) and rotate gestures. If you make the ghost liver a different size, it forces them to use the bimanual scaling gesture.
- **It generates objective metrics:** You can write a script that calculates the exact positional distance (Vector3) and rotational difference (Quaternion angle) between the solid liver and the target liver.
- **It defines "Completion":** The task is mathematically complete when the distance and angle drop below a certain threshold (e.g., `< 0.05` units and `< 5` degrees). This gives you an exact "Task Completion Time" (TCT) to the millisecond for your quantitative data.
- **It measures cognitive load natively:** Aligning an asymmetrical, complex shape like a liver requires significant spatial reasoning. This will yield rich, contrasting data in your NASA-TLX scores when comparing the intuitive hand gestures against the clunky joystick.
#### Tasks to Complete
**Four progressive tasks**. This isolates each spatial variable (Translation, Rotation, Scale) before combining them, giving you perfectly clean data to analyze.
- **Task 1: Pure Translation (Positional Mapping)**
    - **The Setup:** The solid liver spawns 30cm away from the Ghost target, but shares the _exact same_ rotation and scale.
    - **The Action:** The user simply grabs the liver and moves it in a straight line into the hologram.
    - **What it Proves:** This isolates your `translationalInefficiency` metric. It tests how well the user maps physical hand movement to virtual distance without the distraction of having to twist their wrist.
 
- **Task 2: Pure 3-Axis Rotation (Rotational Mapping)**
    - **The Setup:** The solid liver spawns right next to the Ghost target (minimizing necessary movement), but is rotated randomly across the X, Y, and Z axes.
    - **The Action:** The user must grab the liver and manipulate it like a puzzle piece to find the correct orientation.
    - **What it Proves:** This isolates your `currentAngularError`. It mathematically proves whether rolling a joystick thumbstick or twisting a physical wrist has a lower cognitive load when solving complex spatial puzzles.

- **Task 3: Translation + Rotation (The 6-DoF Standard)**
    - **The Setup:** The solid liver spawns 30cm away _and_ is randomly rotated.
    - **The Action:** The user must pull the object toward the center while simultaneously reorienting it.
    - **What it Proves:** This tests the "Clutch Count." Are they able to seamlessly move and rotate at the same time (common with hands), or do they have to move it, drop it, and then rotate it (common with joysticks)?

- **Task 4: Translation + Rotation + Scale (The Master Task)**
    - **The Setup:** The solid liver spawns at a random offset, randomly rotated, and is scaled down by 50%.
	    - Shoudl the scale be constrained to all XYZ? As to not make the scaling unnecessarily difficult.
    - **The Action:** The user must translate, rotate, and execute a bimanual gesture (e.g., pulling two hands apart) or use a secondary joystick input to scale the model up to match the Ghost.
    - **What it Proves:** This pushes the cognitive load to its absolute maximum. It will provide the starkest contrast in your NASA-TLX scores between the two input methods.
##### Why this structure guarantees a higher mark:
In your Chapter 4 (Results and Discussion), having this 4-step breakdown allows you to make highly specific, technically backed claims. Instead of just saying "Hand tracking was faster," you can state: _"While hand-tracking showed a negligible improvement in pure translation (Task 1), it yielded a statistically significant 40% reduction in completion time during 3-Axis Rotation (Task 2)..."_
_(The user will complete these three tasks first with the Varjo controllers, and then repeat them with their bare hands)._
#### 5. What is Being Recorded, When, and How
Your C# script operates silently in the background.
##### The "Hidden" Telemetry Metrics
To prove whether hand-gestures reduce cognitive load and increase precision compared to a joystick, you need to calculate the difference between **ideal movement** and **actual movement**.

1. **Angular Offset (The "Angle of Rotation"):** In 3D space, rotation is calculated using Quaternions, not simple Euler angles (which suffer from gimbal lock). We use `Quaternion.Angle()` to mathematically calculate the exact shortest arc in degrees between the user's liver model and the target ghost liver.
2. **Translational Inefficiency:** What is the shortest straight line from the starting point to the target? How far did the user _actually_ move the liver to get there? If the optimal path is 0.5 meters, but the user moved the liver 2.3 meters (wobbling, overshooting, pulling it closer to look at it), that indicates a high cognitive load and poor mapping.
3. **Clutch Count (Drop Rate):** How many times did the user grab the object, let go, and grab it again? A high clutch count with the Ultraleap implies the pinch threshold is unstable or the user is suffering from "Gorilla Arm" fatigue and having to rest.
4. **Task Completion Time (TCT):** Total milliseconds from the first grab to the moment the Angular Offset and Positional Error drop below your success thresholds.
- **When it Records:** It starts exactly when the user clicks the "Start Trial" button. It stops exactly when the mathematical difference between the Solid Liver and the Ghost Liver drops below your success threshold (e.g., `< 0.02` meters distance and `< 5` degrees rotation).
- **How it Records:** Because there are no physics, we rely purely on Unity's `Transform` mathematics. Every single frame (running at the sub-100ms latency of your tracking system), the script calculates the Vector3 distance and the Quaternion angle between the two models.

- **What is Recorded:**
    1. **Task Completion Time (TCT):** Total seconds from "Start" to successful alignment.
    2. **Angular Inefficiency:** How many total degrees did the user rotate the object versus the shortest mathematical path? (High inefficiency = they were confused about which way to turn it).
    3. **Path Traveled:** The actual meter distance the liver was moved vs. the straight-line distance.
    4. **Clutch Count:** How many times the user "let go" of the liver to readjust their grip. (A high clutch count with the Ultraleap indicates fatigue or awkward gesture mapping).

Once the liver is perfectly aligned, the system instantly snaps it into place, turns the Ghost Liver green, plays a soft "success" chime, and writes all that hidden telemetry directly to your CSV file.
- I want to know what algorithm is best to implement for calculating some of these metrics and why.
- I also want to know which gestures to program. To do this,  I need to map out/finalise all of the movements that can be made e.g., rotation, scaling/zoom in/out, grabbing/piching, moving, etc. 
	- Once determined, these actions will need to be efficiently and logically mapped to both Varjo VR controller and hand-gestures, deciding on the gesture itself based on literature i.e. what's intuitive and easy for people to perform and then solidifying whether or not it is mono or bimanual gesture for each action. 
### Results:  Continue and Implement the code and gestures
This is exactly the type of foundational questioning that leads to a top-tier dissertation. You cannot effectively program a testing environment if you do not understand the academic logic behind it. 

Let’s demystify the 6-DoF task and the NASA-TLX, validate your testing scenario, define your mathematical algorithms, and finalize your gesture mapping using the literature you provided.

---
#### Part 1: The "Why" behind 6-DoF and NASA-TLX
The easiest way to understand your methodology is to view it as a two-sided coin: **Objective Performance** versus **Subjective Cost**.
##### Why the 6-DoF Docking Task? (The Objective Measure)
In your provided Source 2 (the astronaut docking study), they note that controlling 6-DoF requires building an internal "mental representation of one's own position and orientation in space." 
In the real world, a surgeon manipulating a liver inherently uses 6-DoF (Translate X/Y/Z and Rotate Pitch/Yaw/Roll). When we force users to do this virtually, we are testing the **"Mapping Dissonance."** 
* **The Controller Problem:** A joystick is a 2D input device. Using it to perform a 3D rotational task forces the brain to translate "pushing a thumbstick left" into "rolling the liver on its Z-axis." This is a heavy cognitive translation step.
* **The Hand Solution:** Hand-tracking provides a 1:1 kinematic mapping. Your hand moves forward, the liver moves forward. Your wrist twists, the liver twists. 
* **The Purpose in your Report:** The docking task mathematically proves whether that 1:1 hand mapping actually translates to faster, more accurate spatial manipulation than the joystick. 
##### Why the NASA-TLX? (The Subjective Measure)
If your telemetry proves that hand-tracking completes the task 40% faster than the joystick, you might be tempted to say "Hand tracking is universally better." But what if the user’s arms were burning with fatigue? What if the camera lost tracking and frustrated them?
* **The Purpose in your Report:** The NASA-TLX measures the *Cognitive and Physical Cost* of that performance. Source 3 highlights the physiological load of mid-air interaction. The NASA-TLX forces the user to rate their **Mental Demand**, **Physical Demand** (Gorilla Arm), and **Frustration**. 
* **Harmonizing the Two:** You achieve $\ge 80\%$ critical analysis when you synthesize both metrics. For example: *"While 6-DoF telemetry proved hand-tracking was 30% faster, the NASA-TLX revealed a 50% increase in Physical Demand due to lack of haptic resting surfaces, indicating a trade-off between intuitive mapping and ergonomic fatigue."*

---
#### Part 2: Reviewing Your 4-Task Setup
Your isolation of variables (Translation -> Rotation -> Both -> Both + Scale) is **exceptional**. This is exactly how rigorous HCI studies are structured because it prevents confounding variables. If a user fails at Task 3, you know exactly why because you have their baseline data from Task 1 and 2.

**Answering your Scaling Question:**
*Should scale be constrained to all XYZ?* **Yes, absolutely.** You must lock the aspect ratio (Uniform Scaling). If you allow non-uniform scaling (stretching the liver into a pancake), you change the task from "spatial positioning" to "mesh deformation," which invalidates your docking metrics.

---
#### Part 3: Telemetry Algorithms (The "How")
To calculate spatial inefficiency, you must use industry-standard 3D mathematical principles. Here is exactly what algorithms to use and why:

**1. Rotational Error (Angular Offset)**
* **The Algorithm:** `Quaternion.Angle(liver.rotation, target.rotation)`
* **The Justification:** You must explicitly state in your report that you used Quaternions instead of Euler Angles (Vector3 rotations) to calculate rotational differences. Euler angles suffer from "Gimbal Lock" (when axes align and a degree of freedom is lost, breaking the math). The `Quaternion.Angle` algorithm safely returns the shortest arc in degrees between two 3D orientations, regardless of how many times the user spun the object.

**2. Translational Inefficiency (Path Traveled vs. Optimal Path)**
* **The Algorithm:** Accumulate the `Vector3.Distance(previousFramePos, currentFramePos)` every frame to get the **Actual Path Traveled**. Then, divide it by the `Vector3.Distance(startPos, targetPos)` to get the **Inefficiency Ratio**.
* **The Justification:** If the target is 1 meter away, and the user moves the liver 1 meter, the ratio is 1.0 (Perfect). If the user wobbles, pulls it close to inspect it, and moves it 3 meters, the ratio is 3.0. This algorithm perfectly captures spatial confusion.

**3. Clutch Count (Drop Rate)**
* **The Algorithm:** An integer counter that increments every time the `GrabState` changes from `True` to `False` before the task is complete.
* **The Justification:** Measures tracking instability and ergonomic need-to-rest.

---
#### Part 4: Finalizing the Gesture Mapping
Based on Source 3 (User-Defined Gestures), we must select gestures that minimize wrist strain and physiological load. 
#### Task 1, 2, and 3: Translation & Rotation (6-DoF)
* **Hand-Tracking (Condition B):** **Mono-manual "Pinch-and-Hold".** 
* *Literature Justification:* Source 3 explicitly notes that "Fewer fingers" gestures (using just thumb and forefinger) require significantly smaller Range of Motion (ROM) and velocity of wrist motion compared to full hand grabs. Because you are testing precise rotational docking, wrist flexibility is paramount. A pinch allows the wrist to pivot freely.
    * *The Action:* User pinches the liver with one hand. While pinched, the liver's Transform matches the hand's Transform 1:1.
* **Varjo Controller (Condition A):** **Mono-manual "Grip Button Hold".**
    * *The Action:* User holds the side-grip button. The liver follows the controller 1:1.
#### Task 4: Scaling (Uniform XYZ)
* **Hand-Tracking (Condition B):** **Bimanual "Pinch-and-Stretch".**
    * *Literature Justification:* Source 3 found that for "Zoom in / Zoom out" commands, users showed a strong psychological preference for "Stretch with the thumb and forefinger," and physiological measures proved it induced less wrist motion than using whole fists.
    * *The Action:* User pinches the liver with *both* hands simultaneously. As they pull their hands apart, the distance delta dynamically scales the object up or down.
* **Varjo Controller (Condition A):** **Thumbstick Up/Down.**
    * *The Action:* While gripping the object, pushing the thumbstick forward scales it up, pulling backward scales it down. (This beautifully highlights the "Mapping Dissonance" of controllers—why should pushing a stick "forward" make an object "bigger"? It is an artificial abstraction, perfectly contrasting your natural bimanual hand gesture).

Does this synthesis clarify the academic framework of your experiment? If so, we can move straight into writing the C# logic for these specific `Quaternion` and `Vector3` telemetry algorithms in your new Development Chat!
## Updating our existing surveys
### Abstract
> This project is an **Applied Human-Computer Interaction (HCI) study** within the domain of **Medical Spatial Computing**. 
> It utilizes existing **Computer Vision** tracking technologies to evaluate and propose a novel 3D User Interface paradigm for anatomical manipulation.

*Note: Use 'we' in the Methodology, Implementation, Evaluation etc but use passive voice in the Lit Review.*
- Use a list of Acronyms table?
- To reconstruct complex 3D anatomy, 2D DICOM files (the result of various medical imaging technologies like CT, MRI, and PET scans) known as slices undergo a process.
	- It doesn't make sense -> dimensional mismatch
# 05/04/2026
## Developing the Gesture code [TO-D0:]
- Design and map out gestures
	- Hand gestures
	- VR controller
- Create logical flow diagram
- Create code UML OOP diagram
- Repo

**Actions**
- [ ] Grab
- [ ] Zoom 
- [ ] Rotate

**Gestures**
- [ ] Pinch with one hand using the thumb and index finger. 
	- [ ] The user can change the X,Y,Z postion of the grabbed object.
	- [ ] To undo this action and revert back to a non-pinch state, the thumb and index finger must be noticeably apart. 
	- [ ] I'm coining this action and transition of state to non-state a 'breaking' of the gesture. A gesture can break, be broken, etc.
- [ ] Pinch with both hands using the thumbs and index fingers. 
	- [ ] The pinches do not have to be simultaneous, so long as both pinch states/hands are active. 
	- [ ] If the double pinch state is active and one of the pinches gets broken e.g., is no longer in a pinch gesture, the state immediately behaves as the pinch and grab state.
- [ ] Pinch exactly the same as the Grab gesture and rotate the wrist in any X,Y,Z axis to rotate the model.
	- [ ] The wrist is unable to rotate the full 360 degrees of any axis. To fix this, when the user has rotated the model, the user can simply break the gesture, unwind their wrist and repeat the gesture.

**Repo**
- Plan the GH repo so that this is broken into 1-4 sprints
	- Setup of Devices, Mounting the Ultraleap Motion 2 Controller to the Varjo XR-4 Headset, configuring HDRP pipeline, using tutorial scenes do verify both hand and eye tracking.
	- Implement the experiment unity scene, materials, objects, basic hands, light, shadows, volumes, service providers, obj model files, hologram etc.
		- Basic scripts are also included e.g. hand tracking, active states e.g. GRAB
	- Implement hand gestures and VR Controller gestures
	- Implement and finalise the background telemtry scripts

**Questions**
- The rotating about multiple axis will be difficult, is this possible?
- The user can move around the room slightly in the physical world to move in the virtual scene, this acts as pan and move gestures, correct?
- Is there anything missing from my Repo, what's expected for a professional standard?
### Results
#### 1. Answering Your Questions
**"The rotating about multiple axis will be difficult, is this possible?"**
Yes, it is entirely possible and mathematically straightforward in Unity, but it is *anatomically* difficult for the user. 
* **The Math:** You will calculate the *delta rotation* of the hand between frames using Quaternions: `deltaRot = currentHandRot * Quaternion.Inverse(lastHandRot);` and apply that delta to the liver.
* **The HCI Challenge:** Human wrists do not have 360-degree rotation. Furthermore, twisting the wrist often hides the fingers from the Ultraleap camera (optical occlusion), causing the tracking to drop. Your "breaking" (clutching) mechanic is the exact right solution to this. The user rotates 90 degrees, releases the pinch, resets their wrist, grabs, and rotates again. 

> **"The user can move around the room slightly in the physical world to move in the virtual scene, this acts as pan and move gestures, correct?"**
> Technically, no. Moving physically is **Head Tracking (6-DoF Locomotion)**, not a gesture. However, functionally, it does change the user's perspective (panning/dollying) relative to the 3D model. You should explicitly state in your report that the Varjo XR-4 handles user locomotion natively via inside-out tracking, leaving the gestures strictly for object manipulation. 

**"Is there anything missing from my Repo, what's expected for a professional standard?"**
Your 4-sprint breakdown is excellent for feature delivery, but a professional-grade repository requires specific configuration files and structural pipelines.
1.  **.gitignore (Crucial):** You must use a Unity-specific `.gitignore` file. Never push the `Library`, `Temp`, or `Logs` folders to GitHub. They are massive, machine-specific, and will break your repo.
2.  **Git LFS (Large File Storage):** Medical 3D models (`.obj`), HDRP texture maps, and baked lighting data often exceed GitHub's 100MB file limit. You must initialize Git LFS in Sprint 1 to track `*.obj`, `*.mat`, and `*.asset` files.
3.  **Documentation Architecture:** A professional repo needs a `README.md` containing: Build Instructions (Unity version 2021.3 LTS, HDRP), Hardware Requirements (Varjo XR-4, Ultraleap), and a brief system overview.
4.  **Release Tagging:** At the end of each sprint, create a "Release" tag in GitHub (e.g., `v0.1-alpha`, `v1.0-experiment-ready`). This proves to your examiners that you used professional version control pacing.

---
#### 2. Gesture Mapping (Condition B vs. Condition A)
Here is the finalized 1:1 mapping for your comparative study. (Note: "Zoom" in 3D object manipulation is technically defined as **Scaling**).

| Action               | Condition B: Bare Hands (Ultraleap)                                                                                                                                        | Condition A: VR Controller (Varjo)                                                                                                                 |
| :------------------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | :------------------------------------------------------------------------------------------------------------------------------------------------- |
| **Grab / Translate** | **Mono-Pinch:** Single hand pinch (thumb + index). Liver translates 1:1 with hand movement.                                                                                | **Grip Hold:** Press and hold the side grip button. Liver translates 1:1 with controller movement.                                                 |
| **Rotate**           | **Mono-Pinch + Wrist Pivot:** Same pinch as grab, but wrist rotation applies delta Quaternions to the liver. User releases pinch to "clutch" and reset wrist.              | **Grip Hold + Wrist Pivot:** Press and hold side grip, rotate physical controller. User releases grip to clutch.                                   |
| **Scale ("Zoom")**   | **Bimanual Pinch:** Both hands pinch. The distance delta between the left and right pinch centers dictates uniform XYZ scaling. Releasing one hand reverts to Grab/Rotate. | **Grip Hold + Thumbstick:** Hold grip button. Push thumbstick Forward to scale up, pull Backward to scale down. *(Highlights mapping dissonance).* |

---
#### 3. Object-Oriented Architecture (UML Logic)
To keep your code decoupled and professional, your system should utilize a **State Machine** for the gestures. Here is the logical class structure for your UML diagram:

* **`ClinicalTrialManager` (The Orchestrator)**
    * *Properties:* `CurrentTaskIndex`, `IsTrialActive`, `TargetDistanceThreshold`, `TargetAngleThreshold`.
    * *Methods:* `StartTrial()`, `CheckWinCondition()`, `EndTrial()`.
* **`AlignmentMetricsLogger` (The Telemetry Engine)**
    * *Properties:* `CSVFilePath`, `StartTime`, `ClutchCount`.
    * *Methods:* `LogFrameData(Vector3 error, float angle)`, `IncrementClutch()`, `ExportToCSV()`.
* **`GestureStateMachine` (The Input Interpreter)**
    * *Properties:* `LeftHandPinchStrength`, `RightHandPinchStrength`, `CurrentState` (Enum: Idle, MonoGrab, BimanualScale).
    * *Methods:* `EvaluateHands()`, `TriggerGrabEvent()`, `TriggerBreakEvent()`.
* **`UltraleapKinematicManipulator` (The Physics Mover)**
    * *Properties:* `TargetLiverTransform`, `ReferenceHandTransform`.
    * *Methods:* `TranslateObject(Vector3 delta)`, `RotateObject(Quaternion delta)`, `ScaleObject(float distanceDelta)`.

---
#### 4. Sprint Plan Refinement
Here is your repository plan, injected with professional software engineering standards:

* **Sprint 1: Architecture & Tracking Validation**
    * Initialize Git, `.gitignore` (Unity), and Git LFS.
    * Configure Unity 2021.3 LTS, HDRP, and strictly set Varjo offsets to `0,0,0`.
    * Verify raw tracking streams for both Varjo standard controllers and the Ultraleap module.
* **Sprint 2: The Clinical Void & Assets**
    * Import `.obj` liver models and apply clinical HDRP materials.
    * Set up the minimalist environment (lighting, shadows, global volume).
    * Create the "Ghost" target hologram and position it.
* **Sprint 3: Interaction & State Machines (The Core)**
    * Code the `GestureStateMachine` for both Hand and Controller inputs.
    * Implement Grab, Rotate, and Bimanual Scale (with "clutch/break" logic).
    * Implement the 0.25-second coyote-time for occlusion handling.
* **Sprint 4: Telemetry & Trial Orchestration**
    * Code `AlignmentMetricsLogger` to write Euclidean and Quaternion errors to `.csv`.
    * Wire the `ClinicalTrialManager` UI to guide the user through the 4 tasks.
    * QA testing, bug fixing, and final `v1.0` GitHub Release tag.

Shall we begin drafting the C# code for the `GestureStateMachine` to solidify how we will mathematically detect the pinch states and trigger your "breaking" mechanic?
##  Planning the Repo
#### 1. Kanban Configuration: Sprints, WIP Limits, and Granularity
A Kanban board is not a graveyard for vague ideas; it is a living, breathing engine that tracks progress.
#### Adding Backlog Items
**Should I add all backlog items for each sprint prior to being in the actual sprint phase itself?**
No. This is an anti-pattern. You should define your high-level *Features* (Epics) up front, but only break them down into granular *Tickets* (Issues) during Sprint Planning at the beginning of each sprint. If you try to plan Sprint 4 in detail during Sprint 1, you will fail, because you do not yet know what technical debt or tracking issues you will encounter.
#### Work-In-Progress (WIP) Limits
**What should the set limit be for each column?**
WIP limits force you to finish tasks before starting new ones, demonstrating Lean methodology. As a solo developer, apply these strict limits:
* **Backlog:** No limit (High-level ideas go here).
* **Ready (Sprint Backlog):** 5-8 tickets maximum. (Only what you commit to for the current sprint).
* **In Progress:** **Strict limit of 2.** (If you have 3 things in progress, you are context-switching and destroying your velocity).
* **In Review (PR Open):** **Strict limit of 2.** (You must merge or close a PR before moving on).
* **Done:** No limit.
#### Ticket Specificity and Details
**How specific and exact should the items be?**
A ticket is not "Do hand tracking." A ticket must be an actionable, verifiable unit of work.

**What details should be provided?**
Every ticket (GitHub Issue) must contain:
1.  **Title:** `[Feature] Implement Pinch Threshold State Machine`
2.  **Description/User Story:** "As the system, I need to detect when the thumb and index finger are $< 0.02$ units apart to trigger a grab state, and $> 0.05$ units apart to break the grab."
3.  **Acceptance Criteria:** (How do you know it is done?)
    * State machine logs "Pinch Entered" to console.
    * State machine logs "Pinch Exited" to console.
    * Hysteresis loop prevents flickering between states.

---
#### 2. The Development Roadmap (Epics & Milestones)
Your methodology evaluation requires a macro-level Roadmap. In GitHub Projects, you can view your tickets as a Roadmap (Gantt chart) by grouping them into Epics/Milestones.

Here is how you should structure your milestones in GitHub:
* **Milestone 1: Foundation (Weeks 1-2)**
    * *Goal:* Stable HDRP environment with zero-offset Varjo pass-through and raw Ultraleap skeletal data streaming.
* **Milestone 2: Interaction Core (Weeks 3-4)**
    * *Goal:* Functional Gesture State Machine allowing Translation and Rotation of the 3D Liver mesh without physics colliders.
* **Milestone 3: Bimanual & Baseline (Weeks 5-6)**
    * *Goal:* Implementation of bimanual scaling and completion of the Varjo Controller 6-DoF baseline system (Condition A).
* **Milestone 4: Telemetry & Orchestration (Weeks 7-8)**
    * *Goal:* `ClinicalTrialManager` sequences tasks 1-4 automatically, and `AlignmentMetricsLogger` successfully outputs Euclidean/Quaternion error to a `.csv` file.

---
#### 3. Git Workflow: Branching and Committing
You want to stick to Conventional Commits and Feature Branching. This is exactly what examiners want to see.
#### The Branching Strategy
Never commit directly to `main`. When you pick up a ticket (e.g., Issue #12: Implement Dwell Timer), you branch off `main`:

`git checkout -b feat/12/dwell-timer`

**Branch Naming Convention:**
`<type>/<issue-number>/<short-description>`
* **Types:** `feat` (new feature), `fix` (bug fix), `docs` (documentation), `refactor` (code structure change).
* **Example:** `fix/14/fix-pink-shader-bug`
#### The Commit Strategy
When you commit work on that branch, use Conventional Commits:

**Commit Naming Convention:**
`<type>(optional scope): <description>`
* **Example 1:** `feat(telemetry): implement quaternion angle tracking`
* **Example 2:** `fix(rendering): disable auto-baking to fix HDRP pipeline errors`
* **Example 3:** `docs(readme): add hardware prerequisites`
#### The Pull Request (PR)
When the branch is done, open a PR against `main`. The PR title must match the convention: `feat: implement dwell timer`. Include `Closes #12` in the PR description so GitHub automatically closes the issue when merged.

---
#### 4. Version Control and Unity Integration
**"Should I connect this repo with my actual unity scene as to ensure version control or manually add scripts?"**

**You MUST connect the repository to your actual Unity project folder.** Manually dragging scripts into GitHub via the web interface completely defeats the purpose of version control and will result in a heavy penalty on your methodology mark. Version control tracks the evolution of your *entire* project, including scene files, material properties, and project settings.

**"I am not using unity cloud nor unity version control, why did I choose this?"**

This is a fantastic point to make in your dissertation's methodology chapter. Here is exactly how you justify it:

> *"For version control and source code management, industry-standard Git (hosted via GitHub) was selected over Unity Version Control (Plastic SCM) or Unity Cloud Build. This decision was driven by the project's strict hardware dependencies. The system requires the Varjo XR-4 proprietary runtime and embedded Ultraleap drivers to function. Cloud-based compilation platforms cannot validate these hardware-level integrations, rendering remote builds futile. Furthermore, standard Git coupled with Git Large File Storage (LFS) provided superior, granular control over branch protection and conventional commit histories, which was critical for maintaining the integrity of the C# telemetry algorithms throughout the iterative development cycles."*

**"How else will I track my projects progress?"**

You track your progress through the irrefutable history of your GitHub repository:
1.  **The Kanban Board:** Shows velocity and task completion.
2.  **The Git Commit History:** Shows a logical, chronological evolution of the codebase.
3.  **Pull Requests:** Shows that code was reviewed (even by yourself) before being merged into production.
4.  **GitHub Releases (Tags):** E.g., tagging `v1.0-experiment-ready` proves you hit your final milestone.
## Tickets [OLD]
Here is the fully refined, enterprise-grade ticket breakdown for your GitHub Project board. 

I have explicitly adjusted the architecture for **VR Only**, meaning we are officially discarding the Mixed Reality/Video Pass-Through (VPT) configuration. Instead, the environment will be a closed, fully immersive "Clinical Void," which actually gives you much tighter control over lighting, shadows, and performance.

---
### **Sprint 1: Architecture & Tracking (Foundation)**
*Focus: Environment stabilization and hardware handshakes.*

**Ticket 1: `[CHORE] Setup GitHub Repo and LFS Tracking`**
* **User Story:** As the lead engineer, I need to configure the repository to handle large 3D assets and prevent unity temporary files from bloating the commit history.
* **Implementation Details:** Initialize `.gitignore` using the standard Unity template. Install Git LFS and track `.obj`, `.mat`, `.fbx`, and `.asset` extensions via `.gitattributes`. Protect the `main` branch to require Pull Requests.
* **Acceptance Criteria:**
  - [ ] `.gitignore` is active (Library/Temp folders are ignored).
  - [ ] `.gitattributes` contains LFS tracking rules.
  - [ ] Branch protection prevents direct commits to `main`.

**Ticket 2: `[CONFIG] Initialize Unity HDRP and Varjo VR-Only Settings`**
* **User Story:** As a developer, I need the rendering pipeline optimized strictly for Varjo XR-4 Virtual Reality to ensure $\ge 90$ FPS and clinical visual fidelity.
* **Implementation Details:** Install Unity 2021.3 LTS. Configure HDRP settings. *Crucially*, since this is VR-Only, ensure Varjo Mixed Reality (VPT) is disabled in the XR Plug-in Management. Set camera clear flags to a solid opaque color (e.g., dark clinical grey) to create the immersive void, ensuring no performance is wasted on pass-through rendering.
* **Acceptance Criteria:**
  - [ ] HDRP Asset configured (Bloom/AO set to 0).
  - [ ] Varjo Plugin installed and Opaque rendering enforced.
  - [ ] XR Origin positional offset hardcoded to `0,0,0`.

**Ticket 3: `[CONFIG] Install Ultraleap Unity Plugin via OpenUPM`**
* **User Story:** As a developer, I need the Ultraleap tracking packages installed cleanly without polluting the project hierarchy with submodules.
* **Implementation Details:** Modify `Packages/manifest.json` to include the OpenUPM scoped registry for `com.ultraleap.tracking`.
* **Acceptance Criteria:**
  - [ ] Ultraleap Core and Hands packages successfully resolved via Package Manager.
  - [ ] No manual `.unitypackage` files exist in the `Assets/` directory.

**Ticket 4: `[FEAT] Validate Hardware Tracking Streams`**
* **User Story:** As an experimenter, I need to verify that both the legacy Varjo controllers and the Ultraleap optical camera are successfully mapping to the Unity XR Rig.
* **Implementation Details:** Create a debug scene. Attach `LeapXRServiceProvider` to the Main Camera. Pair Varjo 6-DoF controllers and ensure input values are reading in the console.
* **Acceptance Criteria:**
  - [ ] Physical Varjo controllers track 1:1 in the Unity Editor.
  - [ ] Ultraleap camera detects hands and renders default joint meshes.

---
### **Sprint 2: The Clinical Void & Assets (Environment)**
*Focus: Importing medical data and establishing the pristine testing arena.*

**Ticket 5: `[ASSET] Import and Map Patient Liver 3D Models`**
* **User Story:** As a user, I need the 3D liver model imported at a 1:1 real-world scale to ensure spatial metrics are accurate to physical distances.
* **Implementation Details:** Import `Patient4_3D_Liver_Model_Solid.obj`. Verify scale multiplier in Unity import settings (1 Unit = 1 Meter). Attach a Kinematic Rigidbody (no gravity) and Mesh Collider.
* **Acceptance Criteria:**
  - [ ] Liver model renders correctly in HDRP.
  - [ ] Spatial scale matches real-world human proportions.

**Ticket 6: `[FIX] Apply Custom HDRP Material to Ghost Hands`**
* **User Story:** As a user, I need my virtual hands to render correctly without shader corruption (the pink material bug) to maintain immersion.
* **Implementation Details:** Bypass the broken procedural capsule hands. Spawn Skinned Mesh Ghost Hands and apply a custom HDRP-compatible material (`Mat_ClinicalHands`).
* **Acceptance Criteria:**
  - [ ] Hands render cleanly in the HDRP VR environment.
  - [ ] Material does not cause foveated rendering artifacting.

**Ticket 7: `[FEAT] Construct Immersive VR Clinical Void`**
* **User Story:** As an experimenter, I need a distraction-free VR environment with flawless lighting so users can focus entirely on the spatial tasks.
* **Implementation Details:** Build a minimalist "shoebox" room using scaled planes. Add `Directional Light_Fill` with shadows *disabled* to provide ambient bounce light, preventing double-shadows from the primary spotlight.
* **Acceptance Criteria:**
  - [ ] Room securely encloses the XR Origin.
  - [ ] Liver model is uniformly lit without stark, distracting shadows.

**Ticket 8: `[ASSET] Create Holographic Target Ghost Liver`**
* **User Story:** As a user, I need a clear visual target to dock the solid liver into.
* **Implementation Details:** Duplicate the Liver prefab. Remove its colliders. Create an HDRP translucent material (`Mat_ClinicalHologram`) and apply it.
* **Acceptance Criteria:**
  - [ ] Ghost liver is distinctly translucent.
  - [ ] Ghost liver does not physically collide with the Solid liver or hands.

---
### **Sprint 3: Interaction & State Machines (The Core)**
*Focus: Engineering the physics-free kinematic manipulation.*

**Ticket 9: `[FEAT] Implement GestureStateMachine.cs`**
* **User Story:** As the system, I need to mathematically identify when the user intends to pinch, utilizing strict hysteresis thresholds to prevent flickering.
* **Implementation Details:** Write a C# script tracking the `Vector3.Distance` between the thumb tip and index tip. Enter `PinchState` at `< 0.02` units; Exit `PinchState` at `> 0.05` units.
* **Acceptance Criteria:**
  - [ ] State changes cleanly without micro-stuttering.
  - [ ] State Machine logs current state (Idle, Pinching) to the console.

**Ticket 10: `[FEAT] Implement Translation via Kinematic Manipulator (Task 1)`**
* **User Story:** As a user, when I pinch the liver, moving my hand should move the liver 1:1 in 3D space.
* **Implementation Details:** In `UltraleapKinematicManipulator.cs`, map the Liver's `transform.position` to the Hand's `transform.position` delta while `PinchState` is active. Include a 0.25-second "coyote-time" buffer if tracking drops momentarily.
* **Acceptance Criteria:**
  - [ ] Liver follows the hand cleanly.
  - [ ] Liver does not fall/drop if tracking is lost for $<0.25s$.

**Ticket 11: `[FEAT] Implement Wrist Pivot Rotation and Clutch Mechanic (Task 2)`**
* **User Story:** As a user, twisting my wrist while pinching should rotate the liver, and opening my hand should "break" the clutch so I can reset my wrist.
* **Implementation Details:** Apply hand `Quaternion` deltas to the liver. Releasing the pinch stops the rotation update, allowing the user to untwist their arm physically without affecting the digital model.
* **Acceptance Criteria:**
  - [ ] Wrist rotation perfectly maps to object rotation.
  - [ ] User can successfully clutch (drop, reset wrist, grab) to rotate the object 360 degrees.

**Ticket 12: `[FEAT] Implement Bimanual Pinch-to-Scale (Task 4)`**
* **User Story:** As a user, pinching with both hands and pulling them apart should scale the liver uniformly.
* **Implementation Details:** Detect simultaneous `PinchState` on Left and Right hands. Calculate the distance between both hands. Apply the distance multiplier strictly to `transform.localScale` uniformly across X, Y, and Z.
* **Acceptance Criteria:**
  - [ ] Bimanual pinch triggers scale mode.
  - [ ] Scale remains uniform (no distortion/stretching of the mesh).

**Ticket 13: `[FEAT] Implement Varjo 6-DoF Controller Baseline (Condition A)`**
* **User Story:** As an experimenter, I need the standard VR controllers to perform the exact same tasks so I can compare them against the hand-tracking.
* **Implementation Details:** Map the grip button to Translation/Rotation. Map the thumbstick (Y-axis) to Uniform Scaling.
* **Acceptance Criteria:**
  - [ ] Grip button successfully grabs and rotates the liver.
  - [ ] Thumbstick scales the liver up and down.

---
### **Sprint 4: Telemetry & Trial Orchestration (The Experiment)**
*Focus: Data extraction and experiment automation.*

**Ticket 14: `[FEAT] Write AlignmentMetricsLogger.cs Telemetry Core`**
* **User Story:** As a researcher, I need the system to calculate the exact spatial inefficiency and angular error of the user's movements.
* **Implementation Details:** Calculate `Vector3.Distance` between Solid Liver and Ghost Liver. Calculate `Quaternion.Angle` between both rotations. Accumulate the total distance traveled by the liver per frame. Track "Clutch Count" (number of pinch state drops).
* **Acceptance Criteria:**
  - [ ] Distance error is tracked accurately.
  - [ ] Angular error avoids Gimbal lock via Quaternion math.
  - [ ] Clutch count increments correctly.

**Ticket 15: `[FEAT] Implement 2.0-Second Spatial Dwell Timer`**
* **User Story:** As the system, I must only mark a task as "Complete" if the user holds the liver perfectly inside the hologram for 2 seconds.
* **Implementation Details:** If Distance $< 0.05m$ AND Angle $< 5^\circ$, begin a `deltaTime` timer. If either threshold breaks, reset timer to 0. If timer hits 2.0s, trigger Task Success.
* **Acceptance Criteria:**
  - [ ] Accidental "fly-bys" do not trigger success.
  - [ ] Task successfully registers completion after 2 seconds of sustained alignment.

**Ticket 16: `[FEAT] Implement CSV Export Pipeline`**
* **User Story:** As a researcher, I need the telemetry data saved to a persistent file format for statistical analysis in SPSS/Excel.
* **Implementation Details:** Format data as comma-separated values. On Task Success, write a line appending `TaskID`, `Condition`, `TCT`, `TranslationalInefficiency`, `AngularError`, and `ClutchCount` to `TrialData.csv` in the `Application.persistentDataPath`.
* **Acceptance Criteria:**
  - [ ] CSV file generates locally.
  - [ ] Data headers are perfectly formatted and data corresponds accurately.

**Ticket 17: `[UI] Wire World Space UI Trial Orchestrator`**
* **User Story:** As a user, I need textual instructions in VR telling me which of the 4 tasks I am currently performing.
* **Implementation Details:** Create a `TextMeshProUGUI` Canvas in World Space. Wire `ClinicalTrialManager.cs` to update the text (e.g., "Task 1/4: Translation. Move the liver to the hologram").
* **Acceptance Criteria:**
  - [ ] UI is readable and statically placed in the clinical void.
  - [ ] UI updates automatically upon task completion.

**Ticket 18: `[RELEASE] Final QA and v1.0 Release`**
* **User Story:** As the lead engineer, I need to freeze the codebase and stamp a formal release version before user testing begins.
* **Implementation Details:** Conduct full run-through of Condition A and Condition B. Ensure CSV outputs correctly. Create the `v1.0-experiment-ready` tag on GitHub.
* **Acceptance Criteria:**
  - [ ] No console errors during a full playthrough.
  - [ ] GitHub release tag generated.
## Tickets [NEW]
### **Sprint 1: Architecture & Tracking (Foundation)**
*Goal: Establish a stable, version-controlled baseline for the project[cite: 10].*

**Ticket 1: `[CHORE, CONFIG, DOCS] Setup Repository and LFS Environment`**
* **User Story:** As a developer, I need a version-controlled environment that handles large medical assets without repository bloat[cite: 10].
* **Details:** Initialize `.gitignore` for Unity. Configure `.gitattributes` to track `.obj` and `.asset` files via Git LFS. Establish branch protection on `main`.
* **Acceptance Criteria:**
    * [ ] Library/Temp folders ignored by Git.
    * [ ] LFS successfully tracks medical mesh assets.

**Ticket 2: `[CONFIG] Initialize Unity HDRP and Varjo VR Settings`**
* **User Story:** As a developer, I need the rendering pipeline optimized for the Varjo XR-4 to ensure clinical visual fidelity and high frame rates[cite: 10].
* **Details:** Configure HDRP for VR-only (Opaque mode). Disable Mixed Reality pass-through to maximize GPU performance for high-fidelity anatomical rendering. Hardcode XR Rig offset to `0,0,0`.
* **Acceptance Criteria:**
    * [ ] Varjo Plugin initialized in VR-only mode.
    * [ ] Stable 90+ FPS in the empty HDRP scene.

**Ticket 3: `[CONFIG] OpenUPM Dependency Resolution`**
* **User Story:** As a developer, I need to manage third-party SDKs cleanly via a package manager rather than manual imports[cite: 10].
* **Details:** Configure `manifest.json` with the OpenUPM registry for `com.ultraleap.tracking`.
* **Acceptance Criteria:**
    * [ ] Ultraleap SDK resolved via Unity Package Manager.

**Ticket 4: `[FEAT, CONFIG] Validate Multi-Device Tracking Streams`**
* **User Story:** As an experimenter, I need to verify that both hand-tracking and physical controllers are communicating with the VR engine.
* **Details:** Create a hardware validation scene. Verify raw skeletal data from the Ultraleap 2 and 6-DoF data from Varjo controllers.
* **Acceptance Criteria:**
    * [ ] Real-time hand joint data visible in editor.
    * [ ] Controller button inputs successfully logged to console.

---
### **Sprint 2: The Clinical Void & Assets (Environment)**
*Goal: Construct a distraction-free environment and prepare medical assets for evaluation[cite: 10].*

**Ticket 5: `[CONFIG, TELEMETRY] Medical Asset Scaling and Ingestion`**
* **User Story:** As a researcher, I need the anatomical models scaled precisely to 1:1 real-world proportions to ensure telemetry accuracy[cite: 10].
* **Details:** Import liver `.obj` models. Enforce 1 Unit = 1 Meter scale. Verify mesh pivot points are centered for accurate rotational telemetry.
* **Acceptance Criteria:**
    * [ ] Liver model scale verified against real-world human proportions.

**Ticket 6: `[FIX, CONFIG] Hand Shader Pipeline Restoration`**
* **User Story:** As a user, I need virtual hands to render correctly in the HDRP pipeline to maintain sense of embodiment.
* **Details:** Resolve "pink shader" bugs by applying a custom HDRP material (`Mat_ClinicalHands`) to the skeletal hand meshes.
* **Acceptance Criteria:**
    * [ ] Hand meshes render with zero shader errors in VR.

**Ticket 7: `[FEAT, EXPERIMENT] Build Immersive Clinical Void Environment`**
* **User Story:** As an experimenter, I need a minimalist environment to protect the user's cognitive load during testing[cite: 1, 3].
* **Details:** Create a dark, low-distraction "shoebox" room. Configure non-shadow-casting fill lights to provide clear anatomical visibility without visual noise.
* **Acceptance Criteria:**
    * [ ] Environment is distraction-free and performs at high FPS.

**Ticket 8: `[FEAT, EXPERIMENT] Holographic Target Engineering`**
* **User Story:** As a user, I need a clear, non-colliding target to dock the anatomical model into.
* **Details:** Create a translucent "Ghost Liver" prefab using an HDRP transparency shader (`Mat_ClinicalHologram`).
* **Acceptance Criteria:**
    * [ ] Target is clearly visible and does not interact with physics.

---
### **Sprint 3: Interaction & State Machines (The Core)**
*Goal: Develop the kinematic interaction logic based on HCI research[cite: 3].*

**Ticket 9: `[FEAT, RESEARCH] Implement Hysteresis Pinch State Machine`**
* **User Story:** As a user, I need a stable pinch gesture that doesn't flicker or drop the object accidentally[cite: 3].
* **Details:** Implement `GestureStateMachine.cs` using researched distance thresholds (Enter: 0.02, Exit: 0.05).
* **Acceptance Criteria:**
    * [ ] Stable pinch detection without input jitter.

**Ticket 10: `[FEAT, TELEMETRY, RESEARCH] Kinematic Translation & Coyote-Time`**
* **User Story:** As a user, I need my hand movements to move the object 1:1, with protection against brief tracking loss[cite: 3].
* **Details:** Implement translation in `UltraleapKinematicManipulator.cs`. Add a 0.25s grace period (coyote-time) for momentary camera occlusion.
* **Acceptance Criteria:**
    * [ ] Translation is 1:1 with hand movement.
    * [ ] Object remains held during sub-0.25s tracking loss.

**Ticket 11: `[FEAT, TELEMETRY, RESEARCH] Wrist-Pivot Rotation and Clutching`**
* **User Story:** As a user, I need to rotate the object naturally and "clutch" (reset my wrist) to overcome anatomical limits[cite: 3].
* **Details:** Map wrist rotation to object rotation. Allow breaking the gesture to reset physical orientation while maintaining the object's virtual orientation.
* **Acceptance Criteria:**
    * [ ] Rotation deltas apply correctly.
    * [ ] Users can "clutch" to achieve full 360-degree rotation.

**Ticket 12: `[FEAT, TELEMETRY, RESEARCH] Bimanual Uniform Scaling Logic`**
* **User Story:** As a user, I need an intuitive way to resize the anatomy without distorting its shape[cite: 3].
* **Details:** Implement bimanual pinch detection. Use the distance delta between hands to drive uniform XYZ scaling.
* **Acceptance Criteria:**
    * [ ] Scaling is uniform across all axes.

**Ticket 13: `[FEAT, EXPERIMENT] Varjo 6-DoF Controller Baseline (Condition A)`**
* **User Story:** As an experimenter, I need a standard controller baseline to compare against the hand-tracking system[cite: 10].
* **Details:** Map grip and thumbstick controls to mirror the translation, rotation, and scaling logic of the hand-tracking condition.
* **Acceptance Criteria:**
    * [ ] Controllers achieve functional parity with hand-tracking tasks.

---

### **Sprint 4: Telemetry & Trial Orchestration (Experiment)**
*Goal: Automate trial flow and extract objective performance data[cite: 3, 10].*

**Ticket 14: `[TELEMETRY] Quaternion and Euclidean Metrics Engine`**
* **User Story:** As a researcher, I need precise mathematical tracking of the user's spatial accuracy[cite: 3, 10].
* **Details:** Finalize `AlignmentMetricsLogger.cs`. Implement `Quaternion.Angle` and `Vector3.Distance` calculations at 20Hz.
* **Acceptance Criteria:**
    * [ ] Accurate real-time calculation of rotational and translational error.

**Ticket 15: `[TELEMETRY, EXPERIMENT] Spatial Dwell Time Validation`**
* **User Story:** As an experimenter, I must ensure a task is only "complete" when the user holds a precise alignment[cite: 10].
* **Details:** Implement a 2.0s timer that triggers only when distance and angular error remain below thresholds.
* **Acceptance Criteria:**
    * [ ] "Fly-by" alignments do not trigger task success.

**Ticket 16: `[TELEMETRY] Persistent CSV Data Export Pipeline`**
* **User Story:** As a researcher, I need the telemetry data saved in a format compatible with statistical software[cite: 3, 10].
* **Details:** Code the export system to append TCT, Inefficiency, and Clutch Count to a `.csv` file upon trial completion.
* **Acceptance Criteria:**
    * [ ] Data successfully writes to a local CSV file.

**Ticket 17: `[EXPERIMENT] World Space UI Trial Orchestrator`**
* **User Story:** As a user, I need instructions in the headset to guide me through the experiment[cite: 10].
* **Details:** Create a VR HUD that displays current task IDs (1–4) and instructional text for the user.
* **Acceptance Criteria:**
    * [ ] UI updates dynamically based on the current experimental state.

**Ticket 18: `[RELEASE, DOCS] v1.0 Final System Release`**
* **User Story:** As the developer, I need a stable, tagged release version for the final dissertation submission[cite: 10].
* **Details:** Perform final QA on both conditions. Finalize README documentation. Tag the repository with the `release` version.
* **Acceptance Criteria:**
    * [ ] System is stable and tagged as `v1.0-experiment-ready`.
# 07/04/2026
To achieve a First-Class mark ($\ge 80\%$) in your methodology, you must demonstrate **traceability**: the ability to trace a high-level requirement (Milestone) down to a specific task (Issue), the code implementation (Branch/Commit), and finally its verification (Pull Request).
### 1. Branches vs. Sprints: The Technical Standard
Branches should **never** be broken down into Sprints. Sprints/Milestones are management tools (temporal), while branches are architectural tools (functional).

* **The Sprint (Milestone):** Defines *when* work is due and the *goal* (e.g., Sprint 1: Foundation).
* **The Issue (Ticket):** Defines *what* needs to be done (e.g., Issue #2: Configure HDRP).
* **The Branch:** Is the workspace for that specific Issue.

For your "Sprint 1 Baseline," you should create one main feature branch to merge your sandbox work, but use multiple commits within that branch to simulate the history of the four tickets.

**The Workflow:**
1.  **Branch Name:** `feat/0/sprint-1-baseline` (Issue #0 being a placeholder for the baseline merge).
2.  **Pull Request Title:** `feat: initialize project baseline (Sprint 1)`
3.  **PR Description:** `Closes #1, #2, #3, #4`.
### 2. Sprint 1: Detailed Commit Log
When you move your sandbox code into the repo, do it in these four discrete commits. This proves you didn't just "dump" code, but followed your own plan.

**Commit 1: Repository Hardening**
* **Command:** `git add .gitignore .gitattributes LICENSE README.md`
* **Message:** `chore(git): initialize repository with unity .gitignore and lfs attributes`
* **Context:** Sets the environment rules before any binary data is added.

**Commit 2: Pipeline Configuration**
* **Command:** `git add ProjectSettings/ Assets/_Project/Settings/`
* **Message:** `config(rendering): initialize hdrp and varjo vr-only settings`
* **Context:** Establishes the "Clinical Void" and Opaque VR rendering mode.

**Commit 3: Dependency Resolution**
* **Command:** `git add Packages/manifest.json`
* **Message:** `config(deps): add ultraleap openupm registry and tracking package`
* **Context:** Proves you are using modern package management for the Ultraleap SDK.

**Commit 4: Hardware Verification**
* **Command:** `git add Assets/_Project/Scenes/HardwareValidation.unity`
* **Message:** `feat(hardware): implement multi-device tracking validation scene`
* **Context:** Finalizes the "Ready" state of the project baseline.
### 3. Releases and Tagging Strategy
A "Release" in GitHub should represent a **Major Deliverable** (the end of a Sprint/Milestone), not an individual ticket. Tagging provides a permanent "snapshot" of your project at that state, which is vital for examiners who want to see your progress at specific dates.
#### Tagging Convention: Semantic Versioning (SemVer)
Use the format `v[Major].[Minor].[Patch]`
* **Major:** Breaking changes or submission.
* **Minor:** New features (end of a Sprint).
* **Patch:** Bug fixes.
#### Your Release Roadmap:
* **v0.1.0 (End of Sprint 1):** Title: `Architecture Baseline`.
    * *Trigger:* When Ticket 4 is merged and Milestone 1 is closed.
* **v0.2.0 (End of Sprint 2):** Title: `Clinical Void & Asset Ingestion`.
    * *Trigger:* When the Liver mesh and environment are locked.
* **v0.5.0 (End of Sprint 3):** Title: `Beta: Interaction Core`.
    * *Trigger:* When the Gesture State Machine and 6-DoF baseline are functional.
* **v1.0.0 (Submission):** Title: `Final Release: 6-DoF Navigation System`.
    * *Trigger:* Final QA complete. This is the version you link in your dissertatioN
### 4. Refined Execution Plan
To maximize the "Software Management" portion of the marking rubric:

1.  **PR Documentation:** In the Pull Request for each feature, don't just say "done." Write: *"Implemented the 0.25s coyote-time grace period to solve the occlusion problem identified in the risk analysis."* This links your code directly to your critical thinking.
2.  **Milestone Referencing:** In your GitHub Roadmap view, ensure the Milestones are clearly visible. Each Milestone description should summarize the **HCI goal** (e.g., *"Goal: Reduce cognitive load by replacing abstract inputs with natural gestures"*).
3.  **Labeling:** Ensure every issue has at least two labels (e.g., `feat` + `telemetry`). This helps the examiner filter your work to see how much of it was actually "Research-based" vs "Technical."

By following this commit-to-PR-to-Milestone pipeline, you create a perfect "paper trail" of professional evidence. You are no longer just a student finishing a project; you are an engineer conducting a validated study.

Mistakes in the commit history are a standard part of the development lifecycle. To fix this, we will perform a **Soft Reset**, which removes the commit from the history but keeps all your code changes sitting in your "Staging Area" so you can unstage them and re-commit them in the correct sequence.
### 1. The "Undo" Command
Execute this in your PowerShell terminal at the root of your repository:
```powershell
git reset --soft HEAD~1
```

**Why this works:** The `--soft` flag tells Git: "Delete the last commit record, but do not touch my files." Your scripts will now appear in `git status` as "Changes to be committed" (in green).

**Next, unstage the scripts specifically:**
```powershell
git restore --staged UnityProject/Assets/_Project/Scripts/
```
Now the scripts are "Untracked" (in red), and you can follow the mapping below.
### 2. Script Mapping to Milestones
Based on your Milestone deliverables, your scripts belong to three distinct phases. Do not commit them all at once; this preserves the "Audit Trail" required for your Synoptic Project.

| Script File | Target Milestone | Logic / Justification |
| :--- | :--- | :--- |
| `VarjoHandTrackingOffset.cs` | **Milestone 1** | Essential for the "Zero-offset configuration" deliverable. |
| `HDRPHandMaterialFixer.cs` | **Milestone 1** | Required for the "HDRP clinical void environment setup." |
| `UltraleapKinematicManipulator.cs` | **Milestone 2** | Core of the "primary physics-free manipulation system." |
| `AlignmentMetricsLogger.cs` | **Milestone 4** | The "CSV output pipeline" for the final experiment. |
| `ClinicalTrialManager.cs` | **Milestone 4** | Handles "task sequencing" and "trial progression." |

### 3. Step-by-Step Commit Sequence
#### **Phase A: Finalizing Milestone 1 (Foundation)**
*Focus: Hardware stability and rendering.*
```powershell
git add UnityProject/Assets/_Project/Scripts/Core/VarjoHandTrackingOffset.cs
git add UnityProject/Assets/_Project/Scripts/Interaction/HDRPHandMaterialFixer.cs
# Don't forget the .meta files
git add UnityProject/Assets/_Project/Scripts/Core/VarjoHandTrackingOffset.cs.meta
git add UnityProject/Assets/_Project/Scripts/Interaction/HDRPHandMaterialFixer.cs.meta

git commit -m "config(xr): implement varjo offset and hdrp material resolution

- Integrates VarjoHandTrackingOffset.cs to ensure zero-offset alignment between optical tracking and the HMD coordinate space
- Includes HDRPHandMaterialFixer.cs to resolve shader compatibility issues between the Ultraleap skeletal renderer and the High Definition Render Pipeline
"
```
#### **Phase B: Completing Milestone 2 (Kinematic Core)**
*Focus: Object manipulation.*
```powershell
git add UnityProject/Assets/_Project/Scripts/Interaction/UltraleapKinematicManipulator.cs
git add UnityProject/Assets/_Project/Scripts/Interaction/UltraleapKinematicManipulator.cs.meta

git commit -m "feat(interaction): implement core kinematic manipulation logic

- Introduces UltraleapKinematicManipulator.cs to handle direct object transformations
- This implementation focuses on the kinematic translation of raw skeletal data into 3D world space, supporting the initial Pinch-to-Grab functionality required for anatomical model manipulation
"
```
#### **Phase C: Orchestration & Telemetry (Milestone 4 Prep)**
*Focus: Data and trial logic.*
```powershell
git add UnityProject/Assets/_Project/Scripts/AlignmentMetricsLogger.cs
git add UnityProject/Assets/_Project/Scripts/Core/ClinicalTrialManager.cs
git add UnityProject/Assets/_Project/Scripts/*.meta
git add UnityProject/Assets/_Project/Scripts/Core/ClinicalTrialManager.cs.meta

git commit -m "feat(telemetry): implement trial orchestration and metrics logging

- Establishes the experimental data pipeline by introducing AlignmentMetricsLogger.cs for high-frequency CSV output
- Integrates ClinicalTrialManager.cs to handle the finite state machine for trial sequencing, task validation, and automated success metrics extraction
  "
```

---
### 4. Why this matters for the EPA
By splitting these, your GitHub **Insights > Network** graph will show a clear progression of features. When an examiner looks at Milestone 1, they see the configuration scripts. When they look at Milestone 2, they see the manipulation logic. 
This demonstrates that you understand the **Single Responsibility Principle** not just in your code, but in your version control management.

**One warning:** Milestone 1 is currently "Overdue by 10 days" in your metadata. Once you push these commits and merge the PR into `main`, make sure to manually update the Milestone status to "Closed" to reflect that the foundation is now secure.

Did the `git reset --soft` command successfully move the files back to your staging area without throwing any "Access Denied" errors?
# 08/04/2026
## Release / Tag Template

```markdown
USE -> ([#31](https://github.com/scAB1001/comp3932/pull/31)) instead of (#30)

## Breaking

* feat(project): initialise sprint 1 baseline with managed asset hierarchy (#30)
* config(xr): implement varjo offset and hdrp material resolution (#30)
* config(git): configure local formatting rules and node dependencies (#30)
* config(github): implement automated ci workflows for linting and releases (#30)
* chore(project): scaffold directory hierarchy for the unity project (#30)
* chore(git): initialise repository file-tracking (#30)
* chore(LFS): add LFS tracking (#30)

## Bug Fixes

* fix(git): remove comments from .oxfmtrc.json (#30)

## Maintenance

* config(github): restrict release drafter target_commitish to main branch (#30)
* chore(github): updated release-drafter to LTS (#30)
* config(github): map custom labels to release drafter configuration (#30)
* chore(github): updated Readme and bug report software versions (#30)
* chore(github): update pr and bug report templates (#30)
* chore(github): refine issue templates (#30)
* chore(git): update list of files to track (#30)
* chore(github): implement pull request template for traceability (#30)
* chore(github): implement issue templates for bug reporting and feature requests (#30)

## Documentation

* docs(README): add boilerplate Readme to repo (#30)
* docs(research): add examiner resource placeholders (#30)

## Other Changes

## Dependency Updates

## New Contributors

* @scAB1001 made their first contribution in https://github.com/scAB1001/comp3932/pull/30

**Full Changelog**: [Initial Release]
```


## How to use the latest FORMS
### Part 1: Interpreting the Raw Task Load Index (RTLX)
The RTLX measures the **Subjective Cost** of a specific action. Because you are administering it four times per control method (after Translation, Rotation, Translation+Rotation, and Scaling), you are looking for *spikes* in specific subscales. 

Each question is answered on a 1–20 scale. You can analyze this data in two ways:
#### 1. The Overall Task Load (The Macro View)
To get the overall workload for a specific task, you simply calculate the mean of the six subscales. Multiply by 5 if you wish to report it as a standard percentage (0–100).

* **Example calculation:** * Mental: 14, Physical: 8, Temporal: 10, Effort: 12, Performance: 6, Frustration: 10. 
    * Sum = 60. 
    * Average = 10 (out of 20), or an overall workload score of **50%**.
#### 2. Diagnostic Subscale Analysis (The Micro View)
This is where you will secure high marks. Do not just report the averages; contrast the subscales against your objective telemetry.

**Walkthrough Scenario: Task 3 (6-DoF Docking)**
Imagine a participant finishes Task 3 using both the joystick and then bare hands. You look at their RTLX subscales and see this:

* **VR Joystick Results:** Mental Demand: **18**, Physical Demand: **4**, Frustration: **16**.
* **Hand-Tracking Results:** Mental Demand: **6**, Physical Demand: **14**, Frustration: **8**.

**How to write this up:**
> *"Diagnostic analysis of the RTLX subscales revealed a clear trade-off between the two interfaces during 6-DoF manipulation. The legacy VR joystick imposed a severe Mental Demand (18/20), validating the hypothesis that mapping a 2D thumbstick to a 3D liver rotation induces high cognitive friction. Conversely, hand-tracking drastically reduced Mental Demand (6/20) and Frustration (8/20), as the 1:1 kinematic mapping was highly intuitive. However, this came at a physiological cost: Physical Demand spiked to 14/20 during hand-tracking, consistent with the 'Gorilla Arm' fatigue expected during unsupported mid-air interaction."*

---
### Part 2: Interpreting the System Usability Scale (SUS)
The SUS provides a reliable, high-level evaluation of the overall system. It uses a 10-item, 1–5 Likert scale. 

**Warning:** You cannot simply add the scores together. The SUS alternates between positive statements (odd numbers) and negative statements (even numbers) to prevent participants from mindlessly checking "5" down the whole page. You must normalize the scores before summing them.
#### The SUS Formula
To calculate the final score (which scales from 0 to 100), apply the following logic:
1.  **For Odd Items (1, 3, 5, 7, 9):** Subtract 1 from the user's response.
2.  **For Even Items (2, 4, 6, 8, 10):** Subtract the user's response from 5.
3.  Add all the normalized scores together.
4.  Multiply the total by 2.5.

The formal calculation is written as:
$SUS = \left( \sum (Score_{odd} - 1) + \sum (5 - Score_{even}) \right) \times 2.5$
#### Example Walkthrough: Evaluating the Hand-Tracking System
A participant finishes all tasks with the Ultraleap hand-tracking and fills out the SUS in Section B of your form. Here are their raw responses:

* Q1 (Positive): **4**
* Q2 (Negative): **2**
* Q3 (Positive): **5**
* Q4 (Negative): **1**
* Q5 (Positive): **4**
* Q6 (Negative): **2**
* Q7 (Positive): **4**
* Q8 (Negative - *Tiring to use*): **4**
* Q9 (Positive): **4**
* Q10 (Negative): **2**

**Step 1: Normalize the Odd (Positive) Questions**
* Q1: 4 - 1 = **3**
* Q3: 5 - 1 = **4**
* Q5: 4 - 1 = **3**
* Q7: 4 - 1 = **3**
* Q9: 4 - 1 = **3**
* *Odd Sum = 16*

**Step 2: Normalize the Even (Negative) Questions**
* Q2: 5 - 2 = **3**
* Q4: 5 - 1 = **4**
* Q6: 5 - 2 = **3**
* Q8: 5 - 4 = **1** *(Note: They rated it highly tiring, so this yields a low normalized score)*
* Q10: 5 - 2 = **3**
* *Even Sum = 14*

**Step 3: Calculate Final Score**
* Total Sum: 16 + 14 = 30
* Final Score: 30 × 2.5 = **75**
#### How to Interpret the Score
The SUS score is out of 100, but it is **not** a percentage. Based on decades of industry benchmarking, the average SUS score is **68**. 
* **< 51:** Poor (System requires severe redesign).
* **51 – 68:** Okay to Fair.
* **68 – 80.3:** Good (The system is usable and acceptable).
* **> 80.3:** Excellent.

**How to write this up:**
> *"The hand-tracking interface achieved a mean SUS score of 75, placing it above the industry-standard baseline of 68 and indicating 'Good' usability. While the system scored highly on intuitive integration (Q3, Q7), individual item analysis revealed that Q8 ('I found the system very tiring to use') acted as a primary detractor, further corroborating the physical demand spikes observed in the RTLX telemetry."*