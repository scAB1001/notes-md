# Plan
## Central Argument Structure

Every output below should be read as evidence toward one of three sub-questions:

1. **Cognitive load** — does one modality demand more of the user? (RTLX)
2. **Perceived usability** — do users find one modality more usable? (SUS)
3. **Statistical credibility** — are the differences real or noise? (inferential tests)

The telemetry (pending) will add a fourth: **objective performance** — does one modality actually produce better outcomes?

---

## Normality & Assumption Checks

### Shapiro–Wilk tests (Cell 3) + Q-Q plots (Figure 6)
**What they are:** Formal and visual checks of whether your difference scores are normally distributed.

**Why they matter to your project:** Your $n=8$ sample is too small to assume normality by the Central Limit Theorem. Whether you foreground the paired t-test or the Wilcoxon in your Results chapter depends entirely on these outputs. If Shapiro–Wilk rejects normality ($p \leq 0.05$) for a given comparison, you must foreground the Wilcoxon result for that test and note the parametric result only as supplementary. This is a methodological integrity point that examiners will look for explicitly.

**The argument it makes:** It doesn't argue for or against hand-tracking directly — it determines which of your other results you are permitted to assert with confidence.

---

## SUS Outputs

### Figure 1 — SUS Aggregate Box Plot
**What it shows:** The distribution of overall usability scores per modality, with grade threshold lines at 51, 68, and 80.3, and individual participant dots overlaid.

**Why it matters:** At $n=8$, the box alone is misleading — the individual points are as important as the median. A modality sitting above 80.3 is rated *Excellent*; one sitting below 68 falls below the industry average. If hand-tracking falls in *Okay–Fair* while the controller reaches *Excellent*, that is a direct, quantified statement that hand-tracking is not yet a viable replacement in its current form.

**The argument it makes:** This is your headline usability finding. The grade bands give you an industry-validated benchmark rather than a relative comparison in isolation — you are not just saying the controller scored higher, you are saying hand-tracking scored *below the global average for usable systems*.

---

### Figure 2 — SUS Item-Level Median Bar Chart
**What it shows:** The median raw Likert response per question per modality, side by side across Q1–Q10.

**Why it matters:** The aggregate SUS score can mask where a system fails. Q8 is *"I found the system very tiring to use"* — a direct proxy for gorilla-arm fatigue with the Ultraleap. Q3 is about whether the system felt unnecessarily complex. If hand-tracking scores poorly on Q8 but well on Q3 and Q7 (integration and intuitiveness), that tells a nuanced story: the system is conceptually sound but physically demanding — which is a design recommendation, not a verdict of failure.

**The argument it makes:** Diagnostic decomposition of usability. Tells you *where* each modality succeeds and fails, which feeds directly into your discussion section's recommendations. If hand-tracking is dragged down by Q8 alone, you can argue that ergonomic refinements (shorter sessions, wrist rests, reduced tracking volume) could close the gap — making replacement feasible with iteration rather than fundamentally impossible.

---

### SUS Item-Level Wilcoxon Table (Cell 6)
**What it shows:** Per-item signed-rank test results with medians and descriptive stats for both modalities.

**Why it matters:** Identifies which specific SUS items show a statistically credible difference between modalities, not just a descriptive one. At $n=8$, most individual items will not reach $p < 0.05$ — but items approaching significance (e.g. $p = 0.06$–$0.12$) are worth discussing as trends in the context of limited power.

**The argument it makes:** Precision evidence. Rather than saying *"users found the controller more usable overall,"* you can say *"the statistically meaningful usability gap was localised to items concerning physical demand (Q8) and system confidence (Q7), while items concerning learnability (Q3, Q4) showed no significant difference"* — which is a far more sophisticated finding.

---

### SUS Aggregate Inferential Table (Cell 5)
**What it shows:** Paired t-test and Wilcoxon results for the overall SUS score, plus Cohen's $d$ and rank-biserial $r$.

**Why it matters:** Determines whether the aggregate usability gap between modalities is statistically credible. Cohen's $d$ is critical here — at $n=8$ you may not reach $p < 0.05$, but a large effect size ($d > 0.8$) tells you the difference is real and your study was simply underpowered to detect it reliably. This is a standard limitation acknowledgement in small-$n$ HCI studies.

**The argument it makes:** Whether hand-tracking is *significantly* less usable, or just *descriptively* less usable. A non-significant result with a large effect size should be written up as *"the study lacked sufficient power to confirm the observed difference, but the effect magnitude ($d = x$) suggests a practically meaningful gap warranting investigation at larger $n$"* — not as *"there was no difference."*

---

## RTLX Outputs

### Figure 3 — RTLX Sub-scale Grouped Bar Chart
**What it shows:** Mean score per cognitive load dimension per modality, with ±1 SD error bars, aggregated across all tasks and participants.

**Why it matters:** This is your gorilla-arm test. If Physical Demand and Frustration are elevated for hand-tracking while Mental Demand is lower, that matches the theoretical prediction exactly — bare-hand interaction is more intuitive cognitively but more demanding physically. If both Mental Demand *and* Physical Demand are higher for hand-tracking, that suggests the Ultraleap interface is failing on both fronts, which is a stronger argument against replacement.

**The argument it makes:** The trade-off profile between modalities. No single bar wins the argument — it is the *pattern* across all six dimensions that constitutes your finding. A controller that imposes high Mental Demand but low Physical Demand versus a hand-tracking system that does the opposite represents a substitution of one type of cost for another, not a clear win for either.

---

### Figure 4 — RTLX Radar Chart
**What it shows:** The same sub-scale data as Figure 3 but as overlapping polygons on a polar axis — one polygon per modality.

**Why it matters:** The radar format makes the *shape* of the cognitive load profile immediately visible. A controller polygon that is large in the Mental/Temporal quadrant and small in Physical, versus a hand-tracking polygon with the inverse shape, communicates the trade-off in one glance. This is the figure most likely to appear in your dissertation as a key visual.

**The argument it makes:** Complementary to Figure 3 — use both. Figure 3 gives precise values; Figure 4 gives the gestalt pattern. In your write-up you reference Figure 4 when arguing about the overall character of each modality's cognitive cost, and Figure 3 when making specific numerical claims.

---

### Figure 5 — RTLX Total Box Plots per Task
**What it shows:** RTLX aggregate load distributions per modality, split by task (Pure Translation, Pure Rotation, 6-DoF, Bimanual Scaling) in a four-panel figure.

**Why it matters:** Task 4 (Bimanual Scaling) is the most theoretically important. It is the only task that uses the full bimanual interaction model of the Ultraleap — two-hand pinch distance deltas — which has no direct analogue with a single controller. If hand-tracking cognitive load spikes specifically at Task 4 but not Tasks 1–2, that suggests the bimanual gesture model is the bottleneck, not the modality as a whole. If hand-tracking is consistently higher across all four tasks, the problem is more systemic.

**The argument it makes:** Task-specificity of the cognitive load difference. This is where your DFSM architecture becomes relevant — State D (SCALING) is the most complex automaton path, requiring simultaneous pinch threshold detection, bimanual distance delta computation, and grip maintenance. High RTLX at Task 4 specifically would validate the architectural complexity of that state.

---

### RTLX Sub-scale Descriptives + RMSSD Table (Cell 8)
**What it shows:** Mean ± SD and median/IQR per subscale per condition, plus the Root Mean Square of Successive Differences across the six sub-scale scores per participant per condition.

**Why the RMSSD matters:** RMSSD here captures intra-participant *inconsistency* across the six cognitive dimensions. A high RMSSD means the participant experienced very uneven load across subscales — some dimensions were fine, others were extreme. A low RMSSD means load was distributed evenly. If hand-tracking produces higher RMSSD than the controller, it suggests the interaction is imposing *spiky* or unpredictable cognitive demands rather than consistent ones — which in a clinical context is arguably more problematic than consistently moderate load, because it indicates the user cannot anticipate where their attention will be taxed.

**The argument it makes:** Load consistency as a clinical safety consideration. Even if mean RTLX totals are similar, high RMSSD for hand-tracking suggests a less predictable cognitive profile — relevant if this system is ever deployed in an actual surgical planning context where attentional predictability matters.

---

### RTLX Inferential Table per Task (Cell 7)
**What it shows:** Paired t-test and Wilcoxon results for RTLX totals across each of the four tasks, with effect sizes.

**Why it matters:** Tells you which tasks drive statistically credible differences. You may find Tasks 1–2 show no significant difference but Tasks 3–4 do — which localises the argument precisely. Effect sizes again compensate for low power.

**The argument it makes:** Where in the interaction protocol hand-tracking becomes significantly more demanding. If 6-DoF (Task 3) and Scaling (Task 4) both show large effects, your conclusion is that hand-tracking degrades under degrees-of-freedom complexity — exactly the condition that clinical manipulation would impose.

---

## Summary Tables

### Comprehensive Comparative Table (Cell 9)
**What it shows:** All SUS and RTLX descriptive statistics in a single structured table — both modalities, all measures, all tasks.

**Why it matters:** This is your Results chapter anchor table. Every specific numerical claim in your prose should be traceable back to this table. Examiners expect a single reference table of this kind for a within-subjects comparison study.

**The argument it makes:** It does not itself make an argument — it is the evidentiary foundation that all your prose arguments cite.

---

## Pending Telemetry Outputs

When the telemetry data arrives, the remaining figures will address the fourth sub-question — objective performance — and will be the most direct evidence for or against replacement viability. Subjective measures (RTLX, SUS) tell you how users *felt*; telemetry tells you what they *actually achieved*. The Bland–Altman plots in particular will be critical — they will show whether the two modalities produce *clinically equivalent* outcomes (agreement within acceptable limits) or systematically divergent ones.

---

## The Replacement Verdict

Your dissertation conclusion will synthesise all of the above into one of three positions:

**Position A — Not yet viable:** Hand-tracking shows inferior usability (SUS), higher cognitive load (RTLX), and worse objective performance (telemetry) across most tasks. Recommendation: requires significant interface refinement before clinical deployment.

**Position B — Task-conditionally viable:** Hand-tracking performs comparably on simple translation and rotation tasks but degrades on 6-DoF and bimanual scaling. Recommendation: viable for constrained interaction modes; not yet for full 6-DoF clinical manipulation.

**Position C — Viable with caveats:** Statistical differences are present but effect sizes are modest. Usability grades are acceptable. Recommendation: hand-tracking is a credible replacement candidate subject to larger-scale validation.

The outputs you have built are designed to produce exactly the evidence needed to defend whichever of these positions your data supports.
Let me compute what the heatmaps will actually show before writing any code.Good — the data is rich enough to justify exactly four heatmaps. One candidate (raw SUS item responses) is rejected below for methodological reasons. Here is the full assessment and code:

---

## Which Heatmaps Are Justified and Why

**✅ HM-A — RTLX Sub-scale × Task (side-by-side per condition)**
The most analytically valuable heatmap. Reveals simultaneously *which subscale* and *which task* drives load, for each modality.

**✅ HM-B — RTLX Difference Heatmap (Hand − Controller)**
Collapses the comparison into a single signed matrix. Red = hand-tracking worse, blue = controller worse. Immediately shows whether the gap is uniform or task/subscale-specific.

**✅ HM-C — Participant × Task RTLX Total (side-by-side)**
Individual-level view. Exposes whether high group means are driven by one or two outlier participants, or whether the pattern is consistent across all $n$.

**✅ HM-D — SUS Item Difference per Participant (Hand − Controller)**
Shows which specific SUS questions drove each participant's score gap — directly linkable to qualitative feedback.

**❌ HM — Raw SUS item responses (rejected)**
Displaying raw Likert responses without scoring inversion would misrepresent the scale. Post-inversion the values lose their 1–5 interpretability for a heatmap reader. The difference map (HM-D) is more informative and methodologically cleaner.Four cells, each a standalone figure. Here is what each one argues for your dissertation:

---

## Figure 7 — RTLX Sub-scale × Task (Side-by-Side)

**What the reader sees:** Two heatmaps — one blue, one red — with the same colour scale, showing mean load per subscale per task for each modality.

**The argument:** This is your primary diagnostic tool for the replacement question. The Performance row will always appear as a visually distinct dark band in both panels (corrected values cluster near 15–19, reflecting participants rating their own performance as good). Everything above and below that band tells you where each modality imposes load. If Frustration darkens from T1→T4 only in the hand panel, that pinpoints bimanual scaling as the failure mode. If Mental Demand is consistently darker in the controller panel, that supports the cognitive friction argument — the controller requires learned mappings that hands do not.

---

## Figure 8 — RTLX Difference Heatmap (Hand − Controller)

**What the reader sees:** A single diverging heatmap. Red cells = hand-tracking imposed more load there. Blue cells = controller imposed more load. White cells = no difference. Every cell is annotated with its signed value.

**The argument:** This is the single most direct visualisation for the replacement verdict. A predominantly red heatmap = hand-tracking is categorically more demanding. A mixed pattern = the trade-off is task- and dimension-specific, meaning replacement is viable for some tasks but not others. Zero-difference cells (bordered in the code) indicate where the modalities are genuinely equivalent. The Temporal Demand and Physical Demand rows are the most theoretically interesting — if they are blue (controller worse), that would be a surprising and dissertation-worthy finding.

---

## Figure 9 — Participant × Task RTLX Total (Side-by-Side)

**What the reader sees:** Two heatmaps showing each individual participant's total RTLX score across the four tasks.

**The argument:** This is your outlier and consistency check, and it is essential at $n=8$. If the group-level finding is that hand-tracking imposes higher cognitive load, Figure 9 lets you verify whether that is true for *every* participant (a robust finding) or whether one participant (e.g. P04, who has notably high hand-tracking scores in the raw data) is inflating the group mean. Consistent row-level patterns — where the hand panel is uniformly darker than the controller panel across most participants — strengthen any inferential claims you make enormously at this sample size. It also lets you flag individual anomalies for your discussion: *"P03 showed the inverse pattern to the group trend, reporting lower RTLX under hand-tracking across all tasks, consistent with their qualitative preference for the hand modality."*

---

## Figure 10 — SUS Item Difference per Participant (Hand − Controller)

**What the reader sees:** A single heatmap of raw Likert response differences, with phrasing direction (positive/negative item) annotated below each column.

**The argument:** This requires care in interpretation, which is why the phrasing annotation is built into the code. For odd items (positive phrasing like *"I thought the system was easy to use"*), a red cell means the participant rated hand-tracking more favourably — that is good for hand-tracking. For even items (negative phrasing like *"I found the system very tiring"*), a red cell means they rated it as more tiring — that is bad for hand-tracking. The most dissertation-relevant cells are Q7 (*"I would imagine that most people would learn to use this system very quickly"*) and Q8 (*"I found the system very cumbersome to use"*). If Q8 is uniformly red across participants in the even-item interpretation, that corrobor
This is an important decision that has consequences across your entire pipeline. Let me go through every layer systematically.

---

## What Changes

### Statistical Reporting — Degrees of Freedom
Your paired t-tests were already computed at $n=5$, so the test statistics themselves do not change. What changes is how you **report and justify** them. $t(4)$ was previously a temporary state pending full data — it is now your final reported value. Remove every instance of *"partial dataset; final analysis $n=8$"* from all table footnotes.

---

### Power Analysis — This Needs Adding
Dropping to $n=5$ makes your power situation significantly more critical to acknowledge explicitly. You should report this in your Methodology:These numbers are the most important output of this entire conversation for your dissertation. Here is the complete impact assessment:

---

## Complete Impact by Section

### Methodology Chapter
You must now explicitly state that $n=5$ is your **final analytic sample**, and justify the exclusion of three participants. The justification needs to be documented — *bias* is not sufficient on its own as written. Common valid reasons include:

- Equipment malfunction / incomplete data collection
- Participant withdrew consent post-session
- Systematic response bias identified (e.g. straight-lining all responses)
- Protocol deviation during session

Whatever your reason, it must be stated clearly. Examiners will ask. Add a participant flow diagram or a brief exclusion table if possible.

You must also add a **post-hoc power analysis** paragraph. The numbers are stark:

> *"At the final analytic sample of $n = 5$, the study achieved a minimum detectable effect of $d = 1.69$ at $\alpha = .05$ and $1 - \beta = .80$ (two-tailed paired $t$-test, $df = 4$). The largest observed effect — SUS aggregate score, $d = 1.05$ — corresponded to an achieved power of $.43$, substantially below the conventional $.80$ threshold. RTLX comparisons ranged from $d = 0.29$ to $d = 0.74$, yielding achieved power of $.08$–$.25$. These figures indicate the study is materially underpowered and that non-significant results cannot be interpreted as evidence of equivalence between modalities. To achieve $.80$ power at the observed SUS effect size ($d \approx 1.05$), a sample of $n = 10$ would be required."*

This is not a weakness to hide — it is a **limitation to foreground honestly** and address in your Discussion.

---

### Results Chapter
Every inferential result must now be contextualised against the power figures. The protocol for each non-significant result changes from *"no significant difference was found"* to something like:

> *"No statistically significant difference was observed ($W = 2.0$, $p = .188$); however, given the achieved power of $.25$ at this effect size, a Type II error cannot be excluded."*

Effect sizes ($d$ and $r_{rb}$) now become your **primary evidence**, not the $p$-values. At $n=5$, the $p$-value is almost guaranteed to be non-significant for all but the most extreme effects — your SUS $d = 1.05$ is a genuinely large effect that the sample size simply cannot confirm statistically.

---

### Tables — What to Update
Every table footnote needs two changes:

1. Remove *"partial dataset; final analysis $n=8$"* — replace with *"$n = 5$ (see Section X.X for exclusion criteria)"*
2. The $t(4)$ and $df = 4$ notation is now **correct and final** — no change needed there

---

### Discussion / Limitations Chapter
Add a dedicated limitations paragraph covering:

- **Underpowered design:** $n=5$ yields $.43$ power even at the large SUS effect ($d = 1.05$); all null RTLX results must be treated as inconclusive rather than negative
- **Generalisation:** five participants cannot support population-level claims about hand-tracking viability in clinical contexts
- **Recommended replication sample:** $n \geq 10$ for large effects, $n \geq 34$ for medium effects ($d = 0.5$)
- **Counterbalancing:** with $n=5$, any order effects are extremely difficult to detect or control

---

### What Does NOT Change
- All computed statistics ($t$, $W$, $p$, $d$, $r_{rb}$, RMSSD) — these were already computed on $n=5$
- All LaTeX table structures and values — only footnote text needs editing
- All figures and heatmaps — already based on the five participants' data
- The Wilcoxon as primary statistic — this decision is *more* justified now, not less

---

The core finding remains arguable — a SUS effect size of $d = 1.05$ is large by any convention and points clearly toward the controller being rated as more usable. Your dissertation's intellectual contribution is to report that honestly, acknowledge the power limitation, and frame the work as a **pilot study establishing effect size estimates** to power a future definitive trial — which is a completely legitimate and well-precedented position in HCI research.

## RULE

The rule is: **introduce once in the literature review, justify once in the methodology, report once in the results.**

You never re-explain what a test is after the literature review. You never re-justify why you chose it after the methodology. The citations follow the same pattern — they appear heavily in the literature review where the concept is introduced, lightly in the methodology where the test is specified, and not at all in the results where you simply report the output.

---

**Literature Review** — cite fully here. This is where you establish what each test is and why it is appropriate. Every citation listed above belongs here with its full justification paragraph. This is the only place you explain Shapiro-Wilk, Wilcoxon, Cohen's d etc. as concepts.

**Methodology (Statistical Analysis Plan)** — cite minimally here. One back-reference per test is sufficient, using the pattern:

You do not re-explain the test. You simply name it, state which metrics it applies to, and back-reference. The citation appears only because you are making a methodological claim that needs attribution. For tests where the justification is entirely captured by the back-reference, you can omit the citation from the methodology entirely and let the cross-reference carry it.

**Implementation** — no citations for statistical tests here. The implementation chapter describes how the data pipeline was built, not how the data will be analysed. The only statistical content in the implementation chapter is Welford's algorithm, which has its own citation in the literature review and a back-reference in the implementation.

**Results** — no citations for statistical tests here. You report $W = 1.0$, $p = .125$, $d = -1.05$ and move on. The methodology has already told the reader what these numbers mean and why these tests were chosen. Repeating the citation in the results section implies you are still justifying the choice, which should already be settled.

##
```latex
This is a substantial editorial task. I will work through Introduction and Literature Review systematically, identifying every problem and proposing a concrete fix. I will not rewrite everything — only flag what needs changing, cutting or restructuring, with a rationale for each decision tied to the marking rubric criterion it addresses.

---

## Introduction Chapter

### Structural Problems

**The chapter does not introduce key terms early enough.** The reader reaches the Literature Review without knowing what CTR, HTR, the liver mesh, the docking task, NUI, 6-DoF or the DFSM are. Every subsequent chapter uses these terms freely. Fix: add a brief terminology paragraph at the end of Section 1.3 that introduces all abbreviations that recur throughout the dissertation. This eliminates the need for repeated full expansions later and is standard practice in technical dissertations.

**Section 1.2 is weak and should be merged.** The section heading is `The Problem with Current VR Controllers` but the content is mostly about the dimensional mismatch established in Section 1.1. It adds one new idea — mapping dissonance — but stretches it across four short paragraphs. Merge Sections 1.1 and 1.2 into a single section titled `Clinical Motivation and Interaction Problem`, keeping the dimensional mismatch, the cognitive translation cost and the mapping dissonance argument in one continuous flow.

**The report structure enumeration is undergraduate in register.** `Chapter 1) provides a systematic literature review...` is the wrong numbering — Chapter 1 is the Introduction, not the literature review. The list also uses passive, weak phrasing. Either remove it entirely and replace with two sentences of prose, or fix the numbering and tighten the language. At this level the examiner does not need a chapter-by-chapter summary of obvious content.

### Sentence-Level Problems

**Section 1.1, paragraph 2:** `Prior to the development of 3D reconstruction, this required surgeons to construct a precise mental model...` — the phrase `develop a better understanding` in the preceding sentence is vague. Cut it. State the clinical act directly: surgeons interpret CT and MRI scans to identify tumour boundaries and vascular anatomy.

**Section 1.1, paragraph 3:** `This cognitive spatial translation was exhausting and error-prone` — this sentence summarises what the previous paragraph already said. Cut it and merge the CASP sentence directly after the imaging sentence.

**Section 1.2, paragraph 1:** `Immersive virtual reality (IVR) directly address` — subject-verb agreement error. Also, `quickly, a secondary obstacle was introduced` is colloquial. Rewrite: `VR resolves the dimensional mismatch by embedding the surgeon within a true 3D environment, but introduces a secondary problem: how to interact with that environment without reintroducing the cognitive translation cost VR was designed to eliminate.`

**Section 1.3, paragraph 1:** `A growing body of evidence suggests` — weak hedge. You have specific citations. State the claim directly and cite. `Optical hand tracking eliminates the controller mapping layer by translating bare-hand motion directly into digital kinematics \citep{Bachmann2018ReviewController}, theoretically removing the cognitive translation cost at source.`

**Section 1.3, paragraph 3:** `Although HTR promises a more intuitive experience, it introduces new hardware vulnerabilities` — the phrase `promises` is subjective. Use `offers` or state it as an empirical finding. Also the commented-out paragraph at the end of this section should either be included or deleted from the submitted document — comments must not appear in the final PDF.

### What to Cut

- The second sentence of the opening paragraph: `Consequently, liver resection: the surgical removal of malignant tumours, is a clinical priority.` — rewrite as: `Liver resection is therefore a clinical priority, yet the extreme vascularity of the liver renders these procedures exceptionally demanding \citep{Fan2002ResectionAspects}.`
- `Other modelling approaches, such as 3D printing...` in the Literature Review Section 2.1 — this belongs in the Introduction as background context, not in the Literature Review, and even there it is a marginal point that consumes space without advancing the argument.
- The commented-out lines throughout both chapters must be removed from the submitted document.

---

## Literature Review Chapter

### Structural Problems

**Section 2.1 does not conclude with a forward link to the interaction problem.** The section ends after the Chheang collaborative VR paragraph. Add one sentence: `These studies collectively establish the liver docking task as the optimal experimental stimulus; however, they also expose a foundational gap: the input modality driving the interaction has not been empirically evaluated against optical hand tracking at this hardware generation.` This provides the logical bridge to Section 2.2 and motivates the rest of the literature review.

**Section 2.2.5 (Fitts' Law) is missing its mathematical formulation.** You have a comment `% ADD MATHS []` but no equation. The Fitts' Law equation and the Index of Difficulty formula must be present because the Methodology and Results chapters cite them when justifying TCT as the primary metric and when discussing task complexity scaling. Without the equation in the Literature Review, those back-references are unsupported. Add:

```latex
Fitts' Law predicts movement time $MT$ as a linear function of the
Index of Difficulty $ID$:
\begin{equation}
    MT = a + b \cdot ID, \quad \text{where} \quad
    ID = \log_2 \!\left(\frac{2D}{W}\right)
    \label{eq:fitts}
\end{equation}
where $D$ is the distance to the target, $W$ is the target width, and
$a$ and $b$ are empirically determined device constants
\citep{Soukoreff2004TowardsHCI}.
```

**Section 2.2.6 (DFA) opens with a forward reference to Section~\ref{sec:sensor_noise} which appears later in Section 2.6.** This creates a forward dependency within the literature review itself. Either move the DFA section to after Section 2.6, or remove the specific cross-reference and replace it with: `As reactive systems operating on continuous hardware input streams must handle tracking loss, optical occlusion and modality swap events without entering undefined states...`

**Section 2.8 (Statistical Analysis Methods) is misplaced relative to Section 2.7 (Software Compensation).** The statistical methods are analytical tools for evaluating the system, not software compensation techniques. The current order implies they are a subcategory of software engineering, which is logically incorrect. The section is correctly placed before the Summary of Gaps as confirmed earlier — ensure the numbering in the actual LaTeX document reflects this.

**Section 2.9 (Summary of Gaps) still contains the ART ANOVA reference.** The final sentence reads: `evaluating the resulting non-parametric data via the ART ANOVA, this research provides a mathematically robust, definitive analysis`. Remove `the ART ANOVA` and replace with `a pre-registered non-parametric analysis plan`. Also remove `definitive` — a pilot study with n=5 cannot make definitive claims and this word will attract examiner criticism.

**Section 2.10 (Project Aim and Objectives), Objective 5** still references `Aligned Rank Transform (ART) Analysis of Variance (ANOVA)`. Replace with `Wilcoxon Signed-Rank test as the primary non-parametric statistic, with effect sizes reported as Cohen's $d$ and rank-biserial $r$.`

### Section-Level Cuts

**Section 2.3.1 (Early Immersion):** The second paragraph is analytical padding. The key point is that early models conflated immersion with presence. One sentence suffices: `Early frameworks conflated technological immersion with psychological presence, treating embodiment as a binary rather than a continuous, multidimensional construct \citep{Kilteni2012TheReality}, limiting their ability to explain why distinct interaction metaphors produce measurably different cognitive responses.` Cut the rest of that paragraph.

**Section 2.4 (Cognitive Load) opening paragraph:** `\citet{Che2025Three-dimensional3D-MATB-II} underlines that navigating highly dense 3D environments inherently imposes a high baseline cognitive load` — this is a weak opening for the section. The MATB-II paper is a dual-task study unrelated to surgical VR. Lead instead with the surgical motivation: `In surgical simulation, cognitive load is the primary performance determinant; a surgeon who is mentally overloaded by the interaction interface cannot simultaneously reason about anatomy \citep{Mao2021ImmersiveReview}.`

**Section 2.5.2 (Fatigue-Induced Compensation):** The CAF model paragraph and the Yang posture study paragraph are both relevant but the connection to the proposed system is implicit. Add one concluding sentence: `In the proposed study, grip variance --- logged continuously via Welford's algorithm --- serves as a proxy for these fatigue-induced micro-tremors, providing an objective, non-intrusive correlate of the compensatory variance documented here.`

**Section 2.6.1 (Pantomime Grasping):** The sentence `This perfectly aligns with the close-proximity requirements of surgical docking alignment task` is too brief and colloquial. Expand slightly: `The liver docking simulation is explicitly a near-field task; the participant's hands remain within arm's reach of the mesh throughout. The literature therefore predicts a usability preference for HTR in this context, even where objective kinematic performance may favour CTR.`

**Section 2.6.2 (Sensor Noise):** The paragraph beginning `Much like sensor noise, the processing of raw tracking data...` conflates sensor noise with mathematical representation. Quaternions are not a compensation for sensor noise — they are a representation choice that prevents a different class of error (Gimbal Lock). Separate these into two paragraphs with distinct topic sentences.

**Section 2.7.2 (Multi-Modal):** The Gaze+Pinch section is well-written but slightly long. Cut the Midas touch paragraph to one sentence: `The primary limitation is the Midas touch problem, where unintentional glances trigger commands, increasing error rates in precision tasks \citep{Duchowski2017EyeEdition}.`

**Section 2.7.3 (Welford):** The algorithm is well-treated but the opening paragraph on `FixedUpdate` sampling belongs in the Implementation chapter, not the Literature Review. The Literature Review should explain *why* an online algorithm is needed, not *how* Unity's lifecycle works. Replace the first paragraph with: `High-frequency metric accumulation in game engine environments imposes a hard constraint on variance computation: the full sample history cannot be stored without triggering garbage collection at the 90\,Hz physics rate, which would introduce frame-time spikes directly detectable by participants as visual stuttering.`

### Sentence-Level Cuts Across the Chapter

The following phrases appear repeatedly and should be cut on every occurrence — they add length without adding meaning:

- `It can be concluded that...` — just state the conclusion.
- `This perfectly aligns with...` — just state the alignment.
- `While [X] is [positive], it [negative]...` — keep the structure once per section for contrast; cut redundant instances.
- `Furthermore,` at the start of consecutive paragraphs — vary with `This`, `Consequently`, `However` or restructure.
- `In our case,` — academic register; replace with `For the proposed system,` or `In this project,`.
- `We know from Section X that...` — replace with a clean cross-reference: `As established in Section~\ref{sec:X},...`

### Missing Content That Later Chapters Depend On

**The liver mesh is never formally introduced.** The Methodology and Implementation chapters refer to `the target mesh`, `the liver model`, `activeLiverModel` and `the docking task` as if the reader already understands what these are. Add one sentence in Section 2.1: `The proposed simulation uses a polygonal mesh of a human liver, generated from segmented CT data, as the manipulation target; this mesh is referred to throughout as the target mesh or liver model.`

**CTR and HTR are not defined as abbreviations in the Introduction.** They first appear informally in Section 2.6. Move their formal introduction to Section 1.3 in the terminology paragraph proposed above: `The two modalities are referred to throughout as Controller Tracking (CTR) and Hand Tracking (HTR).`

**The docking task is not formally defined until the Methodology.** The Introduction and Literature Review both refer to the `liver docking task` or `docking simulation` without ever defining what docking means in this context. Add one sentence in Section 1.1 or Section 2.1: `The docking task requires the participant to translate, rotate and scale a solid liver mesh to align it with a translucent target hologram, replicating the spatial reasoning demands of pre-operative resection margin planning.`

---

## Priority Order for Edits

| Priority | Action                                                                                    |
| -------- | ----------------------------------------------------------------------------------------- |
| Critical | Remove all ART ANOVA references from Gaps summary and Objectives                          |
| Critical | Remove all commented-out lines from submitted document                                    |
| Critical | Add Fitts' Law equation to Section 2.2.5                                                  |
| Critical | Add terminology paragraph to Section 1.3 defining CTR, HTR, mesh, docking task, NUI, DFSM |
| Critical | Fix subject-verb error in Section 1.2 paragraph 1                                         |
| High     | Merge Sections 1.1 and 1.2                                                                |
| High     | Add forward link to Section 2.1 conclusion                                                |
| High     | Fix DFA forward reference to sec:sensor\_noise                                            |
| High     | Add liver mesh formal definition to Section 2.1                                           |
| High     | Replace weak hedges throughout (`a growing body of evidence`, `it can be concluded`)      |
| Medium   | Cut Early Immersion second paragraph to one sentence                                      |
| Medium   | Separate quaternion paragraph from sensor noise paragraph in Section 2.6.2                |
| Medium   | Cut Gaze+Pinch Midas touch paragraph to one sentence                                      |
| Medium   | Replace FixedUpdate opening paragraph in Section 2.7.3                                    |
| Medium   | Add fatigue-to-grip-variance link sentence in Section 2.5.2                               |
| Medium   | Rewrite report structure enumeration or replace with prose                                |
| Low      | Vary paragraph openers throughout (`Furthermore` overuse)                                 |
| Low      | Replace all `In our case` with `For the proposed system`                                  |

```