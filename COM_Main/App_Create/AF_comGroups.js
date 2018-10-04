<script type="text/javascript"> 
var script_comGroups = {
    validate_GroupID: function(sender) {
      var Prefix = sender.id.replace('GroupID','');
      this.validatePK_comGroups(sender,Prefix);
      },
    validatePK_comGroups: function(o,Prefix) {
      var value = o.id;
      try{$get(Prefix.replace('_F_','') + '_L_ErrMsgcomGroups').innerHTML = '';}catch(ex){}
      var GroupID = $get(Prefix + 'GroupID');
      if(GroupID.value=='')
        return true;
      value = value + ',' + GroupID.value ;
      o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
      o.style.backgroundRepeat= 'no-repeat';
      o.style.backgroundPosition = 'right';
      PageMethods.validatePK_comGroups(value, this.validatedPK_comGroups);
    },
    validatedPK_comGroups: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        try{$get('cph1_FVcomGroups_L_ErrMsgcomGroups').innerHTML = p[2];}catch(ex){}
        o.value='';
        o.focus();
      }
    },
    temp: function() {
    }
    }
</script>
