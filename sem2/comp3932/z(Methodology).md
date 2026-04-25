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