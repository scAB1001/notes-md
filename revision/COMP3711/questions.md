# Test
## Outline
- Lecture 1: Introduction to
## MCQ
Question 1
What is the purpose of a confusion matrix in classification problems?
a) To determine the importance of each feature in the model
b) To summarise regression model performance
c) To calculate the overall accuracy of the model
d) To visualise the performance of a classification model by showing true vs predicted classifications
## Section Specific
### Section 1: Introduction & Data Understanding (Lectures 1-2)
#### Question 1.1 (1 mark)
Which of the following best defines **datafication**?
a) The process of cleaning and structuring raw data.
b) The practice of using algorithms to predict future trends.
c) The process of taking aspects of life and turning them into quantifiable data.
d) The statistical analysis of large datasets to find correlations.
#### Model Solution for 1.1:
**c) The process of taking aspects of life and turning them into quantifiable data.**
*   **Explanation**: This is the core definition from Lecture 1. **Datafication** is the transformation of qualitative, real-world phenomena (e.g., sleep, social interactions) into **data points** that can be tracked and analyzed, creating new forms of value and **actionable insights**.
#### Question 1.2 (2 marks)
According to Donoho's "50 Years of Data Science" paper, what is a key distinction between **Lesser Data Science (LDS)** and **Greater Data Science (GDS)**? Select **two** correct answers.
a) LDS is focused on commercial big-data tools, while GDS proposes a more rigorous, academic framework.
b) LDS includes the study of data ethics, while GDS does not.
c) GDS incorporates the **Common Task Framework (CTF)** as a driver of progress, while LDS ignores it.
d) GDS is solely concerned with predictive modelling, while LDS covers the full data lifecycle.
e) A core division of GDS is **"Science about Data Science"**, the empirical study of data analysis methods themselves.
#### Model Solution for 1.2:
**a) LDS is focused on commercial big-data tools, while GDS proposes a more rigorous, academic framework.** and **e) A core division of GDS is **"Science about Data Science"**, the empirical study of data analysis methods themselves.**
*   **Explanation**: Donoho critiques the narrow, tool-focused **"Lesser Data Science"** driven by industry. His **"Greater Data Science"** vision is broader and includes six divisions, the last and most forward-looking being the empirical, evidence-based study of data science methodology itself. The CTF is highlighted as important, but not as the defining difference.
#### Question 1.3 (1 mark)
A dataset containing customer records has a column for 'Postcode' and a separate column for 'City'. During profiling, you find that for some records, the postcode does not match the city (e.g., a Leeds postcode with 'Manchester' as the city). This is primarily an issue of data:
a) Granularity
b) Scope
c) Temporality
d) Faithfulness
#### Model Solution for 1.3:
**d) Faithfulness**
*   **Explanation**: **Faithfulness** refers to how well data captures reality, including checking for internal **consistency** and violations of obvious dependencies. A mismatched postcode and city is an example of such an inconsistency, indicating a potential data entry error that reduces the data's faithfulness.
#### Question 1.4 (3 marks)
You are exploring a dataset of patient blood test results. The 'Cholesterol' column has 5% missing values. Describe **three** different strategies for handling these missing values, and for each, state one potential **advantage** or **disadvantage**.
#### Model Solution for 1.4:
**(1) Deletion:** Remove all rows with a missing cholesterol value.
*   *Advantage:* Simple and fast to implement.
*   *Disadvantage:* Can introduce **bias** if the missingness is not random (e.g., if sicker patients are less likely to have results recorded), and reduces dataset size.

**(2) Mean/Median Imputation:** Replace missing values with the **mean** or **median** cholesterol level of all patients.
*   *Advantage:* Preserves the dataset size and is simple.
*   *Disadvantage:* Reduces variance and can distort relationships, especially if the missing values have a different underlying distribution.

**(3) Regression Imputation:** Build a model (e.g., linear regression) using other patient features (age, weight) to **predict** the missing cholesterol values.
*   *Advantage:* Can be more accurate than simple imputation if other features are predictive.
*   *Disadvantage:* More complex, risks **overfitting**, and assumes the relationship used for prediction is correct. It also underestimates uncertainty as imputed values are treated as certain.
#### Question 1.5 (2 marks)
For each of the following variables, state whether it is best classified as **Continuous, Discrete, Ordinal, or Nominal**.
i) Shirt size (S, M, L, XL)
ii) Number of products purchased in a transaction
iii) Temperature in degrees Celsius
iv) Political party affiliation (Conservative, Labour, Liberal Democrat)
#### Model Solution for 1.5:
i) **Ordinal**. The categories have a clear order (S < M < L < XL), but the intervals between sizes are not necessarily consistent or meaningful.
ii) **Discrete**. The count of products is a finite, countable number (0, 1, 2, ...).
iii) **Continuous**. Temperature can be measured to an arbitrary level of precision (e.g., 20.0, 20.01, 20.015°C).
iv) **Nominal**. Party names are categories with no inherent order or ranking.
#### Question 1.6 (1 mark - Select Two)
Which of the following are key focuses during the **data profiling** stage of a project, as outlined in the "Practical Guide to Characterising Data"?
a) Training the final machine learning model.
b) Investigating **data quality** (completeness, accuracy, consistency).
c) Characterising the data (understanding its structure and distributions).
d) Deploying the model to a production API.
e) Writing the final project report.
#### Model Solution for 1.6:
**b) Investigating **data quality** (completeness, accuracy, consistency).** and **c) Characterising the data (understanding its structure and distributions).**
*   **Explanation**: The guide's core framework separates **data characterisation** (what the data *is*) from **data quality investigation** (how *fit* it is for purpose). Profiling is the investigative phase before modelling begins.
#### Question 1.7 (5 marks - Scenario Based)
*Scenario:* You are a data scientist at a retail bank. The fraud team wants to build a system to identify potentially fraudulent credit card transactions in **real-time**. They provide you with a historical dataset containing millions of transactions, each with features like `transaction_amount`, `merchant_category`, `time_of_day`, `customer_age`, and a binary label (`is_fraud`: 0 or 1).

a)  What type of machine learning task is this? (1 mark)
b)  The dataset is heavily **imbalanced** (less than 0.1% of transactions are fraud). Why would **accuracy** be a misleading metric to evaluate a model for this task? (2 marks)
c)  Suggest a more appropriate **evaluation metric** and briefly justify your choice. (2 marks)
#### Model Solution for 1.7:
a)  This is a **binary classification** task. The goal is to predict a categorical label (`fraud` or `not fraud`) for each transaction.

b)  **Accuracy** measures the proportion of correct predictions overall. A naïve model that simply predicts "not fraud" for every transaction would be correct over 99.9% of the time, yielding a very high accuracy score. However, this model is useless as it fails to identify **any** of the fraudulent cases (the **positive class** we care about). Therefore, accuracy hides the model's failure on the critical **minority class**.

c)  The **F1 Score** would be a more appropriate metric.
    *   **Justification**: The F1 Score is the **harmonic mean of Precision and Recall**.
    *   **Precision** is important because we want to minimize **false positives** (legitimate transactions flagged as fraud, which annoys customers).
    *   **Recall** is critically important because we want to catch as many **true positives** (actual fraud) as possible.
    The F1 score balances these two competing concerns, providing a single measure that is robust to **class imbalance**. Alternatively, the **Area Under the Precision-Recall Curve (PR-AUC)** is specifically designed for imbalanced classification.
