day 09/00/2025

---
#### Module Objectives
- 


    config(xr): implement varjo offset and hdrp material resolution
    Integrates VarjoHandTrackingOffset.cs to ensure zero-offset alignment between optical tracking and the HMD coordinate space.
    Includes HDRPHandMaterialFixer.cs to resolve shader compatibility issues between the Ultraleap skeletal renderer and the High Definition Render Pipeline (HDRP)
    scAB1001
    scAB1001
    committed
    12 minutes ago
    feat(project): initialise sprint 1 baseline with managed asset hierarchy
    This commit establishes the foundational project structure and configuration required for the Varjo XR-4 and Ultraleap tracking environment.

    Key inclusions:
    - .gitignore: dedicated to the UnityProject dir
    - Packages: manifest.json and lockfile for SDK dependency resolution
    - ProjectSettings: Graphics (HDRP), Input, and XR hardware configurations
    - Assets/_Project: Authored scenes, scripts, and clinical liver models
    - Assets/XR & XRI: Loader and provider settings for OpenXR/Varjo
    - Plugins: TextMesh Pro runtime assets for VR user interface
    scAB1001
    scAB1001
    committed
    17 minutes ago
    chore(git): update list of files to track
    scAB1001
    scAB1001
    committed
    3 hours ago
    docs(README): Add boilerplate Readme to repo.
    - Increase LFS large-file hook size from 0.5 to 5MB
    scAB1001
    scAB1001
    committed
    6 hours ago
    docs(research): add examiner resource placeholders
    - Create the documentation directory for demo GIFs and system architecture diagrams
    - Add the placeholder for the final project report
    scAB1001
    scAB1001
    committed
    6 hours ago
    fix(git): Remove comments from .oxfmtrc.json
    scAB1001
    scAB1001
    committed
    6 hours ago
    config(git): configure local formatting rules and node dependencies
    - Define oxfmt rules for repository-wide file consistency (linting)
    - Commit the lockfile to ensure every environment uses identical tool versions
    scAB1001
    scAB1001
    committed
    7 hours ago
    config(github): implement automated ci workflows for linting and releases
    - Add dotnet-format for automated C# code validation
    - Add release-drafter and tag-and-release for automated version management
    scAB1001
    scAB1001
    committed
    7 hours ago
    chore(project): scaffold directory hierarchy for the unity project
    - Create and track the internal project structure
        - Core: Main clinical trial orchestration and system coordination
        - Input: Hand gesture recognition, state machine and Ultraleap manipulation
        - Telemetry: Performance metrics logging and user interaction data
        - Models: Liver OBJ files, tumor meshes and JSON contour data
        - Materials: Clinical hand and holographic rendering materials
        - Prefabs: Reusable UI elements and prepared liver variants
        - Scenes: Main VR clinical environment for hand-tracking testing
        - ThirdParty: External assets and libraries not managed by UPM
    - Use .gitkeep files to ensure empty directory persistence in the repository
    scAB1001
    scAB1001
    committed
    7 hours ago
    chore(github): implement pull request template for traceability
    - Establish a mandatory checklist for C# architecture and telemetry impact
    - Enforce the link between code changes and high-level project issues
    scAB1001
    scAB1001
    committed
    7 hours ago
    chore(github): implement issue templates for bug reporting and feature requests
    - Create standardised bug report template with hardware/telemetry sections
    - Create feature request template requiring HCI/research justification
    scAB1001
    scAB1001
    committed
    7 hours ago
    chore(git): initialise repository file-tracking
    - set-up LFS tracking for Unity files
    - add custom and Unity-specific files to the .gitignore
    scAB1001
    scAB1001
    committed
    - [ ] 8 hours ago

Commits on Apr 5, 2026