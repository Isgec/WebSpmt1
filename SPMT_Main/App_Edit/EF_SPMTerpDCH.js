<script type="text/javascript"> 
var script_SPMTerpDCH = {
    ACECreatedBy_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('CreatedBy','');
      var F_CreatedBy = $get(sender._element.id);
      var F_CreatedBy_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_CreatedBy.value = p[0];
      F_CreatedBy_Display.innerHTML = e.get_text();
    },
    ACECreatedBy_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('CreatedBy','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
    },
    ACECreatedBy_Populated: function(sender,e) {
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
    ACEConsigneeBPID_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('ConsigneeBPID','');
      var F_ConsigneeBPID = $get(sender._element.id);
      var F_ConsigneeBPID_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_ConsigneeBPID.value = p[0];
      F_ConsigneeBPID_Display.innerHTML = e.get_text();
    },
    ACEConsigneeBPID_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('ConsigneeBPID','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
    },
    ACEConsigneeBPID_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    ACEConsigneeGSTIN_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('ConsigneeGSTIN','');
      var F_ConsigneeGSTIN = $get(sender._element.id);
      var F_ConsigneeGSTIN_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_ConsigneeGSTIN.value = p[1];
      F_ConsigneeGSTIN_Display.innerHTML = e.get_text();
    },
    ACEConsigneeGSTIN_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('ConsigneeGSTIN','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
      var F_ConsigneeBPID = $get(Prefix + 'ConsigneeBPID');
      sender._contextKey = F_ConsigneeBPID.value;
    },
    ACEConsigneeGSTIN_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    ACEConsignerBPID_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('ConsignerBPID','');
      var F_ConsignerBPID = $get(sender._element.id);
      var F_ConsignerBPID_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_ConsignerBPID.value = p[0];
      F_ConsignerBPID_Display.innerHTML = e.get_text();
    },
    ACEConsignerBPID_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('ConsignerBPID','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
    },
    ACEConsignerBPID_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    ACEConsignerGSTIN_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('ConsignerGSTIN','');
      var F_ConsignerGSTIN = $get(sender._element.id);
      var F_ConsignerGSTIN_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_ConsignerGSTIN.value = p[1];
      F_ConsignerGSTIN_Display.innerHTML = e.get_text();
    },
    ACEConsignerGSTIN_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('ConsignerGSTIN','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
      var F_ConsignerBPID = $get(Prefix + 'ConsignerBPID');
      sender._contextKey = F_ConsignerBPID.value;
    },
    ACEConsignerGSTIN_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    ACETransporterID_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('TransporterID','');
      var F_TransporterID = $get(sender._element.id);
      var F_TransporterID_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_TransporterID.value = p[0];
      F_TransporterID_Display.innerHTML = e.get_text();
    },
    ACETransporterID_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('TransporterID','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
    },
    ACETransporterID_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    ACELinkedChallanID_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('LinkedChallanID','');
      var F_LinkedChallanID = $get(sender._element.id);
      var F_LinkedChallanID_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_LinkedChallanID.value = p[0];
      F_LinkedChallanID_Display.innerHTML = e.get_text();
    },
    ACELinkedChallanID_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('LinkedChallanID','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
    },
    ACELinkedChallanID_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    ACEDestinationBPID_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('DestinationBPID','');
      var F_DestinationBPID = $get(sender._element.id);
      var F_DestinationBPID_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_DestinationBPID.value = p[0];
      F_DestinationBPID_Display.innerHTML = e.get_text();
    },
    ACEDestinationBPID_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('DestinationBPID','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
    },
    ACEDestinationBPID_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    ACEDestinationGSTIN_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('DestinationGSTIN','');
      var F_DestinationGSTIN = $get(sender._element.id);
      var F_DestinationGSTIN_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_DestinationGSTIN.value = p[1];
      F_DestinationGSTIN_Display.innerHTML = e.get_text();
    },
    ACEDestinationGSTIN_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('DestinationGSTIN','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
      var F_DestinationBPID = $get(Prefix + 'DestinationBPID');
      sender._contextKey = F_DestinationBPID.value;
    },
    ACEDestinationGSTIN_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    ACEReceivedBy_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('ReceivedBy','');
      var F_ReceivedBy = $get(sender._element.id);
      var F_ReceivedBy_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_ReceivedBy.value = p[0];
      F_ReceivedBy_Display.innerHTML = e.get_text();
    },
    ACEReceivedBy_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('ReceivedBy','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
    },
    ACEReceivedBy_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    ACEClosedBy_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('ClosedBy','');
      var F_ClosedBy = $get(sender._element.id);
      var F_ClosedBy_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_ClosedBy.value = p[0];
      F_ClosedBy_Display.innerHTML = e.get_text();
    },
    ACEClosedBy_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('ClosedBy','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
    },
    ACEClosedBy_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    validate_CreatedBy: function(sender) {
      var Prefix = sender.id.replace('CreatedBy','');
      this.validated_FK_SPMT_erpDCH_CreatedBy_main = true;
      this.validate_FK_SPMT_erpDCH_CreatedBy(sender,Prefix);
      },
    validate_ProjectID: function(sender) {
      var Prefix = sender.id.replace('ProjectID','');
      this.validated_FK_SPMT_erpDCH_ProjectID_main = true;
      this.validate_FK_SPMT_erpDCH_ProjectID(sender,Prefix);
      },
    validate_ConsigneeBPID: function(sender) {
      var Prefix = sender.id.replace('ConsigneeBPID','');
      this.validated_FK_SPMT_erpDCH_ConsigneeBPID_main = true;
      this.validate_FK_SPMT_erpDCH_ConsigneeBPID(sender,Prefix);
      },
    validate_ConsigneeGSTIN: function(sender) {
      var Prefix = sender.id.replace('ConsigneeGSTIN','');
      this.validated_FK_SPMT_erpDCH_ConsigneeGISTIN_main = true;
      this.validate_FK_SPMT_erpDCH_ConsigneeGISTIN(sender,Prefix);
      },
    validate_ConsignerBPID: function(sender) {
      var Prefix = sender.id.replace('ConsignerBPID','');
      this.validated_FK_SPMT_erpDCH_ConsignerBPID_main = true;
      this.validate_FK_SPMT_erpDCH_ConsignerBPID(sender,Prefix);
      },
    validate_ConsignerGSTIN: function(sender) {
      var Prefix = sender.id.replace('ConsignerGSTIN','');
      this.validated_FK_SPMT_erpDCH_ConsignerGSTIN_main = true;
      this.validate_FK_SPMT_erpDCH_ConsignerGSTIN(sender,Prefix);
      },
    validate_TransporterID: function(sender) {
      var Prefix = sender.id.replace('TransporterID','');
      this.validated_FK_SPMT_erpDCH_TransporterID_main = true;
      this.validate_FK_SPMT_erpDCH_TransporterID(sender,Prefix);
      },
    validate_LinkedChallanID: function(sender) {
      var Prefix = sender.id.replace('LinkedChallanID','');
      this.validated_FK_SPMT_erpDCH_LinkedChallanID_main = true;
      this.validate_FK_SPMT_erpDCH_LinkedChallanID(sender,Prefix);
      },
    validate_DestinationBPID: function(sender) {
      var Prefix = sender.id.replace('DestinationBPID','');
      this.validated_FK_SPMT_erpDCH_DestinationBPID_main = true;
      this.validate_FK_SPMT_erpDCH_DestinationBPID(sender,Prefix);
      },
    validate_DestinationGSTIN: function(sender) {
      var Prefix = sender.id.replace('DestinationGSTIN','');
      this.validated_FK_SPMT_erpDCH_DestinationGSTIN_main = true;
      this.validate_FK_SPMT_erpDCH_DestinationGSTIN(sender,Prefix);
      },
    validate_ReceivedBy: function(sender) {
      var Prefix = sender.id.replace('ReceivedBy','');
      this.validated_FK_SPMT_erpDCH_ReceivedBy_main = true;
      this.validate_FK_SPMT_erpDCH_ReceivedBy(sender,Prefix);
      },
    validate_ClosedBy: function(sender) {
      var Prefix = sender.id.replace('ClosedBy','');
      this.validated_FK_SPMT_erpDCH_ClosedBy_main = true;
      this.validate_FK_SPMT_erpDCH_ClosedBy(sender,Prefix);
      },
    validate_FK_SPMT_erpDCH_ClosedBy: function(o,Prefix) {
      var value = o.id;
      var ClosedBy = $get(Prefix + 'ClosedBy');
      if(ClosedBy.value==''){
        if(this.validated_FK_SPMT_erpDCH_ClosedBy_main){
          var o_d = $get(Prefix + 'ClosedBy' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + ClosedBy.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_erpDCH_ClosedBy(value, this.validated_FK_SPMT_erpDCH_ClosedBy);
      },
    validated_FK_SPMT_erpDCH_ClosedBy_main: false,
    validated_FK_SPMT_erpDCH_ClosedBy: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_SPMTerpDCH.validated_FK_SPMT_erpDCH_ClosedBy_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    validate_FK_SPMT_erpDCH_CreatedBy: function(o,Prefix) {
      var value = o.id;
      var CreatedBy = $get(Prefix + 'CreatedBy');
      if(CreatedBy.value==''){
        if(this.validated_FK_SPMT_erpDCH_CreatedBy_main){
          var o_d = $get(Prefix + 'CreatedBy' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + CreatedBy.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_erpDCH_CreatedBy(value, this.validated_FK_SPMT_erpDCH_CreatedBy);
      },
    validated_FK_SPMT_erpDCH_CreatedBy_main: false,
    validated_FK_SPMT_erpDCH_CreatedBy: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_SPMTerpDCH.validated_FK_SPMT_erpDCH_CreatedBy_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    validate_FK_SPMT_erpDCH_ReceivedBy: function(o,Prefix) {
      var value = o.id;
      var ReceivedBy = $get(Prefix + 'ReceivedBy');
      if(ReceivedBy.value==''){
        if(this.validated_FK_SPMT_erpDCH_ReceivedBy_main){
          var o_d = $get(Prefix + 'ReceivedBy' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + ReceivedBy.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_erpDCH_ReceivedBy(value, this.validated_FK_SPMT_erpDCH_ReceivedBy);
      },
    validated_FK_SPMT_erpDCH_ReceivedBy_main: false,
    validated_FK_SPMT_erpDCH_ReceivedBy: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_SPMTerpDCH.validated_FK_SPMT_erpDCH_ReceivedBy_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    validate_FK_SPMT_erpDCH_ProjectID: function(o,Prefix) {
      var value = o.id;
      var ProjectID = $get(Prefix + 'ProjectID');
      if(ProjectID.value==''){
        if(this.validated_FK_SPMT_erpDCH_ProjectID_main){
          var o_d = $get(Prefix + 'ProjectID' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + ProjectID.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_erpDCH_ProjectID(value, this.validated_FK_SPMT_erpDCH_ProjectID);
      },
    validated_FK_SPMT_erpDCH_ProjectID_main: false,
    validated_FK_SPMT_erpDCH_ProjectID: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_SPMTerpDCH.validated_FK_SPMT_erpDCH_ProjectID_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    validate_FK_SPMT_erpDCH_LinkedChallanID: function(o,Prefix) {
      var value = o.id;
      var LinkedChallanID = $get(Prefix + 'LinkedChallanID');
      if(LinkedChallanID.value==''){
        if(this.validated_FK_SPMT_erpDCH_LinkedChallanID_main){
          var o_d = $get(Prefix + 'LinkedChallanID' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + LinkedChallanID.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_erpDCH_LinkedChallanID(value, this.validated_FK_SPMT_erpDCH_LinkedChallanID);
      },
    validated_FK_SPMT_erpDCH_LinkedChallanID_main: false,
    validated_FK_SPMT_erpDCH_LinkedChallanID: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_SPMTerpDCH.validated_FK_SPMT_erpDCH_LinkedChallanID_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    validate_FK_SPMT_erpDCH_DestinationGSTIN: function(o,Prefix) {
      var value = o.id;
      var DestinationBPID = $get(Prefix + 'DestinationBPID');
      if(DestinationBPID.value==''){
        if(this.validated_FK_SPMT_erpDCH_DestinationGSTIN_main){
          var o_d = $get(Prefix + 'DestinationBPID' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + DestinationBPID.value ;
      var DestinationGSTIN = $get(Prefix + 'DestinationGSTIN');
      if(DestinationGSTIN.value==''){
        if(this.validated_FK_SPMT_erpDCH_DestinationGSTIN_main){
          var o_d = $get(Prefix + 'DestinationGSTIN' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + DestinationGSTIN.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_erpDCH_DestinationGSTIN(value, this.validated_FK_SPMT_erpDCH_DestinationGSTIN);
      },
    validated_FK_SPMT_erpDCH_DestinationGSTIN_main: false,
    validated_FK_SPMT_erpDCH_DestinationGSTIN: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_SPMTerpDCH.validated_FK_SPMT_erpDCH_DestinationGSTIN_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    validate_FK_SPMT_erpDCH_ConsigneeGISTIN: function(o,Prefix) {
      var value = o.id;
      var ConsigneeBPID = $get(Prefix + 'ConsigneeBPID');
      if(ConsigneeBPID.value==''){
        if(this.validated_FK_SPMT_erpDCH_ConsigneeGISTIN_main){
          var o_d = $get(Prefix + 'ConsigneeBPID' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + ConsigneeBPID.value ;
      var ConsigneeGSTIN = $get(Prefix + 'ConsigneeGSTIN');
      if(ConsigneeGSTIN.value==''){
        if(this.validated_FK_SPMT_erpDCH_ConsigneeGISTIN_main){
          var o_d = $get(Prefix + 'ConsigneeGSTIN' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + ConsigneeGSTIN.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_erpDCH_ConsigneeGISTIN(value, this.validated_FK_SPMT_erpDCH_ConsigneeGISTIN);
      },
    validated_FK_SPMT_erpDCH_ConsigneeGISTIN_main: false,
    validated_FK_SPMT_erpDCH_ConsigneeGISTIN: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_SPMTerpDCH.validated_FK_SPMT_erpDCH_ConsigneeGISTIN_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    validate_FK_SPMT_erpDCH_ConsignerGSTIN: function(o,Prefix) {
      var value = o.id;
      var ConsignerBPID = $get(Prefix + 'ConsignerBPID');
      if(ConsignerBPID.value==''){
        if(this.validated_FK_SPMT_erpDCH_ConsignerGSTIN_main){
          var o_d = $get(Prefix + 'ConsignerBPID' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + ConsignerBPID.value ;
      var ConsignerGSTIN = $get(Prefix + 'ConsignerGSTIN');
      if(ConsignerGSTIN.value==''){
        if(this.validated_FK_SPMT_erpDCH_ConsignerGSTIN_main){
          var o_d = $get(Prefix + 'ConsignerGSTIN' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + ConsignerGSTIN.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_erpDCH_ConsignerGSTIN(value, this.validated_FK_SPMT_erpDCH_ConsignerGSTIN);
      },
    validated_FK_SPMT_erpDCH_ConsignerGSTIN_main: false,
    validated_FK_SPMT_erpDCH_ConsignerGSTIN: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_SPMTerpDCH.validated_FK_SPMT_erpDCH_ConsignerGSTIN_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    validate_FK_SPMT_erpDCH_DestinationBPID: function(o,Prefix) {
      var value = o.id;
      var DestinationBPID = $get(Prefix + 'DestinationBPID');
      if(DestinationBPID.value==''){
        if(this.validated_FK_SPMT_erpDCH_DestinationBPID_main){
          var o_d = $get(Prefix + 'DestinationBPID' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + DestinationBPID.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_erpDCH_DestinationBPID(value, this.validated_FK_SPMT_erpDCH_DestinationBPID);
      },
    validated_FK_SPMT_erpDCH_DestinationBPID_main: false,
    validated_FK_SPMT_erpDCH_DestinationBPID: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_SPMTerpDCH.validated_FK_SPMT_erpDCH_DestinationBPID_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    validate_FK_SPMT_erpDCH_ConsigneeBPID: function(o,Prefix) {
      var value = o.id;
      var ConsigneeBPID = $get(Prefix + 'ConsigneeBPID');
      if(ConsigneeBPID.value==''){
        if(this.validated_FK_SPMT_erpDCH_ConsigneeBPID_main){
          var o_d = $get(Prefix + 'ConsigneeBPID' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + ConsigneeBPID.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_erpDCH_ConsigneeBPID(value, this.validated_FK_SPMT_erpDCH_ConsigneeBPID);
      },
    validated_FK_SPMT_erpDCH_ConsigneeBPID_main: false,
    validated_FK_SPMT_erpDCH_ConsigneeBPID: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_SPMTerpDCH.validated_FK_SPMT_erpDCH_ConsigneeBPID_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    validate_FK_SPMT_erpDCH_ConsignerBPID: function(o,Prefix) {
      var value = o.id;
      var ConsignerBPID = $get(Prefix + 'ConsignerBPID');
      if(ConsignerBPID.value==''){
        if(this.validated_FK_SPMT_erpDCH_ConsignerBPID_main){
          var o_d = $get(Prefix + 'ConsignerBPID' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + ConsignerBPID.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_erpDCH_ConsignerBPID(value, this.validated_FK_SPMT_erpDCH_ConsignerBPID);
      },
    validated_FK_SPMT_erpDCH_ConsignerBPID_main: false,
    validated_FK_SPMT_erpDCH_ConsignerBPID: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_SPMTerpDCH.validated_FK_SPMT_erpDCH_ConsignerBPID_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    validate_FK_SPMT_erpDCH_TransporterID: function(o,Prefix) {
      var value = o.id;
      var TransporterID = $get(Prefix + 'TransporterID');
      if(TransporterID.value==''){
        if(this.validated_FK_SPMT_erpDCH_TransporterID_main){
          var o_d = $get(Prefix + 'TransporterID' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + TransporterID.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_erpDCH_TransporterID(value, this.validated_FK_SPMT_erpDCH_TransporterID);
      },
    validated_FK_SPMT_erpDCH_TransporterID_main: false,
    validated_FK_SPMT_erpDCH_TransporterID: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_SPMTerpDCH.validated_FK_SPMT_erpDCH_TransporterID_main){
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
