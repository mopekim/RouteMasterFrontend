﻿const brief = {
    data() {
        return {
            bfVM: [],           




        }
    },
    //created: function () {
    //    let _this = this;
    //},
    //mounted: function () {
    //    let _this = this;
    //   
    //},
    methods: {
        commentBrief: function (id) {
            var request = {};
            let _this = this;
            console.log(id);
            var uri = `https://localhost:7145/Comments_Accommodation/Index?stayId=${id}`;
            axios.get(uri).then(response => {
                _this.bfVM = response.data;
                console.log(_this.bfVM);
            }

            ).catch(err => {
                alert(err);
            });

        },      
              
    },
    template: `<div class="row g-3 mt-2 mb-3">
            <div v-for="(text, num) in bfVM" :key="num" class="col-md-4">
                <div class="card overflow-auto" style="max-height: 180px;">
                    <div class="card-body">
                        <div class="d-flex">
                            <h5 class="card-title me-auto">{{text.account}}</h5>
                            <p class="card-text fs-6">{{text.score}}<i class="fa fa-star fa-fw" style="color:#f90;"></i></p>
                        </div>
                        <div class="d-flex">
                            <p class="card-text me-auto fs-5">{{text.title}}</p>
                            <p class="card-text fs-6"><i class="fa-solid fa-thumbs-up"></i> {{text.totalThumbs}}</p>
                        </div>
                    </div>
                </div>
            </div>                
        </div>`

                       




};