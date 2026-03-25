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