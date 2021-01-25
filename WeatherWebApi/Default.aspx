<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WeatherWebApi.Default" %>

<!DOCTYPE html PUBLIC "-//W3C/DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body {
            font-family: Arial;
            font-size: 10pt;
        }

        table {
            border: 1px solid #ccc;
            border-collapse: collapse;
        }

            table th {
                background-color: #F7F7F7;
                color: #333;
                font-weight: bold;
            }

            table th, table td {
                padding: 5px;
                border: 1px solid #ccc;
            }

            table, table table td {
                border: 0px solid #ccc;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="txtCity" runat="server" Text="" />
        <asp:Button ID="btnGetWeatherInformation" Text="Get Weather Information" runat="server" OnClick="GetWeatherInfo" />
        <asp:Button ID="btnGetWeatherForecast" Text="Get Weather Forecast" runat="server" OnClick="GetWeatherForecast" />
        <hr />
        <table id="tblWeather" runat="server" border="0" cellpadding="0" cellspasing="0" visible="false">
            <tr>
                <th colspan="2">Weather Information 
                </th>
            </tr>
            <tr>
                <td rowspan="3">
                    <asp:Image ID="imgWeatherIcon" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblCityAndCountry" runat="server" />
                    Date:
                    <asp:Label ID="lblDate" runat="server" />
                    Description:
                    <asp:Label ID="lblDescription" runat="server" />
                    Humidity:
                    <asp:Label ID="lblHumidity" runat="server" />
                    Wind:
                    <asp:Label ID="lblWind" runat="server" />
                    Clouds:
                    <asp:Label ID="lblClouds" runat="server" />
                </td>
            </tr>
            <tr>
                <td>Temperature:
                    Now:
                    <asp:Label ID="lblTempNow" runat="server" />
                    Feels like:
                    <asp:Label ID="lblTempFeelsLike" runat="server" />
                    Min:
                    <asp:Label ID="lblTempMin" runat="server" />
                    Max:
                    <asp:Label ID="lblTempMax" runat="server" />
                </td>
            </tr>
        </table>
        <hr />
        <table id="tblWeatherForecast" runat="server" border="0" cellpadding="0" cellspasing="0" visible="false">
            <tr>
                <td>
                    <asp:Label ID="lblCityForecast" runat="server" />
                    Weather Forecast:
                </td>
            </tr>
            <tr>
                <td>Day:
                    <asp:Label ID="lblDateForecast1" runat="server" /></td>
                <td>
                    <asp:Image ID="imgWeatherIconForecast1" runat="server" /></td>
                <td>Temperature:
                    <asp:Label ID="lblTempForecast1" runat="server" /></td>
                <td>Description:
                    <asp:Label ID="lblDescriptionForecast1" runat="server" /></td>
                <td>Wind:
                    <asp:Label ID="lblWindForecast1" runat="server" /></td>
                <td>Cloud:
                    <asp:Label ID="lblCloudForecast1" runat="server" /></td>
                <td>Humidity:
                    <asp:Label ID="lblHumidityForecast1" runat="server" /></td>
            </tr>
            <tr>
                <td>Day:
                    <asp:Label ID="lblDateForecast2" runat="server" /></td>
                <td>
                    <asp:Image ID="imgWeatherIconForecast2" runat="server" /></td>
                <td>Temperature:
                    <asp:Label ID="lblTempForecast2" runat="server" /></td>
                <td>Description:
                    <asp:Label ID="lblDescriptionForecast2" runat="server" /></td>
                <td>Wind:
                    <asp:Label ID="lblWindForecast2" runat="server" /></td>
                <td>Cloud:
                    <asp:Label ID="lblCloudForecast2" runat="server" /></td>
                <td>Humidity:
                    <asp:Label ID="lblHumidityForecast2" runat="server" /></td>

            </tr>
            <tr>
                <td>Day:
                    <asp:Label ID="lblDateForecast3" runat="server" /></td>
                <td>
                    <asp:Image ID="imgWeatherIconForecast3" runat="server" /></td>
                <td>Temperature:
                    <asp:Label ID="lblTempForecast3" runat="server" /></td>
                <td>Description:
                    <asp:Label ID="lblDescriptionForecast3" runat="server" /></td>
                <td>Wind:<asp:Label ID="lblWindForecast3" runat="server" /></td>
                <td>Cloud:
                    <asp:Label ID="lblCloudForecast3" runat="server" /></td>
                <td>Humidity:
                    <asp:Label ID="lblHumidityForecast3" runat="server" /></td>

            </tr>
            <tr>
                <td>Day:
                    <asp:Label ID="lblDateForecast4" runat="server" /></td>
                <td>
                    <asp:Image ID="imgWeatherIconForecast4" runat="server" /></td>
                <td>Temperature:
                    <asp:Label ID="lblTempForecast4" runat="server" /></td>
                <td>Description:
                    <asp:Label ID="lblDescriptionForecast4" runat="server" /></td>
                <td>Wind:<asp:Label ID="lblWindForecast4" runat="server" /></td>
                <td>Cloud:
                    <asp:Label ID="lblCloudForecast4" runat="server" /></td>
                <td>Humidity:
                    <asp:Label ID="lblHumidityForecast4" runat="server" /></td>

            </tr>
            <tr>
                <td>Day:
                    <asp:Label ID="lblDateForecast5" runat="server" /></td>
                <td>
                    <asp:Image ID="imgWeatherIconForecast5" runat="server" /></td>
                <td>Temperature:
                    <asp:Label ID="lblTempForecast5" runat="server" /></td>
                <td>Description:
                    <asp:Label ID="lblDescriptionForecast5" runat="server" /></td>
                <td>Wind:<asp:Label ID="lblWindForecast5" runat="server" /></td>
                <td>Cloud:
                    <asp:Label ID="lblCloudForecast5" runat="server" /></td>
                <td>Humidity:
                    <asp:Label ID="lblHumidityForecast5" runat="server" /></td>

            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
