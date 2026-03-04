# Hand-Gesture VR Anatomy Navigation System

## Project Overview
I'm working on my BSc Computer Science final year project (COMP3932 Synoptic Project/EPA) titled **"Replacing Joystick Control: A Hand-Gesture Based Navigation System for 3D Anatomy Manipulation in Virtual Reality."** The project involves developing a hand-tracking interface for a singular medical anatomical model (a patient's liver) to replace existing joystick-based navigation used in surgical planning.

## Current Status (March 1st 2026)
### What I Have Now:
**Hardware Access:**
- Lab PC with: 
	- Windows 11, 
	- Precision 3650 Tower, 
	- 11th Gen Intel(R) Core(TM) i7-11700 @ 2.50GHz, 2496 Mhz, 8 Core(s), 16 Logical Processor(s),
	- GPU 0: NVIDIA GeForce RTX 3080
	- Installed Physical Memory (RAM): 32.0 GB


- Virtual Reality Lab access with Varjo XR-4 headsets
- UltraLeap 2 (Leap Motion Controller 2) peripheral mounted on headset
- Varjo Base software installed on lab PC
- UltraLeap Tracking and Control Panel software on lab PC

**Development Environment:**
- Unity (URP template) with Windows Standalone 64-bit build target
- Varjo XR plugin and UltraLeap Unity plugin ready to install
- Understanding of required Unity settings (DirectX 11/12, Linear color space)

**Data Assets (Liver Resources):**
- Real capsule endoscopy image (reference visualization)
- Liver boundary abstracts (2 files - segmentation boundaries)
- Patient contour JSON files (3 files - 2D and 3D contour data)
- 3D model OBJ files (5 - liver, vena cava, multiple tumors in original/transformed versions)
- Patient liver line outline (2D contour reference)
- Overlay 3D-2D Python utility (registration/transformation)

**Knowledge Gained:**
- Varjo + UltraLeap integration: Unity XR SDK doesn't support Varjo's hand tracking, must use UltraLeap
- XR-4 offset configuration: All offsets are zero (Y=0, Z=0, X tilt=0)
- Need for mesh preprocessing: Medical models have holes, non-manifold edges, high vertex density
- Gesture detection approaches: pinch thresholds (enter 0.02, exit 0.05), grab detection via finger curl
## Project Requirements & Scope
### The Computer Science Problem:
Traditional joystick interfaces for 3D medical visualization impose artificial control mappings that poorly match natural human spatial reasoning. This project investigates whether computer vision-based hand tracking can reduce cognitive load by enabling direct, gesture-based interaction that more closely mimics real-world object manipulation.

**Specific CS challenges:**
1. HCI design: Creating learnable, memorable gesture vocabularies
2. Computer vision integration: Real-time hand tracking interpretation
3. 3D spatial mapping: Converting hand movements to precise model transformations
4. Performance engineering: Maintaining <100ms latency, 90+ FPS
5. Mesh processing: Handling topological inconsistencies in medical models
### Project Aim (Formal):
*"The aim of this project is to develop and evaluate a hand-gesture based interaction system for intuitive 3D anatomical model manipulation in virtual reality, addressing the usability limitations of traditional joystick-controlled interfaces."*
### Objectives (SMART):
1. Develop 3D model preprocessing pipeline for medical mesh optimization
2. Implement real-time hand gesture recognition using UltraLeap API
3. Design gesture-to-action mapping framework for VR navigation
4. Conduct comparative usability evaluation vs. joystick baseline
5. Optimize system performance for comfortable VR experience
### Deliverables:
- Final dissertation report (60-80 pages)
- Software repository with mesh processing toolkit, gesture recognition, Unity integration
- Functional prototype application
- Evaluation dataset and analysis
- Technical documentation
## Technical Constraints
**Critical Technical Notes:**
- Varjo XR-4 + UltraLeap: Unity XR SDK does NOT support Varjo hand tracking - MUST use UltraLeap plugin
- Offset values for XR-4: All zeros (verified from search results)
- Unity requirements: 2021.3 LTS+, Windows Standalone 64-bit, DirectX 11/12 (no OpenGL/Vulkan)
- Model scale: Unity expects 1 unit = 1 meter

**Mesh Processing Requirements:**
- Fix holes and non-manifold geometry
- Simplify dense meshes while preserving anatomical topology
- Convert to Unity-compatible format (OBJ/FBX)
- Preserve critical features for surgical accuracy

**Gesture Set to Implement:**
- Pinch: Grab/select (threshold: enter 0.02, exit 0.05)
- Grab: Move model (palm closure + finger curl)
- Point: Raycast interaction (index finger extension)
- Two-hand: Scale based on hand distance delta
- Two-hand rotate: Rotation around focal point

## Project Plan & Timeline
### Immediate Next Steps (Weeks 1-2):
1. Verify Unity version and build settings
2. Install Varjo XR plugin via Package Manager
3. Import UltraLeap Unity plugin (Core only)
4. Create hand offset configuration script
5. Run sample scene with hand visualization
6. Test in lab with actual hardware
### Weeks 3-4: Model Pipeline
- Inventory and assess all OBJ files for issues
- Research mesh processing algorithms
- Develop Python/Blender cleaning pipeline
- Import processed models to Unity
### Weeks 5-7: Gesture Implementation
- Implement pinch, grab, point detection
- Create gesture state machine
- Map gestures to model transformations
- Add visual feedback
### Weeks 8-10: Evaluation Prep
- Design test tasks and data collection
- Create joystick baseline version
- Prepare ethics approval materials
- Pilot testing and refinement
## Risks & Mitigation

| Risk | Mitigation |
|------|------------|
| Hand tracking unreliable | Simulation mode (mouse control), maintain joystick backup |
| Mesh processing fails | Prioritize one working model, manual Blender cleanup |
| Hardware access conflicts | Book lab 2 weeks ahead, develop in simulator mode |
| Scope creep | MVP defined: basic gestures + one model |
| Participant recruitment | Start early, use computing students |
## Ethics Considerations
- **Data:** Only publicly available anonymized datasets (TCIA)
- **User testing:** University students only, informed consent, right to withdraw
- **Health & safety:** Pre-screening, 15-min VR sessions, researcher monitoring
- **Ethical approval:** Required for user testing (submission Week 4 Semester 2)
## Questions Needing Attention
1. What specific mesh processing algorithms are most appropriate for preserving anatomical accuracy while simplifying?
2. How many evaluation participants provide statistically meaningful results?
3. What additional gestures would enhance surgical planning tasks?
4. How to handle the overlay 3D-2D Python utility - what role does it play?
## Expected Output from This Catch-Up
I need help with:
- Refining the technical approach based on current understanding
- Troubleshooting integration issues
- Developing mesh processing pipeline
- Designing robust gesture recognition
- Planning evaluation methodology
- Writing dissertation chapters
- Preparing for EPA presentations/assessments