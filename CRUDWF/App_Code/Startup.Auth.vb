Imports Owin
Imports Microsoft.Owin.Security.Cookies
Imports Microsoft.Owin.Security.Google
Imports Microsoft.Owin

Partial Public Class Startup
    ' Para obtener más información sobre cómo configurar la autenticación, visite https://go.microsoft.com/fwlink/?LinkId=301883
    Public Sub ConfigureAuth(app As IAppBuilder)
        ' Habilitar la aplicación para que use una cookie para almacenar la información del usuario que inició sesión
        ' y almacenar también información acerca de un usuario que inicie sesión con un proveedor de inicio de sesión de un tercero.
        ' Es obligatorio si la aplicación permite a los usuarios iniciar sesión
        app.UseCookieAuthentication(New CookieAuthenticationOptions() With {
        .AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
        .LoginPath = New PathString("/Account/Login")})
        app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie)

        ' Quitar las marcas de comentario de las líneas siguientes para habilitar el inicio de sesión con proveedores de inicio de sesión de terceros
        'app.UseMicrosoftAccountAuthentication(
        '    clientId:= "",
        '    clientSecret:= "")

        'app.UseTwitterAuthentication(
        '   consumerKey:= "",
        '   consumerSecret:= "")

        'app.UseFacebookAuthentication(
        '   appId:= "",
        '   appSecret:= "")

        'app.UseGoogleAuthentication(New GoogleOAuth2AuthenticationOptions() With {
        '   .ClientId = "",
        '   .ClientSecret = ""})
    End Sub
End Class
