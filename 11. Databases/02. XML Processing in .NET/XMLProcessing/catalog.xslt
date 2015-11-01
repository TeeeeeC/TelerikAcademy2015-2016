<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0"
    xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html>
      <body>
        <h1>Albums</h1>
        <table bgcolor="#E0E0E0" cellspacing="1">
          <tr bgcolor="#EEEEEE">
            <td>
              <b>Name</b>
            </td>
            <td>
              <b>Artist</b>
            </td>
            <td>
              <b>Year</b>
            </td>
            <td>
              <b>Producer</b>
            </td>
            <td>
              <b>Price</b>
            </td>
            <td>
              <b>Song</b>
            </td>
          </tr>
          <xsl:for-each select="/catalog/album">
            <tr bgcolor="white">
              <td>
                <xsl:value-of select="name"></xsl:value-of>
              </td>
              <td>
                <xsl:value-of select="artist"></xsl:value-of>
              </td>
              <td>
                <xsl:value-of select="year"></xsl:value-of>
              </td>
              <td>
                <xsl:value-of select="producer"></xsl:value-of>
              </td>
              <td>
                <xsl:value-of select="price"></xsl:value-of>
              </td>
              <td>
                <table bgcolor="#E0E0E0" cellspacing="1">
                  <tr bgcolor="#EEEEEE">
                    <td>
                      <b>Title</b>
                    </td>
                    <td>
                      <b>Duration</b>
                    </td>
                  </tr>

                  <xsl:for-each select="songs/song">
                    <tr bgcolor="white">
                      <td>
                        <xsl:value-of select="title"></xsl:value-of>
                      </td>
                      <td>
                        <xsl:value-of select="duration"></xsl:value-of>
                      </td>
                    </tr>
                  </xsl:for-each>
                </table>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>

