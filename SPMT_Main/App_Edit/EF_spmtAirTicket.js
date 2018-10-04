<script type="text/javascript"> 
var script_spmtAirTicket = {
    ACEAgentsBPID_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('AgentsBPID','');
      var F_AgentsBPID = $get(sender._element.id);
      var F_AgentsBPID_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_AgentsBPID.value = p[0];
      F_AgentsBPID_Display.innerHTML = e.get_text();
    },
    ACEAgentsBPID_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('AgentsBPID','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
    },
    ACEAgentsBPID_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    ACEAgentsGSTIN_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('AgentsGSTIN','');
      var F_AgentsGSTIN = $get(sender._element.id);
      var F_AgentsGSTIN_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_AgentsGSTIN.value = p[1];
      F_AgentsGSTIN_Display.innerHTML = e.get_text();
    },
    ACEAgentsGSTIN_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('AgentsGSTIN','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
      var F_AgentsBPID = $get(Prefix + 'AgentsBPID');
      sender._contextKey = F_AgentsBPID.value;
    },
    ACEAgentsGSTIN_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    ACEAgentsHSNSACCode_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('AgentsHSNSACCode','');
      var F_AgentsHSNSACCode = $get(sender._element.id);
      var F_AgentsHSNSACCode_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_AgentsHSNSACCode.value = p[1];
      F_AgentsHSNSACCode_Display.innerHTML = e.get_text();
    },
    ACEAgentsHSNSACCode_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('AgentsHSNSACCode','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
      var F_AgentsBillType = $get(Prefix + 'AgentsBillType');
      sender._contextKey = F_AgentsBillType.value;
    },
    ACEAgentsHSNSACCode_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    ACEAgencyBPID_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('AgencyBPID','');
      var F_AgencyBPID = $get(sender._element.id);
      var F_AgencyBPID_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_AgencyBPID.value = p[0];
      F_AgencyBPID_Display.innerHTML = e.get_text();
    },
    ACEAgencyBPID_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('AgencyBPID','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
    },
    ACEAgencyBPID_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    ACEAgencyGSTIN_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('AgencyGSTIN','');
      var F_AgencyGSTIN = $get(sender._element.id);
      var F_AgencyGSTIN_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_AgencyGSTIN.value = p[1];
      F_AgencyGSTIN_Display.innerHTML = e.get_text();
    },
    ACEAgencyGSTIN_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('AgencyGSTIN','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
      var F_AgencyBPID = $get(Prefix + 'AgencyBPID');
      sender._contextKey = F_AgencyBPID.value;
    },
    ACEAgencyGSTIN_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    ACEAgencyHSNSACCode_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('AgencyHSNSACCode','');
      var F_AgencyHSNSACCode = $get(sender._element.id);
      var F_AgencyHSNSACCode_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_AgencyHSNSACCode.value = p[1];
      F_AgencyHSNSACCode_Display.innerHTML = e.get_text();
    },
    ACEAgencyHSNSACCode_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('AgencyHSNSACCode','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
      var F_AgencyBillType = $get(Prefix + 'AgencyBillType');
      sender._contextKey = F_AgencyBillType.value;
    },
    ACEAgencyHSNSACCode_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    ACEEmployeeID_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('EmployeeID','');
      var F_EmployeeID = $get(sender._element.id);
      var F_EmployeeID_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_EmployeeID.value = p[0];
      F_EmployeeID_Display.innerHTML = e.get_text();
    },
    ACEEmployeeID_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('EmployeeID','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
    },
    ACEEmployeeID_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    ACEProjectID_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('ProjectID','');
      var F_ProjectID = $get(sender._element.id);
      var F_ProjectID_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_ProjectID.value = p[0];
      F_ProjectID_Display.innerHTML = e.get_text();
    },
    ACEProjectID_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('ProjectID','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
    },
    ACEProjectID_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    validate_AgentsBPID: function(sender) {
      var Prefix = sender.id.replace('AgentsBPID','');
      this.validated_FK_SPMT_AirTicket_AgentsBPID_main = true;
      this.validate_FK_SPMT_AirTicket_AgentsBPID(sender,Prefix);
      },
    validate_AgentsGSTIN: function(sender) {
      var Prefix = sender.id.replace('AgentsGSTIN','');
      this.validated_FK_SPMT_AirTicket_AgentsGSTIN_main = true;
      this.validate_FK_SPMT_AirTicket_AgentsGSTIN(sender,Prefix);
      },
    validate_AgentsHSNSACCode: function(sender) {
      var Prefix = sender.id.replace('AgentsHSNSACCode','');
      this.validated_FK_SPMT_AirTicket_AgentsHSNSACCode_main = true;
      this.validate_FK_SPMT_AirTicket_AgentsHSNSACCode(sender,Prefix);
      },
    validate_AgencyBPID: function(sender) {
      var Prefix = sender.id.replace('AgencyBPID','');
      this.validated_FK_SPMT_AirTicket_AgencyBPID_main = true;
      this.validate_FK_SPMT_AirTicket_AgencyBPID(sender,Prefix);
      },
    validate_AgencyGSTIN: function(sender) {
      var Prefix = sender.id.replace('AgencyGSTIN','');
      this.validated_FK_SPMT_AirTicket_AgencyGSTIN_main = true;
      this.validate_FK_SPMT_AirTicket_AgencyGSTIN(sender,Prefix);
      },
    validate_AgencyHSNSACCode: function(sender) {
      var Prefix = sender.id.replace('AgencyHSNSACCode','');
      this.validated_FK_SPMT_AirTicket_AgencyHSNSACCode_main = true;
      this.validate_FK_SPMT_AirTicket_AgencyHSNSACCode(sender,Prefix);
      },
    validate_EmployeeID: function(sender) {
      var Prefix = sender.id.replace('EmployeeID','');
      this.validated_FK_SPMT_AirTicket_EmployeeID_main = true;
      this.validate_FK_SPMT_AirTicket_EmployeeID(sender,Prefix);
      },
    validate_ProjectID: function(sender) {
      var Prefix = sender.id.replace('ProjectID','');
      this.validated_FK_SPMT_AirTicket_ProjectID_main = true;
      this.validate_FK_SPMT_AirTicket_ProjectID(sender,Prefix);
      },
    validate_FK_SPMT_AirTicket_EmployeeID: function(o,Prefix) {
      var value = o.id;
      var EmployeeID = $get(Prefix + 'EmployeeID');
      if(EmployeeID.value==''){
        if(this.validated_FK_SPMT_AirTicket_EmployeeID_main){
          var o_d = $get(Prefix + 'EmployeeID' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + EmployeeID.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_AirTicket_EmployeeID(value, this.validated_FK_SPMT_AirTicket_EmployeeID);
      },
    validated_FK_SPMT_AirTicket_EmployeeID_main: false,
    validated_FK_SPMT_AirTicket_EmployeeID: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_spmtAirTicket.validated_FK_SPMT_AirTicket_EmployeeID_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    validate_FK_SPMT_AirTicket_ProjectID: function(o,Prefix) {
      var value = o.id;
      var ProjectID = $get(Prefix + 'ProjectID');
      if(ProjectID.value==''){
        if(this.validated_FK_SPMT_AirTicket_ProjectID_main){
          var o_d = $get(Prefix + 'ProjectID' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + ProjectID.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_AirTicket_ProjectID(value, this.validated_FK_SPMT_AirTicket_ProjectID);
      },
    validated_FK_SPMT_AirTicket_ProjectID_main: false,
    validated_FK_SPMT_AirTicket_ProjectID: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_spmtAirTicket.validated_FK_SPMT_AirTicket_ProjectID_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    validate_FK_SPMT_AirTicket_AgencyHSNSACCode: function(o,Prefix) {
      var value = o.id;
      var AgencyBillType = $get(Prefix + 'AgencyBillType');
      if(AgencyBillType.value==''){
        if(this.validated_FK_SPMT_AirTicket_AgencyHSNSACCode_main){
          var o_d = $get(Prefix + 'AgencyBillType' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + AgencyBillType.value ;
      var AgencyHSNSACCode = $get(Prefix + 'AgencyHSNSACCode');
      if(AgencyHSNSACCode.value==''){
        if(this.validated_FK_SPMT_AirTicket_AgencyHSNSACCode_main){
          var o_d = $get(Prefix + 'AgencyHSNSACCode' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + AgencyHSNSACCode.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_AirTicket_AgencyHSNSACCode(value, this.validated_FK_SPMT_AirTicket_AgencyHSNSACCode);
      },
    validated_FK_SPMT_AirTicket_AgencyHSNSACCode_main: false,
    validated_FK_SPMT_AirTicket_AgencyHSNSACCode: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_spmtAirTicket.validated_FK_SPMT_AirTicket_AgencyHSNSACCode_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    validate_FK_SPMT_AirTicket_AgentsHSNSACCode: function(o,Prefix) {
      var value = o.id;
      var AgentsBillType = $get(Prefix + 'AgentsBillType');
      if(AgentsBillType.value==''){
        if(this.validated_FK_SPMT_AirTicket_AgentsHSNSACCode_main){
          var o_d = $get(Prefix + 'AgentsBillType' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + AgentsBillType.value ;
      var AgentsHSNSACCode = $get(Prefix + 'AgentsHSNSACCode');
      if(AgentsHSNSACCode.value==''){
        if(this.validated_FK_SPMT_AirTicket_AgentsHSNSACCode_main){
          var o_d = $get(Prefix + 'AgentsHSNSACCode' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + AgentsHSNSACCode.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_AirTicket_AgentsHSNSACCode(value, this.validated_FK_SPMT_AirTicket_AgentsHSNSACCode);
      },
    validated_FK_SPMT_AirTicket_AgentsHSNSACCode_main: false,
    validated_FK_SPMT_AirTicket_AgentsHSNSACCode: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_spmtAirTicket.validated_FK_SPMT_AirTicket_AgentsHSNSACCode_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    validate_FK_SPMT_AirTicket_AgencyGSTIN: function(o,Prefix) {
      var value = o.id;
      var AgencyBPID = $get(Prefix + 'AgencyBPID');
      if(AgencyBPID.value==''){
        if(this.validated_FK_SPMT_AirTicket_AgencyGSTIN_main){
          var o_d = $get(Prefix + 'AgencyBPID' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + AgencyBPID.value ;
      var AgencyGSTIN = $get(Prefix + 'AgencyGSTIN');
      if(AgencyGSTIN.value==''){
        if(this.validated_FK_SPMT_AirTicket_AgencyGSTIN_main){
          var o_d = $get(Prefix + 'AgencyGSTIN' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + AgencyGSTIN.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_AirTicket_AgencyGSTIN(value, this.validated_FK_SPMT_AirTicket_AgencyGSTIN);
      },
    validated_FK_SPMT_AirTicket_AgencyGSTIN_main: false,
    validated_FK_SPMT_AirTicket_AgencyGSTIN: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_spmtAirTicket.validated_FK_SPMT_AirTicket_AgencyGSTIN_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    validate_FK_SPMT_AirTicket_AgentsGSTIN: function(o,Prefix) {
      var value = o.id;
      var AgentsBPID = $get(Prefix + 'AgentsBPID');
      if(AgentsBPID.value==''){
        if(this.validated_FK_SPMT_AirTicket_AgentsGSTIN_main){
          var o_d = $get(Prefix + 'AgentsBPID' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + AgentsBPID.value ;
      var AgentsGSTIN = $get(Prefix + 'AgentsGSTIN');
      if(AgentsGSTIN.value==''){
        if(this.validated_FK_SPMT_AirTicket_AgentsGSTIN_main){
          var o_d = $get(Prefix + 'AgentsGSTIN' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + AgentsGSTIN.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_AirTicket_AgentsGSTIN(value, this.validated_FK_SPMT_AirTicket_AgentsGSTIN);
      },
    validated_FK_SPMT_AirTicket_AgentsGSTIN_main: false,
    validated_FK_SPMT_AirTicket_AgentsGSTIN: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_spmtAirTicket.validated_FK_SPMT_AirTicket_AgentsGSTIN_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    validate_FK_SPMT_AirTicket_AgencyBPID: function(o,Prefix) {
      var value = o.id;
      var AgencyBPID = $get(Prefix + 'AgencyBPID');
      if(AgencyBPID.value==''){
        if(this.validated_FK_SPMT_AirTicket_AgencyBPID_main){
          var o_d = $get(Prefix + 'AgencyBPID' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + AgencyBPID.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_AirTicket_AgencyBPID(value, this.validated_FK_SPMT_AirTicket_AgencyBPID);
      },
    validated_FK_SPMT_AirTicket_AgencyBPID_main: false,
    validated_FK_SPMT_AirTicket_AgencyBPID: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_spmtAirTicket.validated_FK_SPMT_AirTicket_AgencyBPID_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    validate_FK_SPMT_AirTicket_AgentsBPID: function(o,Prefix) {
      var value = o.id;
      var AgentsBPID = $get(Prefix + 'AgentsBPID');
      if(AgentsBPID.value==''){
        if(this.validated_FK_SPMT_AirTicket_AgentsBPID_main){
          var o_d = $get(Prefix + 'AgentsBPID' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + AgentsBPID.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_AirTicket_AgentsBPID(value, this.validated_FK_SPMT_AirTicket_AgentsBPID);
      },
    validated_FK_SPMT_AirTicket_AgentsBPID_main: false,
    validated_FK_SPMT_AirTicket_AgentsBPID: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_spmtAirTicket.validated_FK_SPMT_AirTicket_AgentsBPID_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    temp: function() {
    }
    }
</script>
