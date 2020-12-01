using Refit;

namespace Ray.BiliBiliTool.Agent.Interfaces
{
    [Headers(
    "Accept:application/json, text/plain, */*",
    "Referer:https://www.bilibili.com/",
    "Connection:keep-alive",
    "User-Agent:Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/87.0.4280.66 Safari/537.36"
    )]
    public interface IBiliBiliApi
    {
    }
}
