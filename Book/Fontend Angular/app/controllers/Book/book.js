var app = angular.module('my-app', []);
app.controller('bookAddCtrl',function($scope,$http){
  $scope.createBook = function(){
      var data = {
        BookName:$scope.bookname, 
        PublisherName:$scope.publishername, 
        PublisherAge:$scope.publisherage, 
        PageNo:$scope.pageno,
        PublishDate:$scope.publishdate,
        BookType:$scope.booktype,
    };
      $http.post("https://localhost:44373/api/book/add",data).then(function(resp){
          //debugger;
          alert("Data Insert Successfull");
      },function(err){
          //debugger;
          alert(err);
          
      })
  };
});