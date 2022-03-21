/**************************************************************
 *    This file is part of Cipher Scanner, an GUI for SaltwaterTaffy nmap wrapper library
 *    Released under the GNU GPLv2 or any later version
 *    Author: ivan1292 <it.email365@gmail.com>
 *    Date: 2022
***************************************************************/

/**************************************************************
 *    This file contains code of SaltwaterTaffy, an nmap wrapper library for .NET
 *    Released under the GNU GPLv2 or any later version
 *    Author: Thom Dixon <thom@thomdixon.org>
 *    Date: 2013
***************************************************************/
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaltwaterTaffy;
using SaltwaterTaffy.Container;

namespace CipherScannerApp
{
    public partial class CipherForm : Form
    {
        ///<summary>Ports used for scanning need to be declared in _ports variable</summary>
        private string _ports;
        
        /// <summary>Here goes target IP/Domain name.</summary>
        private Target _target;
        
        /// <summary>Used for new line, instead of \n</summary>
        private readonly string _nl = Environment.NewLine;

        public CipherForm()
        {
            InitializeComponent();
            //profile box items
            profileBox.Items.Add("FTP-SMTP-HTTP(s)");
            profileBox.Items.Add("SSH");
            profileBox.Items.Add("Minecraft");
            profileBox.Items.Add("Default");
            profileBox.Items.Add("Null");
            profileBox.Items.Add("Fin");
            profileBox.Items.Add("Xmas");
            profileBox.Items.Add("Syn");
            profileBox.Items.Add("Connect");
            profileBox.Items.Add("Ack");
            profileBox.Items.Add("Window");
            profileBox.Items.Add("Maimon");
            profileBox.Items.Add("SctpInit");
            profileBox.Items.Add("SctpCookieEcho");
            profileBox.Items.Add("Udp");
            profileBox.Items.Add("MC-Auto");
            //speed box items
            speedBox.Items.Add("Fastest Scan");
            speedBox.Items.Add("Fast Scan (Recommended)");
            speedBox.Items.Add("Normal Scan");
            speedBox.Items.Add("Slow Scan");
            speedBox.Items.Add("Slowest Scan");
            //auto setup items
            autoBox.Items.Add("Default");
            autoBox.Items.Add("FTP-SMTP-HTTP(s)");
            autoBox.Items.Add("SSH");
            autoBox.Items.Add("Minecraft");
            //loading bar/loading label
            LoadLoop(false);
        }
        
        #region Buttons
        //Scan button.
        private async void btnScan_Click(object sender, EventArgs e)
        {
            LoadLoop(true);
            
            if (resultBox.TextLength > 0)
                resultBox.Clear();

            if (!string.IsNullOrEmpty(profileBox.Text) || !string.IsNullOrEmpty(txtIP.Text) || !string.IsNullOrEmpty((speedBox.SelectedItem == null).ToString()))
            {
                if (ReferenceEquals(profileBox.SelectedItem.ToString(), "FTP-SMTP-HTTP(s)"))
                    await Task.Run(FSHScan);
                else if (ReferenceEquals(profileBox.SelectedItem.ToString(), "SSH"))
                    await Task.Run(SSHScan);
                else if (ReferenceEquals(profileBox.SelectedItem.ToString(), "MC-Auto"))
                {
                    txtPort.Enabled = false;
                    await Task.Run(MinecraftScan);
                }
                else if (ReferenceEquals(profileBox.SelectedItem.ToString(), "Minecraft"))
                {
                    PortsMissing();
                    txtPort.Enabled = true;
                    var cPorts = txtPort.Text;
                    await Task.Run(() => MinecraftScan(cPorts));
                }
                else if (ReferenceEquals(profileBox.SelectedItem.ToString(), "Default"))
                {
                    PortsMissing();
                    txtPort.Enabled = true;
                    var cPorts = txtPort.Text;
                    await Task.Run(() => DefaultScan(cPorts));
                }
                else if (ReferenceEquals(profileBox.SelectedItem.ToString(), "Null"))
                {
                    PortsMissing();
                    txtPort.Enabled = true;
                    var cPorts = txtPort.Text;
                    await Task.Run(() => NullScan(cPorts));
                }
                else if (ReferenceEquals(profileBox.SelectedItem.ToString(), "Fin"))
                {
                    PortsMissing();
                    txtPort.Enabled = true;
                    var cPorts = txtPort.Text;
                    await Task.Run(() => FinScan(cPorts));
                }
                else if (ReferenceEquals(profileBox.SelectedItem.ToString(), "Xmas"))
                {
                    PortsMissing();
                    txtPort.Enabled = true;
                    var cPorts = txtPort.Text;
                    await Task.Run(() => XmasScan(cPorts));
                }
                else if (ReferenceEquals(profileBox.SelectedItem.ToString(), "Syn"))
                {
                    PortsMissing();
                    txtPort.Enabled = true;
                    var cPorts = txtPort.Text;
                    await Task.Run(() => SynScan(cPorts));
                }
                else if (ReferenceEquals(profileBox.SelectedItem.ToString(), "Connect"))
                {
                    PortsMissing();
                    txtPort.Enabled = true;
                    var cPorts = txtPort.Text;
                    await Task.Run(() => ConnectScan(cPorts));
                }
                else if (ReferenceEquals(profileBox.SelectedItem.ToString(), "Ack"))
                {
                    PortsMissing();
                    txtPort.Enabled = true;
                    var cPorts = txtPort.Text;
                    await Task.Run(() => AckScan(cPorts));
                }
                else if (ReferenceEquals(profileBox.SelectedItem.ToString(), "Window"))
                {
                    PortsMissing();
                    txtPort.Enabled = true;
                    var cPorts = txtPort.Text;
                    await Task.Run(() => WindowScan(cPorts));
                }
                else if (ReferenceEquals(profileBox.SelectedItem.ToString(), "Maimon"))
                {
                    PortsMissing();
                    txtPort.Enabled = true;
                    var cPorts = txtPort.Text;
                    await Task.Run(() => MaimonScan(cPorts));
                }
                else if (ReferenceEquals(profileBox.SelectedItem.ToString(), "SctpInit"))
                {
                    PortsMissing();
                    txtPort.Enabled = true;
                    var cPorts = txtPort.Text;
                    await Task.Run(() => SctpInitScan(cPorts));
                }
                else if (ReferenceEquals(profileBox.SelectedItem.ToString(), "SctpCookieEcho"))
                {
                    PortsMissing();
                    txtPort.Enabled = true;
                    var cPorts = txtPort.Text;
                    await Task.Run(() => SctpCookieEchoMethod(cPorts));
                }
                else if (ReferenceEquals(profileBox.SelectedItem.ToString(), "Udp"))
                {
                    PortsMissing();
                    txtPort.Enabled = true;
                    var cPorts = txtPort.Text;
                    await Task.Run(() => UdpScan(cPorts));
                }
            }
            else
            {
                LoadLoop(false);
                MessageBox.Show(@"Error! Please check if:" + _nl + @"1. IP is missing." + _nl + @"2. Profile is selected." + _nl + @"3. Speed is selected.");
            }
        }

        //Reset button
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetFunction();
        }
        
        // Cancel Button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }
        
        // Auto setup submit button.
        private void autoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (autoBox.SelectedItem.ToString() == @"SSH")
            {
                resultBox.Clear();
                //btnCancel.Enabled = false;
                txtPort.Clear();
                txtPort.Enabled = false;
                LoadLoop(false);
                profileBox.SelectedItem = @"SSH";
                speedBox.SelectedItem = @"Fastest Scan";
            }
            else if (autoBox.SelectedItem.ToString() == @"FTP-SMTP-HTTP(s)")
            {
                resultBox.Clear();
                //btnCancel.Enabled = false;
                txtPort.Clear();
                txtPort.Enabled = false;
                LoadLoop(false);
                profileBox.SelectedItem = @"FTP-SMTP-HTTP(s)";
                speedBox.SelectedItem = @"Fastest Scan";
            }
            else if (autoBox.SelectedItem.ToString() == @"Minecraft")
            {
                resultBox.Clear();
                //btnCancel.Enabled = false;
                txtPort.Clear();
                txtPort.Enabled = false;
                LoadLoop(false);
                profileBox.SelectedItem = @"MC-Auto";
                speedBox.SelectedItem = @"Fastest Scan";
            }
            else if (autoBox.SelectedItem.ToString() == @"Default")
            {
                ResetFunction();
            }
        }
        #endregion
        
        #region OtherFunctions
        // Toggles loading loop progress bar and label
        public static void LoadLoop(bool isOn)
        {
            loadingBar.Visible = isOn;
            lblLoading.Visible = isOn;
        }

        private void ResetFunction()
        {
            txtIP.Clear();
            txtPort.Clear();
            resultBox.Clear();
            //btnCancel.Enabled = false;
            btnScan.Enabled = true;
            txtPort.Enabled = true;
            profileBox.SelectedItem = null;
            speedBox.SelectedItem = null;
            autoBox.SelectedItem = @"Default";
            LoadLoop(false);
            Refresh();
        }
        // Scan types that are not automatic need ports from user.
        private void PortsMissing()
        {
            if (string.IsNullOrEmpty(txtPort.Text))
            {
                LoadLoop(false);
                MessageBox.Show(@"Error! Ports are missing from the PORT Text box.");
            }
        }
        #endregion
        /// <summary>
        ///     Method that does the Scanning part.
        /// </summary>
        /// <param name="customScanner">Does scanning and gives results using given Scan type, ports and flags.</param>
        /// <param name="customType">Scan Type you would like to use for Scan Profile. Example: ScanType.Default</param>
        /// <param name="customFlags">For additional NMAP Flags in Scanning Profiles</param>
        /// <param name="addPorts">Ports that will be used for scanning</param>
        private void Scan(Scanner customScanner, ScanType customType, NmapFlag customFlags, string addPorts)
        {
            //Refresh();
            _target = new Target(txtIP.Text);
            customScanner = new Scanner(_target);

            bool isAlive = true;

            //Nmap Options will change depending which speed has been chosen:
            if (speedBox.SelectedItem.ToString() == @"Fastest Scan")
            {
                customScanner.PersistentOptions = new NmapOptions
                {
                    NmapFlag.InsaneTiming, NmapFlag.Open, customFlags
                };

                var scanResult = customScanner.PortScan(customType, addPorts);
                
                resultBox.Text += $"Initializing scan of {_target} using {profileBox.Text} profile..." + _nl;
                resultBox.Text += $"Detected {scanResult.Total} host(s), {scanResult.Up} up, and {scanResult.Down} down" + _nl;

                if (scanResult.Up == 0)
                {
                    resultBox.Text += $"Since there is {scanResult.Up} host(s) alive, scan has been stopped.";
                    isAlive = false;
                    LoadLoop(false);
                }
                else if (scanResult.Up > 0)
                {
                    while (isAlive)
                    {
                        foreach (Host i in scanResult.Hosts)
                        {
                            resultBox.Text += _nl + $"Host: {i.Address}";
                            
                            foreach (Port j in i.Ports)
                            {
                                if (!string.IsNullOrEmpty(j.Service.Name) && !string.IsNullOrEmpty(j.PortNumber.ToString()))
                                    resultBox.Text += _nl + $"PORT: {j.PortNumber} is running {j.Service.Name}" + _nl + $"VER: {j.Service.Version}" + _nl;

                                else if (j.Filtered)
                                    resultBox.Text += _nl + $"PORT: {j.PortNumber} is filtered" + _nl;
                            }

                            if (i.OsMatches.Any())
                                resultBox.Text += _nl + "Operating System: " + i.OsMatches.First().Name;
                        }

                        isAlive = false;
                        LoadLoop(false);
                        resultBox.Text += _nl + "-----------------------" + _nl + "SCANNING FINISHED" + _nl + "-----------------------";
                        MessageBox.Show(@"Task completed successfully.");
                    }
                }
            }
            else if (speedBox.SelectedItem.ToString() == @"Fast Scan (Recommended)")
            {
                customScanner.PersistentOptions = new NmapOptions
                {
                    NmapFlag.AggressiveTiming, NmapFlag.Open, customFlags
                };

                var scanResult = customScanner.PortScan(customType, addPorts);

                resultBox.Text += $"Initializing scan of {_target} using {profileBox.Text} profile..." + _nl;
                resultBox.Text += $"Detected {scanResult.Total} host(s), {scanResult.Up} up, and {scanResult.Down} down" + _nl;

                if (scanResult.Up == 0)
                {
                    resultBox.Text += $"Since there is {scanResult.Up} host(s) alive, scan has been stopped.";
                    isAlive = false;
                    LoadLoop(false);
                }
                else if (scanResult.Up > 0)
                {
                    while (isAlive)
                    {
                        foreach (Host i in scanResult.Hosts)
                        {
                            resultBox.Text += _nl + $"Host: {i.Address}";
                            
                            foreach (Port j in i.Ports)
                            {
                                if (!string.IsNullOrEmpty(j.Service.Name) && !string.IsNullOrEmpty(j.PortNumber.ToString()))
                                    resultBox.Text += _nl + $"PORT: {j.PortNumber} is running {j.Service.Name}" + _nl + $"VER: {j.Service.Version}" + _nl;

                                else if (j.Filtered)
                                    resultBox.Text += _nl + $"PORT: {j.PortNumber} is filtered" + _nl;
                            }

                            if (i.OsMatches.Any())
                                resultBox.Text += _nl + "Operating System: " + i.OsMatches.First().Name;
                        }

                        isAlive = false;
                        LoadLoop(false);
                        resultBox.Text += _nl + "-----------------------" + _nl + "SCANNING FINISHED" + _nl + "-----------------------";
                        MessageBox.Show(@"Task completed successfully.");
                    }
                }
            }
            else if (speedBox.SelectedItem.ToString() == @"Normal Scan")
            {
                customScanner.PersistentOptions = new NmapOptions
                {
                    NmapFlag.NormalTiming, NmapFlag.Open, customFlags
                };

                var scanResult = customScanner.PortScan(customType, addPorts);

                resultBox.Text += $"Initializing scan of {_target} using {profileBox.Text} profile..." + _nl;
                resultBox.Text += $"Detected {scanResult.Total} host(s), {scanResult.Up} up, and {scanResult.Down} down" + _nl;

                if (scanResult.Up == 0)
                {
                    resultBox.Text += $"Since there is {scanResult.Up} host(s) alive, scan has been stopped.";
                    isAlive = false;
                    LoadLoop(false);
                }
                else if (scanResult.Up > 0)
                {
                    while (isAlive)
                    {
                        foreach (Host i in scanResult.Hosts)
                        {
                            resultBox.Text += _nl + $"Host: {i.Address}";
                            
                            foreach (Port j in i.Ports)
                            {
                                if (!string.IsNullOrEmpty(j.Service.Name) && !string.IsNullOrEmpty(j.PortNumber.ToString()))
                                    resultBox.Text += _nl + $"PORT: {j.PortNumber} is running {j.Service.Name}" + _nl + $"VER: {j.Service.Version}" + _nl;

                                else if (j.Filtered)
                                    resultBox.Text += _nl + $"PORT: {j.PortNumber} is filtered" + _nl;
                            }

                            if (i.OsMatches.Any())
                                resultBox.Text += _nl + "Operating System: " + i.OsMatches.First().Name;
                        }

                        isAlive = false;
                        LoadLoop(false);
                        resultBox.Text += _nl + "-----------------------" + _nl + "SCANNING FINISHED" + _nl + "-----------------------";
                        MessageBox.Show(@"Task completed successfully.");
                    }
                }
            }
            else if (speedBox.SelectedItem.ToString() == @"Slow Scan")
            {
                customScanner.PersistentOptions = new NmapOptions
                {
                    NmapFlag.PoliteTiming, NmapFlag.Open, customFlags
                };

                var scanResult = customScanner.PortScan(customType, addPorts);

                resultBox.Text += $"Initializing scan of {_target} using {profileBox.Text} profile..." + _nl;
                resultBox.Text += $"Detected {scanResult.Total} host(s), {scanResult.Up} up, and {scanResult.Down} down" + _nl;

                if (scanResult.Up == 0)
                {
                    resultBox.Text += $"Since there is {scanResult.Up} host(s) alive, scan has been stopped.";
                    isAlive = false;
                    LoadLoop(false);
                }
                else if (scanResult.Up > 0)
                {
                    while (isAlive)
                    {
                        foreach (Host i in scanResult.Hosts)
                        {
                            resultBox.Text += _nl + $"Host: {i.Address}";
                            
                            foreach (Port j in i.Ports)
                            {
                                if (!string.IsNullOrEmpty(j.Service.Name) && !string.IsNullOrEmpty(j.PortNumber.ToString()))
                                    resultBox.Text += _nl + $"PORT: {j.PortNumber} is running {j.Service.Name}" + _nl + $"VER: {j.Service.Version}" + _nl;

                                else if (j.Filtered)
                                    resultBox.Text += _nl + $"PORT: {j.PortNumber} is filtered" + _nl;
                            }

                            if (i.OsMatches.Any())
                                resultBox.Text += _nl + "Operating System: " + i.OsMatches.First().Name;
                        }

                        isAlive = false;
                        LoadLoop(false);
                        resultBox.Text += _nl + "-----------------------" + _nl + "SCANNING FINISHED" + _nl + "-----------------------";
                        MessageBox.Show(@"Task completed successfully.");
                    }
                }
            }
            else if (speedBox.SelectedItem.ToString() == @"Slowest Scan")
            {
                customScanner.PersistentOptions = new NmapOptions
                {
                    NmapFlag.ParanoidTiming, NmapFlag.Open, customFlags
                };

                var scanResult = customScanner.PortScan(customType, addPorts);

                resultBox.Text += $"Initializing scan of {_target} using {profileBox.Text} profile..." + _nl;
                resultBox.Text += $"Detected {scanResult.Total} host(s), {scanResult.Up} up, and {scanResult.Down} down" + _nl;

                if (scanResult.Up == 0)
                {
                    resultBox.Text += $"Since there is {scanResult.Up} host(s) alive, scan has been stopped.";
                    isAlive = false;
                    LoadLoop(false);
                }
                else if (scanResult.Up > 0)
                {
                    while (isAlive)
                    {
                        foreach (Host i in scanResult.Hosts)
                        {
                            resultBox.Text += _nl + $"Host: {i.Address}";
                            
                            foreach (Port j in i.Ports)
                            {
                                if (!string.IsNullOrEmpty(j.Service.Name) && !string.IsNullOrEmpty(j.PortNumber.ToString()))
                                    resultBox.Text += _nl + $"PORT: {j.PortNumber} is running {j.Service.Name}" + _nl + $"VER: {j.Service.Version}" + _nl;

                                else if (j.Filtered)
                                    resultBox.Text += _nl + $"PORT: {j.PortNumber} is filtered" + _nl;
                            }

                            if (i.OsMatches.Any())
                                resultBox.Text += _nl + "Operating System: " + i.OsMatches.First().Name;
                        }

                        isAlive = false;
                        LoadLoop(false);
                        resultBox.Text += _nl + "-----------------------" + _nl + "SCANNING FINISHED" + _nl + "-----------------------";
                        MessageBox.Show(@"Task completed successfully.");
                    }
                }
            }
            else
            {
                MessageBox.Show(@"Error! Please select Scan Speed in profile.");
            }

            /*if (isAlive)
            {
                btnCancel.Enabled = true;
                btnScan.Enabled = false;
            } */
        }

        #region ScanTypes
        //Default Scan
        private void DefaultScan(string customPorts)
        {
            var defaultScanner = new Scanner(_target); 
            var defaultType = ScanType.Default; 
            var defaultFlag = NmapFlag.HostScan;
            
            Scan(defaultScanner, defaultType, defaultFlag, customPorts);
        }
        
        // TCP Scans
        private void NullScan(string customPorts)
        {
            var nullScanner = new Scanner(_target); 
            var nullType = ScanType.Null; 
            var nullFlag = NmapFlag.TcpNullScan;
            
            Scan(nullScanner, nullType, nullFlag, customPorts);
        }
        
        private void FinScan(string customPorts)
        {
            var finScanner = new Scanner(_target); 
            var finType = ScanType.Fin; 
            var finFlag = NmapFlag.FinScan;
            
            Scan(finScanner, finType, finFlag, customPorts);
        }
        
        private void XmasScan(string customPorts)
        {
            var xmasScanner = new Scanner(_target); 
            var xmasType = ScanType.Xmas; 
            var xmasFlag = NmapFlag.XmasScan;
            
            Scan(xmasScanner, xmasType, xmasFlag, customPorts);
        }
        
        private void SynScan(string customPorts)
        {
            var synScanner = new Scanner(_target); 
            var synType = ScanType.Syn; 
            var synFlag = NmapFlag.TcpSynScan;
            
            Scan(synScanner, synType, synFlag, customPorts);
        }
        
        private void ConnectScan(string customPorts)
        {
            var connectScanner = new Scanner(_target); 
            var connectType = ScanType.Connect; 
            var connectFlag = NmapFlag.ConnectScan;
            
            Scan(connectScanner, connectType, connectFlag, customPorts);
        }
        
        private void AckScan(string customPorts)
        {
            var ackScanner = new Scanner(_target); 
            var ackType = ScanType.Ack; 
            var ackFlag = NmapFlag.AckScan;
            
            Scan(ackScanner, ackType, ackFlag, customPorts);
        }
        
        private void WindowScan(string customPorts)
        {
            var windowScanner = new Scanner(_target); 
            var windowType = ScanType.Window; 
            var windowFlag = NmapFlag.WindowScan;
            
            Scan(windowScanner, windowType, windowFlag, customPorts);
        }
        
        private void MaimonScan(string customPorts)
        {
            var maimonScanner = new Scanner(_target); 
            var maimonType = ScanType.Maimon; 
            var maimonFlag = NmapFlag.MaimonScan;
            
            Scan(maimonScanner, maimonType, maimonFlag, customPorts);
        }
        
        //SCTP SCANS
        private void SctpCookieEchoMethod(string customPorts)
        {
            var cookieScanner = new Scanner(_target); 
            var cookieType = ScanType.SctpCookieEcho; 
            var cookieFlag = NmapFlag.CookieEchoScan;
            
            Scan(cookieScanner, cookieType, cookieFlag, customPorts);
        }

        private void SctpInitScan(string customPorts)
        {
            var sctpScanner = new Scanner(_target); 
            var sctpType = ScanType.SctpInit; 
            var sctpFlag = NmapFlag.SctpInitScan;
            
            Scan(sctpScanner, sctpType, sctpFlag, customPorts);
        }
        
        //UDP-only Scan
        private void UdpScan(string customPorts)
        {
            var udpScanner = new Scanner(_target); 
            var udpType = ScanType.Udp; 
            var udpFlag = NmapFlag.UdpScan;
            
            Scan(udpScanner, udpType, udpFlag, customPorts);
        }

        /// <summary>
        ///     Custom-made scan type that focuses on searching Minecraft server open ports.
        ///
        /// 1. MinecraftScan();
        ///     - This method is used for automatic port settings scanning.
        /// 2. MinecraftScan(string customPorts);
        ///     - This method is used for custom port settings scanning.
        /// </summary>
        private void MinecraftScan()
        {
            var mcScanner = new Scanner(_target);
            var mcType = ScanType.Default;
            var mcFlag = NmapFlag.TcpSynScan;

            _ports = "21000,21020,21030,21040,21050,21060,25500,25520,25540,25541,25560,25561,25562,25563,25564,25565,25570,25569,25580,25600,25610,21245,21249,21650,35500,35565,35575,45597,45500,40994,45565,65500,65535";
            Scan(mcScanner, mcType, mcFlag, _ports);
        }

        private void MinecraftScan(string customPorts)
        {
            var mcScanner = new Scanner(_target); 
            var mcType = ScanType.Default; 
            var mcFlag = NmapFlag.TcpSynScan;
            
            Scan(mcScanner, mcType, mcFlag, customPorts);
        }
        //FTP-SMTP-HTTP(s) Scan
        private void FSHScan()
        {
            var fshScanner = new Scanner(_target);
            var fshType = ScanType.Default;
            var fshFlag = NmapFlag.TcpSynScan;
            
            _ports = "1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,2230,100,135,140,150,990,1000,2000,2222";                
            Scan(fshScanner, fshType, fshFlag, _ports);
        }
        private void SSHScan()
        {
            var sshScanner = new Scanner(_target);
            var sshType = ScanType.Default;
            var sshFlag = NmapFlag.TcpSynScan;
            
            _ports = "1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,50,51,100,445,110,111,135,161,443,512,514,1433,1434,1723,2222,3389,3500,4999,5000,8080";
            Scan(sshScanner, sshType, sshFlag, _ports);
        }
        #endregion
    }
}