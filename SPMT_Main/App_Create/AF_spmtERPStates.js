<script type="text/javascript"> 
var script_spmtERPStates = {
    validate_StateID: function(sender) {
      var Prefix = sender.id.replace('StateID','');
      this.validatePK_spmtERPStates(sender,Prefix);
      },
    validatePK_spmtERPStates: function(o,Prefix) {
      var value = o.id;
      try{$get(Prefix.replace('_F_','') + '_L_ErrMsgspmtERPStates').innerHTML = '';}catch(ex){}
      var StateID = $get(Prefix + 'StateID');
      if(StateID.value=='')
        return true;
      value = value + ',' + StateID.value ;
      o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
      o.style.backgroundRepeat= 'no-repeat';
      o.style.backgroundPosition = 'right';
      PageMethods.validatePK_spmtERPStates(value, this.validatedPK_spmtERPStates);
    },
    validatedPK_spmtERPStates: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        try{$get('cph1_FVspmtERPStates_L_ErrMsgspmtERPStates').innerHTML = p[2];}catch(ex){}
        o.value='';
        o.focus();
      }
    },
    temp: function() {
    }
    }
</script>
