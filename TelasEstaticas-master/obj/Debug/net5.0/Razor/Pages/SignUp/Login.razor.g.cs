#pragma checksum "D:\Users\bella\source\repos\TelasEstaticas-master (1)\TelasEstaticas-master\Pages\SignUp\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57dbd4c89c19c11f97964b2d39f044ec242b1da6"
// <auto-generated/>
#pragma warning disable 1591
namespace ScreensWeDancin.Pages.SignUp
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Users\bella\source\repos\TelasEstaticas-master (1)\TelasEstaticas-master\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\bella\source\repos\TelasEstaticas-master (1)\TelasEstaticas-master\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Users\bella\source\repos\TelasEstaticas-master (1)\TelasEstaticas-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Users\bella\source\repos\TelasEstaticas-master (1)\TelasEstaticas-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Users\bella\source\repos\TelasEstaticas-master (1)\TelasEstaticas-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Users\bella\source\repos\TelasEstaticas-master (1)\TelasEstaticas-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Users\bella\source\repos\TelasEstaticas-master (1)\TelasEstaticas-master\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Users\bella\source\repos\TelasEstaticas-master (1)\TelasEstaticas-master\_Imports.razor"
using ScreensWeDancin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Users\bella\source\repos\TelasEstaticas-master (1)\TelasEstaticas-master\_Imports.razor"
using ScreensWeDancin.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Users\bella\source\repos\TelasEstaticas-master (1)\TelasEstaticas-master\_Imports.razor"
using ScreensWeDancin.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Users\bella\source\repos\TelasEstaticas-master (1)\TelasEstaticas-master\_Imports.razor"
using WeDancin.Frontend.Customers.Data.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Users\bella\source\repos\TelasEstaticas-master (1)\TelasEstaticas-master\_Imports.razor"
using WeDancin.Domain.Interfaces.Accounts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\bella\source\repos\TelasEstaticas-master (1)\TelasEstaticas-master\Pages\SignUp\Login.razor"
using WeDancin.Domain.Entities.Accounts;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    /* || PAGE LAYOUT STYLES */
    .espaco-cadastro {
        display: flex;
        flex-direction: column;
        flex-wrap: nowrap;
        align-items: center;
        position: relative;
        bottom: 28px;
        height: 557px;
        width: 461px;
        margin: auto;
        z-index: 3;
    }

    .form-floating {
        margin: 20px auto;
    }
</style>

");
            __builder.AddMarkupContent(1, @"<header><img src=""/images/Lines/sign-up.svg"" alt=""Linhas orgânicas coloridas"" style=""position: absolute; left: 0; top: -2px; z-index: 1;"">
    <div style=""display: block; text-align: center; position: relative; z-index: 3;""><img src=""/images/Brand/Logo.svg"" alt=""Logo We Dancin"" style=""margin-top: 35px; margin-bottom: 77px;""></div></header>

");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "espaco-cadastro");
            __builder.AddMarkupContent(4, "<section><h3 style=\"margin: 16px 0; text-align: center;\">Login</h3></section>");
#nullable restore
#line 44 "D:\Users\bella\source\repos\TelasEstaticas-master (1)\TelasEstaticas-master\Pages\SignUp\Login.razor"
     if (erro)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "alert alert-danger");
            __builder.AddAttribute(7, "role", "alert");
            __builder.AddContent(8, 
#nullable restore
#line 47 "D:\Users\bella\source\repos\TelasEstaticas-master (1)\TelasEstaticas-master\Pages\SignUp\Login.razor"
             message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 49 "D:\Users\bella\source\repos\TelasEstaticas-master (1)\TelasEstaticas-master\Pages\SignUp\Login.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "section");
            __builder.AddAttribute(10, "style", "display: flex; flex-direction: column;");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(11);
            __builder.AddAttribute(12, "class", "form-signin");
            __builder.AddAttribute(13, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 52 "D:\Users\bella\source\repos\TelasEstaticas-master (1)\TelasEstaticas-master\Pages\SignUp\Login.razor"
                                              userLogin

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 52 "D:\Users\bella\source\repos\TelasEstaticas-master (1)\TelasEstaticas-master\Pages\SignUp\Login.razor"
                                                                         HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "form-floating");
                __builder2.OpenElement(18, "input");
                __builder2.AddAttribute(19, "type", "email");
                __builder2.AddAttribute(20, "class", "form-control on-surface active-placeholder");
                __builder2.AddAttribute(21, "id", "floatingInput");
                __builder2.AddAttribute(22, "placeholder", "name@example.com");
                __builder2.AddAttribute(23, "autocomplete", "off");
                __builder2.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 54 "D:\Users\bella\source\repos\TelasEstaticas-master (1)\TelasEstaticas-master\Pages\SignUp\Login.razor"
                                                                                              userLogin.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userLogin.Email = __value, userLogin.Email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n                ");
                __builder2.AddMarkupContent(27, "<label for=\"floatingInput\">E-mail</label>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n            ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "form-floating");
                __builder2.AddAttribute(31, "style", "margin-top: 20px;");
                __builder2.OpenElement(32, "input");
                __builder2.AddAttribute(33, "type", "password");
                __builder2.AddAttribute(34, "class", "form-control on-surface active-placeholder");
                __builder2.AddAttribute(35, "id", "floatingPassword");
                __builder2.AddAttribute(36, "placeholder", "Crie sua senha");
                __builder2.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 58 "D:\Users\bella\source\repos\TelasEstaticas-master (1)\TelasEstaticas-master\Pages\SignUp\Login.razor"
                                                                                                 userLogin.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userLogin.Password = __value, userLogin.Password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n                ");
                __builder2.AddMarkupContent(40, "<label for=\"floatingPassword\">Digite sua senha</label>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n            ");
                __builder2.AddMarkupContent(42, "<div style=\"display: flex; flex-direction: column; align-items: center;\"><button class=\"dark-purple-button long-button\" style=\"width: 461px;\">Entrar</button></div>\r\n            ");
                __builder2.AddMarkupContent(43, "<div style=\"margin: 16px 5px;\"><p class=\"under-text\" style=\"letter-spacing: -0.02em; text-align: center;\"><a href=\"#\">Esqueci minha senha</a></p></div>\r\n            ");
                __builder2.AddMarkupContent(44, @"<div style=""margin: 16px 5px;""><p class=""body-text"" style=""text-align: center;"">Ao continuar, você concorda com os <a href=""#"" style=""color: #1877F2;"">Termos de Serviço da WeDancin</a> e <a href=""#"" style=""color: #1877F2;"">Políticas de Privacidade</a>.</p></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.AddMarkupContent(46, "<div style=\"margin-top: 14px;\"><p class=\"body-text\" style=\"text-align: center; font-weight: 700\">Não possui uma conta? <a href=\"signup\" style=\"color: #1877F2;\">Cadastre-se.</a></p></div>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "D:\Users\bella\source\repos\TelasEstaticas-master (1)\TelasEstaticas-master\Pages\SignUp\Login.razor"
      
    private UserLogin userLogin = new UserLogin();
    private bool erro = false;
    private string message = string.Empty;

    private async Task HandleValidSubmit()
    {
        try
        {
            var login = await _userRepository.LoginAsync(userLogin);

            if (login.result != null)
            {

                var user = _userRepository.UserRepositoryLoginMiddleware(login.result);

                if (login != null)
                {
                    await _localStorage.SetItem<UserLoginViewModel>("wedancin", user);

                    _navigationManager.NavigateTo("/");
                }
            }
            else
            {
                erro = true;
                message = login.Message;
            }
        }
        catch (Exception ex)
        {
            throw;
        }

    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserRepository _userRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService _localStorage { get; set; }
    }
}
#pragma warning restore 1591