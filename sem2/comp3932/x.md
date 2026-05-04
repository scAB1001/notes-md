## Appendix (Reusable Resources)

Place these in the Appendix and reference them from multiple chapters.

| Visual                                         | Format                                       | Location     | Justification                                                                                                      |
| ---------------------------------------------- | -------------------------------------------- | ------------ | ------------------------------------------------------------------------------------------------------------------ |
| **Labelled hand bones**                        | Figure (image with annotations)              | Appendix A.1 | Referenced in Chapter 2 (biomechanics), Chapter 3 (gesture mapping), and Chapter 4 (hand-tracking implementation). |
| **Leap Motion Controller 2 with FOV**          | Figure (product image + diagram)             | Appendix A.2 | Used in Chapter 2 (hardware limitations), Chapter 3 (apparatus), and Chapter 4 (sensor setup).                     |
| **Varjo XR-4 headset with FOV**                | Figure (product image + diagram)             | Appendix A.3 | Referenced in Chapter 2 (rendering technologies), Chapter 3 (hardware architecture), and Chapter 4 (VR setup).     |
| **Hand‑gesture examples (pinch, grab, point)** | Figure (series of photographs or 3D renders) | Appendix A.4 | Used in Chapter 2 (gesture taxonomy), Chapter 3 (interaction design), and Chapter 4 (gesture recognition).         |
| **Controller and hand schema (DoF matrix)**    | Table                                        | Appendix A.5 | Referenced in Chapter 2 (HCI taxonomy), Chapter 3 (task decomposition), and Chapter 5 (results).                   |
| **Taxonomy of 3D selection techniques**        | Figure (hierarchical tree diagram)           | Appendix A.6 | Central to Chapter 2 (literature review) and cited again in Chapter 5 (discussion).                                |
| **Proof‑of‑concept code snippets**             | Code listing                                 | Appendix A.7 | Used in Chapter 4 (implementation) and Chapter 5 (validation).                                                     |

TODO:
- [X] Labelled hand bones
- [X] Leap Motion Controller 2 with FOV
- [X] Proof‑of‑concept code snippet (Pinch)
- [X] Images of 3D liver model, real model and unity model
- [X] Images of unity four tasks
- [X] UML component diagram
- [X] Pseudo code template (plain and nice)
- [X] Table of GitHub labels
- [X] Image of Roadmap (2)
- [X] Images of Backlog (2)
- [X] Image of Kanban
- [X] Image of issue (2)
- [X] Table of Fields for views
- [X] Finite State Machine diagram
- [X] Proof: FSM
- [X] FSM Delta function table
- [X] Consent forms scanned and uploaded
- [X] SUS, RTLX and Open feedback forms added
- [x] Participant characterisation table
- [X]
- [X]
- [X]
- [ ] Varjo XR-4 headset with FOV
- [ ] Hand‑gesture examples (pinch, grab, point)
- [ ] Proof‑of‑concept code snippet (Threshold and proximity)
- [ ] Controller and hand schema table (DoF matrix)
- [ ] Taxonomy of 3D selection techniques (Tree hierarchy)
- [ ] Data pipeline diagram

- [ ] CONSORT flow diagram
- [ ] Task decomposition table

Participant Characteritics (n=8)
- Sex/Gender
- Age (Ranges?)
- Background
- Occupation (Surgical and Non-surgical) ?
- VR Experience (None, Some, Considerable, Very Experienced)
- Use of XR-4 before (Yes/No)
- Use of Varjo Controoller experience
- Hand-tracking experience
- Gaming Frequency
- Level of alertness
- Use of LMC2 before (Yes/No)
- Handedness

Mean age in years (SD, Min-Max)
P-value
3D, three-dimensional; AR, augmented reality.

---

## Chapter 2: Literature Review

| Visual                                      | Format                | Location                                        | Justification                                                                                                                         |
| ------------------------------------------- | --------------------- | ----------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------- |
| **Taxonomy of 3D selection techniques**     | Figure (tree diagram) | §2.1 (Core Interaction Metaphors)               | Illustrates Argelaguet & Andujar’s classification (virtual hand vs. virtual pointer). Placeholder only; full diagram in Appendix A.6. |
| **Hand bones labelled**                     | Figure                | §2.2 (Biomechanics, Fatigue)                    | Supports discussion of joint kinematics and muscle groups. Refer to Appendix A.1.                                                     |
| **Leap Motion Controller 2 FOV**            | Figure                | §2.3 (Hardware Limitations – Optical Occlusion) | Visualises the limited tracking volume. Refer to Appendix A.2.                                                                        |
| **Varjo XR-4 headset FOV**                  | Figure                | §2.4 (High‑Fidelity Medical Rendering)          | Shows the wide field of view. Refer to Appendix A.3.                                                                                  |
| **Gesture examples (pinch, grab, point)**   | Figure                | §2.5 (Natural User Interfaces)                  | Demonstrates the gestures discussed. Refer to Appendix A.4.                                                                           |
| **Controller vs. hand schema (DoF matrix)** | Table                 | §2.6 (Hardware Realities)                       | Compares available degrees of freedom. Refer to Appendix A.5.                                                                         |
| **Bland‑Altman plot (conceptual)**          | Figure                | §2.7 (Statistical Methods)                      | Illustrates how agreement between measurement methods will be assessed. Placeholder – actual plot in Chapter 5.                       |
| **Line graph of learning curve**            | Figure                | §2.7 (Cognitive Load)                           | Conceptual representation of performance improvement over time. Placeholder – actual data in Chapter 5.                               |

---

## Chapter 3: Methodology

| Visual                                      | Format | Location                     | Justification                                                                                                    |
| ------------------------------------------- | ------ | ---------------------------- | ---------------------------------------------------------------------------------------------------------------- |
| **UML component diagram**                   | Figure | §3.1 (Software Architecture) | Shows decoupling of `InteractionOrchestrator`, providers, and telemetry logger. Essential for explaining design. |
| **Finite State Machine diagram**            | Figure | §3.2 (Interaction Design)    | Visualises state transitions (IDLE → TRANSFORMING → SCALING → CLUTCHED). Core to the FSM explanation.            |
| **CONSORT flow diagram**                    | Figure | §3.3 (Experimental Design)   | Maps participant journey through enrolment, allocation, follow‑up, analysis. Required for pilot study reporting. |
| **Participant characterisation table**      | Table  | §3.4 (Participants)          | Summarises demographics, VR experience, handedness.                                                              |
| **Task decomposition table**                | Table  | §3.5 (Tasks)                 | Breaks down the four subtasks (pure translation, pure rotation, 6‑DoF, full scale) with required actions.        |
| **Hand‑gesture examples**                   | Figure | §3.2 (Gesture Mapping)       | Shows the pinch, grab, point gestures. Refer to Appendix A.4.                                                    |
| **Controller and hand schema (DoF matrix)** | Table  | §3.2 (Gesture Mapping)       | Summarises which actions map to which inputs. Refer to Appendix A.5.                                             |
| **Leap Motion Controller 2 FOV**            | Figure | §3.1 (Hardware Setup)        | Shows the tracking volume. Refer to Appendix A.2.                                                                |
| **Varjo XR-4 headset FOV**                  | Figure | §3.1 (Hardware Setup)        | Shows the headset’s field of view. Refer to Appendix A.3.                                                        |

---

## Chapter 4: Implementation and System Architecture

| Visual                             | Format       | Location                          | Justification                                                                                         |
| ---------------------------------- | ------------ | --------------------------------- | ----------------------------------------------------------------------------------------------------- |
| **UML component diagram**          | Figure       | §4.1 (System Overview)            | Repeated from Chapter 3 (or reference to it). Shows concrete implementation of abstract architecture. |
| **Finite State Machine diagram**   | Figure       | §4.2 (Gesture Recognition Engine) | Implementation‑level state machine with actual trigger conditions.                                    |
| **Proof‑of‑concept code snippets** | Code listing | §4.3 (Kinematic Mathematics)      | Show `Quaternion.Angle` usage, `Vector3.Distance` for inefficiency, etc. Refer to Appendix A.7.       |
| **Data pipeline diagram**          | Figure       | §4.4 (Telemetry Logging)          | Illustrates flow from sensors → Unity → CSV → analysis.                                               |
| **Photograph of 3D liver model**   | Figure       | §4.5 (Visual Feedback)            | Shows the actual patient‑derived liver model used in the simulation.                                  |
| **Hand bones labelled**            | Figure       | §4.2 (Gesture Recognition)        | Explains which anatomical landmarks are tracked. Refer to Appendix A.1.                               |
| **Leap Motion Controller 2 FOV**   | Figure       | §4.1 (Hardware Integration)       | Shows the sensor placement relative to hands. Refer to Appendix A.2.                                  |

---

## Chapter 5: Results, Evaluation and Discussion

| Visual                                                  | Format | Location                     | Justification                                                                 |
| ------------------------------------------------------- | ------ | ---------------------------- | ----------------------------------------------------------------------------- |
| **CONSORT flow diagram**                                | Figure | §5.1 (Participant Flow)      | Actual participant numbers (enrolled, excluded, completed).                   |
| **Participant characterisation table**                  | Table  | §5.1 (Demographics)          | Finalised demographic data.                                                   |
| **Box‑plots (TCT, positional error, rotational error)** | Figure | §5.2 (Objective Performance) | Compare controller vs. hand‑tracking distributions.                           |
| **Bar charts (inefficiency ratios, clutch count)**      | Figure | §5.2 (Objective Performance) | Show mean values with error bars.                                             |
| **Heatmap (clutch count across tasks & conditions)**    | Figure | §5.2 (Objective Performance) | Visualises interaction effects.                                               |
| **Line graphs (learning curve over trials)**            | Figure | §5.2 (Objective Performance) | Shows performance improvement over repeated tasks.                            |
| **Bar charts (SUS scores)**                             | Figure | §5.3 (Subjective Metrics)    | Compares controller vs. hand‑tracking usability.                              |
| **Bar charts (RTLX sub‑scale scores)**                  | Figure | §5.3 (Subjective Metrics)    | Shows mental, physical, temporal demand, etc.                                 |
| **Bland‑Altman plots**                                  | Figure | §5.4 (Agreement Analysis)    | Assesses agreement between objective error and subjective performance rating. |
| **Controller and hand schema (DoF matrix)**             | Table  | §5.5 (Discussion)            | Refer to Appendix A.5 to explain why certain actions performed differently.   |
| **Taxonomy of techniques**                              | Figure | §5.5 (Discussion)            | Refer to Appendix A.6 to categorise observed user behaviours.                 |
| **Hand‑gesture examples**                               | Figure | §5.5 (Discussion)            | Refer to Appendix A.4 to illustrate successful/failed gestures.               |

---

## Summary Checklist

| Visual Type                                  | Chapter 2      | Chapter 3 | Chapter 4 | Chapter 5 | Appendix |
| -------------------------------------------- | -------------- | --------- | --------- | --------- | -------- |
| UML component diagram                        | –              | ✓         | ✓         | –         | –        |
| Finite State Machine diagram                 | –              | ✓         | ✓         | –         | –        |
| CONSORT flow diagram                         | –              | ✓         | –         | ✓         | –        |
| Participant characterisation table           | –              | ✓         | –         | ✓         | –        |
| Task decomposition table                     | –              | ✓         | –         | –         | –        |
| Photograph of 3D liver model                 | –              | –         | ✓         | –         | –        |
| Leap Motion 2 FOV                            | ✓              | ✓         | ✓         | –         | ✓        |
| Varjo XR-4 FOV                               | ✓              | ✓         | ✓         | –         | ✓        |
| Hand‑gesture examples                        | ✓              | ✓         | –         | ✓         | ✓        |
| Hand bones labelled                          | ✓              | –         | ✓         | –         | ✓        |
| Controller & hand schema                     | ✓              | ✓         | –         | ✓         | ✓        |
| Taxonomy of techniques                       | ✓              | –         | –         | ✓         | ✓        |
| Bland‑Altman plots                           | ✓ (conceptual) | –         | –         | ✓         | –        |
| Box‑plots, bar charts, heatmaps, line graphs | –              | –         | –         | ✓         | –        |
| Code snippets                                | –              | –         | ✓         | –         | ✓        |

This plan ensures every visual has a clear purpose, is placed logically, and avoids unnecessary duplication by centralising reusable assets in the appendix.