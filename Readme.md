<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3647)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [ColumnLineHelper.cs](./CS/E3647/ColumnLineHelper.cs) (VB: [ColumnLineHelper.vb](./VB/E3647/ColumnLineHelper.vb))
* [Form1.cs](./CS/E3647/Form1.cs) (VB: [Form1.vb](./VB/E3647/Form1.vb))
* [Program.cs](./CS/E3647/Program.cs) (VB: [Program.vb](./VB/E3647/Program.vb))
<!-- default file list end -->
# How to hide vertical divider lines between certain columns.


<p>This example demonstrates how to hide vertical grid lines for specific columns in GridControl. <br />
This functionality could be implemented in several ways:<br />
1. Hide all vertical lines using the GridView.OptionsView.ShowVertLines property, and explicitly drawing lines for certain cells by handling the GridView.CustomDrawCell event as described in the <a href="https://www.devexpress.com/Support/Center/p/A1018">How to draw a thick border for a grid cell</a> article.<br />
This approach allows painting only inside cell area but it does not allow to paint on grid lines area. As a result is some cases it looks inaccurate.<br />
2. Paint over vertical lines with the cell back color in the grid.Paint event handler. To obtain cells bounds and vertical lines positions could be used the GridViewInfo object that contain all information about visible GridView elements.</p><p></p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-hide-vertical-lines-between-certain-columns&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-hide-vertical-lines-between-certain-columns&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
