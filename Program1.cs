using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MySelenium
{
    class Program1
    {
        IWebDriver driver;

        [SetUp]
            public void LaunchBrowser()
        {
            driver = new ChromeDriver("D:\\chromedriver");
        }

        [Test]
            public void Test()
        {
            driver.Navigate().GoToUrl("https://www.google.co.in");
            string ourl = "Google";
            //Console.WriteLine(ourl);
            driver.Manage().Window.Maximize();
            string pagetitle = driver.Title;
            //Console.WriteLine(pagetitle);
            if(pagetitle.Equals(ourl))
            {
                Console.WriteLine("Suceessfully opened the page!!!!");
                IWebElement element1 = driver.FindElement(By.Name("q"));
                if(element1.Enabled)
                {
                    string val = "Facebook Login";
                    element1.SendKeys(val);
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                   /* var wait = new WebDriverWait(driver, new TimeSpan(0,0,15));*/
                    element1.SendKeys(Keys.Enter);
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                    IWebElement result = driver.FindElement(By.ClassName("l"));
                       if(result.Enabled)
                    {
                         result.Click();
                         driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                         Console.WriteLine("Facebook Login Page Opened!!!");
                        IWebElement username = driver.FindElement(By.Id("email"));
                        IWebElement password = driver.FindElement(By.Id("pass"));
                        IWebElement loginbutton = driver.FindElement(By.Id("loginbutton"));
                        if(username.Enabled && password.Enabled)
                        {
                            username.SendKeys("bhattacharee.rahul125@gmail.com");
                            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                            password.SendKeys("Rahul@1995");
                            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                            loginbutton.Click();
                            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
                            IWebElement Homepage = driver.FindElement(By.ClassName("l9j0dhe7"));
                            if(Homepage.Enabled)
                            {
                                Console.WriteLine("Login Successfull!!!");
                                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                                IWebElement message = driver.FindElement(By.XPath("//body/div[@id='mount_0_0']/div/div/div/div/div/div[3]/span//*[local-name()='svg']"));
                                if (message.Enabled)
                                {
                                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                                    message.Click();
                                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
                                    Console.WriteLine("Message Box Clicked!!!");
                                    IWebElement user = driver.FindElement(By.CssSelector("body._6s5d._71pn._-kb.segoe:nth-child(2) div.n7fi1qx3.hv4rvrfc.b3onmgus.poy2od1o.kr520xx4.ehxjyohh div.j34wkznp.qp9yad78.pmk7jnqg.kr520xx4:nth-child(1) div.iqfcb0g7.tojvnm2t.a6sixzi8.k5wvi7nf.q3lfd5jv.pk4s997a.bipmatt0.cebpdrjk.qowsmv63.owwhemhu.dp1hu0rb.dhp61c6y.l9j0dhe7.iyyx5f41.a8s20v7p:nth-child(1) div.oi9244e8.knvmm38d div.l9j0dhe7 div.cwj9ozl2.ue3kfks5.pw54ja7n.uo3d90p7.l82x9zwi.nwpbqux9.rq0escxv.jgsskzai.ni8dbmo4.stjgntxs div.o36gj0jk div.dbpd2lw6.l9j0dhe7.stjgntxs.ni8dbmo4.lzcic4wl.idiwt2bm div.kr520xx4.pedkr2u6.pmk7jnqg.j9ispegn.ms05siws.pnx7fd3z.b7h9ocf4 div.j83agx80.cbu4d94t.h77mwsce.dp1hu0rb.o36gj0jk.h58bhtfz div.q5bimw55.ofs802cu.dkue75c7.mb9wzai9.o8kakjsu.rpm2j7zs.k7i0oixp.gvuykj2m.j83agx80.cbu4d94t.ni8dbmo4.eg9m0zos.buofh1pr.l56l04vs.r57mb794.l9j0dhe7.kh7kg01d.c3g1iek1.k4xni2cv div.a8s20v7p.k5wvi7nf.buofh1pr.pfnyh3mw.l9j0dhe7.du4w35lb div.l9j0dhe7:nth-child(2) a.oajrlxb2.gs1a9yip.g5ia77u1.mtkw9kbi.tlpljxtp.qensuy8j.ppp5ayq2.goun2846.ccm00jje.s44p3ltw.mk2mc5f4.rt8b4zig.n8ej3o3l.agehan2d.sk4xxmp2.rq0escxv.nhd2j8a9.a8c37x1j.mg4g778l.btwxx1t3.pfnyh3mw.p7hjln8o.kvgmc6g5.cxmmr5t8.oygrvhab.hcukyx3x.tgvbjcpo.hpfvmrgz.jb3vyjys.rz4wbd8a.qt6c0cv9.a8nywdso.l9j0dhe7.i1ao9s8h.esuyzwwr.f1sip0of.du4w35lb.lzcic4wl.abiwlrkh.p8dawk7l.ue3kfks5.pw54ja7n.uo3d90p7.l82x9zwi div.ow4ym5g4.auili1gw.rq0escxv.j83agx80.buofh1pr.g5gj957u.i1fnvgqd.oygrvhab.cxmmr5t8.hcukyx3x.kvgmc6g5.nnctdnn4.hpfvmrgz.qt6c0cv9.jb3vyjys.l9j0dhe7.du4w35lb.bp9cbjyn.btwxx1t3.dflh9lhu.scb9dxdr div.ow4ym5g4.auili1gw.rq0escxv.j83agx80.buofh1pr.g5gj957u.i1fnvgqd.oygrvhab.cxmmr5t8.hcukyx3x.kvgmc6g5.tgvbjcpo.hpfvmrgz.qt6c0cv9.rz4wbd8a.a8nywdso.jb3vyjys.du4w35lb.bp9cbjyn.btwxx1t3.l9j0dhe7 div.gs1a9yip.ow4ym5g4.auili1gw.rq0escxv.j83agx80.cbu4d94t.buofh1pr.g5gj957u.i1fnvgqd.oygrvhab.cxmmr5t8.hcukyx3x.kvgmc6g5.tgvbjcpo.hpfvmrgz.rz4wbd8a.a8nywdso.l9j0dhe7.du4w35lb.rj1gh0hx.f10w8fjw.pybr56ya div.j83agx80.cbu4d94t.ew0dbk1b.irj2b8pg div.qzhwtbm6.knvmm38d:nth-child(2) span.oi732d6d.ik7dh3pa.d2edcug0.qv66sw1b.c1et5uql.a8c37x1j.hop8lmos.enqfppq2.e9vueds3.j5wam9gi.knj5qynh.m9osqain.hzawbc8m.ni8dbmo4.stjgntxs.ltmttdrg.g0qnabr5 div.j83agx80 > span.oi732d6d.ik7dh3pa.d2edcug0.qv66sw1b.c1et5uql.e9vueds3.j5wam9gi.knj5qynh.m9osqain.a8c37x1j.ni8dbmo4.stjgntxs.ltmttdrg.g0qnabr5"));
                                    if(user.Enabled)
                                    {
                                        user.Click();
                                        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                                        Console.WriteLine("User Clicked Successfully!!!!");
                                        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                                        String Msg = "This is an Automated System Generated Msg!!!! Sent By: Rahul Bhattacharjee";
                                        IWebElement msgbox = driver.FindElement(By.XPath("//div[@id='mount_0_0']//div//div//div//div//div//div//div//div//div//div//div//div//div//div//div//form//div//div//div//div//div//div//div//div//div//div//div//div//div"));
                                        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
                                        msgbox.SendKeys(Msg);
                                        IWebElement sendbuttn = driver.FindElement(By.XPath("//*[name()='path' and contains(@d,'M16.691502')]"));
                                        if(sendbuttn.Enabled)
                                        {
                                            sendbuttn.Submit();
                                            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                                            Console.WriteLine("Msg Sent to User Successfully!!!");
                                            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Msg Sending Failed!!!");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("User Click Failed!!!!");
                                    }
                                }

                                else
                                {
                                    Console.WriteLine("Failed to Open Chat!!!");
                                }

                            }
                            else
                            {
                                Console.WriteLine("Login Failed!!!!");
                            }

                        }
                    }
                       else
                    {
                        Console.WriteLine("Facebook Login Failed!!!");
                    }
                }

            }
            
        }

        [TearDown]
            
            public void CloseBrowser()
        {
            driver.Close(); 
        }
    }
}
