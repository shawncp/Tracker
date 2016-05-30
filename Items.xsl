<?xml version="1.0" encoding="UTF-8" ?>
<stylesheet version="1.0" xmlns="http://www.w3.org/1999/XSL/Transform">
	<xsl:template match="/">
	<html>
	<body>
		<h2>Commons Issues Summary</h2>
		<table border="1">
		<tr bgcolor="#9acd32">
		<th align="left">Problem</th>
		<th align="left">Time</th>
		</tr>
		<xsl:for-each select="CommonsTracker">
		<tr>
		<td><xsl:value-of select="Problem"/></td>
		<td><xsl:value-of select="Date"/></td>
		</tr>
		</xsl:for-each>
		</table>
	</body>
	</html>
	</xsl:template>	
</stylesheet>

  