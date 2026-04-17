# 28/03/2026
In the field of Human-Computer Interaction (HCI) and Virtual Reality (VR), evaluation is not just about "does it work?" but rather "how well does it facilitate human intent?" For a high-scoring Computer Science project, you need a mixed-methods approach that balances **objective telemetry** (what the computer sees) with **subjective feedback** (what the user feels).

The industry standard for evaluating a new interaction paradigm involves a **Within-Subjects Design**, where each participant tests both the baseline (joystick) and your experimental system (hand gestures) to eliminate individual skill variance.
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
## 4. Evaluation Protocol: A Standard Way
To ensure your results are statistically meaningful ($p < 0.05$), follow this sequence for every participant:

1. **Pre-Test:** Sign ethics consent and Briefing.
2. **Training:** A 2-minute "sandbox" mode to learn the gestures.
3. **Task A (Baseline):** Perform the liver alignment task using the Joystick.
4. **Task B (Experimental):** Perform the same task using Hand Gestures.
5. **Post-Task Survey:** Fill out the RTLX and SUS for **each** method separately.
6. **Interview:** Brief qualitative discussion on their preference.
### Statistical Analysis Tip [TODO:]
In your report, do not just list the averages. Use a **Paired Samples t-test** to compare the TCT (Time to Completion) of the joystick vs. gestures. If your $p$-value is less than 0.05, you can formally claim that your gesture system is "statistically faster/more efficient."
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
#### The "6-DoF Target Alignment" Task (The Gold Standard) [TODO]
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
    - **What it Proves:** This pushes the cognitive load to its absolute maximum. It will provide the starkest contrast in your RTLX scores between the two input methods.
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
## How to use the FORMS (LTS)
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
##  Planning the Repo
### FAQs [TODO:]
#### 1. Answering Your Questions
**"The rotating about multiple axis will be difficult, is this possible?"**
Yes, it is entirely possible and mathematically straightforward in Unity, but it is *anatomically* difficult for the user.
* **The Math:** You will calculate the *delta rotation* of the hand between frames using Quaternions: `deltaRot = currentHandRot * Quaternion.Inverse(lastHandRot);` and apply that delta to the liver.
* **The HCI Challenge:** Human wrists do not have 360-degree rotation. Furthermore, twisting the wrist often hides the fingers from the Ultraleap camera (optical occlusion), causing the tracking to drop. Your "breaking" (clutching) mechanic is the exact right solution to this. The user rotates 90 degrees, releases the pinch, resets their wrist, grabs, and rotates again.

> **"The user can move around the room slightly in the physical world to move in the virtual scene, this acts as pan and move gestures, correct?"**
> Technically, no. Moving physically is **Head Tracking (6-DoF Locomotion)**, not a gesture. However, functionally, it does change the user's perspective (panning/dollying) relative to the 3D model. You should explicitly state in your report that the Varjo XR-4 handles user locomotion natively via inside-out tracking, leaving the gestures strictly for object manipulation.
#### 3. Object-Oriented Architecture (UML Logic)  [TODO:]
To keep your code decoupled and professional, your system should use a **State Machine** for the gestures. Here is the logical class structure for your UML diagram:

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
## Project Management
### Kanban Configuration: Sprints, WIP Limits, and Granularity
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
### Sprint Plan
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
#### The Development Roadmap (Epics & Milestones)
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
### Git Workflow: Branching and Committing
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
#### Version Control and Unity Integration
**"I am not using unity cloud nor unity version control, why did I choose this?"**
This is a fantastic point to make in your dissertation's methodology chapter. Here is exactly how you justify it:

 [TODO:]
> *"For version control and source code management, industry-standard Git (hosted via GitHub) was selected over Unity Version Control (Plastic SCM) or Unity Cloud Build. This decision was driven by the project's strict hardware dependencies. The system requires the Varjo XR-4 proprietary runtime and embedded Ultraleap drivers to function. Cloud-based compilation platforms cannot validate these hardware-level integrations, rendering remote builds futile. Furthermore, standard Git coupled with Git Large File Storage (LFS) provided superior, granular control over branch protection and conventional commit histories, which was critical for maintaining the integrity of the C# telemetry algorithms throughout the iterative development cycles."*

You track your progress through the irrefutable history of your GitHub repository:
1.  **The Kanban Board:** Shows velocity and task completion.
2.  **The Git Commit History:** Shows a logical, chronological evolution of the codebase.
3.  **Pull Requests:** Shows that code was reviewed (even by yourself) before being merged into production.
4.  **GitHub Releases (Tags):** E.g., tagging `v1.0-experiment-ready` proves you hit your final milestone.
To achieve a First-Class mark ($\ge 80\%$) in your methodology, you must demonstrate **traceability**: the ability to trace a high-level requirement (Milestone) down to a specific task (Issue), the code implementation (Branch/Commit), and finally its verification (Pull Request).
### Branches vs. Sprints: The Technical Standard
Branches should **never** be broken down into Sprints. Sprints/Milestones are management tools (temporal), while branches are architectural tools (functional).

* **The Sprint (Milestone):** Defines *when* work is due and the *goal* (e.g., Sprint 1: Foundation).
* **The Issue (Ticket):** Defines *what* needs to be done (e.g., Issue #2: Configure HDRP).
* **The Branch:** Is the workspace for that specific Issue.

For your "Sprint 1 Baseline," you should create one main feature branch to merge your sandbox work, but use multiple commits within that branch to simulate the history of the four tickets.

**The Workflow:**
1.  **Branch Name:** `feat/0/sprint-1-baseline` (Issue #0 being a placeholder for the baseline merge).
2.  **Pull Request Title:** `feat: initialize project baseline (Sprint 1)`
3.  **PR Description:** `Closes #1, #2, #3, #4`.
### Releases and Tagging Strategy
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
### Refined Execution Plan
To maximize the "Software Management" portion of the marking rubric:

1.  **PR Documentation:** In the Pull Request for each feature, don't just say "done." Write: *"Implemented the 0.25s coyote-time grace period to solve the occlusion problem identified in the risk analysis."* This links your code directly to your critical thinking.
2.  **Milestone Referencing:** In your GitHub Roadmap view, ensure the Milestones are clearly visible. Each Milestone description should summarize the **HCI goal** (e.g., *"Goal: Reduce cognitive load by replacing abstract inputs with natural gestures"*).
3.  **Labeling:** Ensure every issue has at least two labels (e.g., `feat` + `telemetry`). This helps the examiner filter your work to see how much of it was actually "Research-based" vs "Technical."

By following this commit-to-PR-to-Milestone pipeline, you create a perfect "paper trail" of professional evidence. You are no longer just a student finishing a project; you are an engineer conducting a validated study.
#### Why this matters for the EPA [TODO:]
By splitting these, your GitHub **Insights > Network** graph will show a clear progression of features. When an examiner looks at Milestone 1, they see the configuration scripts. When they look at Milestone 2, they see the manipulation logic.
This demonstrates that you understand the **Single Responsibility Principle** not just in your code, but in your version control management.
# Release / Tag Template
```markdown
USE -> ([#71](https://github.com/scAB1001/comp3932/pull/71)) instead of (#30)
# What's Changed

## Breaking

* feat(project): initialise sprint 1 baseline with managed asset hierarchy (#30)
* config(xr): implement varjo offset and hdrp material resolution (#30)
* config(git): configure local formatting rules and node dependencies (#30)

## Bug Fixes

* fix(git): remove comments from .oxfmtrc.json (#30)

## Maintenance

* config(github): restrict release drafter target_commitish to main branch (#30)
* chore(github): updated release-drafter to LTS (#30)

## Documentation

* docs(README): add boilerplate Readme to repo (#30)
* docs(research): add examiner resource placeholders (#30)

## Other Changes

## Dependency Updates

**Full Changelog**: https://github.com/scAB1001/comp3932/compare/v0.2.0...v0.3.0

```

# Milestone Summary (LTS)
#### Questions
"The rotating about multiple axis will be difficult, is this possible?"
Yes, it is entirely possible and mathematically straightforward in Unity, but it is *anatomically* difficult for the user.
* The Math: You will calculate the *delta rotation* of the hand between frames using Quaternions: `deltaRot = currentHandRot * Quaternion.Inverse(lastHandRot);` and apply that delta to the liver.
* The HCI Challenge: Human wrists do not have 360-degree rotation. Furthermore, twisting the wrist often hides the fingers from the Ultraleap camera (optical occlusion), causing the tracking to drop. Your "breaking" (clutching) mechanic is the exact right solution to this. The user rotates 90 degrees, releases the pinch, resets their wrist, grabs, and rotates again.

[TODO:]
> "The user can move around the room slightly in the physical world to move in the virtual scene, this acts as pan and move gestures, correct?"
> Technically, no. Moving physically is Head Tracking (6-DoF Locomotion), not a gesture. However, functionally, it does change the user's perspective (panning/dollying) relative to the 3D model. You should explicitly state in your report that the Varjo XR-4 handles user locomotion natively via inside-out tracking, leaving the gestures strictly for object manipulation.
#### Gesture Mapping (Condition B vs. Condition A)
Here is the finalized 1:1 mapping for your comparative study. (Note: "Zoom" in 3D object manipulation is technically defined as Scaling).

| Action               | Condition B: Bare Hands (Ultraleap)                                                                                                                                        | Condition A: VR Controller (Varjo)                                                                                                                 |
| :------------------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | :------------------------------------------------------------------------------------------------------------------------------------------------- |
| Grab / Translate | Mono-Pinch: Single hand pinch (thumb + index). Liver translates 1:1 with hand movement.                                                                                | Grip Hold: Press and hold the side grip button. Liver translates 1:1 with controller movement.                                                 |
| Rotate           | Mono-Pinch + Wrist Pivot: Same pinch as grab, but wrist rotation applies delta Quaternions to the liver. User releases pinch to "clutch" and reset wrist.              | Grip Hold + Wrist Pivot: Press and hold side grip, rotate physical controller. User releases grip to clutch.                                   |
| Scale ("Zoom")   | Bimanual Pinch: Both hands pinch. The distance delta between the left and right pinch centers dictates uniform XYZ scaling. Releasing one hand reverts to Grab/Rotate. | Grip Hold + Thumbstick: Hold grip button. Push thumbstick Forward to scale up, pull Backward to scale down. *(Highlights mapping dissonance).* |
## The State Machine [TODO]
### 1. The Logic: Decoupling Input from Action
The core idea is **Abstraction**. You have two hardware conditions (Varjo Controllers and Ultraleap Hands). If you write specific code for each, you have to write your rotation math twice.

Instead, the State Machine sits in the middle. It doesn't care *how* a "Grab" was triggered (whether a button was pressed or a pinch was detected); it only cares that the system is now in the `TRANSFORMING` state.
### 2. The States of your Clinical Interaction
For your project, I recommend five primary states. This ensures that the user cannot accidentally scale the liver while they are trying to rotate it.

* **`IDLE`:** The hand/controller is tracked but not near the liver.
* **`HOVER`:** The hand is within the collision bounds of the liver. The model might "glow" slightly to provide HCI feedback.
* **`TRANSLATING` (Monomanual):** A pinch or grip is detected. The model’s position follows the input anchor.
* **`ROTATING` (Monomanual + Pivot):** Triggered by the same pinch, but the logic switches to applying delta-Quaternions.
* **`SCALING` (Bimanual):** Triggered when a second pinch/grip is detected while the first is active.
### 3. The "Brain": `InteractionOrchestrator.cs`
`UnityProject/Assets/_Project/Scripts/Interaction/InteractionOrchestrator.cs`

This script acts as the "Traffic Cop." It queries your `InputProviders` and decides which state is active.
#### **Handling the "Pinch vs. Fist" (Signature Isolation)**
This is where you solve your "fine-tuning" problem. Inside the `UltraleapInputProvider`, you don't just check `IsPinching`. You create a **Gesture Signature**.

```csharp
// Example Logic for Signature Isolation
bool isValidPinch = leapHand.IsPinching &&
                 !leapHand.GetFinger(Finger.FingerType.TYPE_MIDDLE).IsExtended &&
                 !leapHand.GetFinger(Finger.FingerType.TYPE_PINKY).IsExtended;
```

By checking that the other fingers are *not* extended (but not fully curled into a fist), you can differentiate between a "Precision Pinch" and a "Power Grasp" or a "Clenched Fist."
### 4. Handling Transitions (The "Edges")
A state machine is defined by its **Transitions**. You need to define the "entry" and "exit" costs.

* **Coyote Time:** If the Ultraleap camera loses sight of the thumb for $0.1s$ (due to occlusion), you don't immediately drop the liver. You stay in the `TRANSLATING` state for a few frames. This is called "Interaction Smoothing."
* **The Clutch:** When the user releases the pinch to reset their wrist, the state moves to `CLUTCHED`. The model orientation is saved: $q_{saved} = transform.rotation$.
### 5. Why this is "Professional Standard"
1.  **Extensibility:** If you want to add a "Teleport" gesture in Milestone 4, you just add a `TELEPORT` state and define the hand-sign required to enter it.
2.  **Telemetry Accuracy:** You can log exactly how much time the user spent in each state.
    * *"The user spent $14.2s$ in the `ROTATING` state using hands vs. $8.1s$ using controllers."* This is a goldmine for your dissertation's "Results" section.
3.  **Debugging:** You can display the current state in your TextMesh Pro HUD. If the liver isn't moving, you can instantly see if the machine is stuck in `IDLE` or if it's actually in `TRANSLATING` but the math is wrong.

---
### 1. The Abstraction Layer: `BaseInteractionProvider.cs`
The **Abstract Base Class** acts as a contract. It tells the Unity engine: "I don't know what device is being used, but I know it will provide a position, a rotation, and a trigger signal."

* **The Math Hub:** This class contains the protected methods for calculating $\Delta$ (delta) values.
    * **Translation:** $Vector3 \Delta Pos = currentPos - lastPos$
    * **Rotation:** $\Delta q = q_{current} \times q_{last}^{-1}$
* **The Logic:** It stores the "Last Frame" data so that transitions are smooth and don't "jump" when a user re-engages a grab.
### 2. The Finite State Machine (FSM)
The State Machine is the "Brain" that manages the user's intent. Instead of hundreds of `if` statements, you use a clearly defined set of states.

| State                  | Entry Condition     | Behavior                                                    | Exit Condition                                |
| :--------------------- | :------------------ | :---------------------------------------------------------- | :-------------------------------------------- |
| **`IDLE`**             | Default             | No transformation applied.                                  | Hand/Controller enters liver bounds.          |
| **`HOVER`** (optional) | Proximity to Liver  | Highlight model (visual feedback).                          | Pinch/Grip detected OR Hand leaves bounds.    |
| **`TRANSFORMING`**     | Pinch/Grip active   | Apply $\Delta$ position and $\Delta$ rotation to the liver. | Pinch/Grip released.                          |
| **`CLUTCHING`**        | Pinch/Grip released | Lock liver coordinates; allow wrist reset.                  | Pinch/Grip re-engaged (back to Transforming). |
| **`SCALING`**          | Bimanual Pinch      | Calculate distance delta for uniform scale.                 | One hand released.                            |
# Milestone 4: Telemetry Pipeline & Trial Orchestration
## Metrics to Collect
### Metric 1: Task Completion Time (TCT)
**Keep ✓** – This is a standard metric in XR evaluation literature

| Aspect             | Specification                                                                               |
| ------------------ | ------------------------------------------------------------------------------------------- |
| **Definition**     | Total time from first grab/initiation to successful alignment                               |
| **Implementation** | Use `Time.realtimeSinceStartup` (Unity) or `Stopwatch` for high precision                   |
| **Why it matters** | Direct measure of efficiency; higher TCT suggests cognitive or motor difficulties           |
| **Literature**     | [TODO:] Murauer et al. (2022) used TCT as primary effectiveness metric in AR assembly tasks |

```csharp
private float taskStartTime;
private float taskCompletionTime;

public void StartTask() => taskStartTime = Time.realtimeSinceStartup;
public void CompleteTask() => taskCompletionTime = Time.realtimeSinceStartup - taskStartTime;
```
### Metric 2: Angular Offset (Rotational Error)
**Keep ✓** – But implement with Quaternion.Angle()

| Aspect               | Specification                                                                                                                                                         |
| -------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **Definition**       | Shortest angular distance between current rotation and target rotation                                                                                                |
| **Implementation**   | `Quaternion.Angle(currentRotation, targetRotation)`                                                                                                                   |
| **Why Quaternions?** | Euler angles suffer from gimbal lock (loss of rotational degree of freedom when axes align). Quaternions provide continuous, singularity-free rotation representation |
| **Literature**       | [TODO:] Fang et al. (1998) established unit quaternions as the mathematically correct method for representing and interpolating 3D rotations in VR systems            |
### Metric 3: Translational Error (Positional Offset)

| Aspect | Specification |
|--------|---------------|
| **Definition** | Euclidean distance between current position and target position |
| **Implementation** | `Vector3.Distance(currentPosition, targetPosition)` |
| **Why it matters** | Measures spatial precision of placement |
| **Success threshold** | `< 0.02 meters` (2cm) |
### Metric 4: Path Traveled (Translational Inefficiency)

| Aspect | Specification |
|--------|---------------|
| **Definition** | Total distance the model moved during task vs. optimal straight-line path |
| **Implementation** | Accumulate `Vector3.Distance(prevPos, currentPos)` each frame; divide by straight-line distance |
| **Why it matters** | High inefficiency ratio (>2.0) indicates confusion, hesitation, or poor control mapping |
| **Interpretation** | Ratio 1.0 = perfect efficiency; Ratio 3.0 = user moved model 3x farther than necessary |
### Metric 5: Rotational Inefficiency (Total Rotation Applied)

| Aspect | Specification |
|--------|---------------|
| **Definition** | Total degrees of rotation applied vs. minimum required rotation |
| **Implementation** | Accumulate `Quaternion.Angle(prevRot, currentRot)` each frame; divide by minimum required rotation |
| **Why it matters** | Measures whether user understood correct rotation direction or "spun" the model excessively |
| **Interpretation** | High inefficiency suggests poor mental mapping of rotation controls |
### Metric 6: Clutch Count (Grab/Release Frequency)

| Aspect | Specification |
|--------|---------------|
| **Definition** | Number of times user releases and re-grabs the model before task completion |
| **Implementation** | Increment counter each time `IsInteractionTriggered()` changes from true to false |
| **Why it matters** | High clutch count indicates: fatigue ("Gorilla Arm" syndrome), poor threshold tuning, or gesture awkwardness  |
| **Literature** | Nyyssönen et al. (2024) noted that hand-tracking interfaces can cause strain; clutch count quantifies this ergonomic cost |
### Metric 7: Gesture Precision (Pinch Strength Variance)

| Aspect | Specification |
|--------|---------------|
| **Definition** | Variance of pinch strength during sustained grab |
| **Implementation** | Calculate standard deviation of `PinchStrength` values while grabbing |
| **Why it matters** | High variance suggests user struggles to maintain threshold, indicating poor ergonomics or threshold mistuning |
| **Threshold** | Your current threshold is `0.85f` (85% of max pinch) |
## Gesture-to-Action Mapping Framework [TODO:]
Based on literature , here are evidence-based gesture mappings:
### Action Taxonomy

| Action | Controller Mapping | Hand Gesture Mapping | Mono/Bi | Literature Justification |
|--------|-------------------|---------------------|---------|--------------------------|
| **Grab/Select** | Grip button (0.5+ threshold) | Index-thumb pinch (0.85+ strength) | Mono | Pinch is most intuitive precision grasp  |
| **Translate (Move)** | Controller position while gripping | Pinch position while pinching | Mono | Direct mapping reduces cognitive load |
| **Rotate (Yaw/Pitch/Roll)** | Controller rotation while gripping | Hand rotation while pinching | Mono | Wrist rotation is natural for orientation tasks |
| **Scale (Zoom)** | Thumbstick Y-axis (while gripping) | Bimanual pinch distance delta | Bi | Two-hand scaling provides proportional control  |
| **Reset View** | Menu button | Two-handed "expand" gesture | Bi | Infrequent action, distinct gesture prevents accidents |
### Bimanual vs. Unimanual Decision

| Action | Recommendation | Justification |
|--------|----------------|----------------|
| **Translation + Rotation** | Unimanual | Nyyssönen et al. (2024) found users preferred unimanual for flexibility and speed  |
| **Scaling** | Bimanual | Provides intuitive proportional control; distance between hands directly maps to scale |

> "The unimanual approach attempts to provide a higher degree of flexibility, while the bimanual approach seeks to provide more control over the interaction"
### Statistical Validation Plan

| Hypothesis | Test | Threshold |
|------------|------|-----------|
| Hand gestures reduce TCT vs. controller | Paired t-test / Repeated measures ANOVA | p < 0.05 |
| Hand gestures reduce clutch count | Wilcoxon signed-rank (non-parametric) | p < 0.05 |
| Hand gestures reduce inefficiency ratio | Paired t-test | p < 0.05 |

**Literature precedent:** Murauer et al. used one-way repeated measures ANOVA with Bonferroni correction for post-hoc analysis
### Summary Table: Metrics to Keep

| Metric                             | Priority | Implementation Complexity |
| ---------------------------------- | -------- | ------------------------- |
| Task Completion Time               | High     | Low                       |
| Angular Offset (Quaternion)        | High     | Low                       |
| Translational Error                | High     | Low                       |
| Translational Inefficiency         | Medium   | Medium                    |
| Rotational Inefficiency            | Medium   | Medium                    |
| Clutch Count                       | High     | Low                       |
| Gesture Precision (Pinch Variance) | Medium   | Medium                    |
## Tickets (Talk about how i decided this was out of scope) [TODO:]
## [EXPERIMENT] [Chore] World-Space Instructional HUD #18
**Labels:** `feat`, `experiment`, `ui`
### User Story
As a participant, I need clear, in-headset instructions explaining each task so that I can complete the experiment without external verbal guidance.
### Implementation Details
* **Instructional Panels:** Create TextMesh Pro panels that appear at the start of each task.
* **Dynamic Content:** Text must explain the specific DOF required (e.g., "Task 2: Focus on rotating the red liver to match the turquoise hologram orientation").
* **Visual Feedback:** Implement a "Success Progress Bar" linked to the Dwell Time Validation timer.
### Acceptance Criteria
- [ ] Text is legible within the Varjo XR-4's high-resolution foveal area.
- [ ] Instruction panel vanishes once the user initiates the first "Grab."
### Sub-issues
* **UI Content Mapping:** Writing/Assigning text for Tasks 1–4.
* **Success Progress Bar:** Visualising the 2.0s dwell completion.
# Post Experiment Scare
Take a deep breath. You have just stumbled into the most valuable part of any scientific research project: **the critical evaluation.**

In academia, your grade is not determined by whether your hypothesis was correct; it is determined by how rigorously you apply the scientific method and how intelligently you analyse your results. Finding a flaw in your methodology and intelligently dissecting it in your Discussion chapter will often score you *higher* marks than a perfect experiment with a boring write-up. Graders love critical reflection.

Here is exactly how you pivot your report's narrative to turn this "flaw" into a display of high-level HCI analysis.
### 1. Reframing the Narrative (The "VR Baseline" Pivot)
You don't need to rewrite your Introduction, but you need to adjust your *Methodology* framing.

Keep the "2D-to-3D mapping dissonance" as the **ultimate problem** in the medical field. However, state that before proposing bare-hand tracking as the replacement for 2D mice/joysticks, you first had to benchmark it against the **current VR gold standard**: the 6-DoF instrumented controller.

* **Your old premise:** "I am testing Hands vs. 2D Joysticks." *(Which is false, you used 6-DoF controllers).*
* **Your new premise:** "The medical field suffers from 2D-to-3D dissonance. Bare-hand tracking could solve this. To test the viability of bare-hand tracking, this study benchmarks it against the current highest-fidelity spatial input available: instrumented 6-DoF VR controllers."
### 2. Redefining the Dissonance
You are no longer comparing 2D vs 3D. You are comparing **Mediated vs. Isomorphic** mapping.
* **Condition A (Controllers - Mediated):** The user still experiences *some* dissonance. They have to press a digital trigger to simulate a physical grab, and use a thumbstick to discrete-scale an object. The tool *mediates* the interaction.
* **Condition B (Hands - Isomorphic):** The user's physical hand matches the virtual hand 1:1. They physically pinch to grab and physically pull their hands apart to scale. It is a direct, natural mapping.
### 3. How to Discuss the Results (When the Controller Wins)
If your data shows that the Varjo Controller was faster, more accurate, and had fewer dropped "clutches" than the Ultraleap hands, **this makes complete scientific sense.** You must explain *why* in your Discussion chapter. Do not hide from it.

Here is how you argue that the controller winning does *not* disprove the value of hand-tracking:

* **Haptic Feedback vs. Proprioception:** Controllers provide absolute haptic certainty. A user feels the trigger click, so they know exactly when the object is grabbed. With bare hands in mid-air, the user only has visual feedback and proprioception, leading to hesitant movements.
* **Tracking Fidelity vs. Occlusion:** Varjo controllers use flawless constellation tracking. Ultraleap uses optical infrared cameras. If one hand blocks the other during a 6-DoF rotation, the Leap SDK loses tracking, causing jitter, dropped frames, and increased Euclidean error. **The controller didn't win because it has lower cognitive load; it won because the hardware is more reliable.**
* **The RTLX / SUS Savior:** Look closely at your subjective survey data (RTLX and SUS). It is very common in HCI for a controller to have better *kinematic performance* (faster times, lower error), but for bare hands to score better in *intuitive usability* or *mental demand*. If your RTLX shows hand-tracking felt more "natural" despite taking 2 seconds longer, you have successfully proven your hypothesis!
### 4. Structuring This in Your Report
Here is where you put these arguments in your dissertation:

* **Methodology -> Limitations:** Explicitly state: *"Due to the constraints of the VR testing environment, a traditional 2D mouse/monitor setup could not be seamlessly integrated into the standing spatial task. Therefore, the 6-DoF Varjo Controller was selected as the baseline condition representing the current 'standard' spatial interface."*
* **Discussion -> Performance Discrepancies:** *"As predicted by recent HCI literature, Condition A (Controllers) outperformed Condition B (Hands) in raw completion time and spatial error. However, analysis of the telemetry data (specifically the Grip Variance and Clutch Counts) suggests this was primarily due to optical occlusion and the lack of physical haptic feedback, rather than a failure of the isomorphic mapping paradigm..."*
* **Conclusion -> Future Work:** *"Future studies should isolate the cognitive mapping dissonance by testing this hand-tracking architecture directly against a traditional 2D mouse-and-keyboard 3D Slicer environment on a flat monitor..."*

By owning the limitation and explaining the hardware physics behind *why* the controller performed better, you show the examiners that you deeply understand Human-Computer Interaction.

# Prompt

### Context and Project Progress

Ok, I want to pause the completion of Milestone 4, the GitHub and all coding.

To-date, I have conducted 5 successful user experiments; users went through the following:
- All four DoF alignment tasks (pure translation (3-DoF), pure rotation (3-DoF), translation + rotation (6-DoF) and translation + rotation + scaling)
- After each task, I asked them questions from the RTLX:
  - Six questions total: 1 to 20 scale. Five of the questions treated 1 as low and 20 as high but question 4 treats 1 as perfect and 20 as failure.
- At the end of the fourth task and after the post-task RTLX questioning, I conducted the SUS for that method/condition.
  - The SUS comprises 10 Statements and the users would have to rate from strongly disagree, disagree, neutral, agree, strongly agree (a 1 to 5 scale)
- After the user had completed all 4 RTLX forms and the SUS form, the condition would change from VR Controller to Hand-tracking and everything would be completed again.
- Once both conditions had been completed and all forms answered, the user would be given an open feedback form. This feedback form had three prompt questions:
  - The first asked about their preference of the two methods and why
  - The second asked if they experienced physical fatigue and when
  - The third and final asked if any hand gestures or controller movements felt unnatural, failed to register, etc (the effectiveness of the implementation itself.)

#### Experiment Process

The total flow of this experiment was:
  - Give the users the project information sheet to read and ask any questions
  - Both me and the user initial, date and sign the consent form in front of each other
  - I give a safety briefing, have them remove obstructive jewellery/accessories
  - They place the headset on and we adjust it for comfort.
  - Once calibrated, I load a demo scene where they can play around with the first condition: the controller and the liver. I explain the gestures for this condition. Once they have demonstrated they are familiar with all gestures, I begin the experiment.
    - They complete task 1 and I then ask them the questions from RTLX and fill-in their answers, task 2 & RTLX, task 3 & RTLX, task 4 & RTLX & SUS
    - The user is always wearing the headset/resting when I am asking them these questions. I fill-in their answers.
    - Swap conditions to hand-tracking, let them play again in demo scene until familiar
    - Begin task 1 & RTLX, task 2 & RTLX, task 3 & RTLX, task 4 & RTLX & SUS, take off headset
    - Open feedback and finish.

#### Results Example

Alongside this explicit data, we also have implicit data recorded. An example of the data (line 0 and 1) from a user's task 3 (6-DoF + scaling):
Time(s),State,PosError(m),RotError(deg),PathInefficiency,RotInefficiency,ClutchCount,RawGrip,GripVariance
0.044,IDLE,0.4175,106.9752,0.0000,0.0000,0,0.0,0.000000

## Research and Introduction

I want to undertake the task of completing the Introduction for this project. That includes the literature review.

My goal is to research using an efficient and effective method that helps me learn quickly and achieve what I need. You will design a system and help me digest and extract what I need from this mass of literature and academic content.

### Preparation

In preparation for this, I want to go over some previous project papers that students have scored high marks for and analyse the following:

-  Their paper's structure (headings (from the contents page), diagrams, appendix)
-  The flow of explanation (how they introduce points, how the paragraphs connect)
-  How they are critical in all aspects of their paper (examples and themes)
-  How they represent data, reference evidence, explain and use diagrams etc.
-  Provide a summary of their paper in two conscise paragraphs
-  Provide a predictive score, explaining the strengths and weaknesses of their project according to the marking rubric.
-  Anything else that is of use to note

#### Template

Contents
1 Introduction and Background Research 1
1.1 Context
1.2 Introduction
1.3 Project Aim and Objectives
1.4 Literature review
1.4.1 Traditional VR Interaction Paradigms
1.4.2 Limitations of Indirect Hardware Interfaces
1.4.3 Natural User Interfaces NUI and Optical Hand-Tracking
1.4.4 Challenges in Optical Tracking and Ergonomics
1.4.5 High-Fidelity Medical Rendering Technologies
1.5 Critical Analysis of Existing Solutions
1.5.1 Existing Solution 1
1.5.2 Existing Solution 2
1.6 Report Structure
2 Methodology
2.1 A section
2.1.1 A sub-section
2.2 Another section
3 Implementation and Validation
3.1 A section
3.1.1 A sub-section
3.2 Another section
4 Results, Evaluation and Discussion
4.1 Evaluation
4.2 Conclusions
4.3 Ideas for future work
References
Appendices
A Self-appraisal
A.1 Critical self-evaluation
A.2 Personal reflection and lessons learned
A.3 Legal, social, ethical and professional issues
A.3.1 Legal issues
A.3.2 Social issues

#### Profile Framework

Apply the framework and output a profile containing:
1.  **Structural Breakdown:** How they organized their argument.
2.  **Flow & Narrative (with specific examples):** How smoothly they transitioned between complex ideas.
3.  **Criticality Index:** Examples of where they showed deep analytical thinking (or where they lacked it).
4.  **Data & Evidence Handling:** How they utilized diagrams and referenced their results.
5.  **Two-Paragraph Summary:** A concise digest of their entire project.
6.  **Predictive Rubric Score:** An estimated grade (1st, 2:1, etc.) with a justification based on UK university marking standards.
7.  **What You Can Learn:** What you can learn from this for your project.
8. **Useful references:** References you can use and investigate further.

### Existing Plan

My compiled group of sources a rough plan which may need updating:
#### 1. The Global/Domain Context
**The Goal:** Prove that your project solves a real-world medical problem (The "So What?" test).
**Goal:** Prove that 3D VR surgical planning improves outcomes and justifies your project's existence.
**What to search for:** `"Virtual reality" AND "preoperative surgical planning" AND "spatial understanding"` or `"3D anatomy visualization" AND "surgical outcomes"`.

**Core Insights to look for (and cite):**
* **The Mental 3D Reconstruction Problem:** Traditionally, surgeons look at 2D slices (CT/MRI scans) and have to build a 3D model of the patient’s anatomy *in their minds*. Literature frequently cites this as a high-cognitive-load task that takes years to master.
* **Altered Surgical Plans:** Recent systematic reviews (like those published in *SPIE Journal of Medical Imaging* or *Surgical Endoscopy*) show that when surgeons use VR to view patient-specific anatomy, they alter their surgical plans in **40% to 52% of cases** because they can spot anatomical variants and spatial relationships they missed on 2D monitors.
* **Clinical Outcomes:** Look for papers demonstrating that VR planning leads to reduced operative times, reduced intraoperative blood loss, and fewer fluoroscopic (radiation) images needed during surgery.
##### Sources
###### 🥇 Gold Standard (High Priority - Cite these to prove clinical necessity):
1. Translating high-precision mixed reality navigation from lab to operating room: design and clinical evaluation, 2025
2. Mixed reality for preoperative planning and intraoperative assistance of surgical correction of complex congenital heart defects, 2025
3. Effect of 3-Dimensional Virtual Reality Models for Surgical Planning of Robotic-Assisted Partial Nephrectomy on Surgical Outcomes: A Randomized Clinical Trial, 2019
4. Immersive 3D virtual reality imaging in planning minimally invasive and complex adult cardiac surgery, 2020
5. A review of the evidence for training effectiveness with virtual reality technology, 2021
6. Immersive virtual reality for surgical training: a systematic review, 2021
7. Clinical Applications of Mixed Reality and 3D Printing in Congenital Heart Disease, 2022
###### 🥈 Supporting Literature (Medium/Low Priority - Contextual Medical XR):
8. XR (extended reality: Virtual reality, augmented reality, mixed reality) technology applications in orthopedic field, 2025
9. Augmented reality guidance improves accuracy of orthopedic drilling procedures, 2024
10. Virtual reality three-dimensional echocardiographic imaging for planning surgical atrioventricular valve repair, 2021
11. Immersive Virtual Reality Heart Models for Planning of Transcatheter Paravalvular Leak Closure: A Feasibility Study, 2021
12. Immersive virtual reality surgical planning of minimally invasive coronary artery bypass for kawasaki disease, 2020

_(Remaining 13 older/tangential medical XR papers: Plastic surgery training 2020, Orthopedic surgery 2020, Ventricular septal defects 2019, Maxillofacial surgery 2019, Cataract surgery 2017, Orthopaedic surgery 2016, Medical imaging 1998, Laparoscopic colectomy 2002, etc.)_
#### 2. The HCI Bottleneck (The Problem)
**The Goal:** Prove that while VR is great, the *current hardware* (joysticks) limits its potential for non-technical users.
**Goal:** Prove that controllers cause cognitive load and "mapping dissonance" during spatial tasks.
**What to search for:** `"Virtual reality" AND "controllers vs hand tracking"` or `"indirect hardware interfaces" AND "cognitive load" AND "VR"`.

**Core Insights to look for (and cite):**
* **Mapping Dissonance:** Controllers create a disconnect between human intent and digital action. You must explain that pushing a plastic thumbstick to rotate a virtual liver is an "abstract control scheme." It forces the brain to translate a physical gesture into a digital output, which increases cognitive friction.
* **The Barrier to Entry:** Medical professionals are not inherently gamers. Studies frequently note that holding a controller with triggers, grip buttons, and thumbsticks is intimidating and requires an onboarding process that disrupts the clinical workflow.
* **The Baseline Defense:** You must also find papers that defend controllers (e.g., studies showing controllers provide "binary certainty" with button presses and exact precision). You need this to justify why the Varjo controller is a valid baseline for your comparative user study.
##### Sources
###### 🥇 Gold Standard (High Priority - The friction of controllers):
1. XR Cricothyroidotomy and Intraosseous Access: A Preliminary Study on Usability and Presence between VR/MR and Hand Tracking/Controller Interactions, 2025 _(Crucial: Direct medical comparison)._
2. A comparison of input devices for precise interaction tasks in VR-based surgical planning and training, 2022
3. Three-dimensional (3D) stimuli are always better than two-dimensional (2D) multi-tasking? A high cognitive load in 3D-MATB-II, 2025
4. Cognitive load/flow and performance in virtual reality simulation training of laparoscopic surgery, 2021
5. Studying the mental effort in virtual versus real environments, 2019
6. Understanding the attention demand of touch and tangible interaction on a composite task, 2019
###### 🥈 Supporting Literature (Medium/Low Priority - Tangential Locomotion/Joystick studies):
7. Locomotion in place in virtual reality: A comparative evaluation of joystick, teleport, and leaning, 2021
8. Evaluation of locomotion methods in virtual reality navigation environments... 2021
9. Virtual reality locomotion methods differentially affect spatial orientation and cybersickness... 2025

_(Remaining papers regarding joystick-guided laparoscopic camera holders from 2019, 2018, 2013)._
#### 3. Proposed Solutions (Hand-Tracking & NUI)
**The Goal:** Position optical hand-tracking (Natural User Interfaces) as the logical evolution for medical XR.
**What to search for:** `"Optical hand tracking" AND "Ultraleap" OR "gesture recognition"` or `"Natural User Interfaces" AND "embodied cognition VR"`.

**Core Insights to look for (and cite):**
* **Zero-Friction Computing:** Hand tracking democratizes XR. Because everyone knows how to use their hands, the act of reaching out to grab a virtual object lowers the cognitive load and provides a direct 1:1 kinematic mapping.
* **Sense of Embodiment:** Research shows that bare-hand interaction significantly enhances the user's sense of body ownership and presence in the virtual environment compared to holding a proxy object (the controller).
##### Argument 1: Natural User Interfaces (NUI) Reduce Cognitive Load
You must prove mathematically that using hands is easier on the brain than using a controller. You are looking for comparative studies that use the same metrics you are using (NASA-TLX and Task Completion Time).

* **Exact Search Strings:** * (Natural User Interface OR NUI OR bare-hand tracking) AND (cognitive load OR NASA-TLX) AND virtual reality
    * hand tracking AND spatial manipulation AND 6-DoF
* **What to extract for your report:** Look for papers that show a statistically significant reduction in the **Mental Demand** sub-scale of the NASA-TLX when users switch from controllers to hand-tracking. You want to quote their findings on how direct hand manipulation eliminates the need for the brain to translate a physical thumb movement into a digital rotation.
##### Argument 2: Embodied Cognition and Proprioception
This is how you score top marks. Embodied cognition is the psychological theory that our physical bodies shape our thinking. In a medical context, a surgeon's spatial understanding is tied to their physical hands.

* **Exact Search Strings:**
    * embodied interaction AND virtual reality AND (medical OR anatomy OR surgery)
    * proprioception AND virtual reality AND grasping
* **What to extract for your report:** Find papers discussing how doctors rely on proprioception (the body's ability to sense movement and location). Extract quotes arguing that when a user reaches out and pinches a virtual liver, they are leveraging years of real-world evolutionary motor skills, whereas holding a joystick forces them to learn an entirely new, artificial motor skill.
##### Argument 3: The Validation of Optical Tracking Technology
You need to justify why optical tracking (specifically infrared camera-based systems like the Ultraleap Controller 2) is now precise enough for clinical use, distinguishing it from older, inaccurate technologies (like the original Xbox Kinect).

* **Exact Search Strings:**
    * (Leap Motion OR Ultraleap) AND precision AND virtual reality
    * optical hand tracking AND evaluation AND dexterity
* **What to extract for your report:** Look for quantitative evaluations of tracking latency and millimeter accuracy. You want to cite papers that prove modern optical tracking operates at sub-millimeter precision with low enough latency to prevent simulator sickness. This proves the hardware is enterprise-grade and capable of handling complex geometry like a 3D liver mesh.
##### Sources
**Goal:** Position optical hand-tracking and the Leap Motion 2 as the logical evolution for medical XR.
###### 🥇 Gold Standard (High Priority - Hand vs. Controller & Hardware Validation):
1. Analyzing the effectiveness and satisfaction of hand tracking vs. controllers among VR-experienced users, 2026
2. Comparative Analysis of the Accuracy and Robustness of the Leap Motion Controller 2, 2025 _(Crucial: Evaluates your exact hardware)._
3. Comparing hand-based and controller-based interactions in virtual reality learning: effects on presence and interaction performance, 2025
4. Controllers or Bare Hands? A Controlled Evaluation of Input Techniques on Interaction Performance and Exertion in Virtual Reality, 2023
5. Comparison of a vr stylus with a controller, hand tracking, and a mouse for object manipulation and medical marking tasks in virtual reality, 2023
6. Unlocking the Potential of Immersive VR Systems: The Role of Gesture and Natural Controls, 2023
7. Is embodied interaction beneficial? A study on navigating network visualizations, 2023
###### 🥈 Supporting Literature (Medium Priority - General Gesture Tech/Older Hardware):
8. Evaluation of XR device's real-world tracking accuracy and depth perception... 2025
9. A Novel Sensor Fusion Approach for Precise Hand Tracking in Virtual Reality-Based Human—Computer Interaction, 2023
10. Robust Optical Based Hand Interaction for Virtual Reality, 2022
11. Hand tracking for immersive virtual reality: Opportunities and challenges, 2021
12. Object manipulation and deformation using hand gestures, 2021

_(Remaining 18 papers on older Leap Motion validations from 2013-2020, Kinect sensors, EMG gestures, and generic computer vision gesture reviews)._
#### 4. Critical Nuances (Showing "Deep Understanding")
**The Goal:** Examiners award marks $\ge 80\%$ to students who critically evaluate their own solutions. You must research the *flaws* of your proposed system.
**What to search for:** `"Hand tracking" AND "Gorilla Arm fatigue"` or `"optical occlusion" AND "VR tracking latency"`.

**Core Insights to look for (and cite):**
* **"Gorilla Arm" Fatigue:** A well-documented physiological phenomenon in HCI where users experience severe shoulder and arm fatigue from holding their arms extended in mid-air without physical resting support.
* **The Missing Haptics Dilemma:** Interacting with a virtual liver using bare hands feels like "pushing air." Without the rumble or resistance of a controller, the brain lacks tactile confirmation that a "grab" was successful.
* **Optical Occlusion:** The Ultraleap cameras cannot see through solid objects. If one hand crosses over the other (e.g., during your bimanual scaling task), the tracking fails.

**A tip for your literature review:** Don't just list the papers. Synthesize them. For example: *"While [Author A] proved that VR reduces surgical planning time, [Author B] demonstrated that traditional controllers introduce a steep learning curve. This project bridges that gap by..."*
##### Sources
**Goal:** Evaluate the _flaws_ of your system (Gorilla Arm fatigue, optical occlusion, lack of haptics).
###### 🥇 Gold Standard (High Priority - The flaws of mid-air interaction):
1. Quantifying the 'Gorilla Arm' Effect in a Virtual Reality Text Entry Task via Ray-Casting: A Preliminary Single-Subject Study, 2023 _(Use to define the phenomenon)._
2. Absence of Inertial Load on Hand Decreases Task Performance in Virtual Reality Interaction, 2024 _(Use to explain lack of haptic feedback on the virtual liver)._
3. The effect of hands synchronicity on users perceived arms Fatigue in Virtual reality environment, 2023 _(Use to justify your bimanual scaling task design)._
4. Modeling cumulative arm fatigue in mid-air interaction based on perceived exertion and kinetics of arm motion, 2017
5. Real-Time Hand Tracking under Occlusion from an Egocentric RGB-D Sensor, 2017 _(Defines the optical tracking blindspot)._
6. Landing Windows Method as Soft Visual Constraints for Mid-Air Interactions, 2025 _(A solution to lack of haptics)._
7. Probabilistic In-Plane Detection for Mid-Air Virtual Surface Interactions, 2025
###### 🥈 Supporting Literature (Medium/Low Priority - Peripheral Fatigue/Haptic Studies):
8. Dual Leap Motion Controller 2: A Robust Dataset for Multi-view Hand Pose Recognition, 2024 _(Use for Future Work/Self-Appraisal)._
9. Force Feedback-Based Adaptive Sensor Fusion Algorithm for Precision Enhancement in VR-Based Medical Training Systems, 2026
10. Effects of different fatigue locations on upper body kinematics and inter-joint coordination in a repetitive pointing task, 2019
11. Outline Pursuits: Gaze-assisted Selection of Occluded Objects in Virtual Reality, 2020

_(Remaining papers on generalized VR sickness, 2009 haptics, and basic pointing task variability).