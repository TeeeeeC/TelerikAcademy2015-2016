<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0"
    xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html>
      <body>
        <h1>Students</h1>
        <table bgcolor="#E0E0E0" cellspacing="1">
          <tr bgcolor="#EEEEEE">
            <td>
              <b>Name</b>
            </td>
            <td>
              <b>Sex</b>
            </td>
            <td>
              <b>Birthdate</b>
            </td>
            <td>
              <b>Phone</b>
            </td>
            <td>
              <b>Email</b>
            </td>
            <td>
              <b>Course</b>
            </td>
            <td>
              <b>Specialty</b>
            </td>
            <td>
              <b>Faculty Number</b>
            </td>
            <td>
              <b>Exams Taken</b>
            </td>
          </tr>
          <xsl:for-each select="/students/student">
            <tr bgcolor="white">
              <td>
                <xsl:value-of select="name"></xsl:value-of>
              </td>
              <td>
                <xsl:value-of select="sex"></xsl:value-of>
              </td>
              <td>
                <xsl:value-of select="birthDate"></xsl:value-of>
              </td>
              <td>
                <xsl:value-of select="phone"></xsl:value-of>
              </td>
              <td>
                <xsl:value-of select="email"></xsl:value-of>
              </td>
              <td>
                <xsl:value-of select="course"></xsl:value-of>
              </td>
              <td>
                <xsl:value-of select="specialty"></xsl:value-of>
              </td>
              <td>
                <xsl:value-of select="facultyNumber"></xsl:value-of>
              </td>
              <td>
                <table bgcolor="#E0E0E0" cellspacing="1">
                  <tr bgcolor="#EEEEEE">
                    <td>
                      <b>Course Name</b>
                    </td>
                    <td>
                      <b>Tutor</b>
                    </td>
                    <td>
                      <b>Score</b>
                    </td>
                  </tr>
                
                  <xsl:for-each select="examsTaken/exam">
                  <tr bgcolor="white">
                    <td>
                      <xsl:value-of select="name"></xsl:value-of>
                    </td>
                    <td>
                      <xsl:value-of select="tutor"></xsl:value-of>
                    </td>
                    <td>
                      <xsl:value-of select="score"></xsl:value-of>
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
