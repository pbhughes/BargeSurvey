'use strict';

$(document).ready(function () {
    
});

var app = angular.module('surveyApp', []).controller('SurveyController', function ($scope) {
    var surveys;
    $.ajax({
        async:false,
        url: 'api/Survey/List',
        type: 'GET',
        dataType: 'json',
        success: function (data, textStatus, xhr) {
            surveys = data;
        },
        error: function (xhr, textStatus, errorThrown) {
            console.log('Error in Get Customers');
            alert("failed");
        }
    });

    $scope.Surveys = surveys;
});






