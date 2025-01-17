Ext.define('CS.view.Synonyms', {
    extend: 'Ext.tab.Panel',
    alias: 'widget.cs.synonyms',
    height: 250,
    cls: 'text-class',
    frame: false,
    border: '0 0 0 0',
    autoScroll: false,
    collapsible: false,
    closable: false,
    showApproved: true,
    showConfirmed: true,
    showDeleted: false,
    showRejected: false,
    showUncertain: true,
    bodyStyle: 'background-color: #fff; padding-left: .5em;',
    tpl: new Ext.XTemplate(
        '<tpl if="this.hasSynonyms(values)">',
            '<ul>',
                '<tpl for="Synonyms">',
                    '<li>{Name}</li>',
                '</tpl>',
            '</ul>',
        '</tpl>',
        '<tpl if="!this.hasSynonyms(values)">',
            '<i>No synonyms</i>',
        '</tpl>',
        {
            hasSynonyms: function (values) {
                return values.Synonyms.length > 0;
            }
        }
    ),

    loadData: function (compound) {
        this.update('<i>Loading...</i>');

        //  clear existing tabs...
        this.removeAll();

        if (this.showApproved && compound.hasApprovedSynonyms()) 
            this.addTab("Approved", compound.getApprovedSynonyms());

        if (this.showConfirmed && compound.hasConfirmedSynonyms()) 
            this.addTab("Confirmed", compound.getConfirmedSynonyms());

        if (this.showDeleted && compound.hasDeletedSynonyms()) 
            this.addTab("Deleted", compound.getDeletedSynonyms());

        if (this.showRejected && compound.hasRejectedSynonyms()) 
            this.addTab("Rejected", compound.getRejectedSynonyms());

        if (this.showUncertain && compound.hasUncertaintSynonyms()) 
            this.addTab("Uncertain", compound.getUncertaintSynonyms());

        this.update('');
    },
    addTab: function (name, data) {
        this.add({
            title: name,
            items: {
                xtype: 'panel',
                id: this.id + '_panel' + this.items.getCount(),
                border: 0,
                padding: 0,
                tpl: new Ext.XTemplate(
                    '<ul class="zebra" style="overflow:auto; height:100%;">',
                        '<tpl for=".">',
                            '<li>{Name}</li>',
                        '</tpl>',
                    '</ul>'
                ),
                data: data
            }
        });
    }
});
