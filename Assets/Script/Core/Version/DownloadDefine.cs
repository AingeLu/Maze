using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.IO;
using UnityEngine;


//下载方式
public enum DownloadType
{
    WWW,
    HTTPREQUREST,
}

// 下载阶段
public enum DownloadPhase
{
    REQUSET,            // 请求
    DOWNING,            // 下载
    FINISHED,           // 完成
};

// 下载错误码
public enum DownloadErrorCode
{
    SUCC = 0,           //执行成功
    FILE_HASEXIST,      //文件已经存在下载

    GETHEAD_ERROR,      //获取文件头失败
    DOWNCONTENT_ERROR,  //获取内容失败
    MD5_NOTMATCH,       //md5不匹配
};

public delegate void OnDownloadFinished(DownloadFileItem item, DownloadErrorCode errorCode);

public class DownloadFileItem
{
    public DownloadType downloadType;
    public DownloadPhase downloadPhase;

    public string downloadUrl;
    public string localFile;
    public bool bCheckMd5 = true;
    public string fileMD5;
    public string fileName;
    public OnDownloadFinished callBack = null;

    public System.DateTime remoteLastModified;
    public System.DateTime localLastModified;

    public long remoteFileSize = 0;

    public HttpWebRequest request;
    public Stream inStream;
    public FileStream outStream;
    public long hasDownSize = 0;

    public void OnReset()
    {
        downloadPhase = DownloadPhase.REQUSET;
        bCheckMd5 = true;
        callBack = null;
        remoteFileSize = 0;
        hasDownSize = 0;
    }
};
