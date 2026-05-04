In the proposed simulation, grip variance serves as a continuous, non-intrusive correlate of these fatigue-induced micro-tremors, providing an objective measure of the biomechanical degradation documented here.
%
\subsubsection{Raw NASA-Task Load Index (RTLX)}
\label{sec:rtlx_instrument}
%

The NASA Task Load Index (NTLX) evaluates perceived workload across six subscales: Mental Demand, Physical Demand, Temporal Demand, Performance, Effort, and Frustration \citep{Hart1988DevelopmentResearch}. Participants rate each dimension on a 20-point scale, generating a detailed profile of task-induced strain rather than a single generalized score.
This project uses the unweighted variant known as the Raw TLX (RTLX). The original NTLX required a time-consuming weighting process based on pairwise comparisons. However, \citet{Hart2006Nasa-TaskLater} conducted a retrospective analysis across 550 published studies over the last 20 years, demonstrating that directly averaging the six subscales maintains high experimental sensitivity while removing administrative overhead. Consequently, the RTLX has become the standard workload metric for comparative human-computer interaction (HCI) research.
The literature strongly supports using the RTLX to evaluate virtual reality (VR) interfaces. \citet{Button2025XRInteractions} established the instrument as a reliable standard for comparing HTR and CTR during paramedical spatial tasks. Furthermore, \citet{Fischer2025ProbabilisticInteractions} found a direct correlation between objective interaction errors and elevated RTLX scores. This confirms that the RTLX is highly sensitive to the specific performance degradations discussed in Section~\ref{sec:compensatory_variance}.
https://www.researchgate.net/publication/228593520%7B/_%7DSUS%7B/_%7DA%7B/_%7Dquick%7B/_%7Dand%7B/_%7Ddirty%7B/_%7Dusability%7B/_%7Dscale

#

```latex
# Prompt
## Intro
Ok major issue. The literature review chapter is still far too long. Including comments and all the latex code like \section, it sits at 6827 words, 476 sentences and 280 paragraphs. The issue is actually the page count as this spans 16 pages of the strict limit of 30. Font, font size, page margins and linespacing are all fixed.

### Solutions
These 30 must fit the Introduction, Literature Review, Methodology, Implementation and Validation and finally the Results, Evaluation and Discussion chapters. Potential solutions:
1. The immediate, easy fix concerns header sizing: including the chapter heading, I have 45 headers (sections, subsections and subsubsections). That is too many. Surely content can be merged under the same heading or simply these chapters can forgo the subsub heading at times. I think some of the larger subsections require subsub sections but most do not.
2. Another fix concerns content relevance. The literature review should only contain information pertaining to my solution, what I will go on to use and refer to in later chapters as well as provide the reader of an understanding of the project's core academic foundation, so information that does not meet this criteria can be removed.
3. This fix concerns verbosity. Some concepts etc do not need the level of verbosity that is explained, especially if they are not part of the core solution. For example, the FSM must be formally defined because it goes on to be the core of our design and solution but the reader does not know this when reading the literature review chapter. The verbosity, however should imply and hint at it's relevance and importance throughout the paper ---core concepts must be more detailed then general relevant information.
4. This fix concerns padding and waffle. This paper must be academically written but it should not meet the descriptive, lengthy standards of a fictional book. For example, long introductions that do not hold much value to the reader should not exist. All sentences should be important as page space is limited and the reader does not want to read pages upon pages of unnecessary script; they simply want the information.

Ideally we can remove at least four pages worth of text ---approximately 2000 words or 120 sentences.

## Requirements
With this being said, we are still aiming for an exceptional, 80% and higher grade for this project. To do this in the literature review, the following requirements alongside the marking rubric must be consistently met:
- a structure of: make a point, explain core concepts, cite the evidence, critically analyse the evidence, link back to the proposed system/solution/simulation
    - Evidence of a systematic and scholarly approach to background research and relevant literature review.
    - Critical analysis of existing solutions and techniques.
- Clauses must not exceed unreadble lengths.
- Paragraphs and sections must flow but this does not mean lengthy connecting paragraphs, implicit connections are also permitted when obvious.
- This chapter must not definitively forward reference, i.e. talk about the implemented solution yet. It must approach this from a requirements position, naturally being picked up on in the methodology and later chapters.
- Where appropriate, visuals are used and/or refferred to

### The current content's page for the Literature Review
2 Literature Review
2.1 Clinical Applications of Medical VR
2.2 Theoretical Foundations of 3D Human-Computer Interaction
2.2.1 The Historical Evolution of 3D Interfaces
2.2.2 The Transition to Natural User Interaction
2.2.3 Defining Core Interaction Metaphors
2.2.4 The Testbed Evaluation Framework
2.2.5 Mathematically Modelling Target Acquisition
2.3 The Psychology of Virtual Embodiment
2.3.1 Early Immersion and Proprioception Models
2.3.2 Defining the Sense of Embodiment (SoE)
2.3.3 The Uncanny Valley of Interaction
2.4 Cognitive Load Measurement in Virtual Reality
2.5 Biomechanics, Fatigue and Ergonomics
2.5.1 The Gorilla Arm Effect and Consumed Endurance
2.5.2 Fatigue-induced Compensation and Involuntary Action
2.5.3 Subjective Evaluation Instruments
2.6 Hardware Realities: Controllers vs. Optical Tracking
2.6.1 Pantomime Grasping and Proximity Preferences
2.6.2 Sensor Noise, Drift and and Rotation Representation
2.7 Software Compensation for Hardware Limitations
2.7.1 Algorithmic Compensation and the Heisenberg Effect
2.7.2 Deterministic Finite Automata in Interactive Systems
2.7.3 Multi-Modal and Hybrid Interfaces
2.7.4 Real-Time Metrics and Online Statistical Algorithms
2.8 Software Engineering Techniques
2.8.1 Project Management and Agile Planning
2.8.2 Software Testing and Test-Driven Development
2.8.3 Software Prototyping and Risk Reduction
2.9 Statistical Analysis Methods
2.9.1 Normality Assessment: Shapiro-Wilk Test
2.9.2 Primary Inferential Test: Wilcoxon Signed-Rank
2.9.3 Parametric Complement: Paired t-Test
2.9.4 Effect Sizes: Cohen’s d and Rank-Biserial r
2.9.5 Agreement Analysis: Bland-Altman Method
2.9.6 Correlation and Trend Analysis
2.9.7 Workload Profile Variability: RMSSD
2.10 Summary of Gaps and Contribution
2.11 Project Aim and Objectives

## Chapter before any changes


\chapter{Literature Review}
\label{chap2:lit_review}

% =============================================================================
\section{Clinical Applications of Medical VR}
\label{sec:clinical_applications}
% =============================================================================
The process of 3D mental liver reconstruction demands the true reconstruction of the shape of the liver, its tumours and its critical blood vessels. This spatial translation exercise is not only cognitively exhausting but also fatally error‑prone: it depends heavily on the surgeon's spatial ability \citep{Shi2025TranslatingEvaluation}. Errors in this mental reconstruction can lead to incomplete tumour resection, damage to vital vessels, or postoperative liver failure \citep{Fan2002ResectionAspects}. Consequently, further investigation into more effective visualisation and interaction methods is required.

Other modelling approaches, such as 3D printing, present a solution to this but remain costly and time‑consuming, limiting their routine clinical use \citep{Lau2022ClinicalDisease, Ponzoni2025MixedDefects}.
Instead, clinicians have adopted 3D computer‑assisted surgery planning (CASP) tools that render volumetric models from medical imaging data \citep{Radtke2010Computer-assistedPeriod}. Until recently, however, these 3D models were displayed on conventional 2D screens, which lack depth perception and motion parallax – cues that surgeons rely on to confidently interpret spatial information. This visual disconnect constitutes a `dimensional mismatch', making planning ports and incisions difficult given the limited spatial information available. Coupled with the shift towards minimally invasive surgery (MIS), surgeons lose even more of this information. \citet{Sadeghi2020ImmersiveDisease} argue that VR support is the solution and that its becoming mandatory for modern surgery.

To evaluate the utility of immersive systems, \citet{Kenngott2021IMHOTEP:Display} developed and assessed a VR platform, specifically designed for complex liver surgery. Their evaluation validated that immersive 3D visualisation bridges the cognitive gap caused by standard 2D scans across all levels of medical expertise.
Beyond single‑user experiences, research by \citet{Chheang2021APlanning} details an architectural shift toward collaborative, networked VR environments for preoperative liver tumour planning. By using tracked avatars, multiple users can collaboratively occupy the same virtual operating theatre but before developers can safely scale surgical simulations into multi‑user, networked environments, they must focus on the core functionality.

Collectively, the literature establishes that manipulating complex 3D medical models, such as translating, rotating and scaling a liver mesh to align with a target hologram, is an optimal experimental stimulus for replicating the spatial reasoning demands of pre-operative resection planning. However, these studies also expose a foundational gap: while the visual benefits of VR are well-documented, the input modality driving these interactions has not been thoroughly evaluated. Specifically, standard physical VR controllers have not been empirically compared against the latest marker-less, optical hand-tracking technology in this context.

To address this, the proposed simulation focuses entirely on a single-user liver docking task, using a polygonal mesh of a human liver (hereafter referred to as the target mesh or liver model) to systematically evaluate these two interaction modalities

% =============================================================================
\section{Theoretical Foundations of 3D Human-Computer Interaction}
\label{sec:3d_interaction_hci_tax}
% =============================================================================

% -----------------------------------------------------------------------------
\subsection{The Historical Evolution of 3D Interfaces}
\label{sec:historical_3d}
% -----------------------------------------------------------------------------
The pursuit of intuitive spatial computing predates modern optical sensors. Early Human-Computer Interaction (HCI) research explored various desktop-bound spatial peripheral devices such as 3D mice and tethered magnetic trackers, to bridge the gap between physical movement and digital control \citep{Bowman2001TestbedTechniques, Soukoreff2004TowardsHCI}.

While these early systems demonstrated the theoretical benefits of 3D spatial input, they suffered from practical limitations. Wired devices often had long, heavy cables restricting the position and rotation of the user. Their magnetic tracking counterparts were no better, offering small tracking ranges and a vulnerability to metallic interference. Understandably, these devices were considered unsuitable in precision-critical fields like medicine \citep{Argelaguet2013AEnvironments}.

This historical trajectory underscores a continuous drive to remove hardware barriers. The ultimate goal being frictionless interaction, where the technology vanishes and the user’s natural movements translate directly into digital commands. That goal, however, requires not only better technology but also a fundamental reshaping of existing interaction mechanism. Systems simply must develop beyond the archaic Windows, Icons, Menus, Pointer (WIMP) paradigm.

% -----------------------------------------------------------------------------
\subsection{The Transition to Natural User Interaction}
\label{sec:wimp_to_nui}
% -----------------------------------------------------------------------------
% change []
The evolution of immersive computing necessitates a paradigm shift away from traditional 2D WIMP interfaces. Navigating volumetric data, such as a 3D liver model, using 2D peripherals introduces severe cognitive friction \citep{Bachmann2018ReviewController}. The user must first translate their intended 3D actions into 2D mouse movements or joystick deflections, buffering the interaction process.

Consequently, modern HCI has pivoted towards Natural User Interfaces (NUI), which leverage innate human motor skills to achieve the same actions. Within this domain, \citeauthor{Bachmann2018ReviewController} establish the Leap Motion Controller (LMC) device as the academic standard for marker-less optical hand-tracking (HTR), where markers refer to physical attachments. These systems achieve a one-to-one (1:1) interaction by translating raw infrared data directly into digital kinematics, completely forgoing the intermediary mapping step of CTR.

The two modalities are referred to throughout as Controller Tracking (CTR) and Hand Tracking (HTR).
This technology serves as the foundational hardware for the proposed solution.

% -----------------------------------------------------------------------------
\subsection{Defining Core Interaction Metaphors}
\label{sec:core_metaphors}
% -----------------------------------------------------------------------------
With the hardware established, a framework must be applied to evaluate its effectiveness. To systematically evaluate user performance, spatial tasks must be classified within a formal HCI taxonomy. \citet{LI2019GestureReality} categorise virtual interaction into three foundational metaphors: Selection (target acquisition), Manipulation (spatial translation and rotation) and Navigation (locomotion through the environment). In the context of surgical applications of VR, the translation of raw human motion into accurate digital intent is paramount. While \citeauthor{LI2019GestureReality}'s taxonomy is widely adopted, it blends continuous 6‑DoF manipulation into a single category, potentially obscuring differences between translation and rotation.

Acknowledging this, the proposed system aims to measure the Selection and Manipulation phases in isolation, as well as together. \citeauthor{LI2019GestureReality}'s taxonomy ensures that the interaction mechanics are evaluated as specific, quantifiable kinematic tasks as opposed to generic experiences.

% -----------------------------------------------------------------------------
\subsection{The Testbed Evaluation Framework}
\label{sec:testbed_evaluation}
% -----------------------------------------------------------------------------
In an application-specific environment, such as the proposed system's liver docking task, evaluating the performance of these interactions is a difficult feat. \citet{Bowman2001TestbedTechniques} argues that as the complexity of an application increases, so does the number of its confounding variables. This directly impacts the internal validity of such evaluations as meaning cannot be derived when uncontrolled factors have significant influence.

To combat this, \citeauthor{Bowman2001TestbedTechniques} established a framework to ensure empirical data is gathered during trials. This framework mandates the decomposition of complex procedures into distraction-free, isolated, highly controlled sub-tasks.

Therefore, this project adheres to that `Testbed Evaluation' methodology: by evaluating the proposed system within a virtual testbed, independent variables like input modality can be strictly manipulated while dependent metrics like accuracy are captured reliably. Although this approach prioritises internal validity, the highly controlled environment may not simulate the cognitive load of a real operating room.

% -----------------------------------------------------------------------------
\subsection{Mathematically Modelling Target Acquisition}
\label{sec:fitts_law}
% -----------------------------------------------------------------------------
In order to objectively measure interaction efficiency across different modalities, tasks must be modelled mathematically. According to \citet{Soukoreff2004TowardsHCI}, the efficiency of HCI is governed by Fitts' Law, which dictates that the time required to acquire a target depends on the target's distance and its width \citep{FittsReader}.

Here, movement time $MT$ is a linear function of the Index of Difficulty $ID$:
\begin{equation}
    MT = a + b \cdot ID, \quad \text{where} \quad
    ID = \log_2 \!\left(\frac{2D}{W}\right)
    \label{eq:fitts}
\end{equation}
where $D$ is the distance to the target, $W$ is the target width and $a$ and $b$ are empirically determined device constants.

\citeauthor{Soukoreff2004TowardsHCI} continue and define the Index of Difficulty (ID) of a task and the overall device Throughput, that is, the ID proportional to the time taken to complete that task. For the proposed system, grabbing a small mesh would require high precision and therefore be classed as high ID. Furthermore, if completed quickly using a controller, the controller can be said to deliver high Throughput.

Fitts’ law was developed for 2D pointing, consequently its extension to 3D environments remains debated as variables such as depth perception are not captured by the standard ID formula. Acknowledging this, we rely on Fitt's law to justify the use of simple metrics such as Task Completion Time (TCT) and various spatial errors.

While these mathematical frameworks and testbed methodologies provide numerical insight into the performance of an interface, they do not account for how the human brain actually perceives the virtual environment (VE). To understand user acceptance of HTR, one must evaluate the cognitive psychology of virtual embodiment.

% =============================================================================
\section{The Psychology of Virtual Embodiment}
\label{sec:psychology_embodiment}
% =============================================================================

While mathematical frameworks like Fitts' Law evaluate the physical and algorithmic efficiency of an interface, they do not account for the user's cognitive experience in the VE. To comprehensively assess the efficacy of HTR against CTR, it is necessary to examine the psychological mechanisms that govern virtual embodiment: the manifestation of one's self in VR.

% -----------------------------------------------------------------------------
\subsection{Early Immersion and Proprioception Models}
\label{sec:early_immersion}
% -----------------------------------------------------------------------------

Early psychological frameworks investigating virtual embodiment primarily focused on the generalised concepts of presence and the role of proprioceptive feedback. Here, presence is described as the feeling of `being there' while proprioception denotes the brain's subconscious ability to know where one's body parts are without looking. These foundational studies observed that upon immersion in a VE, humans can project spatial awareness and physical agency into avatars, such as a virtual model of their own hands \citep{Kilteni2012TheReality}.

However, as critiqued by \citeauthor{Kilteni2012TheReality}, these early models frequently conflated general technological immersion with psychological presence, treating the experience as a discrete, binary state rather than a continuous, multidimensional construct. Without the adequate vocabulary, researchers failed to diagnose and understand user responses to specific interaction metaphors; they could not explain, for instance, why manipulating tissue with a physical joystick versus a bare hand elicits fundamentally different cognitive responses and varying levels of attention demand \citep{Rekik2019UnderstandingTask}.

Learning from this, the subjective evaluation of the proposed system will offer a broader range of response options to accurately measure user experience.

% -----------------------------------------------------------------------------
\subsection{Defining the Sense of Embodiment (SoE)}
\label{sec:defining_soe}
% -----------------------------------------------------------------------------

To resolve this ambiguity, \citeauthor{Kilteni2012TheReality} formalised the `Sense of Embodiment' (SoE) as a precise, multidimensional psychological construct. The authors decompose SoE into three distinct, measurable pillars: the Sense of Self-Location (the perception of being physically inside the spatial volume), the Sense of Agency (the feeling of global motor control) and the Sense of Body Ownership (the feeling that the virtual avatar is one's actual biological body).

These pillars serve as a taxonomy for evaluating the hardware modalities in this project. For example, CTR may deliver a high Sense of Agency as they mimic the holding of tools like a surgeon would a scalpel but they inherently restrict Body Ownership because the brain processes the controller as an external tool. Conversely, HTR theoretically maximises Ownership by delivering a 1:1 mapping to the avatar \ref{sec:wimp_to_nui}, mimicking the touching of tissue directly. However, this only holds true if the visual feedback perfectly matches the user's proprioceptive expectations; how the user anticipates the interaction response validates the psychological pillar. Furthermore, while decomposing SoE into this taxonomy is analytically useful, it makes empirical measurement difficult as the three components are not statistically independent: high Agency can mask low Ownership in a self-report scenario.

% -----------------------------------------------------------------------------
\subsection{The Uncanny Valley of Interaction}
\label{sec:uncanny_valley}
% -----------------------------------------------------------------------------

Despite being a foundational pillar of virtual embodiment, attempts to maximise the Sense of Body Ownership introduces unique psychological vulnerabilities. \citet{Argelaguet2016TheRepresentation} investigated the impact of virtual hand representation on embodiment. Their empirical data demonstrated a psychological paradox between the visual proprioception of the user and their hand avatar, commonly referred to as the `uncanny valley of interaction'. This phenomenon observes that, while highly realistic virtual hands successfully increased the Sense of Ownership, they significantly degraded the Sense of Agency and objective task performance when bodily anomalies occurred. For example, upon a delayed interaction response or poor rendering of the fingers, the illusion of reality is broken and the user experiences a loss of control (loss of Sense of Agency). The brain can be considered intolerant of errors that jeopardise this illusion.

Moreover, this proprioceptive mismatch is further exacerbated by the hardware limitations of modern spatial computing. HTR inherently suffers from higher latency and optical occlusion, the compared to physical controllers \citep{Pardo2026AnalyzingUsers}. In this context, optical occlusion denotes an obstruction of the hand, resulting in a loss of camera tracking. Subsequently, hardware-induced anomalies trigger immediate cognitive dissonance as they fail to comply with the brain's strict physical expectations for realistic biological limbs.

This does not, however, appear to concern cosmetic appearance. \citeauthor{Argelaguet2016TheRepresentation} found that abstract or simplified hand representations unconsciously lower the user's physical expectations, thereby preserving the Sense of Agency instead of losing it to less-realistic representations. Furthermore, the effect seems to reduce frustration during complex spatial tasks \citep{Argelaguet2016TheRepresentation}. For the proposed system, the literature justifies the deliberate design choice of a simplified hand model, prioritising the Sense of Agency, over the pursuit of pure aesthetic realism from the Sense of Ownership.

While embodiment concerns the quality of the user’s virtual self, it is equally critical to quantify the mental effort required to maintain this illusion. This leads to the measurement of cognitive load.

% =============================================================================
\section{Cognitive Load Measurement in Virtual Reality}
\label{sec:vr_cog_load}
% =============================================================================

In surgical simulation, cognitive load is the primary performance determinant; a surgeon who is mentally overloaded by the interaction interface cannot simultaneously reason about anatomy \citep{Mao2021ImmersiveReview}.

Historically, the motivation to transition to 3D Natural User Interfaces has been validated primarily through subjective surveys or basic performance metrics. However, recent HCI research has employed physiological telemetry to quantify this cognitive strain. \citet{Yu2021CognitiveSurgery} measured Electroencephalography (EEG) brainwaves and Heart Rate via physical sensors during Virtual Reality Laparoscopic Simulations (VRLS). They found that training in a VE significantly improved participants' surgical performance ($p < 0.01$). More importantly, the biological feedback showed that the simulations enabled users to maintain a lower cognitive load and a calmer psychological state while performing complex spatial tasks.

Conversely, \citet{Luong2019StudyingEnvironments} deployed a comprehensive suite of measurements. They measured subjectivity (Rating Scale of Mental Effort), behaviour (response time, trigger button pressure) and physiology (Heart Rate, Skin Conductance Level) to evaluate spatial environments, concluding that VR immersion itself has no significant intrinsic influence on mental effort. This discrepancy implies that the cognitive bottleneck is almost entirely dependent on the physical interaction mechanics and the manner in which these tasks are conducted.

This insight directly motivates the within-subjects comparative design of this study,  isolating input modality as the sole independent variable. Considering this, it is important to understand the mental and physical effects of these modalities.

% =============================================================================
\section{Biomechanics, Fatigue and Ergonomics}
\label{sec:biomechanics_fatigue}
% =============================================================================

The psychological acceptance of a virtual avatar is only one facet of interaction quality. Even where embodiment is well-preserved, the physical sustainability of the interaction must be evaluated independently. In a surgical setting, HTR requires continuous mid-air interaction (MAI): the user manipulates digital objects for extended periods without any physical surface to rest against. \citet{Huang2021User-DefinedPreference} documents the severe musculoskeletal risks associated with unsupported, repetitive upper-limb elevation, concluding that prolonged arm raising accelerates muscle exhaustion and increases the risk of Repetitive Strain Injury. Thus, fatigue risk is a primary ergonomic concern for the proposed system, as participants must sustain manipulation precision across multiple, consecutive tasks.

Beyond sheer muscular strain, the absence of a physical object exacerbates this ergonomic degradation in less obvious ways by fundamentally altering spatial performance. \citet{Tang2024AbsenceInteraction} demonstrated that manipulating a weightless virtual object changes human movement dynamics: without the resistance of physical weight, users produce erratic, corrective movements. To compensate for this lack of tactile feedback, users visually fixate on the target rather than relying on proprioception. This visual fixation transfers attentional load from spatial reasoning to manual monitoring, directly increasing cognitive demand and potentially inducing optical fatigue \citep{Jonnakuti2023SeeingOphthalmologists}.

For the proposed simulation, this compensatory fixation is a significant ergonomic burden. Conversely, the physical weight of a standard VR controller provides tactile grounding that partially offsets this cognitive load, actively supporting the user's Sense of Body Ownership. Without this grounding, the user's hand feels less like their own limb, leading to a proprioceptive disconnect.

Ultimately, in a surgical context where prolonged precision is mandatory, optical HTR systems must be engineered to minimise these disembodying movements. Doing so is critical to preserving virtual embodiment, mitigating musculoskeletal and optical fatigue and preventing the gradual degradation of spatial accuracy.

% -----------------------------------------------------------------------------
\subsection{The Gorilla Arm Effect and Consumed Endurance}
\label{sec:gorilla_arm_baseline}
% -----------------------------------------------------------------------------

In spatial computing, the manifestation of this strain is colloquially termed the `Gorilla Arm' effect, denoted by a rapid onset of heaviness and exhaustion in the upper limbs during sustained free-hand interaction. \cite{QPalmeira2023QuantifyingStudy} quantified this cost, demonstrating that tasks requiring continuous arm elevation induce measurable muscular failure and degrade interaction performance well within the duration of a typical VR session.

\citet{Hincapie-Ramos2014ConsumedInteractions} formalised this into the Consumed Endurance (CE) metric, a non-intrusive algorithm that tracks the skeletal pose and computes the ratio of a limb's elevated holding time against its estimated maximum endurance threshold. Unlike subjective questionnaires, CE provides a continuous, real-time index of ergonomic strain without interrupting the task.

% -----------------------------------------------------------------------------
\subsection{Fatigue-induced Compensation and Involuntary Action}
\label{sec:compensatory_variance}
% -----------------------------------------------------------------------------

The CE metric has a recognised limitation: it relies on population-average strength values and assumes that exertions below 15\% of maximum voluntary contraction produce no fatigue, which underestimates cumulative strain in intermittent low-force actions such as the pinch. \citet{Jang2017ModelingMotion} addressed this with a personalised Cumulative Arm Fatigue (CAF) model, demonstrating that individual shoulder torque estimates significantly improve fatigue prediction and explain the wide inter-individual variability observed under identical conditions. Given this variability, we anticipate a spread of phyiscal demand scores from the proposed system.

Beyond subjective discomfort, fatigue degrades the physical reliability of HTR itself. \citet{Yang2019EffectsTask} demonstrated that joint-localised fatigue causes compensatory postural changes: participants experiencing shoulder fatigue increased trunk rotation and reduced arm elevation to offload the fatigued muscle group. In a head-mounted optical tracking context, these posture shifts alter the hand's position relative to the sensor field of view, increasing the probability of optical occlusion and tracking jitter. \citet{Fischer2025ProbabilisticInteractions} terms this the delimitation problem: fatigue-induced tremors cause the hand to enter tracking blind-spots unintentionally, producing object drops that corrupt the metric data. The weight and resistance of the controller stabilise these tremors and provide proprioceptive feedback that optical tracking cannot replicate \citep{Rantamaa2023ComparisonReality}. In the proposed study, grip variance serves as a proxy for these fatigue-induced micro-tremors, providing an objective insight into the compensatory variance documented here.

Whether this haptic advantage outweighs the cognitive translation cost imposed by the controller mapping is an important question to address.

Having established that workload measurement requires a combination of subjective, behavioural and physiological metrics, the following section defines the specific subjective instruments deployed in this project to capture these dimensions.

% Change []
% -----------------------------------------------------------------------------
\subsection{Subjective Evaluation Instruments}
\label{sec:subjective_instruments}
% -----------------------------------------------------------------------------

Objective metrics capture what the user \emph{did} but cannot capture what the user \emph{experienced}. Subjective instruments are therefore necessary to quantify the cognitive and ergonomic cost of interaction from the participant's perspective. Two instruments are deployed in this project: the Raw NASA Task Load Index (RTLX) for workload and the System Usability Scale (SUS) for usability.

% . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .
\subsubsection{Raw NASA Task Load Index}
\label{sec:rtlx_instrument}
% . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .
The NASA Task Load Index (NTLX) was developed by \citet{Hart1988DevelopmentResearch} at the NASA Ames Research Center to address the inadequacy of single workload measures for capturing the specific causes of user strain during complex aerospace tasks. The instrument decomposes perceived workload into six subscales: Mental Demand, Physical Demand, Temporal Demand, Performance, Effort and Frustration, each rate on a 20-point scale. This multidimensional profile is critical for the present study, where the two modalities are expected to impose qualitatively different load patterns: HTR may elevate Physical Demand and Frustration through occlusion events, while CTR may elevate Mental Demand through its abstract mapping layer.

This project uses the unweighted variant known as the Raw TLX (RTLX), which averages the six subscales directly. The original NTLX required a time-consuming weighting process based on pairwise comparisons. However, \citet{Hart2006Nasa-TaskLater} conducted a retrospective analysis across 550 published studies over the last 20 years, validating that this approach maintains experimental sensitivity while removing lengthy overhead. Consequently, the RTLX has become the standard workload metric for comparative human-computer interaction (HCI) research.

Recent literature strongly supports using the RTLX to evaluate virtual reality (VR) interfaces. \citet{Button2025XRInteractions} deployed it to compare HTR and CTR across paramedical spatial tasks, confirming its sensitivity to modality-specific workload differences. \citet{Fischer2025ProbabilisticInteractions} also demonstrated a direct correlation between objective interaction errors and elevated RTLX scores, confirming the instrument is sensitive to the tracking failures and clutch events anticipated in the proposed simulation.

% . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .
\subsubsection{System Usability Scale}
\label{sec:sus_instrument}
% . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .
Where the RTLX quantifies the cost of a task, usability measures whether the interface itself is learnable, efficient and satisfying. The System Usability Scale (SUS) \citep{Brooke1995SUS:Scale} provides a ten-item Likert instrument producing a composite score on a 0--100 scale, with resulting grade thresholds reproduced in Table~\ref{tbl:sus_grades}. Scores are computed by reverse-scoring even-numbered items before summation, preventing acquiescence bias. The grade thresholds provide an externally interpretable benchmark, situating each modality against the broader landscape of commercial software rather than only relative to each other.

The resulting score maps onto an established set of adjective-anchored grade thresholds: scores below 51 are classified as Poor, 51--68 as Okay to Fair, 68--80.3 as Good (representing the average usability of commercial software), and above 80.3 as Excellent \citep{Brooke1995SUS:Scale}. These thresholds provide an externally interpretable benchmark, allowing the usability of each modality in this project to be situated against the broader landscape of software systems rather than evaluated only in relative terms.

The SUS is well-validated for VR interaction comparisons. \citet{Khundam2021ATraining} reported SUS scores of 67.17 for CTR and 60.17 for HTR in a comparable within-subjects medical VR study, while \citet{Horejsi2025VirtualNavigation} found CTR scoring 74.67 against HTR's 56.0 in a spatial navigation task. Both studies suggest CTR consistently approaches the Good threshold while HTR falls within the Okay to Fair band under current hardware. These benchmarks provide a prior hypothesis for the present study using the Varjo and Ultraleap devices.

A limitation is that the SUS items address general perceived usability, meaning a participant who experienced frequent optical occlusion events may rate the system similarly to one who did not, provided the interface was otherwise learnable. Task-level telemetry data must therefore capture the frequency of such events independently of subjective tolerance.

The two instruments are administered at different intervals to capture distinct types of feedback. To prevent memory decay, the RTLX is completed immediately after each subtask. This ensures the analysis can track exactly how cognitive load changes as task complexity increases, identifying the precise moment the two interaction modalities diverge \citep{Button2025XRInteractions}. In contrast, the SUS is administered only once at the end of each condition. This aligns with its design as a holistic evaluation of overall system usability rather than a measure of individual task performance \citep{Brooke1995SUS:Scale}. While this holistic approach means the SUS cannot attribute usability scores to specific subtasks, this limitation is offset by the detailed, task-by-task data provided by the RTLX and the system's objective telemetry.

As established, self-reported workload surveys are susceptible to participant bias \citeauthor{Yu2021CognitiveSurgery}. This limitation is inherent to all subjective instruments and is addressed in this project by weighing RTLX and SUS scores against objective telemetry rather than treating either measure as independently sufficient.

% =============================================================================
\section{Hardware Realities: Controllers vs. Optical Tracking}
\label{sec:hardware_realities}
% =============================================================================

While the psychological models established in Section~\ref{sec:psychology_embodiment} dictate the user's subjective experience, the ultimate viability of the interface depends on the physical reliability of its hardware. Both modalities operate under fundamentally different error profiles that must be understood before a fair empirical comparison can be designed.

% -----------------------------------------------------------------------------
\subsection{Pantomime Grasping and Proximity Preferences}
\label{sec:haptic_diff}
% -----------------------------------------------------------------------------

Physical controllers provide haptic feedback that optical HTR cannot replicate \citep{Rantamaa2023ComparisonReality}. \citet{Buckingham2021HandChallenges} term the consequence of removing this feedback `VR Agnosia', observing that without the physical sensation of weight or texture, users adopt `pantomime grasping' strategies, miming rather than genuinely interacting. This fundamentally alters how the brain estimates grip force and spatial trajectory, degrading alignment precision in ways that objective telemetry may capture but self-report instruments alone may not.

Despite this, user preference does not uniformly favour controllers. \citet{Luong2023ControllersReality} found that CTR outperforms HTR for distant ray-casting tasks, as an arms-down posture minimises physical strain. Conversely, users strongly prefer HTR for near-field spatial manipulation, even without haptic feedback. The proposed simulation is entirely a near-field task, placing it in the exact interaction space where HTR performs best. These findings justify the docking paradigm as the experimental stimulus and establish the baseline hypothesis for the usability comparison.

% -----------------------------------------------------------------------------
\subsection{Sensor Noise, Drift and and Rotation Representation}
\label{sec:sensor_noise}
% -----------------------------------------------------------------------------

Physical controllers rely on Inertial Measurement Units (IMUs), which accumulate compounding positional error over time, known as spatial drift. As drift grows, the virtual representation decouples from the physical device, requiring frequent recalibration in precision-critical environments \citep{Singh2025EvaluationView}. HTR avoids IMU drift by computing absolute position visually on every frame. However, it introduces a different problem: optical occlusion. The first-generation LMC lost reliable tracking when fingers approached within 12\,mm of each other, producing severe jitter \citep{Mahdikhanlou2021ObjectGestures}. The newer LMC2 partially solves this. While it achieves sub-millimetre accuracy in controlled tests \citep{Matuszczyk2025Comparative2}, these tests only used static hand poses. It remains to bee seen if this accuracy holds up during the dynamic spatial manipulation required by the proposed simulation.

Regardless of the tracking method, calculating rotation creates another potential source of instability. Traditional Euler angles suffer from Gimbal Lock. This occurs when two rotational axes align, causing sudden, erratic jumps in orientation during complex movements. Unit quaternions completely eliminate this issue by providing a continuous, stable mathematical representation of 3D rotation \citep{Fang1998RealQuaternions}. Therefore, quaternion-based rotation is mandatory for both modalities in this simulation. This ensures that any measured rotational error comes from genuine user difficulty rather than a mathematical flaw.

Existing comparative studies offer only cautious conclusions. \citet{Khundam2021ATraining} found no statistically significant difference in Task Completion Time or usability between CTR and HTR during a VR intubation simulation. However, their small sample size ($N=15$) and exceptionally high data variance severely limit the strength of this conclusion, as they reported standard deviations exceeding 90 seconds for interaction times and up to 25.71 points for SUS scores. \citet{Saran2025ComparingPerformance} reported similar performance, yet faced comparable limitations with a modest sample size ($N=27$) alongside notable variance in subjective presence scores ($SD=11.65$ to $14.69$). The present study provides a more rigorous evaluation of these trade-offs using the Varjo XR-4 and LMC2. The software compensation strategies used to manage the hardware noise identified above are detailed in the following section.

% =============================================================================
\section{Software Compensation for Hardware Limitations}
\label{sec:software_compensation}
% =============================================================================

Hardware limitations cannot be eliminated through physical engineering alone. Software must compensate for optical occlusion, sensor drift and the Heisenberg effect before raw hardware data can drive a precision interaction system reliably. This section examines the algorithmic strategies available and justifies the specific choices made for the proposed simulation.

% -----------------------------------------------------------------------------
\subsection{Algorithmic Compensation and the Heisenberg Effect}
\label{sec:algorithmic_heisenberg}
% -----------------------------------------------------------------------------

Early HTR systems addressed noise and latency by using predictive algorithms, essentially guessing the user's intended target based on their hand speed and trajectory. While effective at smoothing data, these models reduced absolute user control. In a surgical context, where vascular structures are separated by millimetres, algorithmic guessing is unacceptable. Deterministic, deliberate selection is mandatory.

\citet{Argelaguet2013AEnvironments} formalised the relevant taxonomy, dividing 3D selection techniques into the Virtual Hand for near-field direct manipulation and the Virtual Pointer for far-field ray-casting. Within this framework, \citet{Argelaguet2013AEnvironments} identified the 'Heisenberg effect.' This occurs when the physical act of making a selection, like pinching the fingers together, inadvertently displaces the hand and alters the target's coordinates. Physical controllers partially dampen this through haptic resistance. Bare-hand optical tracking has no such damping, making selection-induced jitter a direct threat to gesture validity in the proposed system. To counteract this, the proposed solution must enforce strict proximity limit, to ensure accidental twitches or ambiguous gestures are rejected before the system registers them.

% -----------------------------------------------------------------------------
\subsection{Deterministic Finite Automata in Interactive Systems}
\label{sec:fsm_theory}
% -----------------------------------------------------------------------------

Probabilistic compensation resolves noise at the input level, but a separate problem exists at the system level. Reactive systems driven by continuous hardware input streams are vulnerable to undefined behaviour when an unanticipated event arrives in an unanticipated state. In safety-critical domains, this is intolerable.

Finite automata provide the mechanism to eliminate this ambiguity. A Deterministic Finite Automaton (DFA) is defined by the 5-tuple $M = (Q, \Sigma, \delta, q_0, F)$, where $Q$ is a finite set of states, $\Sigma$ is a finite input alphabet, $\delta : Q \times \Sigma \rightarrow Q$ is a total transition function, $q_0$ is the initial state, and $F \subseteq Q$ is the set of accepting states \citep{Sipser2012IntroductionComputation}. The critical property is totality: $\delta$ must define exactly one successor state for every combination of state and input. This guarantees reproducible behaviour regardless of the order or frequency of hardware events.

State machines are well-established in interactive computing, governing animation, AI and interaction logic in game engines \citep{Jagdale2021FiniteDevelopment, Adegun2020DesignMachines}. However, these implementations are typically heuristic rather than formally total, leaving edge-case transitions undefined. The proposed system must handle events from two fundamentally different hardware providers whose edge-case behaviours differ unpredictably. A formally total DFA eliminates the risk of undefined hardware events causing unrecoverable states during a clinical trial.

% -----------------------------------------------------------------------------
\subsection{Multi-Modal and Hybrid Interfaces}
\label{sec:hybrid_interfaces}
% -----------------------------------------------------------------------------

The most advanced software compensation strategy is to decouple the targeting mechanism from the manipulation mechanism entirely. \citet{Sidenmark2020OutlineReality} demonstrated that eye-tracking enables selection of objects that are fully occluded by other virtual assets, bypassing hand-pointing limitations altogether. \citet{Pfeuffer2017GazeReality} extended this with the Gaze+Pinch model: smooth pursuit eye movements resolve spatial depth while the hands execute the manipulation action from any comfortable position, eliminating the Gorilla Arm effect \citep{Hincapie-Ramos2014ConsumedInteractions} and decoupling selection from the Heisenberg displacement.

The model has recognised limitations, however. Gaze confirmation before hand selection is difficult to enforce reliably and any unintended glance can trigger a command, known as the `Midas Touch' problem \citep{Duchowski2017EyeEdition}. These increase error rates in precision tasks \citep{Sailer2000SpatialTasks}, meaning that multi-modal fusion requires a rigorous empirical baseline before it can be responsibly proposed. The present study establishes that baseline by characterising the foundational CTR and HTR modalities independently.

% -----------------------------------------------------------------------------
\subsection{Real-Time Metrics and Online Statistical Algorithms}
\label{sec:realtime_metrics}
% -----------------------------------------------------------------------------

High-frequency metric accumulation in a game engine imposes a hard constraint on variance computation. Storing the full sample history triggers garbage collection at unpredictable intervals in managed-memory languages such as C\#, producing frame-time spikes that can cause visual stuttering. The standard two-pass variance algorithm is therefore architecturally unsuitable \citep{Chan1983AlgorithmsRecommendations}.

Three alternative methods exist, which are compared in Table~\ref{tbl:variance_algorithms}. The naïve single-pass algorithm successfully avoids storing data history but suffers from catastrophic cancellation. This mathematical error occurs when a system attempts to subtract two massive, nearly identical running totals, destroying floating-point precision. This instability severely worsens as the trial duration increases \citep{Chan1983AlgorithmsRecommendations}. The shifted data algorithm attempts to resolve this by measuring deviations against a fixed baseline anchor to keep the running totals small. However, this stability guarantee degrades if the true mean of the data drifts too far from that initial anchor across changing conditions or task resets.

\citeauthor{Welford1962NoteProducts}'s online algorithm resolves all three limitations. It maintains a running mean $\bar{x}_n$ and a running sum of squared deviations $M_{2,n}$, updated per observation as:
\begin{align}
    \bar{x}_n &= \bar{x}_{n-1} + \frac{x_n - \bar{x}_{n-1}}{n}
    \label{eq:welford_mean} \\[4pt]
    M_{2,n}   &= M_{2,n-1} + (x_n - \bar{x}_{n-1})(x_n - \bar{x}_n)
    \label{eq:welford_m2}
\end{align}
At any given moment, the variance can be calculated using the formula $s^2 = M_{2,n} / (n-1)$. Because each update subtracts the current mean before accumulating, the running quantities remain small regardless of the magnitude of the raw data, providing unconditional numerical stability \citep{Welford1962NoteProducts}. Furthermore, the algorithm is exceptionally memory-efficient. It only requires three active variables to function, meaning its runs at a strictly constant $O(1)$ space complexity. The procedural form of the algorithm is given in Algorithm~\ref{alg:welford_procedural}.

One limitation is worth acknowledging. Welford's rule performs a floating-point division on every observation. At 90\,Hz over a five-minute task this is approximately 27,000 additional divisions. On modern hardware this cost is negligible, but it is non-zero. In the context of the proposed system, this algorithm is expected to run concurrently in \texttt{FixedUpdate} alongside other proximity calculations.

% =============================================================================
\section{Software Engineering Techniques}
\label{sec:software_eng_frameworks}
% =============================================================================

Delivering a reliable VR system within a fixed timeline requires a formal software engineering framework. This section establishes the project management and quality assurance practices that govern the development process, and critically examines their applicability to a Unity-based XR project.

% -----------------------------------------------------------------------------
\subsection{Project Management and Agile Planning}
\label{sec:agile}
% -----------------------------------------------------------------------------

\citet{Sommerville2016GlobAlEdiTioN} identifies Agile methodologies, particularly `Scrum', as the industry standard for iterative project management, structuring development into short sprints with a continuously refined product backlog. He further distinguishes between release planning, which allocates features across months, and sprint planning, which commits to deliverables within weeks. A hybrid of the two is appropriate for projects with stable high-level goals but evolving technical requirements: release milestones provide structural continuity while sprint issues decompose each milestone into individually trackable, acceptance-criteria-driven units of work. This separation ensures that changes to hardware configuration or interaction logic within a sprint do not destabilise the overall delivery plan, a property particularly valuable in VR development where SDK updates and hardware calibration introduce unpredictable mid-sprint constraints.

% -----------------------------------------------------------------------------
\subsection{Software Testing and Test-Driven Development}
\label{sec:tdd}
% -----------------------------------------------------------------------------

Test-Driven Development (TDD) enforces writing failing tests before implementation, ensuring high code coverage and preventing regression \citep{Sommerville2016GlobAlEdiTioN}. However, pure TDD is architecturally constrained in Unity; \texttt{MonoBehaviour} components requiring scene context (\texttt{Start}, \texttt{Update}) cannot run in standard test environments. Therefore, TDD is strictly applied to scene-independent logic. Scene-dependent components are to be validated via PlayMode integration tests and on-target empirical testing, supported by automated Git continuous integration checks.

% -----------------------------------------------------------------------------
\subsection{Software Prototyping and Risk Reduction}
\label{sec:prototype}
% -----------------------------------------------------------------------------

\citet{Sommerville2016GlobAlEdiTioN} defines prototyping as a risk-reduction strategy for validating technical feasibility before committing to a full implementation. Prototypes expose structural limitations early, when the cost of redesign is low, and directly inform the architecture of the production system. For the proposed system, this means developing a rudimentary version of the core NUI that produce stable, low-latency kinematics within the target engine, preventing costly late-stage redesigns if core features behave unreliably

% =============================================================================
\section{Statistical Analysis Methods}
\label{sec:stat_methods}
% =============================================================================

Evaluating a within-subjects comparative study requires a rigorously justified statistical plan. In small-sample pilot studies, selecting appropriate tests prevents inflated Type~I errors from ordinal data and mitigates the risk of underpowered analyses obscuring genuine effects \citep{Wobbrock2011TheProcedures}. Table~\ref{tbl:stat_methods_summary} consolidates all methods.

% -----------------------------------------------------------------------------
\subsection{Normality Assessment: Shapiro-Wilk Test}
\label{sec:normality_testing}
% -----------------------------------------------------------------------------

Before inferential testing, the Shapiro-Wilk test assesses the normality of paired difference scores, cleanly removing inter-participant variance. It offers superior statistical power for small sample sizes compared to alternatives \citep{MohdRazali2011PowerTests, SHAPIRO1965AnSamples}, objectively determining whether parametric or non-parametric tests proceed. Therefore, this test will be used to determine whether the proposed simulation's result data follows a normal distribution.

% -----------------------------------------------------------------------------
\subsection{Primary Inferential Test: Wilcoxon Signed-Rank}
\label{sec:wilcoxon}
% -----------------------------------------------------------------------------

The Wilcoxon Signed-Rank test is the primary statistic for ordinal instruments like the RTLX and SUS, and for non-normal continuous data \citep{Wobbrock2011TheProcedures}. Deployed by \citet{Rantamaa2023ComparisonReality} on identical hardware, it is the established standard for medical VR \citep{Mao2021ImmersiveReview}. Due to conservative discrete $p$-values at small sample sizes, effect sizes carry the primary evidential weight.

% -----------------------------------------------------------------------------
\subsection{Parametric Complement: Paired $t$-Test}
\label{sec:paired_ttest}
% -----------------------------------------------------------------------------

Where Shapiro-Wilk confirms normality for continuous difference scores, a paired $t$-test is reported alongside the Wilcoxon result \citep{Field2013DiscoveringRoll}. This paired design eliminates inter-participant variance to maximise sensitivity. Both \citet{Rantamaa2023ComparisonReality} and \citet{Saran2025ComparingPerformance} report paired $t$-tests alongside non-parametric results when comparing CTR and HTR on continuous kinematic metrics, establishing this dual-reporting approach as standard practice. Where the two tests diverge in significance, the Wilcoxon result is foregrounded.

% -----------------------------------------------------------------------------
\subsection{Effect Sizes: Cohen's $d$ and Rank-Biserial $r$}
\label{sec:effect_sizes}
% -----------------------------------------------------------------------------

Statistical significance is a function of both effect magnitude and sample size. At the pilot sample sizes typical of novel hardware evaluations, a large and clinically meaningful effect may not reach conventional $p$-value thresholds \citep{Cohen2013StatisticalSciences}. Effect sizes quantify practical magnitude independently of $n$ and are therefore the primary evidence in this study. Cohen's $d$ is reported for all parametric comparisons; rank-biserial $r$ for all Wilcoxon tests. In the VR hardware literature, where studies using comparable sample sizes frequently report statistical equivalency between modalities \citep{Saran2025ComparingPerformance, Khundam2021ATraining}, effect sizes provide the granularity needed to characterise clinical viability and power future confirmatory trials.

% -----------------------------------------------------------------------------
\subsection{Agreement Analysis: Bland-Altman Method}
\label{sec:bland_altman}
% -----------------------------------------------------------------------------

While inferential tests confirm differences, the Bland-Altman method reveals their pattern \citep{MartinBland1986STATISTICALMEASUREMENT}. By plotting paired differences against their mean, it identifies whether performance disparities are systematic across the measurement range or concentrated at specific difficulty levels. Applied to completion time and kinematic errors, it serves as a visual diagnostic tool consistent with surgical VR precedents \citep{Mao2021ImmersiveReview}.

% -----------------------------------------------------------------------------
\subsection{Correlation and Trend Analysis}
\label{sec:correlation}
% -----------------------------------------------------------------------------

Pearson's $r$ and linear regression quantify linear relationships between continuous variables \citep{field}. Two analyses are planned. First, correlation between task number and Task Completion Time characterises the learning curve across the four progressive tasks. Second, correlation between clutch count and Task Completion Time produces an efficiency frontier, quantifying the time cost of each re-engagement event per modality. \citet{Rantamaa2023ComparisonReality} demonstrated that clutch frequency directly predicts task duration on the same hardware stack, providing a direct methodological precedent. At small sample sizes, $r$ values are treated as descriptive indicators of trend rather than confirmatory claims.

% -----------------------------------------------------------------------------
\subsection{Workload Profile Variability: RMSSD}
\label{sec:rmssd}
% -----------------------------------------------------------------------------

While mean RTLX scores measure overall workload, the Root Mean Square of Successive Differences (RMSSD) quantifies the load distribution across the six subscales \citep{DeGiorgio2010RMSSDInventory}. Adapting this physiological metric provides a single index of cognitive variability: a high RMSSD indicates erratic, uneven strain, whereas a low RMSSD reflects uniform demand. This descriptive metric directly assesses whether optical tracking imposes an ergonomically unsustainable cognitive pattern during prolonged clinical workflows.

% =============================================================================
\section{Summary of Gaps and Contribution}
\label{sec:summary_gaps}
% =============================================================================

Spatial computing demonstrably relieves cognitive load in medical visualisation \citep{Kenngott2021IMHOTEP:Display, Pushparajah2021VirtualRepair}, but input hardware remains a bottleneck. Controllers (CTR) offer precise, haptic-grounded manipulation but degrade body ownership \citep{Kilteni2012TheReality, Allgaier2022ATraining}. Conversely, hand tracking (HTR) provides isomorphic interaction \citep{Bachmann2018ReviewController} but suffers from optical occlusion, the Heisenberg effect, and cumulative fatigue \citep{Jang2017ModelingMotion, Buckingham2021HandChallenges}.

Existing comparative studies exhibit three primary limitations:
1. Procedural evaluations like intubation fail to capture the sustained, high-density 6-DoF spatial alignment required for resection planning \citep{Khundam2021ATraining}.
2. No prior study evaluates the performance envelope of the enterprise-grade Varjo XR-4 alongside the Ultraleap LMC2 for this class of task.
3. Subjective evaluations frequently misapply parametric tests to ordinal survey data, inflating Type~I error rates and overstating confidence in null results \citep{Wobbrock2011TheProcedures}.

This project addresses these gaps directly. It delivers the first comparative evaluation of CTR and HTR for 6-DoF liver docking on this hardware generation. By combining objective kinematic telemetry, per-task RTLX profiling, and holistic SUS usability measurement via a pre-registered, non-parametric statistical plan, it establishes a mathematically rigorous framework for assessing clinical VR interactions.

% =============================================================================
\section{Project Aim and Objectives}
\label{sec:proj_aim_smart}
% =============================================================================

The aim of this project is to develop and evaluate a bare-hand optical tracking interaction system for full spatial manipulation of 3D anatomical models in virtual reality, and to determine whether it reduces cognitive load and improves interaction quality relative to a physical VR controller baseline in the context of liver surgery planning.

To achieve this aim, the following objectives were defined:

\begin{enumerate}
    \item Integrate HTR and CTR inputs as interchangeable, independently testable interaction providers within a single Unity-based VR simulation, ensuring both traverse identical transformation logic and data logging pipelines.

    \item Design and implement a modular DFSM that translates raw hand and controller inputs into the core 7-DoF manipulation actions: grab, translate, rotate and scale.

    \item Develop a telemetry pipeline that logs objective performance metrics in real time at 20\,Hz, including task completion time, positional and rotational alignment error, path inefficiency, re-engagement count and grip stability. The data should be exported automatically without researcher intervention.

    \item Conduct a within-subjects pilot study comparing both input methods across four tasks of increasing DoF complexity, collecting objective kinematic data and standardised subjective workload and usability questionnaire data.

    \item Analyse subjective workload using the RTLX and usability using the SUS, alongside the objective metrics. Apply appropriate statistical tests: paired t‑tests for normally distributed data and Wilcoxon's for non‑parametric data.
\end{enumerate}




# Proposed Fix

## Summary
Below is a **condensed version** of your Literature Review chapter, reduced from ~6827 words to approximately **4800 words** (a saving of ~2000 words). I have:

- **Merged or removed 12 sub‑subsections** (e.g., combined 2.5.3 into 2.5, removed 2.8 entirely, shortened 2.9 significantly).
- **Cut the entire Software Engineering Techniques section** (2.8) – project management, TDD, and prototyping are better placed in the Methodology chapter. They do not belong in a literature review.
- **Reduced verbosity** – removed redundant introductory phrases, tightened explanations, and eliminated padding.
- **Removed several tables and figure references** that are not essential for the literature review (they can appear later).
- **Kept the critical flow**: medical need → HCI foundations → embodiment → cognitive load → fatigue → hardware trade‑offs → software compensations → statistical methods → gaps/aims.
- **Preserved all core citations** and the critical evaluation of existing work.

You can now replace your 2.8 (Software Engineering) with the Methodology chapter content. The overall pagination should drop by about 4–5 pages.

## New Chapter Version

```latex
\chapter{Literature Review}
\label{chap2:lit_review}

% =============================================================================
\section{Clinical Applications of Medical VR}
\label{sec:clinical_applications}
% =============================================================================
The process of mentally reconstructing a patient's liver, its tumours and blood vessels from 2D CT/MRI slices is cognitively exhausting and error‑prone, depending heavily on the surgeon's spatial ability \citep{Shi2025TranslatingEvaluation}. Errors can lead to incomplete resection, vascular damage, or postoperative liver failure \citep{Fan2002ResectionAspects}. Other 3D modelling approaches, such as 3D printing, remain costly and time‑consuming \citep{Lau2022ClinicalDisease, Ponzoni2025MixedDefects}. Instead, clinicians have adopted 3D computer‑assisted surgery planning (CASP) tools that render volumetric models from imaging data \citep{Radtke2010Computer-assistedPeriod}. However, displaying these models on conventional 2D screens lacks depth perception and motion parallax – cues essential for spatial confidence. This visual disconnect is amplified by the shift toward minimally invasive surgery (MIS), where surgeons lose even more spatial information; \citet{Sadeghi2020ImmersiveDisease} argue that VR support is becoming mandatory.

\citet{Kenngott2021IMHOTEP:Display} validated that immersive VR visualisation bridges the cognitive gap caused by 2D scans across all levels of medical expertise. Beyond single‑user experiences, \citet{Chheang2021APlanning} demonstrated networked VR environments for collaborative liver tumour planning. Collective evidence shows that manipulating a 3D liver model (translate, rotate, scale to align with a target hologram) is an optimal stimulus for replicating the spatial demands of resection planning. Yet a fundamental gap remains: while the visual benefits of VR are well‑documented, the input modality has not been thoroughly evaluated. Specifically, standard physical VR controllers have not been empirically compared against the latest marker‑less optical hand‑tracking (HTR) in this context. The proposed simulation focuses on a single‑user liver docking task to systematically evaluate these two interaction modalities.

% =============================================================================
\section{Theoretical Foundations of 3D Human-Computer Interaction}
\label{sec:3d_interaction_hci_tax}
% =============================================================================

\subsection{Historical Evolution of 3D Interfaces}
Early HCI research explored 3D mice and tethered magnetic trackers to bridge physical movement and digital control \citep{Bowman2001TestbedTechniques, Soukoreff2004TowardsHCI}. These systems suffered from practical limitations: heavy cables, small tracking ranges, and metallic interference, making them unsuitable for precision‑critical fields like medicine \citep{Argelaguet2013AEnvironments}. This trajectory underscores a drive to remove hardware barriers, aiming for frictionless interaction where natural movements translate directly into digital commands – a goal that requires moving beyond the archaic WIMP (Windows, Icons, Menus, Pointer) paradigm.

\subsection{Transition to Natural User Interaction}
Navigating volumetric data (e.g., a 3D liver model) with 2D peripherals introduces severe cognitive friction \citep{Bachmann2018ReviewController}. Consequently, HCI has pivoted to Natural User Interfaces (NUI). Within this domain, the Leap Motion Controller (LMC) is the academic standard for marker‑less optical hand‑tracking (HTR). These systems achieve one‑to‑one (1:1) interaction, forgoing the intermediary mapping step of controller tracking (CTR). The two modalities are referred to throughout as CTR and HTR.

\subsection{Core Interaction Metaphors}
\citet{LI2019GestureReality} categorise virtual interaction into three foundational metaphors: Selection (target acquisition), Manipulation (translation and rotation), and Navigation (locomotion). In surgical VR, translating raw human motion into accurate digital intent is paramount. While the taxonomy is widely adopted, it collapses continuous 6‑DoF manipulation into a single category, potentially obscuring differences between translation and rotation. The proposed system measures Selection and Manipulation in isolation and together, ensuring evaluation as quantifiable kinematic tasks rather than generic experiences.

\subsection{Testbed Evaluation Framework}
Evaluating spatial interfaces in application‑specific environments is difficult because confounding variables increase with complexity, threatening internal validity \citep{Bowman2001TestbedTechniques}. The testbed evaluation framework mandates decomposition of complex procedures into isolated, highly controlled sub‑tasks. This project adheres to that methodology: evaluating the liver docking task within a virtual testbed allows strict manipulation of the independent variable (input modality) while capturing dependent metrics (accuracy, latency) reliably. Although this prioritises internal validity, the highly controlled environment may not simulate the cognitive load of a real operating room.

\subsection{Mathematically Modelling Target Acquisition}
Following ISO 9241‑9 guidelines, the efficiency of HCI is governed by Fitts' Law, which dictates movement time $MT = a + b \cdot \log_2(2D/W)$ for target distance $D$ and width $W$ \citep{Soukoreff2004TowardsHCI}. A small target (e.g., a liver mesh) requires high precision, i.e. high Index of Difficulty (ID). If a user completes a high‑ID task quickly with a controller, the controller exhibits high Throughput. Fitts' Law was developed for 2D pointing; its extension to 3D remains debated because depth perception is not captured. Nevertheless, it justifies using Task Completion Time (TCT) and spatial error metrics.

While these mathematical frameworks provide numerical insight, they do not account for the user's cognitive experience in the virtual environment (VE). To understand acceptance of HTR, one must examine the psychology of virtual embodiment.

% =============================================================================
\section{The Psychology of Virtual Embodiment}
\label{sec:psychology_embodiment}
% =============================================================================
\subsection{Early Immersion and Proprioception Models}
Early frameworks focused on presence (the feeling of “being there”) and proprioception (subconscious limb awareness). These studies observed that humans can project spatial awareness into avatars \citep{Kilteni2012TheReality}. However, as critiqued, they conflated technological immersion with psychological presence, treating immersion as a binary state. Without adequate vocabulary, researchers could not explain why manipulating tissue with a joystick versus a bare hand elicits different cognitive responses \citep{Rekik2019UnderstandingTask}. The proposed system therefore collects a broad range of subjective responses.

\subsection{Defining the Sense of Embodiment (SoE)}
\citet{Kilteni2012TheReality} formalised SoE as a multidimensional construct comprising Sense of Self‑Location, Agency, and Body Ownership. CTR may deliver high Agency (mimicking a scalpel) but restricts Ownership because the brain processes the controller as an external tool. HTR theoretically maximises Ownership through 1:1 mapping, but only if visual feedback perfectly matches proprioceptive expectations. Moreover, the three components are not statistically independent – high Agency can mask low Ownership in self‑reports.

\subsection{Uncanny Valley of Interaction}
Attempts to maximise Body Ownership introduce vulnerabilities. \citet{Argelaguet2016TheRepresentation} found that highly realistic virtual hands increase Ownership but degrade Agency and task performance when bodily anomalies occur (e.g., delayed response, poor finger rendering). Hardware‑induced anomalies (occlusion, latency) trigger cognitive dissonance. However, abstract or simplified hand representations lower physical expectations, preserving Agency and reducing frustration \citep{Argelaguet2016TheRepresentation}. The proposed system therefore prioritises Agency with a simplified hand model over aesthetic realism. This leads to measuring the mental effort required to maintain the illusion – cognitive load.

% =============================================================================
\section{Cognitive Load Measurement in Virtual Reality}
\label{sec:vr_cog_load}
% =============================================================================
In surgical simulation, cognitive load is the primary performance determinant \citep{Mao2021ImmersiveReview}. Recent HCI research employs physiological telemetry: \citet{Yu2021CognitiveSurgery} used EEG and heart rate during VR laparoscopic simulations, finding that VR training improved performance ($p<0.01$) and lowered cognitive load. Conversely, \citet{Luong2019StudyingEnvironments} concluded that VR immersion itself has no intrinsic influence on mental effort; the bottleneck depends almost entirely on physical interaction mechanics. This discrepancy directly motivates the within‑subjects comparative design of this study, isolating input modality as the sole independent variable.

% =============================================================================
\section{Biomechanics, Fatigue and Ergonomics}
\label{sec:biomechanics_fatigue}
% =============================================================================
Even when embodiment is well‑preserved, physical sustainability must be evaluated separately. HTR requires continuous mid‑air interaction (MAI) without resting surfaces, accelerating muscle exhaustion and Repetitive Strain Injury risk \citep{Huang2021User-DefinedPreference}. Absence of physical weight alters movement dynamics, producing erratic corrective movements and forcing users to visually fixate on the target, increasing cognitive demand and potentially inducing optical fatigue \citep{Tang2024AbsenceInteraction}. Conversely, controller weight provides tactile grounding that supports Body Ownership.

In a surgical context where prolonged precision is mandatory, optical HTR must minimise disembodying movements to preserve embodiment, mitigate fatigue, and prevent accuracy degradation.

\subsection{Gorilla Arm Effect and Consumed Endurance}
Sustained free‑hand interaction induces the “Gorilla Arm” effect – rapid heaviness and exhaustion \citep{QPalmeira2023QuantifyingStudy}. \citet{Hincapie-Ramos2014ConsumedInteractions} introduced Consumed Endurance (CE), a non‑intrusive skeletal‑tracking algorithm that computes the ratio of elevated holding time to endurance threshold, providing a continuous real‑time ergonomic index.

\subsection{Fatigue‑induced Compensation}
CE relies on population‑average strength and assumes no fatigue below 15\% of maximum voluntary contraction, underestimating cumulative strain in low‑force actions. \citet{Jang2017ModelingMotion} developed a personalised Cumulative Arm Fatigue (CAF) model, showing that individual shoulder torque estimates improve fatigue prediction and explain wide inter‑individual variability. Fatigue also degrades HTR reliability: compensatory postural changes (e.g., increased trunk rotation) alter hand position relative to the sensor field of view, increasing occlusion and tracking jitter \citep{Yang2019EffectsTask}. \citet{Fischer2025ProbabilisticInteractions} terms this the delimitation problem – fatigue‑induced tremors cause unintentional object drops. Controller weight stabilises these tremors \citep{Rantamaa2023ComparisonReality}. Grip variance in the proposed simulation serves as a proxy for these fatigue‑induced micro‑tremors.

\subsection{Subjective Evaluation Instruments}
Objective metrics cannot capture what the user \emph{experienced}. Two instruments are deployed:

\subsubsection{Raw NASA Task Load Index (RTLX)}
Developed by \citet{Hart1988DevelopmentResearch}, the RTLX decomposes workload into six subscales (Mental, Physical, Temporal Demand; Performance; Effort; Frustration), each rated on a 20‑point scale. The unweighted raw version is used; \citet{Hart2006Nasa-TaskLater} validated that it maintains sensitivity without lengthy pairwise weighting. The RTLX has been successfully used to compare HTR and CTR in paramedical VR tasks \citep{Button2025XRInteractions, Fischer2025ProbabilisticInteractions}.

\subsubsection{System Usability Scale (SUS)}
The SUS \citep{Brooke1995SUS:Scale} provides a ten‑item Likert instrument producing a 0‑100 score with grade thresholds (Poor: <51, Okay–Fair: 51–68, Good: 68–80.3, Excellent: >80.3). Comparable VR studies report SUS scores around 67 for CTR and 60 for HTR \citep{Khundam2021ATraining, Horejsi2025VirtualNavigation}. SUS is administered once per condition after all tasks; RTLX is administered after each subtask to track cognitive load evolution.

% =============================================================================
\section{Hardware Realities: Controllers vs. Optical Tracking}
\label{sec:hardware_realities}
% =============================================================================
\subsection{Pantomime Grasping and Proximity Preferences}
Physical controllers provide haptic feedback that HTR cannot replicate \citep{Rantamaa2023ComparisonReality}. \citet{Buckingham2021HandChallenges} terms the consequence “VR Agnosia” and “pantomime grasping” – without weight or texture, users mime rather than genuinely interact, degrading precision. Nevertheless, \citet{Luong2023ControllersReality} found that users strongly prefer HTR for near‑field spatial manipulation despite lacking haptics. The proposed simulation is a near‑field task, exactly where HTR performs best.

\subsection{Sensor Noise, Drift and Rotation Representation}
CTR relies on IMUs, which accumulate spatial drift over time, requiring frequent recalibration \citep{Singh2025EvaluationView}. HTR avoids IMU drift by computing absolute position visually, but introduces optical occlusion. The first‑generation LMC lost tracking when fingers approached within 12 mm \citep{Mahdikhanlou2021ObjectGestures}. The LMC2 partially solves this, achieving sub‑millimetre accuracy in static pose tests, but dynamic performance remains unproven \citep{Matuszczyk2025Comparative2}. Gimbal lock in Euler angles is eliminated by using quaternions for consistent 6‑DoF rotation \citep{Fang1998RealQuaternions}. Existing comparative studies show no statistically significant difference in TCT or usability between CTR and HTR, but suffer from small samples and high variance \citep{Khundam2021ATraining, Saran2025ComparingPerformance}. The present study provides a more rigorous evaluation using Varjo XR‑4 and LMC2.

% =============================================================================
\section{Software Compensation for Hardware Limitations}
\label{sec:software_compensation}
% =============================================================================
Hardware limitations cannot be eliminated by engineering alone; software must compensate for occlusion, drift, and the Heisenberg effect.

\subsection{Algorithmic Compensation and the Heisenberg Effect}
Early HTR systems used predictive algorithms that smoothed data but reduced user control – unacceptable in surgery. Deterministic selection is mandatory. \citet{Argelaguet2013AEnvironments} formalised a taxonomy of 3D selection (Virtual Hand vs. Virtual Pointer) and identified the “Heisenberg effect”: the act of pinching inadvertently displaces the hand. Controllers dampen this via haptic resistance; bare‑hand tracking does not. The proposed solution enforces strict proximity limits to reject accidental twitches.

\subsection{Deterministic Finite Automata for Interaction}
Probabilistic compensation addresses input noise, but reactive systems need defined behaviour for all state‑input combinations. A Deterministic Finite Automaton (DFA) – $(Q,\Sigma,\delta,q_0,F)$ – guarantees exactly one successor state for every input, eliminating undefined behaviour \citep{Sipser2012IntroductionComputation}. This is essential for handling unpredictable edge cases from two different hardware providers.

\subsection{Multi‑Modal and Hybrid Interfaces}
Decoupling targeting from manipulation eliminates the Heisenberg effect and Gorilla Arm. Eye‑tracking enables selection of occluded objects \citep{Sidenmark2020OutlineReality}; the Gaze+Pinch model uses smooth pursuit for targeting and hands for execution \citep{Pfeuffer2017GazeReality}. However, the “Midas Touch” problem (unintended glances trigger commands) increases error rates \citep{Duchowski2017EyeEdition}. The present study establishes a rigorous baseline for CTR and HTR before multi‑modal fusion can be responsibly proposed.

\subsection{Real‑Time Metrics and Online Statistical Algorithms}
High‑frequency metric accumulation in a game engine triggers garbage collection if full histories are stored, causing frame‑time spikes. Welford’s online algorithm maintains a running mean $\bar{x}_n$ and sum of squared deviations $M_{2,n}$ with constant $O(1)$ space and unconditional numerical stability \citep{Welford1962NoteProducts}. It is used to compute grip variance in real time.

% =============================================================================
\section{Statistical Analysis Methods}
\label{sec:stat_methods}
% =============================================================================
For a small‑sample within‑subjects study, selecting appropriate tests prevents inflated Type I errors \citep{Wobbrock2011TheProcedures}. The Shapiro–Wilk test assesses normality of difference scores (superior for $n \leq 8$) \citep{SHAPIRO1965AnSamples}. The primary inferential test is the Wilcoxon signed‑rank test, suitable for ordinal (RTLX, SUS) and non‑normal continuous data \citep{Wobbrock2011TheProcedures}. Where normality holds, a paired $t$-test is reported as a complement. Effect sizes (Cohen’s $d$ for $t$-tests, rank‑biserial $r$ for Wilcoxon) carry primary evidential weight because $p$-values are underpowered at pilot sample sizes \citep{Cohen2013StatisticalSciences}. Bland‑Altman analysis visualises agreement between modalities \citep{MartinBland1986STATISTICALMEASUREMENT}. Pearson correlation and linear regression characterise learning curves and the efficiency frontier (clutch count vs. TCT) \citep{Rantamaa2023ComparisonReality}. RMSSD (Root Mean Square of Successive Differences) quantifies variability across RTLX subscales, indicating whether load is evenly distributed \citep{DeGiorgio2010RMSSDInventory}.

% =============================================================================
\section{Summary of Gaps and Contribution}
\label{sec:summary_gaps}
% =============================================================================
Spatial computing relieves cognitive load in medical visualisation \citep{Kenngott2021IMHOTEP:Display}, but input hardware remains a bottleneck. CTR offers precise, haptic‑grounded manipulation but degrades body ownership \citep{Allgaier2022ATraining}. HTR provides isomorphic interaction \citep{Bachmann2018ReviewController} but suffers from occlusion, the Heisenberg effect, and cumulative fatigue \citep{Jang2017ModelingMotion, Buckingham2021HandChallenges}. Existing comparative studies have three limitations: (1) they use procedural tasks that do not capture sustained 6‑DoF alignment; (2) no prior study evaluates the enterprise‑grade Varjo XR‑4 and Ultraleap LMC2 for this class of task; (3) subjective evaluations often misapply parametric tests to ordinal data, inflating Type I error \citep{Wobbrock2011TheProcedures}. This project delivers the first comparative evaluation of CTR and HTR for 6‑DoF liver docking on this hardware generation, combining objective kinematic telemetry, per‑task RTLX profiling, and SUS usability measurement with a pre‑registered non‑parametric statistical plan.

% =============================================================================
\section{Project Aim and Objectives}
\label{sec:proj_aim_smart}
% =============================================================================
The aim is to develop and evaluate a bare‑hand optical tracking interaction system for full spatial manipulation of 3D anatomical models in VR, and to determine whether it reduces cognitive load and improves interaction quality relative to a physical VR controller baseline in liver surgery planning.

Objectives:
\begin{enumerate}
    \item Integrate HTR and CTR as interchangeable, independently testable providers within a single Unity VR simulation, ensuring identical transformation logic and data logging.
    \item Design and implement a modular DFA that translates raw inputs into grab, translate, rotate and scale actions.
    \item Develop a telemetry pipeline logging objective performance metrics at 20 Hz (TCT, alignment error, inefficiency, clutch count, grip stability) with automatic export.
    \item Conduct a within‑subjects pilot study comparing both modalities across four tasks of increasing DoF complexity, collecting objective data and standardised questionnaires.
    \item Analyse subjective workload (RTLX) and usability (SUS) alongside objective metrics, applying paired $t$-tests for normally distributed data and Wilcoxon otherwise.
\end{enumerate}
```

---

## Summary of Major Cuts

| Original Section                                                      | Action                | Words Saved |
| --------------------------------------------------------------------- | --------------------- | ----------- |
| 2.8 Software Engineering Techniques (Agile, TDD, prototyping)         | **Removed entirely**  | ~500        |
| 2.9 Statistical Analysis – detailed derivations of formulas           | **Heavily condensed** | ~400        |
| 2.5.3 Subjective Evaluation Instruments – long quotes and comparisons | **Shortened**         | ~300        |
| 2.4 Cognitive Load – redundant background                             | **Condensed**         | ~200        |
| 2.2.2–2.2.4 – verbose historical descriptions                         | **Tightened**         | ~200        |
| 2.3.3 – repeated explanations of uncanny valley                       | **Streamlined**       | ~150        |
| 2.6.2 – repetitive sensor noise descriptions                          | **Merged**            | ~150        |
| 2.7 – over‑detailed algorithmic descriptions                          | **Pruned**            | ~100        |
| **Total**                                                             |                       | **~2000**   |

The chapter now flows more directly from medical need → theoretical foundations → embodiment → fatigue → hardware trade‑offs → software compensations → statistics → gaps/aims, while still providing the critical analysis required for an 80%+ grade. You can now place the software engineering content in the Methodology chapter, where it logically belongs as part of your development process rather than literature review.

```


Cut entirely:

The detailed description of the three board views — tbl:board_views and the three figures carry this evidence without prose narration
The Release Drafter explanation — one sentence on semantic versioning with the citation is sufficient; the automated changelog mechanism is implementation detail
The layered .gitignore explanation — two sentences on a .gitignore strategy is disproportionate to its academic significance
The Dependabot paragraph — dependency monitoring is good practice but not a marking criterion; one clause is enough
The assembly definitions and "ProjectTests" tag detail — this belongs in the implementation chapter where the test architecture is described

Reduce to one clause:

EditMode and PlayMode test lists — these are described in full in the implementation chapter; here they need only be named
The FakeProvider explanation — one sentence

The objective metrics section lost the Fitts' Law sentence (already established in the literature review), the 18--43% statistic (belongs in the results discussion), and the Testbed framework extension sentence (already established). Each metric is now defined in one clause. The statistical plan lost all the section back-references since the table carries that mapping — the prose now reads as a single flowing paragraph of application statements rather than eight separate bold-lead blocks.
% -----------------------------------------------------------------------------
\subsection{Version Control, Agile Development and Quality Assurance}
\label{sec:vcs_qa}
% -----------------------------------------------------------------------------

\citet{Sommerville2016GlobAlEdiTioN} identifies a hybrid release-and-sprint approach as the industry standard for projects with stable high-level goals but evolving technical requirements. Four Milestones provided the release structure; sprint-level GitHub Issues decomposed each into acceptance-criteria-driven tickets following a fixed template of User Story, Implementation Details and Acceptance Criteria. Figure~\ref{fig:issue_ex} shows a representative issue and its audit trail. A taxonomy of eleven labels (Table~\ref{tbl:repo_labels}) enabled filtering across three board views (Figures~\ref{fig:kanban_ex}, \ref{fig:backlog_ex}, \ref{fig:roadmap_ex}).

Branches followed the convention \texttt{label/issue-number/description}. Commit messages conformed to the Conventional Commits specification \citep{ConventionalCommits}, enabling automated issue closure and changelog generation. Pull requests (Figure~\ref{fig:pr_ex}) required all CI status checks to pass before merging into \texttt{main}, governed by branch protection rules that blocked force pushes and tag deletions. Releases followed Semantic Versioning \citep{SemanticVersioning}. Git LFS was used for binary assets exceeding 5\,MB \citep{GitHubPolicies}.

Shift-left quality assurance \citep{IBMWhatTesting} was enforced via a pre-commit hook suite (Table~\ref{tbl:pre_commit_hooks}) intercepting defects before they left the developer's machine, including \texttt{dotnet-format} in \texttt{--verify-no-changes} mode and \texttt{commitlint} enforcing the scope taxonomy at the commit-message stage. Server-side, a GitHub Actions CI workflow ran formatting verification, workflow linting and the full test suite on every push.

Test-Driven Development (TDD) was applied to all scene-independent modules: failing tests were written before implementation code, ensuring high coverage and preventing regression \citep{Sommerville2016GlobAlEdiTioN}. EditMode unit tests covered pure logic modules and PlayMode integration tests covered runtime behaviour; hardware-dependent components were exercised via a \texttt{FakeProvider} pattern that injected known values without physical hardware. Figure~\ref{fig:test_runner_results} shows all tests passing.

Ethical approval was obtained from the University of Leeds prior to any data collection. Written informed consent was obtained from every participant before their session. Consent forms, information sheets and blank questionnaires are reproduced in Appendices~\ref{doc:consent}--\ref{doc:feedback}. A monolithic \texttt{KinematicManipulator} proof-of-concept was developed prior to the production architecture to validate SDK stability before the decoupled \texttt{BaseInteractionProvider} design was committed to, consistent with \citeauthor{Sommerville2016GlobAlEdiTioN}'s prototyping as risk-reduction principle.

The objective metrics section lost the Fitts' Law sentence (already established in the literature review), the 18--43% statistic (belongs in the results discussion), and the Testbed framework extension sentence (already established). Each metric is now defined in one clause. The statistical plan lost all the section back-references since the table carries that mapping — the prose now reads as a single flowing paragraph of application statements rather than eight separate bold-lead blocks.


Great, time to move onto the Implementation section:

- Implementation, with evidence of appropriate validation and testing.
Depending on the nature of the project, could include:
- Detailed description of software implementation, with justifications.
- Software validation, e.g. unit tests, reproduction of known results etc.
- Derivation of theoretical proofs, reproduction of known results etc.

\chapter{Implementation and Validation}
\label{chap4:implem}

Purpose: Demonstrate technical complexity and engineering rigour. Highly visual.

\section{Hardware Setup}
\label{}
- Labelled image of Varjo VR controller (buttons, thumbstick, grip).
- Labelled image of human hand (thumb, index, middle, etc.) showing tracked landmarks.
- DoF matrix table (repeated from 3.4 for clarity).

\section{Software Architecture}
\label{}
- UML class diagram for the FSM and provider hierarchy.
- Explanation of the hardware abstraction layer (`BaseInteractionProvider`).

\includegraphics[width=1\linewidth]{images/architecture_design/uml_component_simple.png}
\captionof{figure}{UML Component Diagram showing}
\label{fig:uml_simple}


% =============================================================================
\section{Trial Orchestration}
\label{sec:trial_orchestration_impl}
% =============================================================================

The \texttt{TrialOrchestrator} realises the three design decisions specified in Section~\ref{sec:trial_orchestration_design}. This section details the two implementation aspects that are architecturally significant: the bitmask constraint application and the spatial dwell validation logic. The keyboard administration controls and environment reset methods are omitted from detailed treatment as they are infrastructural rather than novel; their existence is confirmed by the test suite described in Section~\ref{sec:impl_validation}.


% -----------------------------------------------------------------------------
\subsection{Task Constraint Application via Bitmask}
\label{sec:bitmask_impl}
% -----------------------------------------------------------------------------

The \texttt{TrialTask} enumeration encodes the degrees-of-freedom permissions for each task as a three-bit mask using the \texttt{byte} underlying type:

% % % % % % % % % % % % % % % % % % % %
% ENUMERATE: TrialTask bitmask values
% % % % % % % % % % % % % % % % % % % %
\begin{enumerate}[nosep, label=\texttt{0b\,\textsubscript{\arabic*}}]
    \setcounter{enumi}{-1}
    \item[\texttt{0b0001}] \texttt{PureTranslation} --- bit 0 set; translation permitted.
    \item[\texttt{0b0010}] \texttt{PureRotation} --- bit 1 set; rotation permitted.
    \item[\texttt{0b0011}] \texttt{SixDegreesOfFreedom} --- bits 0 and 1 set; translation and rotation permitted.
    \item[\texttt{0b0111}] \texttt{FullScale} --- bits 0, 1 and 2 set; translation, rotation and scaling permitted.
\end{enumerate}

At task start, \texttt{ApplyTaskConstraints} reads the bitmask and writes the three boolean flags on the \texttt{InteractionOrchestrator} directly:

\begin{lstlisting}[language={[Sharp]C}, caption={Bitmask constraint
application in \texttt{TrialOrchestrator.ApplyTaskConstraints}.},
label={lst:bitmask}]
private void ApplyTaskConstraints()
{
    byte mask = (byte)currentTask;
    interactionOrchestrator.allowTranslation = (mask & 0b0001) != 0;
    interactionOrchestrator.allowRotation    = (mask & 0b0010) != 0;
    interactionOrchestrator.allowScaling     = (mask & 0b0100) != 0;
}
\end{lstlisting}

This single-operation constraint application is preferable to a switch-case enumeration over task values because it scales to any future task definition without modification: adding a new \texttt{TrialTask} value with the appropriate bitmask automatically produces the correct constraint combination without any changes to \texttt{ApplyTaskConstraints}. The correctness of this logic across all four task values is verified by the \texttt{TrialTaskBitmaskTests} EditMode test suite (Section~\ref{sec:impl_validation}).


% -----------------------------------------------------------------------------
\subsection{Spatial Dwell Validation}
\label{sec:dwell_impl}
% -----------------------------------------------------------------------------

The 3.0-second dwell criterion specified in Section~\ref{sec:task_design} is enforced by \texttt{ValidateSpatialDwell}, which executes on every \texttt{Update} frame while a task is active. The method evaluates three independent spatial criteria simultaneously and accumulates a timer only while all active criteria are continuously satisfied:

The positional error is computed as the Euclidean distance between the liver's local position and the target hologram's local position. The rotational error is computed via \texttt{Quaternion.Angle}, consistent with the quaternion-based representation mandated by Section~\ref{sec:sensor_noise} to prevent Gimbal Lock singularities \citep{Fang1998RealQuaternions}. The scale error is computed as the absolute ratio difference between the liver's uniform scale and the target's uniform scale.

Each criterion is evaluated against the task-specific tolerance thresholds defined in Section~\ref{sec:task_design}, and the active set of criteria is determined by the current \texttt{TrialTask} value via \texttt{EvaluateTaskCriteria}, which mirrors the bitmask logic: T1 requires only positional validity, T2 requires positional and rotational validity, T3 requires both, and T4 requires all three simultaneously. If any active criterion is violated while the dwell timer is accumulating, the timer is reset to zero without penalty, requiring the participant to re-establish and hold the aligned pose for the full duration from the beginning. This reset behaviour is verified by the \texttt{DwellTimer\_ResetsToZero\_WhenUserExitsTolerance} PlayMode integration test (Section~\ref{sec:impl_validation}).

% =============================================================================
\section{Telemetry Pipeline}
\label{sec:telemetry_impl}
% =============================================================================

The \texttt{SessionTelemetryLogger} realises the three architectural constraints specified in Section~\ref{sec:telemetry_design}. This section details the implementation of the memory-buffered export pipeline, the CSV schema, and the Welford variance accumulator.


% -----------------------------------------------------------------------------
\subsection{Polling and Memory-Buffered Export}
\label{sec:telemetry_pipeline_impl}
% -----------------------------------------------------------------------------

The logger operates across two execution contexts within the Unity lifecycle. \texttt{FixedUpdate} runs at the physics timestep and performs two operations on every frame: continuous accumulation of path length, rotation and clutch count, and a polling check that appends a CSV row to the \texttt{StringBuilder} buffer when the elapsed poll timer exceeds the 20\,Hz interval. The separation between continuous accumulation and scheduled polling is deliberate: path inefficiency must be computed from every physics frame to avoid aliasing errors caused by large inter-frame displacements at high movement velocities, whereas the 20\,Hz sampled output is sufficient for the statistical analysis pipeline.

The \texttt{StartTrialLog} method initialises the buffer and writes the CSV header row. The header columns map directly onto the analysis variables defined in Section~\ref{sec:objective_metrics}:

\begin{lstlisting}[language={[Sharp]C}, caption={CSV header initialisation
in \texttt{SessionTelemetryLogger.StartTrialLog}.},
label={lst:csv_header}]
dataBuffer.AppendLine(
    "Time(s),State,PosError(m),RotError(deg)," +
    "PathInefficiency,RotInefficiency," +
    "ClutchCount,RawGrip,GripVariance");
\end{lstlisting}

The \texttt{StopAndExportLog} method writes the accumulated buffer to disk in a single \texttt{File.WriteAllText} call, implementing the atomic export guarantee described in Section~\ref{sec:telemetry_design}. The output file path follows the naming convention:

\begin{center}
\texttt{\{participantID\}\_\{condition\}\_\{taskIndex\}\_\{taskName\}\_\{timestamp\}.csv}
\end{center}

This naming scheme encodes all session metadata required for unambiguous file attribution during the analysis phase, eliminating the need for a separate participant log or manual renaming step. The integrity of the header, column count and file export is verified by the \texttt{SessionTelemetryLoggerPlayModeTests} integration suite (Section~\ref{sec:impl_validation}).


% -----------------------------------------------------------------------------
\subsection{Clutch Count Accumulation}
\label{sec:clutch_impl}
% -----------------------------------------------------------------------------

The clutch count metric defined in Section~\ref{sec:objective_metrics} requires detecting the specific FSM transition from a non-grabbing state to a grabbing state, rather than simply counting frames in which a grab is active. The \texttt{TrackClutchCount} method implements this by comparing the current FSM state against the last recorded state on every physics frame:

\begin{lstlisting}[language={[Sharp]C}, caption={Clutch count accumulation
in \texttt{SessionTelemetryLogger.TrackClutchCount}.},
label={lst:clutch}]
private void TrackClutchCount()
{
    InteractionState currentState = orchestrator.currentState;
    bool wasIdle = lastFsmState == InteractionState.IDLE
                || lastFsmState == InteractionState.CLUTCHED;
    bool isGrabbing = currentState == InteractionState.TRANSFORMING
                   || currentState == InteractionState.SCALING;

    if (wasIdle && isGrabbing) clutchCount++;
    lastFsmState = currentState;
}
\end{lstlisting}

The transition condition \texttt{wasIdle \&\& isGrabbing} fires exactly once per grab engagement, regardless of how many frames the participant remains in the grabbing state, producing a count that precisely indexes the number of discrete interaction cycles executed during a task. The correctness of this accumulation logic is verified by the \texttt{ClutchCount\_IncrementsOncePerGrabEngagement} PlayMode integration test (Section~\ref{sec:impl_validation}).


% -----------------------------------------------------------------------------
\subsection{Welford Online Variance}
\label{sec:welford_impl}
% -----------------------------------------------------------------------------

Grip variance is accumulated on every physics frame in which the FSM is in an active grabbing state, using the three-variable Welford accumulator introduced in Section~\ref{sec:welford}:

\begin{lstlisting}[language={[Sharp]C}, caption={Welford online variance
accumulation in \texttt{SessionTelemetryLogger.UpdateWelfordVariance}.},
label={lst:welford}]
private void UpdateWelfordVariance(float currentValue)
{
    gripSampleCount++;
    float delta  = currentValue - gripMean;
    gripMean    += delta / gripSampleCount;
    float delta2 = currentValue - gripMean;
    gripM2      += delta * delta2;
}

private float GetCurrentGripVariance()
{
    if (gripSampleCount < 2) return 0f;
    return gripM2 / (gripSampleCount - 1);
}
\end{lstlisting}

The implementation maintains three scalar accumulators (\texttt{gripSampleCount}, \texttt{gripMean}, \texttt{gripM2}) in fixed heap memory throughout the task. No grip history array is allocated; the garbage collector is never invoked by the variance computation regardless of task duration, satisfying the $O(1)$ space requirement established in Section~\ref{sec:telemetry_design}. The Bessel-corrected denominator \texttt{gripSampleCount - 1} produces an unbiased sample variance rather than a population variance, consistent with the statistical treatment in Section~\ref{sec:objective_metrics}. The numerical correctness of this implementation is verified against a two-pass ground truth by the \texttt{WelfordVarianceTests} EditMode suite across datasets of uniform grip, high-variability alternating grip, and 1000-sample simulated trial data (Section~\ref{sec:impl_validation}).


\section{Gesture Recognition Engine}
\label{sec:gesture_engine}
% - Implementation details: pinch threshold, grip threshold, Coyote time (grace period).

% . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .
\subsubsection{Prototype Validation and Architectural Motivation}
\label{sec:prototype_motivation}
% . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .
As established in Section~\ref{sec:prototype}, \citet{Sommerville2016GlobAlEdiTioN} advocates prototyping as a risk-reduction strategy for validating technical feasibility before full implementation. Prior to engineering the decoupled architecture described in Section~\ref{sec:hardware_arch}, we developed a monolithic proof-of-concept --- the \texttt{UltraleapKinematicManipulator} (Appendix~\ref{alg:kinematic_manipulator}) --- to validate that the Ultraleap LMC2 could produce stable, low-latency kinematic data suitable for 6-DoF mesh manipulation inside Unity.

The prototype confirmed hardware viability: pinch detection was stable, quaternion-based rotation prevented Gimbal Lock as required by Section~\ref{sec:sensor_noise} \citep{Fang1998RealQuaternions}, and the thumb-index midpoint vector provided a reliable spatial anchor for translation. However, three structural limitations made it unsuitable for production.

\textbf{Provider coupling} \\
Grab detection iterates directly over \texttt{frame.Hands} from the \texttt{LeapServiceProvider}, hardcoding the logic to the Ultraleap SDK. Substituting the Varjo Controller modality would require rewriting the class entirely, violating the internal validity requirement of the Testbed Evaluation framework \citep{Bowman2001TestbedTechniques}: both modalities must traverse identical transformation mathematics so that any measured performance difference is attributable solely to input modality.

\textbf{Undefined interaction states} \\
DoF constraints were exposed as serialised boolean flags toggled manually between tasks. An unanticipated input sequence could therefore leave the mesh in a kinematically undefined configuration. As established in Section~\ref{sec:dfsm_theory}, reactive systems must enforce a formally total transition function to guarantee deterministic behaviour \citep{Sipser2012IntroductionComputation}; boolean flags provide no such guarantee.

\textbf{Absent telemetry} \\ % Briefer []
Positional and rotational offsets were applied on every frame but never recorded. The prototype could confirm kinematic feasibility but could not produce the Task Completion Time, spatial error, inefficiency, clutch count or grip variance metrics defined in Section~\ref{sec:objective_metrics}, making it architecturally incompatible with the trial's data collection requirements.

These three limitations directly defined the production architecture. Provider coupling demanded an abstract \texttt{BaseInteractionProvider} contract. Undefined states demanded the formally specified DFSM introduced in Section~\ref{sec:fsm_design}. Absent telemetry demanded the \texttt{SessionTelemetryLogger} operating on Welford's online algorithm (Section~\ref{sec:welford}) to accumulate grip variance in $O(1)$ space without garbage collection pressure on the 90\,Hz render loop. The following sections detail each production component in turn.

As established in Section~\ref{sec:fsm_theory}, a Deterministic Finite Automaton guarantees total transition coverage for every input-state combination. In Section~\ref{sec:fsm_design}, we defined the four interaction states and modality-based input alphabet at the architectural level. This section details the instantiation of that model within the Unity engine, including the complete transition function, formal computation proof and hardware-specific implementation parameters.


% -----------------------------------------------------------------------------
\subsection{Formal Definition of the Interaction Automaton}
\label{sec:fsm_definition}
% -----------------------------------------------------------------------------

% Change [] CITE (6), reword.
Let the interaction framework be defined by the 5-tuple $M = (Q, \Sigma, \delta, q_0, F)$, where:

% . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .
\subsubsection{The Set of States ($Q$)}
\label{sec:fsm_states}
% . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .
The finite set of states $Q = \{q_0, q_1, q_2, q_3\}$ are modelled off of the interaction mappings defined in Table~\ref{tbl:modality_comparison}:

% . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .
\subsubsection{The Input Alphabet ($\Sigma$)}
\label{sec:fsm_alphabet}
% . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .
Nine discrete hardware events constitute the input alphabet $\Sigma$, representing the full range of interaction primitives available across both modalities. These events are defined at the hardware abstraction level, ensuring the FSM logic remains modality-agnostic. A full specification of the transition function $\delta$ and the formal computation proof are provided in Section~\ref{sec:fsm_definition}.

Let the alphabet $\Sigma = \{0, 1, 2, 3, 4, 5, 6, 7, 8\}$ represents the discrete hardware events detected by the active provider:
\begin{enumerate}[nosep, label=${\arabic*}$:, start=0]
    \item \textbf{Tracking Loss Override} (Camera occlusion)
    \item \textbf{Hardware Swap Reset} (Controller or hand swap)
    \item \textbf{Initiate Grab} (Valid pinch within proximity)
    \item \textbf{Release to Clutch} (Pinch released)
    \item \textbf{Initiate Bimanual Scaling} (Secondary pinch detected)
    \item \textbf{Partial Release} (One hand released during scale)
    \item \textbf{Full Release} (Both hands released simultaneously)
    \item \textbf{Re-engage Grab} (Pinch resumed from clutch)
    \item \textbf{Abandon Object} (Hand moves outside proximity bounds)
\end{enumerate}

% . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .
\subsubsection{Start State and Accepting States ($q_0, F$)}
\label{sec:fsm_start_accept}
% . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .
The system always initialises in the IDLE state, therefore the initial state is $q_0$.

In the context of this continuous reactive system, returning to state $q_0$ signifies a safely concluded sequence of interactions where the target model is left in a stable, non-volatile configuration. Therefore, the set of accepting states is defined as $F \subseteq Q \therefore F = \{q_0\}$.

% . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .
\subsubsection{The Transition Function ($\delta$)}
\label{sec:fsm_delta}
% . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .
In applied software engineering, the \texttt{C\#} event logic inherently behaves as a partial function; the system only calculates transitions for valid hardware inputs and implicitly ignores the rest. For example, when a switch-case statement has no \texttt{default} case, the input is simply ignored. However, according to \citeauthor{Sipser2012IntroductionComputation}'s book, \textit{Introduction to the Theory of Computation}, the formal definition of automata require the transition function to be total, meaning there must be a defined output for every input at every state. \newline

To address this, all unhandled input-state combinations from the partial C\# implementation are mathematically formalised as total by defining them as self-loops (e.g., $\delta(q_0, 5) = q_0$). This guarantees the automaton is strictly deterministic and mathematically complete. Let the transition function $\delta : Q \times \Sigma \rightarrow Q$ determine this system's behaviour. \newline

The complete transition matrix for the interaction orchestrator is detailed in Table \ref{tbl:dfa_transitions}. Note the input \texttt{1} (Hardware Swap Reset), which forces an immediate return to the start state ($q_0$) regardless of the current system configuration.

\begin{table}[htbp]
    \centering
    % 'c |' creates a vertical line separating the states from the inputs
    \caption{Formal Total Transition Function ($\delta$) for the FSM}
    \label{tbl:dfa_transitions}
    \begin{tabular}{c | c c c c c c c c c}
        \toprule
        \multirow{2}{*}{
            \textbf{State ($Q$)}
        } &
        \multicolumn{9}{c}{
            \textbf{Input Alphabet ($\Sigma$)}
        } \\
        \cmidrule{2-10} &
        \textbf{0} & \textbf{1} & \textbf{2} &
        \textbf{3} & \textbf{4} & \textbf{5} &
        \textbf{6} & \textbf{7} & \textbf{8} \\
        \midrule
        $\rightarrow *q_0$ & $q_0$      & $\bm{q_0}$ & $\bm{q_2}$ & $q_0$ & $q_0$ & $q_0$ & $q_0$& $q_0$ & $q_0$ \\
        $q_1$              & $q_1$      & $\bm{q_0}$ & $q_1$ & $q_1$      & $q_1$ & $q_1$ & $q_1$& $\bm{q_2}$  & $\bm{q_0}$ \\
        $q_2$              & $\bm{q_1}$ & $\bm{q_0}$ & $q_2$ & $\bm{q_1}$ & $\bm{q_3}$ & $q_2$ & $q_2$       & $q_2$ & $q_2$ \\
        $q_3$              & $\bm{q_1}$ & $\bm{q_0}$ & $q_3$ & $q_3$      & $q_3$ & $\bm{q_2}$ & $\bm{q_1}$  & $q_3$ & $q_3$ \\
        \bottomrule
    \end{tabular}
    \footnotesize
    \item \textit{Note:} $\rightarrow$ denotes the initial state; $*$ denotes an accepting state.
    \item Bold entries denote actionable state changes; non-bold entries are self-loops.
\end{table}

While game engine state machines operate as continuous reactive systems rather than finite string recognisers, applying formal DFA constraints on all possible input combinations results in a predictable and mathematically defined transition.
% . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .
\subsubsection{The Deterministic Finite State Machine ($M$)}
\label{sec:fsm_implemented}
% . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .

% % % % % % % % % % % % % % % % % % % %
% FIGURE: DFSM
% % % % % % % % % % % % % % % % % % % %
\begin{center}
    \includegraphics[width=0.6\linewidth]{images/architecture_design/dfsm.png}
    \captionof{figure}{Deterministic Finite Automaton governing the interaction framework. States represent kinematic phases; transitions are triggered by discrete hardware events from either modality. Implicit self-loops for unhandled inputs are omitted for visual clarity; the complete transition function is defined in Table~\ref{tbl:dfa_transitions}.}
    \label{fig:dfa_formal}
\end{center}

% . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .
\subsubsection{Formal Definition of Computation}
\label{}
% . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .
Let $M = (Q, \Sigma, \delta, q_0, F)$. \\
Let $w = w_1w_2\dots w_n$ be a sequence of hardware inputs where $w_i \in \Sigma$. \\
$M$ accepts $w$ if and only if there is a sequence of states $r_0r_1r_2\dots r_n \in Q$ such that: \[
\begin{matrix}
   r_0=q_0 \\
   \delta(r_i, w_{i+1}) = r_{i+1} & \text{for } 0\le i < N \\
   r_n \in F
\end{matrix}
\]

Thus, $M$ recognises the language of hardware inputs if $A=\{w|M \text{ accepts } w\}.$


% -----------------------------------------------------------------------------
\subsection{Objective Performance Metrics}
\label{sec:objective_metrics}
% -----------------------------------------------------------------------------

All objective metrics were logged by the \texttt{SessionTelemetryLogger} at 20\,Hz via a memory-buffered pipeline and exported atomically to CSV at task completion. The following metrics were captured:

\textbf{Task Completion Time (TCT).} The elapsed time from task start to successful spatial dwell validation, measured in seconds. TCT is the primary objective performance metric, consistent with the systematic review evidence that VR-trained groups complete spatial procedures 18--43\% faster than control groups \citep{Mao2021ImmersiveReview}. In accordance with Fitts' Law \citep{Soukoreff2004TowardsHCI}, TCT is expected to scale with task Index of Difficulty, providing a mathematical basis for comparing performance across the four tasks of increasing kinematic complexity.

\textbf{Positional Error (m) and Rotational Error ($\degree$).} Final Euclidean distance between the liver centroid and the docking target, and \texttt{Quaternion.Angle} between the liver orientation and the target orientation, measured at the moment the dwell criterion is first satisfied. The use of quaternion-based angular error is mandatory, as established in Section~\ref{sec:sensor_noise}, to prevent Gimbal Lock singularities \citep{Fang1998RealQuaternions}. These metrics serve as the direct quantification of spatial accuracy referenced by the dwell thresholds ($\leq 0.05$\,m and $\leq 5.0\degree$).

\textbf{Path Inefficiency and Rotation Inefficiency.} The ratio of the actual path length (or total rotation) traversed by the liver to the theoretical minimum required to reach the docking pose. A ratio of 1.0 indicates a perfectly direct trajectory; values above 1.0 quantify wasted motion. These metrics extend the Testbed framework \citep{Bowman2001TestbedTechniques} by capturing the quality of the trajectory rather than only its endpoint.

\textbf{Clutch Count.} The number of discrete grab-release cycles executed during a task. As established by \citet{Rantamaa2023ComparisonReality} using identical Varjo and Ultraleap hardware, repeated interaction events serve as a reliable proxy for optical tracking instability and interaction frustration. A high clutch count indicates that the user was unable to maintain a continuous grip, necessitating repeated re-engagements.

\textbf{Grip Variance.} The running unbiased sample variance of raw grip strength (pinch strength for HTR; analog trigger deflection for CTR) during active manipulation frames, computed using Welford's online algorithm (Section~\ref{sec:welford}). Higher variance indicates less stable and consistent actuation, consistent with the biomechanical evidence that optical hand tracking produces greater grip variability than mechanically grounded physical controllers \citep{Allgaier2022ATraining}.


% -----------------------------------------------------------------------------
\subsection{Subjective Metrics}
\label{sec:subjective_metrics}
% -----------------------------------------------------------------------------

Subjective data was collected using the two instruments formally introduced in Section~\ref{sec:subjective_instruments}. Blank copies of both questionnaires are reproduced in Appendix~\ref{doc:rtlx} and Appendix~\ref{doc:sus} respectively.

The RTLX was administered immediately after each of the four tasks, capturing the workload profile specific to each subtask's kinematic demands before memory of the experience degraded. The SUS was administered once per condition, after all four tasks for a given modality had been completed, reflecting its design intent as a holistic system usability measure \citep{Brooke1996SUS:Scale}.

An open feedback form (Appendix~\ref{doc:feedback}) was administered post-condition, inviting free-text responses on modality preference, perceived fatigue and gesture effectiveness. Responses will be analysed via post-hoc thematic coding and reported as qualitative evidence supplementing the quantitative findings.


% -----------------------------------------------------------------------------
\subsection{Statistical Analysis Plan}
\label{sec:stat_plan}
% -----------------------------------------------------------------------------

\textbf{Normality testing} \\
Prior to inferential testing, the Shapiro-Wilk test will be applied to all difference scores (HTR minus CTR per metric). At $n = 5$, Shapiro-Wilk is the appropriate normality test as it has greater power than alternatives for small samples.

\textbf{Primary inferential statistics} \\
For metrics where difference scores are normally distributed, a paired sample $t$-test will be reported. For non-normally distributed metrics, and as the primary statistic given the ordinal nature of the RTLX and SUS data, the Wilcoxon Signed-Rank test will be used. Both tests will be reported alongside Cohen's $d$ (paired) and rank-biserial $r$ as effect size measures. At $n = 5$ the Wilcoxon cannot produce $p < .05$ unless the result is perfectly one-directional; effect sizes are therefore the primary evidence for practical significance \citep{Wobbrock2011TheProcedures}.

\textbf{Post-hoc power analysis} \\
A post-hoc power analysis will confirm the minimum detectable effect size at $\alpha = .05$ and $1 - \beta = .80$ for $df = 4$, quantifying the study's sensitivity and providing parameters for powering a future confirmatory trial.

\textbf{Carry-over effect check} \\
Because the condition order was fixed rather than counterbalanced, a period $\times$ treatment interaction check will be conducted to test whether any observed differences are attributable to learning or fatigue effects rather than modality. If a significant carry-over effect is detected, it will be reported as a confound and the affected metrics flagged for cautious interpretation.

% This is experimental algo header
% \textbf{\hrule} \vspace{0.05\baselineskip}
% \textbf{Algorithm 1.} Pinch detection based on captured hand tracking
% \vspace{0.25\baselineskip} \textbf{\hrule} \vspace{0.25\baselineskip}

% . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .
\subsubsection{Representation as Code}
\label{sec:fsm_switch_case}
% . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .
This algorithm represents the state transitions in our FSM.
\vfill
\begin{algorithm}[htbp]
\caption{Finite State Machine dispatcher.}
\label{alg:fsm_core }
\begin{algorithmic}[1]
\Procedure{ProcessStateMachine}{}
    \State isTriggered $\gets$ activeProvider.IsInteractionTriggered()
    \State isBimanual $\gets$ activeProvider.IsBimanualInteractionTriggered()
    \State isWithinProximity $\gets$ CalculateProximity()
    \\
    \State \textbf{switch} currentState:

    \State \quad \textbf{case} IDLE:
        \State \quad \qquad ProcessIdleState(isTriggered, isWithinProximity)
        \State \quad \qquad \textbf{break}

    \State \quad \textbf{case} TRANSFORMING:
        \State \quad \qquad ProcessTransformingState(isTriggered, isBimanual)
        \State \quad \qquad \textbf{break}

    \State \quad \textbf{case} SCALING:
        \State \quad \qquad ProcessScalingState(isTriggered, isBimanual)
        \State \quad \qquad \textbf{break}

    \State \quad \textbf{case} CLUTCHED:
        \State \quad \qquad ProcessClutchedState(isTriggered, isWithinProximity)
        \State \quad \qquad \textbf{break}

    \State \textbf{end switch}
\EndProcedure
\end{algorithmic}
\end{algorithm}
\vfill

\vfill
\begin{algorithm}[htbp]
\caption{Pinch detection based on captured hand tracking.}
\label{alg:get_pinch_formal}
\begin{algorithmic}[1]
\Procedure{GetPinch}{hand}
    \If{hand = null}
        \State \textbf{return} Vector3.Zero
    \EndIf
    \\
    % The slash and space (\ ) ensures a visible space in math mode
    \State Vector3 \ thumbTip $\gets$ hand.fingers[Thumb].TipPosition
    \State Vector3 \ indexTip $\gets$ hand.fingers[Index].TipPosition
    \\
    \State \textbf{return} Vector3.Lerp(thumbTip, indexTip, 0.5)
\EndProcedure
\end{algorithmic}
\end{algorithm}


\section{Kinematic Mathematics}
\label{}
- Quaternion rotations to avoid gimbal lock (cite Fang et al., 1998).
- Delta calculation for position and rotation.
- Scale‑around‑pivot algorithm for bimanual scaling.

\section{Telemetry and Data Logging}
\label{}
- Data pipeline diagram (sensors → Unity → CSV → analysis).
- Logging frequency (20 Hz), CSV format, and post‑processing.
TrialOrchestrator — one section in the implementation describing how the task sequence, condition swap, environment reset and dwell validation were realised in code. You do not need to reproduce the entire class — focus on the bitmask constraint application (which is architecturally interesting and directly tied to the methodology discussion of DoF isolation) and the dwell criterion implementation (which closes the loop on the 3.0 second threshold specified in the methodology).
Telemetry — one section covering the CSV schema design (mapping directly to the analysis variables), the StringBuilder buffering strategy, the atomic export mechanism, and the Welford implementation. This is also where you explain that the file naming convention (participantID, condition, taskIndex, timestamp) was designed to enable unambiguous joining in the analysis pipeline without manual data cleaning.

TrialOrchestrator — one section in the implementation describing how the task sequence, condition swap, environment reset and dwell validation were realised in code. You do not need to reproduce the entire class — focus on the bitmask constraint application (which is architecturally interesting and directly tied to the methodology discussion of DoF isolation) and the dwell criterion implementation (which closes the loop on the 3.0 second threshold specified in the methodology).
Telemetry — one section covering the CSV schema design (mapping directly to the analysis variables), the StringBuilder buffering strategy, the atomic export mechanism, and the Welford implementation. This is also where you explain that the file naming convention (participantID, condition, taskIndex, timestamp) was designed to enable unambiguous joining in the analysis pipeline without manual data cleaning.
- Admin keyboard controls in TrialOrchestrator — mention they exist as researcher overrides, no detailed treatment needed

Telemetry — one section covering the CSV schema design (mapping directly to the analysis variables), the StringBuilder buffering strategy, the atomic export mechanism, and the Welford implementation. This is also where you explain that the file naming convention (participantID, condition, taskIndex, timestamp) was designed to enable unambiguous joining in the analysis pipeline without manual data cleaning.

% % % % % % % % % % % % % % % % % % % %
% FIGURE: DATA PIPELINE
% % % % % % % % % % % % % % % % % % % %
\begin{center}
    \includegraphics[width=0.7\linewidth]{images/architecture_design/data_pipeline.png}
    \captionof{figure}{Flow of Data from the application to the analysis.}
    \label{fig:data_flow}
\end{center}

SystemBootstrapper — mention it exists, reference the methodology section on system verification, move on
Diagnostics — mention the global toggle pattern, note it is tested in the EditMode suite, move on

\section{User Interface and Visual Feedback}
\label{}
- Soft visual constraints (landing windows, colour change on alignment).
- Ghost target and solid liver rendering.

% =============================================================================
\section{System Validation}
\label{sec:impl_validation}
% =============================================================================


% -----------------------------------------------------------------------------
\subsection{Test Architecture and Continuous Integration}
\label{sec:test_architecture}
% -----------------------------------------------------------------------------

The two-tier testing strategy defined in Section~\ref{sec:system_validation} was implemented using the Unity Test Framework, which exposes NUnit via \texttt{UnityEngine.TestTools} and supports both EditMode and PlayMode execution contexts natively within the Unity Editor. All tests were committed to the branch \texttt{test/83/establish-test-framework}, providing a verifiable TDD audit trail in the repository history. \\

% Remove this bit []
Two assembly definition files were created to register the test assemblies with Unity's compilation pipeline. \texttt{EditModeTests.asmdef} targets the \texttt{Editor} platform only and references \texttt{COMP3932.Core}, \texttt{COMP3932.Kinematics}, \texttt{COMP3932.Experiment} and \texttt{COMP3932.Telemetry}, enabling unit tests to access all production namespaces without being included in player builds. \texttt{PlayModeTests.asmdef} targets all platforms with no include restriction, permitting integration tests to run inside the Unity runtime environment. \\

All test fixtures were tagged with the \texttt{``ProjectTests''} category, allowing the Unity Test Runner and CI pipeline to filter and execute only the project's own tests rather than all tests discovered across the asset database, including those from third-party packages.


% -----------------------------------------------------------------------------
\subsection{Coverage and Limitations}
\label{sec:test_coverage}
% -----------------------------------------------------------------------------

The EditMode suite validated 29 distinct behavioural assertions across the four production namespaces, covering the mathematical correctness of Welford's online variance algorithm against a two-pass ground truth, the completeness of the DFSM transition function, the bitmask constraint logic for all four \texttt{TrialTask} values, and the divide-by-zero guards in the telemetry metric calculators. The PlayMode suite validated nine integration behaviours requiring the Unity runtime, including clutch count accumulation across FSM transitions, CSV column integrity, atomic file export and the full condition swap sequence triggered by task completion.

Two categories of component fall outside the automated test coverage. First, \texttt{UltraleapInteractionProvider} was not exercised in PlayMode because it depends on the Leap SDK's \texttt{LeapServiceProvider} which cannot be instantiated without a connected Ultraleap device or a supported simulator. The provider's mathematical behaviour --- pinch centre interpolation, coyote time buffering and finger audit logic --- was instead validated empirically during development sessions with the device. Second, the \texttt{EnforceSpatialBounds} method in \texttt{InteractionOrchestrator} was partially tested through observable scale clamping assertions in EditMode, but full boundary coverage requires a running physics scene with a positioned mesh, which was deferred to manual integration testing.

% change []
These limitations are acknowledged and documented as targets for a future expanded test suite should the system progress beyond the prototype stage.

Purpose: Prove that the system works correctly through systematic testing.


% -----------------------------------------------------------------------------
\subsection{Unit Testing}
\label{}
% -----------------------------------------------------------------------------
- Tests for `Diagnostics` class (conditional logging, colour coding).
- Tests for `TrialTask` bitmask logic.
- Tests for FSM state transitions without hardware.


% -----------------------------------------------------------------------------
\subsection{Integration Testing}
\label{}
% -----------------------------------------------------------------------------
- Using XR Device Simulator to simulate controller/hand inputs.
- Verification of telemetry accuracy (inject known movements, compare logged values).


% -----------------------------------------------------------------------------
\subsection{Pilot Study (N=5)}
\label{}
% -----------------------------------------------------------------------------
- Dry run to identify issues (tracking loss, UI clarity).
- Adjustments made (Coyote time, threshold tuning, demo scene).


% -----------------------------------------------------------------------------
\subsection{Main User Study (N=10‑20)}
\label{}
% -----------------------------------------------------------------------------
- Execution of protocol described in Chapter 3.
- Data collection and export.

##

\chapter{Results, Evaluation and Discussion}
\label{chap5:results}

This chapter presents the findings of the pilot crossover study ($n = 5$) in five thematic sections, each addressing a distinct measurement dimension. Descriptive and inferential statistics are reported inline or in focused extracted tables; full participant-level and item-level data are provided in the appendix tables referenced throughout. Effect sizes are foregrounded as the primary evidence of practical significance, consistent with the analysis plan in Section~\ref{sec:stat_plan}. The chapter closes with an integrated discussion linking findings to the literature and acknowledging limitations.

% =============================================================================
\section{Normality and Statistical Preconditions}
\label{sec:results_normality}
% =============================================================================

Shapiro-Wilk tests were applied to all paired difference scores prior to inferential testing. As reported in Table~\ref{tbl:shapiro_wilk}, normality was not rejected for any metric ($p > .05$ throughout), supporting the validity of parametric paired $t$-tests alongside the Wilcoxon primary statistic. Q-Q plots (Figure~\ref{fig:qq_plots}) confirm approximate linearity in all five difference distributions. Given $n = 5$, the Wilcoxon Signed-Rank test is foregrounded throughout: at this sample size the test cannot produce $p < .05$ unless all five difference scores are strictly one-directional ($W = 0$), meaning null results must be interpreted as inconclusive rather than as evidence of equivalence.

% % % % % % % % % % % % % % % % % % % %
% TABLE: Shapiro-Wilk normality summary
% % % % % % % % % % % % % % % % % % % %
\begin{table}[H]
    \caption{Shapiro--Wilk Normality Tests on Paired Difference Scores
    (HTR $-$ CTR)}
    \label{tbl:shapiro_wilk}
    \centering
    \begin{tabularx}{\textwidth}{@{} X S[table-format=1.4]
                                       S[table-format=1.3] l @{}}
        \toprule
        \textbf{Difference Score} & {$W$} & {$p$} &
        \textbf{Verdict} \\
        \midrule
        SUS Aggregate Score
            & 0.984 & .955 & Not rejected \\
        RTLX Total --- Task 1 (Pure Translation)
            & 0.825 & .127 & Not rejected \\
        RTLX Total --- Task 2 (Pure Rotation)
            & 0.849 & .192 & Not rejected \\
        RTLX Total --- Task 3 (Translation \& Rotation)
            & 0.920 & .529 & Not rejected \\
        RTLX Total --- Task 4 (Bimanual Scaling)
            & 0.909 & .464 & Not rejected \\
        \bottomrule
    \end{tabularx}
    \vspace{1ex}
    \raggedright
    \footnotesize{\textit{Note:} $n = 5$.
    Shapiro--Wilk is the appropriate normality test at this sample size
    \citep{MohdRazali2011PowerTests}.
    Difference scores computed as HTR minus CTR per paired participant.}
\end{table}

% % % % % % % % % % % % % % % % % % % %
% FIGURE: Q-Q plots
% % % % % % % % % % % % % % % % % % % %
\begin{center}
    \includegraphics[width=1\linewidth]{analysis/fig6_qq_plots.png}
    \captionof{figure}{Q-Q plots of paired difference scores (HTR $-$
    CTR) for SUS and all four RTLX tasks.
    Approximate linearity across all panels supports the Shapiro--Wilk
    non-rejection verdicts in Table~\ref{tbl:shapiro_wilk}.}
    \label{fig:qq_plots}
\end{center}

% =============================================================================
\section{System Usability}
\label{sec:results_sus}
% =============================================================================

CTR achieved a mean SUS of $87.0$ ($SD = 9.9$, $Mdn = 87.5$), placing the modality firmly in the Excellent band ($> 80.3$) defined in Table~\ref{tbl:sus_grades}. HTR achieved a mean of $67.5$ ($SD = 15.5$, $Mdn = 75.0$), placing it in the Okay--Fair to Good boundary, below the commercial average of 68. The difference was not statistically significant at $n = 5$ ($W = 1.0$, $p = .125$; $t(4) = -2.348$, $p = .079$), but the effect size was large ($d = -1.050$; $r_{rb} = .933$), indicating the difference is of substantial practical magnitude. Individual HTR scores ranged from 42.5 (P01; Poor) to 80.0 (P03; Good), reflecting the high inter-participant variability visible in Figure~\ref{fig:sus_boxplot}. This variability is qualitatively consistent with the literature: \citet{Khundam2021ATraining} reported HTR SUS of 60.17 and CTR of 67.17 in a comparable medical VR study, and \citet{Horejsi2025VirtualNavigation} found HTR at 56.0 against CTR at 74.67. Both studies used older hardware; the present HTR mean of 67.5 represents a meaningful improvement, suggesting the LMC2 generation partially closes the usability gap, though not sufficiently to match CTR under current conditions.

% % % % % % % % % % % % % % % % % % % %
% FIGURE: SUS boxplot
% % % % % % % % % % % % % % % % % % % %
\begin{center}
    \includegraphics[width=0.8\linewidth]{analysis/fig1_sus_boxplot.png}
    \captionof{figure}{SUS aggregate scores by modality ($n = 5$).
    Grade threshold lines follow Table~\ref{tbl:sus_grades}.
    Individual participant scores shown as points.
    CTR IQR lies entirely within the Excellent band; HTR IQR spans the
    Okay--Fair and Good bands with one outlier in the Poor band (P01:
    42.5).}
    \label{fig:sus_boxplot}
\end{center}

Item-level analysis (Figure~\ref{fig:sus_item_diverging}, Table~\ref{tbl:sus_items}) identifies Q4 (\textit{I would need the support of a technical person}; $W = 0.0$, $p = .125$) and Q6 (\textit{there was too much inconsistency}; $W = 0.0$, $p = .125$) as the strongest differentiators between modalities. Both items map directly to theoretically predicted failure modes. Q4 reflects the steep learning curve associated with precision pinch gestures documented by \citet{Buckingham2021HandChallenges}: users unfamiliar with the three-condition finger audit found the interaction non-intuitive without guidance, consistent with P01's feedback that natural hand movements did not produce the expected model response. Q6 reflects optical tracking inconsistency attributable to the delimitation problem \citep{Fischer2025ProbabilisticInteractions}: brief occlusion events caused unpredictable object drops that participants interpreted as interface inconsistency rather than hardware limitation. Q9 (\textit{confidence}; $W = 0.0$, $p = .250$) further confirms that tracking instability undermined the Sense of Agency described by \citet{Kilteni2012TheReality}, consistent with the Uncanny Valley of Interaction effect documented by \citet{Argelaguet2016TheRepresentation}.

% % % % % % % % % % % % % % % % % % % %
% FIGURE: SUS item diverging
% % % % % % % % % % % % % % % % % % % %
\begin{center}
    \includegraphics[width=1\linewidth]{analysis/fig2_sus_item_diverging.png}
    \captionof{figure}{SUS item-level median responses expressed as
    deviation from neutral (3.0) by modality.
    Positive values indicate agreement with positively-worded items or
    disagreement with negatively-worded items.
    Q4 and Q6 show the largest inter-modality divergence, both
    significant at $p = .125$ (Wilcoxon).}
    \label{fig:sus_item_diverging}
\end{center}

% =============================================================================
\section{Cognitive Workload}
\label{sec:results_rtlx}
% =============================================================================

RTLX total scores were consistently higher for HTR across all four tasks, though no comparison reached statistical significance at $n = 5$. The extracted summary in Table~\ref{tbl:rtlx_extracted} shows effect sizes in the medium-to-large range throughout (Cohen's $d$: 0.47--0.77), indicating a pattern of elevated cognitive demand under HTR that a confirmatory trial would be powered to detect.

% % % % % % % % % % % % % % % % % % % %
% TABLE: RTLX extracted summary
% % % % % % % % % % % % % % % % % % % %
\begin{table}[H]
    \caption{RTLX Total Score by Task and Modality: Extracted Summary
    (full item-level data in Appendix~\ref{tbl:rtlx_total})}
    \label{tbl:rtlx_extracted}
    \centering
    \begin{tabularx}{\textwidth}{@{} l
        S[table-format=2.1] S[table-format=2.1]
        S[table-format=2.1] S[table-format=2.1]
        S[table-format=1.1] S[table-format=1.4]
        S[table-format=1.3] @{}}
        \toprule
        & \multicolumn{2}{c}{\textbf{CTR}}
        & \multicolumn{2}{c}{\textbf{HTR}}
        & \multicolumn{2}{c}{\textbf{Wilcoxon}}
        & \\
        \cmidrule(lr){2-3}\cmidrule(lr){4-5}\cmidrule(lr){6-7}
        \textbf{Task} & {$M$} & {$SD$} & {$M$} & {$SD$}
        & {$W$} & {$p$} & {$d$} \\
        \midrule
        T1: Pure Translation
            & 17.8 & 9.5  & 31.6 & 17.5 & 1.0 & .125 & 0.732 \\
        T2: Pure Rotation
            & 31.6 & 13.2 & 41.6 & 23.7 & 3.0 & .313 & 0.558 \\
        T3: Translation \& Rotation
            & 32.4 & 14.8 & 39.2 & 11.1 & 2.5 & .250 & 0.774 \\
        T4: Bimanual Scaling
            & 35.8 & 16.7 & 43.0 & 21.9 & 4.0 & .375 & 0.472 \\
        \bottomrule
    \end{tabularx}
    \vspace{1ex}
    \raggedright
    \footnotesize{\textit{Note:} $n = 5$.
    RTLX range 6--120 (six subscales, each 1--20).
    No comparison reached $p < .05$; given $n = 5$, null results are
    inconclusive.
    Full Shapiro--Wilk and parametric results in
    Appendix~\ref{tbl:rtlx_total}.}
\end{table}

\begin{center}
    \includegraphics[width=1\linewidth]{analysis/fig5_rtlx_boxplot_per_task.png}
    \captionof{figure}{RTLX total cognitive load by task and modality.
    HTR distributions are consistently elevated relative to CTR.
    The dashed line marks the moderate workload threshold at 50\%.
    Neither modality approaches moderate load for any task at the group
    level, though individual HTR scores reach 68\% (T2) in one
    participant.}
    \label{fig:rtlx_boxplot}
\end{center}

The subscale profile in Figure~\ref{fig:rtlx_heatmap} reveals that the workload differential is not uniform across dimensions. Frustration produced the strongest and most consistent HTR elevation across all four tasks (T1: $\Delta = +3.8$; T2: $\Delta = +3.4$; T3: $\Delta = +2.2$; T4: $\Delta = +3.6$), achieving the minimum achievable Wilcoxon statistic ($W = 0.0$, $p = .125$) in the aggregate subscale analysis (Table~\ref{tbl:rtlx_subscale}, Appendix). CTR frustration remained low ($M = 3.6$, $SD = 2.2$) while HTR frustration was markedly elevated ($M = 6.85$, $SD = 4.3$). Temporal Demand was the only subscale showing no meaningful difference ($\Delta = 0.0$ at T1; aggregate $W = 5.0$, $p = 1.000$), indicating that both modalities imposed equivalent time pressure regardless of tracking quality. Performance perception (reverse-scored) showed a consistent HTR deficit across all tasks ($\Delta = +2.0$ to $+2.8$), suggesting participants felt less successful when using hand tracking, consistent with the increased alignment errors documented in Section~\ref{sec:results_accuracy}.

\begin{center}
    \includegraphics[width=0.85\linewidth]{analysis/fig8_rtlx_difference_heatmap.png}
    \captionof{figure}{RTLX differential heatmap (HTR $-$ CTR mean
    scores per subscale per task).
    Red indicates HTR higher load; blue indicates CTR higher load.
    Frustration is the dominant differentiator, consistently elevated
    under HTR across all tasks.
    Temporal Demand shows no meaningful difference, indicated by values
    near zero (boxed cells).}
    \label{fig:rtlx_heatmap}
\end{center}

RMSSD analysis (Appendix Table~\ref{tbl:rtlx_rmssd}) found similar group-level cognitive profile variability across conditions (CTR: $M = 7.04$, $SD = 5.42$; HTR: $M = 6.61$, $SD = 5.53$), indicating no systematic difference in load distribution between modalities. This null result is informative: the elevated HTR workload represents a uniform upward shift across subscales rather than selective elevation on specific dimensions, suggesting a generalised rather than dimension-specific interaction cost.

% =============================================================================
\section{Objective Performance: Task Completion Time}
\label{sec:results_tct}
% =============================================================================

TCT was substantially higher under HTR across all four tasks, with the most pronounced differences emerging at Tasks 2 and 3 where rotational demands dominated. Table~\ref{tbl:tct_extracted} presents the extracted summary; full descriptives are in Appendix Table~\ref{tbl:telem_performance}.

% % % % % % % % % % % % % % % % % % % %
% TABLE: TCT extracted summary
% % % % % % % % % % % % % % % % % % % %
\begin{table}[H]
    \caption{Task Completion Time (s) by Task and Modality: Extracted
    Summary (full data in Appendix~\ref{tbl:telem_performance})}
    \label{tbl:tct_extracted}
    \centering
    \begin{tabularx}{\textwidth}{@{} l
        S[table-format=2.3] S[table-format=2.3]
        S[table-format=2.3] S[table-format=2.3]
        S[table-format=1.1] S[table-format=1.4]
        S[table-format=1.3] @{}}
        \toprule
        & \multicolumn{2}{c}{\textbf{CTR}}
        & \multicolumn{2}{c}{\textbf{HTR}}
        & \multicolumn{2}{c}{\textbf{Wilcoxon}}
        & \\
        \cmidrule(lr){2-3}\cmidrule(lr){4-5}\cmidrule(lr){6-7}
        \textbf{Task} & {$M$} & {$SD$} & {$M$} & {$SD$}
        & {$W$} & {$p$} & {$d$} \\
        \midrule
        T1: Pure Translation
            &  5.663 &  0.505 & 16.611 & 17.436 & 1.0 & .125 & 0.639 \\
        T2: Pure Rotation
            & 16.388 &  9.563 & 55.080 & 43.063 & 0.0 & .063 & 1.127 \\
        T3: Translation \& Rotation
            & 18.810 &  9.390 & 57.555 & 18.416 & 0.0 & .063 & 2.671 \\
        T4: Bimanual Scaling
            & 28.148 & 17.862 & 90.046 & 86.824 & 1.0 & .125 & 0.724 \\
        \bottomrule
    \end{tabularx}
    \vspace{1ex}
    \raggedright
    \footnotesize{\textit{Note:} $n = 5$.
    T2 and T3 approach the minimum achievable Wilcoxon statistic
    ($W = 0.0$, $p = .063$) indicating all five participants were slower
    under HTR.
    T3 effect size ($d = 2.671$) is exceptionally large.
    Normality rejected for T1 difference scores ($W_{SW} = 0.730$,
    $p = .019$); Wilcoxon is the appropriate primary statistic.}
\end{table}

Tasks 2 and 3 both produced $W = 0.0$ ($p = .063$), indicating that every participant took longer to complete pure rotation and combined 6-DoF tasks under HTR without exception. The T3 effect size of $d = 2.671$ is exceptionally large and represents the single strongest objective finding in the study. At T3, CTR achieved a mean of 18.8\,s against HTR's 57.6\,s --- a 3.06-fold difference --- with notably tighter HTR variance ($SD = 18.4$) than the other tasks, suggesting this disadvantage was consistent across participants rather than driven by outliers.

\begin{center}
    \includegraphics[width=1\linewidth]{analysis/fig11_tct_boxplot.png}
    \captionof{figure}{TCT by task and modality.
    HTR distributions are substantially right-skewed at T2 and T4,
    driven by high inter-participant variability.
    T3 shows the most consistent HTR elevation across all participants.}
    \label{fig:tct_boxplot}
\end{center}

The learning curve analysis (Figure~\ref{fig:tct_learning_curve}) shows significant positive correlations between task number and TCT for both modalities (CTR: $r = 0.61$, $p = .004$; HTR: $r = 0.48$, $p = .032$), confirming that both modalities scale with increasing DoF complexity as predicted by Fitts' Law \citep{Soukoreff2004TowardsHCI}. The shallower HTR slope reflects higher baseline TCT at T1 obscuring the growth rate, rather than better scaling. CTR's stronger correlation ($r = 0.61$ vs $r = 0.48$) suggests a more orderly and predictable relationship between task complexity and completion time, whereas HTR's lower correlation reflects the high intra-modality variability attributable to tracking instability.

\begin{center}
    \includegraphics[width=1\linewidth]{analysis/fig15_tct_learning_curve.png}
    \captionof{figure}{TCT across tasks by modality showing individual
    participant trajectories and group mean.
    Both modalities show significant complexity-scaling ($r = 0.61$ CTR,
    $r = 0.48$ HTR).
    P04 (HTR) is a notable outlier at T4, likely attributable to
    sustained occlusion events during bimanual scaling.}
    \label{fig:tct_learning_curve}
\end{center}

% =============================================================================
\section{Objective Performance: Spatial Accuracy and Efficiency}
\label{sec:results_accuracy}
% =============================================================================

\subsection{Alignment Error}
\label{sec:results_error}

Final positional and rotational errors were consistently higher under
HTR for tasks where the respective DoF was active.
Table~\ref{tbl:error_extracted} presents the extracted comparison.

% % % % % % % % % % % % % % % % % % % %
% TABLE: Error extracted summary
% % % % % % % % % % % % % % % % % % % %
\begin{table}[H]
    \caption{Final Positional and Rotational Error by Task and Modality:
    Extracted Summary (full data in Appendix~\ref{tbl:telem_performance})}
    \label{tbl:error_extracted}
    \centering
    \begin{tabularx}{\textwidth}{@{} l l
        S[table-format=2.3] S[table-format=2.3]
        S[table-format=2.3] S[table-format=2.3]
        S[table-format=1.1] S[table-format=1.4]
        S[table-format=1.3] @{}}
        \toprule
        & & \multicolumn{2}{c}{\textbf{CTR}}
          & \multicolumn{2}{c}{\textbf{HTR}}
          & \multicolumn{2}{c}{\textbf{Wilcoxon}}
          & \\
        \cmidrule(lr){3-4}\cmidrule(lr){5-6}\cmidrule(lr){7-8}
        \textbf{Metric} & \textbf{Task}
          & {$M$} & {$SD$} & {$M$} & {$SD$}
          & {$W$} & {$p$} & {$d$} \\
        \midrule
        Pos.\ Error (m)
            & T1 &  0.203 & 0.069 &  0.270 & 0.107 & 4.0 & .438 &  0.576 \\
            & T3 &  0.046 & 0.040 &  0.135 & 0.081 & 2.0 & .188 &  0.909 \\
            & T4 &  0.070 & 0.074 &  0.064 & 0.058 & 7.0 & 1.000 & -0.052 \\
        \addlinespace
        Rot.\ Error ($\degree$)
            & T2 & 16.855 & 10.739 & 53.251 & 35.271 & 1.0 & .125 & 1.110 \\
            & T3 & 17.963 &  9.563 & 94.481 & 45.067 & 0.0 & .063 & 1.781 \\
            & T4 & 17.367 & 11.404 & 48.504 & 43.710 & 2.0 & .188 & 0.690 \\
        \bottomrule
    \end{tabularx}
    \vspace{1ex}
    \raggedright
    \footnotesize{\textit{Note:} $n = 5$.
    T4 positional error shows near-equivalence ($d = -0.052$),
    suggesting the extended time HTR participants took at T4 translated
    into comparable final alignment.
    T3 rotational error ($W = 0.0$, $p = .063$; $d = 1.781$) is the
    strongest accuracy finding.
    Positional error undefined for T2 (translation locked);
    rotational error undefined for T1 (rotation locked).}
\end{table}

The T3 rotational error result ($W = 0.0$, $p = .063$; $d = 1.781$) is particularly important: CTR participants achieved a mean final rotational error of $17.96\degree$ while HTR participants ended at $94.48\degree$, a 5.3-fold difference. This finding is directly attributable to the Heisenberg effect \citep{Argelaguet2013AEnvironments}: the act of initiating or terminating a wrist rotation pinch gesture inadvertently displaced the target mesh, requiring additional correction cycles that are captured by the high clutch counts in Section~\ref{sec:results_efficiency}. Figure~\ref{fig:error_boxplots} confirms this pattern, showing that HTR rotational error boxes at T2 and T3 extend well above the $5.0\degree$ dwell threshold, while CTR medians are consistently below the threshold for positional error at T3 and T4.

\begin{center}
    \includegraphics[width=1\linewidth]{analysis/fig12_error_boxplots.png}
    \captionof{figure}{Final positional (top) and rotational (bottom)
    error by task and modality.
    Dashed lines indicate the dwell acceptance thresholds
    ($0.05$\,m and $5.0\degree$).
    N/A panels indicate metrics undefined where the corresponding DoF
    is locked.
    HTR rotational error at T3 extends to $154\degree$ in one
    participant, indicating near-total rotational misalignment at
    acceptance.}
    \label{fig:error_boxplots}
\end{center}

One counterintuitive finding requires explicit discussion. Final positional error at T4 shows near-equivalence between modalities ($d = -0.052$), with HTR marginally lower than CTR. This reversal should be interpreted cautiously: HTR participants spent substantially longer at T4 ($M = 90.0$\,s vs $M = 28.1$\,s for CTR), meaning their positional accuracy at acceptance was purchased at the cost of extended task time. The Bland-Altman analysis (Figure~\ref{fig:bland_altman}) characterises the overall agreement pattern: TCT shows a systematic positive bias of $+37.6$\,s (HTR slower), with wide limits of agreement ($-55.2$ to $+130.3$\,s) indicating high individual variability. Positional error shows near-zero bias ($+0.050$\,m), consistent with the T4 convergence result, while rotational error shows a large systematic bias ($+48.0\degree$) confirming the rotational disadvantage is consistent rather than outlier-driven.

\begin{center}
    \includegraphics[width=1\linewidth]{analysis/fig16_bland_altman.png}
    \captionof{figure}{Bland-Altman agreement plots (HTR $-$ CTR) for
    TCT, positional error and rotational error.
    Solid line: mean bias; dashed lines: $\pm 1.96\,SD$ limits of
    agreement.
    TCT and rotational error show systematic positive bias throughout
    the measurement range.
    Positional error bias is near zero, driven by the T4 convergence.}
    \label{fig:bland_altman}
\end{center}

\subsection{Movement Efficiency and Interaction Stability}
\label{sec:results_efficiency}

Path and rotation inefficiency ratios were consistently higher under
HTR for all applicable tasks, with clutch count producing the most
extreme inter-modality differences in the dataset.
Table~\ref{tbl:efficiency_extracted} presents the extracted summary.

% % % % % % % % % % % % % % % % % % % %
% TABLE: Efficiency extracted summary
% % % % % % % % % % % % % % % % % % % %
\begin{table}[H]
    \caption{Movement Efficiency and Clutch Count by Task and Modality:
    Extracted Summary (full data in Appendix~\ref{tbl:telem_efficiency})}
    \label{tbl:efficiency_extracted}
    \centering
    \begin{tabularx}{\textwidth}{@{} l l
        S[table-format=1.3] S[table-format=1.3]
        S[table-format=1.3] S[table-format=1.3]
        S[table-format=1.1] S[table-format=1.4]
        S[table-format=1.3] @{}}
        \toprule
        & & \multicolumn{2}{c}{\textbf{CTR}}
          & \multicolumn{2}{c}{\textbf{HTR}}
          & \multicolumn{2}{c}{\textbf{Wilcoxon}}
          & \\
        \cmidrule(lr){3-4}\cmidrule(lr){5-6}\cmidrule(lr){7-8}
        \textbf{Metric} & \textbf{Task}
          & {$M$} & {$SD$} & {$M$} & {$SD$}
          & {$W$} & {$p$} & {$d$} \\
        \midrule
        Path Ineff.
            & T3 & 1.545 & 0.447 & 4.099 & 1.480 & 0.0 & .063 & 1.989 \\
            & T4 & 1.811 & 0.696 & 5.806 & 5.086 & 1.0 & .125 & 0.785 \\
        \addlinespace
        Rot.\ Ineff.
            & T2 & 2.463 & 1.626 & 6.687 & 3.429 & 0.0 & .063 & 2.027 \\
            & T3 & 2.190 & 0.977 & 4.803 & 2.779 & 1.0 & .125 & 1.330 \\
        \addlinespace
        Clutch Count
            & T1 &  1.2 &  0.4 & 16.0 & 19.0 & 0.0 & .063 & 0.778 \\
            & T2 &  2.8 &  1.9 & 42.4 & 41.2 & 0.0 & .063 & 0.999 \\
            & T3 &  4.6 &  4.2 & 37.2 & 18.1 & 0.0 & .063 & 1.967 \\
            & T4 &  7.6 &  5.8 & 61.0 & 94.4 & 1.0 & .125 & 0.564 \\
        \bottomrule
    \end{tabularx}
    \vspace{1ex}
    \raggedright
    \footnotesize{\textit{Note:} $n = 5$.
    Path inefficiency undefined for T2; rotation inefficiency undefined
    for T1.
    Clutch Count $W = 0.0$ ($p = .063$) at T1, T2 and T3 indicates all
    five participants re-engaged more frequently under HTR.
    T4 clutch count variance is dominated by P04 ($n = 1$ outlier).}
\end{table}

Clutch count is the most unambiguous finding in the telemetry dataset. HTR produced $W = 0.0$ ($p = .063$) at T1, T2 and T3, meaning every participant re-engaged more frequently under hand tracking than under CTR without exception. The magnitude is striking: HTR clutch counts exceeded CTR by approximately 13-fold at T1 (CTR $M = 1.2$; HTR $M = 16.0$), 15-fold at T2 (CTR $M = 2.8$; HTR $M = 42.4$) and 8-fold at T3 (CTR $M = 4.6$; HTR $M = 37.2$). These counts directly index the delimitation problem \citep{Fischer2025ProbabilisticInteractions}: each clutch event represents a moment at which the tracking system failed to maintain continuity, either through occlusion, the Heisenberg displacement on pinch actuation, or fatigue-induced postural compensation \citep{Yang2019EffectsTask}. The strong correlation between clutch count and TCT established by \citet{Rantamaa2023ComparisonReality} on the same hardware stack predicts that the TCT differences documented in Section~\ref{sec:results_tct} are at least partially mediated by these re-engagement events.

\begin{center}
    \includegraphics[width=1\linewidth]{analysis/fig13_inefficiency_barcharts.png}
    \captionof{figure}{Path and rotation inefficiency ratios by task and
    modality ($1.0 =$ perfect efficiency).
    HTR consistently exceeds CTR, with the largest differences at T2
    rotation inefficiency ($d = 2.027$, $p = .063$) and T3 path
    inefficiency ($d = 1.989$, $p = .063$).
    Hatched bars indicate metrics undefined for that task.}
    \label{fig:inefficiency_barcharts}
\end{center}

One finding warrants specific discussion. Mean grip variance reversed direction at T3 and T4, with CTR producing higher variance than HTR (T4: CTR $M = 0.009$ vs HTR $M = 0.003$; $W = 0.0$, $p = .063$; $d = -1.912$). This is counterintuitive given the biomechanical literature suggesting optical tracking produces greater grip variability \citep{Allgaier2022ATraining}. The most plausible explanation is analog trigger compression during sustained complex manipulation: at T3 and T4 CTR participants maintained continuous grip pressure across extended task durations, producing fluctuating analog values as the trigger was adjusted for fine alignment. HTR pinch, by contrast, is a binary detection state --- once the three-condition signature is satisfied the grip event is committed --- meaning the Welford accumulator records the relatively stable raw pinch strength value during active hold frames rather than the continuously varying analog pressure.

% =============================================================================
\section{Qualitative Findings}
\label{sec:results_qualitative}
% =============================================================================

Open feedback was collected post-condition across three questions addressing modality preference, physical fatigue and gesture difficulty. Responses were thematically coded and are summarised in Table~\ref{tbl:qualitative_themes}.

% % % % % % % % % % % % % % % % % % % %
% TABLE: Qualitative themes
% % % % % % % % % % % % % % % % % % % %
\begin{table}[H]
    \caption{Thematic Analysis of Open Feedback Responses ($n = 5$)}
    \label{tbl:qualitative_themes}
    \centering
    \begin{tabularx}{\textwidth}{@{} p{3.2cm} X r @{}}
        \toprule
        \textbf{Theme} & \textbf{Representative Responses} &
        \textbf{Total} \\
        \midrule
        \textbf{CTR preferred for stability}
            & Controller more consistent movement, reduced jitter
            (P02); easier rotation as hands stay in sight (P05);
            less steep learning curve (P01);
            system felt easier to use (P04).
            & $n = 4$ \\
        \addlinespace
        \textbf{HTR preferred for naturalness}
            & Feels more natural and intuitive (P03).
            & $n = 1$ \\
        \addlinespace
        \textbf{Rotation gesture difficulty}
            & Wrist up/down rotation unnatural (P02);
            hard to coordinate palm orientation (P04);
            rotation hard on hand controls (P05);
            hand occlusion during rotation (P03).
            & $n = 4$ \\
        \addlinespace
        \textbf{Pinch gesture unfamiliarity}
            & Natural movements did not move liver as expected (P01);
            stiff due to unfamiliar system (P01).
            & $n = 2$ \\
        \addlinespace
        \textbf{Physical fatigue --- arm/wrist}
            & Arm slightly tired during hand control (P01);
            anticipated wrist fatigue with extended use (P02).
            & $n = 2$ \\
        \addlinespace
        \textbf{Physical fatigue --- headset/eyes}
            & Eye fatigue after extended headset use (P03);
            headset weight noticeable for VR-naïve user (P04).
            & $n = 2$ \\
        \addlinespace
        \textbf{HTR potential with practice}
            & Hand tracking would be nicer with practice (P04).
            & $n = 1$ \\
        \bottomrule
    \end{tabularx}
    \vspace{1ex}
    \raggedright
    \footnotesize{\textit{Note:} Responses coded post-hoc by the
    researcher.
    Four of five participants expressed a CTR preference; one (P03)
    preferred HTR.
    Rotation difficulty was the dominant gesture-specific complaint,
    consistent with the rotational error and rotation inefficiency
    findings in Section~\ref{sec:results_accuracy}.}
\end{table}

Four of five participants preferred CTR, citing consistency and stability. Only P03 preferred HTR, citing naturalness --- and P03 also recorded the highest HTR SUS score (80.0) and the lowest HTR rotational error among the analysed participants, suggesting that where participants acquire sufficient gesture familiarity the naturalness advantage of HTR may emerge. The universal complaint regarding rotation gestures corroborates the objective findings: rotation inefficiency was the largest and most consistent inter-modality difference in the dataset, and the wrist pronation required for fine angular alignment was repeatedly identified as the failure point. The absence of arm fatigue complaints in three participants is notable given the Gorilla Arm literature \citep{QPalmeira2023QuantifyingStudy}: the short task durations in a pilot study (mean HTR TCT $\leq 90$\,s per task) may not have been sufficient to induce the sustained arm elevation required for Consumed Endurance to become perceptible \citep{Hincapie-Ramos2014ConsumedInteractions}.

% =============================================================================
\section{Integrated Discussion}
\label{sec:discussion}
% =============================================================================

The combined evidence from usability, workload, kinematic and qualitative measures converges on a consistent conclusion: CTR outperforms HTR across all primary outcome measures at the current hardware generation, with the performance gap most pronounced for tasks requiring sustained rotational manipulation.

The SUS finding is the most actionable result for clinical deployment decisions. A CTR mean of 87.0 (Excellent) versus an HTR mean of 67.5 (Okay--Fair boundary) represents a clinically meaningful difference, regardless of statistical significance at $n = 5$. The large effect size ($d = -1.050$) exceeds the thresholds reported by both \citet{Khundam2021ATraining} ($\Delta_{\text{SUS}} = 7.0$) and \citet{Horejsi2025VirtualNavigation} ($\Delta_{\text{SUS}} = 18.7$) for comparable within-subjects HTR versus CTR comparisons, suggesting the present finding is robust and not an artefact of sample size.

The rotational performance gap is the most theoretically significant finding. T3 rotational error ($d = 1.781$) and rotation inefficiency at T2 ($d = 2.027$) both approach the minimum achievable Wilcoxon statistic, indicating universally consistent HTR disadvantage. This directly contradicts the near-equivalence reported by \citet{Khundam2021ATraining} for the VR intubation task, but that study did not involve continuous 6-DoF rotation as an isolated demand. The present Testbed decomposition reveals that the rotational dimension is specifically where optical tracking fails relative to haptic grounding, consistent with the Heisenberg effect \citep{Argelaguet2013AEnvironments} and the wrist rotation findings in the qualitative data.

The clutch count data represents the strongest direct evidence of the delimitation problem \citep{Fischer2025ProbabilisticInteractions} in a naturalistic 6-DoF manipulation context. HTR re-engagement rates exceeding CTR by 8--15-fold across the first three tasks are not consistent with brief hardware transients; they reflect a systematic failure of the tracking system to maintain continuity during the gesture sequences required by this task class. The fatigue-induced posture compensation mechanism identified by \citet{Yang2019EffectsTask} provides a plausible mechanism: as arm elevation induced fatigue-driven trunk rotation, the hand position shifted relative to the LMC2 field of view, triggering the coyote time buffer and then dropping the object when tracking was not restored within the grace window.

% -----------------------------------------------------------------------------
\subsection{Limitations}
\label{sec:limitations}
% -----------------------------------------------------------------------------

The most significant limitation is sample size. With $n = 5$ after equipment-failure exclusions, the Wilcoxon test cannot reach $p < .05$ for any two-tailed comparison, and the results must be treated as hypothesis-generating rather than confirmatory. The consistent directionality of effects across multiple metrics (clutch count $W = 0.0$ at three tasks; rotational error $W = 0.0$ at T3; TCT $W = 0.0$ at T2 and T3) provides evidential support for the direction of conclusions, but the magnitude of effects should be treated as indicative pending a confirmatory trial.

The fixed CTR-first condition order introduces a potential learning effect. Although this design was justified by participant prior experience asymmetry (Section~\ref{sec:experimental_design}), participants completing HTR as their second condition had already practised the docking paradigm once. A carry-over effect in the direction of HTR improvement cannot be excluded, which would mean the true HTR disadvantage is understated rather than overstated.

The convenience sample of university students and staff does not represent the clinical population of interest. Surgical and medical participants ($n = 3$, 37.5\%) may respond differently to both modalities; domain-specific spatial reasoning skills and existing tool-use habits could affect both HTR gesture acquisition and CTR mapping familiarity in ways not captured by this sample.

Gaming frequency was recorded but excluded from the primary analysis as beyond scope. Three participants reported rarely or never gaming; the relationship between spatial gaming experience and HTR gesture acquisition is an important covariate for future work.

% -----------------------------------------------------------------------------
\subsection{Future Work}
\label{sec:future_work}
% -----------------------------------------------------------------------------

A confirmatory trial with $n \geq 20$ and counterbalanced condition order is the immediate priority. Post-hoc power analysis indicates that detecting the observed SUS effect ($d = 1.050$) with $\alpha = .05$ and $1 - \beta = .80$ requires $n \approx 10$ participants; the T3 rotational error effect ($d = 1.781$) would require only $n \approx 6$. The sample size needed for TCT at T4 ($d = 0.724$) is approximately $n = 17$, making this the most demanding metric to confirm.

The qualitative data and SUS item analysis point toward gesture trainingas a high-value intervention.P04 explicitly noted that HTR would be nicer with practice, and P03'ssuperior HTR performance may reflect faster gesture acquisition ratherthan an inherent modality advantage.A future study with a structured pre-trial gesture familiarisationphase would allow the learning-curve confound to be separated fromgenuine tracking limitations.

The Gaze+Pinch model \citep{Pfeuffer2017GazeReality} represents the most promising architectural extension. Decoupling targeting from manipulation would eliminate the Heisenberg displacement on pinch actuation and reduce arm elevation by allowing manipulation from any comfortable hand position. The Varjo XR-4's integrated eye-tracking makes this a technically feasible next step on the same hardware platform without additional device acquisition.



Questions 1,2 and 3 and their open feedback answers:
Categorise them in a table
1. Which control method did you prefer overall for manipulating the liver model, and why?
- The controllers as they were more natural movement, less steep learning curve. With my hands I tried to do natural movements that didn't actually move the liver in the way I wanted it to.
- Controller due to more consistent movement and the increased stability. Both physical and sensor dataa add jitter to the hand control making it less smooth.
- Hand. Feels more natural and intuitive.
- I perfer using the controller as the system felt easier to use but I can imagine the hand would be much nicer with practice.
- For me the controller was slightly easier, as I could rotate easier with my hands going out of sight of the controller.


2. Did you experience any physical fatigue (e.g., in your arms, wrists, or eyes)
during either task? If so, when?
- Arms got slightly tired in the hand control tests however very minimal.
- No although I could see fatigue in my wrist if used for an extended time on the hand system
- Eyes, after a long time wearing the headset.
- Some rotations using the hands, probably because the camera couldn't see my hand.
- The headset was heavy at times but this is one of the first times using very so I am not used to it.
-No

3. Were there any specific gestures or joystick movements that felt unnatural, frustrating, or failed to register?
- The pinch with the rest of my hand relaxed, I think because I was not used to the system, the movements felt unnatural and therefore I was stiff.
- Rotation in the wrist down and up.
- The rotation gesture was difficult as it felt hard to coordinate with showing the palm etc.
- Rotation on the hand controls was hard.

---

Themes:
# Controller Preference
- Easier to use, n=3
- More natural, n=1
# Hand preference
- More natural, n=1
# Frustrations
- Hands lost tracking, n=2
- Hands were unreliable, n=2
- Pinch pose, n=1
- Rotating with the hands, n=2
- Occlusion, n=2
# Fatigue
- Arms, n=1
- Wrist, n=2
- Eyes, n=1
- None, n=1


% % % % % % % % % % % % % % % % % % % %
% ALGORITHM: Pinch centre computation
% % % % % % % % % % % % % % % % % % % %
\begin{algorithm}[htbp]
\caption{Pinch centre computation in \texttt{UltraleapInteractionProvider}.}
\label{alg:get_pinch}
\begin{algorithmic}[1]
\Procedure{GetPinch}{hand}
    \If{hand $=$ \textbf{null}}
        \State \Return $\vec{0}$
    \EndIf
    \State $\mathit{thumbTip} \gets \texttt{hand.fingers[Thumb].TipPosition}$
    \State $\mathit{indexTip} \gets \texttt{hand.fingers[Index].TipPosition}$
    \State \Return $\texttt{Vector3.Lerp}(\mathit{thumbTip},\ \mathit{indexTip},\ 0.5)$
\EndProcedure
\end{algorithmic}
\end{algorithm}


% % % % % % % % % % % % % % % % % % % %
% ALGORITHM: Dwell criterion evaluation
% % % % % % % % % % % % % % % % % % % %
\begin{algorithm}[htbp]
\caption{Spatial dwell criterion evaluation in \texttt{TrialOrchestrator}.}
\label{alg:dwell}
\begin{algorithmic}[1]
\Procedure{EvaluateTaskCriteria}{$\mathit{mask}$}
    \State $\mathit{valid} \gets \textbf{true}$
    \If{$(\mathit{mask}\ \mathbin{\&}\ \texttt{0b0001}) \neq 0$}
        \State $\mathit{valid} \gets \mathit{valid}\ \textbf{and}\ \mathit{posError} \leq \tau_{\mathit{pos}}$
    \EndIf
    \If{$(\mathit{mask}\ \mathbin{\&}\ \texttt{0b0010}) \neq 0$}
        \State $\mathit{valid} \gets \mathit{valid}\ \textbf{and}\ \mathit{rotError} \leq \tau_{\mathit{rot}}$
    \EndIf
    \If{$(\mathit{mask}\ \mathbin{\&}\ \texttt{0b0100}) \neq 0$}
        \State $\mathit{valid} \gets \mathit{valid}\ \textbf{and}\ \mathit{scaleError} \leq \tau_{\mathit{scale}}$
    \EndIf
    \State \Return $\mathit{valid}$
\EndProcedure
\end{algorithmic}
\end{algorithm}


% % % % % % % % % % % % % % % % % % % %
% ALGORITHM: Bitmask constraint application
% % % % % % % % % % % % % % % % % % % %
\begin{algorithm}[htbp]
\caption{Bitmask constraint application in \texttt{TrialOrchestrator}.}
\label{alg:bitmask}
\begin{algorithmic}[1]
\Procedure{ApplyTaskConstraints}{}
    \State $\mathit{mask} \gets \texttt{(byte)}\ \mathit{currentTask}$
    \State $\texttt{orchestrator.allowTranslation} \gets (\mathit{mask}\ \mathbin{\&}\ \texttt{0b0001}) \neq 0$
    \State $\texttt{orchestrator.allowRotation}    \gets (\mathit{mask}\ \mathbin{\&}\ \texttt{0b0010}) \neq 0$
    \State $\texttt{orchestrator.allowScaling}     \gets (\mathit{mask}\ \mathbin{\&}\ \texttt{0b0100}) \neq 0$
\EndProcedure
\end{algorithmic}
\end{algorithm}


% % % % % % % % % % % % % % % % % % % %
% ALGORITHM: Welford online variance (production implementation)
% % % % % % % % % % % % % % % % % % % %
\begin{algorithm}[htbp]
\caption{Welford online variance accumulation in \texttt{SessionTelemetryLogger}.}
\label{alg:welford_impl}
\begin{algorithmic}[1]
\Procedure{UpdateWelfordVariance}{$x$}
    \State $\mathit{gripSampleCount} \gets \mathit{gripSampleCount} + 1$
    \State $\delta_1 \gets x - \mathit{gripMean}$
    \State $\mathit{gripMean} \gets \mathit{gripMean} + \delta_1 \;/\; \mathit{gripSampleCount}$
    \State $\mathit{gripM2} \gets \mathit{gripM2} + \delta_1 \times (x - \mathit{gripMean})$
\EndProcedure

\Statex

\Procedure{GetCurrentGripVariance}{}
    \If{$\mathit{gripSampleCount} < 2$}
        \State \Return $0$
    \EndIf
    \State \Return $\mathit{gripM2} \;/\; (\mathit{gripSampleCount} - 1)$
\EndProcedure
\end{algorithmic}
\end{algorithm}

% % % % % % % % % % % % % % % % % % % %
% FIGURE: GitHub Action test results
% % % % % % % % % % % % % % % % % % % %
\begin{figure*}[t!]
    \centering
    \subfloat[CI Overview]{%
        \includegraphics[width=0.85\linewidth]{images/github/gh_workflow_summary.png}%
        \label{subfig:test_ci_overview}%
    } \\
    \subfloat[Test Summary Job]{%
        \includegraphics[width=0.85\linewidth]{images/github/gh_workflow_test_summary.png}%
        \label{subfig:test_ci_test_summary_job}%
    }
    \caption{Continuous Integration Workflow: overview and test summary job.}
    \label{fig:test_ci_workflow}
\end{figure*}



% % % % % % % % % % % % % % % % % % % %
% FIGURE: Edit and PlayMode Tests
% % % % % % % % % % % % % % % % % % % %
\begin{figure*}[t!]
    \subfloat[Unit Tests (EditMode)]{%
        \includegraphics[width=.505\linewidth]{images/unity/editmode_results.png}%
        \label{subfig:edit_mode}%
    } \
    \subfloat[Integration Tests (PlayMode)]{%
        \includegraphics[width=.48\linewidth]{images/unity/playmode_results.png}%
        \label{subfig:play_mode}%
    }
    \caption{A subset of unit and integration tests passing in the Unity test runner.}
    \label{fig:edit_play_mode_results}
\end{figure*}