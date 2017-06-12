﻿//  Desc:        Framework For Game Develop with Unity3d
//  Copyright:   Copyright (C) 2017 SnowCold. All rights reserved.
//  WebSite:     https://github.com/SnowCold/PTFramework
//  Blog:        http://blog.csdn.net/snowcoldgame
//  Author:      SnowCold
//  E-mail:      snowcold.ouyang@gmail.com
using System;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;

namespace Qarth
{
    public class AbstractMonoCom : MonoBehaviour, ICom
    {
        private AbstractActor m_Actor;

        public AbstractActor actor
        {
            get { return m_Actor; }
        }

        public virtual int comOrder
        {
            get { return ComOrderDefine.DEFAULT; }
        }

        public void AwakeCom(AbstractActor actor)
        {
            m_Actor = actor;

            OnActorBind(actor);

            OnAwakeCom();
        }

        public void OnComDisable()
        {

        }

        public void OnComEnable()
        {

        }

        public virtual void OnComLateUpdate(float dt)
        {

        }

        public virtual void OnComStart()
        {

        }

        public virtual void OnComUpdate(float dt)
        {

        }

        public void DestroyCom()
        {
            OnDestroyCom();
            m_Actor = null;
            Destroy(this);
        }

#region 子类继承
        protected virtual void OnActorBind(AbstractActor actor)
        {

        }

        protected virtual void OnAwakeCom()
        {

        }
        protected virtual void OnDestroyCom()
        {

        }
#endregion
    }
}
