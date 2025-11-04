#### Final Checks
- [ ] Code 
	- [ ] Consistent, sensible and descriptive naming
	- [ ] Removed unnecessary TO-DOs and Commented code
	- [ ] Commented clearly throughout
	- [ ] Kept some additional test scenarios and sandbox tests
	- [ ] Compiles on SoC machine with no warnings
- [ ] Document
	- [ ] Referenced algorithms, images, quotes etc.
	- [ ] ==FIX== backwards quote issue
	- [ ] ==FIX== code listing && as ^ issue
	- [ ] 13 Pages only, 1 task per page.
	- [ ] Academic language, paragraphs, punctuation and spelling.
## Implementation
#### 1.2 Clipping Lines (3 marks)
Consider the function `clip_line`. It is declared in *draw2d/draw.hpp* and defined in *draw2d/draw.cpp*.
It is supposed to take the line from `aBegin` to `aEnd` and clip it against the `aTargetArea` rectangle (`Rect2F`, defined in *draw2d/rect.hpp*).

If the line requires clipping, update the `aBegin` and `aEnd` arguments to define the clipped line (i.e., the portion of the line inside the target area). The arguments are defined as non-const references, meaning this will change the passed-in values. The function should return true if the line is visible and false otherwise. You should not make any dynamic allocations (nor any system calls) in the clipping method.

**In your report:** 
- [ ] Explain your method for clipping (as a reminder: do not just dump code into your report). Be concise. If appropriate, use a figure to support your explanation.
#### 1.3 Drawing Lines (5 marks)
Next, consider the function `draw_line_solid` and the related `draw_clip_line_solid`. The functions are also declared in the draw2d/draw.{hpp,cpp} pair of files. The former is provided to you and simply calls `clip_line` and then -if visible- `draw_clip_line_solid`.

Implement the `draw_clip_line_solid` function. The goal is to produce a line that is as thin as possible (single pixel width) and that does not have any holes (i.e., each pixel should connect to another pixel either by nearest neighbours or by diagonals). Recall the parametrised version of a line as a starting point. You should ensure that the function produces correct results with all pre-clipped inputs. You may pick any drawing method, but it should scale with `O(N)`with respect to the number of drawn pixels`(N)`.

You should not make any dynamic allocations (nor any system calls) in the line drawing method.
The handed-out code contains two additional programs related to your line drawing. Use lines-sandbox
to visually verify your results in isolation. It includes a small number of examples already. You can switch
between the examples using the number keys. See source code comments for more information. You are free to add additional examples.

The second program, lines-test, runs a few automated tests on the line drawing. It uses the Catch2
testing library. Ensure that your implementation passes the existing tests. Refer to the source code for more information on the tests. With the line drawing in place, you should now be able to see a space ship (Figure 2a).

**In your report:** 
- [ ] Explain your line drawing method. Be concise. Focus on technical aspects. Use equations/figu res for support. A reader should be able to understand how your method works.  
- [x] Include a screenshot of the drawn ship.
