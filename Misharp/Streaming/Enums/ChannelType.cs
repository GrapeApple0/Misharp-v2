using System.Runtime.Serialization;

namespace Misharp.Streaming.Enums;

public enum ChannelType
{
    [EnumMember(Value = "main")] Main,
    [EnumMember(Value = "homeTimeline")] HomeTimeline,
    [EnumMember(Value = "localTimeline")] LocalTimeline,
    [EnumMember(Value = "hybridTimeline")] HybridTimeline,
    [EnumMember(Value = "globalTimeline")] GlobalTimeline,
    [EnumMember(Value = "userList")] UserList,
    [EnumMember(Value = "hashtag")] Hashtag,
    [EnumMember(Value = "roleTimeline")] RoleTimeline,
    [EnumMember(Value = "antenna")] Antenna,
    [EnumMember(Value = "channel")] Channel,
    [EnumMember(Value = "serverStats")] ServerStats,
    [EnumMember(Value = "queueStats")] QueueStats
}