﻿/****************************************************************************
*项目名称：SAEA.MQTT.Exceptions
*CLR 版本：4.0.30319.42000
*机器名称：WENLI-PC
*命名空间：SAEA.MQTT.Exceptions
*类 名 称：MqttCommunicationTimedOutException
*版 本 号： V3.6.2.2
*创建人： yswenli
*电子邮箱：wenguoli_520@qq.com
*创建时间：2019/1/15 11:02:27
*描述：
*=====================================================================
*修改时间：2019/1/15 11:02:27
*修 改 人： yswenli
*版 本 号： V3.6.2.2
*描    述：
*****************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace SAEA.MQTT.Exceptions
{
    public class MqttCommunicationTimedOutException : MqttCommunicationException
    {
        public MqttCommunicationTimedOutException()
        {
        }

        public MqttCommunicationTimedOutException(Exception innerException) : base(innerException)
        {
        }
    }
}
