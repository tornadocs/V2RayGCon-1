﻿namespace VgcApis.Models.IControllers
{
    public interface ICoreCtrl
    {
        /* v1.1.8 */
        string GetInboundIpAndPort();   // 127.0.0.1:1080
        int GetInboundMode();           // 0 config 1 http 2 socks
        string GetMark();
        long GetSpeedTestResult();      // 2000 (ms) default -1
        string GetSummary();            // vmess@1.2.3.4

        void RestartCoreAsync();
        void RunSpeedTestAsync();
        void StopCoreAsync();
        /**********/

        string GetConfig(); // config.json
        double GetIndex();
        string GetName();
        string GetStatus(); // speed test result e.g. 2000ms
        string GetTitle();  // 1.[serv1] vmess@1.2.3.4
        string GetUid();    // hex chars

        bool IsCoreRunning();
        bool IsSelected();
        bool IsUntrack();

        void SetIsSelected(bool selected);
        void SetMark(string mark);

        void RestartCore();
        void RunSpeedTest();
        void StopCore();

        void ChangeConfig(string config);
        void ChangeInboundIpAndPort(string ip, int port);
        void ChangeInboundMode(int type); // 0 config 1 http 2 socks

        // for ProxySetter and Statistics 
        bool IsSuitableToBeUsedAsSysProxy(bool isGlobal, out bool isSocks, out int port);
        Datas.StatsSample TakeStatisticsSample();
    }
}
