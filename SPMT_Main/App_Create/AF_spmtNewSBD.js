<script type="text/javascript"> 
var script_spmtNewSBD = {
    ACEIRNo_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('IRNo','');
      var F_IRNo = $get(sender._element.id);
      var F_IRNo_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_IRNo.value = p[0];
      F_IRNo_Display.innerHTML = e.get_text();
    },
    ACEIRNo_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('IRNo','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
    },
    ACEIRNo_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    ACEHSNSACCode_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('HSNSACCode','');
      var F_HSNSACCode = $get(sender._element.id);
      var F_HSNSACCode_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_HSNSACCode.value = p[1];
      F_HSNSACCode_Display.innerHTML = e.get_text();
    },
    ACEHSNSACCode_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('HSNSACCode','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
      var F_BillType = $get(Prefix + 'BillType_DDLspmtBillTypes');
      sender._contextKey = F_BillType.value;
    },
    ACEHSNSACCode_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    validate_IRNo: function(sender) {
      var Prefix = sender.id.replace('IRNo','');
      this.validated_FK_SPMT_newSBD_IRNo_main = true;
      this.validate_FK_SPMT_newSBD_IRNo(sender,Prefix);
      },
    validate_HSNSACCode: function(sender) {
      var Prefix = sender.id.replace('HSNSACCode','');
      this.validated_FK_SPMT_newSBD_HSNSACCode_main = true;
      this.validate_FK_SPMT_newSBD_HSNSACCode(sender,Prefix);
      },
    validate_FK_SPMT_newSBD_HSNSACCode: function(o,Prefix) {
      var value = o.id;
      var BillType = $get(Prefix + 'BillType_DDLspmtBillTypes');
      if(BillType.value==''){
        if(this.validated_FK_SPMT_newSBD_HSNSACCode_main){
          var o_d = $get(Prefix + 'BillType' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + BillType.value ;
      var HSNSACCode = $get(Prefix + 'HSNSACCode');
      if(HSNSACCode.value==''){
        if(this.validated_FK_SPMT_newSBD_HSNSACCode_main){
          var o_d = $get(Prefix + 'HSNSACCode' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + HSNSACCode.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_newSBD_HSNSACCode(value, this.validated_FK_SPMT_newSBD_HSNSACCode);
      },
    validated_FK_SPMT_newSBD_HSNSACCode_main: false,
    validated_FK_SPMT_newSBD_HSNSACCode: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_spmtNewSBD.validated_FK_SPMT_newSBD_HSNSACCode_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    validate_FK_SPMT_newSBD_IRNo: function(o,Prefix) {
      var value = o.id;
      var IRNo = $get(Prefix + 'IRNo');
      if(IRNo.value==''){
        if(this.validated_FK_SPMT_newSBD_IRNo_main){
          var o_d = $get(Prefix + 'IRNo' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + IRNo.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_newSBD_IRNo(value, this.validated_FK_SPMT_newSBD_IRNo);
      },
    validated_FK_SPMT_newSBD_IRNo_main: false,
    validated_FK_SPMT_newSBD_IRNo: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_spmtNewSBD.validated_FK_SPMT_newSBD_IRNo_main){
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
