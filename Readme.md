# How to hide vertical divider lines between certain columns.


<p>This example demonstrates how to hide vertical grid lines for specific columns in GridControl. <br />
This functionality could be implemented in several ways:<br />
1. Hide all vertical lines using the GridView.OptionsView.ShowVertLines property, and explicitly drawing lines for certain cells by handling the GridView.CustomDrawCell event as described in the <a href="https://www.devexpress.com/Support/Center/p/A1018">How to draw a thick border for a grid cell</a> article.<br />
This approach allows painting only inside cell area but it does not allow to paint on grid lines area. As a result is some cases it looks inaccurate.<br />
2. Paint over vertical lines with the cell back color in the grid.Paint event handler. To obtain cells bounds and vertical lines positions could be used the GridViewInfo object that contain all information about visible GridView elements.</p><p></p>

<br/>


