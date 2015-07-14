/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the dynamodbstreams-2012-08-10.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.DynamoDBv2.Model;

namespace Amazon.DynamoDBv2
{
    /// <summary>
    /// Interface for accessing DynamoDBStreams
    ///
    /// Amazon DynamoDB Streams 
    /// <para>
    /// This is the Amazon DynamoDB Streams API Reference. This guide describes the low-level
    /// API actions for accessing streams and processing stream records. For information about
    /// application development with DynamoDB Streams, see the <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide//Streams.html">Amazon
    /// DynamoDB Developer Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// Note that this document is intended for use with the following DynamoDB documentation:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/">Amazon
    /// DynamoDB Developer Guide</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/amazondynamodb/latest/APIReference/">Amazon DynamoDB
    /// API Reference</a> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The following are short descriptions of each low-level DynamoDB Streams API action,
    /// organized by function.
    /// </para>
    ///  <ul> <li>
    /// <para>
    /// <i>DescribeStream</i> - Returns detailed information about a particular stream.
    /// </para>
    /// </li> <li> 
    /// <para>
    /// <i>GetRecords</i> - Retrieves the stream records from within a shard.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// <i>GetShardIterator</i> - Returns information on how to retrieve the streams record
    /// from a shard with a given shard ID.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// <i>ListStreams</i> - Returns a list of all the streams associated with the current
    /// AWS account and endpoint.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonDynamoDBStreams : IDisposable
    {

        
        #region  DescribeStream

        /// <summary>
        /// Returns information about a stream, including the current status of the stream, its
        /// Amazon Resource Name (ARN), the composition of its shards, and its corresponding DynamoDB
        /// table.
        /// 
        ///  <note>
        /// <para>
        /// You can call <i>DescribeStream</i> at a maximum rate of 10 times per second.
        /// </para>
        /// </note> 
        /// <para>
        /// Each shard in the stream has a <code>SequenceNumberRange</code> associated with it.
        /// If the <code>SequenceNumberRange</code> has a <code>StartingSequenceNumber</code>
        /// but no <code>EndingSequenceNumber</code>, then the shard is still open (able to receive
        /// more stream records). If both <code>StartingSequenceNumber</code> and <code>EndingSequenceNumber</code>
        /// are present, the that shared is closed and can no longer receive more data.
        /// </para>
        /// </summary>
        /// <param name="streamArn">The Amazon Resource Name (ARN) for the stream.</param>
        /// 
        /// <returns>The response from the DescribeStream service method, as returned by DynamoDBStreams.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent stream.
        /// </exception>
        DescribeStreamResponse DescribeStream(string streamArn);

        /// <summary>
        /// Returns information about a stream, including the current status of the stream, its
        /// Amazon Resource Name (ARN), the composition of its shards, and its corresponding DynamoDB
        /// table.
        /// 
        ///  <note>
        /// <para>
        /// You can call <i>DescribeStream</i> at a maximum rate of 10 times per second.
        /// </para>
        /// </note> 
        /// <para>
        /// Each shard in the stream has a <code>SequenceNumberRange</code> associated with it.
        /// If the <code>SequenceNumberRange</code> has a <code>StartingSequenceNumber</code>
        /// but no <code>EndingSequenceNumber</code>, then the shard is still open (able to receive
        /// more stream records). If both <code>StartingSequenceNumber</code> and <code>EndingSequenceNumber</code>
        /// are present, the that shared is closed and can no longer receive more data.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStream service method.</param>
        /// 
        /// <returns>The response from the DescribeStream service method, as returned by DynamoDBStreams.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent stream.
        /// </exception>
        DescribeStreamResponse DescribeStream(DescribeStreamRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStream operation on AmazonDynamoDBStreamsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStream
        ///         operation.</returns>
        IAsyncResult BeginDescribeStream(DescribeStreamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStream.</param>
        /// 
        /// <returns>Returns a  DescribeStreamResult from DynamoDBStreams.</returns>
        DescribeStreamResponse EndDescribeStream(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRecords

        /// <summary>
        /// Retrieves the stream records from a given shard.
        /// 
        ///  
        /// <para>
        /// Specify a shard iterator using the <code>ShardIterator</code> parameter. The shard
        /// iterator specifies the position in the shard from which you want to start reading
        /// stream records sequentially. If there are no stream records available in the portion
        /// of the shard that the iterator points to, <code>GetRecords</code> returns an empty
        /// list. Note that it might take multiple calls to get to a portion of the shard that
        /// contains stream records.
        /// </para>
        ///  <note>
        /// <para>
        /// GetRecords can retrieve a maximum of 1 MB of data or 2000 stream records, whichever
        /// comes first.
        /// </para>
        /// </note>
        /// </summary>
        /// <param name="shardIterator">A shard iterator that was retrieved from a previous GetShardIterator operation. This iterator can be used to access the stream records in this shard.</param>
        /// 
        /// <returns>The response from the GetRecords service method, as returned by DynamoDBStreams.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.ExpiredIteratorException">
        /// The shard iterator has expired and can no longer be used to retrieve stream records.
        /// A shard iterator expires 15 minutes after it is retrieved using the <i>GetShardIterator</i>
        /// action.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// Your request rate is too high. The AWS SDKs for DynamoDB automatically retry requests
        /// that receive this exception. Your request is eventually successful, unless your retry
        /// queue is too large to finish. Reduce the frequency of requests and use exponential
        /// backoff. For more information, go to <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/ErrorHandling.html#APIRetries">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent stream.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TrimmedDataAccessException">
        /// The operation attempted to read past the oldest stream record in a shard.
        /// 
        ///  
        /// <para>
        /// In DynamoDB Streams, there is a 24 hour limit on data retention. Stream records whose
        /// age exceeds this limit are subject to removal (trimming) from the stream. You might
        /// receive a TrimmedDataAccessException if:
        /// </para>
        ///  <ul> <li>You request a shard iterator with a sequence number older than the trim
        /// point (24 hours).</li> <li>You obtain a shard iterator, but before you use the iterator
        /// in a <i>GetRecords</i> request, a stream record in the shard exceeds the 24 hour period
        /// and is trimmed. This causes the iterator to access a record that no longer exists.</li>
        /// </ul>
        /// </exception>
        GetRecordsResponse GetRecords(string shardIterator);

        /// <summary>
        /// Retrieves the stream records from a given shard.
        /// 
        ///  
        /// <para>
        /// Specify a shard iterator using the <code>ShardIterator</code> parameter. The shard
        /// iterator specifies the position in the shard from which you want to start reading
        /// stream records sequentially. If there are no stream records available in the portion
        /// of the shard that the iterator points to, <code>GetRecords</code> returns an empty
        /// list. Note that it might take multiple calls to get to a portion of the shard that
        /// contains stream records.
        /// </para>
        ///  <note>
        /// <para>
        /// GetRecords can retrieve a maximum of 1 MB of data or 2000 stream records, whichever
        /// comes first.
        /// </para>
        /// </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecords service method.</param>
        /// 
        /// <returns>The response from the GetRecords service method, as returned by DynamoDBStreams.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.ExpiredIteratorException">
        /// The shard iterator has expired and can no longer be used to retrieve stream records.
        /// A shard iterator expires 15 minutes after it is retrieved using the <i>GetShardIterator</i>
        /// action.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// Your request rate is too high. The AWS SDKs for DynamoDB automatically retry requests
        /// that receive this exception. Your request is eventually successful, unless your retry
        /// queue is too large to finish. Reduce the frequency of requests and use exponential
        /// backoff. For more information, go to <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/ErrorHandling.html#APIRetries">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent stream.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TrimmedDataAccessException">
        /// The operation attempted to read past the oldest stream record in a shard.
        /// 
        ///  
        /// <para>
        /// In DynamoDB Streams, there is a 24 hour limit on data retention. Stream records whose
        /// age exceeds this limit are subject to removal (trimming) from the stream. You might
        /// receive a TrimmedDataAccessException if:
        /// </para>
        ///  <ul> <li>You request a shard iterator with a sequence number older than the trim
        /// point (24 hours).</li> <li>You obtain a shard iterator, but before you use the iterator
        /// in a <i>GetRecords</i> request, a stream record in the shard exceeds the 24 hour period
        /// and is trimmed. This causes the iterator to access a record that no longer exists.</li>
        /// </ul>
        /// </exception>
        GetRecordsResponse GetRecords(GetRecordsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRecords operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRecords operation on AmazonDynamoDBStreamsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRecords
        ///         operation.</returns>
        IAsyncResult BeginGetRecords(GetRecordsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRecords operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRecords.</param>
        /// 
        /// <returns>Returns a  GetRecordsResult from DynamoDBStreams.</returns>
        GetRecordsResponse EndGetRecords(IAsyncResult asyncResult);

        #endregion
        
        #region  GetShardIterator

        /// <summary>
        /// Returns a shard iterator. A shard iterator provides information about how to retrieve
        /// the stream records from within a shard. Use the shard iterator in a subsequent <code>GetRecords</code>
        /// request to read the stream records from the shard.
        /// 
        ///  <note>
        /// <para>
        /// A shard iterator expires 15 minutes after it is returned to the requester.
        /// </para>
        /// </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetShardIterator service method.</param>
        /// 
        /// <returns>The response from the GetShardIterator service method, as returned by DynamoDBStreams.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent stream.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TrimmedDataAccessException">
        /// The operation attempted to read past the oldest stream record in a shard.
        /// 
        ///  
        /// <para>
        /// In DynamoDB Streams, there is a 24 hour limit on data retention. Stream records whose
        /// age exceeds this limit are subject to removal (trimming) from the stream. You might
        /// receive a TrimmedDataAccessException if:
        /// </para>
        ///  <ul> <li>You request a shard iterator with a sequence number older than the trim
        /// point (24 hours).</li> <li>You obtain a shard iterator, but before you use the iterator
        /// in a <i>GetRecords</i> request, a stream record in the shard exceeds the 24 hour period
        /// and is trimmed. This causes the iterator to access a record that no longer exists.</li>
        /// </ul>
        /// </exception>
        GetShardIteratorResponse GetShardIterator(GetShardIteratorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetShardIterator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetShardIterator operation on AmazonDynamoDBStreamsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetShardIterator
        ///         operation.</returns>
        IAsyncResult BeginGetShardIterator(GetShardIteratorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetShardIterator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetShardIterator.</param>
        /// 
        /// <returns>Returns a  GetShardIteratorResult from DynamoDBStreams.</returns>
        GetShardIteratorResponse EndGetShardIterator(IAsyncResult asyncResult);

        #endregion
        
        #region  ListStreams

        /// <summary>
        /// Returns an array of stream ARNs associated with the current account and endpoint.
        /// If the <code>TableName</code> parameter is present, then <i>ListStreams</i> will return
        /// only the streams ARNs for that table.
        /// 
        ///  <note>
        /// <para>
        /// You can call <i>ListStreams</i> at a maximum rate of 5 times per second.
        /// </para>
        /// </note>
        /// </summary>
        /// 
        /// <returns>The response from the ListStreams service method, as returned by DynamoDBStreams.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent stream.
        /// </exception>
        ListStreamsResponse ListStreams();

        /// <summary>
        /// Returns an array of stream ARNs associated with the current account and endpoint.
        /// If the <code>TableName</code> parameter is present, then <i>ListStreams</i> will return
        /// only the streams ARNs for that table.
        /// 
        ///  <note>
        /// <para>
        /// You can call <i>ListStreams</i> at a maximum rate of 5 times per second.
        /// </para>
        /// </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreams service method.</param>
        /// 
        /// <returns>The response from the ListStreams service method, as returned by DynamoDBStreams.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent stream.
        /// </exception>
        ListStreamsResponse ListStreams(ListStreamsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListStreams operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStreams operation on AmazonDynamoDBStreamsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStreams
        ///         operation.</returns>
        IAsyncResult BeginListStreams(ListStreamsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListStreams operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStreams.</param>
        /// 
        /// <returns>Returns a  ListStreamsResult from DynamoDBStreams.</returns>
        ListStreamsResponse EndListStreams(IAsyncResult asyncResult);

        #endregion
        
    }
}